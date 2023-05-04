﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Carniceria_GUI
{
    /// <summary>
    /// Este formulario me permitirá que el Cliente
    /// pueda comprar uno o mas productos.
    /// </summary>
    public partial class FrmCompraCliente : Form
    {
        #region ATRIBUTOS
        private List<Carne> productosDisponibles;
        private Cliente clienteFormulario;
        private static Carne carneSeleccionada; 
        private Carrito carritoCliente;
        private double peso;
        private double totalDisponibleCliente;
        private Corte corteBuscado;

        #region DATAGRID
        DataTable _dataTable;
        DataRow auxFilaProduc;
        int indexTablaProductos;
        int codigoProducto;
        int indiceDetalle;
        #endregion

        #endregion

        #region CONSTRUCTOR
        /// <summary>
        /// Constructor parametrizado del Formulario, que
        /// me permite instanciar al cliente que recibo e
        /// instanciar la ayuda.
        /// </summary>
        /// <param name="cliente"></param>
        public FrmCompraCliente(Cliente cliente)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Comprar productos";

            _dataTable = new DataTable();
            this.lblClienteEmail.Text = cliente;
            clienteFormulario = cliente;//-->Paso los datos
            carneSeleccionada = new Carne();//-->Evito nulos
            carritoCliente = new Carrito();

            #region INSTANCIO PRODUCTOS
            productosDisponibles = new List<Carne>();
            productosDisponibles.Add(new Carne(Corte.Lomo, 2, CategoriaBovina.Novillo,
                                     new DateTime(2023, 06, 01), 1000, "Antonio", Tipo.Carne_Vacuna, 1200));
            productosDisponibles.Add(new Carne(Corte.Suprema, 1000, CategoriaBovina.No_Es_Bovino,
                         new DateTime(2023, 05, 21), 800, "Mingo CO", Tipo.Pollo, 1000));
            productosDisponibles.Add(new Carne(Corte.Bondiola, 1000, CategoriaBovina.No_Es_Bovino,
                         new DateTime(2023, 06, 01), 1200, "Siga la Vaca", Tipo.Cerdo, 1400));
            productosDisponibles.Add(new Carne(Corte.Costilla, 1000, CategoriaBovina.No_Es_Bovino,
                         new DateTime(2023, 07, 12), 1000, "Gra Chascomús", Tipo.Cerdo, 1200));
            productosDisponibles.Add(new Carne(Corte.Nalga, 200, CategoriaBovina.Novillito,
                         new DateTime(2023, 06, 01), 600, "Antonio", Tipo.Carne_Vacuna, 1000));
            productosDisponibles.Add(new Carne(Corte.Pollo_Entero, 2000, CategoriaBovina.No_Es_Bovino,
                         new DateTime(2023, 06, 01), 1400, "Granjitas ", Tipo.Pollo, 1700));
            productosDisponibles.Add(new Carne(Corte.Solomillo, 0, CategoriaBovina.No_Es_Bovino,
             new DateTime(2023, 06, 01), 1400, "Alsina Lanús ", Tipo.Cerdo, 1700));//-->Test, no debe mostrarlo, no tiene peso/stock
            #endregion

            #region CREO LA AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Como cliente podrás elegir un producto de la lista filtrando los tipos de corte, y ");
            textoAyuda.AppendLine("comprar por kilo para agregar al carrito.");
            textoAyuda.AppendLine("Podrás visualizar alguno de tus datos, en el apartado de costo ");
            textoAyuda.AppendLine("se mostrará el monton disponible de cliente, el saldo disponible que tiene y ");
            textoAyuda.AppendLine("el total de la compra. Al presionar el botón 'Finalizar' podrá ver una factura para confirmar la compra.");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }
        #endregion 

        #region EVENTOS DEL FORM
        /// <summary>
        /// El evento load del formulario me permite deshabilitar los textboxes 
        /// y checkboxes del form para que unicamente se muestre los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCompraCliente_Load(object sender, EventArgs e)
        {
            #region DESHABILITO TEXTBOXES Y CHECKBOXES
            this.txtEmail.Enabled = false;
            this.txtTelefono.Enabled = false;
            this.txtDomicilio.Enabled = false;
            this.txtMontoDisponible.Enabled = false;
            this.checkBoxEfectivo.Enabled = false;
            this.checkboxTarjeta.Enabled = false;
            this.txtSaldoDisponible.Enabled = false;
            this.txtTotalCompra.Enabled = false;
            this.txtNumTarjeta.Enabled = false;
            this.richTextBoxCarrito.ReadOnly = true;
            #endregion

            this.CargarDatosCliente();//-->Cargo los datos del cliente.

            #region DATAGRID
            this._dataTable.Columns.Add("Código");
            this._dataTable.Columns.Add("Tipo");
            this._dataTable.Columns.Add("Corte");
            this._dataTable.Columns.Add("Categoría bovina");
            this._dataTable.Columns.Add("Precio compra");

            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;

            this.CargarProductosDataGrid();//-->Cargo los productos disponibles en el datagrid
            #endregion

            foreach (Corte corte in Enum.GetValues(typeof(Corte)))
            {
                this.cbFiltrarPor.Items.Add(corte.ToString().Replace("_", " "));
            }

            if (clienteFormulario.ConTarjeta)
            {
                totalDisponibleCliente = clienteFormulario.Tarjeta.DineroDisponible;//-->Obtengo el dinero total del cliente
            }
            else
            {
                totalDisponibleCliente = clienteFormulario.DineroEfectivoDisponible;
            }
            this.txtMontoDisponible.Text = totalDisponibleCliente.ToString();
        }
        #endregion

        #region METODOS
        /// <summary>
        /// Metodo privado que me permite cargar en los textboxes los datos del cliente.
        /// </summary>
        private void CargarDatosCliente()
        {
            this.txtEmail.Text = clienteFormulario.Usuario.Email;
            this.txtTelefono.Text = clienteFormulario.Telefono;
            this.txtDomicilio.Text = clienteFormulario.Domicilio;

            if (clienteFormulario.ConTarjeta)
            {
                this.checkboxTarjeta.Checked = true;
                this.txtNumTarjeta.Text = clienteFormulario.Tarjeta.NumeroTarjeta;
                this.txtSaldoDisponible.Text = clienteFormulario.Tarjeta.DineroDisponible.ToString();
            }
            else
            {
                this.checkBoxEfectivo.Checked = true;
                this.txtSaldoDisponible.Text = clienteFormulario.DineroEfectivoDisponible.ToString();
            }
            this.txtMontoDisponible.Text = totalDisponibleCliente.ToString();//-->Cargo el total disponible del cliente
        }

        /// <summary>
        /// Metodo privado que me permite cargar los productos de la lista,
        /// la recorre, uso auxiliares de las filas para poder imprimir los atributos
        /// en el datagrid.
        /// 
        /// Es una forma de que me muestre lo que quiero, ya que sino directamente
        /// al datagrid se le puede pasar la lista y mostrara gracias a las propiedades
        /// de la clase.
        /// </summary>
        private void CargarProductosDataGrid()
        {
            _dataTable.Rows.Clear();

            foreach (Carne carnes in this.productosDisponibles)
            {
                auxFilaProduc = _dataTable.NewRow();

                auxFilaProduc[0] = $"{carnes.Codigo}";//-->Muestro el codigo para luego seleccionarlo
                auxFilaProduc[1] = $"{carnes.Tipo.ToString().Replace("_", " ")}";
                auxFilaProduc[2] = $"{carnes.Corte.ToString().Replace("_", " ")}";
                auxFilaProduc[3] = $"{carnes.Categoria.ToString().Replace("_", " ")}";
                auxFilaProduc[4] = $"{carnes.PrecioCompraCliente}";

                _dataTable.Rows.Add(auxFilaProduc);//-->Añado las Filas
            }
            this.dataGridViewProductos.DataSource = _dataTable;//-->Al dataGrid le paso la lista
        }
        #endregion

        /// <summary>
        /// Este evento me permitira filtrar las carnes disponibles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbFiltrarPor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Me permite unicamente ingresar numeros en el textbox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            FrmMetodoDePago.SoloNumeros(sender, e);
        }

        /// <summary>
        /// Al hacer click en el datagrid de productos disponibles en una de las filas
        /// obtengo la carne, recorriendo la lista de productos y comparando el codigo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.indexTablaProductos = e.RowIndex;//-->Obtengo el indice

            if (this.indexTablaProductos > -1)//-->Si es mayor a -1 obtengo el codigo, celda [0]
            {
                this.indiceDetalle = 0;
                codigoProducto = int.Parse(this.dataGridViewProductos.Rows[indexTablaProductos].Cells[0].Value.ToString());//-->Obtengo el codigo
            }

            //Recorro la lista en busca de ese producto
            foreach (Carne carne in this.productosDisponibles)
            {
                if (carne == codigoProducto)
                {
                    carneSeleccionada = carne;//-->Guardo esa carne
                }
            }
        }

        /// <summary>
        /// Metodo del formulario que me permite realizar validaciones.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool puedeSeguir = true;
            StringBuilder sb = new StringBuilder();

            if (this.indexTablaProductos < 0)
            {
                sb.AppendLine("No se ha seleccionado un Producto de la lista.");
                puedeSeguir = false;
            }

            if (string.IsNullOrEmpty(this.txtPesoRequerido.Text))
            {
                sb.AppendLine("Error con el peso seleccionado.");
                puedeSeguir = false;
            }

            if (!puedeSeguir)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return puedeSeguir;
        }

        /// <summary>
        /// Al presionar este boton me permite agregarlo al carrito.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {
            if (carneSeleccionada.Peso <= 0)//-->Si no hay peso/stock lo quito
            {
                productosDisponibles.Remove(carneSeleccionada);
            }

            if (Validar())//-->Valido que haya tocado un producto
            {
                double.TryParse(this.txtPesoRequerido.Text, out peso);

                if (carritoCliente.AgregarAlCarrito(carneSeleccionada, peso, clienteFormulario))
                {
                    foreach (Carne carne in clienteFormulario.CarritoCompra.Productos)
                    {
                        this.richTextBoxCarrito.Text = $"Corte: {carne.Corte} - " +
                                         $"Precio: {carne.PrecioCompraCliente:f} - Kilos: {carne.Peso}kgs.\n";//-->Imprimo del prducto el corte
                    } 

                    this.txtTotalCompra.Text = clienteFormulario.CarritoCompra.PrecioTotal.ToString();//-->Imprimo el total de la compra
                    MessageBox.Show("Producto agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo agregar al carrito, puede ser que ya exista o el peso no sea valido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.txtPesoRequerido.Clear();
                this.CargarProductosDataGrid();//-->Actualizo el datagrid.
            }
        } 

        /// <summary>
        /// Este boton me permite comprar un producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComprar_Click(object sender, EventArgs e)
        {  
            if (clienteFormulario.CarritoCompra.Productos.Count > 0)//-->Hay productos
            {
                DialogResult respuesta = MessageBox.Show("¿Desea Realizar la compra?" + $"\n{clienteFormulario.CarritoCompra.ToString()}", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult.Yes == respuesta)
                {
                    if (Cliente.Comprar(clienteFormulario, productosDisponibles))
                    {
                        MessageBox.Show("Pudo Comprar.", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information); 

                        //-->Actualizo en los textboxes el dinero del cliente
                        this.CargarDatosCliente();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un problema.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Compra cancelada.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No hay productos en el carrito.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            this.listBoxCarrito.Items.Clear();
            this.CargarProductosDataGrid();//-->Actualizo el datagrid. 
        }
    }
}