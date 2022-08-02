namespace UserControl_Task
{
    partial class UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC));
            this.numberLbl = new System.Windows.Forms.Label();
            this.studentNameLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.guna2CustomRadioButton1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.attendanceRB = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2CustomRadioButton3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2ComboBox2 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.LastEnteredDateLbl = new System.Windows.Forms.Label();
            this.guna2ImageCheckBox1 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2ImageCheckBox2 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.guna2ImageCheckBox3 = new Guna.UI2.WinForms.Guna2ImageCheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // numberLbl
            // 
            this.numberLbl.AutoSize = true;
            this.numberLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberLbl.Location = new System.Drawing.Point(3, 64);
            this.numberLbl.Name = "numberLbl";
            this.numberLbl.Size = new System.Drawing.Size(50, 16);
            this.numberLbl.TabIndex = 0;
            this.numberLbl.Text = "label1";
            // 
            // studentNameLbl
            // 
            this.studentNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLbl.Location = new System.Drawing.Point(160, 59);
            this.studentNameLbl.Name = "studentNameLbl";
            this.studentNameLbl.Size = new System.Drawing.Size(140, 32);
            this.studentNameLbl.TabIndex = 2;
            this.studentNameLbl.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.guna2CustomRadioButton3);
            this.groupBox1.Controls.Add(this.attendanceRB);
            this.groupBox1.Controls.Add(this.guna2CustomRadioButton1);
            this.groupBox1.Location = new System.Drawing.Point(513, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 35);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // guna2CustomRadioButton1
            // 
            this.guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2CustomRadioButton1.CheckedState.BorderThickness = 4;
            this.guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2CustomRadioButton1.Location = new System.Drawing.Point(7, 10);
            this.guna2CustomRadioButton1.Name = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton1.TabIndex = 0;
            this.guna2CustomRadioButton1.Text = "guna2CustomRadioButton1";
            this.guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2CustomRadioButton1.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.White;
            this.guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // attendanceRB
            // 
            this.attendanceRB.CheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.attendanceRB.CheckedState.BorderThickness = 3;
            this.attendanceRB.CheckedState.FillColor = System.Drawing.Color.Yellow;
            this.attendanceRB.CheckedState.InnerColor = System.Drawing.Color.Yellow;
            this.attendanceRB.Location = new System.Drawing.Point(73, 10);
            this.attendanceRB.Name = "attendanceRB";
            this.attendanceRB.Size = new System.Drawing.Size(20, 20);
            this.attendanceRB.TabIndex = 1;
            this.attendanceRB.Text = "guna2CustomRadioButton2";
            this.attendanceRB.UncheckedState.BorderColor = System.Drawing.Color.Yellow;
            this.attendanceRB.UncheckedState.BorderThickness = 2;
            this.attendanceRB.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.attendanceRB.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2CustomRadioButton3
            // 
            this.guna2CustomRadioButton3.CheckedState.BorderColor = System.Drawing.Color.Red;
            this.guna2CustomRadioButton3.CheckedState.BorderThickness = 3;
            this.guna2CustomRadioButton3.CheckedState.FillColor = System.Drawing.Color.Red;
            this.guna2CustomRadioButton3.CheckedState.InnerColor = System.Drawing.Color.Red;
            this.guna2CustomRadioButton3.Location = new System.Drawing.Point(141, 10);
            this.guna2CustomRadioButton3.Name = "guna2CustomRadioButton3";
            this.guna2CustomRadioButton3.Size = new System.Drawing.Size(20, 20);
            this.guna2CustomRadioButton3.TabIndex = 2;
            this.guna2CustomRadioButton3.Text = "guna2CustomRadioButton3";
            this.guna2CustomRadioButton3.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.guna2CustomRadioButton3.UncheckedState.BorderThickness = 2;
            this.guna2CustomRadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomRadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderColor = System.Drawing.Color.Fuchsia;
            this.guna2ComboBox1.BorderThickness = 3;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Location = new System.Drawing.Point(779, 55);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(81, 36);
            this.guna2ComboBox1.TabIndex = 4;
            // 
            // guna2ComboBox2
            // 
            this.guna2ComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.guna2ComboBox2.BorderThickness = 3;
            this.guna2ComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox2.ItemHeight = 30;
            this.guna2ComboBox2.Location = new System.Drawing.Point(1026, 55);
            this.guna2ComboBox2.Name = "guna2ComboBox2";
            this.guna2ComboBox2.Size = new System.Drawing.Size(81, 36);
            this.guna2ComboBox2.TabIndex = 5;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(1128, 55);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(290, 36);
            this.guna2TextBox1.TabIndex = 10;
            this.guna2TextBox1.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1125, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "Rəy";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1114, 123);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(146, 33);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Text = "Rəy Yazmaq";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(1272, 123);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(146, 33);
            this.guna2Button2.TabIndex = 13;
            this.guna2Button2.Text = "İmtina Etmək";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(0, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1820, 10);
            this.label2.TabIndex = 14;
            // 
            // LastEnteredDateLbl
            // 
            this.LastEnteredDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.LastEnteredDateLbl.Location = new System.Drawing.Point(364, 59);
            this.LastEnteredDateLbl.Name = "LastEnteredDateLbl";
            this.LastEnteredDateLbl.Size = new System.Drawing.Size(125, 32);
            this.LastEnteredDateLbl.TabIndex = 15;
            this.LastEnteredDateLbl.Text = "label1";
            // 
            // guna2ImageCheckBox1
            // 
            this.guna2ImageCheckBox1.BackgroundImage = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox1.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.guna2ImageCheckBox1.Image = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox1.ImageRotate = 0F;
            this.guna2ImageCheckBox1.Location = new System.Drawing.Point(899, 64);
            this.guna2ImageCheckBox1.Name = "guna2ImageCheckBox1";
            this.guna2ImageCheckBox1.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox1.TabIndex = 16;
            this.guna2ImageCheckBox1.CheckedChanged += new System.EventHandler(this.guna2ImageCheckBox1_CheckedChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.BackgroundImage = global::UserControl_Task.Properties.Resources.anon;
            this.guna2CirclePictureBox1.Image = global::UserControl_Task.Properties.Resources.anon;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(66, 59);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(43, 35);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 1;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // guna2ImageCheckBox2
            // 
            this.guna2ImageCheckBox2.BackgroundImage = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox2.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.guna2ImageCheckBox2.Image = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox2.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox2.ImageRotate = 0F;
            this.guna2ImageCheckBox2.Location = new System.Drawing.Point(959, 64);
            this.guna2ImageCheckBox2.Name = "guna2ImageCheckBox2";
            this.guna2ImageCheckBox2.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox2.TabIndex = 17;
            // 
            // guna2ImageCheckBox3
            // 
            this.guna2ImageCheckBox3.BackgroundImage = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox3.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.guna2ImageCheckBox3.Image = global::UserControl_Task.Properties.Resources.emptyCrystal;
            this.guna2ImageCheckBox3.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageCheckBox3.ImageRotate = 0F;
            this.guna2ImageCheckBox3.Location = new System.Drawing.Point(929, 64);
            this.guna2ImageCheckBox3.Name = "guna2ImageCheckBox3";
            this.guna2ImageCheckBox3.Size = new System.Drawing.Size(24, 24);
            this.guna2ImageCheckBox3.TabIndex = 18;
            // 
            // UC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2ImageCheckBox3);
            this.Controls.Add(this.guna2ImageCheckBox2);
            this.Controls.Add(this.guna2ImageCheckBox1);
            this.Controls.Add(this.LastEnteredDateLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2ComboBox2);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.studentNameLbl);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.numberLbl);
            this.Name = "UC";
            this.Size = new System.Drawing.Size(1920, 196);
            this.Load += new System.EventHandler(this.UC_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numberLbl;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label studentNameLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton guna2CustomRadioButton3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton attendanceRB;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LastEnteredDateLbl;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox1;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox2;
        private Guna.UI2.WinForms.Guna2ImageCheckBox guna2ImageCheckBox3;
    }
}
