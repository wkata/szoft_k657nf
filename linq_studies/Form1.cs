using linq_studies.Models;

namespace linq_studies
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl1 usercontrol1 = new UserControl1();
            panel1.Controls.Add(usercontrol1);
            usercontrol1.Dock = DockStyle.Fill;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserControl2 usercontrol2 = new UserControl2();
            panel1.Controls.Add(usercontrol2);
            usercontrol2.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}