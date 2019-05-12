namespace BCalc
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
            this.RdoAnd = new System.Windows.Forms.RadioButton();
            this.RdoOr = new System.Windows.Forms.RadioButton();
            this.RdoXor = new System.Windows.Forms.RadioButton();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RdoDiv = new System.Windows.Forms.RadioButton();
            this.RdoMult = new System.Windows.Forms.RadioButton();
            this.RdoMinus = new System.Windows.Forms.RadioButton();
            this.RdoPlus = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.FileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditClearAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BitSettingControl3 = new BCalc.BitSettingControl();
            this.BitSettingControl2 = new BCalc.BitSettingControl();
            this.BitSettingControl1 = new BCalc.BitSettingControl();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RdoAnd
            // 
            this.RdoAnd.AutoSize = true;
            this.RdoAnd.Checked = true;
            this.RdoAnd.Location = new System.Drawing.Point(3, 6);
            this.RdoAnd.Name = "RdoAnd";
            this.RdoAnd.Size = new System.Drawing.Size(46, 19);
            this.RdoAnd.TabIndex = 2;
            this.RdoAnd.TabStop = true;
            this.RdoAnd.Text = "and";
            this.RdoAnd.UseVisualStyleBackColor = true;
            // 
            // RdoOr
            // 
            this.RdoOr.AutoSize = true;
            this.RdoOr.Location = new System.Drawing.Point(55, 6);
            this.RdoOr.Name = "RdoOr";
            this.RdoOr.Size = new System.Drawing.Size(36, 19);
            this.RdoOr.TabIndex = 3;
            this.RdoOr.Text = "or";
            this.RdoOr.UseVisualStyleBackColor = true;
            // 
            // RdoXor
            // 
            this.RdoXor.AutoSize = true;
            this.RdoXor.Location = new System.Drawing.Point(97, 6);
            this.RdoXor.Name = "RdoXor";
            this.RdoXor.Size = new System.Drawing.Size(41, 19);
            this.RdoXor.TabIndex = 4;
            this.RdoXor.Text = "xor";
            this.RdoXor.UseVisualStyleBackColor = true;
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(287, 3);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(87, 24);
            this.BtnCalculate.TabIndex = 6;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RdoDiv);
            this.panel1.Controls.Add(this.RdoMult);
            this.panel1.Controls.Add(this.RdoMinus);
            this.panel1.Controls.Add(this.RdoPlus);
            this.panel1.Controls.Add(this.RdoOr);
            this.panel1.Controls.Add(this.BtnCalculate);
            this.panel1.Controls.Add(this.RdoAnd);
            this.panel1.Controls.Add(this.RdoXor);
            this.panel1.Location = new System.Drawing.Point(511, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 32);
            this.panel1.TabIndex = 7;
            // 
            // RdoDiv
            // 
            this.RdoDiv.AutoSize = true;
            this.RdoDiv.Location = new System.Drawing.Point(253, 6);
            this.RdoDiv.Name = "RdoDiv";
            this.RdoDiv.Size = new System.Drawing.Size(28, 19);
            this.RdoDiv.TabIndex = 10;
            this.RdoDiv.Text = "/";
            this.RdoDiv.UseVisualStyleBackColor = true;
            // 
            // RdoMult
            // 
            this.RdoMult.AutoSize = true;
            this.RdoMult.Location = new System.Drawing.Point(217, 6);
            this.RdoMult.Name = "RdoMult";
            this.RdoMult.Size = new System.Drawing.Size(30, 19);
            this.RdoMult.TabIndex = 9;
            this.RdoMult.Text = "*";
            this.RdoMult.UseVisualStyleBackColor = true;
            // 
            // RdoMinus
            // 
            this.RdoMinus.AutoSize = true;
            this.RdoMinus.Location = new System.Drawing.Point(182, 6);
            this.RdoMinus.Name = "RdoMinus";
            this.RdoMinus.Size = new System.Drawing.Size(29, 19);
            this.RdoMinus.TabIndex = 8;
            this.RdoMinus.Text = "-";
            this.RdoMinus.UseVisualStyleBackColor = true;
            // 
            // RdoPlus
            // 
            this.RdoPlus.AutoSize = true;
            this.RdoPlus.Location = new System.Drawing.Point(144, 6);
            this.RdoPlus.Name = "RdoPlus";
            this.RdoPlus.Size = new System.Drawing.Size(32, 19);
            this.RdoPlus.TabIndex = 7;
            this.RdoPlus.Text = "+";
            this.RdoPlus.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileToolStripMenuItem,
            this.EditToolStripMenuItem,
            this.HelpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(904, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // FileToolStripMenuItem
            // 
            this.FileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExitMenuItem});
            this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
            this.FileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.FileToolStripMenuItem.Text = "&File";
            // 
            // FileExitMenuItem
            // 
            this.FileExitMenuItem.Name = "FileExitMenuItem";
            this.FileExitMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.FileExitMenuItem.Size = new System.Drawing.Size(134, 22);
            this.FileExitMenuItem.Text = "E&xit";
            this.FileExitMenuItem.Click += new System.EventHandler(this.FileExitMenuItem_Click);
            // 
            // EditToolStripMenuItem
            // 
            this.EditToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.EditClearAllMenuItem});
            this.EditToolStripMenuItem.Name = "EditToolStripMenuItem";
            this.EditToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.EditToolStripMenuItem.Text = "&Edit";
            // 
            // EditClearAllMenuItem
            // 
            this.EditClearAllMenuItem.Name = "EditClearAllMenuItem";
            this.EditClearAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.EditClearAllMenuItem.Size = new System.Drawing.Size(156, 22);
            this.EditClearAllMenuItem.Text = "C&lear All";
            this.EditClearAllMenuItem.Click += new System.EventHandler(this.EditClearAllMenuItem_Click);
            // 
            // HelpToolStripMenuItem
            // 
            this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAboutMenuItem});
            this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
            this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpToolStripMenuItem.Text = "&Help";
            // 
            // HelpAboutMenuItem
            // 
            this.HelpAboutMenuItem.Name = "HelpAboutMenuItem";
            this.HelpAboutMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.HelpAboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.HelpAboutMenuItem.Text = "&About";
            this.HelpAboutMenuItem.Click += new System.EventHandler(this.HelpAboutMenuItem_Click);
            // 
            // BitSettingControl3
            // 
            this.BitSettingControl3.DecNumber = 0;
            this.BitSettingControl3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitSettingControl3.Location = new System.Drawing.Point(0, 230);
            this.BitSettingControl3.Name = "BitSettingControl3";
            this.BitSettingControl3.Size = new System.Drawing.Size(909, 80);
            this.BitSettingControl3.TabIndex = 5;
            // 
            // BitSettingControl2
            // 
            this.BitSettingControl2.DecNumber = 0;
            this.BitSettingControl2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitSettingControl2.Location = new System.Drawing.Point(0, 106);
            this.BitSettingControl2.Name = "BitSettingControl2";
            this.BitSettingControl2.Size = new System.Drawing.Size(909, 80);
            this.BitSettingControl2.TabIndex = 1;
            // 
            // BitSettingControl1
            // 
            this.BitSettingControl1.DecNumber = 0;
            this.BitSettingControl1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitSettingControl1.Location = new System.Drawing.Point(0, 27);
            this.BitSettingControl1.Name = "BitSettingControl1";
            this.BitSettingControl1.Size = new System.Drawing.Size(909, 80);
            this.BitSettingControl1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 304);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BitSettingControl3);
            this.Controls.Add(this.BitSettingControl2);
            this.Controls.Add(this.BitSettingControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(920, 340);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BCalc";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BitSettingControl BitSettingControl1;
        private BitSettingControl BitSettingControl2;
        private System.Windows.Forms.RadioButton RdoAnd;
        private System.Windows.Forms.RadioButton RdoOr;
        private System.Windows.Forms.RadioButton RdoXor;
        private BitSettingControl BitSettingControl3;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem FileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FileExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditClearAllMenuItem;
        private System.Windows.Forms.RadioButton RdoDiv;
        private System.Windows.Forms.RadioButton RdoMult;
        private System.Windows.Forms.RadioButton RdoMinus;
        private System.Windows.Forms.RadioButton RdoPlus;
        private System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutMenuItem;
    }
}

