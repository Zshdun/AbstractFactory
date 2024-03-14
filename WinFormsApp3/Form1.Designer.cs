namespace WinFormsApp3
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
            CheckStats = new Button();
            CRR = new Button();
            CBR = new Button();
            RedRobotType = new ComboBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            Battle = new Button();
            BlueRobotType = new ComboBox();
            comboBox4 = new ComboBox();
            comboBox5 = new ComboBox();
            comboBox6 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // CheckStats
            // 
            CheckStats.Location = new Point(316, 337);
            CheckStats.Name = "CheckStats";
            CheckStats.Size = new Size(105, 23);
            CheckStats.TabIndex = 0;
            CheckStats.Text = "Check Stats";
            CheckStats.UseVisualStyleBackColor = true;
            CheckStats.Click += CheckStats_Click;
            // 
            // CRR
            // 
            CRR.Location = new Point(114, 287);
            CRR.Name = "CRR";
            CRR.Size = new Size(121, 47);
            CRR.TabIndex = 1;
            CRR.Text = "Create Red Robot";
            CRR.UseVisualStyleBackColor = true;
            CRR.Click += CRR_click;
            // 
            // CBR
            // 
            CBR.Location = new Point(510, 287);
            CBR.Name = "CBR";
            CBR.Size = new Size(121, 47);
            CBR.TabIndex = 2;
            CBR.Text = "Create Blue Robot";
            CBR.UseVisualStyleBackColor = true;
            CBR.Click += CBR_click;
            // 
            // RedRobotType
            // 
            RedRobotType.FormattingEnabled = true;
            RedRobotType.Items.AddRange(new object[] { "Jakobs", "Maliwan", "Torgue", "Custom" });
            RedRobotType.Location = new Point(160, 65);
            RedRobotType.Name = "RedRobotType";
            RedRobotType.Size = new Size(121, 23);
            RedRobotType.TabIndex = 3;
            RedRobotType.SelectedValueChanged += RedRobotModel_SelectedValueChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "JakobsTurret", "MaliwanLaser", "TorgueRPG" });
            comboBox1.Location = new Point(160, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "JakobsArmor", "MaliwanArmor", "TorgueArmor" });
            comboBox2.Location = new Point(160, 191);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Visible = false;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "JakobsLegs", "MaliwanLegs", "TorgueLegs" });
            comboBox3.Location = new Point(160, 229);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(121, 23);
            comboBox3.TabIndex = 6;
            comboBox3.Visible = false;
            // 
            // Battle
            // 
            Battle.Location = new Point(332, 383);
            Battle.Name = "Battle";
            Battle.Size = new Size(75, 23);
            Battle.TabIndex = 7;
            Battle.Text = "Battle!";
            Battle.UseVisualStyleBackColor = true;
            Battle.Click += Battle_Click;
            // 
            // BlueRobotType
            // 
            BlueRobotType.FormattingEnabled = true;
            BlueRobotType.Items.AddRange(new object[] { "Jakobs", "Maliwan", "Torgue", "Custom" });
            BlueRobotType.Location = new Point(538, 70);
            BlueRobotType.Name = "BlueRobotType";
            BlueRobotType.Size = new Size(121, 23);
            BlueRobotType.TabIndex = 8;
            BlueRobotType.SelectedValueChanged += BlueRobotType_SelectedValueChanged;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "JakobsLegs", "MaliwanLegs", "TorgueLegs" });
            comboBox4.Location = new Point(539, 224);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(121, 23);
            comboBox4.TabIndex = 11;
            comboBox4.Visible = false;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "JakobsArmor", "MaliwanArmor", "TorgueArmor" });
            comboBox5.Location = new Point(539, 186);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(121, 23);
            comboBox5.TabIndex = 10;
            comboBox5.Visible = false;
            // 
            // comboBox6
            // 
            comboBox6.FormattingEnabled = true;
            comboBox6.Items.AddRange(new object[] { "JakobsTurret", "MaliwanLaser", "TorgueRPG" });
            comboBox6.Location = new Point(539, 144);
            comboBox6.Name = "comboBox6";
            comboBox6.Size = new Size(121, 23);
            comboBox6.TabIndex = 9;
            comboBox6.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(117, 9);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 12;
            label1.Text = "RED ROBOT";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(114, 73);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 13;
            label2.Text = "Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(510, 9);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 14;
            label3.Text = "BLUE ROBOT";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(92, 152);
            label5.Name = "label5";
            label5.Size = new Size(52, 15);
            label5.TabIndex = 16;
            label5.Text = "Weapon";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(103, 191);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 17;
            label6.Text = "Armor";
            label6.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(109, 229);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 18;
            label7.Text = "Legs";
            label7.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(484, 229);
            label8.Name = "label8";
            label8.Size = new Size(31, 15);
            label8.TabIndex = 22;
            label8.Text = "Legs";
            label8.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(478, 191);
            label9.Name = "label9";
            label9.Size = new Size(41, 15);
            label9.TabIndex = 21;
            label9.Text = "Armor";
            label9.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(467, 152);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 20;
            label10.Text = "Weapon";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(489, 73);
            label11.Name = "label11";
            label11.Size = new Size(32, 15);
            label11.TabIndex = 19;
            label11.Text = "Type";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox4);
            Controls.Add(comboBox5);
            Controls.Add(comboBox6);
            Controls.Add(BlueRobotType);
            Controls.Add(Battle);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(RedRobotType);
            Controls.Add(CBR);
            Controls.Add(CRR);
            Controls.Add(CheckStats);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CheckStats;
        private Button CRR;
        private Button CBR;
        private ComboBox RedRobotType;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button Battle;
        private ComboBox BlueRobotType;
        private ComboBox comboBox4;
        private ComboBox comboBox5;
        private ComboBox comboBox6;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}