namespace Praktinis_duom_bazes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Prisijungti_button = new Button();
            Pri_slap = new TextBox();
            Pri_ema = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            Reg_slap = new TextBox();
            Reg_telnr = new TextBox();
            Reg_adr = new TextBox();
            Reg_ema = new TextBox();
            Reg_pav = new TextBox();
            Reg_var = new TextBox();
            Registruotis_button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Prisijungti_button);
            groupBox1.Controls.Add(Pri_slap);
            groupBox1.Controls.Add(Pri_ema);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(36, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(633, 471);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Prisijungimas";
            // 
            // Prisijungti_button
            // 
            Prisijungti_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Prisijungti_button.Location = new Point(142, 148);
            Prisijungti_button.Name = "Prisijungti_button";
            Prisijungti_button.Size = new Size(190, 35);
            Prisijungti_button.TabIndex = 4;
            Prisijungti_button.Text = "Prisijungti";
            Prisijungti_button.UseVisualStyleBackColor = true;
            Prisijungti_button.Click += Prisijungti_button_Click;
            // 
            // Pri_slap
            // 
            Pri_slap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pri_slap.Location = new Point(187, 105);
            Pri_slap.Name = "Pri_slap";
            Pri_slap.Size = new Size(237, 29);
            Pri_slap.TabIndex = 3;
            Pri_slap.TextChanged += Pri_slap_TextChanged;
            // 
            // Pri_ema
            // 
            Pri_ema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pri_ema.Location = new Point(187, 70);
            Pri_ema.Name = "Pri_ema";
            Pri_ema.Size = new Size(237, 29);
            Pri_ema.TabIndex = 2;
            Pri_ema.TextChanged += Pri_ema_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(92, 108);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 1;
            label3.Text = "Slaptažodis";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 73);
            label2.Name = "label2";
            label2.Size = new Size(69, 21);
            label2.TabIndex = 0;
            label2.Text = "El.paštas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(590, 21);
            label1.Name = "label1";
            label1.Size = new Size(180, 37);
            label1.TabIndex = 1;
            label1.Text = "IT Parduotuvė";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(Reg_slap);
            groupBox2.Controls.Add(Reg_telnr);
            groupBox2.Controls.Add(Reg_adr);
            groupBox2.Controls.Add(Reg_ema);
            groupBox2.Controls.Add(Reg_pav);
            groupBox2.Controls.Add(Reg_var);
            groupBox2.Controls.Add(Registruotis_button);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(730, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(633, 471);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Registracija";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(156, 248);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 14;
            label9.Text = "Slaptažodis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(155, 213);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 13;
            label8.Text = "Telefono nr.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(180, 178);
            label7.Name = "label7";
            label7.Size = new Size(65, 21);
            label7.TabIndex = 12;
            label7.Text = "Adresas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(172, 143);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 11;
            label6.Text = "El. paštas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(180, 108);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 10;
            label5.Text = "Pavardė";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(188, 73);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 5;
            label4.Text = "Vardas";
            // 
            // Reg_slap
            // 
            Reg_slap.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_slap.Location = new Point(251, 245);
            Reg_slap.Name = "Reg_slap";
            Reg_slap.Size = new Size(237, 29);
            Reg_slap.TabIndex = 9;
            Reg_slap.TextChanged += Reg_slap_TextChanged;
            // 
            // Reg_telnr
            // 
            Reg_telnr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_telnr.Location = new Point(251, 210);
            Reg_telnr.Name = "Reg_telnr";
            Reg_telnr.Size = new Size(237, 29);
            Reg_telnr.TabIndex = 8;
            Reg_telnr.TextChanged += Reg_telnr_TextChanged;
            // 
            // Reg_adr
            // 
            Reg_adr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_adr.Location = new Point(251, 175);
            Reg_adr.Name = "Reg_adr";
            Reg_adr.Size = new Size(237, 29);
            Reg_adr.TabIndex = 7;
            Reg_adr.TextChanged += Reg_adr_TextChanged;
            // 
            // Reg_ema
            // 
            Reg_ema.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_ema.Location = new Point(251, 140);
            Reg_ema.Name = "Reg_ema";
            Reg_ema.Size = new Size(237, 29);
            Reg_ema.TabIndex = 2;
            Reg_ema.TextChanged += Reg_ema_TextChanged;
            // 
            // Reg_pav
            // 
            Reg_pav.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_pav.Location = new Point(251, 105);
            Reg_pav.Name = "Reg_pav";
            Reg_pav.Size = new Size(237, 29);
            Reg_pav.TabIndex = 6;
            Reg_pav.TextChanged += Reg_pav_TextChanged;
            // 
            // Reg_var
            // 
            Reg_var.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Reg_var.Location = new Point(251, 70);
            Reg_var.Name = "Reg_var";
            Reg_var.Size = new Size(237, 29);
            Reg_var.TabIndex = 5;
            Reg_var.TextChanged += Reg_var_TextChanged;
            // 
            // Registruotis_button
            // 
            Registruotis_button.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Registruotis_button.Location = new Point(197, 292);
            Registruotis_button.Name = "Registruotis_button";
            Registruotis_button.Size = new Size(190, 35);
            Registruotis_button.TabIndex = 5;
            Registruotis_button.Text = "Registruotis";
            Registruotis_button.UseVisualStyleBackColor = true;
            Registruotis_button.Click += Registruotis_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 603);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox Pri_ema;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Button Prisijungti_button;
        private TextBox Pri_slap;
        private TextBox Reg_ema;
        private TextBox Reg_pav;
        private TextBox Reg_var;
        private Button Registruotis_button;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox Reg_slap;
        private TextBox Reg_telnr;
        private TextBox Reg_adr;
    }
}
