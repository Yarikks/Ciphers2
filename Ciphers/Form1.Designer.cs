namespace Ciphers
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
            this.cipherText = new System.Windows.Forms.TextBox();
            this.cipheredText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Simple = new System.Windows.Forms.Button();
            this.Blocked = new System.Windows.Forms.Button();
            this.Tabled = new System.Windows.Forms.Button();
            this.key = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cipherText
            // 
            this.cipherText.Location = new System.Drawing.Point(174, 56);
            this.cipherText.Name = "cipherText";
            this.cipherText.Size = new System.Drawing.Size(427, 20);
            this.cipherText.TabIndex = 0;
            // 
            // cipheredText
            // 
            this.cipheredText.Location = new System.Drawing.Point(174, 235);
            this.cipheredText.Name = "cipheredText";
            this.cipheredText.Size = new System.Drawing.Size(427, 20);
            this.cipheredText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст для шифру";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Зашифрований текст";
            // 
            // Simple
            // 
            this.Simple.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Simple.Location = new System.Drawing.Point(674, 30);
            this.Simple.Name = "Simple";
            this.Simple.Size = new System.Drawing.Size(114, 29);
            this.Simple.TabIndex = 4;
            this.Simple.Text = "Простий";
            this.Simple.UseVisualStyleBackColor = true;
            this.Simple.Click += new System.EventHandler(this.Simple_Click);
            // 
            // Blocked
            // 
            this.Blocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Blocked.Location = new System.Drawing.Point(674, 80);
            this.Blocked.Name = "Blocked";
            this.Blocked.Size = new System.Drawing.Size(114, 29);
            this.Blocked.TabIndex = 5;
            this.Blocked.Text = "Блочний";
            this.Blocked.UseVisualStyleBackColor = true;
            this.Blocked.Click += new System.EventHandler(this.Blocked_Click);
            // 
            // Tabled
            // 
            this.Tabled.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tabled.Location = new System.Drawing.Point(674, 133);
            this.Tabled.Name = "Tabled";
            this.Tabled.Size = new System.Drawing.Size(114, 29);
            this.Tabled.TabIndex = 6;
            this.Tabled.Text = "Табличний";
            this.Tabled.UseVisualStyleBackColor = true;
            this.Tabled.Click += new System.EventHandler(this.Tabled_Click);
            // 
            // key
            // 
            this.key.Location = new System.Drawing.Point(174, 107);
            this.key.Name = "key";
            this.key.Size = new System.Drawing.Size(427, 20);
            this.key.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Ключ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.key);
            this.Controls.Add(this.Tabled);
            this.Controls.Add(this.Blocked);
            this.Controls.Add(this.Simple);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cipheredText);
            this.Controls.Add(this.cipherText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.TextBox cipheredText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Simple;
        private System.Windows.Forms.Button Blocked;
        private System.Windows.Forms.Button Tabled;
        private System.Windows.Forms.TextBox key;
        private System.Windows.Forms.Label label3;
    }
}

