namespace PruebaTecnica
{
    partial class Pedidos
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
            this.lblCodCliente = new System.Windows.Forms.Label();
            this.codCliente = new System.Windows.Forms.TextBox();
            this.nombreCliente = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.nombreVendedor = new System.Windows.Forms.TextBox();
            this.lblVendedor = new System.Windows.Forms.Label();
            this.lblFechaEntrega = new System.Windows.Forms.Label();
            this.lblFechaPedido = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CodArt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecUni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moneda = new System.Windows.Forms.ComboBox();
            this.lblMoneda = new System.Windows.Forms.Label();
            this.fechaPedido = new System.Windows.Forms.DateTimePicker();
            this.fechaEntrega = new System.Windows.Forms.TextBox();
            this.btnPedido = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCodCliente
            // 
            this.lblCodCliente.AutoSize = true;
            this.lblCodCliente.Location = new System.Drawing.Point(6, 31);
            this.lblCodCliente.Name = "lblCodCliente";
            this.lblCodCliente.Size = new System.Drawing.Size(95, 20);
            this.lblCodCliente.TabIndex = 1;
            this.lblCodCliente.Text = "Cod. Cliente";
            // 
            // codCliente
            // 
            this.codCliente.Location = new System.Drawing.Point(129, 28);
            this.codCliente.Name = "codCliente";
            this.codCliente.Size = new System.Drawing.Size(91, 26);
            this.codCliente.TabIndex = 2;
            this.codCliente.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombreCliente
            // 
            this.nombreCliente.Location = new System.Drawing.Point(129, 66);
            this.nombreCliente.Name = "nombreCliente";
            this.nombreCliente.Size = new System.Drawing.Size(494, 26);
            this.nombreCliente.TabIndex = 4;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(6, 69);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(118, 20);
            this.lblNombreCliente.TabIndex = 3;
            this.lblNombreCliente.Text = "Nombre Cliente";
            this.lblNombreCliente.Click += new System.EventHandler(this.label3_Click);
            // 
            // nombreVendedor
            // 
            this.nombreVendedor.Location = new System.Drawing.Point(129, 107);
            this.nombreVendedor.Name = "nombreVendedor";
            this.nombreVendedor.Size = new System.Drawing.Size(494, 26);
            this.nombreVendedor.TabIndex = 6;
            // 
            // lblVendedor
            // 
            this.lblVendedor.AutoSize = true;
            this.lblVendedor.Location = new System.Drawing.Point(6, 110);
            this.lblVendedor.Name = "lblVendedor";
            this.lblVendedor.Size = new System.Drawing.Size(79, 20);
            this.lblVendedor.TabIndex = 5;
            this.lblVendedor.Text = "Vendedor";
            // 
            // lblFechaEntrega
            // 
            this.lblFechaEntrega.AutoSize = true;
            this.lblFechaEntrega.Location = new System.Drawing.Point(632, 69);
            this.lblFechaEntrega.Name = "lblFechaEntrega";
            this.lblFechaEntrega.Size = new System.Drawing.Size(115, 20);
            this.lblFechaEntrega.TabIndex = 9;
            this.lblFechaEntrega.Text = "Fecha Entrega";
            // 
            // lblFechaPedido
            // 
            this.lblFechaPedido.AutoSize = true;
            this.lblFechaPedido.Location = new System.Drawing.Point(632, 28);
            this.lblFechaPedido.Name = "lblFechaPedido";
            this.lblFechaPedido.Size = new System.Drawing.Size(107, 20);
            this.lblFechaPedido.TabIndex = 7;
            this.lblFechaPedido.Text = "Fecha Pedido";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodArt,
            this.Description,
            this.Cantidad,
            this.PrecUni,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(17, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(870, 401);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CodArt
            // 
            this.CodArt.FillWeight = 50F;
            this.CodArt.HeaderText = "Código Artículo";
            this.CodArt.Name = "CodArt";
            this.CodArt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CodArt.Width = 150;
            // 
            // Description
            // 
            this.Description.FillWeight = 50F;
            this.Description.HeaderText = "Descripción";
            this.Description.Name = "Description";
            this.Description.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Description.Width = 280;
            // 
            // Cantidad
            // 
            this.Cantidad.FillWeight = 50F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecUni
            // 
            this.PrecUni.FillWeight = 50F;
            this.PrecUni.HeaderText = "Precio Unitario";
            this.PrecUni.Name = "PrecUni";
            this.PrecUni.Width = 150;
            // 
            // Total
            // 
            this.Total.FillWeight = 50F;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.Width = 150;
            // 
            // moneda
            // 
            this.moneda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.moneda.FormattingEnabled = true;
            this.moneda.Items.AddRange(new object[] {
            "USD",
            "PYG",
            "EUR"});
            this.moneda.Location = new System.Drawing.Point(753, 110);
            this.moneda.Name = "moneda";
            this.moneda.Size = new System.Drawing.Size(111, 28);
            this.moneda.TabIndex = 15;
            this.moneda.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // lblMoneda
            // 
            this.lblMoneda.AutoSize = true;
            this.lblMoneda.Location = new System.Drawing.Point(632, 113);
            this.lblMoneda.Name = "lblMoneda";
            this.lblMoneda.Size = new System.Drawing.Size(67, 20);
            this.lblMoneda.TabIndex = 14;
            this.lblMoneda.Text = "Moneda";
            this.lblMoneda.Click += new System.EventHandler(this.label7_Click);
            // 
            // fechaPedido
            // 
            this.fechaPedido.CustomFormat = "dd/MM/yyyy";
            this.fechaPedido.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaPedido.Location = new System.Drawing.Point(753, 26);
            this.fechaPedido.MinDate = new System.DateTime(2022, 5, 13, 0, 0, 0, 0);
            this.fechaPedido.Name = "fechaPedido";
            this.fechaPedido.Size = new System.Drawing.Size(111, 26);
            this.fechaPedido.TabIndex = 16;
            this.fechaPedido.Value = new System.DateTime(2022, 5, 13, 0, 0, 0, 0);
            // 
            // fechaEntrega
            // 
            this.fechaEntrega.Location = new System.Drawing.Point(753, 66);
            this.fechaEntrega.Name = "fechaEntrega";
            this.fechaEntrega.Size = new System.Drawing.Size(111, 26);
            this.fechaEntrega.TabIndex = 17;
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(146, 576);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(741, 55);
            this.btnPedido.TabIndex = 18;
            this.btnPedido.Text = "Realizar Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCodCliente);
            this.groupBox1.Controls.Add(this.codCliente);
            this.groupBox1.Controls.Add(this.fechaEntrega);
            this.groupBox1.Controls.Add(this.lblNombreCliente);
            this.groupBox1.Controls.Add(this.fechaPedido);
            this.groupBox1.Controls.Add(this.nombreCliente);
            this.groupBox1.Controls.Add(this.moneda);
            this.groupBox1.Controls.Add(this.lblVendedor);
            this.groupBox1.Controls.Add(this.lblMoneda);
            this.groupBox1.Controls.Add(this.nombreVendedor);
            this.groupBox1.Controls.Add(this.lblFechaPedido);
            this.groupBox1.Controls.Add(this.lblFechaEntrega);
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 150);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // btnLista
            // 
            this.btnLista.Location = new System.Drawing.Point(17, 577);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(123, 54);
            this.btnLista.TabIndex = 20;
            this.btnLista.Text = "Pedir Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(908, 638);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.dataGridView1);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Pedidos";
            this.Text = "Pedidos Sucursal N";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblCodCliente;
        private System.Windows.Forms.TextBox codCliente;
        private System.Windows.Forms.TextBox nombreCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.TextBox nombreVendedor;
        private System.Windows.Forms.Label lblVendedor;
        private System.Windows.Forms.Label lblFechaEntrega;
        private System.Windows.Forms.Label lblFechaPedido;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox moneda;
        private System.Windows.Forms.Label lblMoneda;
        private System.Windows.Forms.DateTimePicker fechaPedido;
        private System.Windows.Forms.TextBox fechaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodArt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecUni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnLista;
    }
}

