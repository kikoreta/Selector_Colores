namespace Selector_Colores.Formularios
{

    internal sealed partial class Degradado
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
            this.TbColorInicial = new System.Windows.Forms.TextBox();
            this.LblInicio = new System.Windows.Forms.Label();
            this.TbColorFinal = new System.Windows.Forms.TextBox();
            this.LblColorFinal = new System.Windows.Forms.Label();
            this.LvColores = new System.Windows.Forms.ListView();
            this.ColHColor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHRGBA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ColHHex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NumCantidadColores = new System.Windows.Forms.NumericUpDown();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.BtnDegradado = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadColores)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbColorInicial
            // 
            this.TbColorInicial.Location = new System.Drawing.Point(8, 24);
            this.TbColorInicial.MaxLength = 9;
            this.TbColorInicial.Name = "TbColorInicial";
            this.TbColorInicial.Size = new System.Drawing.Size(80, 20);
            this.TbColorInicial.TabIndex = 0;
            this.TbColorInicial.DoubleClick += new System.EventHandler(this.TbColorInicial_DoubleClick);
            // 
            // LblInicio
            // 
            this.LblInicio.AutoSize = true;
            this.LblInicio.Location = new System.Drawing.Point(8, 8);
            this.LblInicio.Name = "LblInicio";
            this.LblInicio.Size = new System.Drawing.Size(74, 13);
            this.LblInicio.TabIndex = 1;
            this.LblInicio.Text = "Color Inicial: #";
            // 
            // TbColorFinal
            // 
            this.TbColorFinal.Location = new System.Drawing.Point(8, 24);
            this.TbColorFinal.MaxLength = 9;
            this.TbColorFinal.Name = "TbColorFinal";
            this.TbColorFinal.Size = new System.Drawing.Size(80, 20);
            this.TbColorFinal.TabIndex = 0;
            this.TbColorFinal.DoubleClick += new System.EventHandler(this.TbColorFinal_DoubleClick);
            // 
            // LblColorFinal
            // 
            this.LblColorFinal.AutoSize = true;
            this.LblColorFinal.Location = new System.Drawing.Point(8, 8);
            this.LblColorFinal.Name = "LblColorFinal";
            this.LblColorFinal.Size = new System.Drawing.Size(69, 13);
            this.LblColorFinal.TabIndex = 1;
            this.LblColorFinal.Text = "Color Final: #";
            // 
            // LvColores
            // 
            this.LvColores.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColHColor,
            this.ColHRGBA,
            this.ColHHex});
            this.LvColores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LvColores.FullRowSelect = true;
            this.LvColores.GridLines = true;
            this.LvColores.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.LvColores.HideSelection = false;
            this.LvColores.LabelWrap = false;
            this.LvColores.Location = new System.Drawing.Point(8, 64);
            this.LvColores.Name = "LvColores";
            this.LvColores.OwnerDraw = true;
            this.LvColores.Size = new System.Drawing.Size(264, 216);
            this.LvColores.TabIndex = 2;
            this.LvColores.UseCompatibleStateImageBehavior = false;
            this.LvColores.View = System.Windows.Forms.View.Details;
            this.LvColores.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.LvColores_DrawColumnHeader);
            this.LvColores.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.LvColores_DrawSubItem);
            // 
            // ColHColor
            // 
            this.ColHColor.Text = "Color";
            // 
            // ColHRGBA
            // 
            this.ColHRGBA.Text = "RGBA";
            this.ColHRGBA.Width = 108;
            // 
            // ColHHex
            // 
            this.ColHHex.Text = "Hex";
            this.ColHHex.Width = 89;
            // 
            // NumCantidadColores
            // 
            this.NumCantidadColores.Location = new System.Drawing.Point(8, 24);
            this.NumCantidadColores.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.NumCantidadColores.Name = "NumCantidadColores";
            this.NumCantidadColores.Size = new System.Drawing.Size(48, 20);
            this.NumCantidadColores.TabIndex = 3;
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Location = new System.Drawing.Point(8, 8);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(52, 13);
            this.LblCantidad.TabIndex = 4;
            this.LblCantidad.Text = "Cantidad:";
            // 
            // BtnDegradado
            // 
            this.BtnDegradado.Location = new System.Drawing.Point(8, 288);
            this.BtnDegradado.Name = "BtnDegradado";
            this.BtnDegradado.Size = new System.Drawing.Size(264, 24);
            this.BtnDegradado.TabIndex = 5;
            this.BtnDegradado.Text = "Formar Degradado";
            this.BtnDegradado.UseVisualStyleBackColor = true;
            this.BtnDegradado.Click += new System.EventHandler(this.BtnDegradado_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Location = new System.Drawing.Point(8, 320);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(264, 24);
            this.BtnAgregar.TabIndex = 6;
            this.BtnAgregar.Text = "Agregar Seleccionados";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LblInicio);
            this.panel1.Controls.Add(this.TbColorInicial);
            this.panel1.Location = new System.Drawing.Point(8, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(96, 48);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblColorFinal);
            this.panel2.Controls.Add(this.TbColorFinal);
            this.panel2.Location = new System.Drawing.Point(112, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(96, 48);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.LblCantidad);
            this.panel3.Controls.Add(this.NumCantidadColores);
            this.panel3.Location = new System.Drawing.Point(216, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(64, 48);
            this.panel3.TabIndex = 9;
            // 
            // Degradado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 353);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnDegradado);
            this.Controls.Add(this.LvColores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Degradado";
            this.Text = "Degradado";
            ((System.ComponentModel.ISupportInitialize)(this.NumCantidadColores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox TbColorInicial;
        private System.Windows.Forms.Label LblInicio;
        private System.Windows.Forms.TextBox TbColorFinal;
        private System.Windows.Forms.Label LblColorFinal;
        private System.Windows.Forms.ListView LvColores;
        private System.Windows.Forms.ColumnHeader ColHRGBA;
        private System.Windows.Forms.ColumnHeader ColHColor;
        private System.Windows.Forms.NumericUpDown NumCantidadColores;
        private System.Windows.Forms.Label LblCantidad;
        private System.Windows.Forms.Button BtnDegradado;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.ColumnHeader ColHHex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}