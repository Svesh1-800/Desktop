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
        
        TextBox textBoxInput;
        DateTimePicker dateTimePickerSetDeadline;
        ListBox listBoxTasks;
        List<string> temp = new List<string>();
        List<string> tempWithoutDate = new List<string>();

        public FormMain()
        { 
            InitializeComponent();
            CreateTemp();
            EventArgs e = new EventArgs();
            object sender = new object();
            TodayToolStripMenuItem_Click(sender, e);

        }
       
        private void CreateTemp()
        {

            StreamReader file = new StreamReader("goals.txt");
            while (!file.EndOfStream)
            {
                string note = file.ReadLine();
                string[] oneTask = note.Split();
                string thatDay = oneTask[oneTask.Length - 1];
                temp.Add(note);
                tempWithoutDate.Add(("- " + note.Remove(note.Length - 21)));
            }
            file.Close();
            

        }

        public void TodayAndTomorrowAndAll(int plus)
        {
            
            
            buttonDelete.Visible = true;
            buttonDelete.Enabled = false;
            panel1.Controls.Clear();
            listBoxTasks = new ListBox();
            Font fn = new Font("Georgia", 12);
            listBoxTasks.Height = 386;
            listBoxTasks.Width = 631;
            listBoxTasks.Font = fn;
            if (plus != -1)
            {
                foreach (string note in temp)
                {
                    string[] oneTask = note.Split();
                    string thatDay = oneTask[oneTask.Length - 1];
                    if (thatDay == DateTime.Now.AddDays(plus).ToShortDateString())
                    {

                        listBoxTasks.Items.Add(("- " + note.Remove(note.Length - 21)));
                    }

                }
            }
            else
            {
                foreach (string note in temp)
                {
                    listBoxTasks.Items.Add(("- " + note.Remove(note.Length - 21)));
                }
            }

            panel1.Controls.Add(listBoxTasks);
            
        }
        private void AllTasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TodayAndTomorrowAndAll(-1);
            listBoxTasks.SelectedIndexChanged += ListBoxTasks_SelectedIndexChanged;
            
        }

       

        private void TomorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodayAndTomorrowAndAll(1);
            listBoxTasks.SelectedIndexChanged += ListBoxTasks_SelectedIndexChanged;
            
        }

        

        private void TodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TodayAndTomorrowAndAll(0);
            listBoxTasks.SelectedIndexChanged += ListBoxTasks_SelectedIndexChanged;
            
            
        }

        

        private void ListBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            buttonDelete.Enabled = true;
        }
        private void CreateTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            buttonDelete.Visible = false;
            panel1.Controls.Clear();
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

            dateTimePickerSetDeadline = new DateTimePicker();
            dateTimePickerSetDeadline.Left = 200;
            dateTimePickerSetDeadline.Top = 160;
            dateTimePickerSetDeadline.MinDate = DateTime.Now;

            Button buttonApplyNew = new Button();
            buttonApplyNew.Height = 50;
            buttonApplyNew.Width = 90;
            buttonApplyNew.Left = 100;
            buttonApplyNew.Top = 190;
            buttonApplyNew.Text = "Подтвердить";
            buttonApplyNew.Click += ButtonOnClick;
            textBoxInput.KeyDown += TextBoxInput_KeyDown;


            panel1.Controls.Add(labelInputText);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(labelInputDate);
            panel1.Controls.Add(dateTimePickerSetDeadline);
            panel1.Controls.Add(buttonApplyNew);
             
        }

        private void TextBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonOnClick(sender, e);
            }
        }
        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Введите задачу");
            }
            else
            {
                CreateNote(textBoxInput.Text, dateTimePickerSetDeadline.Value.ToShortDateString().ToString(), temp);
                textBoxInput.Clear();

            }
        }
        private void CreateNote(string vvod,string date,List<string> temp)
        {
            string note = vvod + " .Дедлайн - " + date;
            temp.Add(note);
            tempWithoutDate.Add(("- " + note.Remove(note.Length - 21)));
            MessageBox.Show("Готово");
        }
       
     


        private void IAmTiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("«Но когда у тебя что-то не получается , ты начинаешь искать виноватых. Например, мою тень. Я скажу тебе то, что ты и так знаешь. Мир не такой уж солнечный и приветливый. Это суровое и опасное место. И не важно, насколько сильным ты считаешь себя, он все равно поставит тебя на колени и будет удерживать, если ты ему это позволишь Дело не в том, как сильно ты бьешь, а в том, как долго сможешь держать удары и двигаться вперед.Только так побеждают Если знаешь, чего ты стоишь, иди и возьми свое.Но будь готов принимать удары, а не говорить, что у меня не получилось из - за него, из - за нее или кого - то еще.Так делают только трусы.Но ты не трус.Быть этого не может—  Артур Дзадзаев");
        }

        private void DeadlinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            buttonDelete.Visible = false;
            panel1.Controls.Clear();
            ListBox listBoxTasks = new ListBox();
            listBoxTasks.BackColor = Color.WhiteSmoke;
            listBoxTasks.Height = 386;
            listBoxTasks.Width = 629;
            Font fn = new Font("Georgia", 12);
            listBoxTasks.Font = fn;
            foreach(string s in temp)
            {
                
                string[] ss = s.Split();
                string numbers = ss[ss.Length - 1];
                string[] date = numbers.Split('.');
                int day = Convert.ToInt32(date[0]);
                int month = Convert.ToInt32(date[1]);
                int year = Convert.ToInt32(date[2]);
                DateTime finishDate = new DateTime(year,month,day);
                TimeSpan left = finishDate.Subtract(DateTime.Now);
                double daysLeft = left.TotalDays;
               
                if(daysLeft+1>=0)
                {
                    listBoxTasks.Items.Add(s.Remove(s.Length - 21) + " - " + (daysLeft).ToString("0") + " day(-s)");
                }
                else
                {
                    listBoxTasks.Items.Add(s.Remove(s.Length - 21) + ". Просрочено на " + (-1 * (daysLeft + 1)).ToString("0") + " day(-s)");
                }

            }
            panel1.Controls.Add(listBoxTasks);

        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int indexForm = listBoxTasks.SelectedIndex;
                string el = listBoxTasks.Items[indexForm].ToString();
                int index = tempWithoutDate.IndexOf(el);
                tempWithoutDate.Remove(el);
                temp.RemoveAt(index);
                listBoxTasks.Items.RemoveAt(indexForm);
            }
            catch
            {
                MessageBox.Show("Cначала выберите задачу из списка");
            }
                buttonDelete.Enabled = false;
            

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            StreamWriter file = new StreamWriter("goals.txt");
            foreach (string note in temp)
            {
                file.WriteLine(note);
            }
           
            file.Close();
            
        }

    }
    
}
