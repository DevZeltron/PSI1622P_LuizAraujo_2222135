namespace ProjectoC_
{
    partial class criacaoconta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(criacaoconta));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            criaruser = new TextBox();
            criarsenha = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(213, -67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(213, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(213, 343);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(291, 365);
            label3.Name = "label3";
            label3.Size = new Size(148, 28);
            label3.TabIndex = 9;
            label3.Text = "Crie uma senha:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(291, 237);
            label1.Name = "label1";
            label1.Size = new Size(175, 28);
            label1.TabIndex = 10;
            label1.Text = "Digite o seu nome:";
            label1.Click += label1_Click;
            // 
            // criaruser
            // 
            criaruser.Anchor = AnchorStyles.Top;
            criaruser.Location = new Point(305, 268);
            criaruser.Name = "criaruser";
            criaruser.Size = new Size(355, 23);
            criaruser.TabIndex = 11;
            // 
            // criarsenha
            // 
            criarsenha.Anchor = AnchorStyles.Top;
            criarsenha.Location = new Point(305, 399);
            criarsenha.Name = "criarsenha";
            criarsenha.Size = new Size(355, 23);
            criarsenha.TabIndex = 12;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(361, 454);
            button1.Name = "button1";
            button1.Size = new Size(221, 85);
            button1.TabIndex = 13;
            button1.Text = "Criar conta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // criacaoconta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(935, 588);
            Controls.Add(button1);
            Controls.Add(criarsenha);
            Controls.Add(criaruser);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "criacaoconta";
            Text = "Criar conta";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label1;
        private TextBox criaruser;
        private TextBox criarsenha;
        private Button button1;
    }
}