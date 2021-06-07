
namespace SWE_project_gui
{
    partial class landingPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.type_gp = new System.Windows.Forms.GroupBox();
            this.subsc_rb = new System.Windows.Forms.RadioButton();
            this.sp_rb = new System.Windows.Forms.RadioButton();
            this.login_btn = new System.Windows.Forms.Button();
            this.type_gp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Insurance Company Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Password";
            // 
            // name_txt
            // 
            this.name_txt.Location = new System.Drawing.Point(191, 150);
            this.name_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(329, 22);
            this.name_txt.TabIndex = 4;
            this.name_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(192, 220);
            this.password_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(328, 22);
            this.password_txt.TabIndex = 5;
            // 
            // type_gp
            // 
            this.type_gp.Controls.Add(this.subsc_rb);
            this.type_gp.Controls.Add(this.sp_rb);
            this.type_gp.Location = new System.Drawing.Point(188, 258);
            this.type_gp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_gp.Name = "type_gp";
            this.type_gp.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_gp.Size = new System.Drawing.Size(349, 56);
            this.type_gp.TabIndex = 16;
            this.type_gp.TabStop = false;
            this.type_gp.Text = "Type";
            // 
            // subsc_rb
            // 
            this.subsc_rb.AutoSize = true;
            this.subsc_rb.Location = new System.Drawing.Point(185, 22);
            this.subsc_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.subsc_rb.Name = "subsc_rb";
            this.subsc_rb.Size = new System.Drawing.Size(97, 21);
            this.subsc_rb.TabIndex = 1;
            this.subsc_rb.TabStop = true;
            this.subsc_rb.Text = "Subscriber";
            this.subsc_rb.UseVisualStyleBackColor = true;
            this.subsc_rb.CheckedChanged += new System.EventHandler(this.subsc_rb_CheckedChanged);
            // 
            // sp_rb
            // 
            this.sp_rb.AutoSize = true;
            this.sp_rb.Location = new System.Drawing.Point(23, 22);
            this.sp_rb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sp_rb.Name = "sp_rb";
            this.sp_rb.Size = new System.Drawing.Size(133, 21);
            this.sp_rb.TabIndex = 0;
            this.sp_rb.TabStop = true;
            this.sp_rb.Text = "Service Provider";
            this.sp_rb.UseVisualStyleBackColor = true;
            // 
            // login_btn
            // 
            this.login_btn.Location = new System.Drawing.Point(188, 350);
            this.login_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(94, 23);
            this.login_btn.TabIndex = 18;
            this.login_btn.Text = "Log in";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // landingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 406);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.type_gp);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "landingPage";
            this.Text = "Registration Window";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.landingPage_FormClosing);
            this.Load += new System.EventHandler(this.landingPage_Load);
            this.type_gp.ResumeLayout(false);
            this.type_gp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.GroupBox type_gp;
        private System.Windows.Forms.RadioButton subsc_rb;
        private System.Windows.Forms.RadioButton sp_rb;
        private System.Windows.Forms.Button login_btn;
    }
}

