namespace Tercera_Tarea_Prog_3
{
    partial class BuscarCargos
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
            this.dtbuscarempleado = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btncerrar1 = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtbuscarempleado)).BeginInit();
            this.SuspendLayout();
            // 
            // dtbuscarempleado
            // 
            this.dtbuscarempleado.AllowUserToAddRows = false;
            this.dtbuscarempleado.AllowUserToDeleteRows = false;
            this.dtbuscarempleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtbuscarempleado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Descripcion});
            this.dtbuscarempleado.Location = new System.Drawing.Point(12, 12);
            this.dtbuscarempleado.Name = "dtbuscarempleado";
            this.dtbuscarempleado.ReadOnly = true;
            this.dtbuscarempleado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtbuscarempleado.Size = new System.Drawing.Size(397, 242);
            this.dtbuscarempleado.TabIndex = 0;
            this.dtbuscarempleado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbuscarempleado_CellContentClick);
            this.dtbuscarempleado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtbuscarempleado_CellDoubleClick);
            // 
            // Cod
            // 
            this.Cod.DataPropertyName = "cod_cargo";
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 250;
            // 
            // btncerrar1
            // 
            this.btncerrar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncerrar1.Location = new System.Drawing.Point(209, 260);
            this.btncerrar1.Name = "btncerrar1";
            this.btncerrar1.Size = new System.Drawing.Size(75, 23);
            this.btncerrar1.TabIndex = 4;
            this.btncerrar1.Text = "Cerrar";
            this.btncerrar1.UseVisualStyleBackColor = true;
            this.btncerrar1.Click += new System.EventHandler(this.btncerrar1_Click);
            // 
            // btnaceptar
            // 
            this.btnaceptar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnaceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaceptar.Location = new System.Drawing.Point(105, 260);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 3;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // BuscarCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(420, 306);
            this.Controls.Add(this.btncerrar1);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.dtbuscarempleado);
            this.Name = "BuscarCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BuscarCargos";
            this.Load += new System.EventHandler(this.BuscarCargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtbuscarempleado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtbuscarempleado;
        private System.Windows.Forms.Button btncerrar1;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
    }
}