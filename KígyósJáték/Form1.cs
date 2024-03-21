using System.Windows.Forms;

namespace KígyósJáték
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int irany_x = 1;
        int irany_y = 0;
        int lépésszám;
        Random rnd = new Random();
        List<KígyóElem> kígyó = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            int xhely = 200;
            int yhely = 100;
            Kaja kaja = new Kaja();
            kaja.Top = yhely;
            kaja.Left = xhely;
            Controls.Add(kaja);
            if (fej_x == xhely && fej_y == yhely)
            {
                KígyóElem.hossz++;
                Controls.Remove(kaja);

            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lépésszám++;
            

            fej_x += irany_x * KígyóElem.Méret;
            fej_y += irany_y * KígyóElem.Méret;

            foreach (object item in Controls)
            {
                if (item is KígyóElem)
                {
                    KígyóElem k = (KígyóElem)item;

                    if (k.Top == fej_y && k.Left == fej_x)
                    { timer1.Enabled = false; return; }
                }
            }

            

           
            KígyóElem ke = new KígyóElem();
            ke.Top = fej_y;
            ke.Left = fej_x;
            kígyó.Add(ke);
            Controls.Add(ke);

            if (kígyó.Count > KígyóElem.hossz) 
            {
                KígyóElem levágandó = kígyó[0];
                kígyó.RemoveAt(0);
                Controls.Remove(levágandó);
            }

            if (lépésszám % 2 == 0) ke.BackColor = Color.GreenYellow;


            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) 
            {
                irany_y = -1;
                irany_x = 0;
            }
            if (e.KeyCode == Keys.Down)
            {
                irany_y = 1;
                irany_x = 0;
            }
            if(e.KeyCode == Keys.Left)
            {
                irany_x = -1;
                irany_y = 0;
            }
            if(e.KeyCode == Keys.Right)
            {
                irany_x = 1;
                irany_y = 0;
            }
            

        }

        
    }
}