namespace csgo_simple_glow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.chkTeamGlow = new System.Windows.Forms.CheckBox();
            this.chkEnemyGlow = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkTeamGlow
            // 
            this.chkTeamGlow.AutoSize = true;
            this.chkTeamGlow.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkTeamGlow.Location = new System.Drawing.Point(113, 33);
            this.chkTeamGlow.Name = "chkTeamGlow";
            this.chkTeamGlow.Size = new System.Drawing.Size(139, 29);
            this.chkTeamGlow.TabIndex = 0;
            this.chkTeamGlow.Text = "teammate";
            this.chkTeamGlow.UseVisualStyleBackColor = true;
            this.chkTeamGlow.CheckedChanged += new System.EventHandler(this.chkTeamGlow_CheckedChanged);
            // 
            // chkEnemyGlow
            // 
            this.chkEnemyGlow.AutoSize = true;
            this.chkEnemyGlow.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.chkEnemyGlow.Location = new System.Drawing.Point(130, -2);
            this.chkEnemyGlow.Name = "chkEnemyGlow";
            this.chkEnemyGlow.Size = new System.Drawing.Size(102, 29);
            this.chkEnemyGlow.TabIndex = 1;
            this.chkEnemyGlow.Text = "enemy";
            this.chkEnemyGlow.UseVisualStyleBackColor = true;
            this.chkEnemyGlow.CheckedChanged += new System.EventHandler(this.chkEnemyGlow_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, -2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "external glowesp by destiezk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(388, 66);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEnemyGlow);
            this.Controls.Add(this.chkTeamGlow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "21atgajsa81258gaajaiaa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkTeamGlow;
        private System.Windows.Forms.CheckBox chkEnemyGlow;
        private System.Windows.Forms.Label label1;
    }
}

