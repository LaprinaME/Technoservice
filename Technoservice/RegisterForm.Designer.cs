namespace Technoservice
{
    partial class RegisterForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.emplSnpTextBox = new System.Windows.Forms.TextBox();
            this.emplPhoneTextBox = new System.Windows.Forms.TextBox();
            this.emplLoginTextBox = new System.Windows.Forms.TextBox();
            this.emplPassTextBox = new System.Windows.Forms.TextBox();
            this.emplRoleTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(32, 282);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(75, 23);
            this.registerButton.TabIndex = 0;
            this.registerButton.Text = "button1";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // emplSnpTextBox
            // 
            this.emplSnpTextBox.Location = new System.Drawing.Point(32, 25);
            this.emplSnpTextBox.Name = "emplSnpTextBox";
            this.emplSnpTextBox.Size = new System.Drawing.Size(100, 22);
            this.emplSnpTextBox.TabIndex = 1;
            this.emplSnpTextBox.TextChanged += new System.EventHandler(this.emplSnpTextBox_TextChanged);
            // 
            // emplPhoneTextBox
            // 
            this.emplPhoneTextBox.Location = new System.Drawing.Point(32, 75);
            this.emplPhoneTextBox.Name = "emplPhoneTextBox";
            this.emplPhoneTextBox.Size = new System.Drawing.Size(100, 22);
            this.emplPhoneTextBox.TabIndex = 2;
            this.emplPhoneTextBox.TextChanged += new System.EventHandler(this.emplPhoneTextBox_TextChanged);
            // 
            // emplLoginTextBox
            // 
            this.emplLoginTextBox.Location = new System.Drawing.Point(32, 120);
            this.emplLoginTextBox.Name = "emplLoginTextBox";
            this.emplLoginTextBox.Size = new System.Drawing.Size(100, 22);
            this.emplLoginTextBox.TabIndex = 3;
            this.emplLoginTextBox.TextChanged += new System.EventHandler(this.emplLoginTextBox_TextChanged);
            // 
            // emplPassTextBox
            // 
            this.emplPassTextBox.Location = new System.Drawing.Point(32, 179);
            this.emplPassTextBox.Name = "emplPassTextBox";
            this.emplPassTextBox.Size = new System.Drawing.Size(100, 22);
            this.emplPassTextBox.TabIndex = 4;
            this.emplPassTextBox.TextChanged += new System.EventHandler(this.emplPassTextBox_TextChanged);
            // 
            // emplRoleTextBox
            // 
            this.emplRoleTextBox.Location = new System.Drawing.Point(32, 230);
            this.emplRoleTextBox.Name = "emplRoleTextBox";
            this.emplRoleTextBox.Size = new System.Drawing.Size(100, 22);
            this.emplRoleTextBox.TabIndex = 5;
            this.emplRoleTextBox.TextChanged += new System.EventHandler(this.emplRoleTextBox_TextChanged);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emplRoleTextBox);
            this.Controls.Add(this.emplPassTextBox);
            this.Controls.Add(this.emplLoginTextBox);
            this.Controls.Add(this.emplPhoneTextBox);
            this.Controls.Add(this.emplSnpTextBox);
            this.Controls.Add(this.registerButton);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox emplSnpTextBox;
        private System.Windows.Forms.TextBox emplPhoneTextBox;
        private System.Windows.Forms.TextBox emplLoginTextBox;
        private System.Windows.Forms.TextBox emplPassTextBox;
        private System.Windows.Forms.TextBox emplRoleTextBox;
    }
}