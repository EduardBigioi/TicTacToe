
namespace TicTacToe
{
    partial class mainForm
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
            this.resetGameButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resetGameButton
            // 
            this.resetGameButton.Location = new System.Drawing.Point(291, 335);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(75, 23);
            this.resetGameButton.TabIndex = 0;
            this.resetGameButton.Text = "Restart";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Click += new System.EventHandler(this.resetGameButton_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetGameButton);
            this.Name = "mainForm";
            this.Text = "TIC TAC TOE";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetGameButton;
    }
}

