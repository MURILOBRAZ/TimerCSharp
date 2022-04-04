namespace TimerProject
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblTempori = new System.Windows.Forms.Label();
            this.BtnIniciarTempori = new System.Windows.Forms.Button();
            this.BtnZerarTempori = new System.Windows.Forms.Button();
            this.BtnVoltarTempori = new System.Windows.Forms.Button();
            this.BtnPararTempori = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.LblTempori);
            this.panel1.Controls.Add(this.BtnVoltarTempori);
            this.panel1.Controls.Add(this.BtnIniciarTempori);
            this.panel1.Controls.Add(this.BtnZerarTempori);
            this.panel1.Controls.Add(this.BtnPararTempori);
            this.panel1.Location = new System.Drawing.Point(13, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 278);
            this.panel1.TabIndex = 2;
            // 
            // LblTempori
            // 
            this.LblTempori.AutoSize = true;
            this.LblTempori.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTempori.Location = new System.Drawing.Point(68, 77);
            this.LblTempori.Name = "LblTempori";
            this.LblTempori.Size = new System.Drawing.Size(284, 73);
            this.LblTempori.TabIndex = 6;
            this.LblTempori.Text = "00:00:00";
            // 
            // BtnIniciarTempori
            // 
            this.BtnIniciarTempori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciarTempori.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIniciarTempori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnIniciarTempori.Location = new System.Drawing.Point(3, 175);
            this.BtnIniciarTempori.Name = "BtnIniciarTempori";
            this.BtnIniciarTempori.Size = new System.Drawing.Size(169, 47);
            this.BtnIniciarTempori.TabIndex = 5;
            this.BtnIniciarTempori.Text = "Iniciar";
            this.BtnIniciarTempori.UseVisualStyleBackColor = true;
            // 
            // BtnZerarTempori
            // 
            this.BtnZerarTempori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnZerarTempori.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZerarTempori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnZerarTempori.Location = new System.Drawing.Point(250, 175);
            this.BtnZerarTempori.Name = "BtnZerarTempori";
            this.BtnZerarTempori.Size = new System.Drawing.Size(169, 47);
            this.BtnZerarTempori.TabIndex = 4;
            this.BtnZerarTempori.Text = "Zerar";
            this.BtnZerarTempori.UseVisualStyleBackColor = true;
            // 
            // BtnVoltarTempori
            // 
            this.BtnVoltarTempori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarTempori.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarTempori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVoltarTempori.Location = new System.Drawing.Point(250, 228);
            this.BtnVoltarTempori.Name = "BtnVoltarTempori";
            this.BtnVoltarTempori.Size = new System.Drawing.Size(169, 47);
            this.BtnVoltarTempori.TabIndex = 3;
            this.BtnVoltarTempori.Text = "Voltar";
            this.BtnVoltarTempori.UseVisualStyleBackColor = true;
            // 
            // BtnPararTempori
            // 
            this.BtnPararTempori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPararTempori.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPararTempori.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnPararTempori.Location = new System.Drawing.Point(3, 228);
            this.BtnPararTempori.Name = "BtnPararTempori";
            this.BtnPararTempori.Size = new System.Drawing.Size(169, 47);
            this.BtnPararTempori.TabIndex = 0;
            this.BtnPararTempori.Text = "Parar";
            this.BtnPararTempori.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 7;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(250, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(169, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 302);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = ".:Temporizador:.";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblTempori;
        private System.Windows.Forms.Button BtnIniciarTempori;
        private System.Windows.Forms.Button BtnZerarTempori;
        private System.Windows.Forms.Button BtnVoltarTempori;
        private System.Windows.Forms.Button BtnPararTempori;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}