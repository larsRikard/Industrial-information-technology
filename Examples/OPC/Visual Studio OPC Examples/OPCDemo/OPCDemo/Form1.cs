using NationalInstruments;
using NationalInstruments.Net;
using NationalInstruments.UI;
using NationalInstruments.UI.WindowsForms;
using System;
using System.Windows.Forms;
using Tuc.LabWork;  


namespace OPCDemo
{
    public partial class Form1 : Form
    {

        DataSocket dataSocket = new DataSocket();
        

        public Form1()
        {
            string opcUrl;
            
            InitializeComponent();

            timer1.Start();           
            

            // Connect to OPC Server
            opcUrl = "opc://localhost/Matrikon.OPC.Simulation/Bucket Brigade.Real4";
            
            if (dataSocket.IsConnected)
                dataSocket.Disconnect();

            dataSocket.Connect(opcUrl, AccessMode.Read);
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            double opcValue = 0;
            double opcValueFahrenheit = 0; ;

            Scaling myScaling = new Scaling();
             
            // Get Latest Data from OPC Server 
            dataSocket.Update();

            opcValue = Convert.ToDouble(dataSocket.Data.Value);

            opcValueFahrenheit = myScaling.CelciusToFahrenheit(opcValue);

            // Update GUI
            txtOPCValue.Text = opcValue.ToString();
            txtFahrenheit.Text = opcValueFahrenheit.ToString();

            thermometerOPCValue.Value = opcValue;
            thermometerFahrenheit.Value = opcValueFahrenheit;

            waveformGraph1.PlotYAppend(opcValue);

        }

      


        private void Form1_Closed(object sender, EventArgs e)
        {
            dataSocket.Disconnect();            
        }

                     

        
    }
}
