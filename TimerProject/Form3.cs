using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            for(int i = 0; i  > 60; i++)
            {

                this.comboBox1.Items.Add(i.ToString());
                this.comboBox1.Items.Add(i.ToString());

            }

            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;
        }
    }
}
