namespace VillogoGomb
{
    public partial class Form1 : Form
    {
        int m�ret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

            for(int sor=0; sor<10; sor++)
            {
                for (int oszlop=0; oszlop<10; oszlop++)
                {
                   SzamoloGomb b = new SzamoloGomb();
                    //b.Height = m�ret;
                    //b.Width = m�ret;
                    b.Left = oszlop * m�ret;
                    b.Top = sor * m�ret;
                    //b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }

    }
}