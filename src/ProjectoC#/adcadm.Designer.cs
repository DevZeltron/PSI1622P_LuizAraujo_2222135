namespace ProjectoC_
{
    partial class adcadm
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
            adcPbtn = new Button();
            dataGridViewSaborPizzas = new DataGridView();
            sabor = new DataGridViewTextBoxColumn();
            dataGridViewBebidas = new DataGridView();
            adcBevbtn = new Button();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaborPizzas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBebidas).BeginInit();
            SuspendLayout();
            // 
            // adcPbtn
            // 
            adcPbtn.Location = new Point(557, 90);
            adcPbtn.Name = "adcPbtn";
            adcPbtn.Size = new Size(180, 61);
            adcPbtn.TabIndex = 1;
            adcPbtn.Text = "Adicionar";
            adcPbtn.UseVisualStyleBackColor = true;
            adcPbtn.Click += button1_Click;
            // 
            // dataGridViewSaborPizzas
            // 
            dataGridViewSaborPizzas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSaborPizzas.Columns.AddRange(new DataGridViewColumn[] { sabor });
            dataGridViewSaborPizzas.Location = new Point(12, 12);
            dataGridViewSaborPizzas.Name = "dataGridViewSaborPizzas";
            dataGridViewSaborPizzas.RowTemplate.Height = 25;
            dataGridViewSaborPizzas.Size = new Size(500, 210);
            dataGridViewSaborPizzas.TabIndex = 3;
            // 
            // sabor
            // 
            sabor.DataPropertyName = "sabor_id, nome, preco";
            sabor.HeaderText = "";
            sabor.Name = "sabor";
            // 
            // dataGridViewBebidas
            // 
            dataGridViewBebidas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBebidas.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridViewBebidas.Location = new Point(12, 270);
            dataGridViewBebidas.Name = "dataGridViewBebidas";
            dataGridViewBebidas.RowTemplate.Height = 25;
            dataGridViewBebidas.Size = new Size(500, 210);
            dataGridViewBebidas.TabIndex = 4;
            // 
            // adcBevbtn
            // 
            adcBevbtn.Location = new Point(557, 348);
            adcBevbtn.Name = "adcBevbtn";
            adcBevbtn.Size = new Size(180, 61);
            adcBevbtn.TabIndex = 5;
            adcBevbtn.Text = "Adicionar";
            adcBevbtn.UseVisualStyleBackColor = true;
            adcBevbtn.Click += adcBevbtn_Click;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "bebida_id, nomebev, preco";
            dataGridViewTextBoxColumn1.HeaderText = "";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // adcadm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 492);
            Controls.Add(adcBevbtn);
            Controls.Add(dataGridViewBebidas);
            Controls.Add(dataGridViewSaborPizzas);
            Controls.Add(adcPbtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "adcadm";
            Text = "adcadm";
            Load += adcadm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSaborPizzas).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBebidas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button adcPbtn;
        private DataGridView dataGridViewSaborPizzas;
        private DataGridViewTextBoxColumn sabor;
        private DataGridView dataGridViewBebidas;
        private Button adcBevbtn;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    }
}