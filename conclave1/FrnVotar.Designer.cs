namespace conclave1
{
    partial class FrnVotar
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
            this.lbxCardeais = new System.Windows.Forms.ListBox();
            this.btVotar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbxCardeais
            // 
            this.lbxCardeais.FormattingEnabled = true;
            this.lbxCardeais.Location = new System.Drawing.Point(12, 101);
            this.lbxCardeais.Name = "lbxCardeais";
            this.lbxCardeais.Size = new System.Drawing.Size(275, 160);
            this.lbxCardeais.TabIndex = 0;
            // 
            // btVotar
            // 
            this.btVotar.Location = new System.Drawing.Point(112, 267);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(75, 40);
            this.btVotar.TabIndex = 1;
            this.btVotar.Text = "&Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecione um cardeal: ";
            // 
            // FrnVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.lbxCardeais);
            this.Name = "FrnVotar";
            this.Text = "FrnVotar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCardeais;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.Label label1;
    }
}