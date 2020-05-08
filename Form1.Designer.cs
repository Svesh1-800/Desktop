namespace uCAN
{
    partial class FormMain
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
            this.menuSideBar = new System.Windows.Forms.MenuStrip();
            this.сегодняToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завтраToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗадачиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.яУсталToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.всеЗадачиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьЗадачуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьКатегориюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuSideBar
            // 
            this.menuSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuSideBar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuSideBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сегодняToolStripMenuItem,
            this.завтраToolStripMenuItem,
            this.всеЗадачиToolStripMenuItem,
            this.яУсталToolStripMenuItem,
            this.всеЗадачиToolStripMenuItem1,
            this.создатьЗадачуToolStripMenuItem,
            this.создатьКатегориюToolStripMenuItem});
            this.menuSideBar.Location = new System.Drawing.Point(0, 0);
            this.menuSideBar.Name = "menuSideBar";
            this.menuSideBar.Size = new System.Drawing.Size(197, 450);
            this.menuSideBar.TabIndex = 0;
            this.menuSideBar.Text = "menuSideBar";
            // 
            // сегодняToolStripMenuItem
            // 
            this.сегодняToolStripMenuItem.Name = "сегодняToolStripMenuItem";
            this.сегодняToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.сегодняToolStripMenuItem.Text = "Сегодня";
            // 
            // завтраToolStripMenuItem
            // 
            this.завтраToolStripMenuItem.Name = "завтраToolStripMenuItem";
            this.завтраToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.завтраToolStripMenuItem.Text = "Завтра";
            // 
            // всеЗадачиToolStripMenuItem
            // 
            this.всеЗадачиToolStripMenuItem.Name = "всеЗадачиToolStripMenuItem";
            this.всеЗадачиToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.всеЗадачиToolStripMenuItem.Text = "Все задачи";
            // 
            // яУсталToolStripMenuItem
            // 
            this.яУсталToolStripMenuItem.Name = "яУсталToolStripMenuItem";
            this.яУсталToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.яУсталToolStripMenuItem.Text = "Я устал";
            // 
            // всеЗадачиToolStripMenuItem1
            // 
            this.всеЗадачиToolStripMenuItem1.Name = "всеЗадачиToolStripMenuItem1";
            this.всеЗадачиToolStripMenuItem1.Size = new System.Drawing.Size(184, 27);
            this.всеЗадачиToolStripMenuItem1.Text = "Все задачи";
            // 
            // создатьЗадачуToolStripMenuItem
            // 
            this.создатьЗадачуToolStripMenuItem.Name = "создатьЗадачуToolStripMenuItem";
            this.создатьЗадачуToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.создатьЗадачуToolStripMenuItem.Text = "Создать задачу ";
            // 
            // создатьКатегориюToolStripMenuItem
            // 
            this.создатьКатегориюToolStripMenuItem.Name = "создатьКатегориюToolStripMenuItem";
            this.создатьКатегориюToolStripMenuItem.Size = new System.Drawing.Size(184, 27);
            this.создатьКатегориюToolStripMenuItem.Text = "Создать категорию";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuSideBar);
            this.Name = "FormMain";
            this.Text = "UCAN";
            this.menuSideBar.ResumeLayout(false);
            this.menuSideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSideBar;
        private System.Windows.Forms.ToolStripMenuItem сегодняToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem завтраToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗадачиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem яУсталToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеЗадачиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem создатьЗадачуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьКатегориюToolStripMenuItem;
    }
}

