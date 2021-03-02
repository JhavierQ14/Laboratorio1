
namespace LaboratorioProgramacionUno.Vista
{
    partial class FrmOperaciones
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblMostrarUser = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMostrarIva = new System.Windows.Forms.Label();
            this.lblNproducto = new System.Windows.Forms.Label();
            this.lblPproducto = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtIva = new System.Windows.Forms.TextBox();
            this.txtNproducto = new System.Windows.Forms.TextBox();
            this.txtPproducto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTsinIva = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIvaAgregar = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotalIniacial = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblTotalFinal = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABLA DE DESCUENTOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(587, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario actual";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblMostrarUser
            // 
            this.lblMostrarUser.AutoSize = true;
            this.lblMostrarUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarUser.Location = new System.Drawing.Point(776, 46);
            this.lblMostrarUser.Name = "lblMostrarUser";
            this.lblMostrarUser.Size = new System.Drawing.Size(0, 20);
            this.lblMostrarUser.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(39, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(807, 125);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ACCION";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "REGLA";
            this.Column2.Name = "Column2";
            // 
            // lblMostrarIva
            // 
            this.lblMostrarIva.AutoSize = true;
            this.lblMostrarIva.Location = new System.Drawing.Point(36, 293);
            this.lblMostrarIva.Name = "lblMostrarIva";
            this.lblMostrarIva.Size = new System.Drawing.Size(22, 13);
            this.lblMostrarIva.TabIndex = 4;
            this.lblMostrarIva.Text = "Iva";
            // 
            // lblNproducto
            // 
            this.lblNproducto.AutoSize = true;
            this.lblNproducto.Location = new System.Drawing.Point(36, 340);
            this.lblNproducto.Name = "lblNproducto";
            this.lblNproducto.Size = new System.Drawing.Size(117, 13);
            this.lblNproducto.TabIndex = 5;
            this.lblNproducto.Text = "Nombre del el producto";
            // 
            // lblPproducto
            // 
            this.lblPproducto.AutoSize = true;
            this.lblPproducto.Location = new System.Drawing.Point(36, 390);
            this.lblPproducto.Name = "lblPproducto";
            this.lblPproducto.Size = new System.Drawing.Size(99, 13);
            this.lblPproducto.TabIndex = 6;
            this.lblPproducto.Text = "Precio del producto";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(36, 443);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtIva
            // 
            this.txtIva.Location = new System.Drawing.Point(197, 290);
            this.txtIva.Name = "txtIva";
            this.txtIva.Size = new System.Drawing.Size(171, 20);
            this.txtIva.TabIndex = 8;
            // 
            // txtNproducto
            // 
            this.txtNproducto.Location = new System.Drawing.Point(197, 340);
            this.txtNproducto.Name = "txtNproducto";
            this.txtNproducto.Size = new System.Drawing.Size(171, 20);
            this.txtNproducto.TabIndex = 9;
            // 
            // txtPproducto
            // 
            this.txtPproducto.Location = new System.Drawing.Point(197, 387);
            this.txtPproducto.Name = "txtPproducto";
            this.txtPproducto.Size = new System.Drawing.Size(171, 20);
            this.txtPproducto.TabIndex = 10;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(197, 436);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(171, 20);
            this.txtCantidad.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(588, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Producto";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Location = new System.Drawing.Point(730, 273);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(0, 13);
            this.lblNombreProducto.TabIndex = 13;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(506, 340);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Total sin iva :";
            // 
            // lblTsinIva
            // 
            this.lblTsinIva.AutoSize = true;
            this.lblTsinIva.Location = new System.Drawing.Point(774, 340);
            this.lblTsinIva.Name = "lblTsinIva";
            this.lblTsinIva.Size = new System.Drawing.Size(0, 13);
            this.lblTsinIva.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(506, 374);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Iva a agregar :";
            // 
            // lblIvaAgregar
            // 
            this.lblIvaAgregar.AutoSize = true;
            this.lblIvaAgregar.Location = new System.Drawing.Point(774, 374);
            this.lblIvaAgregar.Name = "lblIvaAgregar";
            this.lblIvaAgregar.Size = new System.Drawing.Size(0, 13);
            this.lblIvaAgregar.TabIndex = 17;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(506, 413);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(192, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Total sin descuento y con Iva incluido :";
            // 
            // lblTotalIniacial
            // 
            this.lblTotalIniacial.AutoSize = true;
            this.lblTotalIniacial.Location = new System.Drawing.Point(774, 413);
            this.lblTotalIniacial.Name = "lblTotalIniacial";
            this.lblTotalIniacial.Size = new System.Drawing.Size(0, 13);
            this.lblTotalIniacial.TabIndex = 19;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(506, 452);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(76, 13);
            this.label16.TabIndex = 20;
            this.label16.Text = "Total a pagar :";
            // 
            // lblTotalFinal
            // 
            this.lblTotalFinal.AutoSize = true;
            this.lblTotalFinal.Location = new System.Drawing.Point(774, 452);
            this.lblTotalFinal.Name = "lblTotalFinal";
            this.lblTotalFinal.Size = new System.Drawing.Size(0, 13);
            this.lblTotalFinal.TabIndex = 21;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(237, 482);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 22;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // FrmOperaciones
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 535);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotalFinal);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lblTotalIniacial);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblIvaAgregar);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lblTsinIva);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblNombreProducto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtPproducto);
            this.Controls.Add(this.txtNproducto);
            this.Controls.Add(this.txtIva);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblPproducto);
            this.Controls.Add(this.lblNproducto);
            this.Controls.Add(this.lblMostrarIva);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblMostrarUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmOperaciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOperaciones";
            this.Load += new System.EventHandler(this.FrmOperaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMostrarUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblMostrarIva;
        private System.Windows.Forms.Label lblNproducto;
        private System.Windows.Forms.Label lblPproducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtPproducto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblNombreProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTsinIva;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblIvaAgregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotalIniacial;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblTotalFinal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        public System.Windows.Forms.TextBox txtIva;
        public System.Windows.Forms.TextBox txtNproducto;
    }
}