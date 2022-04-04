namespace TimerProject
{
    partial class FrmGeral
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGeral));
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSair = new System.Windows.Forms.Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCrono = new System.Windows.Forms.Button();
            this.BtnTemp = new System.Windows.Forms.Button();
            this.BtnRelog = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(14, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "-----------------------------------------------";
            // 
            // BtnSair
            // 
            this.BtnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSair.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnSair.Location = new System.Drawing.Point(17, 327);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(169, 47);
            this.BtnSair.TabIndex = 0;
            this.BtnSair.Text = "SAIR";
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LblTitle.Location = new System.Drawing.Point(13, 11);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(147, 29);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "O Que Deseja?";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnRelog);
            this.panel1.Controls.Add(this.BtnTemp);
            this.panel1.Controls.Add(this.BtnCrono);
            this.panel1.Controls.Add(this.LblTitle);
            this.panel1.Controls.Add(this.BtnSair);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 400);
            this.panel1.TabIndex = 0;
            // 
            // BtnCrono
            // 
            this.BtnCrono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCrono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnCrono.Location = new System.Drawing.Point(17, 250);
            this.BtnCrono.Name = "BtnCrono";
            this.BtnCrono.Size = new System.Drawing.Size(169, 47);
            this.BtnCrono.TabIndex = 3;
            this.BtnCrono.Text = "Cronômetro";
            this.BtnCrono.UseVisualStyleBackColor = true;
            this.BtnCrono.Click += new System.EventHandler(this.BtnCrono_Click);
            // 
            // BtnTemp
            // 
            this.BtnTemp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTemp.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnTemp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnTemp.Location = new System.Drawing.Point(17, 176);
            this.BtnTemp.Name = "BtnTemp";
            this.BtnTemp.Size = new System.Drawing.Size(169, 47);
            this.BtnTemp.TabIndex = 4;
            this.BtnTemp.Text = "Temporizador";
            this.BtnTemp.UseVisualStyleBackColor = true;
            this.BtnTemp.Click += new System.EventHandler(this.BtnTemp_Click);
            // 
            // BtnRelog
            // 
            this.BtnRelog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRelog.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRelog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnRelog.Location = new System.Drawing.Point(17, 98);
            this.BtnRelog.Name = "BtnRelog";
            this.BtnRelog.Size = new System.Drawing.Size(169, 47);
            this.BtnRelog.TabIndex = 5;
            this.BtnRelog.Text = "Relógio";
            this.BtnRelog.UseVisualStyleBackColor = true;
            this.BtnRelog.Click += new System.EventHandler(this.BtnRelog_Click);
            // 
            // FrmGeral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(213, 424);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGeral";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Temporizador:.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnRelog;
        private System.Windows.Forms.Button BtnTemp;
        private System.Windows.Forms.Button BtnCrono;
    }
}

