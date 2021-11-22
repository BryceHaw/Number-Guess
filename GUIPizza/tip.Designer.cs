namespace GUIPizza
{
    partial class tip
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
            this.btnAddTip = new System.Windows.Forms.Button();
            this.grpBoxTip = new System.Windows.Forms.GroupBox();
            this.txt15Tip = new System.Windows.Forms.TextBox();
            this.txt20Tip = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.chk20Tip = new System.Windows.Forms.RadioButton();
            this.chk15Tip = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.grpBoxTip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(26, 359);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(285, 54);
            this.btnAddTip.TabIndex = 0;
            this.btnAddTip.Text = "Add Tip";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // grpBoxTip
            // 
            this.grpBoxTip.Controls.Add(this.chk15Tip);
            this.grpBoxTip.Controls.Add(this.chk20Tip);
            this.grpBoxTip.Controls.Add(this.txt15Tip);
            this.grpBoxTip.Controls.Add(this.txt20Tip);
            this.grpBoxTip.Location = new System.Drawing.Point(26, 24);
            this.grpBoxTip.Name = "grpBoxTip";
            this.grpBoxTip.Size = new System.Drawing.Size(285, 198);
            this.grpBoxTip.TabIndex = 1;
            this.grpBoxTip.TabStop = false;
            this.grpBoxTip.Text = "Tip Amount";
            // 
            // txt15Tip
            // 
            this.txt15Tip.Location = new System.Drawing.Point(143, 61);
            this.txt15Tip.Name = "txt15Tip";
            this.txt15Tip.ReadOnly = true;
            this.txt15Tip.Size = new System.Drawing.Size(93, 29);
            this.txt15Tip.TabIndex = 5;
            // 
            // txt20Tip
            // 
            this.txt20Tip.Location = new System.Drawing.Point(143, 108);
            this.txt20Tip.Name = "txt20Tip";
            this.txt20Tip.ReadOnly = true;
            this.txt20Tip.Size = new System.Drawing.Size(93, 29);
            this.txt20Tip.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Subtotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(117, 264);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(93, 29);
            this.txtSubtotal.TabIndex = 4;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(117, 306);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 29);
            this.txtTotal.TabIndex = 5;
            // 
            // chk20Tip
            // 
            this.chk20Tip.AutoSize = true;
            this.chk20Tip.Location = new System.Drawing.Point(27, 108);
            this.chk20Tip.Name = "chk20Tip";
            this.chk20Tip.Size = new System.Drawing.Size(110, 29);
            this.chk20Tip.TabIndex = 6;
            this.chk20Tip.TabStop = true;
            this.chk20Tip.Text = "20% Tip";
            this.chk20Tip.UseVisualStyleBackColor = true;
            // 
            // chk15Tip
            // 
            this.chk15Tip.AutoSize = true;
            this.chk15Tip.Location = new System.Drawing.Point(27, 62);
            this.chk15Tip.Name = "chk15Tip";
            this.chk15Tip.Size = new System.Drawing.Size(110, 29);
            this.chk15Tip.TabIndex = 7;
            this.chk15Tip.TabStop = true;
            this.chk15Tip.Text = "15% Tip";
            this.chk15Tip.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Check Total";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 438);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpBoxTip);
            this.Controls.Add(this.btnAddTip);
            this.Name = "tip";
            this.Text = "Tip";
            this.Load += new System.EventHandler(this.tip_Load);
            this.grpBoxTip.ResumeLayout(false);
            this.grpBoxTip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.GroupBox grpBoxTip;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txt20Tip;
        private System.Windows.Forms.TextBox txt15Tip;
        private System.Windows.Forms.RadioButton chk15Tip;
        private System.Windows.Forms.RadioButton chk20Tip;
        private System.Windows.Forms.Button button1;
    }
}