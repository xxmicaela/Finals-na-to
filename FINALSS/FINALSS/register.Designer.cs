namespace FINALSS
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            btnRegisterAccount = new Button();
            btnBackSignIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DeepPink;
            label1.Location = new Point(172, 49);
            label1.Name = "label1";
            label1.Size = new Size(151, 44);
            label1.TabIndex = 0;
            label1.Text = "Sign Up";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.MediumVioletRed;
            label2.Location = new Point(25, 154);
            label2.Name = "label2";
            label2.Size = new Size(70, 23);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.MediumVioletRed;
            label3.Location = new Point(25, 280);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 2;
            label3.Text = "Username";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.MediumVioletRed;
            label4.Location = new Point(25, 394);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 3;
            label4.Text = "Password";
            // 
            // txtName
            // 
            txtName.Location = new Point(25, 193);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(356, 38);
            txtName.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(25, 432);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(356, 38);
            txtPassword.TabIndex = 5;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(25, 318);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(356, 37);
            txtUsername.TabIndex = 6;
            // 
            // btnRegisterAccount
            // 
            btnRegisterAccount.BackColor = Color.PaleVioletRed;
            btnRegisterAccount.FlatStyle = FlatStyle.Flat;
            btnRegisterAccount.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegisterAccount.Location = new Point(113, 519);
            btnRegisterAccount.Name = "btnRegisterAccount";
            btnRegisterAccount.Size = new Size(268, 46);
            btnRegisterAccount.TabIndex = 7;
            btnRegisterAccount.Text = "Register Account";
            btnRegisterAccount.UseVisualStyleBackColor = false;
            btnRegisterAccount.Click += btnRegisterAccount_Click;
            // 
            // btnBackSignIn
            // 
            btnBackSignIn.BackColor = Color.Crimson;
            btnBackSignIn.FlatStyle = FlatStyle.Flat;
            btnBackSignIn.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackSignIn.Location = new Point(113, 597);
            btnBackSignIn.Name = "btnBackSignIn";
            btnBackSignIn.Size = new Size(268, 43);
            btnBackSignIn.TabIndex = 8;
            btnBackSignIn.Text = "Sign In";
            btnBackSignIn.UseVisualStyleBackColor = false;
            btnBackSignIn.Click += button2_Click;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Pink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(493, 686);
            Controls.Add(btnBackSignIn);
            Controls.Add(btnRegisterAccount);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "register";
            Text = "register";
            Load += register_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Button btnRegisterAccount;
        private Button btnBackSignIn;
    }
}