using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SocketTcp
{
	public partial class FormTcpServer : Form
	{
		delegate void AddOnline(string ip, bool v);
		delegate void ReciceData(string data);
		AddOnline addOnline;
		ReciceData reciceData;
		public FormTcpServer()
		{
			InitializeComponent();
			addOnline = AddOnlineToListBox;
			reciceData = ReciceDataToText;
		}

		//创建套接字
		Socket socket = null;

		//创建负责监听客户端连接的线程
		Thread threadListen = null;

		private void btn_startserver_Click(object sender, EventArgs e)
		{
			//创建负责监听的套接字，InterNetwork（IPV4）字节流的 Tcp
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPAddress address = IPAddress.Parse(txt_ip.Text.Trim());
			//根据IPAddress以及端口号创建IPEndPoint
			IPEndPoint endPoint = new IPEndPoint(address, int.Parse(txt_port.Text.Trim()));

			try
			{
				socket.Bind(endPoint);				
				Invoke(reciceData, "服务器开启成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("开启服务失败" + ex.Message, "打开服务");
				return;
			}

			socket.Listen(10);
			threadListen = new Thread(ListenConnecting);
			threadListen.IsBackground = true;
			threadListen.Start();
			btn_startserver.Enabled = false;
		}

		private void ListenConnecting()
		{
			while (true)
			{
				//Accept是阻塞函数，在没有接收到客户端时，会一直处于阻塞状态
				Socket client = socket.Accept();
				string clientName = client.RemoteEndPoint.ToString();
				Invoke(addOnline, clientName, true);
				Invoke(reciceData, clientName + "上线");
				//开启接受线程
				Thread thr = new Thread(ReciveMsg);
				thr.IsBackground = true;
				thr.Start(client);
			}
		}

		private void ReciveMsg(object data)
		{
			Socket client = (Socket)data;
			while (true)
			{
				//定义一个2M的缓冲区
				byte[] arr = new byte[2 * 1024 * 1024];
				int length = -1;
				length = client.Receive(arr);
				if (length == 0)
				{
					//客户端断开连接
					string clientName = client.RemoteEndPoint.ToString();
					Invoke(addOnline, clientName, false);
					Invoke(reciceData, clientName + "下线");
					//停止改客户端的数据接收
					break;
				}
				else if(length > 0)
				{
					string str = Encoding.UTF8.GetString(arr, 0, length);
					Invoke(reciceData, str);
				}
			}
			
		}

		private void AddOnlineToListBox(string url, bool isAdd)
		{
			if (isAdd)
			{
				lbOnline.Items.Add(url);
			}
			else
			{
				lbOnline.Items.Remove(url);
			}
		}


		private void ReciceDataToText(string data)
		{
			txt_revice.AppendText(data + Environment.NewLine);
		}
	}
}
