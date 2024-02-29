using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VillogoGomb
{
    internal class SzamoloGomb : Button
    {
        int szám;
        public SzamoloGomb()
        {
            Height = 20;
            Width = 20;
            szám = 1;        
            Click += SzamoloGomb_Click;
            Text=1.ToString();
        }

        private void SzamoloGomb_Click(object? sender, EventArgs e)
        {
            szám++;
            if(szám==6)
            {
                szám = 1;
            }
            Text=szám.ToString();   
        }
    }
}
