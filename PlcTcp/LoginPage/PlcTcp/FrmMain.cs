using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Server;
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
			//获取所有ip
			var Ips = Dns.GetHostAddressesAsync(Dns.GetHostName());
			List<string> iplist = new List<string>();
			iplist.Add("127.0.0.1");
			foreach (IPAddress iP in Ips.Result)
			{
				if (iP.AddressFamily == AddressFamily.InterNetwork)
				{
					iplist.Add(iP.ToString());
				}
			}
			if (iplist.Count > 0)
			{
				this.cb_mqtt_ip.DataSource = iplist;
				this.cb_mqtt_ip.SelectedIndex = 0;
			}
			this.tabControl1.SelectedIndex = 2;
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
		List<Socket> clients = new List<Socket>();

		private void ListenConnect()
		{
			while (true)
			{
				Socket tcpClient = TcpServer.Accept();
				Task.Run(new Action(()=> {
					clients.Add(tcpClient);
					ReciveFromPlc(tcpClient);
				}));
			}
		}
		byte[] SetBuffer;
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
				if (length == 110)
				{
					byte[] result = ByteArrayLib.GetByteArrayFromByteArray(buffer, 0, length);
					SetBuffer = ByteArrayLib.GetByteArrayFromByteArray(buffer,100,10);
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
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (clients.Count > 0)
			{
				float val = Convert.ToSingle(this.tb_send_data.Text);
				byte[] b = ByteArrayLib.GetByteArrayFromFloat(val);
				byte[] set = ByteArrayLib.SetByteArray(SetBuffer, val, 0,0);
				int send = clients[0].Send(set);
			}
		}

		#endregion


		#region MQTT Server

		private IMqttServer mqttServer;
		MqttFactory _mqttFactory;
		MqttFactory mqttFactory {
			get {
				if (_mqttFactory == null)
					_mqttFactory = new MqttFactory();
				return _mqttFactory;
			}
		}
		private void btn_mqtt_start_Click(object sender, EventArgs e)
		{
			if (mqttServer != null)
				return;
			mqttServer = mqttFactory.CreateMqttServer();
			var optionBuilder = new MqttServerOptionsBuilder();
			//允许多少个同时连接
			optionBuilder.WithConnectionBacklog(10);
			optionBuilder.WithDefaultEndpointPort(Convert.ToInt32(this.tb_mqtt_port.Text));
			optionBuilder.WithDefaultEndpointBoundIPAddress(IPAddress.Parse(this.cb_mqtt_ip.Text));
			var option = optionBuilder.Build() as MqttServerOptions;

			//添加验证
			option.ConnectionValidator += (MqttConnectionValidatorContext context) => {
				if (context.Username == "admin" && context.Password == "123456")
				{
					context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionAccepted;
				}
				else
				{
					context.ReturnCode = MQTTnet.Protocol.MqttConnectReturnCode.ConnectionRefusedIdentifierRejected;
				}
			};

			mqttServer.ClientConnected += MqttServer_ClientConnected;
			mqttServer.ClientDisconnected += MqttServer_ClientDisconnected;
			mqttServer.ClientSubscribedTopic += MqttServer_ClientSubscribedTopic;
			mqttServer.ClientUnsubscribedTopic += MqttServer_ClientUnsubscribedTopic;
			mqttServer.ApplicationMessageReceived += MqttServer_ApplicationMessageReceived;
			mqttServer.Started += MqttServer_Started;
			mqttServer.Stopped += MqttServer_Stopped;
			mqttServer.StartAsync(option);
		}

		private void btn_mqtt_stop_Click(object sender, EventArgs e)
		{
			if (mqttServer == null)
				return;
			mqttServer.StopAsync();
			mqttServer = null;
		}

		private void MqttServer_Stopped(object sender, EventArgs e)
		{
			MqttTip("服务器停止");		
		}

		private void MqttServer_Started(object sender, EventArgs e)
		{
			MqttTip("服务器开启");
		}

		private void MqttServer_ApplicationMessageReceived(object sender, MqttApplicationMessageReceivedEventArgs e)
		{
		
		}

		private void MqttServer_ClientUnsubscribedTopic(object sender, MQTTnet.Server.MqttClientUnsubscribedTopicEventArgs e)
		{
		
		}

		private void MqttServer_ClientSubscribedTopic(object sender, MQTTnet.Server.MqttClientSubscribedTopicEventArgs e)
		{
		}

		private void MqttServer_ClientDisconnected(object sender, MQTTnet.Server.MqttClientDisconnectedEventArgs e)
		{
		
		}

		private void MqttServer_ClientConnected(object sender, MQTTnet.Server.MqttClientConnectedEventArgs e)
		{

		}

		private void MqttTip(string tip)
		{
			this.mqtt_tip.Text = tip;
		}
		#endregion

		#region MQTT Client
		IMqttClient mqttClient;
		private void btn_matt_Connect_Click(object sender, EventArgs e)
		{
			if (mqttClient != null)
				return;
			mqttClient = mqttFactory.CreateMqttClient();
			var option = new MqttClientOptions() { ClientId = Guid.NewGuid().ToString("D") };
			option.ChannelOptions = new MqttClientTcpOptions()
			{
				Server = this.tb_Client_Link_IP.Text,
				Port = Convert.ToInt32(this.tb_connect_port.Text)
			};
			option.Credentials = new MqttClientCredentials()
			{
				Username = tb_account.Text,
				Password = tb_password.Text
			};
			option.CleanSession = true;
			option.KeepAlivePeriod = TimeSpan.FromSeconds(100);
			option.KeepAliveSendInterval = TimeSpan.FromSeconds(10000);
			mqttClient.Connected += MqttClient_Connected;
			mqttClient.Disconnected += MqttClient_Disconnected; ;
			mqttClient.ConnectAsync(option);
		}

		private void MqttClient_Disconnected(object sender, MQTTnet.Client.MqttClientDisconnectedEventArgs e)
		{
			MqttClientTip("断开连接");
		}

		private void MqttClient_Connected(object sender, MQTTnet.Client.MqttClientConnectedEventArgs e)
		{
			MqttClientTip("连接成功");
		}

		private void MqttClientTip(string tip)
		{			
			Invoke(new Action(()=>{
				this.tb_mqtt_client_tip.Text = tip;
			}));
		}
		private void btn_mqtt_disconnect_Click(object sender, EventArgs e)
		{
			if (mqttClient == null)
				return;
			mqttClient.DisconnectAsync();
			mqttClient = null;
		}

		private void publishTimer_Tick(object sender, EventArgs e)
		{
			
		}

		/// <summary>
		/// 向服务器某个订阅(Topic)发送消息
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void btn_publish_Click(object sender, EventArgs e)
		{
			MqttApplicationMessage message = new MqttApplicationMessage()
			{
				//Topic = 某个订阅名,
				Topic = "thinger",
				Payload = Encoding.UTF8.GetBytes(DateTime.Now.Second.ToString()),
				QualityOfServiceLevel = MQTTnet.Protocol.MqttQualityOfServiceLevel.AtLeastOnce,
				Retain = false
			};

			mqttClient.PublishAsync(message);
		}

		xktComm.SiemensS7 objD7 = new xktComm.SiemensS7();


		/// <summary>
		/// 连接西蒙子
		/// </summary>
		public void LinkSiemensS7()
		{
			objD7.Connect("127.0.0.1",xktComm.Common.CPU_Type.S7200SMART, 0, 0);
		}

		/// <summary>
		/// 读取西蒙子的值
		/// </summary>
		/// <returns></returns>
		public string readSiemensS7()
		{
			return objD7.Read("DB1.DBD0", xktComm.Common.VarType.Real).ToString();
		}
		#endregion


	}
}
