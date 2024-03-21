namespace n09310012
{
    partial class ckr
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
            this.zoo = new System.Windows.Forms.Button();
            this.cs1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // zoo
            // 
            this.zoo.Location = new System.Drawing.Point(92, 48);
            this.zoo.Name = "zoo";
            this.zoo.Size = new System.Drawing.Size(75, 23);
            this.zoo.TabIndex = 0;
            this.zoo.Text = "切換";
            this.zoo.UseVisualStyleBackColor = true;
            this.zoo.Click += new System.EventHandler(this.zoo_Click);
            // 
            // cs1
            // 
            this.cs1.Location = new System.Drawing.Point(369, 75);
            this.cs1.Name = "cs1";
            this.cs1.Size = new System.Drawing.Size(75, 23);
            this.cs1.TabIndex = 1;
            this.cs1.Text = "關閉視窗";
            this.cs1.UseVisualStyleBackColor = true;
            this.cs1.Click += new System.EventHandler(this.cs1_Click);
            // 
            // ckr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cs1);
            this.Controls.Add(this.zoo);
            this.Name = "ckr";
            this.Text = "home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button zoo;
        private System.Windows.Forms.Button cs1;
    }
}