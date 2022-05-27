
namespace _066_ExeDataGridandNavBinding
{
    partial class MenuLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuLogin));
            this.Judul = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UserID = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.Label();
            this.InputUser = new System.Windows.Forms.TextBox();
            this.InputPW = new System.Windows.Forms.TextBox();
            this.TnC = new System.Windows.Forms.CheckBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Judul
            // 
            this.Judul.AutoSize = true;
            this.Judul.BackColor = System.Drawing.Color.Transparent;
            this.Judul.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Judul.Font = new System.Drawing.Font("Glacial Indifference", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Judul.ForeColor = System.Drawing.Color.Yellow;
            this.Judul.Location = new System.Drawing.Point(148, 24);
            this.Judul.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Judul.Name = "Judul";
            this.Judul.Size = new System.Drawing.Size(224, 31);
            this.Judul.TabIndex = 2;
            this.Judul.Text = "DATA MAHASISWA";
            this.Judul.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(112, 70);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 213);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // UserID
            // 
            this.UserID.AutoSize = true;
            this.UserID.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserID.Location = new System.Drawing.Point(109, 314);
            this.UserID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserID.Name = "UserID";
            this.UserID.Size = new System.Drawing.Size(113, 23);
            this.UserID.TabIndex = 3;
            this.UserID.Text = "User ID       :";
            this.UserID.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("Glacial Indifference", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PW.Location = new System.Drawing.Point(108, 373);
            this.PW.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(113, 23);
            this.PW.TabIndex = 4;
            this.PW.Text = "Password  :";
            this.PW.Click += new System.EventHandler(this.label3_Click);
            // 
            // InputUser
            // 
            this.InputUser.Location = new System.Drawing.Point(237, 314);
            this.InputUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputUser.Name = "InputUser";
            this.InputUser.Size = new System.Drawing.Size(155, 20);
            this.InputUser.TabIndex = 5;
            this.InputUser.TextChanged += new System.EventHandler(this.InputUser_TextChanged);
            // 
            // InputPW
            // 
            this.InputPW.Location = new System.Drawing.Point(237, 373);
            this.InputPW.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InputPW.Name = "InputPW";
            this.InputPW.Size = new System.Drawing.Size(155, 20);
            this.InputPW.TabIndex = 6;
            this.InputPW.TextChanged += new System.EventHandler(this.InputPW_TextChanged);
            // 
            // TnC
            // 
            this.TnC.AutoSize = true;
            this.TnC.Font = new System.Drawing.Font("Glacial Indifference", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TnC.Location = new System.Drawing.Point(112, 420);
            this.TnC.Name = "TnC";
            this.TnC.Size = new System.Drawing.Size(158, 20);
            this.TnC.TabIndex = 7;
            this.TnC.Text = "Terms and Conditions";
            this.TnC.UseVisualStyleBackColor = true;
            this.TnC.CheckedChanged += new System.EventHandler(this.TnC_CheckedChanged);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.Font = new System.Drawing.Font("Glacial Indifference", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.Location = new System.Drawing.Point(317, 464);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(75, 23);
            this.ButtonLogin.TabIndex = 8;
            this.ButtonLogin.Text = "Login";
            this.ButtonLogin.UseVisualStyleBackColor = true;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Font = new System.Drawing.Font("Glacial Indifference", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(112, 464);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 23);
            this.ButtonExit.TabIndex = 9;
            this.ButtonExit.Text = "Exit";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // MenuLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(511, 516);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonLogin);
            this.Controls.Add(this.TnC);
            this.Controls.Add(this.InputPW);
            this.Controls.Add(this.InputUser);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.UserID);
            this.Controls.Add(this.Judul);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuLogin";
            this.Text = "MenuLogin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Judul;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label UserID;
        private System.Windows.Forms.Label PW;
        private System.Windows.Forms.TextBox InputUser;
        private System.Windows.Forms.TextBox InputPW;
        private System.Windows.Forms.CheckBox TnC;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Button ButtonExit;
    }
}

