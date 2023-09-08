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
		
		}
		#region 客户端程序
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
					Invoke(new Action(() =>     
					{
						foreach (Control item in this.tabPage1.Controls)
						{
							if (item is TextShow ls)
							{
								ls.VarValue = ParseData(ls, result);
							}
						}
					}));				
				}
			}
		}

		public string ParseData(TextShow ls, byte[] result)
		{
			string VarValue = string.Empty;
			switch (ls.DataType)
			{
				case DataType.Bool:
					VarValue = BitLib.GetBitFromByteArray(result, ls.Start, ls.Offset).ToString();
					break;
				case DataType.Byte:
					VarValue = ByteLib.GetByteFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.Short:
					VarValue = ShortLib.GetShortFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.UShort:
					VarValue = UShortLib.GetUShortFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.Int:
					VarValue = IntLib.GetIntFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.UInt:
					VarValue = UIntLib.GetUIntFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.Float:
					VarValue = FloatLib.GetFloatFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.Double:
					VarValue = DoubleLib.GetDoubleFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.Long:
					VarValue = LongLib.GetLongFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.ULong:
					VarValue = ULongLib.GetULongFromByteArray(result, ls.Start).ToString();
					break;
				case DataType.String:
					VarValue = StringLib.GetStringFromByteArrayByBitConvert(result, ls.Start, ls.Offset).ToString();
					break;
				case DataType.ByteArray:
					VarValue = ByteArrayLib.GetByteArrayFromByteArray(result, ls.Start, ls.Offset).ToString();
					break;
			}
			return VarValue;
		}

		/// <summary>
		/// 在TextShow上读取某一个值
		/// </summary>
		/// <param name="result"></param>
		
		//创建取消数据源
		private CancellationTokenSource cts = new CancellationTokenSource();
		#endregion

		#region 服务器程序
		Socket TcpServer;
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.btn_startServer.Text == "打开")
			{
				TcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
				EndPoint EP = new IPEndPoint(IPAddress.Parse(this.tb_server_ip.Text), int.Parse(this.tb_server_port.Text));
				try
				{
					TcpServer.Bind(EP);
				}
				catch (Exception ex)
				{
					MessageBox.Show("开启服务器失败:" + ex.Message);
					return;
				}
				this.btn_startServer.Text = "关闭";
				TcpServer.Listen(5);
				Task.Run(new Action(()=> {
					ListenConnect();
				}));
			}
			else if (this.btn_startServer.Text == "关闭")
			{
				TcpServer?.Close();
				this.btn_startServer.Text = "打开";
			}

		}

		private void ListenConnect()
		{
			while (true)
			{
				Socket tcpClient = TcpServer.Accept();
				Task.Run(new Action(()=> {
					ReciveFromPlc(tcpClient);
				}));
			}
		}

		private void ReciveFromPlc(Socket tcpClient)
		{
			while (true)
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
					byte[] result = ByteArrayLib.GetByteArrayFromByteArray(buffer, 0, length);		
					Invoke(new Action(() =>
					{
						foreach (Control item in this.tabPage2.Controls)
						{
							if (item is TextShow ls)
							{
								ls.VarValue = ParseData(ls, result);
							}
						}
					}));
				}
			}
			
		}
		#endregion

		private void textShow2_Load(object sender, EventArgs e)
		{

		}
	}
}
