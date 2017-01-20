namespace Ksu.Cis300.TextEditor
{
    partial class UserInterface
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
            this.uxMenu = new System.Windows.Forms.MenuStrip();
            this.uxFileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.uxInputText = new System.Windows.Forms.TextBox();
            this.uxOpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.uxSaveDialog = new System.Windows.Forms.SaveFileDialog();
            this.uxOpen1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxSaveAs1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxMenu
            // 
            this.uxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxFileMenu});
            this.uxMenu.Location = new System.Drawing.Point(0, 0);
            this.uxMenu.Name = "uxMenu";
            this.uxMenu.Size = new System.Drawing.Size(385, 24);
            this.uxMenu.TabIndex = 0;
            this.uxMenu.Text = "menuStrip1";
            // 
            // uxFileMenu
            // 
            this.uxFileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uxOpen1,
            this.uxSaveAs1});
            this.uxFileMenu.Name = "uxFileMenu";
            this.uxFileMenu.Size = new System.Drawing.Size(37, 20);
            this.uxFileMenu.Text = "File";
            // 
            // uxInputText
            // 
            this.uxInputText.Location = new System.Drawing.Point(12, 27);
            this.uxInputText.Multiline = true;
            this.uxInputText.Name = "uxInputText";
            this.uxInputText.Size = new System.Drawing.Size(361, 186);
            this.uxInputText.TabIndex = 1;
            // 
            // uxOpen1
            // 
            this.uxOpen1.Name = "uxOpen1";
            this.uxOpen1.Size = new System.Drawing.Size(152, 22);
            this.uxOpen1.Text = "Open";
            this.uxOpen1.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // uxSaveAs1
            // 
            this.uxSaveAs1.Name = "uxSaveAs1";
            this.uxSaveAs1.Size = new System.Drawing.Size(152, 22);
            this.uxSaveAs1.Text = "Save As";
            this.uxSaveAs1.Click += new System.EventHandler(this.uxSaveAs1_Click);
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 225);
            this.Controls.Add(this.uxInputText);
            this.Controls.Add(this.uxMenu);
            this.MainMenuStrip = this.uxMenu;
            this.Name = "UserInterface";
            this.Text = "Text Editor";
            this.uxMenu.ResumeLayout(false);
            this.uxMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip uxMenu;
        private System.Windows.Forms.ToolStripMenuItem uxFileMenu;
        private System.Windows.Forms.TextBox uxInputText;
        private System.Windows.Forms.OpenFileDialog uxOpenDialog;
        private System.Windows.Forms.SaveFileDialog uxSaveDialog;
        private System.Windows.Forms.ToolStripMenuItem uxOpen1;
        private System.Windows.Forms.ToolStripMenuItem uxSaveAs1;
    }
}

