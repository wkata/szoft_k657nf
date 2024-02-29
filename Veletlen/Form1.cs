namespace Veletlen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random rnd= new Random(); 
            

            for(int i=0;i<100;i++)
            {
                Button b = new Button();
                b.Top=rnd.Next(0,ClientRectangle.Height);
                b.Left=rnd.Next(0,ClientRectangle.Width);
                b.Width = rnd.Next(20, 60);
                b.Height = rnd.Next(20, 60);
                int r = rnd.Next(0, 256);
                int g = rnd.Next(0, 256);
                int bl = rnd.Next(0, 256);
                b.BackColor = Color.FromArgb(r,g,bl);
                Controls.Add(b);
            }
        }
    }
}