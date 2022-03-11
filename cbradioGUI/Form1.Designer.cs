
namespace cbradioGUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comb_nev = new System.Windows.Forms.ComboBox();
            this.tb_ido = new System.Windows.Forms.TextBox();
            this.nur_adas = new System.Windows.Forms.NumericUpDown();
            this.bt_mentes = new System.Windows.Forms.Button();
            this.tb_fajlba = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_adatlist = new System.Windows.Forms.Label();
            this.listb_adatok = new System.Windows.Forms.ListBox();
            this.tb_nev = new System.Windows.Forms.TextBox();
            this.tb_kereses = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nur_adas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_fajlba);
            this.groupBox1.Controls.Add(this.bt_mentes);
            this.groupBox1.Controls.Add(this.nur_adas);
            this.groupBox1.Controls.Add(this.tb_ido);
            this.groupBox1.Controls.Add(this.comb_nev);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adatrögzítés";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sofőr neve";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(38, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adás ideje (óó:pp)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(38, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adások száma";
            // 
            // comb_nev
            // 
            this.comb_nev.FormattingEnabled = true;
            this.comb_nev.Location = new System.Drawing.Point(177, 73);
            this.comb_nev.Name = "comb_nev";
            this.comb_nev.Size = new System.Drawing.Size(121, 21);
            this.comb_nev.TabIndex = 2;
            // 
            // tb_ido
            // 
            this.tb_ido.Location = new System.Drawing.Point(177, 171);
            this.tb_ido.Name = "tb_ido";
            this.tb_ido.Size = new System.Drawing.Size(100, 20);
            this.tb_ido.TabIndex = 3;
            // 
            // nur_adas
            // 
            this.nur_adas.Location = new System.Drawing.Point(177, 268);
            this.nur_adas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nur_adas.Name = "nur_adas";
            this.nur_adas.Size = new System.Drawing.Size(120, 20);
            this.nur_adas.TabIndex = 4;
            this.nur_adas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bt_mentes
            // 
            this.bt_mentes.Location = new System.Drawing.Point(51, 342);
            this.bt_mentes.Name = "bt_mentes";
            this.bt_mentes.Size = new System.Drawing.Size(75, 23);
            this.bt_mentes.TabIndex = 5;
            this.bt_mentes.Text = "Mentés";
            this.bt_mentes.UseVisualStyleBackColor = true;
            this.bt_mentes.Click += new System.EventHandler(this.bt_mentes_Click);
            // 
            // tb_fajlba
            // 
            this.tb_fajlba.Location = new System.Drawing.Point(263, 342);
            this.tb_fajlba.Name = "tb_fajlba";
            this.tb_fajlba.Size = new System.Drawing.Size(102, 23);
            this.tb_fajlba.TabIndex = 1;
            this.tb_fajlba.Text = "Mentés fájlba";
            this.tb_fajlba.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_kereses);
            this.groupBox2.Controls.Add(this.tb_nev);
            this.groupBox2.Controls.Add(this.listb_adatok);
            this.groupBox2.Controls.Add(this.lb_adatlist);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(455, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Keresés";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(37, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sofőrnév";
            // 
            // lb_adatlist
            // 
            this.lb_adatlist.AutoSize = true;
            this.lb_adatlist.Location = new System.Drawing.Point(37, 174);
            this.lb_adatlist.Name = "lb_adatlist";
            this.lb_adatlist.Size = new System.Drawing.Size(72, 13);
            this.lb_adatlist.TabIndex = 1;
            this.lb_adatlist.Text = "Adások listája";
            // 
            // listb_adatok
            // 
            this.listb_adatok.FormattingEnabled = true;
            this.listb_adatok.Location = new System.Drawing.Point(67, 190);
            this.listb_adatok.Name = "listb_adatok";
            this.listb_adatok.Size = new System.Drawing.Size(203, 212);
            this.listb_adatok.TabIndex = 2;
            // 
            // tb_nev
            // 
            this.tb_nev.Location = new System.Drawing.Point(132, 73);
            this.tb_nev.Name = "tb_nev";
            this.tb_nev.Size = new System.Drawing.Size(128, 20);
            this.tb_nev.TabIndex = 3;
            // 
            // tb_kereses
            // 
            this.tb_kereses.Location = new System.Drawing.Point(106, 126);
            this.tb_kereses.Name = "tb_kereses";
            this.tb_kereses.Size = new System.Drawing.Size(112, 23);
            this.tb_kereses.TabIndex = 4;
            this.tb_kereses.Text = "Keresés";
            this.tb_kereses.UseVisualStyleBackColor = true;
            this.tb_kereses.Click += new System.EventHandler(this.tb_kereses_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nur_adas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button tb_fajlba;
        private System.Windows.Forms.Button bt_mentes;
        private System.Windows.Forms.NumericUpDown nur_adas;
        private System.Windows.Forms.TextBox tb_ido;
        private System.Windows.Forms.ComboBox comb_nev;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button tb_kereses;
        private System.Windows.Forms.TextBox tb_nev;
        private System.Windows.Forms.ListBox listb_adatok;
        private System.Windows.Forms.Label lb_adatlist;
        private System.Windows.Forms.Label label4;
    }
}

