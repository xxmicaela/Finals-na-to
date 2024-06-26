namespace FINALSS
{
    partial class admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin));
            label1 = new Label();
            label2 = new Label();
            txtID = new TextBox();
            txtName = new TextBox();
            label5 = new Label();
            txtNumber = new TextBox();
            label3 = new Label();
            txtColor = new TextBox();
            label4 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnUpdate = new Button();
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnLogout = new Button();
            cbRole = new ComboBox();
            btnRemove = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.GradientActiveCaption;
            label1.Location = new Point(457, 42);
            label1.Name = "label1";
            label1.Size = new Size(414, 47);
            label1.TabIndex = 0;
            label1.Text = "Welcome to BINI PH.";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 91);
            label2.Name = "label2";
            label2.Size = new Size(19, 19);
            label2.TabIndex = 1;
            label2.Text = "#";
            // 
            // txtID
            // 
            txtID.Location = new Point(41, 120);
            txtID.Multiline = true;
            txtID.Name = "txtID";
            txtID.Size = new Size(273, 34);
            txtID.TabIndex = 2;
            // 
            // txtName
            // 
            txtName.Location = new Point(41, 193);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(273, 34);
            txtName.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 164);
            label5.Name = "label5";
            label5.Size = new Size(65, 19);
            label5.TabIndex = 7;
            label5.Text = "Name:";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(41, 344);
            txtNumber.Multiline = true;
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(273, 34);
            txtNumber.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(41, 315);
            label3.Name = "label3";
            label3.Size = new Size(80, 19);
            label3.TabIndex = 11;
            label3.Text = "Number:";
            // 
            // txtColor
            // 
            txtColor.Location = new Point(41, 271);
            txtColor.Multiline = true;
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(273, 34);
            txtColor.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(41, 242);
            label4.Name = "label4";
            label4.Size = new Size(58, 19);
            label4.TabIndex = 9;
            label4.Text = "Color:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(41, 393);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 13;
            label6.Text = "Role";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.PaleVioletRed;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(41, 483);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(273, 59);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "Add Account";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Crimson;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(41, 570);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(273, 59);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update Account";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(391, 164);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(361, 34);
            txtSearch.TabIndex = 17;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumVioletRed;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearch.Location = new Point(758, 164);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(131, 34);
            btnSearch.TabIndex = 18;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(391, 226);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(498, 370);
            dataGridView1.TabIndex = 19;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.PaleVioletRed;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(758, 610);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(131, 34);
            btnLogout.TabIndex = 20;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // cbRole
            // 
            cbRole.FormattingEnabled = true;
            cbRole.Items.AddRange(new object[] { "Visual", "Lead Dancer", "Main Dancer", "Lead Vocal", "Main Vocal", "Lead Rapper", "Main Rapper", "Leader", "Sub Vocal" });
            cbRole.Location = new Point(41, 428);
            cbRole.Name = "cbRole";
            cbRole.Size = new Size(273, 28);
            cbRole.TabIndex = 21;
            // 
            // btnRemove
            // 
            btnRemove.BackColor = Color.PaleVioletRed;
            btnRemove.FlatStyle = FlatStyle.Flat;
            btnRemove.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemove.Location = new Point(391, 610);
            btnRemove.Name = "btnRemove";
            btnRemove.Size = new Size(131, 34);
            btnRemove.TabIndex = 22;
            btnRemove.Text = "Remove";
            btnRemove.UseVisualStyleBackColor = false;
            btnRemove.Click += btnRemove_Click;
            // 
            // admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(941, 687);
            Controls.Add(btnRemove);
            Controls.Add(cbRole);
            Controls.Add(btnLogout);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(label6);
            Controls.Add(txtNumber);
            Controls.Add(label3);
            Controls.Add(txtColor);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label5);
            Controls.Add(txtID);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "admin";
            Text = "admin";
            Load += admin_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtID;
        private TextBox txtName;
        private Label label5;
        private TextBox txtNumber;
        private Label label3;
        private TextBox txtColor;
        private Label label4;
        private Label label6;
        private Button btnAdd;
        private Button btnUpdate;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnLogout;
        private ComboBox cbRole;
        private Button btnRemove;
    }
}