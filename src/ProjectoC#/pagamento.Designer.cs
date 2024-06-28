namespace ProjectoC_
{
    partial class pagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pagamento));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            finalizarcompra = new Button();
            cardrdnbtn = new RadioButton();
            moneyrdnbtn = new RadioButton();
            label4 = new Label();
            itenslbl = new Label();
            totalp = new Label();
            label3 = new Label();
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
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(306, 9);
            label1.Name = "label1";
            label1.Size = new Size(269, 23);
            label1.TabIndex = 3;
            label1.Text = "   Bem Vindo à área de pagamento!";
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(12, 258);
            label2.Name = "label2";
            label2.Size = new Size(333, 23);
            label2.TabIndex = 4;
            label2.Text = "Por favor, escolha o método de pagamento!";
            // 
            // finalizarcompra
            // 
            finalizarcompra.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            finalizarcompra.Location = new Point(329, 432);
            finalizarcompra.Name = "finalizarcompra";
            finalizarcompra.Size = new Size(212, 52);
            finalizarcompra.TabIndex = 5;
            finalizarcompra.Text = "Finalizar compra";
            finalizarcompra.UseVisualStyleBackColor = true;
            finalizarcompra.Click += button1_Click;
            // 
            // cardrdnbtn
            // 
            cardrdnbtn.AutoSize = true;
            cardrdnbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            cardrdnbtn.Location = new Point(23, 309);
            cardrdnbtn.Name = "cardrdnbtn";
            cardrdnbtn.RightToLeft = RightToLeft.Yes;
            cardrdnbtn.Size = new Size(141, 24);
            cardrdnbtn.TabIndex = 6;
            cardrdnbtn.TabStop = true;
            cardrdnbtn.Text = "Cartão de Credito";
            cardrdnbtn.UseVisualStyleBackColor = true;
            // 
            // moneyrdnbtn
            // 
            moneyrdnbtn.AutoSize = true;
            moneyrdnbtn.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            moneyrdnbtn.Location = new Point(23, 352);
            moneyrdnbtn.Name = "moneyrdnbtn";
            moneyrdnbtn.RightToLeft = RightToLeft.Yes;
            moneyrdnbtn.Size = new Size(82, 24);
            moneyrdnbtn.TabIndex = 7;
            moneyrdnbtn.TabStop = true;
            moneyrdnbtn.Text = "Dinheiro";
            moneyrdnbtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Font = new Font("Verdana", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(12, 161);
            label4.Name = "label4";
            label4.Size = new Size(121, 23);
            label4.TabIndex = 9;
            label4.Text = "Total a pagar:";
            // 
            // itenslbl
            // 
            itenslbl.Location = new Point(138, 123);
            itenslbl.Name = "itenslbl";
            itenslbl.Size = new Size(118, 23);
            itenslbl.TabIndex = 10;
            // 
            // totalp
            // 
            totalp.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            totalp.Location = new Point(126, 161);
            totalp.Name = "totalp";
            totalp.Size = new Size(232, 40);
            totalp.TabIndex = 11;
            totalp.Click += totalp_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(306, 55);
            label3.Name = "label3";
            label3.Size = new Size(269, 23);
            label3.TabIndex = 13;
            label3.Text = "     Obrigado pela sua preferência!";
            // 
            // pagamento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 496);
            Controls.Add(label3);
            Controls.Add(totalp);
            Controls.Add(itenslbl);
            Controls.Add(label4);
            Controls.Add(moneyrdnbtn);
            Controls.Add(cardrdnbtn);
            Controls.Add(finalizarcompra);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "pagamento";
            Text = "pagamento";
            Load += pagamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button finalizarcompra;
        private RadioButton cardrdnbtn;
        private RadioButton moneyrdnbtn;
        private Label label4;
        private Label itenslbl;
        private Label totalp;
        private Label label3;
    }
}