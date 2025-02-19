namespace moreWinBtn
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            infoLable = new Label();
            button4 = new Button();
            button5 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(23, 32);
            button1.Name = "button1";
            button1.Size = new Size(253, 253);
            button1.TabIndex = 0;
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(305, 32);
            button2.Name = "button2";
            button2.Size = new Size(253, 253);
            button2.TabIndex = 1;
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(581, 32);
            button3.Name = "button3";
            button3.Size = new Size(253, 253);
            button3.TabIndex = 2;
            button3.TextAlign = ContentAlignment.BottomCenter;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // infoLable
            // 
            infoLable.AutoSize = true;
            infoLable.Font = new Font("Microsoft JhengHei UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 136);
            infoLable.Location = new Point(56, 318);
            infoLable.Name = "infoLable";
            infoLable.Size = new Size(69, 25);
            infoLable.TabIndex = 3;
            infoLable.Text = "label1";
            // 
            // button4
            // 
            button4.BackColor = Color.Linen;
            button4.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button4.Location = new Point(273, 385);
            button4.Name = "button4";
            button4.Size = new Size(139, 49);
            button4.TabIndex = 4;
            button4.Text = "再試一次";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Linen;
            button5.Font = new Font("Microsoft JhengHei UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button5.Location = new Point(455, 385);
            button5.Name = "button5";
            button5.Size = new Size(139, 49);
            button5.TabIndex = 5;
            button5.Text = "離開";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 476);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(infoLable);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label infoLable;
        private Button button4;
        private Button button5;
    }
}
