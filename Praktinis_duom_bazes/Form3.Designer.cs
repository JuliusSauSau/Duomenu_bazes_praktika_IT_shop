namespace Praktinis_duom_bazes
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            job_position_box = new TextBox();
            label2 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            slaptazodis_box = new TextBox();
            telefononr_box = new TextBox();
            email_box = new TextBox();
            pavarde_box = new TextBox();
            vardas_box = new TextBox();
            produkto_list = new ListBox();
            groupBox2 = new GroupBox();
            vardas_pavarde_pasirinkimas_box = new ComboBox();
            cacel_uzsakyma_button = new Button();
            save_uzsakyma_button = new Button();
            kiekis_box = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label3 = new Label();
            atsijungimas = new Button();
            label12 = new Label();
            produkto_pavadinimas_box = new TextBox();
            label13 = new Label();
            produkto_kaina_box = new TextBox();
            label14 = new Label();
            produkto_kiekis_box = new TextBox();
            selected_prod_box = new ComboBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(524, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 37);
            label1.TabIndex = 0;
            label1.Text = "Darbuotojo informacija";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(job_position_box);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(slaptazodis_box);
            groupBox1.Controls.Add(telefononr_box);
            groupBox1.Controls.Add(email_box);
            groupBox1.Controls.Add(pavarde_box);
            groupBox1.Controls.Add(vardas_box);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(457, 561);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Darbuotojo Informacija";
            // 
            // job_position_box
            // 
            job_position_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            job_position_box.Location = new Point(119, 236);
            job_position_box.Name = "job_position_box";
            job_position_box.ReadOnly = true;
            job_position_box.Size = new Size(237, 29);
            job_position_box.TabIndex = 29;
            job_position_box.TextChanged += job_position_box_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 239);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 28;
            label2.Text = "Darbo pozicija";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(24, 204);
            label9.Name = "label9";
            label9.Size = new Size(89, 21);
            label9.TabIndex = 26;
            label9.Text = "Slaptažodis";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(23, 169);
            label8.Name = "label8";
            label8.Size = new Size(90, 21);
            label8.TabIndex = 25;
            label8.Text = "Telefono nr.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(40, 134);
            label6.Name = "label6";
            label6.Size = new Size(73, 21);
            label6.TabIndex = 23;
            label6.Text = "El. paštas";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(48, 99);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 22;
            label5.Text = "Pavardė";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(56, 64);
            label4.Name = "label4";
            label4.Size = new Size(57, 21);
            label4.TabIndex = 16;
            label4.Text = "Vardas";
            // 
            // slaptazodis_box
            // 
            slaptazodis_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slaptazodis_box.Location = new Point(119, 201);
            slaptazodis_box.Name = "slaptazodis_box";
            slaptazodis_box.ReadOnly = true;
            slaptazodis_box.Size = new Size(237, 29);
            slaptazodis_box.TabIndex = 21;
            slaptazodis_box.TextChanged += slaptazodis_box_TextChanged;
            // 
            // telefononr_box
            // 
            telefononr_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            telefononr_box.Location = new Point(119, 166);
            telefononr_box.Name = "telefononr_box";
            telefononr_box.ReadOnly = true;
            telefononr_box.Size = new Size(237, 29);
            telefononr_box.TabIndex = 20;
            telefononr_box.TextChanged += telefononr_box_TextChanged;
            // 
            // email_box
            // 
            email_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            email_box.Location = new Point(119, 131);
            email_box.Name = "email_box";
            email_box.ReadOnly = true;
            email_box.Size = new Size(237, 29);
            email_box.TabIndex = 15;
            email_box.TextChanged += email_box_TextChanged;
            // 
            // pavarde_box
            // 
            pavarde_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pavarde_box.Location = new Point(119, 96);
            pavarde_box.Name = "pavarde_box";
            pavarde_box.ReadOnly = true;
            pavarde_box.Size = new Size(237, 29);
            pavarde_box.TabIndex = 18;
            pavarde_box.TextChanged += pavarde_box_TextChanged;
            // 
            // vardas_box
            // 
            vardas_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vardas_box.Location = new Point(119, 61);
            vardas_box.Name = "vardas_box";
            vardas_box.ReadOnly = true;
            vardas_box.Size = new Size(237, 29);
            vardas_box.TabIndex = 17;
            vardas_box.TextChanged += vardas_box_TextChanged;
            // 
            // produkto_list
            // 
            produkto_list.FormattingEnabled = true;
            produkto_list.ItemHeight = 15;
            produkto_list.Location = new Point(500, 61);
            produkto_list.Name = "produkto_list";
            produkto_list.Size = new Size(848, 139);
            produkto_list.TabIndex = 29;
            produkto_list.SelectedIndexChanged += produkto_list_SelectedIndexChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(selected_prod_box);
            groupBox2.Controls.Add(vardas_pavarde_pasirinkimas_box);
            groupBox2.Controls.Add(cacel_uzsakyma_button);
            groupBox2.Controls.Add(save_uzsakyma_button);
            groupBox2.Controls.Add(kiekis_box);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(494, 299);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(861, 234);
            groupBox2.TabIndex = 30;
            groupBox2.TabStop = false;
            groupBox2.Text = "Naujas užsakymas";
            // 
            // vardas_pavarde_pasirinkimas_box
            // 
            vardas_pavarde_pasirinkimas_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            vardas_pavarde_pasirinkimas_box.FormattingEnabled = true;
            vardas_pavarde_pasirinkimas_box.Location = new Point(142, 48);
            vardas_pavarde_pasirinkimas_box.Name = "vardas_pavarde_pasirinkimas_box";
            vardas_pavarde_pasirinkimas_box.Size = new Size(237, 29);
            vardas_pavarde_pasirinkimas_box.TabIndex = 35;
            vardas_pavarde_pasirinkimas_box.SelectedIndexChanged += vardas_pavarde_pasirinkimas_box_SelectedIndexChanged;
            // 
            // cacel_uzsakyma_button
            // 
            cacel_uzsakyma_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cacel_uzsakyma_button.Location = new Point(676, 34);
            cacel_uzsakyma_button.Name = "cacel_uzsakyma_button";
            cacel_uzsakyma_button.Size = new Size(178, 44);
            cacel_uzsakyma_button.TabIndex = 34;
            cacel_uzsakyma_button.Text = "Atšaukti";
            cacel_uzsakyma_button.UseVisualStyleBackColor = true;
            cacel_uzsakyma_button.Click += cacel_uzsakyma_button_Click;
            // 
            // save_uzsakyma_button
            // 
            save_uzsakyma_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            save_uzsakyma_button.Location = new Point(431, 33);
            save_uzsakyma_button.Name = "save_uzsakyma_button";
            save_uzsakyma_button.Size = new Size(178, 44);
            save_uzsakyma_button.TabIndex = 31;
            save_uzsakyma_button.Text = "Užsakyti";
            save_uzsakyma_button.UseVisualStyleBackColor = true;
            save_uzsakyma_button.Click += save_uzsakyma_button_Click;
            // 
            // kiekis_box
            // 
            kiekis_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            kiekis_box.Location = new Point(142, 118);
            kiekis_box.Name = "kiekis_box";
            kiekis_box.Size = new Size(237, 29);
            kiekis_box.TabIndex = 33;
            kiekis_box.TextChanged += keikis_box_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(86, 121);
            label11.Name = "label11";
            label11.Size = new Size(50, 21);
            label11.TabIndex = 32;
            label11.Text = "Kiekis";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(56, 86);
            label10.Name = "label10";
            label10.Size = new Size(80, 21);
            label10.TabIndex = 30;
            label10.Text = "Produktas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 51);
            label3.Name = "label3";
            label3.Size = new Size(116, 21);
            label3.TabIndex = 17;
            label3.Text = "Vardas Pavardė";
            // 
            // atsijungimas
            // 
            atsijungimas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atsijungimas.Location = new Point(1195, 547);
            atsijungimas.Name = "atsijungimas";
            atsijungimas.Size = new Size(178, 44);
            atsijungimas.TabIndex = 3;
            atsijungimas.Text = "Atsijungti";
            atsijungimas.UseVisualStyleBackColor = true;
            atsijungimas.Click += atsijungimas_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(500, 214);
            label12.Name = "label12";
            label12.Size = new Size(97, 21);
            label12.TabIndex = 30;
            label12.Text = "Pavadinimas";
            // 
            // produkto_pavadinimas_box
            // 
            produkto_pavadinimas_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produkto_pavadinimas_box.Location = new Point(603, 211);
            produkto_pavadinimas_box.Name = "produkto_pavadinimas_box";
            produkto_pavadinimas_box.ReadOnly = true;
            produkto_pavadinimas_box.Size = new Size(237, 29);
            produkto_pavadinimas_box.TabIndex = 31;
            produkto_pavadinimas_box.TextChanged += produkto_pavadinimas_box_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(871, 214);
            label13.Name = "label13";
            label13.Size = new Size(48, 21);
            label13.TabIndex = 32;
            label13.Text = "Kaina";
            // 
            // produkto_kaina_box
            // 
            produkto_kaina_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produkto_kaina_box.Location = new Point(925, 211);
            produkto_kaina_box.Name = "produkto_kaina_box";
            produkto_kaina_box.ReadOnly = true;
            produkto_kaina_box.Size = new Size(237, 29);
            produkto_kaina_box.TabIndex = 33;
            produkto_kaina_box.TextChanged += produkto_kaina_box_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(549, 264);
            label14.Name = "label14";
            label14.Size = new Size(50, 21);
            label14.TabIndex = 34;
            label14.Text = "Kiekis";
            // 
            // produkto_kiekis_box
            // 
            produkto_kiekis_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            produkto_kiekis_box.Location = new Point(603, 261);
            produkto_kiekis_box.Name = "produkto_kiekis_box";
            produkto_kiekis_box.ReadOnly = true;
            produkto_kiekis_box.Size = new Size(237, 29);
            produkto_kiekis_box.TabIndex = 35;
            produkto_kiekis_box.TextChanged += produkto_kiekis_box_TextChanged;
            // 
            // selected_prod_box
            // 
            selected_prod_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            selected_prod_box.FormattingEnabled = true;
            selected_prod_box.Location = new Point(142, 83);
            selected_prod_box.Name = "selected_prod_box";
            selected_prod_box.Size = new Size(237, 29);
            selected_prod_box.TabIndex = 36;
            selected_prod_box.SelectedIndexChanged += selected_prod_box_SelectedIndexChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 603);
            Controls.Add(label14);
            Controls.Add(produkto_kiekis_box);
            Controls.Add(label13);
            Controls.Add(produkto_kaina_box);
            Controls.Add(label12);
            Controls.Add(atsijungimas);
            Controls.Add(produkto_pavadinimas_box);
            Controls.Add(groupBox2);
            Controls.Add(produkto_list);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox slaptazodis_box;
        private TextBox telefononr_box;
        private TextBox email_box;
        private TextBox pavarde_box;
        private TextBox vardas_box;
        private Label label2;
        private ListBox produkto_list;
        private GroupBox groupBox2;
        private Button atsijungimas;
        private Label label3;
        private TextBox kiekis_box;
        private Label label11;
        private Label label10;
        private Button cacel_uzsakyma_button;
        private Button save_uzsakyma_button;
        private TextBox job_position_box;
        private Label label12;
        private TextBox produkto_pavadinimas_box;
        private Label label13;
        private TextBox produkto_kaina_box;
        private Label label14;
        private TextBox produkto_kiekis_box;
        private ComboBox vardas_pavarde_pasirinkimas_box;
        private ComboBox selected_prod_box;
    }
}