namespace Tekno4
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
            this.lblResult = new System.Windows.Forms.Label();
            this.txtNumbers = new System.Windows.Forms.TextBox();
            this.btnSelectedFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(222, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(76, 23);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "Result";
            // 
            // txtNumbers
            // 
            this.txtNumbers.BackColor = System.Drawing.Color.White;
            this.txtNumbers.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumbers.Location = new System.Drawing.Point(136, 35);
            this.txtNumbers.Multiline = true;
            this.txtNumbers.Name = "txtNumbers";
            this.txtNumbers.ReadOnly = true;
            this.txtNumbers.Size = new System.Drawing.Size(257, 549);
            this.txtNumbers.TabIndex = 1;
            // 
            // btnSelectedFile
            // 
            this.btnSelectedFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectedFile.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectedFile.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelectedFile.Location = new System.Drawing.Point(136, 605);
            this.btnSelectedFile.Name = "btnSelectedFile";
            this.btnSelectedFile.Size = new System.Drawing.Size(257, 35);
            this.btnSelectedFile.TabIndex = 2;
            this.btnSelectedFile.Text = "Select File";
            this.btnSelectedFile.UseVisualStyleBackColor = false;
            this.btnSelectedFile.Click += new System.EventHandler(this.btnSelectedFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 652);
            this.Controls.Add(this.btnSelectedFile);
            this.Controls.Add(this.txtNumbers);
            this.Controls.Add(this.lblResult);
            this.Name = "Form1";
            this.Text = "Tekno4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Button btnSelectedFile;
    }
}

