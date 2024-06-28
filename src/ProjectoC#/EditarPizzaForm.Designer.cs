namespace ProjectoC_
{
    partial class EditarPizzaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarPizzaForm));
            label1 = new Label();
            txtNomeP = new TextBox();
            label2 = new Label();
            txtPrecoP = new TextBox();
            salvarpizza = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(34, 141);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 0;
            label1.Text = "Editar nome:";
            // 
            // txtNomeP
            // 
            txtNomeP.Location = new Point(137, 141);
            txtNomeP.Name = "txtNomeP";
            txtNomeP.Size = new Size(217, 23);
            txtNomeP.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 217);
            label2.Name = "label2";
            label2.Size = new Size(96, 21);
            label2.TabIndex = 2;
            label2.Text = "Editar preço:";
            // 
            // txtPrecoP
            // 
            txtPrecoP.Location = new Point(137, 215);
            txtPrecoP.Name = "txtPrecoP";
            txtPrecoP.Size = new Size(217, 23);
            txtPrecoP.TabIndex = 3;
            // 
            // salvarpizza
            // 
            salvarpizza.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            salvarpizza.Location = new Point(207, 343);
            salvarpizza.Name = "salvarpizza";
            salvarpizza.Size = new Size(147, 41);
            salvarpizza.TabIndex = 4;
            salvarpizza.Text = "Salvar";
            salvarpizza.UseVisualStyleBackColor = true;
            salvarpizza.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(316, 98);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // EditarPizzaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 396);
            Controls.Add(pictureBox1);
            Controls.Add(salvarpizza);
            Controls.Add(txtPrecoP);
            Controls.Add(label2);
            Controls.Add(txtNomeP);
            Controls.Add(label1);
            Name = "EditarPizzaForm";
            Text = "EditarPizzaForm";
            Load += EditarPizzaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNomeP;
        private Label label2;
        private TextBox txtPrecoP;
        private Button salvarpizza;
        private PictureBox pictureBox1;
    }
}