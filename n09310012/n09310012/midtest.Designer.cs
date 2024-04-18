namespace n09310012
{
    partial class midtest
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
            this.C = new System.Windows.Forms.Label();
            this.Center = new System.Windows.Forms.TextBox();
            this.trefson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.AutoSize = true;
            this.C.Location = new System.Drawing.Point(231, 81);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(48, 12);
            this.C.TabIndex = 0;
            this.C.Text = "攝氏(C):";
            // 
            // Center
            // 
            this.Center.Location = new System.Drawing.Point(361, 70);
            this.Center.Name = "Center";
            this.Center.Size = new System.Drawing.Size(100, 22);
            this.Center.TabIndex = 1;
            // 
            // trefson
            // 
            this.trefson.Location = new System.Drawing.Point(361, 129);
            this.trefson.Name = "trefson";
            this.trefson.Size = new System.Drawing.Size(75, 23);
            this.trefson.TabIndex = 2;
            this.trefson.Text = "轉換";
            this.trefson.UseVisualStyleBackColor = true;
            this.trefson.Click += new System.EventHandler(this.trefson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "華氏(F):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "請輸入攝氏後按下轉換按鈕";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // midtest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trefson);
            this.Controls.Add(this.Center);
            this.Controls.Add(this.C);
            this.Name = "midtest";
            this.Text = "midtest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label C;
        private System.Windows.Forms.TextBox Center;
        private System.Windows.Forms.Button trefson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}