
namespace Stock_Viewer
{
    partial class addPopup
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
            this.addText = new System.Windows.Forms.TextBox();
            this.addSubmit = new System.Windows.Forms.Button();
            this.addSymbolLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.exchangeAddLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addText
            // 
            this.addText.Location = new System.Drawing.Point(64, 52);
            this.addText.Name = "addText";
            this.addText.Size = new System.Drawing.Size(117, 20);
            this.addText.TabIndex = 0;
            // 
            // addSubmit
            // 
            this.addSubmit.Location = new System.Drawing.Point(64, 78);
            this.addSubmit.Name = "addSubmit";
            this.addSubmit.Size = new System.Drawing.Size(117, 21);
            this.addSubmit.TabIndex = 1;
            this.addSubmit.Text = "Submit";
            this.addSubmit.UseVisualStyleBackColor = true;
            this.addSubmit.Click += new System.EventHandler(this.addSubmit_Click);
            // 
            // addSymbolLabel
            // 
            this.addSymbolLabel.AutoSize = true;
            this.addSymbolLabel.Location = new System.Drawing.Point(12, 55);
            this.addSymbolLabel.Name = "addSymbolLabel";
            this.addSymbolLabel.Size = new System.Drawing.Size(44, 13);
            this.addSymbolLabel.TabIndex = 2;
            this.addSymbolLabel.Text = "Symbol:";
            this.addSymbolLabel.Click += new System.EventHandler(this.addButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 20);
            this.textBox1.TabIndex = 3;
            // 
            // exchangeAddLabel
            // 
            this.exchangeAddLabel.AutoSize = true;
            this.exchangeAddLabel.Location = new System.Drawing.Point(4, 26);
            this.exchangeAddLabel.Name = "exchangeAddLabel";
            this.exchangeAddLabel.Size = new System.Drawing.Size(58, 13);
            this.exchangeAddLabel.TabIndex = 4;
            this.exchangeAddLabel.Text = "Exchange:";
            // 
            // addPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(203, 116);
            this.Controls.Add(this.exchangeAddLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.addSymbolLabel);
            this.Controls.Add(this.addSubmit);
            this.Controls.Add(this.addText);
            this.Name = "addPopup";
            this.Text = "addPopup";
            this.Load += new System.EventHandler(this.addPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox addText;
        private System.Windows.Forms.Button addSubmit;
        private System.Windows.Forms.Label addSymbolLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label exchangeAddLabel;
    }
}