namespace BinaryMultiplication
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
            this.binaryConversion = new System.Windows.Forms.Button();
            this.multiplicationBinary = new System.Windows.Forms.Button();
            this.unary = new System.Windows.Forms.Button();
            this.DecimalInput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userInput = new System.Windows.Forms.NumericUpDown();
            this.resultTextbox = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.userInput)).BeginInit();
            this.SuspendLayout();
            // 
            // binaryConversion
            // 
            this.binaryConversion.Location = new System.Drawing.Point(12, 160);
            this.binaryConversion.Name = "binaryConversion";
            this.binaryConversion.Size = new System.Drawing.Size(121, 23);
            this.binaryConversion.TabIndex = 0;
            this.binaryConversion.Text = "Conversion";
            this.binaryConversion.UseVisualStyleBackColor = true;
            this.binaryConversion.Click += new System.EventHandler(this.button1_Click);
            // 
            // multiplicationBinary
            // 
            this.multiplicationBinary.Location = new System.Drawing.Point(139, 160);
            this.multiplicationBinary.Name = "multiplicationBinary";
            this.multiplicationBinary.Size = new System.Drawing.Size(145, 23);
            this.multiplicationBinary.TabIndex = 1;
            this.multiplicationBinary.Text = " Multiplication";
            this.multiplicationBinary.UseVisualStyleBackColor = true;
            this.multiplicationBinary.Click += new System.EventHandler(this.multiplicationBinary_Click);
            // 
            // unary
            // 
            this.unary.Location = new System.Drawing.Point(290, 160);
            this.unary.Name = "unary";
            this.unary.Size = new System.Drawing.Size(101, 23);
            this.unary.TabIndex = 2;
            this.unary.Text = "Unary";
            this.unary.UseVisualStyleBackColor = true;
            // 
            // DecimalInput
            // 
            this.DecimalInput.AutoSize = true;
            this.DecimalInput.Location = new System.Drawing.Point(61, 84);
            this.DecimalInput.Name = "DecimalInput";
            this.DecimalInput.Size = new System.Drawing.Size(72, 13);
            this.DecimalInput.TabIndex = 4;
            this.DecimalInput.Text = "Decimal Input";
            this.DecimalInput.Click += new System.EventHandler(this.DecimalInput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 46);
            this.label1.TabIndex = 5;
            this.label1.Text = "Catch Media Inc";
            // 
            // userInput
            // 
            this.userInput.Location = new System.Drawing.Point(150, 82);
            this.userInput.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.userInput.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.userInput.Name = "userInput";
            this.userInput.Size = new System.Drawing.Size(131, 20);
            this.userInput.TabIndex = 6;
            this.userInput.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // resultTextbox
            // 
            this.resultTextbox.Location = new System.Drawing.Point(88, 213);
            this.resultTextbox.Name = "resultTextbox";
            this.resultTextbox.Size = new System.Drawing.Size(236, 172);
            this.resultTextbox.TabIndex = 7;
            this.resultTextbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 446);
            this.Controls.Add(this.resultTextbox);
            this.Controls.Add(this.userInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DecimalInput);
            this.Controls.Add(this.unary);
            this.Controls.Add(this.multiplicationBinary);
            this.Controls.Add(this.binaryConversion);
            this.Name = "Form1";
            this.Text = "Binary Multiplication";
            ((System.ComponentModel.ISupportInitialize)(this.userInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button binaryConversion;
        private System.Windows.Forms.Button multiplicationBinary;
        private System.Windows.Forms.Button unary;
        private System.Windows.Forms.Label DecimalInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown userInput;
        private System.Windows.Forms.RichTextBox resultTextbox;
    }
}

