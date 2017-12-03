namespace ProjectMuteSheet
{
    partial class FormPointBuy
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
            this.BtnStrIncrease = new System.Windows.Forms.Button();
            this.lbStrPB = new System.Windows.Forms.Label();
            this.BtnStrDecrease = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnStrIncrease
            // 
            this.BtnStrIncrease.Location = new System.Drawing.Point(22, 75);
            this.BtnStrIncrease.Name = "BtnStrIncrease";
            this.BtnStrIncrease.Size = new System.Drawing.Size(75, 23);
            this.BtnStrIncrease.TabIndex = 0;
            this.BtnStrIncrease.Text = "Increase";
            this.BtnStrIncrease.UseVisualStyleBackColor = true;
            // 
            // lbStrPB
            // 
            this.lbStrPB.AutoSize = true;
            this.lbStrPB.Location = new System.Drawing.Point(31, 117);
            this.lbStrPB.Name = "lbStrPB";
            this.lbStrPB.Size = new System.Drawing.Size(13, 13);
            this.lbStrPB.TabIndex = 1;
            this.lbStrPB.Text = "8";
            // 
            // BtnStrDecrease
            // 
            this.BtnStrDecrease.Location = new System.Drawing.Point(22, 155);
            this.BtnStrDecrease.Name = "BtnStrDecrease";
            this.BtnStrDecrease.Size = new System.Drawing.Size(75, 23);
            this.BtnStrDecrease.TabIndex = 2;
            this.BtnStrDecrease.Text = "Decrease";
            this.BtnStrDecrease.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Strength";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(22, 284);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Strength";
            // 
            // FormPointBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 310);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnStrDecrease);
            this.Controls.Add(this.lbStrPB);
            this.Controls.Add(this.BtnStrIncrease);
            this.Name = "FormPointBuy";
            this.Text = "FormPointBuy";
            this.Load += new System.EventHandler(this.FormPointBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStrIncrease;
        private System.Windows.Forms.Label lbStrPB;
        private System.Windows.Forms.Button BtnStrDecrease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}