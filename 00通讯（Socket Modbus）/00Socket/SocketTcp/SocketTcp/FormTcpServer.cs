using System;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;

namespace SocketTcp
{
	public partial class FormTcpServer : Form
	{
		delegate void AddOnline(string ip);
		AddOnline addOnline;
		public FormTcpServer()
		{
			InitializeComponent();
			addOnline = AddOnlineToListBox;
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
				MessageBox.Show("开启服务成功", "打开服务");
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
				Socket client = socket.Accept();
				if(client != null)
				{
					Invoke(addOnline, client.RemoteEndPoint.ToString());
				}
			}
		}

		private void AddOnlineToListBox(string url)
		{
			lbOnline.Items.Add(url);
		}
	}
}
