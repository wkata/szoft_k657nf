namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<Sor> lista = new List<Sor>();

            for (int i = 0; i < 10; i++)
            {
                Button n�v = new Button();
                n�v.Text = Fibonacci(i).ToString();
                n�v.Top = i * 20;
                Controls.Add(n�v);
                
                Sor �jSor =new Sor();
                �jSor.�rt�k = Fibonacci(i);
                �jSor.Sorsz�m = i;
                lista.Add(�jSor);

            }


            dataGridView1.DataSource = lista;

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);

        }
    }
}