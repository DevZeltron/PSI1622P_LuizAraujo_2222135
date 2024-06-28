namespace ProjectoC_
{
    partial class EditarBebidaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarBebidaForm));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            txtNomeb = new TextBox();
            txtPrecob = new TextBox();
            salvarbebida = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(2, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(28, 142);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 7;
            label1.Text = "Editar nome:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(29, 242);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 8;
            label2.Text = "Editar preço:";
            // 
            // txtNomeb
            // 
            txtNomeb.Location = new Point(131, 144);
            txtNomeb.Name = "txtNomeb";
            txtNomeb.Size = new Size(217, 23);
            txtNomeb.TabIndex = 9;
            // 
            // txtPrecob
            // 
            txtPrecob.Location = new Point(131, 244);
            txtPrecob.Name = "txtPrecob";
            txtPrecob.Size = new Size(217, 23);
            txtPrecob.TabIndex = 10;
            // 
            // salvarbebida
            // 
            salvarbebida.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            salvarbebida.Location = new Point(211, 372);
            salvarbebida.Name = "salvarbebida";
            salvarbebida.Size = new Size(147, 41);
            salvarbebida.TabIndex = 11;
            salvarbebida.Text = "Salvar";
            salvarbebida.UseVisualStyleBackColor = true;
            salvarbebida.Click += salvarbebida_Click;
            // 
            // EditarBebidaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 425);
            Controls.Add(salvarbebida);
            Controls.Add(txtPrecob);
            Controls.Add(txtNomeb);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "EditarBebidaForm";
            Text = "EditarBebidaForm";
            Load += EditarBebidaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private TextBox txtNomeb;
        private TextBox txtPrecob;
        private Button salvarbebida;
    }
}