using System;
using System.Windows.Forms;
using NationalInstruments;
using NationalInstruments.Net;

namespace OPCExample
{
    public partial class Form1 : Form
    {

        DataSocket dataSocketRead = new DataSocket();
        DataSocket dataSocketWrite = new DataSocket();

        public Form1()
        {
            InitializeComponent();


            string opcUrl;
            opcUrl = "opc://localhost/MATRIKON.OPC.Simulation/Bucket Brigade.Real4";
            

            if (dataSocketRead.IsConnected)
                dataSocketRead.Disconnect();

            dataSocketRead.Connect(opcUrl, AccessMode.Read);


            if (dataSocketWrite.IsConnected)
                dataSocketWrite.Disconnect();

            dataSocketWrite.Connect(opcUrl, AccessMode.Write);


        }

        private void btnReadOpc_Click(object sender, EventArgs e)
        {

            dataSocketRead.Update();

            txtReadOpcValue.Text = dataSocketRead.Data.Value.ToString();

        }

        private void btnWriteOpc_Click(object sender, EventArgs e)
        {

            double opcValue = 0;

            opcValue = Convert.ToDouble(txtWriteOpcValue.Text);

            dataSocketWrite.Data.Value = opcValue;

            dataSocketWrite.Update();
        }
    }
}
