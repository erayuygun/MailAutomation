﻿namespace MailAutomation
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMailAl = new System.Windows.Forms.TextBox();
            this.textBoxİsimAl = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label1.Location = new System.Drawing.Point(12, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.NavajoWhite;
            this.label2.Location = new System.Drawing.Point(12, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Firma Adı:";
            // 
            // textBoxMailAl
            // 
            this.textBoxMailAl.Location = new System.Drawing.Point(138, 111);
            this.textBoxMailAl.Name = "textBoxMailAl";
            this.textBoxMailAl.Size = new System.Drawing.Size(290, 20);
            this.textBoxMailAl.TabIndex = 2;
            // 
            // textBoxİsimAl
            // 
            this.textBoxİsimAl.Location = new System.Drawing.Point(138, 167);
            this.textBoxİsimAl.Name = "textBoxİsimAl";
            this.textBoxİsimAl.Size = new System.Drawing.Size(290, 20);
            this.textBoxİsimAl.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Bisque;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button1.Location = new System.Drawing.Point(163, 235);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 49);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gönder";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Sienna;
            this.ClientSize = new System.Drawing.Size(440, 326);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxİsimAl);
            this.Controls.Add(this.textBoxMailAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Automation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxMailAl;
        private System.Windows.Forms.TextBox textBoxİsimAl;
        private System.Windows.Forms.Button button1;
    }
}

