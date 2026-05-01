using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class FrmInfoStudent : Form
    {
        public FrmInfoStudent()
        {

            InitializeComponent();
        }

        private void CLEAR_BTN_Click(object sender, EventArgs e)
        {


            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }

        private void utton5_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the program?",
                                                "Confirm Exit",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);


            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void SUBMIT_BTN_Click_1(object sender, EventArgs e)
        {
            StudentInfo student = new StudentInfo(
            IDTXT.Text,
            FIRSTNAMETXT.Text,
            LASTNAMETXT.Text

            );

            listBox1.Items.Add(student.StudentID);
            listBox2.Items.Add(student.FirstName);
            listBox3.Items.Add(student.LastName);
        }
    }

}
