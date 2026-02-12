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
    public partial class foundForm : Form
    {
        public foundForm()
        {
            InitializeComponent();
        }

        private void foundForm_Load(object sender, EventArgs e)
        {
            label8.Text = external.bookNameAnswer;
            label9.Text = external.moalefAnswer;
            label10.Text = external.motargemAnswer;
            label11.Text = external.entesharatAnswer;
            label12.Text = external.salechap;
            label13.Text = external.titleAnswer;
            label14.Text = external.shabakNameAnswer;
            pictureBox1.ImageLocation = external.pictureBoxUrl;
        }
    }
}
