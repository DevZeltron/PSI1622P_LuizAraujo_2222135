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
            dataGridBebida = new DataGridView();
            Editarbtn = new Button();
            EditarBbtn = new Button();
            bebida_id = new DataGridViewTextBoxColumn();
            nomebev = new DataGridViewTextBoxColumn();
            sabor_id = new DataGridViewTextBoxColumn();
            bebida = new DataGridViewTextBoxColumn();
            nomebebida = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridPizzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBebida).BeginInit();
            SuspendLayout();
            // 
            // dataGridPizzas
            // 
            dataGridPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridPizzas.Columns.AddRange(new DataGridViewColumn[] { sabor_id });
            dataGridPizzas.Location = new Point(26, 12);
            dataGridPizzas.Name = "dataGridPizzas";
            dataGridPizzas.RowTemplate.Height = 25;
            dataGridPizzas.Size = new Size(550, 255);
            dataGridPizzas.TabIndex = 1;
            // 
            // dataGridBebida
            // 
            dataGridBebida.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBebida.Columns.AddRange(new DataGridViewColumn[] { bebida, nomebebida, dataGridViewTextBoxColumn1 });
            dataGridBebida.Location = new Point(26, 397);
            dataGridBebida.Name = "dataGridBebida";
            dataGridBebida.RowTemplate.Height = 25;
            dataGridBebida.Size = new Size(550, 255);
            dataGridBebida.TabIndex = 2;
            // 
            // Editarbtn
            // 
            Editarbtn.Location = new Point(618, 80);
            Editarbtn.Name = "Editarbtn";
            Editarbtn.Size = new Size(202, 52);
            Editarbtn.TabIndex = 3;
            Editarbtn.Text = "Editar Pizza";
            Editarbtn.UseVisualStyleBackColor = true;
            Editarbtn.Click += EditarPbtn_Click;
            // 
            // EditarBbtn
            // 
            EditarBbtn.Location = new Point(618, 479);
            EditarBbtn.Name = "EditarBbtn";
            EditarBbtn.Size = new Size(202, 52);
            EditarBbtn.TabIndex = 4;
            EditarBbtn.Text = "Editar Bebida";
            EditarBbtn.UseVisualStyleBackColor = true;
            EditarBbtn.Click += button1_Click;
            // 
            // bebida_id
            // 
            bebida_id.DataPropertyName = "bebida_id";
            bebida_id.HeaderText = "bebida_id";
            bebida_id.Name = "bebida_id";
            // 
            // nomebev
            // 
            nomebev.DataPropertyName = "nomebev";
            nomebev.HeaderText = "nomebev";
            nomebev.Name = "nomebev";
            // 
            // sabor_id
            // 
            sabor_id.DataPropertyName = "sabor_id, name, preco";
            sabor_id.HeaderText = "sabor_id";
            sabor_id.Name = "sabor_id";
            // 
            // bebida
            // 
            bebida.DataPropertyName = "bebida_id, nome, preco";
            bebida.HeaderText = "bebida_id";
            bebida.Name = "bebida";
            // 
            // nomebebida
            // 
            nomebebida.DataPropertyName = "bebida_id";
            nomebebida.HeaderText = "nome";
            nomebebida.Name = "nomebebida";
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "preco";
            dataGridViewTextBoxColumn1.HeaderText = "preco";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // editaradm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1135, 701);
            Controls.Add(EditarBbtn);
            Controls.Add(Editarbtn);
            Controls.Add(dataGridBebida);
            Controls.Add(dataGridPizzas);
            FormBorderStyle = FormBorderStyle.None;
            Name = "editaradm";
            Text = "editaradm";
            Load += editaradm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridPizzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBebida).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridPizzas;
        private DataGridView dataGridBebida;
        private Button Editarbtn;
        private Button EditarBbtn;
        private DataGridViewTextBoxColumn bebida_id;
        private DataGridViewTextBoxColumn nomebev;
        private DataGridViewTextBoxColumn sabor_id;
        private DataGridViewTextBoxColumn bebida;
        private DataGridViewTextBoxColumn nomebebida;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}