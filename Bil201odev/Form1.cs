using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bil201odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void kontrol() 
        {

            if (checkBox1.Checked == true)
            {
                if (Metin.Text.Contains(Aranacakifade.Text))
                {

                }
                else
                {
                    MessageBox.Show("Lütfen Metin girin ");
                } 
            }
            else if (checkBox2.Checked==true)
            {
                if (Metin.Text.Contains(Aranacakifade.Text))
                {

                }
                else
                {
                    MessageBox.Show("lütfen sayı girin ");
                }
            }
            else if (checkBox3.Checked ==true)
            {
                if (Metin.Text.Contains(Aranacakifade.Text))
                {

                }
                else
                {
                    MessageBox.Show("Lütfen karakter gir");
                }
            }
             

            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string metin = Metin.Text;
            string aranacakIfade = Aranacakifade.Text;

           


        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {

            int index = Metin.Text.IndexOf(Aranacakifade.Text);
            textBox3.Text += " \r\n" + "Metin indexi : " + index.ToString();



            kontrol();

            int metinUzunlugu = Metin.Text.Length;
            int aranacakifade = Aranacakifade.Text.Length;
            textBox3.Text += " \r\n" + "Metin Uzunlugu : " + metinUzunlugu +   "\r\n" +"Aranacak ifade Uzunlugu : "+ aranacakifade;

            ListViewItem item = new ListViewItem();
            item.Text = $"{listView1.Items.Count + 1}. \"{Aranacakifade}\" metinde aranmış ve {MetinIcindeKacKez(Metin.Text, Aranacakifade.Text)} defa bulunmuştur. Metnin uzunluğu {metinUzunlugu} karakterdir.";
            listView1.Items.Add(item);





            
        }
        private int MetinIcindeKacKez(string metin, string Aranacakifade)
        {
            int adet = 0;
            int index = -1;

            while ((index = metin.IndexOf(Aranacakifade, index + 1)) != -1)
            {
                adet++;
            }


            return adet;
        }

            private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage3;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            listView1.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(1, "Programa hoş geldiniz", "Nesne yönelimli programlama ödevi 1", ToolTipIcon.Info);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Aranacakifade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
