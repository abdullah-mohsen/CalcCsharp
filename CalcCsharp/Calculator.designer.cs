namespace CalcCsharp
{
    partial class Calculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnthree = new System.Windows.Forms.Button();
            this.btntwo_ = new System.Windows.Forms.Button();
            this.btnfour_ = new System.Windows.Forms.Button();
            this.btnsix = new System.Windows.Forms.Button();
            this.btnfive = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnseven = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnplus = new System.Windows.Forms.Button();
            this.btnEqual = new System.Windows.Forms.Button();
            this.btndivide = new System.Windows.Forms.Button();
            this.btnmultiply = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 29);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnC
            // 
            this.btnC.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnC.Location = new System.Drawing.Point(0, 64);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(134, 23);
            this.btnC.TabIndex = 1;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = false;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnMinus.Location = new System.Drawing.Point(160, 66);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(45, 21);
            this.btnMinus.TabIndex = 2;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(0, 93);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(45, 21);
            this.btnOne.TabIndex = 3;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.DisplayNumber);
            // 
            // btnthree
            // 
            this.btnthree.Location = new System.Drawing.Point(102, 93);
            this.btnthree.Name = "btnthree";
            this.btnthree.Size = new System.Drawing.Size(45, 21);
            this.btnthree.TabIndex = 4;
            this.btnthree.Text = "3";
            this.btnthree.UseVisualStyleBackColor = true;
            this.btnthree.Click += new System.EventHandler(this.btnthree_Click);
            // 
            // btntwo_
            // 
            this.btntwo_.Location = new System.Drawing.Point(51, 93);
            this.btntwo_.Name = "btntwo_";
            this.btntwo_.Size = new System.Drawing.Size(45, 21);
            this.btntwo_.TabIndex = 5;
            this.btntwo_.Text = "2";
            this.btntwo_.UseVisualStyleBackColor = true;
            this.btntwo_.Click += new System.EventHandler(this.DisplayNumber);
            // 
            // btnfour_
            // 
            this.btnfour_.Location = new System.Drawing.Point(0, 120);
            this.btnfour_.Name = "btnfour_";
            this.btnfour_.Size = new System.Drawing.Size(45, 21);
            this.btnfour_.TabIndex = 6;
            this.btnfour_.Text = "4";
            this.btnfour_.UseVisualStyleBackColor = true;
            this.btnfour_.Click += new System.EventHandler(this.btnfour__Click);
            // 
            // btnsix
            // 
            this.btnsix.Location = new System.Drawing.Point(102, 120);
            this.btnsix.Name = "btnsix";
            this.btnsix.Size = new System.Drawing.Size(45, 21);
            this.btnsix.TabIndex = 7;
            this.btnsix.Text = "6";
            this.btnsix.UseVisualStyleBackColor = true;
            this.btnsix.Click += new System.EventHandler(this.btnsix_Click);
            // 
            // btnfive
            // 
            this.btnfive.Location = new System.Drawing.Point(51, 120);
            this.btnfive.Name = "btnfive";
            this.btnfive.Size = new System.Drawing.Size(45, 21);
            this.btnfive.TabIndex = 8;
            this.btnfive.Text = "5";
            this.btnfive.UseVisualStyleBackColor = true;
            this.btnfive.Click += new System.EventHandler(this.btnfive_Click);
            // 
            // btnNine
            // 
            this.btnNine.Location = new System.Drawing.Point(102, 147);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(45, 21);
            this.btnNine.TabIndex = 9;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = true;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnEight
            // 
            this.btnEight.Location = new System.Drawing.Point(51, 147);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(45, 21);
            this.btnEight.TabIndex = 10;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = true;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnseven
            // 
            this.btnseven.Location = new System.Drawing.Point(0, 147);
            this.btnseven.Name = "btnseven";
            this.btnseven.Size = new System.Drawing.Size(45, 21);
            this.btnseven.TabIndex = 11;
            this.btnseven.Text = "7";
            this.btnseven.UseVisualStyleBackColor = true;
            this.btnseven.Click += new System.EventHandler(this.btnseven_Click);
            // 
            // btnZero
            // 
            this.btnZero.Location = new System.Drawing.Point(0, 182);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(96, 21);
            this.btnZero.TabIndex = 12;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = true;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnplus
            // 
            this.btnplus.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnplus.Location = new System.Drawing.Point(160, 93);
            this.btnplus.Name = "btnplus";
            this.btnplus.Size = new System.Drawing.Size(45, 21);
            this.btnplus.TabIndex = 13;
            this.btnplus.Text = "+";
            this.btnplus.UseVisualStyleBackColor = false;
            this.btnplus.Click += new System.EventHandler(this.btnplus_Click);
            // 
            // btnEqual
            // 
            this.btnEqual.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEqual.Location = new System.Drawing.Point(102, 182);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(100, 21);
            this.btnEqual.TabIndex = 14;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = false;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // btndivide
            // 
            this.btndivide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btndivide.Location = new System.Drawing.Point(160, 147);
            this.btndivide.Name = "btndivide";
            this.btndivide.Size = new System.Drawing.Size(45, 21);
            this.btndivide.TabIndex = 15;
            this.btndivide.Text = "/";
            this.btndivide.UseVisualStyleBackColor = false;
            this.btndivide.Click += new System.EventHandler(this.btndivide_Click);
            // 
            // btnmultiply
            // 
            this.btnmultiply.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnmultiply.Location = new System.Drawing.Point(160, 120);
            this.btnmultiply.Name = "btnmultiply";
            this.btnmultiply.Size = new System.Drawing.Size(45, 21);
            this.btnmultiply.TabIndex = 16;
            this.btnmultiply.Text = "*";
            this.btnmultiply.UseVisualStyleBackColor = false;
            this.btnmultiply.Click += new System.EventHandler(this.btnmultiply_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(208, 215);
            this.Controls.Add(this.btnmultiply);
            this.Controls.Add(this.btndivide);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.btnplus);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnseven);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnfive);
            this.Controls.Add(this.btnsix);
            this.Controls.Add(this.btnfour_);
            this.Controls.Add(this.btntwo_);
            this.Controls.Add(this.btnthree);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.textBox1);
            this.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Name = "Calculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnthree;
        private System.Windows.Forms.Button btntwo_;
        private System.Windows.Forms.Button btnfour_;
        private System.Windows.Forms.Button btnsix;
        private System.Windows.Forms.Button btnfive;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnseven;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnplus;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.Button btndivide;
        private System.Windows.Forms.Button btnmultiply;
    }
}