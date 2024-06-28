namespace ProjectoC_
{
    partial class Formmoney
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formmoney));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            montantetxt = new TextBox();
            moneybtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(258, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 153);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 4;
            label1.Text = "Insira o montante:";
            // 
            // montantetxt
            // 
            montantetxt.Location = new Point(146, 153);
            montantetxt.Name = "montantetxt";
            montantetxt.Size = new Size(117, 23);
            montantetxt.TabIndex = 5;
            // 
            // moneybtn
            // 
            moneybtn.Location = new Point(186, 314);
            moneybtn.Name = "moneybtn";
            moneybtn.Size = new Size(137, 55);
            moneybtn.TabIndex = 6;
            moneybtn.Text = "Pagar";
            moneybtn.UseVisualStyleBackColor = true;
            moneybtn.Click += moneybtn_Click;
            // 
            // Formmoney
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 381);
            Controls.Add(moneybtn);
            Controls.Add(montantetxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Formmoney";
            Text = "Formmoney";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox montantetxt;
        private Button moneybtn;
    }
}