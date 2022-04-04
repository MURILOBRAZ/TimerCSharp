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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        #region Form
        private void Form4_Load(object sender, EventArgs e)
        {
           // this.Text = DateTime.Now.ToString();
        }
        #endregion

        #region TIMER
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.LblRelog.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        #endregion

        #region VOLTAR
        private void BtnVoltarRelog_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
