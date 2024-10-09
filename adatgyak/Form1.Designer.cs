
namespace adatgyak
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
            this.addB = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.prop1T = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.prop2T = new Guna.UI2.WinForms.Guna2TextBox();
            this.delB = new Guna.UI2.WinForms.Guna2Button();
            this.delAllB = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // addB
            // 
            this.addB.Animated = true;
            this.addB.AutoRoundedCorners = true;
            this.addB.BackColor = System.Drawing.Color.Transparent;
            this.addB.BorderRadius = 15;
            this.addB.BorderThickness = 2;
            this.addB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addB.ForeColor = System.Drawing.Color.White;
            this.addB.IndicateFocus = true;
            this.addB.Location = new System.Drawing.Point(356, 274);
            this.addB.Name = "addB";
            this.addB.Size = new System.Drawing.Size(180, 60);
            this.addB.TabIndex = 0;
            this.addB.Text = "Add";
            this.addB.UseTransparentBackground = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(304, 420);
            this.listBox1.TabIndex = 1;
            // 
            // prop1T
            // 
            this.prop1T.Animated = true;
            this.prop1T.AutoRoundedCorners = true;
            this.prop1T.BorderColor = System.Drawing.Color.Black;
            this.prop1T.BorderRadius = 15;
            this.prop1T.BorderThickness = 2;
            this.prop1T.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prop1T.DefaultText = "";
            this.prop1T.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prop1T.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prop1T.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prop1T.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prop1T.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prop1T.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prop1T.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prop1T.Location = new System.Drawing.Point(568, 29);
            this.prop1T.Name = "prop1T";
            this.prop1T.PasswordChar = '\0';
            this.prop1T.PlaceholderText = "Property 1";
            this.prop1T.SelectedText = "";
            this.prop1T.Size = new System.Drawing.Size(200, 36);
            this.prop1T.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(480, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Property 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(480, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Property 2";
            // 
            // prop2T
            // 
            this.prop2T.Animated = true;
            this.prop2T.AutoRoundedCorners = true;
            this.prop2T.BorderColor = System.Drawing.Color.Black;
            this.prop2T.BorderRadius = 15;
            this.prop2T.BorderThickness = 2;
            this.prop2T.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.prop2T.DefaultText = "";
            this.prop2T.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.prop2T.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.prop2T.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prop2T.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.prop2T.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prop2T.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.prop2T.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prop2T.Location = new System.Drawing.Point(568, 79);
            this.prop2T.Name = "prop2T";
            this.prop2T.PasswordChar = '\0';
            this.prop2T.PlaceholderText = "Property 2";
            this.prop2T.SelectedText = "";
            this.prop2T.Size = new System.Drawing.Size(200, 36);
            this.prop2T.TabIndex = 5;
            // 
            // delB
            // 
            this.delB.Animated = true;
            this.delB.AutoRoundedCorners = true;
            this.delB.BackColor = System.Drawing.Color.Transparent;
            this.delB.BorderRadius = 15;
            this.delB.BorderThickness = 2;
            this.delB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delB.ForeColor = System.Drawing.Color.White;
            this.delB.IndicateFocus = true;
            this.delB.Location = new System.Drawing.Point(588, 274);
            this.delB.Name = "delB";
            this.delB.Size = new System.Drawing.Size(180, 60);
            this.delB.TabIndex = 6;
            this.delB.Text = "Delete";
            this.delB.UseTransparentBackground = true;
            // 
            // delAllB
            // 
            this.delAllB.Animated = true;
            this.delAllB.AutoRoundedCorners = true;
            this.delAllB.BackColor = System.Drawing.Color.Transparent;
            this.delAllB.BorderRadius = 15;
            this.delAllB.BorderThickness = 2;
            this.delAllB.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delAllB.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delAllB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delAllB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delAllB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.delAllB.ForeColor = System.Drawing.Color.White;
            this.delAllB.IndicateFocus = true;
            this.delAllB.Location = new System.Drawing.Point(356, 366);
            this.delAllB.Name = "delAllB";
            this.delAllB.Size = new System.Drawing.Size(412, 60);
            this.delAllB.TabIndex = 7;
            this.delAllB.Text = "Delete All";
            this.delAllB.UseTransparentBackground = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.delAllB);
            this.Controls.Add(this.delB);
            this.Controls.Add(this.prop2T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prop1T);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.addB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button addB;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2TextBox prop1T;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox prop2T;
        private Guna.UI2.WinForms.Guna2Button delB;
        private Guna.UI2.WinForms.Guna2Button delAllB;
    }
}

