namespace ProjectoC_
{
    partial class FormAdicionarBebidas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdicionarBebidas));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            nomeBtxt = new TextBox();
            precotxt = new TextBox();
            adcbebida = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(23, 164);
            label1.Name = "label1";
            label1.Size = new Size(128, 21);
            label1.TabIndex = 8;
            label1.Text = "Nome da bebida:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 220);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 9;
            label2.Text = "Preço:";
            // 
            // nomeBtxt
            // 
            nomeBtxt.Location = new Point(156, 166);
            nomeBtxt.Name = "nomeBtxt";
            nomeBtxt.Size = new Size(153, 23);
            nomeBtxt.TabIndex = 10;
            // 
            // precotxt
            // 
            precotxt.Location = new Point(81, 222);
            precotxt.Name = "precotxt";
            precotxt.Size = new Size(127, 23);
            precotxt.TabIndex = 11;
            // 
            // adcbebida
            // 
            adcbebida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            adcbebida.Location = new Point(222, 345);
            adcbebida.Name = "adcbebida";
            adcbebida.Size = new Size(153, 54);
            adcbebida.TabIndex = 12;
            adcbebida.Text = "Salvar";
            adcbebida.UseVisualStyleBackColor = true;
            adcbebida.Click += button1_Click;
            // 
            // FormAdicionarBebidas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 411);
            Controls.Add(adcbebida);
            Controls.Add(precotxt);
            Controls.Add(nomeBtxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "FormAdicionarBebidas";
            Text = "FormAdicionarBebidas";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox nomeBtxt;
        private TextBox precotxt;
        private Button adcbebida;
    }
}