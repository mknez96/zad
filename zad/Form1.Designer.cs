namespace zad
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUnosCijene = new System.Windows.Forms.TextBox();
            this.textBoxUnosVrste = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxIspis = new System.Windows.Forms.TextBox();
            this.gumbUnesi = new System.Windows.Forms.Button();
            this.gumbPretrazi = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPretraga = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Unos troška:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Unos vrste troška:";
            // 
            // textBoxUnosCijene
            // 
            this.textBoxUnosCijene.Location = new System.Drawing.Point(103, 27);
            this.textBoxUnosCijene.Name = "textBoxUnosCijene";
            this.textBoxUnosCijene.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnosCijene.TabIndex = 2;
            // 
            // textBoxUnosVrste
            // 
            this.textBoxUnosVrste.Location = new System.Drawing.Point(129, 63);
            this.textBoxUnosVrste.Name = "textBoxUnosVrste";
            this.textBoxUnosVrste.Size = new System.Drawing.Size(100, 20);
            this.textBoxUnosVrste.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ispis:";
            // 
            // textBoxIspis
            // 
            this.textBoxIspis.Location = new System.Drawing.Point(33, 166);
            this.textBoxIspis.Multiline = true;
            this.textBoxIspis.Name = "textBoxIspis";
            this.textBoxIspis.Size = new System.Drawing.Size(325, 219);
            this.textBoxIspis.TabIndex = 5;
            // 
            // gumbUnesi
            // 
            this.gumbUnesi.Location = new System.Drawing.Point(274, 42);
            this.gumbUnesi.Name = "gumbUnesi";
            this.gumbUnesi.Size = new System.Drawing.Size(84, 37);
            this.gumbUnesi.TabIndex = 6;
            this.gumbUnesi.Text = "Unesi";
            this.gumbUnesi.UseVisualStyleBackColor = true;
            this.gumbUnesi.Click += new System.EventHandler(this.gumbUnesi_Click);
            // 
            // gumbPretrazi
            // 
            this.gumbPretrazi.Location = new System.Drawing.Point(669, 196);
            this.gumbPretrazi.Name = "gumbPretrazi";
            this.gumbPretrazi.Size = new System.Drawing.Size(75, 23);
            this.gumbPretrazi.TabIndex = 7;
            this.gumbPretrazi.Text = "Pretraži";
            this.gumbPretrazi.UseVisualStyleBackColor = true;
            this.gumbPretrazi.Click += new System.EventHandler(this.gumbPretrazi_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Koji trošak želite pretražiti:";
            // 
            // textBoxPretraga
            // 
            this.textBoxPretraga.Location = new System.Drawing.Point(538, 198);
            this.textBoxPretraga.Name = "textBoxPretraga";
            this.textBoxPretraga.Size = new System.Drawing.Size(100, 20);
            this.textBoxPretraga.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPretraga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gumbPretrazi);
            this.Controls.Add(this.gumbUnesi);
            this.Controls.Add(this.textBoxIspis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxUnosVrste);
            this.Controls.Add(this.textBoxUnosCijene);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUnosCijene;
        private System.Windows.Forms.TextBox textBoxUnosVrste;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxIspis;
        private System.Windows.Forms.Button gumbUnesi;
        private System.Windows.Forms.Button gumbPretrazi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPretraga;
    }
}

