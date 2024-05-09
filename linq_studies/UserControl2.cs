using linq_studies.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linq_studies
{
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();
        }

        

        private void UserControl2_Load(object sender, EventArgs e)
        {
            var klist = from k in context.Courses
                        select k;

            listBox1.DataSource = klist.ToList();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from k in context.Courses
                                  where k.Name.Contains(textBox1.Text)
                                  select k).ToList();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course course = (Course)listBox1.SelectedItem;

            dataGridView1.DataSource = (from l in context.Lessons
                                       where l.CourseFk == course.CourseSk
                                       select new
                                       {
                                           Nap = l.DayFkNavigation.Name,
                                           Sáv = l.TimeFkNavigation.Name,
                                           Oktató = l.InstructorFkNavigation.Name
                                       }).ToList();
        }
    }
}
