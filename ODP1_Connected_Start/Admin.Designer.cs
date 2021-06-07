
namespace SWE_project_gui
{
    partial class Admin_Form
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DepCheck = new System.Windows.Forms.CheckBox();
            this.Depandancies = new System.Windows.Forms.GroupBox();
            this.AddDep = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dep_Name = new System.Windows.Forms.TextBox();
            this.Dep_Age = new System.Windows.Forms.TextBox();
            this.SP__Name = new System.Windows.Forms.TextBox();
            this.Sub_Job = new System.Windows.Forms.TextBox();
            this.Sub_SSN = new System.Windows.Forms.TextBox();
            this.Sub_Address = new System.Windows.Forms.TextBox();
            this.Sub_Name = new System.Windows.Forms.TextBox();
            this.SP_ServiceProvided = new System.Windows.Forms.TextBox();
            this.SP_Address = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Sub_Age = new System.Windows.Forms.TextBox();
            this.Sub = new System.Windows.Forms.RadioButton();
            this.ServiceProvider = new System.Windows.Forms.RadioButton();
            this.TypeGroup = new System.Windows.Forms.GroupBox();
            this.SerProGroup = new System.Windows.Forms.GroupBox();
            this.SubGroup = new System.Windows.Forms.GroupBox();
            this.Depandancies.SuspendLayout();
            this.TypeGroup.SuspendLayout();
            this.SerProGroup.SuspendLayout();
            this.SubGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Service Provided";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "SSN";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(49, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Job";
            // 
            // DepCheck
            // 
            this.DepCheck.AutoSize = true;
            this.DepCheck.Location = new System.Drawing.Point(88, 170);
            this.DepCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DepCheck.Name = "DepCheck";
            this.DepCheck.Size = new System.Drawing.Size(121, 21);
            this.DepCheck.TabIndex = 14;
            this.DepCheck.Text = "Depandancies";
            this.DepCheck.UseVisualStyleBackColor = true;
            this.DepCheck.CheckedChanged += new System.EventHandler(this.DepCheck_CheckedChanged);
            // 
            // Depandancies
            // 
            this.Depandancies.Controls.Add(this.AddDep);
            this.Depandancies.Controls.Add(this.label9);
            this.Depandancies.Controls.Add(this.label8);
            this.Depandancies.Controls.Add(this.Dep_Name);
            this.Depandancies.Controls.Add(this.Dep_Age);
            this.Depandancies.Location = new System.Drawing.Point(388, 289);
            this.Depandancies.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Depandancies.Name = "Depandancies";
            this.Depandancies.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Depandancies.Size = new System.Drawing.Size(380, 143);
            this.Depandancies.TabIndex = 15;
            this.Depandancies.TabStop = false;
            this.Depandancies.Text = "Depandancies";
            this.Depandancies.Visible = false;
            // 
            // AddDep
            // 
            this.AddDep.Location = new System.Drawing.Point(88, 102);
            this.AddDep.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddDep.Name = "AddDep";
            this.AddDep.Size = new System.Drawing.Size(186, 23);
            this.AddDep.TabIndex = 19;
            this.AddDep.Text = "Add Depandancy";
            this.AddDep.UseVisualStyleBackColor = true;
            this.AddDep.Click += new System.EventHandler(this.AddDep_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Age";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Name";
            // 
            // Dep_Name
            // 
            this.Dep_Name.AcceptsReturn = true;
            this.Dep_Name.Location = new System.Drawing.Point(88, 25);
            this.Dep_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dep_Name.Name = "Dep_Name";
            this.Dep_Name.Size = new System.Drawing.Size(210, 22);
            this.Dep_Name.TabIndex = 18;
            // 
            // Dep_Age
            // 
            this.Dep_Age.Location = new System.Drawing.Point(88, 61);
            this.Dep_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dep_Age.Name = "Dep_Age";
            this.Dep_Age.Size = new System.Drawing.Size(210, 22);
            this.Dep_Age.TabIndex = 17;
            // 
            // SP__Name
            // 
            this.SP__Name.Location = new System.Drawing.Point(142, 43);
            this.SP__Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SP__Name.Name = "SP__Name";
            this.SP__Name.Size = new System.Drawing.Size(210, 22);
            this.SP__Name.TabIndex = 16;
            // 
            // Sub_Job
            // 
            this.Sub_Job.Location = new System.Drawing.Point(88, 143);
            this.Sub_Job.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub_Job.Name = "Sub_Job";
            this.Sub_Job.Size = new System.Drawing.Size(210, 22);
            this.Sub_Job.TabIndex = 19;
            // 
            // Sub_SSN
            // 
            this.Sub_SSN.Location = new System.Drawing.Point(88, 114);
            this.Sub_SSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub_SSN.Name = "Sub_SSN";
            this.Sub_SSN.Size = new System.Drawing.Size(210, 22);
            this.Sub_SSN.TabIndex = 20;
            // 
            // Sub_Address
            // 
            this.Sub_Address.Location = new System.Drawing.Point(88, 62);
            this.Sub_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub_Address.Name = "Sub_Address";
            this.Sub_Address.Size = new System.Drawing.Size(210, 22);
            this.Sub_Address.TabIndex = 21;
            // 
            // Sub_Name
            // 
            this.Sub_Name.Location = new System.Drawing.Point(88, 30);
            this.Sub_Name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub_Name.Name = "Sub_Name";
            this.Sub_Name.Size = new System.Drawing.Size(210, 22);
            this.Sub_Name.TabIndex = 22;
            // 
            // SP_ServiceProvided
            // 
            this.SP_ServiceProvided.Location = new System.Drawing.Point(142, 107);
            this.SP_ServiceProvided.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SP_ServiceProvided.Name = "SP_ServiceProvided";
            this.SP_ServiceProvided.Size = new System.Drawing.Size(210, 22);
            this.SP_ServiceProvided.TabIndex = 23;
            // 
            // SP_Address
            // 
            this.SP_Address.Location = new System.Drawing.Point(142, 75);
            this.SP_Address.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SP_Address.Name = "SP_Address";
            this.SP_Address.Size = new System.Drawing.Size(210, 22);
            this.SP_Address.TabIndex = 24;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(261, 445);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(186, 23);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "Age";
            // 
            // Sub_Age
            // 
            this.Sub_Age.Location = new System.Drawing.Point(88, 88);
            this.Sub_Age.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub_Age.Name = "Sub_Age";
            this.Sub_Age.Size = new System.Drawing.Size(45, 22);
            this.Sub_Age.TabIndex = 26;
            // 
            // Sub
            // 
            this.Sub.AutoSize = true;
            this.Sub.Location = new System.Drawing.Point(397, 41);
            this.Sub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Sub.Name = "Sub";
            this.Sub.Size = new System.Drawing.Size(97, 21);
            this.Sub.TabIndex = 7;
            this.Sub.TabStop = true;
            this.Sub.Text = "Subscriber";
            this.Sub.UseVisualStyleBackColor = true;
            this.Sub.CheckedChanged += new System.EventHandler(this.Sub_CheckedChanged);
            // 
            // ServiceProvider
            // 
            this.ServiceProvider.AutoSize = true;
            this.ServiceProvider.Location = new System.Drawing.Point(53, 41);
            this.ServiceProvider.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ServiceProvider.Name = "ServiceProvider";
            this.ServiceProvider.Size = new System.Drawing.Size(133, 21);
            this.ServiceProvider.TabIndex = 6;
            this.ServiceProvider.TabStop = true;
            this.ServiceProvider.Text = "Service Provider";
            this.ServiceProvider.UseVisualStyleBackColor = true;
            this.ServiceProvider.CheckedChanged += new System.EventHandler(this.ServiceProvider_CheckedChanged);
            // 
            // TypeGroup
            // 
            this.TypeGroup.Controls.Add(this.ServiceProvider);
            this.TypeGroup.Controls.Add(this.Sub);
            this.TypeGroup.Location = new System.Drawing.Point(12, 11);
            this.TypeGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeGroup.Name = "TypeGroup";
            this.TypeGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeGroup.Size = new System.Drawing.Size(583, 74);
            this.TypeGroup.TabIndex = 8;
            this.TypeGroup.TabStop = false;
            this.TypeGroup.Text = "Type of Account";
            // 
            // SerProGroup
            // 
            this.SerProGroup.Controls.Add(this.SP_Address);
            this.SerProGroup.Controls.Add(this.label1);
            this.SerProGroup.Controls.Add(this.label2);
            this.SerProGroup.Controls.Add(this.label3);
            this.SerProGroup.Controls.Add(this.SP__Name);
            this.SerProGroup.Controls.Add(this.SP_ServiceProvided);
            this.SerProGroup.Location = new System.Drawing.Point(12, 98);
            this.SerProGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerProGroup.Name = "SerProGroup";
            this.SerProGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SerProGroup.Size = new System.Drawing.Size(358, 157);
            this.SerProGroup.TabIndex = 27;
            this.SerProGroup.TabStop = false;
            this.SerProGroup.Text = "Service Provide";
            // 
            // SubGroup
            // 
            this.SubGroup.Controls.Add(this.Sub_SSN);
            this.SubGroup.Controls.Add(this.label4);
            this.SubGroup.Controls.Add(this.Sub_Age);
            this.SubGroup.Controls.Add(this.label5);
            this.SubGroup.Controls.Add(this.label10);
            this.SubGroup.Controls.Add(this.label6);
            this.SubGroup.Controls.Add(this.label7);
            this.SubGroup.Controls.Add(this.Sub_Name);
            this.SubGroup.Controls.Add(this.DepCheck);
            this.SubGroup.Controls.Add(this.Sub_Address);
            this.SubGroup.Controls.Add(this.Sub_Job);
            this.SubGroup.Location = new System.Drawing.Point(388, 98);
            this.SubGroup.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubGroup.Name = "SubGroup";
            this.SubGroup.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SubGroup.Size = new System.Drawing.Size(400, 193);
            this.SubGroup.TabIndex = 25;
            this.SubGroup.TabStop = false;
            this.SubGroup.Text = "Subcriber";
            // 
            // Admin_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.SubGroup);
            this.Controls.Add(this.SerProGroup);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Depandancies);
            this.Controls.Add(this.TypeGroup);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Admin_Form";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_Form_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Form_Load);
            this.Depandancies.ResumeLayout(false);
            this.Depandancies.PerformLayout();
            this.TypeGroup.ResumeLayout(false);
            this.TypeGroup.PerformLayout();
            this.SerProGroup.ResumeLayout(false);
            this.SerProGroup.PerformLayout();
            this.SubGroup.ResumeLayout(false);
            this.SubGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox DepCheck;
        private System.Windows.Forms.GroupBox Depandancies;
        private System.Windows.Forms.Button AddDep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Dep_Name;
        private System.Windows.Forms.TextBox Dep_Age;
        private System.Windows.Forms.TextBox SP__Name;
        private System.Windows.Forms.TextBox Sub_Job;
        private System.Windows.Forms.TextBox Sub_SSN;
        private System.Windows.Forms.TextBox Sub_Address;
        private System.Windows.Forms.TextBox Sub_Name;
        private System.Windows.Forms.TextBox SP_ServiceProvided;
        private System.Windows.Forms.TextBox SP_Address;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Sub_Age;
        private System.Windows.Forms.RadioButton Sub;
        private System.Windows.Forms.RadioButton ServiceProvider;
        private System.Windows.Forms.GroupBox TypeGroup;
        private System.Windows.Forms.GroupBox SerProGroup;
        private System.Windows.Forms.GroupBox SubGroup;
    }
}