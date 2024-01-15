namespace Chess___96
{
    partial class Form1
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
            this.btnBasla = new System.Windows.Forms.Button();
            this.btnBeyaz = new System.Windows.Forms.Button();
            this.btnSİyah = new System.Windows.Forms.Button();
            this.lblBeyaz = new System.Windows.Forms.Label();
            this.lblSiyah = new System.Windows.Forms.Label();
            this.timerBeyaz = new System.Windows.Forms.Timer(this.components);
            this.timerSiyah = new System.Windows.Forms.Timer(this.components);
            this.lblMesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBasla.Location = new System.Drawing.Point(12, 41);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(198, 34);
            this.btnBasla.TabIndex = 0;
            this.btnBasla.Text = "BAŞLA";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // btnBeyaz
            // 
            this.btnBeyaz.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnBeyaz.Location = new System.Drawing.Point(12, 107);
            this.btnBeyaz.Name = "btnBeyaz";
            this.btnBeyaz.Size = new System.Drawing.Size(128, 34);
            this.btnBeyaz.TabIndex = 1;
            this.btnBeyaz.Text = "BEYAZ";
            this.btnBeyaz.UseVisualStyleBackColor = false;
            this.btnBeyaz.Click += new System.EventHandler(this.btnBeyaz_Click);
            // 
            // btnSİyah
            // 
            this.btnSİyah.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnSİyah.Location = new System.Drawing.Point(12, 175);
            this.btnSİyah.Name = "btnSİyah";
            this.btnSİyah.Size = new System.Drawing.Size(128, 34);
            this.btnSİyah.TabIndex = 2;
            this.btnSİyah.Text = "SİYAH";
            this.btnSİyah.UseVisualStyleBackColor = false;
            this.btnSİyah.Click += new System.EventHandler(this.btnSİyah_Click);
            // 
            // lblBeyaz
            // 
            this.lblBeyaz.AutoSize = true;
            this.lblBeyaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBeyaz.Location = new System.Drawing.Point(175, 116);
            this.lblBeyaz.Name = "lblBeyaz";
            this.lblBeyaz.Size = new System.Drawing.Size(14, 16);
            this.lblBeyaz.TabIndex = 3;
            this.lblBeyaz.Text = "0";
            // 
            // lblSiyah
            // 
            this.lblSiyah.AutoSize = true;
            this.lblSiyah.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSiyah.Location = new System.Drawing.Point(175, 184);
            this.lblSiyah.Name = "lblSiyah";
            this.lblSiyah.Size = new System.Drawing.Size(14, 16);
            this.lblSiyah.TabIndex = 4;
            this.lblSiyah.Text = "0";
            // 
            // timerBeyaz
            // 
            this.timerBeyaz.Interval = 1000;
            this.timerBeyaz.Tick += new System.EventHandler(this.timerBeyaz_Tick);
            // 
            // timerSiyah
            // 
            this.timerSiyah.Interval = 1000;
            this.timerSiyah.Tick += new System.EventHandler(this.timerSiyah_Tick);
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMesaj.Location = new System.Drawing.Point(12, 22);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(22, 16);
            this.lblMesaj.TabIndex = 5;
            this.lblMesaj.Text = "***";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(246, 275);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.lblSiyah);
            this.Controls.Add(this.lblBeyaz);
            this.Controls.Add(this.btnSİyah);
            this.Controls.Add(this.btnBeyaz);
            this.Controls.Add(this.btnBasla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Button btnBeyaz;
        private System.Windows.Forms.Button btnSİyah;
        private System.Windows.Forms.Label lblBeyaz;
        private System.Windows.Forms.Label lblSiyah;
        private System.Windows.Forms.Timer timerBeyaz;
        private System.Windows.Forms.Timer timerSiyah;
        private System.Windows.Forms.Label lblMesaj;
    }
}

