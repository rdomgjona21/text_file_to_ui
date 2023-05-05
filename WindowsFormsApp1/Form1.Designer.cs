namespace WindowsFormsApp1
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
            this.button1 = new System.Windows.Forms.Button();
            this.labelFullName = new System.Windows.Forms.Label();
            this.textFullName = new System.Windows.Forms.TextBox();
            this.labelYearofBirth = new System.Windows.Forms.Label();
            this.textYearofBirth = new System.Windows.Forms.TextBox();
            this.labelCity = new System.Windows.Forms.Label();
            this.textCity = new System.Windows.Forms.TextBox();
            this.labelFaculty = new System.Windows.Forms.Label();
            this.textFaculty = new System.Windows.Forms.TextBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.textRole = new System.Windows.Forms.TextBox();
            this.labelRoleDep = new System.Windows.Forms.Label();
            this.textDepartment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnload1_Click);
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Location = new System.Drawing.Point(12, 69);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(55, 13);
            this.labelFullName.TabIndex = 1;
            this.labelFullName.Text = "Full name:";
            this.labelFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // textFullName
            // 
            this.textFullName.Location = new System.Drawing.Point(137, 69);
            this.textFullName.Name = "textFullName";
            this.textFullName.Size = new System.Drawing.Size(301, 20);
            this.textFullName.TabIndex = 2;
            this.textFullName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelYearofBirth
            // 
            this.labelYearofBirth.AutoSize = true;
            this.labelYearofBirth.Location = new System.Drawing.Point(12, 98);
            this.labelYearofBirth.Name = "labelYearofBirth";
            this.labelYearofBirth.Size = new System.Drawing.Size(67, 13);
            this.labelYearofBirth.TabIndex = 3;
            this.labelYearofBirth.Text = "Year of birth:";
            this.labelYearofBirth.Click += new System.EventHandler(this.label2_Click);
            // 
            // textYearofBirth
            // 
            this.textYearofBirth.Location = new System.Drawing.Point(137, 98);
            this.textYearofBirth.Name = "textYearofBirth";
            this.textYearofBirth.Size = new System.Drawing.Size(301, 20);
            this.textYearofBirth.TabIndex = 5;
            this.textYearofBirth.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(12, 128);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(27, 13);
            this.labelCity.TabIndex = 6;
            this.labelCity.Text = "City:";
            this.labelCity.Click += new System.EventHandler(this.label3_Click);
            // 
            // textCity
            // 
            this.textCity.Location = new System.Drawing.Point(137, 124);
            this.textCity.Name = "textCity";
            this.textCity.Size = new System.Drawing.Size(301, 20);
            this.textCity.TabIndex = 7;
            this.textCity.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // labelFaculty
            // 
            this.labelFaculty.AutoSize = true;
            this.labelFaculty.Location = new System.Drawing.Point(12, 155);
            this.labelFaculty.Name = "labelFaculty";
            this.labelFaculty.Size = new System.Drawing.Size(44, 13);
            this.labelFaculty.TabIndex = 8;
            this.labelFaculty.Text = "Faculty:";
            this.labelFaculty.Click += new System.EventHandler(this.label4_Click);
            // 
            // textFaculty
            // 
            this.textFaculty.Location = new System.Drawing.Point(137, 155);
            this.textFaculty.Name = "textFaculty";
            this.textFaculty.Size = new System.Drawing.Size(301, 20);
            this.textFaculty.TabIndex = 9;
            this.textFaculty.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(12, 186);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(32, 13);
            this.labelRole.TabIndex = 10;
            this.labelRole.Text = "Role:";
            this.labelRole.Click += new System.EventHandler(this.label5_Click);
            // 
            // textRole
            // 
            this.textRole.Location = new System.Drawing.Point(137, 186);
            this.textRole.Name = "textRole";
            this.textRole.Size = new System.Drawing.Size(301, 20);
            this.textRole.TabIndex = 11;
            this.textRole.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelRoleDep
            // 
            this.labelRoleDep.AutoSize = true;
            this.labelRoleDep.Location = new System.Drawing.Point(9, 218);
            this.labelRoleDep.Name = "labelRoleDep";
            this.labelRoleDep.Size = new System.Drawing.Size(107, 13);
            this.labelRoleDep.TabIndex = 12;
            this.labelRoleDep.Text = "[role specific atribute]";
            this.labelRoleDep.Click += new System.EventHandler(this.label6_Click);
            // 
            // textDepartment
            // 
            this.textDepartment.Location = new System.Drawing.Point(137, 218);
            this.textDepartment.Name = "textDepartment";
            this.textDepartment.Size = new System.Drawing.Size(301, 20);
            this.textDepartment.TabIndex = 13;
            this.textDepartment.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 329);
            this.Controls.Add(this.textDepartment);
            this.Controls.Add(this.labelRoleDep);
            this.Controls.Add(this.textRole);
            this.Controls.Add(this.labelRole);
            this.Controls.Add(this.textFaculty);
            this.Controls.Add(this.labelFaculty);
            this.Controls.Add(this.textCity);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.textYearofBirth);
            this.Controls.Add(this.labelYearofBirth);
            this.Controls.Add(this.textFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelFullName;
        private System.Windows.Forms.TextBox textFullName;
        private System.Windows.Forms.Label labelYearofBirth;
        private System.Windows.Forms.TextBox textYearofBirth;
        private System.Windows.Forms.Label labelCity;
        private System.Windows.Forms.TextBox textCity;
        private System.Windows.Forms.Label labelFaculty;
        private System.Windows.Forms.TextBox textFaculty;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.TextBox textRole;
        private System.Windows.Forms.Label labelRoleDep;
        private System.Windows.Forms.TextBox textDepartment;
    }
}

