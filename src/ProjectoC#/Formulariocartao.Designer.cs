namespace ProjectoC_
{
    partial class Formulariocartao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formulariocartao));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            senhatxt = new TextBox();
            confirm = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 76);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(31, 144);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 4;
            label1.Text = "Insira a senha:";
            // 
            // senhatxt
            // 
            senhatxt.Location = new Point(138, 145);
            senhatxt.Name = "senhatxt";
            senhatxt.Size = new Size(112, 23);
            senhatxt.TabIndex = 5;
            // 
            // confirm
            // 
            confirm.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            confirm.Location = new Point(323, 285);
            confirm.Name = "confirm";
            confirm.Size = new Size(116, 46);
            confirm.TabIndex = 6;
            confirm.Text = "Confirmar";
            confirm.UseVisualStyleBackColor = true;
            confirm.Click += confirm_Click;
            // 
            // Formulariocartao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 352);
            Controls.Add(confirm);
            Controls.Add(senhatxt);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Formulariocartao";
            Text = "Formulariocartao";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox senhatxt;
        private Button confirm;
    }
}