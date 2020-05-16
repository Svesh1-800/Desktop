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
        MonthCalendar today;
        DateTimePicker dateTimePickerSetDeadline;
        CheckedListBox checkedListBoxTodayTasks;
        
        

        public FormMain()
        {
            InitializeComponent();
            EventArgs e = new EventArgs();
            object sender = new object();
            TodayToolStripMenuItem_Click(sender, e);

        }
      
        
        
        
        private void CreateTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            today = new MonthCalendar();
            dateTimePickerSetDeadline.MinDate = today.TodayDate;

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
            panel1.Controls.Add(dateTimePickerSetDeadline);
            panel1.Controls.Add(buttonApplyNew);
            
            

            
        }

        
        private void CreateListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            
        }
       
        static void CreateNote(string vvod,string date)
        { 
            StreamWriter file = new StreamWriter("goals.txt", true);
            file.WriteLine(vvod + " .Дедлайн - " +date );
            file.Close();
            MessageBox.Show("Готово");
        }
        public void ButtonOnClick(object sender, EventArgs eventArgs)
        {
            if (textBoxInput.Text == "")
            {
                MessageBox.Show("Введите задачу");
            }
            else
            {
                CreateNote(textBoxInput.Text, dateTimePickerSetDeadline.Value.ToShortDateString().ToString());
                textBoxInput.Clear();
                
            }
        }
     
        private void TodayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            checkedListBoxTodayTasks = new CheckedListBox();
            Font fn = new Font("Georgia", 12);
            checkedListBoxTodayTasks.Font = fn;
            checkedListBoxTodayTasks.Width = 800;
            checkedListBoxTodayTasks.Height = 800;
            StreamReader file = new StreamReader("goals.txt");
            today = new MonthCalendar();
            while (!file.EndOfStream)
            {
                string note = file.ReadLine();
                string[] oneTask = note.Split();
                int cnt = oneTask.Length;
                int cntNote = note.Length;
                string thatDay = oneTask[cnt-1];
                if(thatDay == today.TodayDate.ToShortDateString())
                {
                    checkedListBoxTodayTasks.Items.Add(note.Remove(cntNote-21));
                }
                
            }
            file.Close();
            panel1.Controls.Add(checkedListBoxTodayTasks);

        }

        private void AllTasksToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            checkedListBoxTodayTasks = new CheckedListBox();
            Font fn = new Font("Georgia", 12);
            checkedListBoxTodayTasks.Font = fn;
            checkedListBoxTodayTasks.Width = 800;
            checkedListBoxTodayTasks.Height = 800;


            StreamReader file = new StreamReader("goals.txt");
            while (!file.EndOfStream)
            {
                string oneTask = file.ReadLine();
                checkedListBoxTodayTasks.Items.Add(oneTask);
            }
            file.Close();
            panel1.Controls.Add(checkedListBoxTodayTasks);
        }

        private void TomorrowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            checkedListBoxTodayTasks = new CheckedListBox();
            Font fn = new Font("Georgia", 12);
            checkedListBoxTodayTasks.Font = fn;
            checkedListBoxTodayTasks.Width = 800;
            checkedListBoxTodayTasks.Height = 800;
            StreamReader file = new StreamReader("goals.txt");
            today = new MonthCalendar();
            while (!file.EndOfStream)
            {
                string note = file.ReadLine();
                string[] oneTask = note.Split();
                int cnt = oneTask.Length;
                int cntNote = note.Length;
                string thatDay = oneTask[cnt - 1];
                if (thatDay == today.TodayDate.AddDays(1).ToShortDateString())
                {
                    checkedListBoxTodayTasks.Items.Add(note.Remove(cntNote - 21));
                }

            }
            file.Close();
            panel1.Controls.Add(checkedListBoxTodayTasks);
        }

        private void IAmTiredToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("«Но когда у тебя что-то не получается , ты начинаешь искать виноватых. Например, мою тень. Я скажу тебе то, что ты и так знаешь. Мир не такой уж солнечный и приветливый. Это суровое и опасное место. И не важно, насколько сильным ты считаешь себя, он все равно поставит тебя на колени и будет удерживать, если ты ему это позволишь Дело не в том, как сильно ты бьешь, а в том, как долго сможешь держать удары и двигаться вперед.Только так побеждают Если знаешь, чего ты стоишь, иди и возьми свое.Но будь готов принимать удары, а не говорить, что у меня не получилось из - за него, из - за нее или кого - то еще.Так делают только трусы.Но ты не трус.Быть этого не может—  Артур Дзадзаев");
        }
    }
    
}
