namespace WindowsFormsControlLibrary1
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.broj_varijabli = new System.Windows.Forms.Label();
            this.dekrement = new System.Windows.Forms.Button();
            this.inkrement = new System.Windows.Forms.Button();
            this.tekst_br_varijabli = new System.Windows.Forms.Label();
            this.broj_nili_vrata = new System.Windows.Forms.Label();
            this.broj_ni_vrata = new System.Windows.Forms.Label();
            this.inkrement_ni = new System.Windows.Forms.Button();
            this.inkrement_nili = new System.Windows.Forms.Button();
            this.svijetlo_X0 = new System.Windows.Forms.Label();
            this.svijetlo_X4 = new System.Windows.Forms.Label();
            this.svijetlo_X3 = new System.Windows.Forms.Label();
            this.svijetlo_X2 = new System.Windows.Forms.Label();
            this.svijetlo_X1 = new System.Windows.Forms.Label();
            this.izbornik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.izlaz = new System.Windows.Forms.Label();
            this.reset_lights = new System.Windows.Forms.Button();
            this.counting_point = new System.Windows.Forms.Button();
            this.add_cabel = new System.Windows.Forms.Button();
            this.izlaz_svijetlo = new WindowsFormsControlLibrary1.CircularLabel();
            this.circularLabel1 = new WindowsFormsControlLibrary1.CircularLabel();
            this.SuspendLayout();
            // 
            // broj_varijabli
            // 
            this.broj_varijabli.BackColor = System.Drawing.Color.Coral;
            this.broj_varijabli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.broj_varijabli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_varijabli.Location = new System.Drawing.Point(50, 400);
            this.broj_varijabli.Name = "broj_varijabli";
            this.broj_varijabli.Size = new System.Drawing.Size(30, 30);
            this.broj_varijabli.TabIndex = 17;
            this.broj_varijabli.Text = "1";
            this.broj_varijabli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dekrement
            // 
            this.dekrement.BackColor = System.Drawing.Color.Red;
            this.dekrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dekrement.Location = new System.Drawing.Point(14, 400);
            this.dekrement.Name = "dekrement";
            this.dekrement.Size = new System.Drawing.Size(30, 30);
            this.dekrement.TabIndex = 18;
            this.dekrement.Text = "-";
            this.dekrement.UseVisualStyleBackColor = false;
            this.dekrement.Click += new System.EventHandler(this.dekrement_Click);
            // 
            // inkrement
            // 
            this.inkrement.BackColor = System.Drawing.Color.Lime;
            this.inkrement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkrement.Location = new System.Drawing.Point(86, 400);
            this.inkrement.Name = "inkrement";
            this.inkrement.Size = new System.Drawing.Size(30, 30);
            this.inkrement.TabIndex = 19;
            this.inkrement.Text = "+";
            this.inkrement.UseVisualStyleBackColor = false;
            this.inkrement.Click += new System.EventHandler(this.inkrement_Click);
            // 
            // tekst_br_varijabli
            // 
            this.tekst_br_varijabli.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tekst_br_varijabli.Location = new System.Drawing.Point(10, 380);
            this.tekst_br_varijabli.Name = "tekst_br_varijabli";
            this.tekst_br_varijabli.Size = new System.Drawing.Size(110, 15);
            this.tekst_br_varijabli.TabIndex = 20;
            this.tekst_br_varijabli.Text = "BROJ VARIJABLI";
            this.tekst_br_varijabli.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // broj_nili_vrata
            // 
            this.broj_nili_vrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_nili_vrata.Location = new System.Drawing.Point(143, 380);
            this.broj_nili_vrata.Name = "broj_nili_vrata";
            this.broj_nili_vrata.Size = new System.Drawing.Size(126, 15);
            this.broj_nili_vrata.TabIndex = 21;
            this.broj_nili_vrata.Text = "DODAJ NILI VRATA";
            this.broj_nili_vrata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // broj_ni_vrata
            // 
            this.broj_ni_vrata.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.broj_ni_vrata.Location = new System.Drawing.Point(143, 415);
            this.broj_ni_vrata.Name = "broj_ni_vrata";
            this.broj_ni_vrata.Size = new System.Drawing.Size(126, 15);
            this.broj_ni_vrata.TabIndex = 22;
            this.broj_ni_vrata.Text = "DODAJ NI VRATA";
            this.broj_ni_vrata.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inkrement_ni
            // 
            this.inkrement_ni.BackColor = System.Drawing.Color.Lime;
            this.inkrement_ni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkrement_ni.Location = new System.Drawing.Point(275, 407);
            this.inkrement_ni.Name = "inkrement_ni";
            this.inkrement_ni.Size = new System.Drawing.Size(30, 30);
            this.inkrement_ni.TabIndex = 27;
            this.inkrement_ni.Text = "+";
            this.inkrement_ni.UseVisualStyleBackColor = false;
            this.inkrement_ni.Click += new System.EventHandler(this.inkrement_ni_Click);
            // 
            // inkrement_nili
            // 
            this.inkrement_nili.BackColor = System.Drawing.Color.Lime;
            this.inkrement_nili.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inkrement_nili.Location = new System.Drawing.Point(275, 375);
            this.inkrement_nili.Name = "inkrement_nili";
            this.inkrement_nili.Size = new System.Drawing.Size(30, 30);
            this.inkrement_nili.TabIndex = 28;
            this.inkrement_nili.Text = "+";
            this.inkrement_nili.UseVisualStyleBackColor = false;
            this.inkrement_nili.Click += new System.EventHandler(this.inkrement_nili_Click);
            // 
            // svijetlo_X0
            // 
            this.svijetlo_X0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svijetlo_X0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svijetlo_X0.Location = new System.Drawing.Point(590, 375);
            this.svijetlo_X0.Name = "svijetlo_X0";
            this.svijetlo_X0.Size = new System.Drawing.Size(25, 25);
            this.svijetlo_X0.TabIndex = 30;
            this.svijetlo_X0.Text = "X0";
            this.svijetlo_X0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svijetlo_X4
            // 
            this.svijetlo_X4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svijetlo_X4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svijetlo_X4.Location = new System.Drawing.Point(470, 375);
            this.svijetlo_X4.Name = "svijetlo_X4";
            this.svijetlo_X4.Size = new System.Drawing.Size(25, 25);
            this.svijetlo_X4.TabIndex = 31;
            this.svijetlo_X4.Text = "X4";
            this.svijetlo_X4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svijetlo_X3
            // 
            this.svijetlo_X3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svijetlo_X3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svijetlo_X3.Location = new System.Drawing.Point(500, 375);
            this.svijetlo_X3.Name = "svijetlo_X3";
            this.svijetlo_X3.Size = new System.Drawing.Size(25, 25);
            this.svijetlo_X3.TabIndex = 32;
            this.svijetlo_X3.Text = "X3";
            this.svijetlo_X3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svijetlo_X2
            // 
            this.svijetlo_X2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svijetlo_X2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svijetlo_X2.Location = new System.Drawing.Point(530, 375);
            this.svijetlo_X2.Name = "svijetlo_X2";
            this.svijetlo_X2.Size = new System.Drawing.Size(25, 25);
            this.svijetlo_X2.TabIndex = 33;
            this.svijetlo_X2.Text = "X2";
            this.svijetlo_X2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // svijetlo_X1
            // 
            this.svijetlo_X1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.svijetlo_X1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svijetlo_X1.Location = new System.Drawing.Point(560, 375);
            this.svijetlo_X1.Name = "svijetlo_X1";
            this.svijetlo_X1.Size = new System.Drawing.Size(25, 25);
            this.svijetlo_X1.TabIndex = 34;
            this.svijetlo_X1.Text = "X1";
            this.svijetlo_X1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // izbornik
            // 
            this.izbornik.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.izbornik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.izbornik.ForeColor = System.Drawing.SystemColors.ControlText;
            this.izbornik.Location = new System.Drawing.Point(0, 370);
            this.izbornik.Name = "izbornik";
            this.izbornik.Size = new System.Drawing.Size(700, 80);
            this.izbornik.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(630, 450);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 100);
            this.label1.TabIndex = 35;
            this.label1.Text = "label1";
            // 
            // izlaz
            // 
            this.izlaz.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.izlaz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.izlaz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.izlaz.Location = new System.Drawing.Point(650, 160);
            this.izlaz.Name = "izlaz";
            this.izlaz.Size = new System.Drawing.Size(50, 50);
            this.izlaz.TabIndex = 36;
            this.izlaz.Text = "Y";
            this.izlaz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // reset_lights
            // 
            this.reset_lights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_lights.Location = new System.Drawing.Point(650, 412);
            this.reset_lights.Name = "reset_lights";
            this.reset_lights.Size = new System.Drawing.Size(35, 35);
            this.reset_lights.TabIndex = 39;
            this.reset_lights.Text = "R";
            this.reset_lights.UseVisualStyleBackColor = true;
            this.reset_lights.Click += new System.EventHandler(this.Reset_lights_Click);
            // 
            // counting_point
            // 
            this.counting_point.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.counting_point.Location = new System.Drawing.Point(650, 373);
            this.counting_point.Name = "counting_point";
            this.counting_point.Size = new System.Drawing.Size(35, 35);
            this.counting_point.TabIndex = 40;
            this.counting_point.Text = "CP";
            this.counting_point.UseVisualStyleBackColor = true;
            this.counting_point.Click += new System.EventHandler(this.Counting_point_Click);
            // 
            // add_cabel
            // 
            this.add_cabel.Location = new System.Drawing.Point(340, 380);
            this.add_cabel.Name = "add_cabel";
            this.add_cabel.Size = new System.Drawing.Size(90, 25);
            this.add_cabel.TabIndex = 41;
            this.add_cabel.Text = "DODAJ KABEL";
            this.add_cabel.UseVisualStyleBackColor = true;
            this.add_cabel.Click += new System.EventHandler(this.Add_cabel_Click);
            // 
            // izlaz_svijetlo
            // 
            this.izlaz_svijetlo.AutoSize = true;
            this.izlaz_svijetlo.BackColor = System.Drawing.Color.Red;
            this.izlaz_svijetlo.Location = new System.Drawing.Point(670, 185);
            this.izlaz_svijetlo.Name = "izlaz_svijetlo";
            this.izlaz_svijetlo.Size = new System.Drawing.Size(57, 13);
            this.izlaz_svijetlo.TabIndex = 38;
            this.izlaz_svijetlo.Text = "                l";
            // 
            // circularLabel1
            // 
            this.circularLabel1.AutoSize = true;
            this.circularLabel1.BackColor = System.Drawing.Color.Blue;
            this.circularLabel1.Location = new System.Drawing.Point(668, 185);
            this.circularLabel1.Name = "circularLabel1";
            this.circularLabel1.Size = new System.Drawing.Size(0, 13);
            this.circularLabel1.TabIndex = 37;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Controls.Add(this.add_cabel);
            this.Controls.Add(this.counting_point);
            this.Controls.Add(this.reset_lights);
            this.Controls.Add(this.izlaz_svijetlo);
            this.Controls.Add(this.circularLabel1);
            this.Controls.Add(this.izlaz);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.svijetlo_X1);
            this.Controls.Add(this.svijetlo_X2);
            this.Controls.Add(this.svijetlo_X3);
            this.Controls.Add(this.svijetlo_X4);
            this.Controls.Add(this.svijetlo_X0);
            this.Controls.Add(this.inkrement_nili);
            this.Controls.Add(this.inkrement_ni);
            this.Controls.Add(this.broj_ni_vrata);
            this.Controls.Add(this.broj_nili_vrata);
            this.Controls.Add(this.tekst_br_varijabli);
            this.Controls.Add(this.inkrement);
            this.Controls.Add(this.dekrement);
            this.Controls.Add(this.broj_varijabli);
            this.Controls.Add(this.izbornik);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(700, 450);
            this.Load += new System.EventHandler(this.UserControl1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label broj_varijabli;
        private System.Windows.Forms.Button dekrement;
        private System.Windows.Forms.Button inkrement;
        private System.Windows.Forms.Label tekst_br_varijabli;
        private System.Windows.Forms.Label broj_nili_vrata;
        private System.Windows.Forms.Label broj_ni_vrata;
        private System.Windows.Forms.Button inkrement_ni;
        private System.Windows.Forms.Button inkrement_nili;
        private System.Windows.Forms.Label svijetlo_X0;
        private System.Windows.Forms.Label svijetlo_X4;
        private System.Windows.Forms.Label svijetlo_X3;
        private System.Windows.Forms.Label svijetlo_X2;
        private System.Windows.Forms.Label svijetlo_X1;
        private System.Windows.Forms.Label izbornik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label izlaz;
        private CircularLabel circularLabel1;
        private CircularLabel izlaz_svijetlo;
        private System.Windows.Forms.Button reset_lights;
        private System.Windows.Forms.Button counting_point;
        private System.Windows.Forms.Button add_cabel;
    }
}
