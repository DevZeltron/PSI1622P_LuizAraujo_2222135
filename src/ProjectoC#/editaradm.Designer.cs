namespace ProjectoC_
{
    partial class editaradm
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
            dataGridPizzas = new DataGridView();
            dataGridViewBeb = new DataGridView();
            EditarPbtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridPizzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBeb).BeginInit();
            SuspendLayout();
            // 
            // dataGridPizzas
            // 
            dataGridPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPizzas.Location = new Point(26, 12);
            dataGridPizzas.Name = "dataGridPizzas";
            dataGridPizzas.RowTemplate.Height = 25;
            dataGridPizzas.Size = new Size(379, 255);
            dataGridPizzas.TabIndex = 1;
            // 
            // dataGridViewBeb
            // 
            dataGridViewBeb.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBeb.Location = new Point(26, 397);
            dataGridViewBeb.Name = "dataGridViewBeb";
            dataGridViewBeb.RowTemplate.Height = 25;
            dataGridViewBeb.Size = new Size(379, 255);
            dataGridViewBeb.TabIndex = 2;
            // 
            // EditarPbtn
            // 
            EditarPbtn.Location = new Point(447, 86);
            EditarPbtn.Name = "EditarPbtn";
            EditarPbtn.Size = new Size(202, 52);
            EditarPbtn.TabIndex = 3;
            EditarPbtn.Text = "Editar Pizza";
            EditarPbtn.UseVisualStyleBackColor = true;
            EditarPbtn.Click += EditarPbtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(447, 503);
            button1.Name = "button1";
            button1.Size = new Size(202, 52);
            button1.TabIndex = 4;
            button1.Text = "Editar Bebida";
            button1.UseVisualStyleBackColor = true;
            // 
            // editaradm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 701);
            Controls.Add(button1);
            Controls.Add(EditarPbtn);
            Controls.Add(dataGridViewBeb);
            Controls.Add(dataGridPizzas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editaradm";
            Text = "editaradm";
            Load += editaradm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPizzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBeb).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridPizzas;
        private DataGridView dataGridViewBeb;
        private Button EditarPbtn;
        private Button button1;
    }
}