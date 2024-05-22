namespace Praktinis_duom_bazes
{
    partial class Form5
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
            groupBox3 = new GroupBox();
            new_pareiga_botton = new Button();
            label6 = new Label();
            new_pareigos_pav_box = new TextBox();
            pareigos_pav_box = new TextBox();
            pareigosid_box = new TextBox();
            label3 = new Label();
            pareigu_list = new ListBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            delete_pareiga_box = new Button();
            Get_back_button = new Button();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(new_pareiga_botton);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(new_pareigos_pav_box);
            groupBox3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(523, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(476, 182);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Nauja Pareiga";
            // 
            // new_pareiga_botton
            // 
            new_pareiga_botton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_pareiga_botton.Location = new Point(125, 109);
            new_pareiga_botton.Name = "new_pareiga_botton";
            new_pareiga_botton.Size = new Size(178, 44);
            new_pareiga_botton.TabIndex = 41;
            new_pareiga_botton.Text = "Ivesti Pareiga";
            new_pareiga_botton.UseVisualStyleBackColor = true;
            new_pareiga_botton.Click += new_pareiga_botton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(80, 64);
            label6.Name = "label6";
            label6.Size = new Size(61, 21);
            label6.TabIndex = 33;
            label6.Text = "Pareiga";
            // 
            // new_pareigos_pav_box
            // 
            new_pareigos_pav_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            new_pareigos_pav_box.Location = new Point(147, 61);
            new_pareigos_pav_box.Name = "new_pareigos_pav_box";
            new_pareigos_pav_box.Size = new Size(237, 29);
            new_pareigos_pav_box.TabIndex = 34;
            new_pareigos_pav_box.TextChanged += new_pareigos_pav_box_TextChanged;
            // 
            // pareigos_pav_box
            // 
            pareigos_pav_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareigos_pav_box.Location = new Point(149, 250);
            pareigos_pav_box.Name = "pareigos_pav_box";
            pareigos_pav_box.ReadOnly = true;
            pareigos_pav_box.Size = new Size(237, 29);
            pareigos_pav_box.TabIndex = 34;
            pareigos_pav_box.TextChanged += pareigos_pav_box_TextChanged;
            // 
            // pareigosid_box
            // 
            pareigosid_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareigosid_box.Location = new Point(149, 285);
            pareigosid_box.Name = "pareigosid_box";
            pareigosid_box.ReadOnly = true;
            pareigosid_box.Size = new Size(237, 29);
            pareigosid_box.TabIndex = 36;
            pareigosid_box.TextChanged += pareigosid_box_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(82, 253);
            label3.Name = "label3";
            label3.Size = new Size(61, 21);
            label3.TabIndex = 33;
            label3.Text = "Pareiga";
            // 
            // pareigu_list
            // 
            pareigu_list.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pareigu_list.FormattingEnabled = true;
            pareigu_list.ItemHeight = 15;
            pareigu_list.Location = new Point(49, 45);
            pareigu_list.Name = "pareigu_list";
            pareigu_list.Size = new Size(362, 199);
            pareigu_list.TabIndex = 35;
            pareigu_list.SelectedIndexChanged += pareigu_list_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(55, 288);
            label1.Name = "label1";
            label1.Size = new Size(88, 21);
            label1.TabIndex = 37;
            label1.Text = "Pareigos ID";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(delete_pareiga_box);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(pareigu_list);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(pareigosid_box);
            groupBox1.Controls.Add(pareigos_pav_box);
            groupBox1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 428);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Egzistuojanti Pareiga";
            // 
            // delete_pareiga_box
            // 
            delete_pareiga_box.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            delete_pareiga_box.Location = new Point(113, 328);
            delete_pareiga_box.Name = "delete_pareiga_box";
            delete_pareiga_box.Size = new Size(178, 44);
            delete_pareiga_box.TabIndex = 41;
            delete_pareiga_box.Text = "Pasalinti Pareiga";
            delete_pareiga_box.UseVisualStyleBackColor = true;
            delete_pareiga_box.Click += delete_pareiga_box_Click;
            // 
            // Get_back_button
            // 
            Get_back_button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Get_back_button.Location = new Point(903, 401);
            Get_back_button.Name = "Get_back_button";
            Get_back_button.Size = new Size(178, 44);
            Get_back_button.TabIndex = 40;
            Get_back_button.Text = "Gryzti";
            Get_back_button.UseVisualStyleBackColor = true;
            Get_back_button.Click += Get_back_button_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1093, 457);
            Controls.Add(Get_back_button);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Name = "Form5";
            Text = "Form5";
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox3;
        private Label label6;
        private TextBox new_pareigos_pav_box;
        private TextBox pareigos_pav_box;
        private TextBox pareigosid_box;
        private Label label3;
        private ListBox pareigu_list;
        private Label label1;
        private GroupBox groupBox1;
        private Button delete_pareiga_box;
        private Button Get_back_button;
        private Button new_pareiga_botton;
    }
}