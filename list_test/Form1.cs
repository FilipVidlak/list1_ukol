using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace list_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        } 
        List<int> seznamcisel = new List<int>();
        Random rng = new Random();
        public void Vypis()
        {
            MessageBox.Show("První pozice maximální čísla: " + seznamcisel.IndexOf(seznamcisel.Max()));
            MessageBox.Show("Poslední pozice maximální čísla: " + seznamcisel.LastIndexOf(seznamcisel.Max()));
            MessageBox.Show("Průměr všech vygenerovaných čísel: " + seznamcisel.Average().ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < int.Parse(textBox1.Text); i++)
                {
                    int znak = rng.Next(19, 30);
                    seznamcisel.Distinct().ToList();
                    seznamcisel.Add(znak);
                    button2.Enabled = true;
                }
                //vypsat
                foreach (int znak in seznamcisel)
                {
                    listBox1.Items.Add(znak);
                }
                Vypis();
            }
            catch { MessageBox.Show("Zadej správnou hodnotu!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string vystup = "";
                foreach (int znak in seznamcisel)
                {
                bool lol = true;
                if (znak > 0)
                {
                    for (int j = 2; j <= znak / 2 && lol; j++)
                    {
                        if (znak % j == 0) { lol = false; }
                    }
                    if (lol) { vystup += znak + " "; }
                }
               
                }
            MessageBox.Show("Prvočísla jsou: " + vystup,  "Prvočíslo", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
      
    }
}
