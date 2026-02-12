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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                for (int k = 0; k < dataGridView1.Rows.Count; k++)
                {
                    if (dataGridView1.Rows[k].Cells[2].Value.ToString() == textBox2.Text && dataGridView1.Rows[k].Cells[4].Value.ToString() == textBox4.Text)
                    {
                        DialogResult result = MessageBox.Show("This email is already exit Do you want to login ? ", "warning", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            login login = new login();
                            this.Hide();
                            login.Show();

                            break;
                        }
                        else
                        {
                            Form1 form = new Form1();
                            this.Hide();
                            form.Show();

                            break;
                        }
                    }
                    else
                    {
                        usersTableAdapter.InsertQuery(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, "user");
                        MessageBox.Show("successfully added");

                        this.usersTableAdapter.Fill(this.database1DataSet.users);

                        external.username = textBox1.Text;

                        Form1 form1 = new Form1();
                        this.Hide();
                        form1.Show();

                        break;
                    }
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {
            login login = new login();
            this.Hide();
            login.Show();
        }
        private void register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.database1DataSet.users);

        }
    }
}
