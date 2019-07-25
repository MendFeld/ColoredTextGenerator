namespace TextColorGenerator
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
            this.btnSend = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.pColor = new System.Windows.Forms.Panel();
            this.rtfResult = new System.Windows.Forms.RichTextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(691, 39);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 0;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // pColor
            // 
            this.pColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColor.Location = new System.Drawing.Point(631, 30);
            this.pColor.Name = "pColor";
            this.pColor.Size = new System.Drawing.Size(54, 32);
            this.pColor.TabIndex = 1;
            this.pColor.Click += new System.EventHandler(this.PColor_Click);
            // 
            // rtfResult
            // 
            this.rtfResult.Location = new System.Drawing.Point(27, 68);
            this.rtfResult.Name = "rtfResult";
            this.rtfResult.Size = new System.Drawing.Size(739, 370);
            this.rtfResult.TabIndex = 2;
            this.rtfResult.Text = "";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(53, 39);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(555, 20);
            this.txtValue.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.rtfResult);
            this.Controls.Add(this.pColor);
            this.Controls.Add(this.btnSend);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Multiple Color";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel pColor;
        private System.Windows.Forms.RichTextBox rtfResult;
        private System.Windows.Forms.TextBox txtValue;
    }
}

