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
            this.lbStr = new System.Windows.Forms.Label();
            this.lbDex = new System.Windows.Forms.Label();
            this.lbCon = new System.Windows.Forms.Label();
            this.lbInt = new System.Windows.Forms.Label();
            this.lbWis = new System.Windows.Forms.Label();
            this.lbCha = new System.Windows.Forms.Label();
            this.lbPoints = new System.Windows.Forms.Label();
            this.txtBoxPoints = new System.Windows.Forms.TextBox();
            this.btnStrIn = new System.Windows.Forms.Button();
            this.btnStrDe = new System.Windows.Forms.Button();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.btnDexDe = new System.Windows.Forms.Button();
            this.btnDexIn = new System.Windows.Forms.Button();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.btnConDe = new System.Windows.Forms.Button();
            this.btnConIn = new System.Windows.Forms.Button();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.btnIntDe = new System.Windows.Forms.Button();
            this.btnIntIn = new System.Windows.Forms.Button();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.btnChaDe = new System.Windows.Forms.Button();
            this.btnChaIn = new System.Windows.Forms.Button();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.btnWisDe = new System.Windows.Forms.Button();
            this.btnWisIn = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbStr
            // 
            this.lbStr.AutoSize = true;
            this.lbStr.Location = new System.Drawing.Point(12, 9);
            this.lbStr.Name = "lbStr";
            this.lbStr.Size = new System.Drawing.Size(47, 13);
            this.lbStr.TabIndex = 5;
            this.lbStr.Text = "Strength";
            // 
            // lbDex
            // 
            this.lbDex.AutoSize = true;
            this.lbDex.Location = new System.Drawing.Point(65, 9);
            this.lbDex.Name = "lbDex";
            this.lbDex.Size = new System.Drawing.Size(48, 13);
            this.lbDex.TabIndex = 7;
            this.lbDex.Text = "Dexterity";
            // 
            // lbCon
            // 
            this.lbCon.AutoSize = true;
            this.lbCon.Location = new System.Drawing.Point(119, 9);
            this.lbCon.Name = "lbCon";
            this.lbCon.Size = new System.Drawing.Size(62, 13);
            this.lbCon.TabIndex = 9;
            this.lbCon.Text = "Constitution";
            // 
            // lbInt
            // 
            this.lbInt.AutoSize = true;
            this.lbInt.Location = new System.Drawing.Point(187, 9);
            this.lbInt.Name = "lbInt";
            this.lbInt.Size = new System.Drawing.Size(61, 13);
            this.lbInt.TabIndex = 11;
            this.lbInt.Text = "Intillegence";
            // 
            // lbWis
            // 
            this.lbWis.AutoSize = true;
            this.lbWis.Location = new System.Drawing.Point(251, 9);
            this.lbWis.Name = "lbWis";
            this.lbWis.Size = new System.Drawing.Size(45, 13);
            this.lbWis.TabIndex = 13;
            this.lbWis.Text = "Wisdom";
            // 
            // lbCha
            // 
            this.lbCha.AutoSize = true;
            this.lbCha.Location = new System.Drawing.Point(302, 9);
            this.lbCha.Name = "lbCha";
            this.lbCha.Size = new System.Drawing.Size(50, 13);
            this.lbCha.TabIndex = 15;
            this.lbCha.Text = "Charisma";
            // 
            // lbPoints
            // 
            this.lbPoints.AutoSize = true;
            this.lbPoints.Location = new System.Drawing.Point(141, 121);
            this.lbPoints.Name = "lbPoints";
            this.lbPoints.Size = new System.Drawing.Size(87, 13);
            this.lbPoints.TabIndex = 17;
            this.lbPoints.Text = "Points Remaning";
            // 
            // txtBoxPoints
            // 
            this.txtBoxPoints.Location = new System.Drawing.Point(168, 137);
            this.txtBoxPoints.Name = "txtBoxPoints";
            this.txtBoxPoints.ReadOnly = true;
            this.txtBoxPoints.Size = new System.Drawing.Size(29, 20);
            this.txtBoxPoints.TabIndex = 18;
            this.txtBoxPoints.Text = "27";
            // 
            // btnStrIn
            // 
            this.btnStrIn.Location = new System.Drawing.Point(12, 25);
            this.btnStrIn.Name = "btnStrIn";
            this.btnStrIn.Size = new System.Drawing.Size(33, 23);
            this.btnStrIn.TabIndex = 19;
            this.btnStrIn.Text = "+";
            this.btnStrIn.UseVisualStyleBackColor = true;
            this.btnStrIn.Click += new System.EventHandler(this.btnStrIn_Click);
            // 
            // btnStrDe
            // 
            this.btnStrDe.Location = new System.Drawing.Point(12, 83);
            this.btnStrDe.Name = "btnStrDe";
            this.btnStrDe.Size = new System.Drawing.Size(33, 23);
            this.btnStrDe.TabIndex = 20;
            this.btnStrDe.Text = "-";
            this.btnStrDe.UseVisualStyleBackColor = true;
            this.btnStrDe.Click += new System.EventHandler(this.btnStrDe_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(12, 54);
            this.txtStr.Name = "txtStr";
            this.txtStr.ReadOnly = true;
            this.txtStr.Size = new System.Drawing.Size(33, 20);
            this.txtStr.TabIndex = 21;
            this.txtStr.Text = "8";
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(68, 54);
            this.txtDex.Name = "txtDex";
            this.txtDex.ReadOnly = true;
            this.txtDex.Size = new System.Drawing.Size(33, 20);
            this.txtDex.TabIndex = 24;
            this.txtDex.Text = "8";
            // 
            // btnDexDe
            // 
            this.btnDexDe.Location = new System.Drawing.Point(68, 83);
            this.btnDexDe.Name = "btnDexDe";
            this.btnDexDe.Size = new System.Drawing.Size(33, 23);
            this.btnDexDe.TabIndex = 23;
            this.btnDexDe.Text = "-";
            this.btnDexDe.UseVisualStyleBackColor = true;
            this.btnDexDe.Click += new System.EventHandler(this.btnDexDe_Click);
            // 
            // btnDexIn
            // 
            this.btnDexIn.Location = new System.Drawing.Point(68, 25);
            this.btnDexIn.Name = "btnDexIn";
            this.btnDexIn.Size = new System.Drawing.Size(33, 23);
            this.btnDexIn.TabIndex = 22;
            this.btnDexIn.Text = "+";
            this.btnDexIn.UseVisualStyleBackColor = true;
            this.btnDexIn.Click += new System.EventHandler(this.btnDexIn_Click);
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(122, 54);
            this.txtCon.Name = "txtCon";
            this.txtCon.ReadOnly = true;
            this.txtCon.Size = new System.Drawing.Size(33, 20);
            this.txtCon.TabIndex = 27;
            this.txtCon.Text = "8";
            // 
            // btnConDe
            // 
            this.btnConDe.Location = new System.Drawing.Point(122, 83);
            this.btnConDe.Name = "btnConDe";
            this.btnConDe.Size = new System.Drawing.Size(33, 23);
            this.btnConDe.TabIndex = 26;
            this.btnConDe.Text = "-";
            this.btnConDe.UseVisualStyleBackColor = true;
            this.btnConDe.Click += new System.EventHandler(this.btnConDe_Click);
            // 
            // btnConIn
            // 
            this.btnConIn.Location = new System.Drawing.Point(122, 25);
            this.btnConIn.Name = "btnConIn";
            this.btnConIn.Size = new System.Drawing.Size(33, 23);
            this.btnConIn.TabIndex = 25;
            this.btnConIn.Text = "+";
            this.btnConIn.UseVisualStyleBackColor = true;
            this.btnConIn.Click += new System.EventHandler(this.btnConIn_Click);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(190, 54);
            this.txtInt.Name = "txtInt";
            this.txtInt.ReadOnly = true;
            this.txtInt.Size = new System.Drawing.Size(33, 20);
            this.txtInt.TabIndex = 30;
            this.txtInt.Text = "8";
            // 
            // btnIntDe
            // 
            this.btnIntDe.Location = new System.Drawing.Point(190, 83);
            this.btnIntDe.Name = "btnIntDe";
            this.btnIntDe.Size = new System.Drawing.Size(33, 23);
            this.btnIntDe.TabIndex = 29;
            this.btnIntDe.Text = "-";
            this.btnIntDe.UseVisualStyleBackColor = true;
            this.btnIntDe.Click += new System.EventHandler(this.btnIntDe_Click);
            // 
            // btnIntIn
            // 
            this.btnIntIn.Location = new System.Drawing.Point(190, 25);
            this.btnIntIn.Name = "btnIntIn";
            this.btnIntIn.Size = new System.Drawing.Size(33, 23);
            this.btnIntIn.TabIndex = 28;
            this.btnIntIn.Text = "+";
            this.btnIntIn.UseVisualStyleBackColor = true;
            this.btnIntIn.Click += new System.EventHandler(this.btnIntIn_Click);
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(305, 54);
            this.txtCha.Name = "txtCha";
            this.txtCha.ReadOnly = true;
            this.txtCha.Size = new System.Drawing.Size(33, 20);
            this.txtCha.TabIndex = 33;
            this.txtCha.Text = "8";
            // 
            // btnChaDe
            // 
            this.btnChaDe.Location = new System.Drawing.Point(305, 83);
            this.btnChaDe.Name = "btnChaDe";
            this.btnChaDe.Size = new System.Drawing.Size(33, 23);
            this.btnChaDe.TabIndex = 32;
            this.btnChaDe.Text = "-";
            this.btnChaDe.UseVisualStyleBackColor = true;
            this.btnChaDe.Click += new System.EventHandler(this.btnChaDe_Click);
            // 
            // btnChaIn
            // 
            this.btnChaIn.Location = new System.Drawing.Point(305, 25);
            this.btnChaIn.Name = "btnChaIn";
            this.btnChaIn.Size = new System.Drawing.Size(33, 23);
            this.btnChaIn.TabIndex = 31;
            this.btnChaIn.Text = "+";
            this.btnChaIn.UseVisualStyleBackColor = true;
            this.btnChaIn.Click += new System.EventHandler(this.btnChaIn_Click);
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(254, 54);
            this.txtWis.Name = "txtWis";
            this.txtWis.ReadOnly = true;
            this.txtWis.Size = new System.Drawing.Size(33, 20);
            this.txtWis.TabIndex = 36;
            this.txtWis.Text = "8";
            // 
            // btnWisDe
            // 
            this.btnWisDe.Location = new System.Drawing.Point(254, 83);
            this.btnWisDe.Name = "btnWisDe";
            this.btnWisDe.Size = new System.Drawing.Size(33, 23);
            this.btnWisDe.TabIndex = 35;
            this.btnWisDe.Text = "-";
            this.btnWisDe.UseVisualStyleBackColor = true;
            this.btnWisDe.Click += new System.EventHandler(this.btnWisDe_Click);
            // 
            // btnWisIn
            // 
            this.btnWisIn.Location = new System.Drawing.Point(254, 25);
            this.btnWisIn.Name = "btnWisIn";
            this.btnWisIn.Size = new System.Drawing.Size(33, 23);
            this.btnWisIn.TabIndex = 34;
            this.btnWisIn.Text = "+";
            this.btnWisIn.UseVisualStyleBackColor = true;
            this.btnWisIn.Click += new System.EventHandler(this.btnWisIn_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(144, 163);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // FormPointBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 205);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.btnWisDe);
            this.Controls.Add(this.btnWisIn);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.btnChaDe);
            this.Controls.Add(this.btnChaIn);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.btnIntDe);
            this.Controls.Add(this.btnIntIn);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.btnConDe);
            this.Controls.Add(this.btnConIn);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.btnDexDe);
            this.Controls.Add(this.btnDexIn);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.btnStrDe);
            this.Controls.Add(this.btnStrIn);
            this.Controls.Add(this.txtBoxPoints);
            this.Controls.Add(this.lbPoints);
            this.Controls.Add(this.lbCha);
            this.Controls.Add(this.lbWis);
            this.Controls.Add(this.lbInt);
            this.Controls.Add(this.lbCon);
            this.Controls.Add(this.lbDex);
            this.Controls.Add(this.lbStr);
            this.Name = "FormPointBuy";
            this.Text = "FormPointBuy";
            this.Load += new System.EventHandler(this.FormPointBuy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbStr;
        private System.Windows.Forms.Label lbDex;
        private System.Windows.Forms.Label lbCon;
        private System.Windows.Forms.Label lbInt;
        private System.Windows.Forms.Label lbWis;
        private System.Windows.Forms.Label lbCha;
        private System.Windows.Forms.Label lbPoints;
        private System.Windows.Forms.TextBox txtBoxPoints;
        private System.Windows.Forms.Button btnStrIn;
        private System.Windows.Forms.Button btnStrDe;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.Button btnDexDe;
        private System.Windows.Forms.Button btnDexIn;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Button btnConDe;
        private System.Windows.Forms.Button btnConIn;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Button btnIntDe;
        private System.Windows.Forms.Button btnIntIn;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.Button btnChaDe;
        private System.Windows.Forms.Button btnChaIn;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.Button btnWisDe;
        private System.Windows.Forms.Button btnWisIn;
        private System.Windows.Forms.Button btnReset;
    }
}