namespace Проект___Конкурентно_програмиране
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
            circle = new Button();
            square = new Button();
            triangle = new Button();
            red = new Button();
            blue = new Button();
            SuspendLayout();
            // 
            // circle
            // 
            circle.Location = new Point(290, 12);
            circle.Name = "circle";
            circle.Size = new Size(133, 47);
            circle.TabIndex = 0;
            circle.Text = "Circle";
            circle.UseVisualStyleBackColor = true;
            // 
            // square
            // 
            square.Location = new Point(12, 12);
            square.Name = "square";
            square.Size = new Size(133, 47);
            square.TabIndex = 1;
            square.Text = "Square";
            square.UseVisualStyleBackColor = true;
            // 
            // triangle
            // 
            triangle.Location = new Point(151, 12);
            triangle.Name = "triangle";
            triangle.Size = new Size(133, 47);
            triangle.TabIndex = 2;
            triangle.Text = "Triangle";
            triangle.UseVisualStyleBackColor = true;
            // 
            // red
            // 
            red.Location = new Point(76, 65);
            red.Name = "red";
            red.Size = new Size(133, 47);
            red.TabIndex = 3;
            red.Text = "Red";
            red.UseVisualStyleBackColor = true;
            red.Click += red_Click;
            // 
            // blue
            // 
            blue.Location = new Point(215, 65);
            blue.Name = "blue";
            blue.Size = new Size(133, 47);
            blue.TabIndex = 4;
            blue.Text = "Blue";
            blue.UseVisualStyleBackColor = true;
            blue.Click += blue_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1355, 620);
            Controls.Add(blue);
            Controls.Add(red);
            Controls.Add(triangle);
            Controls.Add(square);
            Controls.Add(circle);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button circle;
        private Button square;
        private Button triangle;
        private Button red;
        private Button blue;
    }
}
