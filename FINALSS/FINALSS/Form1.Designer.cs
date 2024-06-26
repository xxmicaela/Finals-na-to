namespace FINALSS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            chbShowPassword = new CheckBox();
            btnSignIn = new Button();
            btnCancel = new Button();
            label5 = new Label();
            LinkSignUp = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Viner Hand ITC", 25.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightCoral;
            label1.Location = new Point(170, 46);
            label1.Name = "label1";
            label1.Size = new Size(182, 68);
            label1.TabIndex = 0;
            label1.Text = "Sign In";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightCoral;
            label2.Location = new Point(29, 271);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 2;
            label2.Text = "Username:";
            label2.Click += label2_Click;
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUsername.Location = new Point(29, 303);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter your username";
            txtUsername.Size = new Size(257, 34);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.Location = new Point(29, 390);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter your password";
            txtPassword.Size = new Size(259, 36);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Palatino Linotype", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightCoral;
            label3.Location = new Point(29, 357);
            label3.Name = "label3";
            label3.Size = new Size(87, 23);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // chbShowPassword
            // 
            chbShowPassword.AutoSize = true;
            chbShowPassword.BackColor = Color.Transparent;
            chbShowPassword.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            chbShowPassword.ForeColor = Color.LightCoral;
            chbShowPassword.Location = new Point(32, 432);
            chbShowPassword.Name = "chbShowPassword";
            chbShowPassword.Size = new Size(140, 22);
            chbShowPassword.TabIndex = 6;
            chbShowPassword.Text = "Show Password";
            chbShowPassword.UseVisualStyleBackColor = false;
            chbShowPassword.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.CornflowerBlue;
            btnSignIn.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.Location = new Point(93, 505);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(259, 52);
            btnSignIn.TabIndex = 7;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.DodgerBlue;
            btnCancel.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(93, 614);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(259, 54);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Palatino Linotype", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.LightCoral;
            label5.Location = new Point(93, 564);
            label5.Name = "label5";
            label5.Size = new Size(164, 20);
            label5.TabIndex = 10;
            label5.Text = "Don't have an account?";
            label5.Click += label5_Click;
            // 
            // LinkSignUp
            // 
            LinkSignUp.AutoSize = true;
            LinkSignUp.BackColor = Color.Transparent;
            LinkSignUp.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LinkSignUp.LinkColor = Color.WhiteSmoke;
            LinkSignUp.Location = new Point(247, 565);
            LinkSignUp.Name = "LinkSignUp";
            LinkSignUp.Size = new Size(63, 18);
            LinkSignUp.TabIndex = 11;
            LinkSignUp.TabStop = true;
            LinkSignUp.Text = "Sign Up";
            LinkSignUp.LinkClicked += LinkSignUp_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(501, 732);
            Controls.Add(LinkSignUp);
            Controls.Add(label5);
            Controls.Add(btnCancel);
            Controls.Add(btnSignIn);
            Controls.Add(chbShowPassword);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label3;
        private CheckBox chbShowPassword;
        private Button btnSignIn;
        private Button btnCancel;
        private Label label5;
        private LinkLabel LinkSignUp;
    }
}
