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
        List<Pacient> seznampacientu = new List<Pacient>();
        Random rng = new Random();
        bool JePrvocislo(int znak)
        {
            
        }
        public void Vypis()
        {
            MessageBox.Show("První pozice maximální čísla: " + seznamcisel.IndexOf(seznamcisel.Max()));
            MessageBox.Show("Poslední pozice maximální čísla: " + seznamcisel.LastIndexOf(seznamcisel.Max()));
            MessageBox.Show("Průměr všech vygenerovaných čísel: " + seznamcisel.Average().ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textBox1.Text); i++)
            {
                int znak = rng.Next(19, 30);
                seznamcisel.Add(znak);
            }
            //vypsat
            foreach (int znak in seznamcisel)
            {
                seznamcisel.Distinct().ToList();
                listBox1.Items.Add(znak);
            }
            Vypis();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
                //pres string
                /*   foreach (int znak in seznamcisel)
                   {
                       seznamcisel.Sort();
                       MessageBox.Show("Seřazeno", "Done", znak.ToString());
                   }
                */
                /* seznamcisel.Sort();
                 string lol = string.Join(Environment.NewLine, seznamcisel.ToArray());
                 MessageBox.Show("Seřazeno", "Done", lol);
                */
                string vystup = "";
                foreach (int znak in seznamcisel)
                {
                    vystup += znak + " ";
                }
                MessageBox.Show(vystup);
            }
      
    }
}
