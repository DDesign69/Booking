namespace Booking
{
    partial class Register
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtPitanjeReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnRegSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.txtEmailReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.txtPassReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUserReg = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.txtPitanjeReg);
            this.panel1.Controls.Add(this.btnRegSave);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.txtEmailReg);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.txtPassReg);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.txtUserReg);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 450);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(24, 352);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 15);
            this.label2.TabIndex = 18;
            this.label2.Text = "SIGURNOSNO PITANJE!";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(191, 309);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(34, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // txtPitanjeReg
            // 
            this.txtPitanjeReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPitanjeReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPitanjeReg.ForeColor = System.Drawing.Color.White;
            this.txtPitanjeReg.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPitanjeReg.HintText = "Sigurnosna rec";
            this.txtPitanjeReg.isPassword = false;
            this.txtPitanjeReg.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtPitanjeReg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPitanjeReg.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPitanjeReg.LineThickness = 3;
            this.txtPitanjeReg.Location = new System.Drawing.Point(26, 302);
            this.txtPitanjeReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtPitanjeReg.Name = "txtPitanjeReg";
            this.txtPitanjeReg.Size = new System.Drawing.Size(199, 46);
            this.txtPitanjeReg.TabIndex = 16;
            this.txtPitanjeReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPitanjeReg.OnValueChanged += new System.EventHandler(this.txtPitanjeReg_OnValueChanged);
            // 
            // btnRegSave
            // 
            this.btnRegSave.Activecolor = System.Drawing.Color.DodgerBlue;
            this.btnRegSave.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnRegSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegSave.BorderRadius = 5;
            this.btnRegSave.ButtonText = "POTVRDI";
            this.btnRegSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnRegSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnRegSave.Iconimage = null;
            this.btnRegSave.Iconimage_right = null;
            this.btnRegSave.Iconimage_right_Selected = null;
            this.btnRegSave.Iconimage_Selected = null;
            this.btnRegSave.IconMarginLeft = 0;
            this.btnRegSave.IconMarginRight = 0;
            this.btnRegSave.IconRightVisible = true;
            this.btnRegSave.IconRightZoom = 0D;
            this.btnRegSave.IconVisible = true;
            this.btnRegSave.IconZoom = 40D;
            this.btnRegSave.IsTab = false;
            this.btnRegSave.Location = new System.Drawing.Point(57, 392);
            this.btnRegSave.Name = "btnRegSave";
            this.btnRegSave.Normalcolor = System.Drawing.Color.DodgerBlue;
            this.btnRegSave.OnHovercolor = System.Drawing.Color.DodgerBlue;
            this.btnRegSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnRegSave.selected = false;
            this.btnRegSave.Size = new System.Drawing.Size(136, 32);
            this.btnRegSave.TabIndex = 15;
            this.btnRegSave.Text = "POTVRDI";
            this.btnRegSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRegSave.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(81)))), ((int)(((byte)(87)))));
            this.btnRegSave.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegSave.Click += new System.EventHandler(this.btnRegSave_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(191, 243);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 31);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // txtEmailReg
            // 
            this.txtEmailReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmailReg.ForeColor = System.Drawing.Color.White;
            this.txtEmailReg.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailReg.HintText = "Email";
            this.txtEmailReg.isPassword = false;
            this.txtEmailReg.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailReg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmailReg.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtEmailReg.LineThickness = 3;
            this.txtEmailReg.Location = new System.Drawing.Point(26, 236);
            this.txtEmailReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmailReg.Name = "txtEmailReg";
            this.txtEmailReg.Size = new System.Drawing.Size(199, 46);
            this.txtEmailReg.TabIndex = 13;
            this.txtEmailReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmailReg.OnValueChanged += new System.EventHandler(this.txtEmailReg_OnValueChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(191, 178);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // txtPassReg
            // 
            this.txtPassReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPassReg.ForeColor = System.Drawing.Color.White;
            this.txtPassReg.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtPassReg.HintText = "Lozinka";
            this.txtPassReg.isPassword = false;
            this.txtPassReg.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtPassReg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPassReg.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtPassReg.LineThickness = 3;
            this.txtPassReg.Location = new System.Drawing.Point(26, 171);
            this.txtPassReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassReg.Name = "txtPassReg";
            this.txtPassReg.Size = new System.Drawing.Size(199, 46);
            this.txtPassReg.TabIndex = 11;
            this.txtPassReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassReg.OnValueChanged += new System.EventHandler(this.txtPassReg_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(191, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // txtUserReg
            // 
            this.txtUserReg.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserReg.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtUserReg.ForeColor = System.Drawing.Color.White;
            this.txtUserReg.HintForeColor = System.Drawing.Color.DodgerBlue;
            this.txtUserReg.HintText = "Korisnicko ime";
            this.txtUserReg.isPassword = false;
            this.txtUserReg.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtUserReg.LineIdleColor = System.Drawing.Color.Gray;
            this.txtUserReg.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtUserReg.LineThickness = 3;
            this.txtUserReg.Location = new System.Drawing.Point(26, 107);
            this.txtUserReg.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserReg.Name = "txtUserReg";
            this.txtUserReg.Size = new System.Drawing.Size(199, 46);
            this.txtUserReg.TabIndex = 9;
            this.txtUserReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserReg.OnValueChanged += new System.EventHandler(this.txtUserReg_OnValueChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 2);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(27, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRACIJA";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(250, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 450);
            this.panel2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(330, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "X";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(29, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "* unesite u polje";
            this.label10.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(29, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 15);
            this.label4.TabIndex = 20;
            this.label4.Text = "* unesite u polje";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(29, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "* unesite u polje";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(29, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "* unesite u polje";
            this.label6.Visible = false;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUserReg;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmailReg;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPassReg;
        private Bunifu.Framework.UI.BunifuFlatButton btnRegSave;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPitanjeReg;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
    }
}