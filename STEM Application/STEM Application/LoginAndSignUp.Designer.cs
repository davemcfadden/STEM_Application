namespace STEM_Application
{
    partial class LoginAndSignUp
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
            this.SignUp = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.loginEmail_label = new System.Windows.Forms.Label();
            this.loginPassword_Input = new System.Windows.Forms.TextBox();
            this.loginPassword_label = new System.Windows.Forms.Label();
            this.loginEmail_Input = new System.Windows.Forms.TextBox();
            this.loginValidation = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.validationErrors = new System.Windows.Forms.ListView();
            this.submit = new System.Windows.Forms.Button();
            this.name_input = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_label = new System.Windows.Forms.Label();
            this.confirmpassword_input = new System.Windows.Forms.TextBox();
            this.confirmpassword_label = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.cancel = new System.Windows.Forms.Button();
            this.SignUp.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // SignUp
            // 
            this.SignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SignUp.Controls.Add(this.tabPage1);
            this.SignUp.Controls.Add(this.tabPage2);
            this.SignUp.Location = new System.Drawing.Point(12, 1);
            this.SignUp.Name = "SignUp";
            this.SignUp.SelectedIndex = 0;
            this.SignUp.Size = new System.Drawing.Size(319, 433);
            this.SignUp.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.loginEmail_label);
            this.tabPage1.Controls.Add(this.loginPassword_Input);
            this.tabPage1.Controls.Add(this.loginPassword_label);
            this.tabPage1.Controls.Add(this.loginEmail_Input);
            this.tabPage1.Controls.Add(this.loginValidation);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(311, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Login";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loginEmail_label
            // 
            this.loginEmail_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginEmail_label.AutoSize = true;
            this.loginEmail_label.Location = new System.Drawing.Point(8, 50);
            this.loginEmail_label.Name = "loginEmail_label";
            this.loginEmail_label.Size = new System.Drawing.Size(32, 13);
            this.loginEmail_label.TabIndex = 28;
            this.loginEmail_label.Text = "Email";
            // 
            // loginPassword_Input
            // 
            this.loginPassword_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPassword_Input.Location = new System.Drawing.Point(109, 86);
            this.loginPassword_Input.MaxLength = 20;
            this.loginPassword_Input.Name = "loginPassword_Input";
            this.loginPassword_Input.PasswordChar = '*';
            this.loginPassword_Input.Size = new System.Drawing.Size(155, 20);
            this.loginPassword_Input.TabIndex = 26;
            // 
            // loginPassword_label
            // 
            this.loginPassword_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginPassword_label.AutoSize = true;
            this.loginPassword_label.Location = new System.Drawing.Point(8, 93);
            this.loginPassword_label.Name = "loginPassword_label";
            this.loginPassword_label.Size = new System.Drawing.Size(53, 13);
            this.loginPassword_label.TabIndex = 27;
            this.loginPassword_label.Text = "Password";
            // 
            // loginEmail_Input
            // 
            this.loginEmail_Input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginEmail_Input.Location = new System.Drawing.Point(109, 47);
            this.loginEmail_Input.MaxLength = 100;
            this.loginEmail_Input.Name = "loginEmail_Input";
            this.loginEmail_Input.Size = new System.Drawing.Size(155, 20);
            this.loginEmail_Input.TabIndex = 25;
            // 
            // loginValidation
            // 
            this.loginValidation.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginValidation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginValidation.Location = new System.Drawing.Point(11, 149);
            this.loginValidation.Name = "loginValidation";
            this.loginValidation.Size = new System.Drawing.Size(294, 31);
            this.loginValidation.TabIndex = 24;
            this.loginValidation.UseCompatibleStateImageBehavior = false;
            this.loginValidation.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label2.Location = new System.Drawing.Point(6, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 29);
            this.label2.TabIndex = 23;
            this.label2.Text = "Login";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.validationErrors);
            this.tabPage2.Controls.Add(this.submit);
            this.tabPage2.Controls.Add(this.name_input);
            this.tabPage2.Controls.Add(this.email_label);
            this.tabPage2.Controls.Add(this.password_input);
            this.tabPage2.Controls.Add(this.password_label);
            this.tabPage2.Controls.Add(this.confirmpassword_input);
            this.tabPage2.Controls.Add(this.confirmpassword_label);
            this.tabPage2.Controls.Add(this.email_input);
            this.tabPage2.Controls.Add(this.name_label);
            this.tabPage2.Controls.Add(this.cancel);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(311, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sign Up";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Sign Up";
            // 
            // validationErrors
            // 
            this.validationErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.validationErrors.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.validationErrors.Location = new System.Drawing.Point(8, 243);
            this.validationErrors.Name = "validationErrors";
            this.validationErrors.Size = new System.Drawing.Size(297, 26);
            this.validationErrors.TabIndex = 23;
            this.validationErrors.UseCompatibleStateImageBehavior = false;
            this.validationErrors.View = System.Windows.Forms.View.List;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(106, 214);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(77, 23);
            this.submit.TabIndex = 16;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // name_input
            // 
            this.name_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_input.Location = new System.Drawing.Point(105, 43);
            this.name_input.MaxLength = 100;
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(155, 20);
            this.name_input.TabIndex = 12;
            // 
            // email_label
            // 
            this.email_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_label.AutoSize = true;
            this.email_label.Location = new System.Drawing.Point(4, 89);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(32, 13);
            this.email_label.TabIndex = 20;
            this.email_label.Text = "Email";
            // 
            // password_input
            // 
            this.password_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_input.Location = new System.Drawing.Point(105, 125);
            this.password_input.MaxLength = 20;
            this.password_input.Name = "password_input";
            this.password_input.PasswordChar = '*';
            this.password_input.Size = new System.Drawing.Size(155, 20);
            this.password_input.TabIndex = 14;
            // 
            // password_label
            // 
            this.password_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(4, 132);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 19;
            this.password_label.Text = "Password";
            // 
            // confirmpassword_input
            // 
            this.confirmpassword_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmpassword_input.Location = new System.Drawing.Point(105, 169);
            this.confirmpassword_input.MaxLength = 20;
            this.confirmpassword_input.Name = "confirmpassword_input";
            this.confirmpassword_input.PasswordChar = '*';
            this.confirmpassword_input.Size = new System.Drawing.Size(155, 20);
            this.confirmpassword_input.TabIndex = 15;
            // 
            // confirmpassword_label
            // 
            this.confirmpassword_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmpassword_label.AutoSize = true;
            this.confirmpassword_label.Location = new System.Drawing.Point(4, 176);
            this.confirmpassword_label.Name = "confirmpassword_label";
            this.confirmpassword_label.Size = new System.Drawing.Size(91, 13);
            this.confirmpassword_label.TabIndex = 18;
            this.confirmpassword_label.Text = "Confirm Password";
            // 
            // email_input
            // 
            this.email_input.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.email_input.Location = new System.Drawing.Point(105, 86);
            this.email_input.MaxLength = 100;
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(155, 20);
            this.email_input.TabIndex = 13;
            // 
            // name_label
            // 
            this.name_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(4, 45);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(35, 13);
            this.name_label.TabIndex = 21;
            this.name_label.Text = "Name";
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.Color.Black;
            this.cancel.Location = new System.Drawing.Point(188, 214);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(72, 23);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Clear Fields";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // LoginAndSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 453);
            this.Controls.Add(this.SignUp);
            this.Name = "LoginAndSignUp";
            this.Text = "STEM System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosing_Click);
            this.SignUp.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SignUp;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView validationErrors;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox confirmpassword_input;
        private System.Windows.Forms.Label confirmpassword_label;
        private System.Windows.Forms.TextBox email_input;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label loginEmail_label;
        private System.Windows.Forms.TextBox loginPassword_Input;
        private System.Windows.Forms.Label loginPassword_label;
        private System.Windows.Forms.TextBox loginEmail_Input;
        private System.Windows.Forms.ListView loginValidation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

