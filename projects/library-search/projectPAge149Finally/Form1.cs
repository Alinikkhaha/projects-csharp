using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPAge149Finally
{
    public partial class Form1 : Form
    {
        bool isActive = false;

        LoginForm login = new LoginForm();
        public Form1()
        {
            InitializeComponent();
            this.checkDisable();
        }
        public void checkDisable ()
        {
            label2.Text = external.exportName == null ? "مهمان" : external.exportName ;
            
            if (label2.Text == "مهمان")
            {
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;
                textBox13.Enabled = false;
                textBox14.Enabled = false;
                textBox15.Enabled = false;
                textBox16.Enabled = false;
                textBox17.Enabled = false;
                button4.Enabled = false;
                button5.Enabled = false;
                button6.Enabled = false;
                button7.Enabled = false;
                button8.Enabled = false;
                button9.Enabled = false;
            }
            else
            {
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;
                textBox11.Enabled = true;
                textBox12.Enabled = true;
                textBox13.Enabled = true;
                textBox14.Enabled = true;
                textBox15.Enabled = true;
                textBox16.Enabled = true;
                textBox17.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button7.Enabled = true;
                button8.Enabled = true;
                button9.Enabled = true;
            }
        }

        List<string> codeMeLi = new List<string>();
        List<string> codeOzviyat = new List<string>();
        List<string> membersName = new List<string>();
        List<string> membersFamilyName = new List<string>();
        List<string> membersTelefon = new List<string>();
        List<string> membersPictures = new List<string>();
        private void button6_Click(object sender, EventArgs e) 
        {
            if (textBox5.Text == "" && textBox6.Text == "" && textBox7.Text == "" && textBox8.Text == "" && textBox9.Text == "")
            {
                MessageBox.Show("fill all the form");
            }
            else
            {
                codeOzviyat.Add(textBox5.Text);
                membersName.Add(textBox6.Text);
                membersFamilyName.Add(textBox7.Text);
                codeMeLi.Add(textBox8.Text);
                membersTelefon.Add(textBox9.Text);
                membersPictures.Add(pictureBox1.ImageLocation);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e) {}

        private void radioButton2_CheckedChanged(object sender, EventArgs e){}

        
        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter something");
                }
                else
                {
                    for (int k = 0; k < bookName.Count; k++)
                    {
                        if (bookName[k] == textBox1.Text )
                        {
                            
                            external.bookNameAnswer = textBox1.Text;
                            external.moalefAnswer = moalef[k];
                            external.motargemAnswer = motargem[k];
                            external.entesharatAnswer = entesharat[k];
                            external.salechap = saleChap[k];
                            external.titleAnswer = title[k];
                            external.shabakNameAnswer = shabak[k];
                            external.pictureBoxUrl = bookPictures[k];

                            foundForm foundForm = new foundForm();
                            foundForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                    }
                }
            }

            if (radioButton2.Checked)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Plese enter something");
                }
                else
                {
                    for (int k = 0; k < moalef.Count; k++)
                    {
                        if (moalef[k] == textBox2.Text)
                        {

                            external.bookNameAnswer = bookName[k];
                            external.moalefAnswer = textBox2.Text;
                            external.motargemAnswer = motargem[k];
                            external.entesharatAnswer = entesharat[k];
                            external.salechap = saleChap[k];
                            external.titleAnswer = title[k];
                            external.shabakNameAnswer = shabak[k];
                            external.pictureBoxUrl = bookPictures[k];

                            foundForm foundForm = new foundForm();
                            foundForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                    }
                }
            }


            if (radioButton3.Checked)
            {
                if (textBox3.Text == "")
                {
                    MessageBox.Show("Plese enter something");
                }
                else
                {
                    for (int k = 0; k < title.Count; k++)
                    {
                        if (title[k] == textBox3.Text)
                        {

                            external.bookNameAnswer = bookName[k];
                            external.moalefAnswer = moalef[k];
                            external.motargemAnswer = motargem[k];
                            external.entesharatAnswer = entesharat[k];
                            external.salechap = saleChap[k];
                            external.titleAnswer = textBox3.Text;
                            external.shabakNameAnswer = shabak[k];
                            external.pictureBoxUrl = bookPictures[k];

                            foundForm foundForm = new foundForm();
                            foundForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                    }
                }
            }


            if (radioButton4.Checked)
            {
                if (textBox4.Text == "")
                {
                    MessageBox.Show("Plese enter something");
                }
                else
                {
                    for (int k = 0; k < saleChap.Count; k++)
                    {
                        if (saleChap[k] == textBox4.Text)
                        {

                            external.bookNameAnswer = bookName[k];
                            external.moalefAnswer = moalef[k];
                            external.motargemAnswer = motargem[k];
                            external.entesharatAnswer = entesharat[k];
                            external.salechap = textBox4.Text;
                            external.titleAnswer = title[k];
                            external.shabakNameAnswer = shabak[k];
                            external.pictureBoxUrl = bookPictures[k];

                            foundForm foundForm = new foundForm();
                            foundForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("not found");
                        }
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.ShowDialog();
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.ImageLocation = openFileDialog1.FileName;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            pictureBox1.ImageLocation = "";
        }
        
        List<string> bookName = new List<string>();
        List<string> moalef = new List<string>();
        List<string> motargem = new List<string>();
        List<string> entesharat = new List<string>();
        List<string> saleChap = new List<string>();
        List<string> title = new List<string>();
        List<string> shabak = new List<string>();
        List<string> bookPictures = new List<string>();


        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "" && textBox12.Text == "" && textBox13.Text == "" && textBox14.Text == "" && textBox15.Text == "" && textBox16.Text == "" && textBox17.Text == "" )
            {
                MessageBox.Show("fill all the form");
            }
            else
            {
                bookName.Add(textBox11.Text);
                moalef.Add(textBox12.Text);
                motargem.Add(textBox13.Text);
                entesharat.Add(textBox14.Text);
                saleChap.Add(textBox15.Text);
                title.Add(textBox16.Text);
                shabak.Add(textBox17.Text);
                bookPictures.Add(pictureBox2.ImageLocation);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.ImageLocation = openFileDialog1.FileName;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox11.Text = ""; textBox12.Text = ""; textBox13.Text = ""; textBox14.Text = ""; textBox15.Text = ""; textBox16.Text = ""; textBox17.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
