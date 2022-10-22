namespace Games
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PlusLeftLabel = new System.Windows.Forms.Label();
            this.PlusRightLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Sum = new System.Windows.Forms.NumericUpDown();
            this.Difference = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MinusRightLabel = new System.Windows.Forms.Label();
            this.MinusLeftLabel = new System.Windows.Forms.Label();
            this.Product = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimesRightLabel = new System.Windows.Forms.Label();
            this.TimeLeftLabel = new System.Windows.Forms.Label();
            this.Quotient = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DivideRightLabel = new System.Windows.Forms.Label();
            this.DivideLeftLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).BeginInit();
            this.SuspendLayout();
            // 
            // TimeLabel
            // 
            this.TimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TimeLabel.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLabel.Location = new System.Drawing.Point(272, 9);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(200, 30);
            this.TimeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(167, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time Left";
            // 
            // PlusLeftLabel
            // 
            this.PlusLeftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusLeftLabel.Location = new System.Drawing.Point(50, 75);
            this.PlusLeftLabel.Name = "PlusLeftLabel";
            this.PlusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusLeftLabel.TabIndex = 2;
            this.PlusLeftLabel.Text = "?";
            this.PlusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PlusRightLabel
            // 
            this.PlusRightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusRightLabel.Location = new System.Drawing.Point(182, 75);
            this.PlusRightLabel.Name = "PlusRightLabel";
            this.PlusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.PlusRightLabel.TabIndex = 3;
            this.PlusRightLabel.Text = "?";
            this.PlusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(116, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 50);
            this.label3.TabIndex = 4;
            this.label3.Text = "+";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(248, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 50);
            this.label4.TabIndex = 5;
            this.label4.Text = "=";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Sum
            // 
            this.Sum.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sum.Location = new System.Drawing.Point(314, 82);
            this.Sum.Name = "Sum";
            this.Sum.Size = new System.Drawing.Size(100, 39);
            this.Sum.TabIndex = 6;
            this.Sum.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Difference
            // 
            this.Difference.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Difference.Location = new System.Drawing.Point(314, 127);
            this.Difference.Name = "Difference";
            this.Difference.Size = new System.Drawing.Size(100, 39);
            this.Difference.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(248, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 50);
            this.label2.TabIndex = 10;
            this.label2.Text = "=";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(116, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 50);
            this.label5.TabIndex = 9;
            this.label5.Text = "-";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusRightLabel
            // 
            this.MinusRightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusRightLabel.Location = new System.Drawing.Point(182, 120);
            this.MinusRightLabel.Name = "MinusRightLabel";
            this.MinusRightLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusRightLabel.TabIndex = 8;
            this.MinusRightLabel.Text = "?";
            this.MinusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MinusLeftLabel
            // 
            this.MinusLeftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusLeftLabel.Location = new System.Drawing.Point(50, 120);
            this.MinusLeftLabel.Name = "MinusLeftLabel";
            this.MinusLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.MinusLeftLabel.TabIndex = 7;
            this.MinusLeftLabel.Text = "?";
            this.MinusLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Product
            // 
            this.Product.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Product.Location = new System.Drawing.Point(314, 172);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(100, 39);
            this.Product.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(248, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 50);
            this.label6.TabIndex = 15;
            this.label6.Text = "=";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(116, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 50);
            this.label7.TabIndex = 14;
            this.label7.Text = "x";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimesRightLabel
            // 
            this.TimesRightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimesRightLabel.Location = new System.Drawing.Point(182, 165);
            this.TimesRightLabel.Name = "TimesRightLabel";
            this.TimesRightLabel.Size = new System.Drawing.Size(60, 50);
            this.TimesRightLabel.TabIndex = 13;
            this.TimesRightLabel.Text = "?";
            this.TimesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimeLeftLabel
            // 
            this.TimeLeftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TimeLeftLabel.Location = new System.Drawing.Point(50, 165);
            this.TimeLeftLabel.Name = "TimeLeftLabel";
            this.TimeLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.TimeLeftLabel.TabIndex = 12;
            this.TimeLeftLabel.Text = "?";
            this.TimeLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Quotient
            // 
            this.Quotient.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Quotient.Location = new System.Drawing.Point(314, 217);
            this.Quotient.Name = "Quotient";
            this.Quotient.Size = new System.Drawing.Size(100, 39);
            this.Quotient.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(248, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 50);
            this.label10.TabIndex = 20;
            this.label10.Text = "=";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(116, 210);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 50);
            this.label11.TabIndex = 19;
            this.label11.Text = "÷";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideRightLabel
            // 
            this.DivideRightLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideRightLabel.Location = new System.Drawing.Point(182, 210);
            this.DivideRightLabel.Name = "DivideRightLabel";
            this.DivideRightLabel.Size = new System.Drawing.Size(60, 50);
            this.DivideRightLabel.TabIndex = 18;
            this.DivideRightLabel.Text = "?";
            this.DivideRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DivideLeftLabel
            // 
            this.DivideLeftLabel.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideLeftLabel.Location = new System.Drawing.Point(50, 210);
            this.DivideLeftLabel.Name = "DivideLeftLabel";
            this.DivideLeftLabel.Size = new System.Drawing.Size(60, 50);
            this.DivideLeftLabel.TabIndex = 17;
            this.DivideLeftLabel.Text = "?";
            this.DivideLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.Quotient);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DivideRightLabel);
            this.Controls.Add(this.DivideLeftLabel);
            this.Controls.Add(this.Product);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TimesRightLabel);
            this.Controls.Add(this.TimeLeftLabel);
            this.Controls.Add(this.Difference);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MinusRightLabel);
            this.Controls.Add(this.MinusLeftLabel);
            this.Controls.Add(this.Sum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PlusRightLabel);
            this.Controls.Add(this.PlusLeftLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TimeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "計算クイズ";
            ((System.ComponentModel.ISupportInitialize)(this.Sum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Difference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Product)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Quotient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label TimeLabel;
        private Label label1;
        private Label PlusLeftLabel;
        private Label PlusRightLabel;
        private Label label3;
        private Label label4;
        private NumericUpDown Sum;
        private NumericUpDown Difference;
        private Label label2;
        private Label label5;
        private Label MinusRightLabel;
        private Label MinusLeftLabel;
        private NumericUpDown Product;
        private Label label6;
        private Label label7;
        private Label TimesRightLabel;
        private Label TimeLeftLabel;
        private NumericUpDown Quotient;
        private Label label10;
        private Label label11;
        private Label DivideRightLabel;
        private Label DivideLeftLabel;
    }
}