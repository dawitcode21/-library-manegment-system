namespace Data_structure_library_manegment_system
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernamebox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.loginbotton = new System.Windows.Forms.Button();
            this.cancelbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // usernamebox
            // 
            this.usernamebox.Location = new System.Drawing.Point(328, 172);
            this.usernamebox.Name = "usernamebox";
            this.usernamebox.Size = new System.Drawing.Size(166, 26);
            this.usernamebox.TabIndex = 2;
            // 
            // passwordbox
            // 
            this.passwordbox.Location = new System.Drawing.Point(328, 222);
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(166, 26);
            this.passwordbox.TabIndex = 3;
            // 
            // loginbotton
            // 
            this.loginbotton.Location = new System.Drawing.Point(341, 272);
            this.loginbotton.Name = "loginbotton";
            this.loginbotton.Size = new System.Drawing.Size(87, 29);
            this.loginbotton.TabIndex = 4;
            this.loginbotton.Text = "LOGIN";
            this.loginbotton.UseVisualStyleBackColor = true;
            this.loginbotton.Click += new System.EventHandler(this.loginbotton_Click);
            // 
            // cancelbutton
            // 
            this.cancelbutton.Location = new System.Drawing.Point(341, 317);
            this.cancelbutton.Name = "cancelbutton";
            this.cancelbutton.Size = new System.Drawing.Size(87, 29);
            this.cancelbutton.TabIndex = 5;
            this.cancelbutton.Text = "CANCEL";
            this.cancelbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancelbutton);
            this.Controls.Add(this.loginbotton);
            this.Controls.Add(this.passwordbox);
            this.Controls.Add(this.usernamebox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernamebox;
        private System.Windows.Forms.TextBox passwordbox;
        private System.Windows.Forms.Button loginbotton;
        private System.Windows.Forms.Button cancelbutton;
    }
}

