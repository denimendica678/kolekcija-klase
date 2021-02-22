using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace praktičnaUpotrebaKolekcije
{
    
    public partial class Form1 : Form
    {
        List<Brkovi> lista = new List<Brkovi>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Brkovi brk in lista)
            {
                if(brk.Pod4.ToString() == "M")
                {
                    brk.Dodatak = "Ima brkove.";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "Podatak 1" + "\t" + "Podatak 2" + "\t" + "Podatak 3" + "\t" + "Podatak 4" + "\r\n";
            foreach (Brkovi brk in lista)
            {
                richTextBox1.AppendText(brk.ToString());
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Brkovi brk = new Brkovi(textBox1.Text, textBox2.Text,
                    Convert.ToInt32(textBox3),
                    Convert.ToChar(comboBox1.SelectedItem));

                lista.Add(brk);

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                

            }
            catch (Exception greska)
            {
                MessageBox.Show("greška");
            }
        
        }
    }
}
