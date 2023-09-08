using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;

namespace PlcTcp
{
	public partial class FrmMain : Form
	{
		public FrmMain()
		{
			InitializeComponent();
			delShowReadData = ShowReadData;
		}

		//创建Socket;
		Socket tcpClient; 
		private void btn_connect_Click(object sender, EventArgs e)
		{
			if (this.btn_connect.Text == "连接")
			{
				tcpClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				EndPoint EP = new IPEndPoint(IPAddress.Parse(this.tb_plc_ip.Text), int.Parse(this.tb_plc_port.Text));
				try
				{
					tcpClient.Connect(EP);
				}
				catch (Exception ex)
				{
					MessageBox.Show("连接失败:" + ex.Message);
					return;
				}
				//MessageBox.Show("连接成功!");	
				this.btn_connect.Text = "断开";
				Task.Run(()=> {
					GetPLCValue();
				});
			}
			else if(this.btn_connect.Text == "断开")
			{
				this.btn_connect.Text = "连接";
				tcpClient?.Close();
				cts.Cancel();
			}
		}

		private void GetPLCValue()
		{
			while (!cts.IsCancellationRequested)
			{
				byte[] buffer = new byte[1024 * 10];
				int length = -1;
				try
				{
					length = tcpClient.Receive(buffer, SocketFlags.None);
				}
				catch (Exception e)
				{
					break;
				}
				if (length == 100)
				{
					byte[] result = ByteArrayLib.GetByteArrayFromByteArray(buffer,0, length);
					//float f = FloatLib.GetFloatFromByteArray(result,0, DataFormat.ABCD);
					delShowReadData?.Invoke(result);
				}
			}
		}
		delegate void DelShowReadData(byte[] data);
		DelShowReadData delShowReadData;
		/// <summary>
		/// 在TextShow上读取某一个值
		/// </summary>
		/// <param name="result"></param>
		private void ShowReadData(byte[] result)
		{
			foreach (Control item in this.tabPage1.Controls)
			{
				if (item is TextShow ls)
				{
					switch (ls.DataType)
					{
						case DataType.Bool:
							ls.VarValue = BitLib.GetBitFromByteArray(result, ls.Start, ls.Offset).ToString();
							break;
						case DataType.Byte:
							ls.VarValue = ByteLib.GetByteFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.Short:
							ls.VarValue = ShortLib.GetShortFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.UShort:
							ls.VarValue = UShortLib.GetUShortFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.Int:
							ls.VarValue = IntLib.GetIntFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.UInt:
							ls.VarValue = UIntLib.GetUIntFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.Float:
							ls.VarValue = FloatLib.GetFloatFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.Double:
							ls.VarValue = DoubleLib.GetDoubleFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.Long:
							ls.VarValue = LongLib.GetLongFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.ULong:
							ls.VarValue = ULongLib.GetULongFromByteArray(result, ls.Start).ToString();
							break;
						case DataType.String:
							ls.VarValue = StringLib.GetStringFromByteArrayByBitConvert(result, ls.Start, ls.Offset).ToString();
							break;
						case DataType.ByteArray:
							ls.VarValue = ByteArrayLib.GetByteArrayFromByteArray(result, ls.Start, ls.Offset).ToString();
							break;
					}
				}
			}
		}

		//创建取消数据源
		private CancellationTokenSource cts = new CancellationTokenSource();
	}
}
