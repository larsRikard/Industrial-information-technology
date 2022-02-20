namespace OPC_Write
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
            this.btnWriteOpc = new System.Windows.Forms.Button();
            this.lblWriteOpcValue = new System.Windows.Forms.Label();
            this.txtWriteOpcValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnWriteOpc
            // 
            this.btnWriteOpc.Location = new System.Drawing.Point(156, 38);
            this.btnWriteOpc.Name = "btnWriteOpc";
            this.btnWriteOpc.Size = new System.Drawing.Size(75, 23);
            this.btnWriteOpc.TabIndex = 5;
            this.btnWriteOpc.Text = "Write OPC";
            this.btnWriteOpc.UseVisualStyleBackColor = true;
            this.btnWriteOpc.Click += new System.EventHandler(this.btnWriteOpc_Click);
            // 
            // lblWriteOpcValue
            // 
            this.lblWriteOpcValue.AutoSize = true;
            this.lblWriteOpcValue.Location = new System.Drawing.Point(33, 27);
            this.lblWriteOpcValue.Name = "lblWriteOpcValue";
            this.lblWriteOpcValue.Size = new System.Drawing.Size(33, 13);
            this.lblWriteOpcValue.TabIndex = 4;
            this.lblWriteOpcValue.Text = "Data:";
            // 
            // txtWriteOpcValue
            // 
            this.txtWriteOpcValue.Location = new System.Drawing.Point(33, 41);
            this.txtWriteOpcValue.Name = "txtWriteOpcValue";
            this.txtWriteOpcValue.Size = new System.Drawing.Size(100, 20);
            this.txtWriteOpcValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 102);
            this.Controls.Add(this.btnWriteOpc);
            this.Controls.Add(this.lblWriteOpcValue);
            this.Controls.Add(this.txtWriteOpcValue);
            this.Name = "Form1";
            this.Text = "Write to OPC Server";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteOpc;
        private System.Windows.Forms.Label lblWriteOpcValue;
        private System.Windows.Forms.TextBox txtWriteOpcValue;
    }
}

