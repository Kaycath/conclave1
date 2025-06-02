namespace conclave1
{
    partial class Form1
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
            this.btGerenciar = new System.Windows.Forms.Button();
            this.btVotar = new System.Windows.Forms.Button();
            this.btResultado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGerenciar
            // 
            this.btGerenciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerenciar.Location = new System.Drawing.Point(41, 58);
            this.btGerenciar.Name = "btGerenciar";
            this.btGerenciar.Size = new System.Drawing.Size(197, 104);
            this.btGerenciar.TabIndex = 0;
            this.btGerenciar.Text = "&Gerenciar Cardeais";
            this.btGerenciar.UseVisualStyleBackColor = true;
            this.btGerenciar.Click += new System.EventHandler(this.btGerenciar_Click);
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(41, 168);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(197, 104);
            this.btVotar.TabIndex = 1;
            this.btVotar.Text = "&Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // btResultado
            // 
            this.btResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btResultado.Location = new System.Drawing.Point(41, 278);
            this.btResultado.Name = "btResultado";
            this.btResultado.Size = new System.Drawing.Size(197, 105);
            this.btResultado.TabIndex = 2;
            this.btResultado.Text = "&Resultado";
            this.btResultado.UseVisualStyleBackColor = true;
            this.btResultado.Click += new System.EventHandler(this.btResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 450);
            this.Controls.Add(this.btResultado);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.btGerenciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btGerenciar;
        private System.Windows.Forms.Button btVotar;
        private System.Windows.Forms.Button btResultado;
    }
}

