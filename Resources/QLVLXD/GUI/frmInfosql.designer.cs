namespace GUI_QLVLXD
{
    partial class frmInfosql
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
            this.btnOK = new System.Windows.Forms.Button();
            this.checkBoxLogin = new System.Windows.Forms.CheckBox();
            this.data = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.TextBox();
            this.use = new System.Windows.Forms.TextBox();
            this.Server = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rdBtnSuaCSDL = new System.Windows.Forms.RadioButton();
            this.rdBtnTaoCSDL = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(210, 224);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(84, 33);
            this.btnOK.TabIndex = 16;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxLogin
            // 
            this.checkBoxLogin.AutoSize = true;
            this.checkBoxLogin.Location = new System.Drawing.Point(210, 176);
            this.checkBoxLogin.Name = "checkBoxLogin";
            this.checkBoxLogin.Size = new System.Drawing.Size(173, 17);
            this.checkBoxLogin.TabIndex = 15;
            this.checkBoxLogin.Text = "Đăng nhập bằng user windows";
            this.checkBoxLogin.UseVisualStyleBackColor = true;
            this.checkBoxLogin.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // data
            // 
            this.data.Location = new System.Drawing.Point(302, 60);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(173, 20);
            this.data.TabIndex = 12;
            // 
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(302, 135);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(173, 20);
            this.pass.TabIndex = 14;
            // 
            // use
            // 
            this.use.Location = new System.Drawing.Point(302, 97);
            this.use.Name = "use";
            this.use.Size = new System.Drawing.Size(173, 20);
            this.use.TabIndex = 13;
            // 
            // Server
            // 
            this.Server.Location = new System.Drawing.Point(302, 22);
            this.Server.Name = "Server";
            this.Server.Size = new System.Drawing.Size(173, 20);
            this.Server.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(207, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Data Source";
            // 
            // rdBtnSuaCSDL
            // 
            this.rdBtnSuaCSDL.AutoSize = true;
            this.rdBtnSuaCSDL.Checked = true;
            this.rdBtnSuaCSDL.Location = new System.Drawing.Point(44, 36);
            this.rdBtnSuaCSDL.Name = "rdBtnSuaCSDL";
            this.rdBtnSuaCSDL.Size = new System.Drawing.Size(75, 17);
            this.rdBtnSuaCSDL.TabIndex = 17;
            this.rdBtnSuaCSDL.TabStop = true;
            this.rdBtnSuaCSDL.Text = "Sửa CSDL";
            this.rdBtnSuaCSDL.UseVisualStyleBackColor = true;
            this.rdBtnSuaCSDL.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rdBtnTaoCSDL
            // 
            this.rdBtnTaoCSDL.AutoSize = true;
            this.rdBtnTaoCSDL.Location = new System.Drawing.Point(44, 80);
            this.rdBtnTaoCSDL.Name = "rdBtnTaoCSDL";
            this.rdBtnTaoCSDL.Size = new System.Drawing.Size(94, 17);
            this.rdBtnTaoCSDL.TabIndex = 17;
            this.rdBtnTaoCSDL.Text = "Tạo mới CSDL";
            this.rdBtnTaoCSDL.UseVisualStyleBackColor = true;
            // 
            // frmInfosql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(508, 269);
            this.Controls.Add(this.rdBtnTaoCSDL);
            this.Controls.Add(this.rdBtnSuaCSDL);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.checkBoxLogin);
            this.Controls.Add(this.data);
            this.Controls.Add(this.pass);
            this.Controls.Add(this.use);
            this.Controls.Add(this.Server);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmInfosql";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cơ sở dữ  liệu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.CheckBox checkBoxLogin;
        private System.Windows.Forms.TextBox data;
        private System.Windows.Forms.TextBox pass;
        private System.Windows.Forms.TextBox use;
        private System.Windows.Forms.TextBox Server;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdBtnSuaCSDL;
        private System.Windows.Forms.RadioButton rdBtnTaoCSDL;
    }
}