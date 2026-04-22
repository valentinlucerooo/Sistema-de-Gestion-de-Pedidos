using BLL;
using DAL;
using ENTITYS;

namespace UI
{
    public partial class Form1 : Form
    {
        PedidoBLL pedidoBLL = new PedidoBLL();
        EnvioBLL envioBLL = new EnvioBLL();
        ProductoBLL productoBLL = new ProductoBLL();
        List<Producto> productos = new List<Producto>();
        List<Envio> envios = new List<Envio>();
        List<Pedido> pedidos = new List<Pedido>();
        int IDseleccionado = 0;
        public void Actualizar()
        {
            try
            {
                dgvPedidos.DataSource = null;
                dgvPedidos.DataSource = pedidoBLL.GetAll();
                gbProducto.Visible = false;
                gbEnvio.Visible = false;

                cmbProducto.DataSource = null;
                cmbProducto.DataSource = productoBLL.GetAllProductos();
                cmbProducto.DisplayMember = "Descripcion";
                cmbProducto.ValueMember = "IDProducto";

                cmbEnvio.DataSource = null;
                cmbEnvio.DataSource = envioBLL.GetAllEnvios();
                cmbEnvio.DisplayMember = "Zona";
                cmbEnvio.ValueMember = "IDEnvio";
            }
            catch
            {

            }


        }
        public Form1()
        {
            InitializeComponent();

        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            gbProducto.Visible = true;
            gbEnvio.Visible = false;
        }

        private void btnAgregarEnvio_Click(object sender, EventArgs e)
        {
            gbEnvio.Visible = true;
            gbProducto.Visible = false;
        }

        private void btnAgregarPedido_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nuevo = new Pedido();
                nuevo.Producto = new Producto();
                nuevo.Producto.IDProducto = Convert.ToInt32(cmbProducto.SelectedValue);
                nuevo.Producto.ProductoTipo = cmbProducto.Text;
                nuevo.Envio = new Envio();
                nuevo.Envio.IDEnvio = Convert.ToInt32(cmbEnvio.SelectedValue);
                nuevo.Envio.Zona = cmbEnvio.Text;
                nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevo.Prioridad = txtPrioridad.Text;
                pedidoBLL.ValidarPedido(nuevo);
                MessageBox.Show("Pedido agregado correctamente");
                Actualizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                Actualizar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnAgregarB_Click(object sender, EventArgs e)
        {
            try
            {
                Pedido nuevo = new Pedido();
                nuevo.Producto = new Producto();
                nuevo.Producto.IDProducto = Convert.ToInt32(cmbProducto.SelectedValue);
                nuevo.Producto.ProductoTipo = cmbProducto.Text;
                nuevo.Envio = new Envio();
                nuevo.Envio.IDEnvio = Convert.ToInt32(cmbEnvio.SelectedValue);
                nuevo.Envio.Zona = cmbEnvio.Text;
                nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevo.Prioridad = txtPrioridad.Text;
                pedidos.Add(nuevo);
                MessageBox.Show("Pedido agregado correctamente a la lista");
                Actualizar();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnValidarB_Click(object sender, EventArgs e)
        {
            try
            {
                pedidoBLL.ValidarBorrador(pedidos);
                MessageBox.Show("Borrador validado y guardado correctamente");
                Actualizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

            try
            {
                if (IDseleccionado == 0)
                {
                    MessageBox.Show("No se ha seleccionado ningún pedido para modificar.");
                    return;
                }
                Pedido nuevo = new Pedido();
                nuevo.IDpedido = IDseleccionado; // Asegúrate de tener esta variable definida y asignada correctamente
                nuevo.Producto = new Producto();
                nuevo.Producto.IDProducto = Convert.ToInt32(cmbProducto.SelectedValue);
                nuevo.Producto.ProductoTipo = cmbProducto.Text;
                nuevo.Envio = new Envio();
                nuevo.Envio.IDEnvio = Convert.ToInt32(cmbEnvio.SelectedValue);
                nuevo.Envio.Zona = cmbEnvio.Text;
                nuevo.Cantidad = Convert.ToInt32(txtCantidad.Text);
                nuevo.Prioridad = txtPrioridad.Text;
                nuevo.FechaRegistro = DateTime.Now; //  establecer la fecha de registro 
                pedidoBLL.ModificarPedido(nuevo);
                MessageBox.Show(" se modifico exitosamente el pedido seleccionado. ");
                IDseleccionado = 0; // Reiniciar el ID seleccionado después de modificar
                Actualizar();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPedidos.CurrentRow == null)
                return;
            Pedido elegido = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;
            MessageBox.Show("seleccionaste el pedido = " + elegido.IDpedido);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvPedidos.CurrentRow != null)
            {
                try
                {
                    Pedido elegido = (Pedido)dgvPedidos.CurrentRow.DataBoundItem; // Obtener el pedido seleccionado
                    cmbEnvio.SelectedValue = elegido.Envio.IDEnvio; // Establecer el valor seleccionado en el ComboBox de envío
                    cmbProducto.SelectedValue = elegido.Producto.IDProducto; // Establecer el valor seleccionado en el ComboBox de producto
                    txtCantidad.Text = elegido.Cantidad.ToString(); // Establecer la cantidad en el TextBox
                    txtPrioridad.Text = elegido.Prioridad; // Establecer la prioridad en el TextBox
                    IDseleccionado = elegido.IDpedido; // Guardar el ID del pedido seleccionado para futuras modificaciones
                }
                catch
                {
                    throw;
                }

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPedidos.CurrentRow != null)
                {
                    Pedido seleccionado = (Pedido)dgvPedidos.CurrentRow.DataBoundItem;
                    int eliminado = seleccionado.IDpedido;
                    pedidoBLL.BorrarPedido(eliminado);
                    Actualizar();
                    MessageBox.Show(" Pedido N " + eliminado + " fue eliminado correctamente. ");
                    IDseleccionado = 0; // Reiniciar el ID seleccionado después de eliminar
                }


            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnNuevoEnvio_Click(object sender, EventArgs e)
        {
            try
            {
                Envio nuevo = new Envio();
                nuevo.Zona = txtZonaE.Text;
                nuevo.Precio = Convert.ToDecimal(txtPrecioE.Text);
                envioBLL.ValidarEnvio(nuevo);
                MessageBox.Show("Envio agregado correctamente");
                Actualizar();
                gbEnvio.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)//agrega un envio a la lista de borrador
        {
            try
            {
                Envio nuevo = new Envio();
                nuevo.Zona = txtZonaE.Text;
                nuevo.Precio = Convert.ToDecimal(txtPrecioE.Text);
                envios.Add(nuevo);
                MessageBox.Show("Envio agregado correctamente a la lista de borrador");
                Actualizar();
                gbEnvio.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnVE_Click(object sender, EventArgs e)
        {
            try
            {
                envioBLL.ValidarLIstaEnvios(envios);
                MessageBox.Show("Borrador de envios validado correctamente");
                Actualizar();
                gbEnvio.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevo = new Producto();
                nuevo.ProductoTipo = txtTipoProducto.Text;
                nuevo.Descripcion = txtDescripcionP.Text;
                nuevo.Precio = Convert.ToDecimal(txtPrecioP.Text);
                productoBLL.ValidarProducto(nuevo);
                MessageBox.Show("Producto agregado correctamente");
                Actualizar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBP_Click(object sender, EventArgs e)
        {
            try
            {
                Producto nuevo = new Producto();
                nuevo.ProductoTipo = txtTipoProducto.Text;
                nuevo.Descripcion = txtDescripcionP.Text;
                nuevo.Precio = Convert.ToDecimal(txtPrecioP.Text);
                productos.Add(nuevo);
                MessageBox.Show("Producto agregado correctamente a la lista de borrador");
                Actualizar();
                gbProducto.Visible = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnVP_Click(object sender, EventArgs e)
        {
            try
            {
                productoBLL.ValidarListaPRoductos(productos);
                MessageBox.Show("lista de productos validado correctamente");
                Actualizar();
                gbProducto.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
