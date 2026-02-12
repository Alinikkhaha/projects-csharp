using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectPAge149Finally
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            label3.Text = "You have " + counter.ToString() + " chances";
            label4.Hide();
        }

        int counter = 3;
        int minute = 1;
        int seconds = 60;
        bool isActive = false;

        public void timers ()
        {
            if (seconds != 0)
            {
                timer1.Start();
                minute = 0;
                seconds--;
                label4.Text = minute.ToString() + ":" + seconds.ToString();
                textBox1.Enabled = false;
                textBox2.Enabled = false;
            }
            else
            {
                timer1.Stop();
                minute = 1;
                seconds = 59;
                label4.Hide();
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                --counter;

                label3.Text = "You have " + counter.ToString() + "chances";

                if (counter == 0)
                {
                    label4.Show();
                    counter = 3;
                    label3.Text = "You have " + counter.ToString() + " chances";

                    isActive = true;
                    this.timers();
                }
            }
            else
            {
                external.exportName = textBox1.Text;

                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isActive)
            {
                this.timers();
            }
        }

        private void LoginForm_Load(object sender, EventArgs e) {}
    }
}
