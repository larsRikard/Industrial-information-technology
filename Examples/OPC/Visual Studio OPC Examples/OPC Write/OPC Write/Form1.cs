using NationalInstruments;
using NationalInstruments.Net;
using System;
using System.Windows.Forms;

namespace OPC_Write
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

            dataSocket.Connect(opcUrl, AccessMode.Write);
        }

        private void btnWriteOpc_Click(object sender, EventArgs e)
        {

            double opcValue = 0;

            opcValue = Convert.ToDouble(txtWriteOpcValue.Text);

            dataSocket.Data.Value = opcValue;

            dataSocket.Update();
        }
    }
}
