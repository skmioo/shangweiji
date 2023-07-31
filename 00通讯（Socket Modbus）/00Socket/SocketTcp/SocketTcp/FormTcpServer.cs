using System;
using System.Collections.Generic;
using System.IO;
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
		//文件保存委托对象
		FileSaveDelegate MyFileSave;
		Dictionary<string, Socket> Clients = new Dictionary<string, Socket>();
		public FormTcpServer()
		{
			InitializeComponent();
			addOnline = AddOnlineToListBox;
			showTip = ShowTipToText;
			MyFileSave = FileSave;
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
				try
				{
					length = client.Receive(arr);

					if (length == 0)
					{
						HandleClientUnLink(client);
						//停止改客户端的数据接收
						break;
					}
					else if (length > 0)
					{
						if (arr[0] == 0)
						{
							string str = Encoding.UTF8.GetString(arr, 0, length);
							string clientName = client.RemoteEndPoint.ToString();
							string Msg = "[接收] " + clientName + "   " + str;
							Invoke(showTip, Msg);
						}
						if (arr[0] == 1)
						{
							Invoke(MyFileSave, arr, length);
						}						
					}
				}
				catch (Exception Ex)
				{
					HandleClientUnLink(client);
					//停止改客户端的数据接收
					break;
				}
			}			
		}

		private void HandleClientUnLink(Socket client)
		{

			//客户端断开连接
			string clientName = client.RemoteEndPoint.ToString();
			Invoke(addOnline, clientName, false);
			Invoke(showTip, clientName + "下线");
			if (Clients.ContainsKey(clientName))
			{
				Clients.Remove(clientName);
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

		private void btn_OpenClient_Click(object sender, EventArgs e)
		{
			FormTcpClient form = new FormTcpClient();
			form.Show();
		}

		private void btn_selectfile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = "D:\\";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				txt_file.Text = ofd.FileName;
			}
		}

		private void btn_sendfile_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_file.Text))
			{
				MessageBox.Show("请选择您要发送的文件！", "发送文件提示");
				return;
			}
			string online = this.lbOnline.Text.Trim();
			if (string.IsNullOrEmpty(online))
			{
				MessageBox.Show("请选择您要发送的对象！", "发送文件提示");
				return;
			}
			using (FileStream fs = new FileStream(txt_file.Text, FileMode.Open))
			{
				string filename = Path.GetFileName(txt_file.Text);
				string StrMsg = "发送文件为：" + filename;
				byte[] arrMsg = Encoding.UTF8.GetBytes(StrMsg);
				byte[] arrSend = new byte[arrMsg.Length + 1];
				arrSend[0] = 0;
				Buffer.BlockCopy(arrMsg, 0, arrSend, 1, arrMsg.Length);
				Clients[online].Send(arrSend);

				byte[] arrfileSend = new byte[1024 * 1024 * 2];
				int length = fs.Read(arrfileSend, 0, arrfileSend.Length);

				byte[] arrfile = new byte[length + 1];
				arrfile[0] = 1;
				Buffer.BlockCopy(arrfileSend, 0, arrfile, 1, length);
				Clients[online].Send(arrfile);
			}
		}

		private void FileSave(byte[] bt, int length)
		{
			try
			{
				SaveFileDialog sfd = new SaveFileDialog();
				sfd.Filter = "word files(*.docx)|*.docx|txt files(*.txt)|*.txt|xls files(*.xls)|*.xls|All files(*.*)|*.*";
				if (sfd.ShowDialog() == DialogResult.OK)
				{
					string fileSavePath = sfd.FileName;

					using (FileStream fs = new FileStream(fileSavePath, FileMode.Create))
					{
						fs.Write(bt, 1, length - 1);
						Invoke(new Action(() => this.txt_Tip.AppendText("[保存]     保存文件成功" + fileSavePath + Environment.NewLine)));
					}

				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("保存异常" + ex.Message, "保存文件出现异常");
			}
		}

	}

}
