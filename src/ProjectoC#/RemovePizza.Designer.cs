namespace ProjectoC_
{
    partial class RemovePizza
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemovePizza));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nometxt = new TextBox();
            removerbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-1, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(218, 20);
            label1.TabIndex = 4;
            label1.Text = "Digite qual pizza quer remover:";
            // 
            // nometxt
            // 
            nometxt.Location = new Point(236, 140);
            nometxt.Name = "nometxt";
            nometxt.Size = new Size(235, 23);
            nometxt.TabIndex = 5;
            // 
            // removerbtn
            // 
            removerbtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            removerbtn.Location = new Point(227, 340);
            removerbtn.Name = "removerbtn";
            removerbtn.Size = new Size(174, 49);
            removerbtn.TabIndex = 6;
            removerbtn.Text = "Remover";
            removerbtn.UseVisualStyleBackColor = true;
            removerbtn.Click += removerbtn_Click;
            // 
            // RemovePizza
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 401);
            Controls.Add(removerbtn);
            Controls.Add(nometxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "RemovePizza";
            Text = "RemovePizza";
            Load += RemovePizza_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox nometxt;
        private Button removerbtn;
    }
}