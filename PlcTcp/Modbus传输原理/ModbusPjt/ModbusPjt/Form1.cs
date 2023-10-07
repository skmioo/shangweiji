using Modbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModbusPjt
{
	public partial class Form1 : Form
	{
		//Modbus Poll
		public string 主PortName = "COM19";
		//Modbus Slave
		public string 从PortName = "COM20";
		public Form1()
		{
			InitializeComponent();
			
		}
		ModbusRtu ModbusRtu = new ModbusRtu();
		private void btn_connect_Click(object sender, EventArgs e)
		{
			try
			{
				//自己绑定的是主端口，软件Virtual Serial Port中设置了主Port与从Port的连接
				//此时使用Modbus Slave 设置端口为从端口，那么就可以传输数据
				ModbusRtu.Connect(主PortName, 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
			}
			catch (Exception)
			{
				MessageBox.Show("连接失败");
				return;
			}
			MessageBox.Show("连接成功");
		}

		private void btn_disconnect_Click(object sender, EventArgs e)
		{
			ModbusRtu.DisConnect();
		}

		private void btn_read_outputstatus_Click(object sender, EventArgs e)
		{
			byte[] response = ModbusRtu.ReadOutputStatus(Convert.ToByte(this.tb_slaveId.Text), Convert.ToUInt16(this.tb_startaddress.Text), Convert.ToUInt16(this.tb_readLength.Text));
			if (response != null)
			{
				bool[] boolRes = GetBitArrayFromByteArray(response);
				StringBuilder sb = new StringBuilder();
				for (int i = 0; i < Convert.ToUInt16(this.tb_readLength.Text); i++)
				{
					sb.Append(boolRes[i].ToString());
					sb.Append(" ");
				}
				this.rtb_msg.AppendText( sb.ToString() + Environment.NewLine);
			}
		}

		/// <summary>
		/// 将一个字节转换成bool数组
		/// </summary>
		/// <param name="b"></param>
		/// <param name="reverse"></param>
		/// <returns></returns>
		public bool[] GetBitArrayFromByte(byte b, bool reverse = false)
		{
			bool[] array = new bool[8];
			if (reverse)
			{
				for (int i = 7; i >= 0; i--)
				{
					array[i] = (b & 0x1) == 1;
					b = (byte)(b >> 1);
				}
			} else
			{
				for (int i = 0; i < 8; i++)
				{
					array[i] = (b & 0x1) == 1;
					b = (byte)(b >> 1);
				}
			}
			return array;
		}

		/// <summary>
		/// 将一个字节数组转换为bool数组
		/// </summary>
		/// <param name="b"></param>
		/// <param name="reverse"></param>
		/// <returns></returns>
		private bool[] GetBitArrayFromByteArray(byte[] b, bool reverse = false)
		{
			List<bool> res = new List<bool>();
			foreach (var item in b)
			{
				res.AddRange(GetBitArrayFromByte(item, reverse));
			}
			return res.ToArray();
		}

	}
}
