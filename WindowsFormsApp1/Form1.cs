using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void btnload1_Click(object sender, EventArgs e)

        {
            UserFileReader userFileReader = new UserFileReader();
            UserParser userParser = new UserParser();
            UserDisplayer userDisplayer = new UserDisplayer();
            User reader = new User();
            reader = userParser.Parse(userFileReader.FileOpen());
            textFullName.Text = userDisplayer.Name(reader);
            textYearofBirth.Text = reader.YearOfBirth.ToString();
            textCity.Text = reader.City.ToString();
            textFaculty.Text = reader.Faculty.ToString();
            textRole.Text = reader.Role.ToString();

            if (reader.Role == "student")
            {
                textDepartment.Text = reader.FavoriteCourse.ToString();
                labelRoleDep.Text = "Favorite course:";
            }
            else
            {
                textDepartment.Text = reader.Department.ToString();
                labelRoleDep.Text = "Department:";
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
           
        }
    }

   
}
