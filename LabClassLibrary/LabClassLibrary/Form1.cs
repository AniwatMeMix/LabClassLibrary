using StudentClassLibrary;
using static System.Net.Mime.MediaTypeNames;

namespace LabClassLibrary
{
    public partial class Form1 : Form
    {
        List<Student> listStudent = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            this.tdLCD.Text = "";
            string input_name = this.tdName.Text;
            string input_student_id = this.tdID.Text;
            Student newStudent = new Student(input_name,input_student_id);
            this.listStudent.Add(newStudent);
            for (int i= 0; i < this.listStudent.Count; i++)
            {
                Student currentStudent= this.listStudent[i];
                string display = currentStudent.displayInfo();
                this.tdLCD.Text += display;
                this.tdName.Text = "";
                this.tdID.Text = "";
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string save_data = this.tdLCD.Text;
            File.WriteAllText("D:/text.csv " , save_data);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] data = File.ReadAllLines("D:/ text.csv");
            //to do 
            //add data to listStudent
            for (int i = 0; i < data.Length; i++)
            {
                string idata = data[i];
                
                // add idata to listStudent
                // using Substring
            }
            //Display data to tdLCD
            displayData();
            
        }

        private void displayData()
        {
            for (int i = 0; i < this.listStudent.Count(); i++)
            {
                Student currentStudent = this.listStudent[i];
                string display = currentStudent.displayInfo();
                this.tdLCD.Text += display;
                //to do
                // [] Fix display data from list
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}