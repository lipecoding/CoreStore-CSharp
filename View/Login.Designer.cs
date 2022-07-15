namespace CoreStore_CSharp.View
{
    partial class Login
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
            this.loginpnl = new MetroFramework.Controls.MetroPanel();
            this.loginbtn = new MetroFramework.Controls.MetroButton();
            this.passlbl = new MetroFramework.Controls.MetroLabel();
            this.userlbl = new MetroFramework.Controls.MetroLabel();
            this.passtxt = new System.Windows.Forms.TextBox();
            this.usertxt = new System.Windows.Forms.TextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.loginpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginpnl
            // 
            this.loginpnl.Controls.Add(this.loginbtn);
            this.loginpnl.Controls.Add(this.passlbl);
            this.loginpnl.Controls.Add(this.userlbl);
            this.loginpnl.Controls.Add(this.passtxt);
            this.loginpnl.Controls.Add(this.usertxt);
            this.loginpnl.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.loginpnl.HorizontalScrollbarBarColor = true;
            this.loginpnl.HorizontalScrollbarHighlightOnWheel = false;
            this.loginpnl.HorizontalScrollbarSize = 11;
            this.loginpnl.Location = new System.Drawing.Point(23, 71);
            this.loginpnl.Name = "loginpnl";
            this.loginpnl.Size = new System.Drawing.Size(219, 216);
            this.loginpnl.Style = MetroFramework.MetroColorStyle.Purple;
            this.loginpnl.TabIndex = 0;
            this.loginpnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginpnl.VerticalScrollbarBarColor = true;
            this.loginpnl.VerticalScrollbarHighlightOnWheel = false;
            this.loginpnl.VerticalScrollbarSize = 10;
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(67, 161);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(65, 28);
            this.loginbtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.loginbtn.TabIndex = 6;
            this.loginbtn.Text = "Sign In";
            this.loginbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.passlbl.Location = new System.Drawing.Point(67, 91);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(67, 19);
            this.passlbl.Style = MetroFramework.MetroColorStyle.Purple;
            this.passlbl.TabIndex = 5;
            this.passlbl.Text = "Password";
            this.passlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.userlbl.Location = new System.Drawing.Point(67, 19);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(71, 19);
            this.userlbl.Style = MetroFramework.MetroColorStyle.Purple;
            this.userlbl.TabIndex = 4;
            this.userlbl.Text = "Username";
            this.userlbl.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // passtxt
            // 
            this.passtxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.passtxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passtxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.passtxt.Location = new System.Drawing.Point(26, 116);
            this.passtxt.Name = "passtxt";
            this.passtxt.PasswordChar = '●';
            this.passtxt.Size = new System.Drawing.Size(160, 17);
            this.passtxt.TabIndex = 3;
            // 
            // usertxt
            // 
            this.usertxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.usertxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usertxt.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.usertxt.Location = new System.Drawing.Point(26, 44);
            this.usertxt.Name = "usertxt";
            this.usertxt.Size = new System.Drawing.Size(160, 17);
            this.usertxt.TabIndex = 2;
            // 
            // metroButton1
            // 
            this.metroButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.metroButton1.Location = new System.Drawing.Point(244, 11);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(18, 20);
            this.metroButton1.Style = MetroFramework.MetroColorStyle.Purple;
            this.metroButton1.TabIndex = 1;
            this.metroButton1.Text = "X";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.loginbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 314);
            this.ControlBox = false;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.loginpnl);
            this.Font = new System.Drawing.Font("Nunito SemiBold", 8.999998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(20, 68, 20, 23);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "CoreStore | Login";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.loginpnl.ResumeLayout(false);
            this.loginpnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel loginpnl;
        private MetroFramework.Controls.MetroButton loginbtn;
        private MetroFramework.Controls.MetroLabel passlbl;
        private MetroFramework.Controls.MetroLabel userlbl;
        private TextBox passtxt;
        private TextBox usertxt;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}