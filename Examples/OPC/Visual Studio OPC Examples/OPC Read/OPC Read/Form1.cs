using NationalInstruments;
using NationalInstruments.Net;
using System;
using System.Windows.Forms;

namespace OPC_Read
{
    public partial class Form1 : Form
    {
        DataSocket dataSocket = new DataSocket();

        public Form1()
        {
            InitializeComponent();

            string opcUrl;
            opcUrl = "opc://localhost/MATRIKON.OPC.Simulation/Bucket Brigade.Real4";


            if (dataSocket.IsConnected)
                dataSocket.Disconnect();

            dataSocket.Connect(opcUrl, AccessMode.Read);
        }

        private void btnReadOpc_Click(object sender, EventArgs e)
        {

            dataSocket.Update();

            txtReadOpcValue.Text = dataSocket.Data.Value.ToString();
        }
    }
}
