namespace TimerProject
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnVoltarRelog = new System.Windows.Forms.Button();
            this.LblRelog = new System.Windows.Forms.Label();
            this.TimerRelog = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnVoltarRelog);
            this.panel1.Controls.Add(this.LblRelog);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 166);
            this.panel1.TabIndex = 0;
            // 
            // BtnVoltarRelog
            // 
            this.BtnVoltarRelog.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnVoltarRelog.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltarRelog.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnVoltarRelog.Location = new System.Drawing.Point(251, 116);
            this.BtnVoltarRelog.Name = "BtnVoltarRelog";
            this.BtnVoltarRelog.Size = new System.Drawing.Size(169, 47);
            this.BtnVoltarRelog.TabIndex = 9;
            this.BtnVoltarRelog.Text = "Voltar";
            this.BtnVoltarRelog.UseVisualStyleBackColor = true;
            this.BtnVoltarRelog.Click += new System.EventHandler(this.BtnVoltarRelog_Click);
            // 
            // LblRelog
            // 
            this.LblRelog.AutoSize = true;
            this.LblRelog.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRelog.Location = new System.Drawing.Point(3, 0);
            this.LblRelog.Name = "LblRelog";
            this.LblRelog.Size = new System.Drawing.Size(417, 108);
            this.LblRelog.TabIndex = 8;
            this.LblRelog.Text = "00:00:00";
            // 
            // TimerRelog
            // 
            this.TimerRelog.Enabled = true;
            this.TimerRelog.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(447, 190);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = ".:Relógio:.";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblRelog;
        private System.Windows.Forms.Button BtnVoltarRelog;
        private System.Windows.Forms.Timer TimerRelog;
    }
}