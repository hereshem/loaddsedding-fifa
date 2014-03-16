namespace Loadshedding
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
            this.pbxFull = new System.Windows.Forms.PictureBox();
            this.pbxPlan = new System.Windows.Forms.PictureBox();
            this.pbxMain = new System.Windows.Forms.PictureBox();
            this.pbxSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFull)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxFull
            // 
            this.pbxFull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(53)))));
            this.pbxFull.Image = global::Loadshedding.Properties.Resources.schedule;
            this.pbxFull.Location = new System.Drawing.Point(202, 441);
            this.pbxFull.Name = "pbxFull";
            this.pbxFull.Size = new System.Drawing.Size(128, 108);
            this.pbxFull.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxFull.TabIndex = 5;
            this.pbxFull.TabStop = false;
            this.pbxFull.Click += new System.EventHandler(this.pbxFull_Click);
            // 
            // pbxPlan
            // 
            this.pbxPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(53)))));
            this.pbxPlan.Image = global::Loadshedding.Properties.Resources.plan;
            this.pbxPlan.Location = new System.Drawing.Point(373, 441);
            this.pbxPlan.Name = "pbxPlan";
            this.pbxPlan.Size = new System.Drawing.Size(128, 108);
            this.pbxPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxPlan.TabIndex = 3;
            this.pbxPlan.TabStop = false;
            this.pbxPlan.Click += new System.EventHandler(this.pbxPlan_Click);
            // 
            // pbxMain
            // 
            this.pbxMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(53)))));
            this.pbxMain.Image = global::Loadshedding.Properties.Resources.back;
            this.pbxMain.Location = new System.Drawing.Point(31, 441);
            this.pbxMain.Name = "pbxMain";
            this.pbxMain.Size = new System.Drawing.Size(128, 108);
            this.pbxMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxMain.TabIndex = 2;
            this.pbxMain.TabStop = false;
            this.pbxMain.Click += new System.EventHandler(this.pbxMain_Click);
            // 
            // pbxSettings
            // 
            this.pbxSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(123)))), ((int)(((byte)(53)))));
            this.pbxSettings.Image = ((System.Drawing.Image)(resources.GetObject("pbxSettings.Image")));
            this.pbxSettings.InitialImage = null;
            this.pbxSettings.Location = new System.Drawing.Point(544, 441);
            this.pbxSettings.Name = "pbxSettings";
            this.pbxSettings.Size = new System.Drawing.Size(128, 108);
            this.pbxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxSettings.TabIndex = 0;
            this.pbxSettings.TabStop = false;
            this.pbxSettings.Click += new System.EventHandler(this.pbxSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(704, 556);
            this.Controls.Add(this.pbxFull);
            this.Controls.Add(this.pbxPlan);
            this.Controls.Add(this.pbxMain);
            this.Controls.Add(this.pbxSettings);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Text = "Sunkoshi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFull)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSettings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxSettings;
        private System.Windows.Forms.PictureBox pbxMain;
        private System.Windows.Forms.PictureBox pbxPlan;
        private System.Windows.Forms.PictureBox pbxFull;

    }
}

