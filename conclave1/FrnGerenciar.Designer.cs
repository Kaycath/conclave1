namespace conclave1
{
    partial class FrnGerenciar
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
            this.dgvCardeais = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAdiciona = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardeais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCardeais
            // 
            this.dgvCardeais.AllowUserToAddRows = false;
            this.dgvCardeais.AllowUserToDeleteRows = false;
            this.dgvCardeais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardeais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.dgvCardeais.Location = new System.Drawing.Point(12, 32);
            this.dgvCardeais.Name = "dgvCardeais";
            this.dgvCardeais.ReadOnly = true;
            this.dgvCardeais.Size = new System.Drawing.Size(285, 406);
            this.dgvCardeais.TabIndex = 1;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(316, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(396, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(167, 20);
            this.txtNome.TabIndex = 3;
            // 
            // btAdiciona
            // 
            this.btAdiciona.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdiciona.Location = new System.Drawing.Point(370, 143);
            this.btAdiciona.Name = "btAdiciona";
            this.btAdiciona.Size = new System.Drawing.Size(113, 41);
            this.btAdiciona.TabIndex = 4;
            this.btAdiciona.Text = "&Adiconar";
            this.btAdiciona.UseVisualStyleBackColor = true;
            this.btAdiciona.Click += new System.EventHandler(this.btAdiciona_Click);
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(370, 334);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(113, 41);
            this.btRemover.TabIndex = 5;
            this.btRemover.Text = "E&xcluir";
            this.btRemover.UseVisualStyleBackColor = true;
            // 
            // FrnGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdiciona);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvCardeais);
            this.Name = "FrnGerenciar";
            this.Text = "Frn-Gerenciar-Cardeais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrnGerenciar_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardeais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCardeais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btAdiciona;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}