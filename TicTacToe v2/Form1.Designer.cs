namespace TicTacToe
{
    partial class TicTacToe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetWinCountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.a1 = new System.Windows.Forms.Button();
            this.c3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.a3 = new System.Windows.Forms.Button();
            this.c2 = new System.Windows.Forms.Button();
            this.c1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b1 = new System.Windows.Forms.Button();
            this.a2 = new System.Windows.Forms.Button();
            this.draws = new System.Windows.Forms.Label();
            this.xWinsTotal = new System.Windows.Forms.Label();
            this.drawsTotal = new System.Windows.Forms.Label();
            this.oWinsTotal = new System.Windows.Forms.Label();
            this.textBoxP1 = new System.Windows.Forms.TextBox();
            this.textBoxP2 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(259, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetWinCountsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetWinCountsToolStripMenuItem
            // 
            this.resetWinCountsToolStripMenuItem.Name = "resetWinCountsToolStripMenuItem";
            this.resetWinCountsToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.resetWinCountsToolStripMenuItem.Text = "Full Reset";
            this.resetWinCountsToolStripMenuItem.Click += new System.EventHandler(this.resetWinCountsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // a1
            // 
            this.a1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a1.Location = new System.Drawing.Point(12, 27);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(75, 75);
            this.a1.TabIndex = 1;
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.buttonClick);
            this.a1.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.a1.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // c3
            // 
            this.c3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c3.Location = new System.Drawing.Point(174, 189);
            this.c3.Name = "c3";
            this.c3.Size = new System.Drawing.Size(75, 75);
            this.c3.TabIndex = 2;
            this.c3.UseVisualStyleBackColor = true;
            this.c3.Click += new System.EventHandler(this.buttonClick);
            this.c3.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.c3.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(174, 108);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(75, 75);
            this.b3.TabIndex = 3;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.buttonClick);
            this.b3.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.b3.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // a3
            // 
            this.a3.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a3.Location = new System.Drawing.Point(174, 27);
            this.a3.Name = "a3";
            this.a3.Size = new System.Drawing.Size(75, 75);
            this.a3.TabIndex = 4;
            this.a3.UseVisualStyleBackColor = true;
            this.a3.Click += new System.EventHandler(this.buttonClick);
            this.a3.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.a3.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // c2
            // 
            this.c2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c2.Location = new System.Drawing.Point(93, 189);
            this.c2.Name = "c2";
            this.c2.Size = new System.Drawing.Size(75, 75);
            this.c2.TabIndex = 5;
            this.c2.UseVisualStyleBackColor = true;
            this.c2.Click += new System.EventHandler(this.buttonClick);
            this.c2.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.c2.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // c1
            // 
            this.c1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1.Location = new System.Drawing.Point(12, 189);
            this.c1.Name = "c1";
            this.c1.Size = new System.Drawing.Size(75, 75);
            this.c1.TabIndex = 6;
            this.c1.UseVisualStyleBackColor = true;
            this.c1.Click += new System.EventHandler(this.buttonClick);
            this.c1.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.c1.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(93, 108);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(75, 75);
            this.b2.TabIndex = 7;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.buttonClick);
            this.b2.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.b2.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(12, 108);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(75, 75);
            this.b1.TabIndex = 8;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.buttonClick);
            this.b1.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.b1.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // a2
            // 
            this.a2.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.a2.Location = new System.Drawing.Point(93, 27);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(75, 75);
            this.a2.TabIndex = 9;
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.buttonClick);
            this.a2.MouseEnter += new System.EventHandler(this.mouseEnterButton);
            this.a2.MouseLeave += new System.EventHandler(this.mouseLeaveButton);
            // 
            // draws
            // 
            this.draws.AutoSize = true;
            this.draws.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draws.Location = new System.Drawing.Point(111, 273);
            this.draws.Name = "draws";
            this.draws.Size = new System.Drawing.Size(41, 15);
            this.draws.TabIndex = 12;
            this.draws.Text = "Draws";
            // 
            // xWinsTotal
            // 
            this.xWinsTotal.AutoSize = true;
            this.xWinsTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xWinsTotal.Location = new System.Drawing.Point(43, 294);
            this.xWinsTotal.Name = "xWinsTotal";
            this.xWinsTotal.Size = new System.Drawing.Size(17, 19);
            this.xWinsTotal.TabIndex = 13;
            this.xWinsTotal.Text = "0";
            // 
            // drawsTotal
            // 
            this.drawsTotal.AutoSize = true;
            this.drawsTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawsTotal.Location = new System.Drawing.Point(122, 294);
            this.drawsTotal.Name = "drawsTotal";
            this.drawsTotal.Size = new System.Drawing.Size(17, 19);
            this.drawsTotal.TabIndex = 14;
            this.drawsTotal.Text = "0";
            // 
            // oWinsTotal
            // 
            this.oWinsTotal.AutoSize = true;
            this.oWinsTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oWinsTotal.Location = new System.Drawing.Point(199, 294);
            this.oWinsTotal.Name = "oWinsTotal";
            this.oWinsTotal.Size = new System.Drawing.Size(17, 19);
            this.oWinsTotal.TabIndex = 15;
            this.oWinsTotal.Text = "0";
            // 
            // textBoxP1
            // 
            this.textBoxP1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP1.Location = new System.Drawing.Point(12, 270);
            this.textBoxP1.Name = "textBoxP1";
            this.textBoxP1.Size = new System.Drawing.Size(75, 23);
            this.textBoxP1.TabIndex = 16;
            this.textBoxP1.Text = "Player 1";
            this.textBoxP1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxP2
            // 
            this.textBoxP2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxP2.Location = new System.Drawing.Point(174, 270);
            this.textBoxP2.Name = "textBoxP2";
            this.textBoxP2.Size = new System.Drawing.Size(73, 23);
            this.textBoxP2.TabIndex = 17;
            this.textBoxP2.Text = "Player 2";
            this.textBoxP2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TicTacToe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 327);
            this.Controls.Add(this.textBoxP2);
            this.Controls.Add(this.textBoxP1);
            this.Controls.Add(this.oWinsTotal);
            this.Controls.Add(this.drawsTotal);
            this.Controls.Add(this.xWinsTotal);
            this.Controls.Add(this.draws);
            this.Controls.Add(this.a2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.c1);
            this.Controls.Add(this.c2);
            this.Controls.Add(this.a3);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.c3);
            this.Controls.Add(this.a1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "TicTacToe";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            //this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button a1;
        private System.Windows.Forms.Button c3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button a3;
        private System.Windows.Forms.Button c2;
        private System.Windows.Forms.Button c1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Label draws;
        private System.Windows.Forms.Label xWinsTotal;
        private System.Windows.Forms.Label drawsTotal;
        private System.Windows.Forms.Label oWinsTotal;
        private System.Windows.Forms.ToolStripMenuItem resetWinCountsToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxP1;
        private System.Windows.Forms.TextBox textBoxP2;
    }
}

