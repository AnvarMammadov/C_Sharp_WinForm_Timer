namespace C_Sharp_WinForm_Practice
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
            this.btnBaku = new System.Windows.Forms.Button();
            this.btnLondon = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaku
            // 
            this.btnBaku.Location = new System.Drawing.Point(116, 73);
            this.btnBaku.Name = "btnBaku";
            this.btnBaku.Size = new System.Drawing.Size(177, 75);
            this.btnBaku.TabIndex = 0;
            this.btnBaku.Text = "Baku";
            this.btnBaku.UseVisualStyleBackColor = true;
            this.btnBaku.Click += new System.EventHandler(this.btnBaku_Click);
            // 
            // btnLondon
            // 
            this.btnLondon.Location = new System.Drawing.Point(443, 73);
            this.btnLondon.Name = "btnLondon";
            this.btnLondon.Size = new System.Drawing.Size(177, 75);
            this.btnLondon.TabIndex = 1;
            this.btnLondon.Text = "London";
            this.btnLondon.UseVisualStyleBackColor = true;
            this.btnLondon.Click += new System.EventHandler(this.btnLondon_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Cascadia Mono", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTime.Location = new System.Drawing.Point(232, 314);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(314, 79);
            this.lblTime.TabIndex = 2;
            this.lblTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 38F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(725, 514);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnLondon);
            this.Controls.Add(this.btnBaku);
            this.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaku;
        private System.Windows.Forms.Button btnLondon;
        private System.Windows.Forms.Label lblTime;
    }
}

