namespace ProjectoC_
{
    partial class FormAdicionarPizzas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarPizzas));
            label1 = new Label();
            label2 = new Label();
            saborPtxt = new TextBox();
            precotxt = new TextBox();
            pictureBox1 = new PictureBox();
            salvarbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 155);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome da pizza:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 219);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 1;
            label2.Text = "Preco:";
            // 
            // saborPtxt
            // 
            saborPtxt.Location = new Point(131, 156);
            saborPtxt.Name = "saborPtxt";
            saborPtxt.Size = new Size(156, 23);
            saborPtxt.TabIndex = 2;
            // 
            // precotxt
            // 
            precotxt.Location = new Point(67, 220);
            precotxt.Name = "precotxt";
            precotxt.Size = new Size(158, 23);
            precotxt.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // salvarbtn
            // 
            salvarbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            salvarbtn.Location = new Point(187, 354);
            salvarbtn.Name = "salvarbtn";
            salvarbtn.Size = new Size(180, 54);
            salvarbtn.TabIndex = 7;
            salvarbtn.Text = "Salvar";
            salvarbtn.UseVisualStyleBackColor = true;
            salvarbtn.Click += salvarbtn_Click;
            // 
            // FormAdicionarPizzas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(642, 420);
            Controls.Add(salvarbtn);
            Controls.Add(pictureBox1);
            Controls.Add(precotxt);
            Controls.Add(saborPtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormAdicionarPizzas";
            Text = "FormAdicionarPizzas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox saborPtxt;
        private TextBox precotxt;
        private PictureBox pictureBox1;
        private Button salvarbtn;
    }
}