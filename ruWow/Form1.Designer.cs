namespace ruWow
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.swap = new System.Windows.Forms.Button();
            this.euL = new System.Windows.Forms.Button();
            this.ruL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(61, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "RU";
            // 
            // swap
            // 
            this.swap.Location = new System.Drawing.Point(75, 55);
            this.swap.Name = "swap";
            this.swap.Size = new System.Drawing.Size(75, 23);
            this.swap.TabIndex = 1;
            this.swap.Text = "SWAP";
            this.swap.UseVisualStyleBackColor = true;
            this.swap.Click += new System.EventHandler(this.swap_Click);
            // 
            // euL
            // 
            this.euL.Location = new System.Drawing.Point(12, 84);
            this.euL.Name = "euL";
            this.euL.Size = new System.Drawing.Size(100, 23);
            this.euL.TabIndex = 2;
            this.euL.Text = "EU";
            this.euL.UseVisualStyleBackColor = true;
            this.euL.Click += new System.EventHandler(this.euL_Click);
            // 
            // ruL
            // 
            this.ruL.Location = new System.Drawing.Point(116, 84);
            this.ruL.Name = "ruL";
            this.ruL.Size = new System.Drawing.Size(100, 23);
            this.ruL.TabIndex = 3;
            this.ruL.Tag = "RU";
            this.ruL.Text = "RU";
            this.ruL.UseVisualStyleBackColor = true;
            this.ruL.Click += new System.EventHandler(this.ruL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 119);
            this.Controls.Add(this.ruL);
            this.Controls.Add(this.euL);
            this.Controls.Add(this.swap);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Смена языка вовна";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button swap;
        private System.Windows.Forms.Button euL;
        private System.Windows.Forms.Button ruL;
    }
}

