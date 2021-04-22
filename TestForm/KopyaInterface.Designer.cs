
namespace TestForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CurrentProg = new System.Windows.Forms.ProgressBar();
            this.TotalProg = new System.Windows.Forms.ProgressBar();
            this.SourceTxt = new System.Windows.Forms.TextBox();
            this.SourceBtn = new System.Windows.Forms.Button();
            this.DestinationBtn = new System.Windows.Forms.Button();
            this.DestinationTxt = new System.Windows.Forms.TextBox();
            this.StartBtn = new System.Windows.Forms.Button();
            this.FileRadio = new System.Windows.Forms.RadioButton();
            this.FolderRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TotalProgLbl = new System.Windows.Forms.Label();
            this.CurrentProgLbl = new System.Windows.Forms.Label();
            this.StatMsgLbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SourceErrorLbl = new System.Windows.Forms.Label();
            this.DestinationErrorLbl = new System.Windows.Forms.Label();
            this.SizeStatLbl = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CurrentProg
            // 
            this.CurrentProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CurrentProg.Location = new System.Drawing.Point(18, 29);
            this.CurrentProg.Name = "CurrentProg";
            this.CurrentProg.Size = new System.Drawing.Size(363, 10);
            this.CurrentProg.TabIndex = 0;
            // 
            // TotalProg
            // 
            this.TotalProg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalProg.Location = new System.Drawing.Point(18, 61);
            this.TotalProg.Name = "TotalProg";
            this.TotalProg.Size = new System.Drawing.Size(363, 10);
            this.TotalProg.TabIndex = 0;
            // 
            // SourceTxt
            // 
            this.SourceTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceTxt.Location = new System.Drawing.Point(17, 35);
            this.SourceTxt.Name = "SourceTxt";
            this.SourceTxt.Size = new System.Drawing.Size(320, 23);
            this.SourceTxt.TabIndex = 1;
            this.SourceTxt.TextChanged += new System.EventHandler(this.SourceTxt_TextChanged);
            // 
            // SourceBtn
            // 
            this.SourceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceBtn.Location = new System.Drawing.Point(343, 35);
            this.SourceBtn.Name = "SourceBtn";
            this.SourceBtn.Size = new System.Drawing.Size(75, 23);
            this.SourceBtn.TabIndex = 2;
            this.SourceBtn.Text = "Browse";
            this.SourceBtn.UseVisualStyleBackColor = true;
            this.SourceBtn.Click += new System.EventHandler(this.SourceBtn_Click);
            // 
            // DestinationBtn
            // 
            this.DestinationBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationBtn.Enabled = false;
            this.DestinationBtn.Location = new System.Drawing.Point(343, 79);
            this.DestinationBtn.Name = "DestinationBtn";
            this.DestinationBtn.Size = new System.Drawing.Size(75, 23);
            this.DestinationBtn.TabIndex = 4;
            this.DestinationBtn.Text = "Browse";
            this.DestinationBtn.UseVisualStyleBackColor = true;
            this.DestinationBtn.Click += new System.EventHandler(this.DestinationBtn_Click);
            // 
            // DestinationTxt
            // 
            this.DestinationTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationTxt.Enabled = false;
            this.DestinationTxt.Location = new System.Drawing.Point(17, 79);
            this.DestinationTxt.Name = "DestinationTxt";
            this.DestinationTxt.Size = new System.Drawing.Size(320, 23);
            this.DestinationTxt.TabIndex = 3;
            // 
            // StartBtn
            // 
            this.StartBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StartBtn.Location = new System.Drawing.Point(262, 108);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 7;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // FileRadio
            // 
            this.FileRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FileRadio.Checked = true;
            this.FileRadio.Location = new System.Drawing.Point(100, 108);
            this.FileRadio.Name = "FileRadio";
            this.FileRadio.Size = new System.Drawing.Size(75, 19);
            this.FileRadio.TabIndex = 5;
            this.FileRadio.TabStop = true;
            this.FileRadio.Text = "File";
            this.FileRadio.UseVisualStyleBackColor = true;
            // 
            // FolderRadio
            // 
            this.FolderRadio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FolderRadio.Enabled = false;
            this.FolderRadio.Location = new System.Drawing.Point(181, 108);
            this.FolderRadio.Name = "FolderRadio";
            this.FolderRadio.Size = new System.Drawing.Size(75, 19);
            this.FolderRadio.TabIndex = 6;
            this.FolderRadio.Text = "Folder";
            this.FolderRadio.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Current";
            // 
            // TotalProgLbl
            // 
            this.TotalProgLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TotalProgLbl.Location = new System.Drawing.Point(353, 42);
            this.TotalProgLbl.Name = "TotalProgLbl";
            this.TotalProgLbl.Size = new System.Drawing.Size(35, 15);
            this.TotalProgLbl.TabIndex = 0;
            this.TotalProgLbl.Text = "100%";
            // 
            // CurrentProgLbl
            // 
            this.CurrentProgLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CurrentProgLbl.Location = new System.Drawing.Point(353, 11);
            this.CurrentProgLbl.Name = "CurrentProgLbl";
            this.CurrentProgLbl.Size = new System.Drawing.Size(35, 15);
            this.CurrentProgLbl.TabIndex = 0;
            this.CurrentProgLbl.Text = "100%";
            // 
            // StatMsgLbl
            // 
            this.StatMsgLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.StatMsgLbl.AutoEllipsis = true;
            this.StatMsgLbl.Location = new System.Drawing.Point(18, 78);
            this.StatMsgLbl.Name = "StatMsgLbl";
            this.StatMsgLbl.Size = new System.Drawing.Size(363, 15);
            this.StatMsgLbl.TabIndex = 0;
            this.StatMsgLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "Source";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Destination";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SizeStatLbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CurrentProg);
            this.panel1.Controls.Add(this.TotalProg);
            this.panel1.Controls.Add(this.StatMsgLbl);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.CurrentProgLbl);
            this.panel1.Controls.Add(this.TotalProgLbl);
            this.panel1.Location = new System.Drawing.Point(17, 137);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(401, 106);
            this.panel1.TabIndex = 0;
            // 
            // SourceErrorLbl
            // 
            this.SourceErrorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SourceErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.SourceErrorLbl.Location = new System.Drawing.Point(93, 17);
            this.SourceErrorLbl.Name = "SourceErrorLbl";
            this.SourceErrorLbl.Size = new System.Drawing.Size(244, 15);
            this.SourceErrorLbl.TabIndex = 0;
            // 
            // DestinationErrorLbl
            // 
            this.DestinationErrorLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DestinationErrorLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.DestinationErrorLbl.Location = new System.Drawing.Point(93, 61);
            this.DestinationErrorLbl.Name = "DestinationErrorLbl";
            this.DestinationErrorLbl.Size = new System.Drawing.Size(244, 15);
            this.DestinationErrorLbl.TabIndex = 0;
            // 
            // SizeStatLbl
            // 
            this.SizeStatLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SizeStatLbl.AutoEllipsis = true;
            this.SizeStatLbl.Location = new System.Drawing.Point(118, 42);
            this.SizeStatLbl.Name = "SizeStatLbl";
            this.SizeStatLbl.Size = new System.Drawing.Size(163, 15);
            this.SizeStatLbl.TabIndex = 1;
            this.SizeStatLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 261);
            this.Controls.Add(this.DestinationErrorLbl);
            this.Controls.Add(this.SourceErrorLbl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FolderRadio);
            this.Controls.Add(this.FileRadio);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.DestinationBtn);
            this.Controls.Add(this.DestinationTxt);
            this.Controls.Add(this.SourceBtn);
            this.Controls.Add(this.SourceTxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kopya";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar CurrentProg;
        private System.Windows.Forms.ProgressBar TotalProg;
        private System.Windows.Forms.TextBox SourceTxt;
        private System.Windows.Forms.Button SourceBtn;
        private System.Windows.Forms.Button DestinationBtn;
        private System.Windows.Forms.TextBox DestinationTxt;
        private System.Windows.Forms.Button StartBtn;
        private System.Windows.Forms.RadioButton FileRadio;
        private System.Windows.Forms.RadioButton FolderRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TotalProgLbl;
        private System.Windows.Forms.Label CurrentProgLbl;
        private System.Windows.Forms.Label StatMsgLbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label SourceErrorLbl;
        private System.Windows.Forms.Label DestinationErrorLbl;
        private System.Windows.Forms.Label SizeStatLbl;
    }
}

