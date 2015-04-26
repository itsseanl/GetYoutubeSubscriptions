namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.imgOne = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemovePage = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAddPageOutput = new System.Windows.Forms.TextBox();
            this.btnGetLinks = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(6, 27);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(216, 59);
            this.txtOutput.TabIndex = 2;
            this.txtOutput.Visible = false;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(5, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 368);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.imgOne);
            this.tabPage1.Controls.Add(this.txtOutput);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(234, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video List";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // imgOne
            // 
            this.imgOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgOne.Location = new System.Drawing.Point(6, 27);
            this.imgOne.Name = "imgOne";
            this.imgOne.Size = new System.Drawing.Size(61, 50);
            this.imgOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOne.TabIndex = 5;
            this.imgOne.TabStop = false;
            this.imgOne.Visible = false;
            this.imgOne.Click += new System.EventHandler(this.imgOne_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtChannelName);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnRemovePage);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtAddPageOutput);
            this.tabPage2.Controls.Add(this.btnGetLinks);
            this.tabPage2.Controls.Add(this.txtInput);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(234, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comments/Suggestions? Send them to                   itsseanl@gmail.com";
            // 
            // btnRemovePage
            // 
            this.btnRemovePage.Location = new System.Drawing.Point(115, 88);
            this.btnRemovePage.Name = "btnRemovePage";
            this.btnRemovePage.Size = new System.Drawing.Size(83, 23);
            this.btnRemovePage.TabIndex = 8;
            this.btnRemovePage.Text = "Remove Page";
            this.btnRemovePage.UseVisualStyleBackColor = true;
            this.btnRemovePage.Click += new System.EventHandler(this.btnRemovePage_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter full youtube video page URL:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAddPageOutput
            // 
            this.txtAddPageOutput.Location = new System.Drawing.Point(3, 117);
            this.txtAddPageOutput.Multiline = true;
            this.txtAddPageOutput.Name = "txtAddPageOutput";
            this.txtAddPageOutput.Size = new System.Drawing.Size(225, 21);
            this.txtAddPageOutput.TabIndex = 6;
            // 
            // btnGetLinks
            // 
            this.btnGetLinks.Location = new System.Drawing.Point(33, 88);
            this.btnGetLinks.Name = "btnGetLinks";
            this.btnGetLinks.Size = new System.Drawing.Size(81, 23);
            this.btnGetLinks.TabIndex = 7;
            this.btnGetLinks.Text = "Add Page";
            this.btnGetLinks.UseVisualStyleBackColor = true;
            this.btnGetLinks.Click += new System.EventHandler(this.btnGetLinks_Click_1);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(6, 24);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(222, 20);
            this.txtInput.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(160, 3);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(77, 25);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtChannelName
            // 
            this.txtChannelName.Location = new System.Drawing.Point(6, 62);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(222, 20);
            this.txtChannelName.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter Channel Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(250, 387);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(266, 426);
            this.MinimumSize = new System.Drawing.Size(266, 426);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "ReliableSubBox";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOne)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAddPageOutput;
        private System.Windows.Forms.Button btnGetLinks;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.PictureBox imgOne;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnRemovePage;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtChannelName;
    }
}

