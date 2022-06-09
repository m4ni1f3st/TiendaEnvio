namespace TiendaEnvio
{
    partial class frmTienda
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
            this.label1 = new System.Windows.Forms.Label();
            this.gridProductos = new System.Windows.Forms.DataGridView();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKilometros = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtExistencias = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtEUR = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un producto a enviar:";
            // 
            // gridProductos
            // 
            this.gridProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProductos.Location = new System.Drawing.Point(52, 49);
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(433, 205);
            this.gridProductos.TabIndex = 1;
            this.gridProductos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProductos_CellClick);
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(651, 17);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.ReadOnly = true;
            this.txtDolar.Size = new System.Drawing.Size(100, 20);
            this.txtDolar.TabIndex = 2;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(595, 323);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(676, 323);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(523, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Precio del dólar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Producto seleccionado: ";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(651, 74);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(100, 20);
            this.txtProducto.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kilometros a recorrer:";
            // 
            // txtKilometros
            // 
            this.txtKilometros.Location = new System.Drawing.Point(651, 150);
            this.txtKilometros.Name = "txtKilometros";
            this.txtKilometros.Size = new System.Drawing.Size(100, 20);
            this.txtKilometros.TabIndex = 8;
            this.txtKilometros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(523, 192);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subtotal:";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(651, 189);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(523, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(651, 225);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(523, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Existencias:";
            // 
            // txtExistencias
            // 
            this.txtExistencias.Location = new System.Drawing.Point(651, 111);
            this.txtExistencias.Name = "txtExistencias";
            this.txtExistencias.Size = new System.Drawing.Size(100, 20);
            this.txtExistencias.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(523, 262);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Total USD:";
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(651, 259);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.ReadOnly = true;
            this.txtUSD.Size = new System.Drawing.Size(100, 20);
            this.txtUSD.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(523, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total EUR:";
            // 
            // txtEUR
            // 
            this.txtEUR.Location = new System.Drawing.Point(651, 289);
            this.txtEUR.Name = "txtEUR";
            this.txtEUR.ReadOnly = true;
            this.txtEUR.Size = new System.Drawing.Size(100, 20);
            this.txtEUR.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(525, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Precio del euro:";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(651, 43);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(100, 20);
            this.txtE.TabIndex = 20;
            // 
            // frmTienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 358);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtEUR);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtExistencias);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKilometros);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.gridProductos);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmTienda";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Envios";
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gridProductos;
        private System.Windows.Forms.TextBox txtDolar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKilometros;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtExistencias;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtEUR;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtE;
    }
}

