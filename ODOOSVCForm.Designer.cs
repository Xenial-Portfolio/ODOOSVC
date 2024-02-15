
namespace ODOOSVC
{
    partial class ODOOSVCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ODOOSVCForm));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.HeaderIcon = new System.Windows.Forms.PictureBox();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.CloseLabel = new System.Windows.Forms.Label();
            this.ODServiceLabel = new System.Windows.Forms.Label();
            this.ODServiceRestart = new System.Windows.Forms.Button();
            this.ODServiceStop = new System.Windows.Forms.Button();
            this.PostServiceStop = new System.Windows.Forms.Button();
            this.PostServiceRestart = new System.Windows.Forms.Button();
            this.PostServiceLabel = new System.Windows.Forms.Label();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.Indigo;
            this.HeaderPanel.Controls.Add(this.HeaderLabel);
            this.HeaderPanel.Controls.Add(this.HeaderIcon);
            this.HeaderPanel.Controls.Add(this.MinimizeLabel);
            this.HeaderPanel.Controls.Add(this.CloseLabel);
            this.HeaderPanel.Location = new System.Drawing.Point(-9, -14);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(339, 65);
            this.HeaderPanel.TabIndex = 0;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderPanel_MouseDown);
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.Color.White;
            this.HeaderLabel.Location = new System.Drawing.Point(53, 25);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(136, 29);
            this.HeaderLabel.TabIndex = 2;
            this.HeaderLabel.Text = "Odoo SVC";
            this.HeaderLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HeaderLabel_MouseDown);
            // 
            // HeaderIcon
            // 
            this.HeaderIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeaderIcon.BackgroundImage")));
            this.HeaderIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeaderIcon.Location = new System.Drawing.Point(16, 11);
            this.HeaderIcon.Name = "HeaderIcon";
            this.HeaderIcon.Size = new System.Drawing.Size(35, 55);
            this.HeaderIcon.TabIndex = 3;
            this.HeaderIcon.TabStop = false;
            this.HeaderIcon.Click += new System.EventHandler(this.HeaderIcon_Click);
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.AutoSize = true;
            this.MinimizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimizeLabel.ForeColor = System.Drawing.Color.White;
            this.MinimizeLabel.Location = new System.Drawing.Point(258, 22);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(22, 29);
            this.MinimizeLabel.TabIndex = 1;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            // 
            // CloseLabel
            // 
            this.CloseLabel.AutoSize = true;
            this.CloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseLabel.ForeColor = System.Drawing.Color.White;
            this.CloseLabel.Location = new System.Drawing.Point(289, 24);
            this.CloseLabel.Name = "CloseLabel";
            this.CloseLabel.Size = new System.Drawing.Size(31, 29);
            this.CloseLabel.TabIndex = 0;
            this.CloseLabel.Text = "X";
            this.CloseLabel.Click += new System.EventHandler(this.CloseLabel_Click);
            // 
            // ODServiceLabel
            // 
            this.ODServiceLabel.AutoSize = true;
            this.ODServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ODServiceLabel.ForeColor = System.Drawing.Color.Red;
            this.ODServiceLabel.Location = new System.Drawing.Point(12, 80);
            this.ODServiceLabel.Name = "ODServiceLabel";
            this.ODServiceLabel.Size = new System.Drawing.Size(132, 25);
            this.ODServiceLabel.TabIndex = 1;
            this.ODServiceLabel.Text = "Odoo Service";
            // 
            // ODServiceRestart
            // 
            this.ODServiceRestart.Location = new System.Drawing.Point(150, 84);
            this.ODServiceRestart.Name = "ODServiceRestart";
            this.ODServiceRestart.Size = new System.Drawing.Size(75, 47);
            this.ODServiceRestart.TabIndex = 2;
            this.ODServiceRestart.Text = "Restart";
            this.ODServiceRestart.UseVisualStyleBackColor = true;
            this.ODServiceRestart.Click += new System.EventHandler(this.ODServiceRestart_Click);
            // 
            // ODServiceStop
            // 
            this.ODServiceStop.Location = new System.Drawing.Point(231, 84);
            this.ODServiceStop.Name = "ODServiceStop";
            this.ODServiceStop.Size = new System.Drawing.Size(75, 47);
            this.ODServiceStop.TabIndex = 3;
            this.ODServiceStop.Text = "Stop";
            this.ODServiceStop.UseVisualStyleBackColor = true;
            this.ODServiceStop.Click += new System.EventHandler(this.ODServiceStop_Click);
            // 
            // PostServiceStop
            // 
            this.PostServiceStop.Location = new System.Drawing.Point(231, 150);
            this.PostServiceStop.Name = "PostServiceStop";
            this.PostServiceStop.Size = new System.Drawing.Size(75, 47);
            this.PostServiceStop.TabIndex = 6;
            this.PostServiceStop.Text = "Stop";
            this.PostServiceStop.UseVisualStyleBackColor = true;
            this.PostServiceStop.Click += new System.EventHandler(this.PostServiceStop_Click);
            // 
            // PostServiceRestart
            // 
            this.PostServiceRestart.Location = new System.Drawing.Point(150, 150);
            this.PostServiceRestart.Name = "PostServiceRestart";
            this.PostServiceRestart.Size = new System.Drawing.Size(75, 47);
            this.PostServiceRestart.TabIndex = 5;
            this.PostServiceRestart.Text = "Restart";
            this.PostServiceRestart.UseVisualStyleBackColor = true;
            this.PostServiceRestart.Click += new System.EventHandler(this.PostServiceRestart_Click);
            // 
            // PostServiceLabel
            // 
            this.PostServiceLabel.AutoSize = true;
            this.PostServiceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostServiceLabel.ForeColor = System.Drawing.Color.Red;
            this.PostServiceLabel.Location = new System.Drawing.Point(12, 149);
            this.PostServiceLabel.Name = "PostServiceLabel";
            this.PostServiceLabel.Size = new System.Drawing.Size(125, 25);
            this.PostServiceLabel.TabIndex = 4;
            this.PostServiceLabel.Text = "Postgre SQL";
            // 
            // ODOOSVCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkMagenta;
            this.ClientSize = new System.Drawing.Size(320, 218);
            this.Controls.Add(this.PostServiceStop);
            this.Controls.Add(this.PostServiceRestart);
            this.Controls.Add(this.PostServiceLabel);
            this.Controls.Add(this.ODServiceStop);
            this.Controls.Add(this.ODServiceRestart);
            this.Controls.Add(this.ODServiceLabel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ODOOSVCForm";
            this.Text = "ODOOSVC";
            this.Load += new System.EventHandler(this.ODOOSVCForm_Load);
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HeaderIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label CloseLabel;
        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.PictureBox HeaderIcon;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ODServiceLabel;
        private System.Windows.Forms.Button ODServiceRestart;
        private System.Windows.Forms.Button ODServiceStop;
        private System.Windows.Forms.Button PostServiceStop;
        private System.Windows.Forms.Button PostServiceRestart;
        private System.Windows.Forms.Label PostServiceLabel;
    }
}

