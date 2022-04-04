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
    public partial class FrmGeral : Form
    {
        public static FrmGeral instance;
        public FrmGeral()
        {
            InitializeComponent();
            instance = this;
        }
        #region CRONOMETRO 
        private void BtnCrono_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
        #endregion

        #region SAIR
        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TEMPORIZADOR
        private void BtnTemp_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        #endregion

        #region RELOGIO
        private void BtnRelog_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
        #endregion
    }
}
