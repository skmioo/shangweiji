using System;
using System.Collections.Generic;
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
		delegate void ShowTip(string data);
		AddOnline addOnline;
		ShowTip showTip;
		Dictionary<string, Socket> Clients = new Dictionary<string, Socket>();
		public FormTcpServer()
		{
			InitializeComponent();
			addOnline = AddOnlineToListBox;
			showTip = ShowTipToText;
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
				Invoke(showTip, "服务器开启成功");
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
				Invoke(showTip, clientName + "上线");
				Clients.Add(clientName, client);
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
					Invoke(showTip, clientName + "下线");
					if (Clients.ContainsKey(clientName))
					{
						Clients.Remove(clientName);
					}
					//停止改客户端的数据接收
					break;
				}
				else if(length > 0)
				{
					string str = Encoding.UTF8.GetString(arr, 0, length);
					string clientName = client.RemoteEndPoint.ToString();
					string Msg = "[接收] " + clientName + "   " + str;
					Invoke(showTip, Msg);
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


		private void ShowTipToText(string data)
		{
			txt_Tip.AppendText(data + Environment.NewLine);
		}

		private void btn_sendmsg_Click(object sender, EventArgs e)
		{
			string txt = txt_send.Text.Trim();
			if (string.IsNullOrEmpty(txt))
			{
				MessageBox.Show("请设置发送内容");
				return;
			}
			if (this.lbOnline.SelectedItems.Count == 0)
			{
				MessageBox.Show("请选择您要发送的对象");
				return;
			}
			byte[] arrMsg = Encoding.UTF8.GetBytes(txt);
			foreach (string item in this.lbOnline.SelectedItems)
			{
				Clients[item].Send(arrMsg);
				string Msg = "[发送] " + item + "   " + txt;
				Invoke(showTip, Msg);
			}
		}

		private void btn_send_msg_all_Click(object sender, EventArgs e)
		{
			string txt = txt_send.Text.Trim();
			if (string.IsNullOrEmpty(txt))
			{
				MessageBox.Show("请设置发送内容");
				return;
			}
			byte[] arrMsg = Encoding.UTF8.GetBytes(txt);
			foreach (string item in Clients.Keys)
			{
				Clients[item].Send(arrMsg);
				string Msg = "[发送] " + item + "   " + txt;
				Invoke(showTip, Msg);
			}
			Invoke(showTip, "[群发] 完毕!");
		}
	}
}
