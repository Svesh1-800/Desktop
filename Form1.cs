using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uCAN
{
    
    public partial class FormMain : Form
    {
        Button buttonApplyNew;
        TextBox textBoxInput;


        public FormMain()
        {
            InitializeComponent();
        }
        public class Fsa
        {

        }
        
        private void CreateTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxInput = new TextBox();

            textBoxInput.Width = 400;
            textBoxInput.Height = 30;

            textBoxInput.Multiline = true;
            textBoxInput.MaxLength = 45;
            Font fn = new Font("Georgia", 11);
            textBoxInput.Font = fn;

            textBoxInput.Left = 100;
            textBoxInput.Top = 100;

            Label labelInputText = new Label();
            labelInputText.Text = "Введите задачу:";
            labelInputText.Left = 100;
            labelInputText.Top = 70;

            Label labelInputDate = new Label();
            labelInputDate.Text = "Дедлайн:";
            labelInputDate.Left = 100;
            labelInputDate.Top = 160;

            MonthCalendar monthCalendarsetDealine = new MonthCalendar();
            monthCalendarsetDealine.Left = 200;
            monthCalendarsetDealine.Top = 160;
            monthCalendarsetDealine.MinDate = monthCalendarsetDealine.TodayDate;

            buttonApplyNew = new Button();
            buttonApplyNew.Height = 50;
            buttonApplyNew.Width = 90;
            buttonApplyNew.Left = 100;
            buttonApplyNew.Top = 190;
            buttonApplyNew.Text = "Подтвердить";
            buttonApplyNew.Click += ButtonOnClick;


            panel1.Controls.Add(labelInputText);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(labelInputDate);
            panel1.Controls.Add(monthCalendarsetDealine);
            panel1.Controls.Add(buttonApplyNew);


            
        }

        
        private void CreateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
        }
       
        static void CreateNote(string vvod)
        {
            
            
            
            StreamWriter file = new StreamWriter("goals.txt",true);
            
            file.WriteLine(vvod);
            
            file.Close();
            MessageBox.Show("Готово");
        }
        private void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Введите задачу");
            }
            else
            {
                CreateNote(textBoxInput.Text);
                textBoxInput.Clear();
            }
        }

    }
    
}
