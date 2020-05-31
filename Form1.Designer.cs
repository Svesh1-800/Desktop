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
            System.Windows.Forms.Label label2;
            this.menuSideBar = new System.Windows.Forms.MenuStrip();
            this.TodayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TomorrowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.IAmTiredToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AllTasksToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeadlinesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRemoveTask = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            this.menuSideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            label2.Location = new System.Drawing.Point(34, 20);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(28, 34);
            label2.TabIndex = 3;
            label2.Text = "U";
            // 
            // menuSideBar
            // 
            this.menuSideBar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuSideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuSideBar.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuSideBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TodayToolStripMenuItem,
            this.TomorrowToolStripMenuItem,
            this.IAmTiredToolStripMenuItem,
            this.AllTasksToolStripMenuItem1,
            this.CreateTaskToolStripMenuItem,
            this.DeadlinesToolStripMenuItem});
            this.menuSideBar.Location = new System.Drawing.Point(0, 0);
            this.menuSideBar.Name = "menuSideBar";
            this.menuSideBar.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.menuSideBar.Size = new System.Drawing.Size(171, 450);
            this.menuSideBar.TabIndex = 0;
            this.menuSideBar.Text = "menuSideBar";
            // 
            // TodayToolStripMenuItem
            // 
            this.TodayToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.TodayToolStripMenuItem.Name = "TodayToolStripMenuItem";
            this.TodayToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.TodayToolStripMenuItem.Text = "Сегодня";
            this.TodayToolStripMenuItem.Click += new System.EventHandler(this.TodayToolStripMenuItem_Click);
            // 
            // TomorrowToolStripMenuItem
            // 
            this.TomorrowToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TomorrowToolStripMenuItem.Name = "TomorrowToolStripMenuItem";
            this.TomorrowToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.TomorrowToolStripMenuItem.Text = "Завтра";
            this.TomorrowToolStripMenuItem.Click += new System.EventHandler(this.TomorrowToolStripMenuItem_Click);
            // 
            // IAmTiredToolStripMenuItem
            // 
            this.IAmTiredToolStripMenuItem.ForeColor = System.Drawing.Color.Maroon;
            this.IAmTiredToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.IAmTiredToolStripMenuItem.Name = "IAmTiredToolStripMenuItem";
            this.IAmTiredToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.IAmTiredToolStripMenuItem.Text = "Я устал";
            this.IAmTiredToolStripMenuItem.Click += new System.EventHandler(this.IAmTiredToolStripMenuItem_Click);
            // 
            // AllTasksToolStripMenuItem1
            // 
            this.AllTasksToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.AllTasksToolStripMenuItem1.Name = "AllTasksToolStripMenuItem1";
            this.AllTasksToolStripMenuItem1.Size = new System.Drawing.Size(152, 27);
            this.AllTasksToolStripMenuItem1.Text = "Все задачи";
            this.AllTasksToolStripMenuItem1.Click += new System.EventHandler(this.AllTasksToolStripMenuItem1_Click);
            // 
            // CreateTaskToolStripMenuItem
            // 
            this.CreateTaskToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CreateTaskToolStripMenuItem.Name = "CreateTaskToolStripMenuItem";
            this.CreateTaskToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.CreateTaskToolStripMenuItem.Text = "Создать задачу ";
            this.CreateTaskToolStripMenuItem.Click += new System.EventHandler(this.CreateTaskToolStripMenuItem_Click);
            // 
            // DeadlinesToolStripMenuItem
            // 
            this.DeadlinesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeadlinesToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.DeadlinesToolStripMenuItem.Name = "DeadlinesToolStripMenuItem";
            this.DeadlinesToolStripMenuItem.Size = new System.Drawing.Size(152, 27);
            this.DeadlinesToolStripMenuItem.Text = "DEADLINES";
            this.DeadlinesToolStripMenuItem.Click += new System.EventHandler(this.DeadlinesToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(55, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "CAN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(171, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 386);
            this.panel1.TabIndex = 4;
            // 
            // buttonRemoveTask
            // 
            this.buttonRemoveTask.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.buttonRemoveTask.Enabled = false;
            this.buttonRemoveTask.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRemoveTask.Location = new System.Drawing.Point(174, 401);
            this.buttonRemoveTask.Name = "buttonRemoveTask";
            this.buttonRemoveTask.Size = new System.Drawing.Size(163, 28);
            this.buttonRemoveTask.TabIndex = 5;
            this.buttonRemoveTask.Text = "Завершить задачу";
            this.buttonRemoveTask.UseVisualStyleBackColor = false;
            this.buttonRemoveTask.Click += new System.EventHandler(this.buttonRemoveTask_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonRemoveTask);
            this.Controls.Add(this.panel1);
            this.Controls.Add(label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuSideBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormMain";
            this.Text = "UCAN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.menuSideBar.ResumeLayout(false);
            this.menuSideBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuSideBar;
        private System.Windows.Forms.ToolStripMenuItem TodayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TomorrowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem IAmTiredToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AllTasksToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem CreateTaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeadlinesToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonRemoveTask;
    }
}

