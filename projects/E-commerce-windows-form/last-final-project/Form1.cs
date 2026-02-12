using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace last_final_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            checkIfUserIsAdminOrNot();
        }

        string checkName;
        public void checkIfUserIsAdminOrNot()
        {
            checkName = external.username == null ? "ghost" : external.username;

            label2.Text = checkName;

            if (checkName != "ghost")
            {
                label3.Text = "exit";
            }

            // for checkUserBasket Empty or not 

            if (checkName == "ghost") // جای true باید رول کاربر چک شه که ببینه ادمین هست یا ادمین نیست /////   if it's admin
            {
                adminPenlToolStripMenuItem.Visible = false;
            }
            else
            {
                if (external.username == "ali")
                {
                    adminPenlToolStripMenuItem.Visible = true;
                }
                else
                {
                    adminPenlToolStripMenuItem.Visible = false;
                }
            }
        }
        public void checkLabel16()
        {
            if (dataGridView3.Rows.Count != 1)
            {
                label16.Visible = false;
                label17.Visible = true;
                label18.Visible = true;
                button6.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                pictureBox8.Visible = true;
                label19.Visible = true;
                label20.Visible = true;
                label21.Visible = true;
                label22.Visible = true;
                label23.Visible = true;
                label24.Visible = true;
                label25.Visible = true;
                label26.Visible = true;
            }
            else
            {
                label16.Visible = true;
                label17.Visible = false;
                label18.Visible = false;
                button6.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                pictureBox8.Visible = false;
                label19.Visible = false;
                label20.Visible = false;
                label21.Visible = false;
                label22.Visible = false;
                label23.Visible = false;
                label24.Visible = false;
                label25.Visible = false;
                label26.Visible = false;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.database1DataSet2.products);
            // TODO: This line of code loads data into the 'database1DataSet2.userBasket' table. You can move, or remove it, as needed.
            this.userBasketTableAdapter.Fill(this.database1DataSet2.userBasket);
            // TODO: This line of code loads data into the 'database1DataSet1.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.database1DataSet1.products);

            // TODO: This line of code loads data into the 'database1DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.users);

            // TODO: This line of code loads data into the 'database1DataSet.products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.database1DataSet.products);

            this.checkLabel16();

            //dataGridView3.Visible = false;
            //dataGridView4.Visible = false;
            //dataGridView1.Visible = false;
            //dataGridView2.Visible = false;

            pictureBox1.Image = Image.FromFile(dataGridView1.Rows[1].Cells[5].Value.ToString());
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            label8.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            label9.Text = dataGridView1.Rows[1].Cells[3].Value.ToString();

            pictureBox2.Image = Image.FromFile(dataGridView1.Rows[2].Cells[5].Value.ToString());
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            label10.Text = dataGridView1.Rows[2].Cells[3].Value.ToString();
            label11.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();

            pictureBox3.Image = Image.FromFile(dataGridView1.Rows[3].Cells[5].Value.ToString());
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;
            label12.Text = dataGridView1.Rows[3].Cells[3].Value.ToString();
            label13.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();


            pictureBox4.Image = Image.FromFile(dataGridView1.Rows[4].Cells[5].Value.ToString());
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            label14.Text = dataGridView1.Rows[4].Cells[3].Value.ToString();
            label15.Text = dataGridView1.Rows[4].Cells[1].Value.ToString();

            //  بقیه عکسای مربوط به محصولات اضافه شود

            pictureBox9.Image = Image.FromFile(dataGridView1.Rows[1].Cells[5].Value.ToString());
            pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
            label33.Text = dataGridView1.Rows[1].Cells[3].Value.ToString();
            label32.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();

            pictureBox10.Image = Image.FromFile(dataGridView1.Rows[2].Cells[5].Value.ToString());
            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
            label34.Text = dataGridView1.Rows[2].Cells[3].Value.ToString();
            label35.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();

            pictureBox11.Image = Image.FromFile(dataGridView1.Rows[3].Cells[5].Value.ToString());
            pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
            label36.Text = dataGridView1.Rows[3].Cells[3].Value.ToString();
            label37.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();

            pictureBox12.Image = Image.FromFile(dataGridView1.Rows[4].Cells[5].Value.ToString());
            pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
            label38.Text = dataGridView1.Rows[4].Cells[3].Value.ToString();
            label39.Text = dataGridView1.Rows[4].Cells[1].Value.ToString();

            pictureBox13.Image = Image.FromFile(dataGridView1.Rows[5].Cells[5].Value.ToString());
            pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
            label40.Text = dataGridView1.Rows[5].Cells[3].Value.ToString();
            label41.Text = dataGridView1.Rows[5].Cells[1].Value.ToString();

            pictureBox14.Image = Image.FromFile(dataGridView1.Rows[6].Cells[5].Value.ToString());
            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
            label42.Text = dataGridView1.Rows[6].Cells[3].Value.ToString();
            label43.Text = dataGridView1.Rows[6].Cells[1].Value.ToString();

            pictureBox15.Image = Image.FromFile(dataGridView1.Rows[7].Cells[5].Value.ToString());
            pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
            label44.Text = dataGridView1.Rows[7].Cells[3].Value.ToString();
            label45.Text = dataGridView1.Rows[7].Cells[1].Value.ToString();

            pictureBox16.Image = Image.FromFile(dataGridView1.Rows[8].Cells[5].Value.ToString());
            pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
            label46.Text = dataGridView1.Rows[8].Cells[3].Value.ToString();
            label47.Text = dataGridView1.Rows[8].Cells[1].Value.ToString();

            pictureBox17.Image = Image.FromFile(dataGridView1.Rows[9].Cells[5].Value.ToString());
            pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
            label48.Text = dataGridView1.Rows[9].Cells[3].Value.ToString();
            label49.Text = dataGridView1.Rows[9].Cells[1].Value.ToString();

            pictureBox18.Image = Image.FromFile(dataGridView1.Rows[1].Cells[5].Value.ToString());
            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
            label50.Text = dataGridView1.Rows[1].Cells[3].Value.ToString();
            label51.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[] colors = { "red", "gray", "black", "yellow", "purple", "orange" };

            if (label3.Text != "exit")
            {
                Random random = new Random();

                int randomNumber = random.Next(colors.Length);

                string names = colors[randomNumber];

                label3.ForeColor = Color.FromName(names);
            }
            else
            {
                label3.ForeColor = Color.Red;
            }
        }
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1home;
        }
        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2products;
        }

        private void adminPenlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1adminPanel;
        }

        private void userBasketToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1userBasket;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

            if (checkName != "ghost")
            {
                label3.Text = "login/register";
                label2.Text = "ghost";
            }
            else
            {
                login login = new login();

                this.Hide();
                login.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dataGridView5.AllowUserToAddRows = true;

            int index = dataGridView5.Rows.Count - 1;

             //MessageBox.Show(dataGridView5.Rows[index].Cells[1].Value.ToString());

            dataGridView5.Rows.Add();

            dataGridView5.Rows[index].Cells[1].Value = textBox1.Text;
            dataGridView5.Rows[index].Cells[2].Value = textBox2.Text;
            dataGridView5.Rows[index].Cells[3].Value = textBox3.Text;
            dataGridView5.Rows[index].Cells[4].Value = textBox4.Text;
            dataGridView5.Rows[index].Cells[5].Value = textBox6.Text;

            this.productsTableAdapter.Fill(this.database1DataSet1.products);

            //MessageBox.Show(dataGridView1.Rows[index].Cells[0].Value.ToString());

            //dataGridView1.Rows[index].Cells[2].Value = textBox2.Text;
            //dataGridView1.Rows[index].Cells[3].Value = textBox3.Text;
            //dataGridView1.Rows[index].Cells[4].Value = textBox4.Text;
        }

        int finalPrice = 0;
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (label2.Text != "ghost")
            {
                int index = dataGridView3.Rows.Count - 1;
                dataGridView3.Rows.Add();

                dataGridView3.Rows[index].Cells[0].Value = dataGridView2.Rows[1].Cells[0].Value;
                dataGridView3.Rows[index].Cells[1].Value = dataGridView2.Rows[1].Cells[1].Value;
                dataGridView3.Rows[index].Cells[2].Value = dataGridView2.Rows[1].Cells[2].Value;
                dataGridView3.Rows[index].Cells[3].Value = dataGridView2.Rows[1].Cells[3].Value;
                dataGridView3.Rows[index].Cells[4].Value = dataGridView2.Rows[1].Cells[4].Value;
                dataGridView3.Rows[index].Cells[5].Value = dataGridView2.Rows[1].Cells[5].Value;

                this.checkLabel16();

                //finalPrice += Convert.ToInt32(dataGridView3.Rows[1].Cells[3].Value);
                //label18.Text = finalPrice.ToString();

                // get user basket and show in cart

                //pictureBox5.Image = Image.FromFile(dataGridView3.Rows[0].Cells[4].Value.ToString());
                //label20.Text = dataGridView3.Rows[0].Cells[0].Value.ToString();
                //label19.Text = dataGridView3.Rows[0].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("sorry you don't have any account");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (label2.Text != "ghost")
            {
                int index = dataGridView3.Rows.Count - 1;
                dataGridView3.Rows.Add();

                dataGridView3.Rows[index].Cells[0].Value = dataGridView2.Rows[2].Cells[0].Value;
                dataGridView3.Rows[index].Cells[1].Value = dataGridView2.Rows[2].Cells[1].Value;
                dataGridView3.Rows[index].Cells[2].Value = dataGridView2.Rows[2].Cells[2].Value;
                dataGridView3.Rows[index].Cells[3].Value = dataGridView2.Rows[2].Cells[3].Value;
                dataGridView3.Rows[index].Cells[4].Value = dataGridView2.Rows[2].Cells[4].Value;
                dataGridView3.Rows[index].Cells[5].Value = dataGridView2.Rows[2].Cells[5].Value;

                this.checkLabel16();

                //finalPrice += Convert.ToInt32(dataGridView3.Rows[2].Cells[3].Value);
                //label18.Text = finalPrice.ToString();

                // get user basket and show in cart

                //pictureBox6.Image = Image.FromFile(dataGridView3.Rows[1].Cells[4].Value.ToString());
                //label22.Text = dataGridView3.Rows[1].Cells[0].Value.ToString();
                //label21.Text = dataGridView3.Rows[1].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("sorry you don't have any account");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (label2.Text != "ghost")
            {
                int index = dataGridView3.Rows.Count - 1;

                dataGridView3.Rows.Add();

                dataGridView3.Rows[index].Cells[0].Value = dataGridView2.Rows[3].Cells[0].Value;
                dataGridView3.Rows[index].Cells[1].Value = dataGridView2.Rows[3].Cells[1].Value;
                dataGridView3.Rows[index].Cells[2].Value = dataGridView2.Rows[3].Cells[2].Value;
                dataGridView3.Rows[index].Cells[3].Value = dataGridView2.Rows[3].Cells[3].Value;
                dataGridView3.Rows[index].Cells[4].Value = dataGridView2.Rows[3].Cells[4].Value;
                dataGridView3.Rows[index].Cells[5].Value = dataGridView2.Rows[3].Cells[5].Value;

                this.checkLabel16();
            }
            else
            {
                MessageBox.Show("sorry you don't have any account");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (label2.Text != "ghost")
            {
                int index = dataGridView3.Rows.Count - 1;
                dataGridView3.Rows.Add();

                dataGridView3.Rows[index].Cells[0].Value = dataGridView2.Rows[4].Cells[0].Value;
                dataGridView3.Rows[index].Cells[1].Value = dataGridView2.Rows[4].Cells[1].Value;
                dataGridView3.Rows[index].Cells[2].Value = dataGridView2.Rows[4].Cells[2].Value;
                dataGridView3.Rows[index].Cells[3].Value = dataGridView2.Rows[4].Cells[3].Value;
                dataGridView3.Rows[index].Cells[4].Value = dataGridView2.Rows[4].Cells[4].Value;
                dataGridView3.Rows[index].Cells[5].Value = dataGridView2.Rows[4].Cells[5].Value;

                this.checkLabel16();
            }
            else
            {
                MessageBox.Show("sorry you don't have any account");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            productsTableAdapter.showAllUserBasket(database1DataSet.products);

            //label18.Text = 

            //label18.Text = productsTableAdapter.sum().ToString();

            pictureBox5.Image = Image.FromFile(dataGridView3.Rows[0].Cells[5].Value.ToString());
            label20.Text = dataGridView3.Rows[0].Cells[1].Value.ToString();
            label19.Text = dataGridView3.Rows[0].Cells[3].Value.ToString();


            pictureBox6.Image = Image.FromFile(dataGridView3.Rows[1].Cells[5].Value.ToString());
            label22.Text = dataGridView3.Rows[1].Cells[1].Value.ToString();
            label21.Text = dataGridView3.Rows[1].Cells[3].Value.ToString();

            pictureBox7.Image = Image.FromFile(dataGridView3.Rows[2].Cells[5].Value.ToString());
            label24.Text = dataGridView3.Rows[2].Cells[1].Value.ToString();
            label23.Text = dataGridView3.Rows[2].Cells[3].Value.ToString();

            pictureBox8.Image = Image.FromFile(dataGridView3.Rows[3].Cells[5].Value.ToString());
            label26.Text = dataGridView3.Rows[3].Cells[1].Value.ToString();
            label25.Text = dataGridView3.Rows[3].Cells[3].Value.ToString();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            //productsTableAdapter.searchValue(this.productsTableAdapter);

            productsTableAdapter.searchLive(this.database1DataSet1.products , textBox5.Text);

            int index = dataGridView1.Rows.Count - 1;

            if (dataGridView1.Rows.Count > 1)
            {
                for (int k = 0; k < index; k++)
                {
                    if (dataGridView1.Rows[k].Cells[1].Value != null)
                    {
                        pictureBox9.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                        pictureBox9.BackgroundImageLayout = ImageLayout.Stretch;
                        label33.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                        label32.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                        k++;

                        if (dataGridView1.Rows[k].Cells[1].Value != null)
                        {
                            pictureBox10.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                            pictureBox10.BackgroundImageLayout = ImageLayout.Stretch;
                            label34.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                            label35.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                            k++;

                            if (dataGridView1.Rows[k].Cells[1].Value != null)
                            {
                                pictureBox11.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                pictureBox11.BackgroundImageLayout = ImageLayout.Stretch;
                                label36.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                label37.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                k++;

                                if (dataGridView1.Rows[k].Cells[1].Value != null)
                                {
                                    pictureBox12.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                    pictureBox12.BackgroundImageLayout = ImageLayout.Stretch;
                                    label38.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                    label39.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                    k++;

                                    if (dataGridView1.Rows[k].Cells[1].Value != null)
                                    {
                                        pictureBox13.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                        pictureBox13.BackgroundImageLayout = ImageLayout.Stretch;
                                        label40.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                        label41.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                        k++;

                                        if (dataGridView1.Rows[k].Cells[1].Value != null)
                                        {
                                            pictureBox14.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                            pictureBox14.BackgroundImageLayout = ImageLayout.Stretch;
                                            label42.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                            label43.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                            k++;

                                            if (dataGridView1.Rows[k].Cells[1].Value != null)
                                            {

                                                pictureBox15.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                                pictureBox15.BackgroundImageLayout = ImageLayout.Stretch;
                                                label44.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                                label45.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                                k++;

                                                if (dataGridView1.Rows[k].Cells[1].Value != null)
                                                {
                                                    pictureBox16.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                                    pictureBox16.BackgroundImageLayout = ImageLayout.Stretch;
                                                    label46.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                                    label47.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                                    k++;

                                                    if (dataGridView1.Rows[k].Cells[1].Value != null)
                                                    {
                                                        pictureBox17.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                                        pictureBox17.BackgroundImageLayout = ImageLayout.Stretch;
                                                        label48.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                                        label49.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                                        k++;

                                                        if (dataGridView1.Rows[k].Cells[1].Value != null)
                                                        {
                                                            pictureBox18.Image = Image.FromFile(dataGridView1.Rows[k].Cells[5].Value.ToString());
                                                            pictureBox18.BackgroundImageLayout = ImageLayout.Stretch;
                                                            label50.Text = dataGridView1.Rows[k].Cells[3].Value.ToString();
                                                            label51.Text = dataGridView1.Rows[k].Cells[1].Value.ToString();

                                                        }
                                                        else
                                                        {
                                                            pictureBox18.Visible = false;
                                                            label50.Visible = false;
                                                            label51.Visible = false;
                                                            break;
                                                        }
                                                    }
                                                    else
                                                    {
                                                        pictureBox17.Visible = false;
                                                        label48.Visible = false;
                                                        label49.Visible = false;

                                                        pictureBox18.Visible = false;
                                                        label50.Visible = false;
                                                        label51.Visible = false;
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    pictureBox16.Visible = false;
                                                    label46.Visible = false;
                                                    label47.Visible = false;

                                                    pictureBox17.Visible = false;
                                                    label48.Visible = false;
                                                    label49.Visible = false;

                                                    pictureBox18.Visible = false;
                                                    label50.Visible = false;
                                                    label51.Visible = false;

                                                    break;
                                                }
                                            }
                                            else
                                            {
                                                pictureBox15.Visible = false;
                                                label44.Visible = false;
                                                label45.Visible = false;

                                                pictureBox16.Visible = false;
                                                label46.Visible = false;
                                                label47.Visible = false;

                                                pictureBox17.Visible = false;
                                                label48.Visible = false;
                                                label49.Visible = false;

                                                pictureBox18.Visible = false;
                                                label50.Visible = false;
                                                label51.Visible = false;

                                                break;
                                            }
                                        }
                                        else
                                        {
                                            pictureBox14.Visible = false;
                                            label42.Visible = false;
                                            label43.Visible = false;

                                            pictureBox15.Visible = false;
                                            label44.Visible = false;
                                            label45.Visible = false;

                                            pictureBox16.Visible = false;
                                            label46.Visible = false;
                                            label47.Visible = false;

                                            pictureBox17.Visible = false;
                                            label48.Visible = false;
                                            label49.Visible = false;

                                            pictureBox18.Visible = false;
                                            label50.Visible = false;
                                            label51.Visible = false;
                                            break;
                                        }
                                    }
                                    else {

                                        pictureBox13.Visible = false;
                                        label40.Visible = false;
                                        label41.Visible = false;

                                        pictureBox14.Visible = false;
                                        label42.Visible = false;
                                        label43.Visible = false;

                                        pictureBox15.Visible = false;
                                        label44.Visible = false;
                                        label45.Visible = false;

                                        pictureBox16.Visible = false;
                                        label46.Visible = false;
                                        label47.Visible = false;

                                        pictureBox17.Visible = false;
                                        label48.Visible = false;
                                        label49.Visible = false;

                                        pictureBox18.Visible = false;
                                        label50.Visible = false;
                                        label51.Visible = false;

                                        break;
                                    }

                                }
                                else
                                {
                                    pictureBox12.Visible = false;
                                    label38.Visible = false;
                                    label39.Visible = false;

                                    pictureBox13.Visible = false;
                                    label40.Visible = false;
                                    label41.Visible = false;

                                    pictureBox14.Visible = false;
                                    label42.Visible = false;
                                    label43.Visible = false;

                                    pictureBox15.Visible = false;
                                    label44.Visible = false;
                                    label45.Visible = false;

                                    pictureBox16.Visible = false;
                                    label46.Visible = false;
                                    label47.Visible = false;

                                    pictureBox17.Visible = false;
                                    label48.Visible = false;
                                    label49.Visible = false;

                                    pictureBox18.Visible = false;
                                    label50.Visible = false;
                                    label51.Visible = false;
                                    break;
                                }
                            }
                            else
                            {
                                pictureBox11.Visible = false;
                                label36.Visible = false;
                                label37.Visible = false;

                                pictureBox12.Visible = false;
                                label38.Visible = false;
                                label39.Visible = false;

                                pictureBox13.Visible = false;
                                label40.Visible = false;
                                label41.Visible = false;

                                pictureBox14.Visible = false;
                                label42.Visible = false;
                                label43.Visible = false;

                                pictureBox15.Visible = false;
                                label44.Visible = false;
                                label45.Visible = false;

                                pictureBox16.Visible = false;
                                label46.Visible = false;
                                label47.Visible = false;

                                pictureBox17.Visible = false;
                                label48.Visible = false;
                                label49.Visible = false;

                                pictureBox18.Visible = false;
                                label50.Visible = false;
                                label51.Visible = false;

                                break;
                            }
                        }
                        else
                        {
                            pictureBox10.Visible = false;
                            label34.Visible = false;
                            label35.Visible = false;

                            pictureBox11.Visible = false;
                            label36.Visible = false;
                            label37.Visible = false;

                            pictureBox12.Visible = false;
                            label38.Visible = false;
                            label39.Visible = false;

                            pictureBox13.Visible = false;
                            label40.Visible = false;
                            label41.Visible = false;

                            pictureBox14.Visible = false;
                            label42.Visible = false;
                            label43.Visible = false;

                            pictureBox15.Visible = false;
                            label44.Visible = false;
                            label45.Visible = false;

                            pictureBox16.Visible = false;
                            label46.Visible = false;
                            label47.Visible = false;

                            pictureBox17.Visible = false;
                            label48.Visible = false;
                            label49.Visible = false;

                            pictureBox18.Visible = false;
                            label50.Visible = false;
                            label51.Visible = false;

                            break;
                        }
                    }
                    else
                    {
                        pictureBox9.Visible = false;
                        label32.Visible = false;
                        label33.Visible = false;

                        pictureBox10.Visible = false;
                        label34.Visible = false;
                        label35.Visible = false;

                        pictureBox11.Visible = false;
                        label36.Visible = false;
                        label37.Visible = false;

                        pictureBox12.Visible = false;
                        label38.Visible = false;
                        label39.Visible = false;

                        pictureBox13.Visible = false;
                        label40.Visible = false;
                        label41.Visible = false;

                        pictureBox14.Visible = false;
                        label42.Visible = false;
                        label43.Visible = false;

                        pictureBox15.Visible = false;
                        label44.Visible = false;
                        label45.Visible = false;

                        pictureBox16.Visible = false;
                        label46.Visible = false;
                        label47.Visible = false;

                        pictureBox17.Visible = false;
                        label48.Visible = false;
                        label49.Visible = false;

                        pictureBox18.Visible = false;
                        label50.Visible = false;
                        label51.Visible = false;

                        break;
                    }
                }
            }
            else
            {

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            productsTableAdapter.deletes(textBox14.Text);

            this.productsTableAdapter.Fill(this.database1DataSet.products);

        }

        private void button8_Click(object sender, EventArgs e)
        {
            int p1 = int.Parse(textBox11.Text);
            productsTableAdapter.updateQueryByAdmin(textBox8.Text, p1 , textBox8.Text);

            this.productsTableAdapter.Fill(this.database1DataSet.products);

            textBox8.Text = "";
            textBox11.Text = "";

        }
    }
}
