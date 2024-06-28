namespace ProjectoC_
{
    partial class RemoveBebida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveBebida));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nometxt = new TextBox();
            removerb = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 88);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 180);
            label1.Name = "label1";
            label1.Size = new Size(230, 20);
            label1.TabIndex = 5;
            label1.Text = "Digite qual bebida quer remover:";
            // 
            // nometxt
            // 
            nometxt.Location = new Point(248, 181);
            nometxt.Name = "nometxt";
            nometxt.Size = new Size(235, 23);
            nometxt.TabIndex = 6;
            nometxt.TextChanged += nometxt_TextChanged;
            // 
            // removerb
            // 
            removerb.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            removerb.Location = new Point(267, 336);
            removerb.Name = "removerb";
            removerb.Size = new Size(153, 46);
            removerb.TabIndex = 7;
            removerb.Text = "Remover";
            removerb.UseVisualStyleBackColor = true;
            removerb.Click += removerb_Click;
            // 
            // RemoveBebida
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 420);
            Controls.Add(removerb);
            Controls.Add(nometxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RemoveBebida";
            Text = "RemoveBebida";
            Load += RemoveBebida_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nometxt;
        private Button removerb;
    }
}