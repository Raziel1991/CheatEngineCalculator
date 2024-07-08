namespace HexSubtractionApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtHex1 = new System.Windows.Forms.TextBox();
            this.txtHex2 = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.textResult1 = new System.Windows.Forms.TextBox();
            this.buttonCopy1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHex1
            // 
            this.txtHex1.Location = new System.Drawing.Point(12, 12);
            this.txtHex1.Name = "txtHex1";
            this.txtHex1.Size = new System.Drawing.Size(260, 20);
            this.txtHex1.TabIndex = 0;
            this.txtHex1.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            // 
            // txtHex2
            // 
            this.txtHex2.Location = new System.Drawing.Point(12, 38);
            this.txtHex2.Name = "txtHex2";
            this.txtHex2.Size = new System.Drawing.Size(260, 20);
            this.txtHex2.TabIndex = 1;
            this.txtHex2.TextChanged += new System.EventHandler(this.txtHex_TextChanged);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(12, 79);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(40, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Result:";
            // 
            // textResult1
            // 
            this.textResult1.Location = new System.Drawing.Point(58, 76);
            this.textResult1.Name = "textResult1";
            this.textResult1.Size = new System.Drawing.Size(214, 20);
            this.textResult1.TabIndex = 3;
            // 
            // buttonCopy1
            // 
            this.buttonCopy1.Location = new System.Drawing.Point(74, 119);
            this.buttonCopy1.Name = "buttonCopy1";
            this.buttonCopy1.Size = new System.Drawing.Size(145, 23);
            this.buttonCopy1.TabIndex = 4;
            this.buttonCopy1.Text = "Copy to Clipboard";
            this.buttonCopy1.UseVisualStyleBackColor = true;
            this.buttonCopy1.Click += new System.EventHandler(this.buttonCopy1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 214);
            this.Controls.Add(this.buttonCopy1);
            this.Controls.Add(this.textResult1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtHex2);
            this.Controls.Add(this.txtHex1);
            this.Name = "MainForm";
            this.Text = "Hex Subtraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtHex1;
        private System.Windows.Forms.TextBox txtHex2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox textResult1;
        private System.Windows.Forms.Button buttonCopy1;
    }
}
