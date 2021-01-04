
namespace Stock_Viewer
{
    partial class stockViewer
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
            this.stockLabel = new System.Windows.Forms.Label();
            this.stockList = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.valueLabel = new System.Windows.Forms.Label();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.changeValueBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.stockLabel.Location = new System.Drawing.Point(12, 18);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(38, 13);
            this.stockLabel.TabIndex = 0;
            this.stockLabel.Text = "Stock:";
            this.stockLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // stockList
            // 
            this.stockList.FormattingEnabled = true;
            this.stockList.Location = new System.Drawing.Point(56, 18);
            this.stockList.Name = "stockList";
            this.stockList.Size = new System.Drawing.Size(120, 95);
            this.stockList.TabIndex = 1;
            this.stockList.SelectedIndexChanged += new System.EventHandler(this.stocksList_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonAdd.Location = new System.Drawing.Point(12, 34);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(38, 35);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "+";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonRemove.Location = new System.Drawing.Point(12, 75);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(38, 38);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "-";
            this.buttonRemove.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label1.Location = new System.Drawing.Point(2, 120);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(58, 17);
            this.Label1.TabIndex = 4;
            this.Label1.Text = "Symbol:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Label2.Location = new System.Drawing.Point(12, 141);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(48, 17);
            this.Label2.TabIndex = 5;
            this.Label2.Text = "Value:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(111, 133);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(0, 13);
            this.nameLabel.TabIndex = 6;
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(111, 163);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(0, 13);
            this.valueLabel.TabIndex = 7;
            // 
            // loadingLabel
            // 
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(88, 212);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(54, 13);
            this.loadingLabel.TabIndex = 8;
            this.loadingLabel.Text = "Loading...";
            this.loadingLabel.Visible = false;
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.nameBox.Location = new System.Drawing.Point(56, 117);
            this.nameBox.Name = "nameBox";
            this.nameBox.ReadOnly = true;
            this.nameBox.Size = new System.Drawing.Size(49, 20);
            this.nameBox.TabIndex = 9;
            // 
            // valueBox
            // 
            this.valueBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.valueBox.Location = new System.Drawing.Point(56, 140);
            this.valueBox.Name = "valueBox";
            this.valueBox.ReadOnly = true;
            this.valueBox.Size = new System.Drawing.Size(120, 20);
            this.valueBox.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(-1, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Change:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // changeValueBox
            // 
            this.changeValueBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.changeValueBox.Location = new System.Drawing.Point(56, 163);
            this.changeValueBox.Name = "changeValueBox";
            this.changeValueBox.ReadOnly = true;
            this.changeValueBox.Size = new System.Drawing.Size(49, 20);
            this.changeValueBox.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(114, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(28, 20);
            this.textBox2.TabIndex = 13;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.volumeLabel.Location = new System.Drawing.Point(1, 186);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(59, 17);
            this.volumeLabel.TabIndex = 14;
            this.volumeLabel.Text = "Volume:";
            // 
            // volumeBox
            // 
            this.volumeBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.volumeBox.Location = new System.Drawing.Point(56, 189);
            this.volumeBox.Name = "volumeBox";
            this.volumeBox.ReadOnly = true;
            this.volumeBox.Size = new System.Drawing.Size(120, 20);
            this.volumeBox.TabIndex = 15;
            // 
            // stockViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 271);
            this.Controls.Add(this.volumeBox);
            this.Controls.Add(this.volumeLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.changeValueBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.valueBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.valueLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.stockList);
            this.Controls.Add(this.stockLabel);
            this.Name = "stockViewer";
            this.Text = "Stock Viewer";
            this.Load += new System.EventHandler(this.stockViewer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.ListBox stockList;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox changeValueBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label volumeLabel;
        private System.Windows.Forms.TextBox volumeBox;
    }
}

