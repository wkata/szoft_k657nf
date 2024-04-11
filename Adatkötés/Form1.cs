using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace Adatkötés
{
    public partial class Form1 : Form
    {
        BindingList<CData> countryList = new BindingList<CData>();
        public Form1()
        {
            InitializeComponent();
            cDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = cDataBindingSource;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cDataBindingSource.RemoveCurrent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.CData = cDataBindingSource.Current as CData;
            f2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using(var writer= new StreamWriter("countries.csv"))
            using(var csv= new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            };
        }
    }
}