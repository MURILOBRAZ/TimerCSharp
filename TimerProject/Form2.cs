using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TimerProject
{
    public partial class Form2 : Form
    {
        private Stopwatch stopwatch;
        public Form2()
        {
            InitializeComponent();
        }

        #region FORM
        private void Form2_Load(object sender, EventArgs e)
        {
            stopwatch = new Stopwatch();
        }
        #endregion

        #region INICIAR
        private void BtnIniciarCrono_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
        }

        #endregion

        #region PARAR
        private void BtnPararCrono_Click(object sender, EventArgs e)
        {
            stopwatch.Stop();
        }
        #endregion

        #region ZERAR
        private void BtnZerarCrono_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
        }
        #endregion

        #region VOLTAR  
        private void BtnVoltarCrono_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TIMER   
        private void TimerCrono_Tick(object sender, EventArgs e)
        {
            this.LblCrono.Text = stopwatch.Elapsed.ToString();
        }
        #endregion

        #region LIXO
        private void LblCrono_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
