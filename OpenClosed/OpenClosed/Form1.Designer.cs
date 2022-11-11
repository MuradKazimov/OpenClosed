namespace OpenClosed
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
            this.BtnChangeConnection = new System.Windows.Forms.Button();
            this.LblConnectionStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnChangeConnection
            // 
            this.BtnChangeConnection.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeConnection.Location = new System.Drawing.Point(120, 138);
            this.BtnChangeConnection.Name = "BtnChangeConnection";
            this.BtnChangeConnection.Size = new System.Drawing.Size(176, 60);
            this.BtnChangeConnection.TabIndex = 0;
            this.BtnChangeConnection.Text = "Connect";
            this.BtnChangeConnection.UseVisualStyleBackColor = true;
            this.BtnChangeConnection.Click += new System.EventHandler(this.BtnChangeConnection_Click);
            // 
            // LblConnectionStatus
            // 
            this.LblConnectionStatus.AutoSize = true;
            this.LblConnectionStatus.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblConnectionStatus.Location = new System.Drawing.Point(99, 62);
            this.LblConnectionStatus.Name = "LblConnectionStatus";
            this.LblConnectionStatus.Size = new System.Drawing.Size(0, 28);
            this.LblConnectionStatus.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 278);
            this.Controls.Add(this.LblConnectionStatus);
            this.Controls.Add(this.BtnChangeConnection);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnChangeConnection;
        private System.Windows.Forms.Label LblConnectionStatus;
    }
}

