namespace WindowsFormsApp1
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
			this.btnBucaPeloId = new System.Windows.Forms.Button();
			this.btnGravaArquivo = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.lblId = new System.Windows.Forms.Label();
			this.btnBuscaTodos = new System.Windows.Forms.Button();
			this.dgvResultado = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
			this.SuspendLayout();
			// 
			// btnBucaPeloId
			// 
			this.btnBucaPeloId.Location = new System.Drawing.Point(559, 30);
			this.btnBucaPeloId.Name = "btnBucaPeloId";
			this.btnBucaPeloId.Size = new System.Drawing.Size(85, 23);
			this.btnBucaPeloId.TabIndex = 0;
			this.btnBucaPeloId.Text = "Busca pelo &Id";
			this.btnBucaPeloId.UseVisualStyleBackColor = true;
			this.btnBucaPeloId.Click += new System.EventHandler(this.btnBucaPeloId_Click);
			// 
			// btnGravaArquivo
			// 
			this.btnGravaArquivo.Location = new System.Drawing.Point(741, 30);
			this.btnGravaArquivo.Name = "btnGravaArquivo";
			this.btnGravaArquivo.Size = new System.Drawing.Size(85, 23);
			this.btnGravaArquivo.TabIndex = 1;
			this.btnGravaArquivo.Text = "&Grava Arquivo";
			this.btnGravaArquivo.UseVisualStyleBackColor = true;
			this.btnGravaArquivo.Click += new System.EventHandler(this.btnGravaArquivo_Click);
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(12, 30);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(150, 22);
			this.txtId.TabIndex = 2;
			this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
			// 
			// lblId
			// 
			this.lblId.AutoSize = true;
			this.lblId.Location = new System.Drawing.Point(12, 10);
			this.lblId.Name = "lblId";
			this.lblId.Size = new System.Drawing.Size(16, 13);
			this.lblId.TabIndex = 3;
			this.lblId.Text = "Id";
			// 
			// btnBuscaTodos
			// 
			this.btnBuscaTodos.Location = new System.Drawing.Point(650, 30);
			this.btnBuscaTodos.Name = "btnBuscaTodos";
			this.btnBuscaTodos.Size = new System.Drawing.Size(85, 23);
			this.btnBuscaTodos.TabIndex = 4;
			this.btnBuscaTodos.Text = "Busca &Todos";
			this.btnBuscaTodos.UseVisualStyleBackColor = true;
			this.btnBuscaTodos.Click += new System.EventHandler(this.btnBuscaTodos_Click);
			// 
			// dgvResultado
			// 
			this.dgvResultado.AllowUserToAddRows = false;
			this.dgvResultado.AllowUserToDeleteRows = false;
			this.dgvResultado.AllowUserToResizeColumns = false;
			this.dgvResultado.AllowUserToResizeRows = false;
			this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvResultado.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgvResultado.Location = new System.Drawing.Point(12, 70);
			this.dgvResultado.MultiSelect = false;
			this.dgvResultado.Name = "dgvResultado";
			this.dgvResultado.ReadOnly = true;
			this.dgvResultado.RowHeadersVisible = false;
			this.dgvResultado.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvResultado.Size = new System.Drawing.Size(817, 348);
			this.dgvResultado.TabIndex = 5;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(838, 430);
			this.Controls.Add(this.dgvResultado);
			this.Controls.Add(this.btnBuscaTodos);
			this.Controls.Add(this.lblId);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnGravaArquivo);
			this.Controls.Add(this.btnBucaPeloId);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnBucaPeloId;
		private System.Windows.Forms.Button btnGravaArquivo;
		private System.Windows.Forms.TextBox txtId;
		private System.Windows.Forms.Label lblId;
		private System.Windows.Forms.Button btnBuscaTodos;
		private System.Windows.Forms.DataGridView dgvResultado;
	}
}

