namespace BinaryRelationMatrix
{
    partial class BinaryRelationMatrixForm
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
            button_Count = new Button();
            label_Hint1 = new Label();
            label_Hint2 = new Label();
            textBox_Result = new TextBox();
            textBox_B = new TextBox();
            label_B = new Label();
            textBox_A = new TextBox();
            label_A = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Count
            // 
            button_Count.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button_Count.Location = new Point(12, 232);
            button_Count.Name = "button_Count";
            button_Count.Size = new Size(430, 39);
            button_Count.TabIndex = 40;
            button_Count.Text = "Count Binary Relation Matrix";
            button_Count.UseVisualStyleBackColor = true;
            button_Count.Click += button_Count_Click;
            // 
            // label_Hint1
            // 
            label_Hint1.AutoSize = true;
            label_Hint1.Location = new Point(301, 134);
            label_Hint1.Name = "label_Hint1";
            label_Hint1.Size = new Size(107, 15);
            label_Hint1.TabIndex = 39;
            label_Hint1.Text = "*Format like: 1, 2, 3";
            // 
            // label_Hint2
            // 
            label_Hint2.AutoSize = true;
            label_Hint2.Location = new Point(301, 214);
            label_Hint2.Name = "label_Hint2";
            label_Hint2.Size = new Size(107, 15);
            label_Hint2.TabIndex = 38;
            label_Hint2.Text = "*Format like: 1, 2, 3";
            // 
            // textBox_Result
            // 
            textBox_Result.AcceptsReturn = true;
            textBox_Result.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_Result.Location = new Point(12, 277);
            textBox_Result.Multiline = true;
            textBox_Result.Name = "textBox_Result";
            textBox_Result.ReadOnly = true;
            textBox_Result.ScrollBars = ScrollBars.Both;
            textBox_Result.Size = new Size(430, 213);
            textBox_Result.TabIndex = 37;
            // 
            // textBox_B
            // 
            textBox_B.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_B.Location = new Point(117, 163);
            textBox_B.Name = "textBox_B";
            textBox_B.Size = new Size(291, 46);
            textBox_B.TabIndex = 36;
            textBox_B.TextChanged += textBox_TextChanged;
            // 
            // label_B
            // 
            label_B.AutoSize = true;
            label_B.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_B.Location = new Point(48, 166);
            label_B.Name = "label_B";
            label_B.Size = new Size(70, 40);
            label_B.TabIndex = 35;
            label_B.Text = "B = ";
            // 
            // textBox_A
            // 
            textBox_A.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_A.Location = new Point(117, 81);
            textBox_A.Name = "textBox_A";
            textBox_A.Size = new Size(291, 46);
            textBox_A.TabIndex = 34;
            textBox_A.TextChanged += textBox_TextChanged;
            // 
            // label_A
            // 
            label_A.AutoSize = true;
            label_A.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_A.Location = new Point(48, 84);
            label_A.Name = "label_A";
            label_A.Size = new Size(72, 40);
            label_A.TabIndex = 33;
            label_A.Text = "A = ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.expression;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(435, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // BinaryRelationMatrixForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(454, 501);
            Controls.Add(pictureBox1);
            Controls.Add(button_Count);
            Controls.Add(label_Hint1);
            Controls.Add(label_Hint2);
            Controls.Add(textBox_Result);
            Controls.Add(textBox_B);
            Controls.Add(label_B);
            Controls.Add(textBox_A);
            Controls.Add(label_A);
            Name = "BinaryRelationMatrixForm";
            Text = "Binary Relation Matrix";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Count;
        private Label label_Hint1;
        private Label label_Hint2;
        private TextBox textBox_Result;
        private TextBox textBox_B;
        private Label label_B;
        private TextBox textBox_A;
        private Label label_A;
        private PictureBox pictureBox1;
    }
}