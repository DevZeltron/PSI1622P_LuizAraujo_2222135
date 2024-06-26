namespace ProjectoC_
{
    partial class pizzas
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
            label1 = new Label();
            fcbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(834, 55);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 0;
            // 
            // fcbtn
            // 
            fcbtn.Location = new Point(527, 661);
            fcbtn.Name = "fcbtn";
            fcbtn.Size = new Size(296, 93);
            fcbtn.TabIndex = 1;
            fcbtn.Text = "Checkout";
            fcbtn.UseVisualStyleBackColor = true;
            fcbtn.Click += fcbtn_Click;
            // 
            // pizzas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1441, 932);
            Controls.Add(fcbtn);
            Controls.Add(label1);
            Margin = new Padding(4, 5, 4, 5);
            Name = "pizzas";
            Text = "pizzas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button fcbtn;
    }
}