namespace Praktinis_duom_bazes
{
    partial class Form6
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
            groupBox1 = new GroupBox();
            Pasalinti_darb_button = new Button();
            save_darb_changes_button = new Button();
            darbuotoju_list = new ListBox();
            darb_job_position_box = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            darb_slaptazodis_box = new TextBox();
            darb_telefononr_box = new TextBox();
            darb_email_box = new TextBox();
            darb_pavarde_box = new TextBox();
            darb_vardas_box = new TextBox();
            groupBox2 = new GroupBox();
            new_darb_pozicija_combo_box = new ComboBox();
            new_darb_button = new Button();
            label1 = new Label();
            label3 = new Label();
            label7 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            new_darb_slap_box = new TextBox();
            new_darb_telnr_box = new TextBox();
            new_darb_email_box = new TextBox();
            new_darb_pavarde_box = new TextBox();
            new_darb_vardas_box = new TextBox();
            Get_back_button = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Pasalinti_darb_button);
            groupBox1.Controls.Add(save_darb_changes_button);
            groupBox1.Controls.Add(darbuotoju_list);
            groupBox1.Controls.Add(darb_job_position_box);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(darb_slaptazodis_box);
            groupBox1.Controls.Add(darb_telefononr_box);
            groupBox1.Controls.Add(darb_email_box);
            groupBox1.Controls.Add(darb_pavarde_box);
            groupBox1.Controls.Add(darb_vardas_box);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Darbuotoju Informacija";
            // 
            // Pasalinti_darb_button
            // 
            Pasalinti_darb_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Pasalinti_darb_button.Location = new Point(99, 493);
            Pasalinti_darb_button.Name = "Pasalinti_darb_button";
            Pasalinti_darb_button.Size = new Size(178, 44);
            Pasalinti_darb_button.TabIndex = 43;
            Pasalinti_darb_button.Text = "Pasalinti Darbuotoja";
            Pasalinti_darb_button.UseVisualStyleBackColor = true;
            Pasalinti_darb_button.Click += Pasalinti_darb_button_Click;
            // 
            // save_darb_changes_button
            // 
            save_darb_changes_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_darb_changes_button.Location = new Point(99, 443);
            save_darb_changes_button.Name = "save_darb_changes_button";
            save_darb_changes_button.Size = new Size(178, 44);
            save_darb_changes_button.TabIndex = 42;
            save_darb_changes_button.Text = "Issaugoti Pakeitimus";
            save_darb_changes_button.UseVisualStyleBackColor = true;
            save_darb_changes_button.Click += save_darb_changes_button_Click;
            // 
            // darbuotoju_list
            // 
            darbuotoju_list.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darbuotoju_list.FormattingEnabled = true;
            darbuotoju_list.ItemHeight = 15;
            darbuotoju_list.Location = new Point(20, 34);
            darbuotoju_list.Name = "darbuotoju_list";
            darbuotoju_list.Size = new Size(418, 184);
            darbuotoju_list.TabIndex = 31;
            darbuotoju_list.SelectedIndexChanged += darbuotoju_list_SelectedIndexChanged;
            // 
            // darb_job_position_box
            // 
            darb_job_position_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_job_position_box.Location = new Point(136, 399);
            darb_job_position_box.Name = "darb_job_position_box";
            darb_job_position_box.ReadOnly = true;
            darb_job_position_box.Size = new Size(237, 29);
            darb_job_position_box.TabIndex = 29;
            darb_job_position_box.TextChanged += darb_job_position_box_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 402);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 28;
            label2.Text = "Darbo pozicija";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(41, 367);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 26;
            label9.Text = "Slaptažodis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(40, 332);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 25;
            label8.Text = "Telefono nr.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(57, 297);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 23;
            label6.Text = "El. paštas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(65, 262);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 22;
            label5.Text = "Pavardė";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 227);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 16;
            label4.Text = "Vardas";
            // 
            // darb_slaptazodis_box
            // 
            darb_slaptazodis_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_slaptazodis_box.Location = new Point(136, 364);
            darb_slaptazodis_box.Name = "darb_slaptazodis_box";
            darb_slaptazodis_box.ReadOnly = true;
            darb_slaptazodis_box.Size = new Size(237, 29);
            darb_slaptazodis_box.TabIndex = 21;
            darb_slaptazodis_box.TextChanged += darb_slaptazodis_box_TextChanged;
            // 
            // darb_telefononr_box
            // 
            darb_telefononr_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_telefononr_box.Location = new Point(136, 329);
            darb_telefononr_box.Name = "darb_telefononr_box";
            darb_telefononr_box.ReadOnly = true;
            darb_telefononr_box.Size = new Size(237, 29);
            darb_telefononr_box.TabIndex = 20;
            darb_telefononr_box.TextChanged += darb_telefononr_box_TextChanged;
            // 
            // darb_email_box
            // 
            darb_email_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_email_box.Location = new Point(136, 294);
            darb_email_box.Name = "darb_email_box";
            darb_email_box.ReadOnly = true;
            darb_email_box.Size = new Size(237, 29);
            darb_email_box.TabIndex = 15;
            darb_email_box.TextChanged += darb_email_box_TextChanged;
            // 
            // darb_pavarde_box
            // 
            darb_pavarde_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_pavarde_box.Location = new Point(136, 259);
            darb_pavarde_box.Name = "darb_pavarde_box";
            darb_pavarde_box.ReadOnly = true;
            darb_pavarde_box.Size = new Size(237, 29);
            darb_pavarde_box.TabIndex = 18;
            darb_pavarde_box.TextChanged += darb_pavarde_box_TextChanged;
            // 
            // darb_vardas_box
            // 
            darb_vardas_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_vardas_box.Location = new Point(136, 224);
            darb_vardas_box.Name = "darb_vardas_box";
            darb_vardas_box.ReadOnly = true;
            darb_vardas_box.Size = new Size(237, 29);
            darb_vardas_box.TabIndex = 17;
            darb_vardas_box.TextChanged += darb_vardas_box_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(new_darb_pozicija_combo_box);
            groupBox2.Controls.Add(new_darb_button);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(new_darb_slap_box);
            groupBox2.Controls.Add(new_darb_telnr_box);
            groupBox2.Controls.Add(new_darb_email_box);
            groupBox2.Controls.Add(new_darb_pavarde_box);
            groupBox2.Controls.Add(new_darb_vardas_box);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(512, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(457, 320);
            groupBox2.TabIndex = 44;
            groupBox2.TabStop = false;
            groupBox2.Text = "Darbuotoju Informacija";
            // 
            // new_darb_pozicija_combo_box
            // 
            new_darb_pozicija_combo_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_pozicija_combo_box.FormattingEnabled = true;
            new_darb_pozicija_combo_box.Location = new Point(149, 213);
            new_darb_pozicija_combo_box.Name = "new_darb_pozicija_combo_box";
            new_darb_pozicija_combo_box.Size = new Size(237, 29);
            new_darb_pozicija_combo_box.TabIndex = 43;
            new_darb_pozicija_combo_box.SelectedIndexChanged += new_darb_pozicija_combo_box_SelectedIndexChanged;
            // 
            // new_darb_button
            // 
            new_darb_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_button.Location = new Point(114, 259);
            new_darb_button.Name = "new_darb_button";
            new_darb_button.Size = new Size(178, 44);
            new_darb_button.TabIndex = 42;
            new_darb_button.Text = "Prideti Darbuotoja";
            new_darb_button.UseVisualStyleBackColor = true;
            new_darb_button.Click += new_darb_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(36, 216);
            label1.Name = "label1";
            label1.Size = new Size(109, 21);
            label1.TabIndex = 28;
            label1.Text = "Darbo pozicija";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 181);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 26;
            label3.Text = "Slaptažodis";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(53, 146);
            label7.Name = "label7";
            label7.Size = new Size(90, 21);
            label7.TabIndex = 25;
            label7.Text = "Telefono nr.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(70, 111);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 23;
            label10.Text = "El. paštas";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(78, 76);
            label11.Name = "label11";
            label11.Size = new Size(65, 21);
            label11.TabIndex = 22;
            label11.Text = "Pavardė";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(86, 41);
            label12.Name = "label12";
            label12.Size = new Size(57, 21);
            label12.TabIndex = 16;
            label12.Text = "Vardas";
            // 
            // new_darb_slap_box
            // 
            new_darb_slap_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_slap_box.Location = new Point(149, 178);
            new_darb_slap_box.Name = "new_darb_slap_box";
            new_darb_slap_box.ReadOnly = true;
            new_darb_slap_box.Size = new Size(237, 29);
            new_darb_slap_box.TabIndex = 21;
            new_darb_slap_box.TextChanged += new_darb_slap_box_TextChanged;
            // 
            // new_darb_telnr_box
            // 
            new_darb_telnr_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_telnr_box.Location = new Point(149, 143);
            new_darb_telnr_box.Name = "new_darb_telnr_box";
            new_darb_telnr_box.ReadOnly = true;
            new_darb_telnr_box.Size = new Size(237, 29);
            new_darb_telnr_box.TabIndex = 20;
            new_darb_telnr_box.TextChanged += new_darb_telnr_box_TextChanged;
            // 
            // new_darb_email_box
            // 
            new_darb_email_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_email_box.Location = new Point(149, 108);
            new_darb_email_box.Name = "new_darb_email_box";
            new_darb_email_box.ReadOnly = true;
            new_darb_email_box.Size = new Size(237, 29);
            new_darb_email_box.TabIndex = 15;
            new_darb_email_box.TextChanged += new_darb_email_box_TextChanged;
            // 
            // new_darb_pavarde_box
            // 
            new_darb_pavarde_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_pavarde_box.Location = new Point(149, 73);
            new_darb_pavarde_box.Name = "new_darb_pavarde_box";
            new_darb_pavarde_box.ReadOnly = true;
            new_darb_pavarde_box.Size = new Size(237, 29);
            new_darb_pavarde_box.TabIndex = 18;
            new_darb_pavarde_box.TextChanged += new_darb_pavarde_box_TextChanged;
            // 
            // new_darb_vardas_box
            // 
            new_darb_vardas_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_darb_vardas_box.Location = new Point(149, 38);
            new_darb_vardas_box.Name = "new_darb_vardas_box";
            new_darb_vardas_box.ReadOnly = true;
            new_darb_vardas_box.Size = new Size(237, 29);
            new_darb_vardas_box.TabIndex = 17;
            new_darb_vardas_box.TextChanged += new_darb_vardas_box_TextChanged;
            // 
            // Get_back_button
            // 
            Get_back_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Get_back_button.Location = new Point(793, 538);
            Get_back_button.Name = "Get_back_button";
            Get_back_button.Size = new Size(178, 44);
            Get_back_button.TabIndex = 45;
            Get_back_button.Text = "Gryzti";
            Get_back_button.UseVisualStyleBackColor = true;
            Get_back_button.Click += Get_back_button_Click;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 594);
            Controls.Add(Get_back_button);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form6";
            Text = "Form6";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox darb_job_position_box;
        private Label label2;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox darb_slaptazodis_box;
        private TextBox darb_telefononr_box;
        private TextBox darb_email_box;
        private TextBox darb_pavarde_box;
        private TextBox darb_vardas_box;
        private ListBox darbuotoju_list;
        private Button save_darb_changes_button;
        private Button Pasalinti_darb_button;
        private GroupBox groupBox2;
        private ComboBox new_darb_pozicija_combo_box;
        private Button new_darb_button;
        private Label label1;
        private Label label3;
        private Label label7;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox new_darb_slap_box;
        private TextBox new_darb_telnr_box;
        private TextBox new_darb_email_box;
        private TextBox new_darb_pavarde_box;
        private TextBox new_darb_vardas_box;
        private Button Get_back_button;
    }
}