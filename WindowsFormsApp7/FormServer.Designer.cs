namespace WindowsFormsApp7
{
    partial class FormServer
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtGidicekMesaj = new System.Windows.Forms.TextBox();
            this.txtGidicekIpPort = new System.Windows.Forms.TextBox();
            this.btnMesajGonder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(378, 207);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Gelen Mesaj : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Gönderilecek Mesaj :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gönderilecek ip:port :";
            // 
            // txtGidicekMesaj
            // 
            this.txtGidicekMesaj.Location = new System.Drawing.Point(125, 267);
            this.txtGidicekMesaj.Name = "txtGidicekMesaj";
            this.txtGidicekMesaj.Size = new System.Drawing.Size(209, 20);
            this.txtGidicekMesaj.TabIndex = 5;
            this.txtGidicekMesaj.Text = "serverdan yolladım";
            // 
            // txtGidicekIpPort
            // 
            this.txtGidicekIpPort.Location = new System.Drawing.Point(125, 302);
            this.txtGidicekIpPort.Name = "txtGidicekIpPort";
            this.txtGidicekIpPort.Size = new System.Drawing.Size(209, 20);
            this.txtGidicekIpPort.TabIndex = 5;
            this.txtGidicekIpPort.Text = "127.0.0.1:52154";
            // 
            // btnMesajGonder
            // 
            this.btnMesajGonder.Location = new System.Drawing.Point(365, 268);
            this.btnMesajGonder.Name = "btnMesajGonder";
            this.btnMesajGonder.Size = new System.Drawing.Size(78, 51);
            this.btnMesajGonder.TabIndex = 6;
            this.btnMesajGonder.Text = "GÖNDER";
            this.btnMesajGonder.UseVisualStyleBackColor = true;
            this.btnMesajGonder.Click += new System.EventHandler(this.btnMesajGonder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 342);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(463, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "AÇIKLAMA : ilk clientten buraya mesaj gönderirsen ip adresi ne gösterir yukarıdak" +
    "i mesaj alanında";
            // 
            // FormServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 378);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnMesajGonder);
            this.Controls.Add(this.txtGidicekIpPort);
            this.Controls.Add(this.txtGidicekMesaj);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SERVER";
            this.Load += new System.EventHandler(this.FormServer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtGidicekMesaj;
        private System.Windows.Forms.TextBox txtGidicekIpPort;
        private System.Windows.Forms.Button btnMesajGonder;
        private System.Windows.Forms.Label label4;
    }
}

