namespace OPCExample
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
            this.txtReadOpcValue = new System.Windows.Forms.TextBox();
            this.txtWriteOpcValue = new System.Windows.Forms.TextBox();
            this.btnReadOpc = new System.Windows.Forms.Button();
            this.btnWriteOpc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReadOpcValue
            // 
            this.txtReadOpcValue.Location = new System.Drawing.Point(19, 76);
            this.txtReadOpcValue.Name = "txtReadOpcValue";
            this.txtReadOpcValue.Size = new System.Drawing.Size(100, 20);
            this.txtReadOpcValue.TabIndex = 0;
            // 
            // txtWriteOpcValue
            // 
            this.txtWriteOpcValue.Location = new System.Drawing.Point(19, 22);
            this.txtWriteOpcValue.Name = "txtWriteOpcValue";
            this.txtWriteOpcValue.Size = new System.Drawing.Size(100, 20);
            this.txtWriteOpcValue.TabIndex = 1;
            // 
            // btnReadOpc
            // 
            this.btnReadOpc.Location = new System.Drawing.Point(153, 72);
            this.btnReadOpc.Name = "btnReadOpc";
            this.btnReadOpc.Size = new System.Drawing.Size(75, 23);
            this.btnReadOpc.TabIndex = 2;
            this.btnReadOpc.Text = "Read OPC";
            this.btnReadOpc.UseVisualStyleBackColor = true;
            this.btnReadOpc.Click += new System.EventHandler(this.btnReadOpc_Click);
            // 
            // btnWriteOpc
            // 
            this.btnWriteOpc.Location = new System.Drawing.Point(153, 22);
            this.btnWriteOpc.Name = "btnWriteOpc";
            this.btnWriteOpc.Size = new System.Drawing.Size(75, 23);
            this.btnWriteOpc.TabIndex = 3;
            this.btnWriteOpc.Text = "Write OPC";
            this.btnWriteOpc.UseVisualStyleBackColor = true;
            this.btnWriteOpc.Click += new System.EventHandler(this.btnWriteOpc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 130);
            this.Controls.Add(this.btnWriteOpc);
            this.Controls.Add(this.btnReadOpc);
            this.Controls.Add(this.txtWriteOpcValue);
            this.Controls.Add(this.txtReadOpcValue);
            this.Name = "Form1";
            this.Text = "OPC Example";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReadOpcValue;
        private System.Windows.Forms.TextBox txtWriteOpcValue;
        private System.Windows.Forms.Button btnReadOpc;
        private System.Windows.Forms.Button btnWriteOpc;
    }
}

