using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTehtava17
{
    public partial class Jätkänshakki : Form
    {
        int kohta1 = 0;
        int kohta2 = 0;
        int[] napit = new int[25];
        Bitmap X = Properties.Resources.X;
        Bitmap O = Properties.Resources.O;
        int pelaaja = 0;
        int klikkaus1 = 0;
        int klikkaus2 = 0;
        int voitot1 = 0;
        int voitot2 = 0;
        public Jätkänshakki()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button nappi = (Button)sender;
            if (pelaaja == 0)
            {
                nappi.Image = X;
                pelaaja = 1;
                klikkaus1++;
                label3.Text = Convert.ToString(klikkaus1);
                nappi.Click -= button_Click;
                napit[Convert.ToInt32(nappi.Tag)] = 1;
                label5.Text = Convert.ToString(voitot1);
                label6.Text = Convert.ToString(voitot2);
            }
            else
            {
                nappi.Image = O;
                pelaaja = 0;
                klikkaus2++;
                label4.Text = Convert.ToString(klikkaus2);
                nappi.Click -= button_Click;
                napit[Convert.ToInt32(nappi.Tag)] = 2;
                label5.Text = Convert.ToString(voitot1);
                label6.Text = Convert.ToString(voitot2);
            }
            //Pystyrivit
            for (int i = 0; i < 25; i++)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            //Vaakarivit
            for (int i = 0; i < 25; i = i + 5)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            for (int i = 1; i < 25; i = i + 5)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            for (int i = 2; i < 25; i = i + 5)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            for (int i = 3; i < 25; i = i + 5)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            for (int i = 4; i < 25; i = i + 5)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }

            //Vinorivit
            for (int i = 0; i < 25; i = i + 6)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
            for (int i = 4; i < 25; i = i + 4)
            {
                if (napit[i] == 1)
                {
                    kohta1++;
                }
                else
                {
                    kohta1 = 0;
                }
                if (kohta1 == 5)
                {
                    MessageBox.Show("Rasti voitti!");
                    voitot1++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
                if (napit[i] == 2)
                {
                    kohta2++;
                }
                else
                {
                    kohta2 = 0;
                }
                if (kohta2 == 5)
                {
                    MessageBox.Show("Ympyrä voitti!");
                    voitot2++;
                    foreach (Button element in this.Controls.OfType<Button>())
                    {
                        if (element.Name != "button26")
                        {
                            element.Click -= button_Click;
                        }
                    }
                }
            }
        }
        //Resetti
        private void button26_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 25; i++)
            {
                napit[i] = 0;
            }
            kohta1 = 0;
            kohta2 = 0;
            pelaaja = 0;
            klikkaus1 = 0;
            label3.Text = klikkaus1.ToString();
            klikkaus2 = 0;
            label4.Text = klikkaus2.ToString(); 
            foreach (Button element in this.Controls.OfType<Button>())
            {
                if (element.Name != "button26")
                {
                    element.Image = null;
                    element.Click -= button_Click;
                    element.Click += button_Click;
                }       
            }
        }
    }
}
