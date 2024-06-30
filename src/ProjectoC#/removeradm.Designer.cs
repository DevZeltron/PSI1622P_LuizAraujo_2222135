namespace ProjectoC_
{
    partial class removeradm
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
            dataGridSaborPizzasR = new DataGridView();
            sabor = new DataGridViewTextBoxColumn();
            dataGridBebidasR = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            removerP = new Button();
            removerB = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridSaborPizzasR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBebidasR).BeginInit();
            SuspendLayout();
            // 
            // dataGridSaborPizzasR
            // 
            dataGridSaborPizzasR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridSaborPizzasR.Columns.AddRange(new DataGridViewColumn[] { sabor });
            dataGridSaborPizzasR.Location = new Point(12, 12);
            dataGridSaborPizzasR.Name = "dataGridSaborPizzasR";
            dataGridSaborPizzasR.RowTemplate.Height = 25;
            dataGridSaborPizzasR.Size = new Size(500, 210);
            dataGridSaborPizzasR.TabIndex = 4;
            // 
            // sabor
            // 
            sabor.DataPropertyName = "sabor_id, nome, preco";
            sabor.HeaderText = "";
            sabor.Name = "sabor";
            // 
            // dataGridBebidasR
            // 
            dataGridBebidasR.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridBebidasR.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dataGridBebidasR.Location = new Point(12, 287);
            dataGridBebidasR.Name = "dataGridBebidasR";
            dataGridBebidasR.RowTemplate.Height = 25;
            dataGridBebidasR.Size = new Size(500, 210);
            dataGridBebidasR.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.DataPropertyName = "bebida_id, nomebev, preco";
            dataGridViewTextBoxColumn1.HeaderText = "";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // removerP
            // 
            removerP.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            removerP.Location = new Point(548, 93);
            removerP.Name = "removerP";
            removerP.Size = new Size(175, 44);
            removerP.TabIndex = 6;
            removerP.Text = "Remover Pizza";
            removerP.UseVisualStyleBackColor = true;
            removerP.Click += removerP_Click;
            // 
            // removerB
            // 
            removerB.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            removerB.Location = new Point(548, 364);
            removerB.Name = "removerB";
            removerB.Size = new Size(175, 44);
            removerB.TabIndex = 7;
            removerB.Text = "Remover Bebida";
            removerB.UseVisualStyleBackColor = true;
            removerB.Click += removerB_Click;
            // 
            // removeradm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 509);
            Controls.Add(removerB);
            Controls.Add(removerP);
            Controls.Add(dataGridBebidasR);
            Controls.Add(dataGridSaborPizzasR);
            FormBorderStyle = FormBorderStyle.None;
            Name = "removeradm";
            Text = "removeradm";
            Load += removeradm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridSaborPizzasR).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridBebidasR).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridSaborPizzasR;
        private DataGridViewTextBoxColumn sabor;
        private DataGridView dataGridBebidasR;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button removerP;
        private Button removerB;
    }
}