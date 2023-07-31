using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SocketTcp
{
	delegate void FileSaveDelegate(byte[] bt, int length);
	public partial class FormTcpClient : Form
	{
		delegate void ShowTip(string data);
		ShowTip showTip;
		//文件保存委托对象
		FileSaveDelegate MyFileSave;
		public FormTcpClient()
		{
			InitializeComponent();
			showTip = ShowTipToText;
			FormClosing += OnFormClose;
			MyFileSave = FileSave;
		}

		private void OnFormClose(object sender, FormClosingEventArgs e)
		{
			isRunning = false;
			thrReciveServer.Abort();
			thrReciveServer = null;
			if (socket != null)
			{ 
				socket.Close();
				socket = null;
			}
		}

		//创建套接字
		Socket socket = null;
		Thread thrReciveServer;
		private void btn_LinkServer_Click(object sender, EventArgs e)
		{
			btn_LinkServer.Enabled = false;
			//创建负责监听的套接字，InterNetwork（IPV4）字节流的 Tcp
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			IPAddress address = IPAddress.Parse(txt_ip.Text.Trim());
			//根据IPAddress以及端口号创建IPEndPoint
			IPEndPoint endPoint = new IPEndPoint(address, int.Parse(txt_port.Text.Trim()));
			try
			{
				Invoke(showTip, "连接服务器中...");
				socket.Connect(endPoint);				
				Invoke(showTip, "连接服务器成功");
			}
			catch (Exception ex)
			{
				MessageBox.Show("连接服务器失败" + ex.Message);
				return;
			}
			thrReciveServer = new Thread(reciveDataFromServer);
			thrReciveServer.IsBackground = true;
			thrReciveServer.Start(socket);
		}
		bool isRunning;
		private void reciveDataFromServer(object data)
		{
			Socket server = (Socket)data;
			isRunning = true;
			while (isRunning)
			{
				//定义一个2M的缓冲区
				byte[] arr = new byte[2 * 1024 * 1024];
				int length = -1;
				try {
					length = server.Receive(arr);
				} catch (Exception e)
				{
					ServerUnLink(server);
					break;
				}
				if (length == 0)
				{
					//客户端断开连接
					ServerUnLink(server);
					//停止改客户端的数据接收
					break;
				}
				else if (length > 0)
				{
					if (arr[0] == 0)
					{ 
						string str = Encoding.UTF8.GetString(arr, 0, length);
						string serverName = server.RemoteEndPoint.ToString();
						string Msg = "[接收] " + serverName + "   " + str;
						Invoke(showTip, Msg);
					}
					if (arr[0] == 1)
					{
						Invoke(MyFileSave, arr, length);
					}
				}
			}
		}

		private void ServerUnLink(Socket server)
		{
			string serverName = server.RemoteEndPoint.ToString();
			Invoke(showTip, serverName + "断开连接");
			socket = null;
			isRunning = false;
		}

		private void ShowTipToText(string data)
		{
			txt_Tip.AppendText(data + Environment.NewLine);
		}

		private void btn_send_msg_Click(object sender, EventArgs e)
		{
			if(socket == null)
			{
				MessageBox.Show("请先连接服务器");
				return;
			}
			string Msg = "[发送] " + txt_client_name + "   " + txt_send.Text;
			byte[] arrMsg = Encoding.UTF8.GetBytes(Msg);			
			socket.Send(arrMsg);			
			Invoke(showTip, Msg);
			
		}

		private void btn_send_file_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(txt_file.Text))
			{
				MessageBox.Show("请选择您要发送的文件！", "发送文件提示");
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
				socket.Send(arrSend);

				byte[] arrfileSend = new byte[1024 * 1024 * 2];
				int length = fs.Read(arrfileSend, 0, arrfileSend.Length);

				byte[] arrfile = new byte[length + 1];
				arrfile[0] = 1;
				Buffer.BlockCopy(arrfileSend, 0, arrfile, 1, length);
				socket.Send(arrfile);
			}

		}

		#region 委托方法体
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
		#endregion

		private void btn_selectfile_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.InitialDirectory = "D:\\";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				txt_file.Text = ofd.FileName;
			}
		}
	}
}
