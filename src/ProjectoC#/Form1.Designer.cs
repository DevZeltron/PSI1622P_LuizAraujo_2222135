namespace ProjectoC_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            namelogin = new TextBox();
            passlogin = new TextBox();
            label2 = new Label();
            label3 = new Label();
            createacclink = new LinkLabel();
            entrarbtn = new Button();
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
            pictureBox1.Location = new Point(218, -67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(471, 349);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(243, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(243, 288);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(100, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // namelogin
            // 
            namelogin.Anchor = AnchorStyles.Top;
            namelogin.Location = new Point(320, 233);
            namelogin.Multiline = true;
            namelogin.Name = "namelogin";
            namelogin.Size = new Size(326, 28);
            namelogin.TabIndex = 5;
            // 
            // passlogin
            // 
            passlogin.Anchor = AnchorStyles.Top;
            passlogin.Location = new Point(320, 344);
            passlogin.Multiline = true;
            passlogin.Name = "passlogin";
            passlogin.Size = new Size(326, 28);
            passlogin.TabIndex = 6;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(320, 199);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 7;
            label2.Text = "Utilizador:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(320, 310);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 8;
            label3.Text = "Password:";
            // 
            // createacclink
            // 
            createacclink.Anchor = AnchorStyles.Top;
            createacclink.AutoSize = true;
            createacclink.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            createacclink.LinkBehavior = LinkBehavior.HoverUnderline;
            createacclink.Location = new Point(650, 387);
            createacclink.Name = "createacclink";
            createacclink.Size = new Size(115, 17);
            createacclink.TabIndex = 11;
            createacclink.TabStop = true;
            createacclink.Text = "Não possui conta?";
            createacclink.LinkClicked += createacclink_LinkClicked;
            // 
            // entrarbtn
            // 
            entrarbtn.Anchor = AnchorStyles.Top;
            entrarbtn.BackColor = Color.Transparent;
            entrarbtn.FlatAppearance.BorderSize = 0;
            entrarbtn.FlatAppearance.MouseDownBackColor = Color.Transparent;
            entrarbtn.FlatStyle = FlatStyle.Popup;
            entrarbtn.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            entrarbtn.Location = new Point(370, 449);
            entrarbtn.Name = "entrarbtn";
            entrarbtn.Size = new Size(218, 70);
            entrarbtn.TabIndex = 12;
            entrarbtn.Text = "ENTRAR";
            entrarbtn.UseVisualStyleBackColor = false;
            entrarbtn.Click += entrarbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(919, 571);
            Controls.Add(createacclink);
            Controls.Add(entrarbtn);
            Controls.Add(passlogin);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(namelogin);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Login";
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
        private TextBox namelogin;
        private TextBox passlogin;
        private Label label2;
        private Label label3;
        private LinkLabel createacclink;
        private Button entrarbtn;
    }
}