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
            this.numUDStr = new System.Windows.Forms.NumericUpDown();
            this.lbStr = new System.Windows.Forms.Label();
            this.lbDex = new System.Windows.Forms.Label();
            this.numUDDex = new System.Windows.Forms.NumericUpDown();
            this.lbCon = new System.Windows.Forms.Label();
            this.numUDCon = new System.Windows.Forms.NumericUpDown();
            this.lbInt = new System.Windows.Forms.Label();
            this.numUDInt = new System.Windows.Forms.NumericUpDown();
            this.lbWis = new System.Windows.Forms.Label();
            this.numUDWis = new System.Windows.Forms.NumericUpDown();
            this.lbCha = new System.Windows.Forms.Label();
            this.numUDCha = new System.Windows.Forms.NumericUpDown();
            this.lbPoints = new System.Windows.Forms.Label();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCha)).BeginInit();
            this.SuspendLayout();
            // 
            // numUDStr
            // 
            this.numUDStr.Location = new System.Drawing.Point(12, 50);
            this.numUDStr.Name = "numUDStr";
            this.numUDStr.Size = new System.Drawing.Size(44, 20);
            this.numUDStr.TabIndex = 4;
            this.numUDStr.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUDStr.ValueChanged += new System.EventHandler(this.numUDStr_ValueChanged);
            // 
            // lbStr
            // 
            this.lbStr.AutoSize = true;
            this.lbStr.Location = new System.Drawing.Point(9, 22);
            this.lbStr.Name = "lbStr";
            this.lbStr.Size = new System.Drawing.Size(47, 13);
            this.lbStr.TabIndex = 5;
            this.lbStr.Text = "Strength";
            // 
            // lbDex
            // 
            this.lbDex.AutoSize = true;
            this.lbDex.Location = new System.Drawing.Point(62, 22);
            this.lbDex.Name = "lbDex";
            this.lbDex.Size = new System.Drawing.Size(48, 13);
            this.lbDex.TabIndex = 7;
            this.lbDex.Text = "Dexterity";
            // 
            // numUDDex
            // 
            this.numUDDex.Location = new System.Drawing.Point(65, 50);
            this.numUDDex.Name = "numUDDex";
            this.numUDDex.Size = new System.Drawing.Size(44, 20);
            this.numUDDex.TabIndex = 6;
            this.numUDDex.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numUDDex.ValueChanged += new System.EventHandler(this.numUDDex_ValueChanged);
            // 
            // lbCon
            // 
            this.lbCon.AutoSize = true;
            this.lbCon.Location = new System.Drawing.Point(115, 22);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(62, 13);
            this.lbCon.TabIndex = 9;
            this.lbCon.Text = "Constitution";
            // 
            // numUDCon
            // 
            this.numUDCon.Location = new System.Drawing.Point(118, 50);
            this.numUDCon.Name = "numUDCon";
            this.numUDCon.Size = new System.Drawing.Size(44, 20);
            this.numUDCon.TabIndex = 8;
            this.numUDCon.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(183, 23);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(61, 13);
            this.lbInt.TabIndex = 11;
            this.lbInt.Text = "Intillegence";
            // 
            // numUDInt
            // 
            this.numUDInt.Location = new System.Drawing.Point(186, 50);
            this.numUDInt.Name = "numUDInt";
            this.numUDInt.Size = new System.Drawing.Size(44, 20);
            this.numUDInt.TabIndex = 10;
            this.numUDInt.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbWis
            // 
            this.lbWis.AutoSize = true;
            this.lbWis.Location = new System.Drawing.Point(250, 23);
            this.lbWis.Name = "lbWis";
            this.lbWis.Size = new System.Drawing.Size(45, 13);
            this.lbWis.TabIndex = 13;
            this.lbWis.Text = "Wisdom";
            // 
            // numUDWis
            // 
            this.numUDWis.Location = new System.Drawing.Point(253, 50);
            this.numUDWis.Name = "numUDWis";
            this.numUDWis.Size = new System.Drawing.Size(44, 20);
            this.numUDWis.TabIndex = 12;
            this.numUDWis.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbCha
            // 
            this.lbCha.AutoSize = true;
            this.lbCha.Location = new System.Drawing.Point(317, 22);
            this.lbCha.Name = "lbCha";
            this.lbCha.Size = new System.Drawing.Size(50, 13);
            this.lbCha.TabIndex = 15;
            this.lbCha.Text = "Charisma";
            // 
            // numUDCha
            // 
            this.numUDCha.Location = new System.Drawing.Point(320, 50);
            this.numUDCha.Name = "numUDCha";
            this.numUDCha.Size = new System.Drawing.Size(44, 20);
            this.numUDCha.TabIndex = 14;
            this.numUDCha.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Location = new System.Drawing.Point(131, 86);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(87, 13);
            this.lbPoints.TabIndex = 17;
            this.lbPoints.Text = "Points Remaning";
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.Location = new System.Drawing.Point(158, 102);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.ReadOnly = true;
            this.txtBoxPoints.Size = new System.Drawing.Size(29, 20);
            this.txtBoxPoints.TabIndex = 18;
            this.txtBoxPoints.Text = "27";
            // 
            // FormPointBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 125);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.lbCha);
            this.Controls.Add(this.numUDCha);
            this.Controls.Add(this.lbWis);
            this.Controls.Add(this.numUDWis);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.numUDInt);
            this.Controls.Add(this.lbCon);
            this.Controls.Add(this.numUDCon);
            this.Controls.Add(this.lbDex);
            this.Controls.Add(this.numUDDex);
            this.Controls.Add(this.lbStr);
            this.Controls.Add(this.numUDStr);
            this.Name = "FormPointBuy";
            this.Text = "FormPointBuy";
            this.Load += new System.EventHandler(this.FormPointBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUDStr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDDex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDWis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDCha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown numUDStr;
        private System.Windows.Forms.Label lbStr;
        private System.Windows.Forms.Label lbDex;
        private System.Windows.Forms.NumericUpDown numUDDex;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.NumericUpDown numUDCon;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.NumericUpDown numUDInt;
        private System.Windows.Forms.Label lbWis;
        private System.Windows.Forms.NumericUpDown numUDWis;
        private System.Windows.Forms.Label lbCha;
        private System.Windows.Forms.NumericUpDown numUDCha;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.TextBox txtBoxPoints;
    }
}