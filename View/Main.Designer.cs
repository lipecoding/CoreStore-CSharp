namespace CoreStore_CSharp.View
{
    partial class Main
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
            this.btnpnl = new MetroFramework.Controls.MetroPanel();
            this.miscbtn = new MetroFramework.Controls.MetroButton();
            this.providerbtn = new MetroFramework.Controls.MetroButton();
            this.productbtn = new MetroFramework.Controls.MetroButton();
            this.userbtn = new MetroFramework.Controls.MetroButton();
            this.mainpnl = new MetroFramework.Controls.MetroPanel();
            this.closebtn = new MetroFramework.Controls.MetroButton();
            this.btnpnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnpnl
            // 
            this.btnpnl.Controls.Add(this.miscbtn);
            this.btnpnl.Controls.Add(this.providerbtn);
            this.btnpnl.Controls.Add(this.productbtn);
            this.btnpnl.Controls.Add(this.userbtn);
            this.btnpnl.HorizontalScrollbarBarColor = true;
            this.btnpnl.HorizontalScrollbarHighlightOnWheel = false;
            this.btnpnl.HorizontalScrollbarSize = 10;
            this.btnpnl.Location = new System.Drawing.Point(26, 75);
            this.btnpnl.Name = "btnpnl";
            this.btnpnl.Size = new System.Drawing.Size(948, 52);
            this.btnpnl.Style = MetroFramework.MetroColorStyle.Purple;
            this.btnpnl.TabIndex = 0;
            this.btnpnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnpnl.VerticalScrollbarBarColor = true;
            this.btnpnl.VerticalScrollbarHighlightOnWheel = false;
            this.btnpnl.VerticalScrollbarSize = 10;
            // 
            // miscbtn
            // 
            this.miscbtn.Location = new System.Drawing.Point(711, 0);
            this.miscbtn.Name = "miscbtn";
            this.miscbtn.Size = new System.Drawing.Size(237, 52);
            this.miscbtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.miscbtn.TabIndex = 10;
            this.miscbtn.Text = "Misc";
            this.miscbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.miscbtn.Click += new System.EventHandler(this.miscbtn_Click);
            // 
            // providerbtn
            // 
            this.providerbtn.Location = new System.Drawing.Point(474, 0);
            this.providerbtn.Name = "providerbtn";
            this.providerbtn.Size = new System.Drawing.Size(237, 52);
            this.providerbtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.providerbtn.TabIndex = 9;
            this.providerbtn.Text = "Providers";
            this.providerbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.providerbtn.Click += new System.EventHandler(this.providerbtn_Click);
            // 
            // productbtn
            // 
            this.productbtn.Location = new System.Drawing.Point(237, 0);
            this.productbtn.Name = "productbtn";
            this.productbtn.Size = new System.Drawing.Size(237, 52);
            this.productbtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.productbtn.TabIndex = 11;
            this.productbtn.Text = "Products";
            this.productbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.productbtn.Click += new System.EventHandler(this.productbtn_Click);
            // 
            // userbtn
            // 
            this.userbtn.Location = new System.Drawing.Point(0, 0);
            this.userbtn.Name = "userbtn";
            this.userbtn.Size = new System.Drawing.Size(237, 52);
            this.userbtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.userbtn.TabIndex = 8;
            this.userbtn.Text = "User";
            this.userbtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.userbtn.Click += new System.EventHandler(this.userbtn_Click);
            // 
            // mainpnl
            // 
            this.mainpnl.HorizontalScrollbarBarColor = true;
            this.mainpnl.HorizontalScrollbarHighlightOnWheel = false;
            this.mainpnl.HorizontalScrollbarSize = 10;
            this.mainpnl.Location = new System.Drawing.Point(26, 133);
            this.mainpnl.Name = "mainpnl";
            this.mainpnl.Size = new System.Drawing.Size(948, 440);
            this.mainpnl.Style = MetroFramework.MetroColorStyle.Purple;
            this.mainpnl.TabIndex = 2;
            this.mainpnl.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.mainpnl.VerticalScrollbarBarColor = true;
            this.mainpnl.VerticalScrollbarHighlightOnWheel = false;
            this.mainpnl.VerticalScrollbarSize = 10;
            // 
            // closebtn
            // 
            this.closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebtn.Location = new System.Drawing.Point(978, 14);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(18, 20);
            this.closebtn.Style = MetroFramework.MetroColorStyle.Purple;
            this.closebtn.TabIndex = 3;
            this.closebtn.Text = "X";
            this.closebtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.ControlBox = false;
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.mainpnl);
            this.Controls.Add(this.btnpnl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749998F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(23, 72, 23, 24);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "CoreStore | Products";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.btnpnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel btnpnl;
        private MetroFramework.Controls.MetroButton miscbtn;
        private MetroFramework.Controls.MetroButton providerbtn;
        private MetroFramework.Controls.MetroButton userbtn;
        private MetroFramework.Controls.MetroPanel mainpnl;
        private MetroFramework.Controls.MetroButton productbtn;
        private MetroFramework.Controls.MetroButton closebtn;
    }
}