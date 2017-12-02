namespace WindowsFormsUsers
{
    partial class AddUser
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
            this.lblAddUser = new System.Windows.Forms.Label();
            this.lblAddUsername = new System.Windows.Forms.Label();
            this.lblAddName = new System.Windows.Forms.Label();
            this.lblAddSurname = new System.Windows.Forms.Label();
            this.lblAddPassword = new System.Windows.Forms.Label();
            this.inptAddUsername = new System.Windows.Forms.TextBox();
            this.inptAddName = new System.Windows.Forms.TextBox();
            this.inptAddSurname = new System.Windows.Forms.TextBox();
            this.inptAddPassword = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Location = new System.Drawing.Point(194, 21);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(80, 13);
            this.lblAddUser.TabIndex = 0;
            this.lblAddUser.Text = "Dodaj korisnika";
            // 
            // lblAddUsername
            // 
            this.lblAddUsername.AutoSize = true;
            this.lblAddUsername.Location = new System.Drawing.Point(48, 78);
            this.lblAddUsername.Name = "lblAddUsername";
            this.lblAddUsername.Size = new System.Drawing.Size(55, 13);
            this.lblAddUsername.TabIndex = 1;
            this.lblAddUsername.Text = "Username";
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(51, 195);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(24, 13);
            this.lblAddName.TabIndex = 2;
            this.lblAddName.Text = "Ime";
            // 
            // lblAddSurname
            // 
            this.lblAddSurname.AutoSize = true;
            this.lblAddSurname.Location = new System.Drawing.Point(51, 159);
            this.lblAddSurname.Name = "lblAddSurname";
            this.lblAddSurname.Size = new System.Drawing.Size(44, 13);
            this.lblAddSurname.TabIndex = 3;
            this.lblAddSurname.Text = "Prezime";
            // 
            // lblAddPassword
            // 
            this.lblAddPassword.AutoSize = true;
            this.lblAddPassword.Location = new System.Drawing.Point(48, 115);
            this.lblAddPassword.Name = "lblAddPassword";
            this.lblAddPassword.Size = new System.Drawing.Size(44, 13);
            this.lblAddPassword.TabIndex = 4;
            this.lblAddPassword.Text = "Lozinka";
            // 
            // inptAddUsername
            // 
            this.inptAddUsername.Location = new System.Drawing.Point(150, 70);
            this.inptAddUsername.Name = "inptAddUsername";
            this.inptAddUsername.Size = new System.Drawing.Size(230, 20);
            this.inptAddUsername.TabIndex = 5;
            // 
            // inptAddName
            // 
            this.inptAddName.Location = new System.Drawing.Point(150, 195);
            this.inptAddName.Name = "inptAddName";
            this.inptAddName.Size = new System.Drawing.Size(230, 20);
            this.inptAddName.TabIndex = 6;
            // 
            // inptAddSurname
            // 
            this.inptAddSurname.Location = new System.Drawing.Point(150, 151);
            this.inptAddSurname.Name = "inptAddSurname";
            this.inptAddSurname.Size = new System.Drawing.Size(230, 20);
            this.inptAddSurname.TabIndex = 7;
            // 
            // inptAddPassword
            // 
            this.inptAddPassword.Location = new System.Drawing.Point(150, 108);
            this.inptAddPassword.Name = "inptAddPassword";
            this.inptAddPassword.Size = new System.Drawing.Size(230, 20);
            this.inptAddPassword.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(150, 260);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "ZATVORI";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(305, 260);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "DODAJ";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 328);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.inptAddPassword);
            this.Controls.Add(this.inptAddSurname);
            this.Controls.Add(this.inptAddName);
            this.Controls.Add(this.inptAddUsername);
            this.Controls.Add(this.lblAddPassword);
            this.Controls.Add(this.lblAddSurname);
            this.Controls.Add(this.lblAddName);
            this.Controls.Add(this.lblAddUsername);
            this.Controls.Add(this.lblAddUser);
            this.Name = "AddUser";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.Label lblAddUsername;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.Label lblAddSurname;
        private System.Windows.Forms.Label lblAddPassword;
        private System.Windows.Forms.TextBox inptAddUsername;
        private System.Windows.Forms.TextBox inptAddName;
        private System.Windows.Forms.TextBox inptAddSurname;
        private System.Windows.Forms.TextBox inptAddPassword;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
    }
}