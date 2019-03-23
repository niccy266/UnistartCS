namespace Exercise2
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
            this.buttonChlorineCost = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxLength = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelLength = new System.Windows.Forms.Label();
            this.labelHeight = new System.Windows.Forms.Label();
            this.labelChlorKgs = new System.Windows.Forms.Label();
            this.labelChlorBags = new System.Windows.Forms.Label();
            this.labelChlorCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonChlorineCost
            // 
            this.buttonChlorineCost.Location = new System.Drawing.Point(372, 90);
            this.buttonChlorineCost.Name = "buttonChlorineCost";
            this.buttonChlorineCost.Size = new System.Drawing.Size(150, 20);
            this.buttonChlorineCost.TabIndex = 0;
            this.buttonChlorineCost.Text = "&Calculate Chlorine Cost";
            this.buttonChlorineCost.UseVisualStyleBackColor = true;
            this.buttonChlorineCost.Click += new System.EventHandler(this.buttonChlorineCost_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(372, 220);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(150, 20);
            this.buttonClear.TabIndex = 1;
            this.buttonClear.Text = "Clea&r";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(372, 246);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(150, 20);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "E&xit";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(422, 64);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(100, 20);
            this.textBoxHeight.TabIndex = 3;
            // 
            // textBoxLength
            // 
            this.textBoxLength.Location = new System.Drawing.Point(422, 13);
            this.textBoxLength.Name = "textBoxLength";
            this.textBoxLength.Size = new System.Drawing.Size(100, 20);
            this.textBoxLength.TabIndex = 4;
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(422, 38);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(100, 20);
            this.textBoxWidth.TabIndex = 5;
            // 
            // labelWidth
            // 
            this.labelWidth.Location = new System.Drawing.Point(369, 38);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(50, 20);
            this.labelWidth.TabIndex = 6;
            this.labelWidth.Text = "Width:";
            this.labelWidth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelLength
            // 
            this.labelLength.Location = new System.Drawing.Point(369, 12);
            this.labelLength.Name = "labelLength";
            this.labelLength.Size = new System.Drawing.Size(50, 20);
            this.labelLength.TabIndex = 7;
            this.labelLength.Text = "Length:";
            this.labelLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelHeight
            // 
            this.labelHeight.Location = new System.Drawing.Point(369, 64);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(50, 20);
            this.labelHeight.TabIndex = 8;
            this.labelHeight.Text = "Height:";
            this.labelHeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChlorKgs
            // 
            this.labelChlorKgs.Location = new System.Drawing.Point(369, 142);
            this.labelChlorKgs.Name = "labelChlorKgs";
            this.labelChlorKgs.Size = new System.Drawing.Size(90, 20);
            this.labelChlorKgs.TabIndex = 9;
            this.labelChlorKgs.Text = "Chlorine Needed:";
            this.labelChlorKgs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChlorBags
            // 
            this.labelChlorBags.Location = new System.Drawing.Point(369, 168);
            this.labelChlorBags.Name = "labelChlorBags";
            this.labelChlorBags.Size = new System.Drawing.Size(90, 20);
            this.labelChlorBags.TabIndex = 10;
            this.labelChlorBags.Text = "Bags of Chlorine:";
            this.labelChlorBags.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChlorCost
            // 
            this.labelChlorCost.Location = new System.Drawing.Point(369, 193);
            this.labelChlorCost.Name = "labelChlorCost";
            this.labelChlorCost.Size = new System.Drawing.Size(90, 20);
            this.labelChlorCost.TabIndex = 11;
            this.labelChlorCost.Text = "Cost of Bags:";
            this.labelChlorCost.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(369, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Water Volume:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(472, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(50, 20);
            this.textBox1.TabIndex = 13;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(472, 142);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(50, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(472, 168);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(50, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(472, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(50, 20);
            this.textBox4.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 278);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxLength);
            this.Controls.Add(this.labelChlorCost);
            this.Controls.Add(this.labelChlorBags);
            this.Controls.Add(this.labelChlorKgs);
            this.Controls.Add(this.labelHeight);
            this.Controls.Add(this.labelLength);
            this.Controls.Add(this.labelWidth);
            this.Controls.Add(this.textBoxWidth);
            this.Controls.Add(this.textBoxHeight);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonChlorineCost);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Purity Swiming Pools Chlorine Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonChlorineCost;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxLength;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelLength;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.Label labelChlorKgs;
        private System.Windows.Forms.Label labelChlorBags;
        private System.Windows.Forms.Label labelChlorCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
    }
}

