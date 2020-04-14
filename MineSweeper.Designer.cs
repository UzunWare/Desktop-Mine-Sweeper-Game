namespace Mine_Sweeper
{
    partial class Map
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
            this.Panel = new System.Windows.Forms.Panel();
            this.Expert = new System.Windows.Forms.RadioButton();
            this.Medium = new System.Windows.Forms.RadioButton();
            this.Easy = new System.Windows.Forms.RadioButton();
            this.Start = new System.Windows.Forms.Button();
            this.CellMap = new System.Windows.Forms.FlowLayoutPanel();
            this.Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel
            // 
            this.Panel.Controls.Add(this.Expert);
            this.Panel.Controls.Add(this.Medium);
            this.Panel.Controls.Add(this.Easy);
            this.Panel.Location = new System.Drawing.Point(7, 9);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(187, 54);
            this.Panel.TabIndex = 0;
            // 
            // Expert
            // 
            this.Expert.AutoSize = true;
            this.Expert.Location = new System.Drawing.Point(129, 19);
            this.Expert.Name = "Expert";
            this.Expert.Size = new System.Drawing.Size(55, 17);
            this.Expert.TabIndex = 2;
            this.Expert.Text = "Expert";
            this.Expert.UseVisualStyleBackColor = true;
            // 
            // Medium
            // 
            this.Medium.AutoSize = true;
            this.Medium.Location = new System.Drawing.Point(61, 19);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(62, 17);
            this.Medium.TabIndex = 1;
            this.Medium.Text = "Medium";
            this.Medium.UseVisualStyleBackColor = true;
            // 
            // Easy
            // 
            this.Easy.AutoSize = true;
            this.Easy.Location = new System.Drawing.Point(7, 19);
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(48, 17);
            this.Easy.TabIndex = 0;
            this.Easy.Text = "Easy";
            this.Easy.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Palatino Linotype", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(200, 9);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(82, 53);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // CellMap
            // 
            this.CellMap.Location = new System.Drawing.Point(14, 77);
            this.CellMap.Name = "CellMap";
            this.CellMap.Size = new System.Drawing.Size(552, 558);
            this.CellMap.TabIndex = 2;
            // 
            // Map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(578, 647);
            this.Controls.Add(this.CellMap);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Panel);
            this.Name = "Map";
            this.Text = "Mine Sweeper";
            this.Panel.ResumeLayout(false);
            this.Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.FlowLayoutPanel CellMap;
        private System.Windows.Forms.RadioButton Expert;
        private System.Windows.Forms.RadioButton Medium;
        private System.Windows.Forms.RadioButton Easy;
    }
}

