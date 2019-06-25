namespace MainMenu
{
    partial class FormMainMenu
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.but_Game15 = new System.Windows.Forms.Button();
            this.but_mosaic = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_Game15
            // 
            this.but_Game15.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_Game15.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_Game15.Font = new System.Drawing.Font("Ravie", 10.75F);
            this.but_Game15.Location = new System.Drawing.Point(70, 64);
            this.but_Game15.Name = "but_Game15";
            this.but_Game15.Size = new System.Drawing.Size(121, 41);
            this.but_Game15.TabIndex = 0;
            this.but_Game15.Text = "Game 15";
            this.but_Game15.UseVisualStyleBackColor = false;
            this.but_Game15.Click += new System.EventHandler(this.but_Game15_Click);
            // 
            // but_mosaic
            // 
            this.but_mosaic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.but_mosaic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_mosaic.Font = new System.Drawing.Font("Ravie", 10.75F);
            this.but_mosaic.Location = new System.Drawing.Point(72, 123);
            this.but_mosaic.Name = "but_mosaic";
            this.but_mosaic.Size = new System.Drawing.Size(121, 41);
            this.but_mosaic.TabIndex = 1;
            this.but_mosaic.Text = "Mosaic";
            this.but_mosaic.UseVisualStyleBackColor = false;
            this.but_mosaic.Click += new System.EventHandler(this.but_mosaic_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(264, 287);
            this.Controls.Add(this.but_mosaic);
            this.Controls.Add(this.but_Game15);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button but_Game15;
        private System.Windows.Forms.Button but_mosaic;
    }
}

