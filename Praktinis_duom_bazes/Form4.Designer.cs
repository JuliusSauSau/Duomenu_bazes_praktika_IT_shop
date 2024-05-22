namespace Praktinis_duom_bazes
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
            groupBox1 = new GroupBox();
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
            darbuotoju_list = new ListBox();
            pareigu_list = new ListBox();
            label1 = new Label();
            label3 = new Label();
            pareigosid_box = new TextBox();
            pareigos_pav_box = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            darb_telnr = new TextBox();
            darb_email = new TextBox();
            darb_pavarde = new TextBox();
            darb_vardas = new TextBox();
            label2 = new Label();
            darb_slap_box = new TextBox();
            label14 = new Label();
            darb_pareiga_box = new TextBox();
            atsijungimas = new Button();
            pareiga_menu_button = new Button();
            worker_menu_button = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
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
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(414, 561);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administratoriaus Informacija";
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
            // darbuotoju_list
            // 
            darbuotoju_list.FormattingEnabled = true;
            darbuotoju_list.ItemHeight = 15;
            darbuotoju_list.Location = new Point(903, 33);
            darbuotoju_list.Name = "darbuotoju_list";
            darbuotoju_list.Size = new Size(418, 199);
            darbuotoju_list.TabIndex = 30;
            darbuotoju_list.SelectedIndexChanged += darbuotoju_list_SelectedIndexChanged;
            // 
            // pareigu_list
            // 
            pareigu_list.FormattingEnabled = true;
            pareigu_list.ItemHeight = 15;
            pareigu_list.Location = new Point(460, 33);
            pareigu_list.Name = "pareigu_list";
            pareigu_list.Size = new Size(362, 199);
            pareigu_list.TabIndex = 31;
            pareigu_list.SelectedIndexChanged += pareigu_list_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(466, 276);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 32;
            label1.Text = "Pareigos ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(493, 241);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 29;
            label3.Text = "Pareiga";
            // 
            // pareigosid_box
            // 
            pareigosid_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareigosid_box.Location = new Point(560, 273);
            pareigosid_box.Name = "pareigosid_box";
            pareigosid_box.ReadOnly = true;
            pareigosid_box.Size = new Size(237, 29);
            pareigosid_box.TabIndex = 31;
            pareigosid_box.TextChanged += pareigosid_box_TextChanged;
            // 
            // pareigos_pav_box
            // 
            pareigos_pav_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareigos_pav_box.Location = new Point(560, 238);
            pareigos_pav_box.Name = "pareigos_pav_box";
            pareigos_pav_box.ReadOnly = true;
            pareigos_pav_box.Size = new Size(237, 29);
            pareigos_pav_box.TabIndex = 30;
            pareigos_pav_box.TextChanged += pareigos_pav_box_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(918, 346);
            label10.Name = "label10";
            label10.Size = new Size(90, 21);
            label10.TabIndex = 36;
            label10.Text = "Telefono nr.";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(935, 311);
            label11.Name = "label11";
            label11.Size = new Size(73, 21);
            label11.TabIndex = 35;
            label11.Text = "El. paštas";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(943, 276);
            label12.Name = "label12";
            label12.Size = new Size(65, 21);
            label12.TabIndex = 34;
            label12.Text = "Pavardė";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(951, 241);
            label13.Name = "label13";
            label13.Size = new Size(57, 21);
            label13.TabIndex = 30;
            label13.Text = "Vardas";
            // 
            // darb_telnr
            // 
            darb_telnr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_telnr.Location = new Point(1014, 343);
            darb_telnr.Name = "darb_telnr";
            darb_telnr.ReadOnly = true;
            darb_telnr.Size = new Size(237, 29);
            darb_telnr.TabIndex = 33;
            darb_telnr.TextChanged += darb_telnr_TextChanged;
            // 
            // darb_email
            // 
            darb_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_email.Location = new Point(1014, 308);
            darb_email.Name = "darb_email";
            darb_email.ReadOnly = true;
            darb_email.Size = new Size(237, 29);
            darb_email.TabIndex = 29;
            darb_email.TextChanged += darb_email_TextChanged;
            // 
            // darb_pavarde
            // 
            darb_pavarde.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_pavarde.Location = new Point(1014, 273);
            darb_pavarde.Name = "darb_pavarde";
            darb_pavarde.ReadOnly = true;
            darb_pavarde.Size = new Size(237, 29);
            darb_pavarde.TabIndex = 32;
            darb_pavarde.TextChanged += darb_pavarde_TextChanged;
            // 
            // darb_vardas
            // 
            darb_vardas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_vardas.Location = new Point(1014, 238);
            darb_vardas.Name = "darb_vardas";
            darb_vardas.ReadOnly = true;
            darb_vardas.Size = new Size(237, 29);
            darb_vardas.TabIndex = 31;
            darb_vardas.TextChanged += darb_vardas_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(919, 381);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 28;
            label2.Text = "Slaptažodis";
            // 
            // darb_slap_box
            // 
            darb_slap_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_slap_box.Location = new Point(1014, 378);
            darb_slap_box.Name = "darb_slap_box";
            darb_slap_box.ReadOnly = true;
            darb_slap_box.Size = new Size(237, 29);
            darb_slap_box.TabIndex = 27;
            darb_slap_box.TextChanged += darb_slap_box_TextChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label14.Location = new Point(947, 416);
            label14.Name = "label14";
            label14.Size = new Size(61, 21);
            label14.TabIndex = 37;
            label14.Text = "Pareiga";
            // 
            // darb_pareiga_box
            // 
            darb_pareiga_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            darb_pareiga_box.Location = new Point(1014, 413);
            darb_pareiga_box.Name = "darb_pareiga_box";
            darb_pareiga_box.ReadOnly = true;
            darb_pareiga_box.Size = new Size(237, 29);
            darb_pareiga_box.TabIndex = 38;
            darb_pareiga_box.TextChanged += darb_pareiga_box_TextChanged;
            // 
            // atsijungimas
            // 
            atsijungimas.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            atsijungimas.Location = new Point(1195, 547);
            atsijungimas.Name = "atsijungimas";
            atsijungimas.Size = new Size(178, 44);
            atsijungimas.TabIndex = 39;
            atsijungimas.Text = "Atsijungti";
            atsijungimas.UseVisualStyleBackColor = true;
            atsijungimas.Click += atsijungimas_Click;
            // 
            // pareiga_menu_button
            // 
            pareiga_menu_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareiga_menu_button.Location = new Point(524, 311);
            pareiga_menu_button.Name = "pareiga_menu_button";
            pareiga_menu_button.Size = new Size(178, 44);
            pareiga_menu_button.TabIndex = 42;
            pareiga_menu_button.Text = "Pareigu Menu";
            pareiga_menu_button.UseVisualStyleBackColor = true;
            pareiga_menu_button.Click += pareiga_menu_button_Click;
            // 
            // worker_menu_button
            // 
            worker_menu_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            worker_menu_button.Location = new Point(1000, 459);
            worker_menu_button.Name = "worker_menu_button";
            worker_menu_button.Size = new Size(178, 44);
            worker_menu_button.TabIndex = 43;
            worker_menu_button.Text = "Darbuotoju Menu";
            worker_menu_button.UseVisualStyleBackColor = true;
            worker_menu_button.Click += worker_menu_button_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 603);
            Controls.Add(worker_menu_button);
            Controls.Add(pareiga_menu_button);
            Controls.Add(atsijungimas);
            Controls.Add(label14);
            Controls.Add(darb_pareiga_box);
            Controls.Add(label2);
            Controls.Add(label10);
            Controls.Add(darb_slap_box);
            Controls.Add(label1);
            Controls.Add(label11);
            Controls.Add(pareigu_list);
            Controls.Add(label12);
            Controls.Add(label3);
            Controls.Add(label13);
            Controls.Add(darbuotoju_list);
            Controls.Add(darb_telnr);
            Controls.Add(pareigosid_box);
            Controls.Add(darb_email);
            Controls.Add(groupBox1);
            Controls.Add(darb_pavarde);
            Controls.Add(pareigos_pav_box);
            Controls.Add(darb_vardas);
            Name = "Form4";
            Text = "Form4";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private TextBox darb_poz_box;
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
        private ListBox darbuotoju_list;
        private ListBox pareigu_list;
        private Label label1;
        private Label label3;
        private TextBox pareigosid_box;
        private TextBox pareigos_pav_box;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox darb_telnr;
        private TextBox darb_email;
        private TextBox darb_pavarde;
        private TextBox darb_vardas;
        private TextBox darb_slap_box;
        private Label label14;
        private TextBox darb_pareiga_box;
        private Button atsijungimas;
        private Button pareiga_menu_button;
        private Button worker_menu_button;
    }
}