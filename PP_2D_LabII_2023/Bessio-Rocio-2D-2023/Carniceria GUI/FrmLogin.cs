using Entidades;
using Microsoft.VisualBasic.Logging;
using System.Media;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Carniceria_GUI
{
    public partial class FrmLogin : Form
    {
        #region ATRIBUTOS 
        private List<Cliente> clientes;
        private Cliente cliente;
        private Cliente clientePrueba;
        private List<Vendedor> vendedores;
        private Vendedor vendedor;
        private Persona ingresante;

        private FrmHeladera frmHeladera;
        private FrmMetodoDePago frmMetodoDePago;
        private SoundPlayer soundPlayer;
        #endregion

        public FrmLogin()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;

            #region INSTANCIO CLIENTES
            clientes = new List<Cliente>();
            cliente = new Cliente("Rocio", "Bessio", Sexo.Femenino, Nacionalidad.Argentina, new DateTime(2003, 08, 13), "45013997", "Formosa 2680", "1138225232",
                                   new Usuario("rociobessio@gmail.com", "123"), new Carrito());
            clientePrueba = new Cliente("Romina", "Per�z", Sexo.Femenino, Nacionalidad.Argentina, new DateTime(1992, 10, 11),
                                        "30125878", "Mitre 198", "11890778", new Usuario("romipp@gmail.com", "123"), new Carrito());
            clientes.Add(clientePrueba);
            clientes.Add(cliente);
            #endregion

            #region INSTANCIO VENDEDORES
            vendedores = new List<Vendedor>();
            vendedor = new Vendedor(new Usuario("felipe@hotmail.com", "123"));
            vendedor = Vendedor.CargarDatosVendedor(vendedor);//-->Le cargo las listas al vendedor que usare.

            vendedores.Add(vendedor);//-->Asi lo puedo enviar al formulario si presiona el boton.
            vendedores.Add(new Vendedor(new Usuario("Lucas@yahoo.com.ar", "123")));
            #endregion

            #region INSTANCIO SOUNDPLAYER
            soundPlayer = new SoundPlayer();
            soundPlayer.SoundLocation = "LoginUnlocked.wav";
            #endregion

            #region CREO LA AYUDA
            StringBuilder textoAyuda = new StringBuilder();
            textoAyuda.AppendLine("Podr�s iniciar sesi�n ingresando tu email y contrase�a ");
            textoAyuda.AppendLine("o directamente presionando alguno de los botones de Vendedor o Cliente para agilizar el proceso");
            FrmLogin.MostrarAyuda(this.lblPrintHelp, textoAyuda.ToString());
            #endregion
        }

        /// <summary>
        /// En el evento load le cambio el nombre al form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Felices las vacas";
        }

        #region VALIDACIONES
        /// <summary>
        /// Me permite validar los textboxes del formulario.
        /// Imprime un Message box con el msj de error.
        /// </summary>
        /// <returns>Retorna true si no hay error.</returns>
        private bool ValidarCampos()
        {
            bool puede = true;
            StringBuilder sb = new StringBuilder();
            //Chequeo que complete los campos
            if (string.IsNullOrEmpty(this.txtEmail.Text) ||
                string.IsNullOrEmpty(this.txtContrasenia.Text))
            {
                sb.Append("FALTO COMPLETAR ALGUN CAMPO.");
                puede = false;
            }

            //Si no es true debo mostrar un MessageBox
            if (!puede)
            {
                MessageBox.Show(sb.ToString(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return puede;
        }  

        /// <summary>
        /// Este metodo privado del formulario me permite principalmente verificar que Persona
        /// no sea nulo, llamo al metodo estatico de la clase Usuario esValidoElUsuario(), 
        /// si una persona != null entonces puede abrir otro formulario.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns></returns>
        private bool PuedeSeguir(Usuario usuario)
        {
            bool retorno = false;//No puede
            ingresante = Usuario.esValidoElUsuario(usuario,vendedores,clientes);//-->Retorna el tipo de Persona

            if (ingresante != null)//-->Verifico que sea distinta de null
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

        #region BOTONES DEL FORM
        /// <summary>
        /// Al presionar este boton se realizan las validaciones necesarias para, de
        /// esta manera poder abrir el form correspondiente dependiendo de la Entidad
        /// que corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            //-->Creo un usuario con los datos del textboxes
            Usuario usuario = new Usuario(this.txtEmail.Text, this.txtContrasenia.Text);
            bool ingresaraONo = this.PuedeSeguir(usuario);//-->Devuelve bool si puede

            if (ValidarCampos())//-->Verifico que haya ingresado email y contrase�a
            {
                if (!ingresaraONo)//-->Si no puede ingresar.
                {
                    MessageBox.Show("Ocurrio un error con los datos ingresados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (ingresante.EsCliente)//-->Utilizo la propiedad abstracta para saber si es Cliente
                    {
                        this.BackColor = Color.DarkKhaki;
                        soundPlayer.Play(); 
                        frmMetodoDePago = new FrmMetodoDePago((Cliente)ingresante);//-->Casteo Persona a Cliente
                        frmMetodoDePago.Show();

                    }
                    else//-->Si no lo es, quiere decir que es Vendedor
                    {
                        this.BackColor = Color.MediumPurple;
                        soundPlayer.Play(); 
                        frmHeladera = new FrmHeladera((Vendedor)ingresante);//-->Casteo a Vendedor
                        frmHeladera.Show();
                    }
                }
            }
        }

        /// <summary>
        /// Le preguntara al usuario si realmente desea cerrar el formulario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("�Esta seguro que desea salir?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (DialogResult.No == respuesta)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Este metodo estatico me permite mostrarle una ayuda al usuario para que sepa
        /// que hacer.
        /// 
        /// Utilizo la herramienta ToolTip, la cual mostrara como un MessageBox 
        /// imprimiendo el mensaje de ayuda o guia para el usuario.
        /// 
        /// Cada vez que el cursor se pare sobre el icono se mostrara la burbuja con el
        /// mensaje.
        /// </summary>
        /// <param name="etiqueta"></param>
        /// <param name="mensaje"></param>
        public static void MostrarAyuda(Label etiqueta, string mensaje)
        {
            ToolTip yourToolTip = new ToolTip();
            yourToolTip.ToolTipIcon = ToolTipIcon.Info;//-->Icono de la buble
            yourToolTip.IsBalloon = true;//-->Que tenga formato "burbuja" sino por default sera ventana
            yourToolTip.ShowAlways = true;//-->Que siempre lo muestra
            yourToolTip.SetToolTip(etiqueta, mensaje);//-->Lo seteo.
        }

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del Vendedor 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVendedor_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = this.vendedor.Usuario.Contrasenia;
            this.txtEmail.Text = this.vendedor.Usuario.Email;
            this.BackColor = Color.MediumPurple;
        }

        /// <summary>
        /// Al presionarlo me cargara en el texbox los datos del cliente 
        /// hardcodeado que cree.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.txtContrasenia.Text = this.clientePrueba.Usuario.Contrasenia;
            this.txtEmail.Text = this.clientePrueba.Usuario.Email;
            this.BackColor = Color.DarkKhaki;
        }
        #endregion 
    }
}