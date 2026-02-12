using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace last_final_project
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "")
            {
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {

                    if (dataGridView1.Rows[k].Cells[2].Value.ToString() == textBox1.Text && dataGridView1.Rows[k].Cells[4].Value.ToString() == textBox2.Text)
                    {
                        external.username = dataGridView1.Rows[k].Cells[1].Value.ToString();

                        Form1 form = new Form1();
                        form.Show();

                        break;
                    }
                    else if (dataGridView1.Rows[k].Cells[2].Value.ToString() == textBox1.Text && dataGridView1.Rows[k].Cells[4].Value.ToString() != textBox2.Text)
                    {
                        MessageBox.Show("password is wrong try again! ");
                        break;
                    }
                    else
                    {
                        if (k != dataGridView1.Rows.Count)
                        {
                            continue;
                        }

                        DialogResult result = MessageBox.Show("Email not found You have to register your account", "warning", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            register resgiter = new register();
                            this.Hide();
                            resgiter.Show();

                            break;
                        }
                        else
                        {
                            Form1 form1 = new Form1();
                            this.Hide();
                            form1.Show();

                            break;
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Fields must not be empty");
            }
        }

        private void login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.users);

        }

        private void label5_Click(object sender, EventArgs e)
        {
            register register = new register();

            this.Hide();
            register.Show();
        }
    }
}
