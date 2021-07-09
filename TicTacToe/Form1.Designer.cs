
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
            this.gamePanel = new System.Windows.Forms.Panel();
            this.gameSplitContainer = new System.Windows.Forms.SplitContainer();
            this.gameOptionsSplitContainer = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.gameSplitContainer)).BeginInit();
            this.gameSplitContainer.Panel1.SuspendLayout();
            this.gameSplitContainer.Panel2.SuspendLayout();
            this.gameSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsSplitContainer)).BeginInit();
            this.gameOptionsSplitContainer.Panel2.SuspendLayout();
            this.gameOptionsSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // resetGameButton
            // 
            this.resetGameButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resetGameButton.Location = new System.Drawing.Point(5, 5);
            this.resetGameButton.Name = "resetGameButton";
            this.resetGameButton.Size = new System.Drawing.Size(633, 61);
            this.resetGameButton.TabIndex = 0;
            this.resetGameButton.Text = "Restart";
            this.resetGameButton.UseVisualStyleBackColor = true;
            this.resetGameButton.Click += new System.EventHandler(this.resetGameButton_Click);
            // 
            // gamePanel
            // 
            this.gamePanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gamePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gamePanel.Location = new System.Drawing.Point(86, 138);
            this.gamePanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(250, 260);
            this.gamePanel.TabIndex = 2;
            // 
            // gameSplitContainer
            // 
            this.gameSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.gameSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gameSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameSplitContainer.Name = "gameSplitContainer";
            this.gameSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // gameSplitContainer.Panel1
            // 
            this.gameSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameSplitContainer.Panel1.Controls.Add(this.gameOptionsSplitContainer);
            // 
            // gameSplitContainer.Panel2
            // 
            this.gameSplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.gameSplitContainer.Panel2.Controls.Add(this.resetGameButton);
            this.gameSplitContainer.Panel2.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.gameSplitContainer.Size = new System.Drawing.Size(643, 552);
            this.gameSplitContainer.SplitterDistance = 479;
            this.gameSplitContainer.SplitterWidth = 2;
            this.gameSplitContainer.TabIndex = 3;
            // 
            // gameOptionsSplitContainer
            // 
            this.gameOptionsSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameOptionsSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.gameOptionsSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.gameOptionsSplitContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gameOptionsSplitContainer.Name = "gameOptionsSplitContainer";
            // 
            // gameOptionsSplitContainer.Panel1
            // 
            this.gameOptionsSplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            // 
            // gameOptionsSplitContainer.Panel2
            // 
            this.gameOptionsSplitContainer.Panel2.Controls.Add(this.gamePanel);
            this.gameOptionsSplitContainer.Size = new System.Drawing.Size(643, 479);
            this.gameOptionsSplitContainer.SplitterDistance = 200;
            this.gameOptionsSplitContainer.SplitterWidth = 2;
            this.gameOptionsSplitContainer.TabIndex = 0;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 552);
            this.Controls.Add(this.gameSplitContainer);
            this.Name = "mainForm";
            this.Text = "TIC TAC TOE";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.gameSplitContainer.Panel1.ResumeLayout(false);
            this.gameSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameSplitContainer)).EndInit();
            this.gameSplitContainer.ResumeLayout(false);
            this.gameOptionsSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gameOptionsSplitContainer)).EndInit();
            this.gameOptionsSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button resetGameButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.SplitContainer gameSplitContainer;
        private System.Windows.Forms.SplitContainer gameOptionsSplitContainer;
    }
}

