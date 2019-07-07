namespace Mosaic
{
    partial class FormMosaic
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.levelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level1 = new System.Windows.Forms.ToolStripMenuItem();
            this.level2 = new System.Windows.Forms.ToolStripMenuItem();
            this.level3 = new System.Windows.Forms.ToolStripMenuItem();
            this.savegame = new System.Windows.Forms.ToolStripMenuItem();
            this.loadSavedGame = new System.Windows.Forms.ToolStripMenuItem();
            this.menu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mosaic.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 111);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown_1);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.LavenderBlush;
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.menu,
            this.toolStripMenuItem2,
            this.buttonAdd});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(784, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.levelToolStripMenuItem1,
            this.savegame,
            this.loadSavedGame});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // levelToolStripMenuItem1
            // 
            this.levelToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.level1,
            this.level2,
            this.level3});
            this.levelToolStripMenuItem1.Name = "levelToolStripMenuItem1";
            this.levelToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.levelToolStripMenuItem1.Text = "Level";
            // 
            // level1
            // 
            this.level1.Name = "level1";
            this.level1.Size = new System.Drawing.Size(110, 22);
            this.level1.Text = "Level 1";
            this.level1.Click += new System.EventHandler(this.level1_Click);
            // 
            // level2
            // 
            this.level2.Name = "level2";
            this.level2.Size = new System.Drawing.Size(110, 22);
            this.level2.Text = "Level 2";
            this.level2.Click += new System.EventHandler(this.level2_Click);
            // 
            // level3
            // 
            this.level3.Name = "level3";
            this.level3.Size = new System.Drawing.Size(110, 22);
            this.level3.Text = "Level 3";
            this.level3.Click += new System.EventHandler(this.level3_Click);
            // 
            // savegame
            // 
            this.savegame.Name = "savegame";
            this.savegame.Size = new System.Drawing.Size(166, 22);
            this.savegame.Text = "Save the game";
            // 
            // loadSavedGame
            // 
            this.loadSavedGame.Name = "loadSavedGame";
            this.loadSavedGame.Size = new System.Drawing.Size(166, 22);
            this.loadSavedGame.Text = "Load saved game";
            // 
            // menu
            // 
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(43, 20);
            this.menu.Text = "Start";
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(24, 20);
            this.toolStripMenuItem2.Text = "?";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(27, 20);
            this.buttonAdd.Text = "+";
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.White;
            this.buttonRight.Enabled = false;
            this.buttonRight.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRight.Location = new System.Drawing.Point(373, 4);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(20, 20);
            this.buttonRight.TabIndex = 6;
            this.buttonRight.Text = ">";
            this.buttonRight.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.White;
            this.buttonLeft.Enabled = false;
            this.buttonLeft.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonLeft.Location = new System.Drawing.Point(346, 4);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonLeft.Size = new System.Drawing.Size(20, 20);
            this.buttonLeft.TabIndex = 5;
            this.buttonLeft.Text = "<";
            this.buttonLeft.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // FormMosaic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormMosaic";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem levelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem level1;
        private System.Windows.Forms.ToolStripMenuItem level2;
        private System.Windows.Forms.ToolStripMenuItem level3;
        private System.Windows.Forms.ToolStripMenuItem savegame;
        private System.Windows.Forms.ToolStripMenuItem loadSavedGame;
        private System.Windows.Forms.ToolStripMenuItem menu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem buttonAdd;
        public System.Windows.Forms.Button buttonRight;
        public System.Windows.Forms.Button buttonLeft;
    }
}

