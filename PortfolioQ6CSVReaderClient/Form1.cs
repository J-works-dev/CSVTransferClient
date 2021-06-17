using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortfolioQ6CSVReaderClient
{
    public partial class Form1 : Form
    {
        private Pipe pipeClient;

        public Form1()
        {
            InitializeComponent();
            CreateNewPipeClient();
            clientStart();
        }

        void CreateNewPipeClient()
        {
            if (pipeClient != null)
            {
                pipeClient.MessageReceived -= pipeClient_MessageReceived;
                pipeClient.ServerDisconnected -= pipeClient_ServerDisconnected;
            }

            pipeClient = new Pipe();
            pipeClient.MessageReceived += pipeClient_MessageReceived;
            pipeClient.ServerDisconnected += pipeClient_ServerDisconnected;
        }

        void pipeClient_ServerDisconnected()
        {
            Invoke(new Pipe.ServerDisconnectedHandler(ServerDisconnected));
        }

        void ServerDisconnected()
        {
            statusStrip.Text = "Client Disconnected!";
        }

        void pipeClient_MessageReceived(byte[] message)
        {
            Invoke(new Pipe.MessageReceivedHandler(DisplayReceivedMessage),
                new object[] { message });
        }

        void DisplayReceivedMessage(byte[] message)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            string str = encoder.GetString(message, 0, message.Length);

            if (str == "close")
            {
                pipeClient.Disconnect();

                //CreateNewPipeClient();
                //pipeClient.Connect(textBoxPipeName.Text);
                statusLabel.Text = "Server Closed";
            }
            textBoxMessages.Text += str + "\r\n";
        }

        private void buttonSendM_Click(object sender, EventArgs e)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();

            pipeClient.SendMessage(encoder.GetBytes(textBoxSend.Text));
            textBoxSend.Clear();
        }

        private void buttonSendCSV_Click(object sender, EventArgs e)
        {

        }

        private void buttonSaveCSV_Click(object sender, EventArgs e)
        {

        }

        private void clientStart()
        {
            pipeClient.Connect(textBoxPipeName.Text);
        }

        private void textBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSendM_Click(this, new EventArgs());
            }
        }
    }
}
