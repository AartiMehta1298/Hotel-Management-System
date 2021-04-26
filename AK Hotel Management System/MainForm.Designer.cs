
namespace AK_Hotel_Management_System
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.roomButton5 = new Guna.UI2.WinForms.Guna2Button();
            this.reservation2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.staffButton3 = new Guna.UI2.WinForms.Guna2Button();
            this.clintButton2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(775, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "x";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 79);
            this.panel1.TabIndex = 7;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Sitka Display", 27F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 8);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(468, 54);
            this.guna2HtmlLabel1.TabIndex = 10;
            this.guna2HtmlLabel1.Text = "AK Hotel Management System ";
            // 
            // guna2Button1
            // 
            this.guna2Button1.AutoRoundedCorners = true;
            this.guna2Button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("guna2Button1.BackgroundImage")));
            this.guna2Button1.BorderRadius = 17;
            this.guna2Button1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.White;
            this.guna2Button1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(671, 35);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(81, 37);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Logout";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.roomButton5);
            this.panel2.Controls.Add(this.reservation2Button4);
            this.panel2.Controls.Add(this.staffButton3);
            this.panel2.Controls.Add(this.clintButton2);
            this.panel2.Location = new System.Drawing.Point(0, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 438);
            this.panel2.TabIndex = 8;
            // 
            // roomButton5
            // 
            this.roomButton5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("roomButton5.BackgroundImage")));
            this.roomButton5.BorderRadius = 20;
            this.roomButton5.BorderThickness = 1;
            this.roomButton5.CheckedState.Parent = this.roomButton5;
            this.roomButton5.CustomImages.Parent = this.roomButton5;
            this.roomButton5.FillColor = System.Drawing.Color.White;
            this.roomButton5.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.roomButton5.ForeColor = System.Drawing.Color.Teal;
            this.roomButton5.HoverState.Parent = this.roomButton5;
            this.roomButton5.Location = new System.Drawing.Point(45, 178);
            this.roomButton5.Name = "roomButton5";
            this.roomButton5.ShadowDecoration.Parent = this.roomButton5;
            this.roomButton5.Size = new System.Drawing.Size(169, 37);
            this.roomButton5.TabIndex = 3;
            this.roomButton5.Text = "Room";
            this.roomButton5.Click += new System.EventHandler(this.roomButton5_Click);
            // 
            // reservation2Button4
            // 
            this.reservation2Button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reservation2Button4.BackgroundImage")));
            this.reservation2Button4.BorderRadius = 20;
            this.reservation2Button4.BorderThickness = 1;
            this.reservation2Button4.CheckedState.Parent = this.reservation2Button4;
            this.reservation2Button4.CustomImages.Parent = this.reservation2Button4;
            this.reservation2Button4.FillColor = System.Drawing.Color.White;
            this.reservation2Button4.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.reservation2Button4.ForeColor = System.Drawing.Color.Teal;
            this.reservation2Button4.HoverState.Parent = this.reservation2Button4;
            this.reservation2Button4.Location = new System.Drawing.Point(45, 250);
            this.reservation2Button4.Name = "reservation2Button4";
            this.reservation2Button4.ShadowDecoration.Parent = this.reservation2Button4;
            this.reservation2Button4.Size = new System.Drawing.Size(169, 37);
            this.reservation2Button4.TabIndex = 2;
            this.reservation2Button4.Text = "Reservation";
            this.reservation2Button4.Click += new System.EventHandler(this.reservation2Button4_Click);
            // 
            // staffButton3
            // 
            this.staffButton3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("staffButton3.BackgroundImage")));
            this.staffButton3.BorderRadius = 20;
            this.staffButton3.BorderThickness = 1;
            this.staffButton3.CheckedState.Parent = this.staffButton3;
            this.staffButton3.CustomImages.Parent = this.staffButton3;
            this.staffButton3.FillColor = System.Drawing.Color.White;
            this.staffButton3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.staffButton3.ForeColor = System.Drawing.Color.Teal;
            this.staffButton3.HoverState.Parent = this.staffButton3;
            this.staffButton3.Location = new System.Drawing.Point(45, 109);
            this.staffButton3.Name = "staffButton3";
            this.staffButton3.ShadowDecoration.Parent = this.staffButton3;
            this.staffButton3.Size = new System.Drawing.Size(169, 37);
            this.staffButton3.TabIndex = 1;
            this.staffButton3.Text = "Staff";
            this.staffButton3.Click += new System.EventHandler(this.staffButton3_Click);
            // 
            // clintButton2
            // 
            this.clintButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("clintButton2.BackgroundImage")));
            this.clintButton2.BorderRadius = 20;
            this.clintButton2.BorderThickness = 1;
            this.clintButton2.CheckedState.Parent = this.clintButton2;
            this.clintButton2.CustomImages.Parent = this.clintButton2;
            this.clintButton2.FillColor = System.Drawing.Color.White;
            this.clintButton2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold);
            this.clintButton2.ForeColor = System.Drawing.Color.Teal;
            this.clintButton2.HoverState.Parent = this.clintButton2;
            this.clintButton2.Location = new System.Drawing.Point(45, 42);
            this.clintButton2.Name = "clintButton2";
            this.clintButton2.ShadowDecoration.Parent = this.clintButton2;
            this.clintButton2.Size = new System.Drawing.Size(169, 37);
            this.clintButton2.TabIndex = 0;
            this.clintButton2.Text = "Client";
            this.clintButton2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageFlip = Guna.UI2.WinForms.Enums.FlipOrientation.Horizontal;
            this.guna2PictureBox1.Location = new System.Drawing.Point(265, 85);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(533, 429);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 9;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Copyright @ 2021. All rights reserved  C# My Design";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(810, 524);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button roomButton5;
        private Guna.UI2.WinForms.Guna2Button reservation2Button4;
        private Guna.UI2.WinForms.Guna2Button staffButton3;
        private Guna.UI2.WinForms.Guna2Button clintButton2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}