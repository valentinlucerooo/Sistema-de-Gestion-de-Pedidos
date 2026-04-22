namespace UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            btnAgregarPedido = new Button();
            dgvPedidos = new DataGridView();
            cmbProducto = new ComboBox();
            txtCantidad = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            cmbEnvio = new ComboBox();
            txtPrioridad = new MaskedTextBox();
            gbEnvio = new GroupBox();
            txtPrecioE = new MaskedTextBox();
            Precio = new Label();
            btnVE = new Button();
            btnNuevoEnvio = new Button();
            btrnValidarBE = new Button();
            txtZonaE = new MaskedTextBox();
            label11 = new Label();
            gbProducto = new GroupBox();
            txtPrecioP = new MaskedTextBox();
            label7 = new Label();
            BtnVP = new Button();
            btnBP = new Button();
            txtDescripcionP = new MaskedTextBox();
            label13 = new Label();
            btnNuevoProducto = new Button();
            txtTipoProducto = new MaskedTextBox();
            label12 = new Label();
            btnAgregarProducto = new Button();
            btnAgregarEnvio = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            label9 = new Label();
            label10 = new Label();
            btnAgregarB = new Button();
            btnValidarB = new Button();
            btnEditar = new Button();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            gbEnvio.SuspendLayout();
            gbProducto.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label1.Location = new Point(58, 89);
            label1.Name = "label1";
            label1.Size = new Size(85, 22);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // btnAgregarPedido
            // 
            btnAgregarPedido.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnAgregarPedido.Location = new Point(59, 466);
            btnAgregarPedido.Name = "btnAgregarPedido";
            btnAgregarPedido.Size = new Size(222, 56);
            btnAgregarPedido.TabIndex = 1;
            btnAgregarPedido.Text = "Agregar Pedido";
            btnAgregarPedido.UseVisualStyleBackColor = true;
            btnAgregarPedido.Click += btnAgregarPedido_Click;
            // 
            // dgvPedidos
            // 
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Location = new Point(303, 89);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(703, 312);
            dgvPedidos.TabIndex = 2;
            dgvPedidos.CellContentClick += dgvPedidos_CellContentClick;
            // 
            // cmbProducto
            // 
            cmbProducto.FormattingEnabled = true;
            cmbProducto.Location = new Point(58, 132);
            cmbProducto.Name = "cmbProducto";
            cmbProducto.Size = new Size(222, 28);
            cmbProducto.TabIndex = 3;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(58, 219);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(222, 27);
            txtCantidad.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label2.Location = new Point(58, 178);
            label2.Name = "label2";
            label2.Size = new Size(87, 22);
            label2.TabIndex = 6;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(102, 18);
            label3.Name = "label3";
            label3.Size = new Size(373, 32);
            label3.TabIndex = 7;
            label3.Text = "Sistema Gestion de Pedidos";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label4.Location = new Point(58, 267);
            label4.Name = "label4";
            label4.Size = new Size(57, 22);
            label4.TabIndex = 8;
            label4.Text = "Envio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label6.Location = new Point(59, 354);
            label6.Name = "label6";
            label6.Size = new Size(86, 22);
            label6.TabIndex = 10;
            label6.Text = "Prioridad";
            // 
            // cmbEnvio
            // 
            cmbEnvio.FormattingEnabled = true;
            cmbEnvio.Location = new Point(58, 307);
            cmbEnvio.Name = "cmbEnvio";
            cmbEnvio.Size = new Size(222, 28);
            cmbEnvio.TabIndex = 11;
            // 
            // txtPrioridad
            // 
            txtPrioridad.Location = new Point(59, 390);
            txtPrioridad.Name = "txtPrioridad";
            txtPrioridad.Size = new Size(222, 27);
            txtPrioridad.TabIndex = 12;
            // 
            // gbEnvio
            // 
            gbEnvio.BackColor = SystemColors.AppWorkspace;
            gbEnvio.Controls.Add(txtPrecioE);
            gbEnvio.Controls.Add(Precio);
            gbEnvio.Controls.Add(btnVE);
            gbEnvio.Controls.Add(btnNuevoEnvio);
            gbEnvio.Controls.Add(btrnValidarBE);
            gbEnvio.Controls.Add(txtZonaE);
            gbEnvio.Controls.Add(label11);
            gbEnvio.Font = new Font("MS Reference Sans Serif", 10.8F);
            gbEnvio.Location = new Point(1031, 89);
            gbEnvio.Name = "gbEnvio";
            gbEnvio.Size = new Size(354, 343);
            gbEnvio.TabIndex = 13;
            gbEnvio.TabStop = false;
            gbEnvio.Text = "Nuevo Envio";
            // 
            // txtPrecioE
            // 
            txtPrecioE.Location = new Point(6, 153);
            txtPrecioE.Name = "txtPrecioE";
            txtPrecioE.Size = new Size(222, 29);
            txtPrecioE.TabIndex = 36;
            // 
            // Precio
            // 
            Precio.AutoSize = true;
            Precio.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            Precio.Location = new Point(6, 117);
            Precio.Name = "Precio";
            Precio.Size = new Size(67, 22);
            Precio.TabIndex = 35;
            Precio.Text = "Precio ";
            // 
            // btnVE
            // 
            btnVE.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnVE.Location = new Point(53, 296);
            btnVE.Name = "btnVE";
            btnVE.Size = new Size(257, 38);
            btnVE.TabIndex = 34;
            btnVE.Text = "Confirmar Borrador";
            btnVE.UseVisualStyleBackColor = true;
            btnVE.Click += btnVE_Click;
            // 
            // btnNuevoEnvio
            // 
            btnNuevoEnvio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnNuevoEnvio.Location = new Point(67, 206);
            btnNuevoEnvio.Name = "btnNuevoEnvio";
            btnNuevoEnvio.Size = new Size(224, 38);
            btnNuevoEnvio.TabIndex = 25;
            btnNuevoEnvio.Text = "Agregar Nuevo Envio";
            btnNuevoEnvio.UseVisualStyleBackColor = true;
            btnNuevoEnvio.Click += btnNuevoEnvio_Click;
            // 
            // btrnValidarBE
            // 
            btrnValidarBE.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btrnValidarBE.Location = new Point(53, 250);
            btrnValidarBE.Name = "btrnValidarBE";
            btrnValidarBE.Size = new Size(257, 38);
            btrnValidarBE.TabIndex = 33;
            btrnValidarBE.Text = "Agregar a Borrador";
            btrnValidarBE.UseVisualStyleBackColor = true;
            btrnValidarBE.Click += button4_Click;
            // 
            // txtZonaE
            // 
            txtZonaE.Location = new Point(6, 77);
            txtZonaE.Name = "txtZonaE";
            txtZonaE.Size = new Size(222, 29);
            txtZonaE.TabIndex = 26;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label11.Location = new Point(6, 41);
            label11.Name = "label11";
            label11.Size = new Size(53, 22);
            label11.TabIndex = 25;
            label11.Text = "Zona";
            // 
            // gbProducto
            // 
            gbProducto.BackColor = SystemColors.AppWorkspace;
            gbProducto.Controls.Add(txtPrecioP);
            gbProducto.Controls.Add(label7);
            gbProducto.Controls.Add(BtnVP);
            gbProducto.Controls.Add(btnBP);
            gbProducto.Controls.Add(txtDescripcionP);
            gbProducto.Controls.Add(label13);
            gbProducto.Controls.Add(btnNuevoProducto);
            gbProducto.Controls.Add(txtTipoProducto);
            gbProducto.Controls.Add(label12);
            gbProducto.Font = new Font("MS Reference Sans Serif", 10.8F);
            gbProducto.Location = new Point(1031, 339);
            gbProducto.Name = "gbProducto";
            gbProducto.Size = new Size(354, 431);
            gbProducto.TabIndex = 14;
            gbProducto.TabStop = false;
            gbProducto.Text = "Nuevo Producto";
            // 
            // txtPrecioP
            // 
            txtPrecioP.Location = new Point(6, 220);
            txtPrecioP.Name = "txtPrecioP";
            txtPrecioP.Size = new Size(222, 29);
            txtPrecioP.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label7.Location = new Point(6, 187);
            label7.Name = "label7";
            label7.Size = new Size(61, 22);
            label7.TabIndex = 33;
            label7.Text = "Precio";
            // 
            // BtnVP
            // 
            BtnVP.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            BtnVP.Location = new Point(59, 384);
            BtnVP.Name = "BtnVP";
            BtnVP.Size = new Size(257, 38);
            BtnVP.TabIndex = 32;
            BtnVP.Text = "Confirmar Borrador";
            BtnVP.UseVisualStyleBackColor = true;
            BtnVP.Click += BtnVP_Click;
            // 
            // btnBP
            // 
            btnBP.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnBP.Location = new Point(59, 338);
            btnBP.Name = "btnBP";
            btnBP.Size = new Size(257, 38);
            btnBP.TabIndex = 31;
            btnBP.Text = "Agregar a Borrador";
            btnBP.UseVisualStyleBackColor = true;
            btnBP.Click += btnBP_Click;
            // 
            // txtDescripcionP
            // 
            txtDescripcionP.Location = new Point(6, 146);
            txtDescripcionP.Name = "txtDescripcionP";
            txtDescripcionP.Size = new Size(222, 29);
            txtDescripcionP.TabIndex = 30;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label13.Location = new Point(6, 113);
            label13.Name = "label13";
            label13.Size = new Size(109, 22);
            label13.TabIndex = 29;
            label13.Text = "Descripcion";
            // 
            // btnNuevoProducto
            // 
            btnNuevoProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnNuevoProducto.Location = new Point(59, 274);
            btnNuevoProducto.Name = "btnNuevoProducto";
            btnNuevoProducto.Size = new Size(257, 38);
            btnNuevoProducto.TabIndex = 27;
            btnNuevoProducto.Text = "Agregar Nuevo Producto";
            btnNuevoProducto.UseVisualStyleBackColor = true;
            btnNuevoProducto.Click += btnNuevoProducto_Click;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.ForeColor = SystemColors.InactiveCaption;
            txtTipoProducto.Location = new Point(6, 76);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new Size(222, 29);
            txtTipoProducto.TabIndex = 28;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("MS Reference Sans Serif", 10.2F, FontStyle.Italic);
            label12.Location = new Point(6, 41);
            label12.Name = "label12";
            label12.Size = new Size(154, 22);
            label12.TabIndex = 27;
            label12.Text = "Tipo de Producto";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnAgregarProducto.Location = new Point(343, 623);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(222, 56);
            btnAgregarProducto.TabIndex = 15;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // btnAgregarEnvio
            // 
            btnAgregarEnvio.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnAgregarEnvio.Location = new Point(644, 623);
            btnAgregarEnvio.Name = "btnAgregarEnvio";
            btnAgregarEnvio.Size = new Size(222, 56);
            btnAgregarEnvio.TabIndex = 16;
            btnAgregarEnvio.Text = "Agregar Envio";
            btnAgregarEnvio.UseVisualStyleBackColor = true;
            btnAgregarEnvio.Click += btnAgregarEnvio_Click;
            // 
            // btnModificar
            // 
            btnModificar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnModificar.Location = new Point(343, 459);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(222, 56);
            btnModificar.TabIndex = 17;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            btnModificar.Click += btnModificar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnEliminar.Location = new Point(644, 469);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(222, 56);
            btnEliminar.TabIndex = 18;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.Location = new Point(393, 415);
            label9.Name = "label9";
            label9.Size = new Size(130, 32);
            label9.TabIndex = 23;
            label9.Text = "Modificar";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label10.Location = new Point(695, 415);
            label10.Name = "label10";
            label10.Size = new Size(118, 32);
            label10.TabIndex = 24;
            label10.Text = "Eliminar";
            // 
            // btnAgregarB
            // 
            btnAgregarB.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnAgregarB.Location = new Point(59, 541);
            btnAgregarB.Name = "btnAgregarB";
            btnAgregarB.Size = new Size(222, 42);
            btnAgregarB.TabIndex = 25;
            btnAgregarB.Text = "Agregar Borrador";
            btnAgregarB.UseVisualStyleBackColor = true;
            btnAgregarB.Click += btnAgregarB_Click;
            // 
            // btnValidarB
            // 
            btnValidarB.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnValidarB.Location = new Point(59, 594);
            btnValidarB.Name = "btnValidarB";
            btnValidarB.Size = new Size(222, 42);
            btnValidarB.TabIndex = 26;
            btnValidarB.Text = "validar Borrador";
            btnValidarB.UseVisualStyleBackColor = true;
            btnValidarB.Click += btnValidarB_Click;
            // 
            // btnEditar
            // 
            btnEditar.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Italic);
            btnEditar.Location = new Point(343, 535);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(222, 56);
            btnEditar.TabIndex = 27;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(393, 705);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(374, 56);
            btnSalir.TabIndex = 28;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1406, 781);
            Controls.Add(btnSalir);
            Controls.Add(btnEditar);
            Controls.Add(btnValidarB);
            Controls.Add(btnAgregarB);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(btnEliminar);
            Controls.Add(gbProducto);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregarEnvio);
            Controls.Add(btnAgregarProducto);
            Controls.Add(gbEnvio);
            Controls.Add(txtPrioridad);
            Controls.Add(cmbEnvio);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtCantidad);
            Controls.Add(cmbProducto);
            Controls.Add(dgvPedidos);
            Controls.Add(btnAgregarPedido);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            gbEnvio.ResumeLayout(false);
            gbEnvio.PerformLayout();
            gbProducto.ResumeLayout(false);
            gbProducto.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAgregarPedido;
        private DataGridView dgvPedidos;
        private ComboBox cmbProducto;
        private TextBox txtCantidad;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private ComboBox cmbEnvio;
        private MaskedTextBox txtPrioridad;
        private GroupBox gbEnvio;
        private GroupBox gbProducto;
        private Button btnAgregarProducto;
        private Button btnAgregarEnvio;
        private Button btnModificar;
        private Button btnEliminar;
        private MaskedTextBox txtTipoProducto;
        private Label label12;
        private MaskedTextBox txtZonaE;
        private Label label11;
        private Label label9;
        private Label label10;
        private Button btnNuevoEnvio;
        private Button btnNuevoProducto;
        private MaskedTextBox txtDescripcionP;
        private Label label13;
        private Button btnAgregarB;
        private Button btnValidarB;
        private Button btnVE;
        private Button btrnValidarBE;
        private Button BtnVP;
        private Button btnBP;
        private Button btnEditar;
        private Button btnSalir;
        private MaskedTextBox txtPrecioE;
        private Label Precio;
        private MaskedTextBox txtPrecioP;
        private Label label7;
    }
}
