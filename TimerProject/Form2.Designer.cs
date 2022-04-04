namespace TimerProject
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnIniciarCrono = new System.Windows.Forms.Button();
            this.BtnZerarCrono = new System.Windows.Forms.Button();
            this.BtnVoltarCrono = new System.Windows.Forms.Button();
            this.BtnPararCrono = new System.Windows.Forms.Button();
            this.LblCrono = new System.Windows.Forms.Label();
            this.TimerCrono = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblCrono);
            this.panel1.Controls.Add(this.BtnIniciarCrono);
            this.panel1.Controls.Add(this.BtnZerarCrono);
            this.panel1.Controls.Add(this.BtnVoltarCrono);
            this.panel1.Controls.Add(this.BtnPararCrono);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 400);
            this.panel1.TabIndex = 1;
            // 
            // BtnIniciarCrono
            // 
            this.BtnIniciarCrono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarCrono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarCrono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIniciarCrono.Location = new System.Drawing.Point(16, 126);
            this.BtnIniciarCrono.Name = "BtnIniciarCrono";
            this.BtnIniciarCrono.Size = new System.Drawing.Size(169, 47);
            this.BtnIniciarCrono.TabIndex = 5;
            this.BtnIniciarCrono.Text = "Iniciar";
            this.BtnIniciarCrono.UseVisualStyleBackColor = true;
            this.BtnIniciarCrono.Click += new System.EventHandler(this.BtnIniciarCrono_Click);
            // 
            // BtnZerarCrono
            // 
            this.BtnZerarCrono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZerarCrono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZerarCrono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnZerarCrono.Location = new System.Drawing.Point(17, 261);
            this.BtnZerarCrono.Name = "BtnZerarCrono";
            this.BtnZerarCrono.Size = new System.Drawing.Size(169, 47);
            this.BtnZerarCrono.TabIndex = 4;
            this.BtnZerarCrono.Text = "Zerar";
            this.BtnZerarCrono.UseVisualStyleBackColor = true;
            this.BtnZerarCrono.Click += new System.EventHandler(this.BtnZerarCrono_Click);
            // 
            // BtnVoltarCrono
            // 
            this.BtnVoltarCrono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarCrono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarCrono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVoltarCrono.Location = new System.Drawing.Point(17, 325);
            this.BtnVoltarCrono.Name = "BtnVoltarCrono";
            this.BtnVoltarCrono.Size = new System.Drawing.Size(169, 47);
            this.BtnVoltarCrono.TabIndex = 3;
            this.BtnVoltarCrono.Text = "Voltar";
            this.BtnVoltarCrono.UseVisualStyleBackColor = true;
            this.BtnVoltarCrono.Click += new System.EventHandler(this.BtnVoltarCrono_Click);
            // 
            // BtnPararCrono
            // 
            this.BtnPararCrono.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPararCrono.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPararCrono.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPararCrono.Location = new System.Drawing.Point(17, 194);
            this.BtnPararCrono.Name = "BtnPararCrono";
            this.BtnPararCrono.Size = new System.Drawing.Size(169, 47);
            this.BtnPararCrono.TabIndex = 0;
            this.BtnPararCrono.Text = "Parar";
            this.BtnPararCrono.UseVisualStyleBackColor = true;
            this.BtnPararCrono.Click += new System.EventHandler(this.BtnPararCrono_Click);
            // 
            // LblCrono
            // 
            this.LblCrono.AutoSize = true;
            this.LblCrono.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCrono.Location = new System.Drawing.Point(8, 22);
            this.LblCrono.Name = "LblCrono";
            this.LblCrono.Size = new System.Drawing.Size(191, 52);
            this.LblCrono.TabIndex = 6;
            this.LblCrono.Text = "00:00:00";
            this.LblCrono.Click += new System.EventHandler(this.LblCrono_Click);
            // 
            // TimerCrono
            // 
            this.TimerCrono.Enabled = true;
            this.TimerCrono.Tick += new System.EventHandler(this.TimerCrono_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(213, 424);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Cronômetro:.";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnIniciarCrono;
        private System.Windows.Forms.Button BtnZerarCrono;
        private System.Windows.Forms.Button BtnVoltarCrono;
        private System.Windows.Forms.Button BtnPararCrono;
        private System.Windows.Forms.Label LblCrono;
        private System.Windows.Forms.Timer TimerCrono;
    }
}