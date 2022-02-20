namespace OPCDemo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.thermometerOPCValue = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtOPCValue = new System.Windows.Forms.TextBox();
            this.labelOPCValue = new System.Windows.Forms.Label();
            this.waveformGraph1 = new NationalInstruments.UI.WindowsForms.WaveformGraph();
            this.waveformPlot1 = new NationalInstruments.UI.WaveformPlot();
            this.xAxis1 = new NationalInstruments.UI.XAxis();
            this.yAxis1 = new NationalInstruments.UI.YAxis();
            this.thermometerFahrenheit = new NationalInstruments.UI.WindowsForms.Thermometer();
            this.txtFahrenheit = new System.Windows.Forms.TextBox();
            this.lblFahrenheit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerOPCValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerFahrenheit)).BeginInit();
            this.SuspendLayout();
            // 
            // thermometerOPCValue
            // 
            this.thermometerOPCValue.Location = new System.Drawing.Point(12, 19);
            this.thermometerOPCValue.Name = "thermometerOPCValue";
            this.thermometerOPCValue.Range = new NationalInstruments.UI.Range(0D, 50D);
            this.thermometerOPCValue.Size = new System.Drawing.Size(90, 227);
            this.thermometerOPCValue.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtOPCValue
            // 
            this.txtOPCValue.Location = new System.Drawing.Point(27, 244);
            this.txtOPCValue.Name = "txtOPCValue";
            this.txtOPCValue.Size = new System.Drawing.Size(75, 20);
            this.txtOPCValue.TabIndex = 1;
            // 
            // labelOPCValue
            // 
            this.labelOPCValue.AutoSize = true;
            this.labelOPCValue.Location = new System.Drawing.Point(28, 9);
            this.labelOPCValue.Name = "labelOPCValue";
            this.labelOPCValue.Size = new System.Drawing.Size(59, 13);
            this.labelOPCValue.TabIndex = 2;
            this.labelOPCValue.Text = "OPC Value";
            // 
            // waveformGraph1
            // 
            this.waveformGraph1.Location = new System.Drawing.Point(202, 32);
            this.waveformGraph1.Name = "waveformGraph1";
            this.waveformGraph1.Plots.AddRange(new NationalInstruments.UI.WaveformPlot[] {
            this.waveformPlot1});
            this.waveformGraph1.Size = new System.Drawing.Size(430, 257);
            this.waveformGraph1.TabIndex = 3;
            this.waveformGraph1.UseColorGenerator = true;
            this.waveformGraph1.XAxes.AddRange(new NationalInstruments.UI.XAxis[] {
            this.xAxis1});
            this.waveformGraph1.YAxes.AddRange(new NationalInstruments.UI.YAxis[] {
            this.yAxis1});
            // 
            // waveformPlot1
            // 
            this.waveformPlot1.XAxis = this.xAxis1;
            this.waveformPlot1.YAxis = this.yAxis1;
            // 
            // thermometerFahrenheit
            // 
            this.thermometerFahrenheit.Location = new System.Drawing.Point(108, 19);
            this.thermometerFahrenheit.Name = "thermometerFahrenheit";
            this.thermometerFahrenheit.Size = new System.Drawing.Size(90, 227);
            this.thermometerFahrenheit.TabIndex = 4;
            // 
            // txtFahrenheit
            // 
            this.txtFahrenheit.Location = new System.Drawing.Point(127, 244);
            this.txtFahrenheit.Name = "txtFahrenheit";
            this.txtFahrenheit.Size = new System.Drawing.Size(67, 20);
            this.txtFahrenheit.TabIndex = 5;
            // 
            // lblFahrenheit
            // 
            this.lblFahrenheit.AutoSize = true;
            this.lblFahrenheit.Location = new System.Drawing.Point(124, 9);
            this.lblFahrenheit.Name = "lblFahrenheit";
            this.lblFahrenheit.Size = new System.Drawing.Size(57, 13);
            this.lblFahrenheit.TabIndex = 6;
            this.lblFahrenheit.Text = "Fahrenheit";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 321);
            this.Controls.Add(this.lblFahrenheit);
            this.Controls.Add(this.txtFahrenheit);
            this.Controls.Add(this.thermometerFahrenheit);
            this.Controls.Add(this.waveformGraph1);
            this.Controls.Add(this.labelOPCValue);
            this.Controls.Add(this.txtOPCValue);
            this.Controls.Add(this.thermometerOPCValue);
            this.Name = "Form1";
            this.Text = "OPC Demo";
            ((System.ComponentModel.ISupportInitialize)(this.thermometerOPCValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waveformGraph1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thermometerFahrenheit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NationalInstruments.UI.WindowsForms.Thermometer thermometerOPCValue;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtOPCValue;
        private System.Windows.Forms.Label labelOPCValue;
        private NationalInstruments.UI.WindowsForms.WaveformGraph waveformGraph1;
        private NationalInstruments.UI.WaveformPlot waveformPlot1;
        private NationalInstruments.UI.XAxis xAxis1;
        private NationalInstruments.UI.YAxis yAxis1;
        private NationalInstruments.UI.WindowsForms.Thermometer thermometerFahrenheit;
        private System.Windows.Forms.TextBox txtFahrenheit;
        private System.Windows.Forms.Label lblFahrenheit;
    }
}

