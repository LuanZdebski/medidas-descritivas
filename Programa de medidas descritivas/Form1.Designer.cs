namespace Programa_de_medidas_descritivas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataNumero = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Peso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMedia = new System.Windows.Forms.Button();
            this.btnMediana = new System.Windows.Forms.Button();
            this.btnVariancia = new System.Windows.Forms.Button();
            this.btnDesvio = new System.Windows.Forms.Button();
            this.btnCoeficiente = new System.Windows.Forms.Button();
            this.btnConjunto = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataNumero)).BeginInit();
            this.SuspendLayout();
            // 
            // dataNumero
            // 
            this.dataNumero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNumero.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Peso});
            this.dataNumero.Location = new System.Drawing.Point(12, 45);
            this.dataNumero.Name = "dataNumero";
            this.dataNumero.Size = new System.Drawing.Size(629, 298);
            this.dataNumero.TabIndex = 2;
            // 
            // Numero
            // 
            this.Numero.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numero.HeaderText = "Numero";
            this.Numero.Name = "Numero";
            // 
            // Peso
            // 
            this.Peso.HeaderText = "Peso";
            this.Peso.Name = "Peso";
            // 
            // btnMedia
            // 
            this.btnMedia.Location = new System.Drawing.Point(12, 350);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(308, 88);
            this.btnMedia.TabIndex = 3;
            this.btnMedia.Text = "Média aritmetica";
            this.btnMedia.UseVisualStyleBackColor = true;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // btnMediana
            // 
            this.btnMediana.Location = new System.Drawing.Point(333, 350);
            this.btnMediana.Name = "btnMediana";
            this.btnMediana.Size = new System.Drawing.Size(308, 88);
            this.btnMediana.TabIndex = 4;
            this.btnMediana.Text = "Mediana";
            this.btnMediana.UseVisualStyleBackColor = true;
            this.btnMediana.Click += new System.EventHandler(this.btnMediana_Click);
            // 
            // btnVariancia
            // 
            this.btnVariancia.Location = new System.Drawing.Point(12, 444);
            this.btnVariancia.Name = "btnVariancia";
            this.btnVariancia.Size = new System.Drawing.Size(308, 88);
            this.btnVariancia.TabIndex = 5;
            this.btnVariancia.Text = "Variância";
            this.btnVariancia.UseVisualStyleBackColor = true;
            this.btnVariancia.Click += new System.EventHandler(this.btnVariancia_Click);
            // 
            // btnDesvio
            // 
            this.btnDesvio.Location = new System.Drawing.Point(333, 444);
            this.btnDesvio.Name = "btnDesvio";
            this.btnDesvio.Size = new System.Drawing.Size(308, 88);
            this.btnDesvio.TabIndex = 6;
            this.btnDesvio.Text = "Desvio padrão";
            this.btnDesvio.UseVisualStyleBackColor = true;
            this.btnDesvio.Click += new System.EventHandler(this.btnDesvio_Click);
            // 
            // btnCoeficiente
            // 
            this.btnCoeficiente.Location = new System.Drawing.Point(12, 538);
            this.btnCoeficiente.Name = "btnCoeficiente";
            this.btnCoeficiente.Size = new System.Drawing.Size(308, 88);
            this.btnCoeficiente.TabIndex = 7;
            this.btnCoeficiente.Text = "Coeficiente da variação";
            this.btnCoeficiente.UseVisualStyleBackColor = true;
            this.btnCoeficiente.Click += new System.EventHandler(this.btnCoeficiente_Click);
            // 
            // btnConjunto
            // 
            this.btnConjunto.Location = new System.Drawing.Point(333, 538);
            this.btnConjunto.Name = "btnConjunto";
            this.btnConjunto.Size = new System.Drawing.Size(308, 88);
            this.btnConjunto.TabIndex = 8;
            this.btnConjunto.Text = "Determinar conjunto";
            this.btnConjunto.UseVisualStyleBackColor = true;
            this.btnConjunto.Click += new System.EventHandler(this.btnConjunto_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(566, 16);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 645);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnConjunto);
            this.Controls.Add(this.btnCoeficiente);
            this.Controls.Add(this.btnDesvio);
            this.Controls.Add(this.btnVariancia);
            this.Controls.Add(this.btnMediana);
            this.Controls.Add(this.btnMedia);
            this.Controls.Add(this.dataNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataNumero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataNumero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Peso;
        private System.Windows.Forms.Button btnMedia;
        private System.Windows.Forms.Button btnMediana;
        private System.Windows.Forms.Button btnVariancia;
        private System.Windows.Forms.Button btnDesvio;
        private System.Windows.Forms.Button btnCoeficiente;
        private System.Windows.Forms.Button btnConjunto;
        private System.Windows.Forms.Button btnLimpar;
    }
}

