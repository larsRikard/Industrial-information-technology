namespace OPC_Read
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
            this.lblReadOpcValue = new System.Windows.Forms.Label();
            this.btnReadOpc = new System.Windows.Forms.Button();
            this.txtReadOpcValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReadOpcValue
            // 
            this.lblReadOpcValue.AutoSize = true;
            this.lblReadOpcValue.Location = new System.Drawing.Point(38, 28);
            this.lblReadOpcValue.Name = "lblReadOpcValue";
            this.lblReadOpcValue.Size = new System.Drawing.Size(33, 13);
            this.lblReadOpcValue.TabIndex = 8;
            this.lblReadOpcValue.Text = "Data:";
            // 
            // btnReadOpc
            // 
            this.btnReadOpc.Location = new System.Drawing.Point(161, 41);
            this.btnReadOpc.Name = "btnReadOpc";
            this.btnReadOpc.Size = new System.Drawing.Size(75, 23);
            this.btnReadOpc.TabIndex = 7;
            this.btnReadOpc.Text = "Read OPC";
            this.btnReadOpc.UseVisualStyleBackColor = true;
            this.btnReadOpc.Click += new System.EventHandler(this.btnReadOpc_Click);
            // 
            // txtReadOpcValue
            // 
            this.txtReadOpcValue.Location = new System.Drawing.Point(38, 44);
            this.txtReadOpcValue.Name = "txtReadOpcValue";
            this.txtReadOpcValue.Size = new System.Drawing.Size(100, 20);
            this.txtReadOpcValue.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 107);
            this.Controls.Add(this.lblReadOpcValue);
            this.Controls.Add(this.btnReadOpc);
            this.Controls.Add(this.txtReadOpcValue);
            this.Name = "Form1";
            this.Text = "Read from OPC Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReadOpcValue;
        private System.Windows.Forms.Button btnReadOpc;
        private System.Windows.Forms.TextBox txtReadOpcValue;
    }
}

