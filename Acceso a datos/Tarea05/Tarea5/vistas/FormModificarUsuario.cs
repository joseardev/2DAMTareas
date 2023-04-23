using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tarea5.Entidades;
using Tarea5.Servicios;

namespace Tarea5.vistas
{
    public partial class FormModificarUsuario : Form
    {
        private Usuario usuario;
        private UsuarioService usuarioService = new UsuarioService();

        public FormModificarUsuario()
        {
            InitializeComponent();
        }

        public FormModificarUsuario(Usuario usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
            tbEmail.Text = this.usuario.Mail;
            tbNombreUsuario.Text = this.usuario.NombreUsuario;
            tbPassword.Text = this.usuario.Password;
            tbNombre.Text = this.usuario.Nombre;
            tbApellidos.Text = this.usuario.Apellido;
        }

        private void btModficarUsuario_Click(object sender, EventArgs e)
        {
            SetupCrearUsuario();
        }
        private void SetupCrearUsuario()
        {

            try
            {
                if (tbNombreUsuario.Text.Length > 0 && tbEmail.Text.Length > 0 && tbPassword.Text.Length > 0 && tbNombre.Text.Length > 0 && tbApellidos.Text.Length > 0)
                {

                    usuario.Nombre = tbNombre.Text;
                    usuario.NombreUsuario = tbNombreUsuario.Text;
                    usuario.Apellido = tbApellidos.Text;
                    usuario.Mail = tbEmail.Text;
                    usuario.Password = tbPassword.Text;
                    if (CompruebaDatosUsuario(usuario))
                    {
                        this.usuarioService.Update(usuario);
                        MessageBox.Show("Usuario Modificado");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Faltan datos");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
        private bool CompruebaDatosUsuario(Entidades.Usuario usuario)
        {
            if (!CompruebaEmailIsOk(usuario.Mail))
            {
                MessageBox.Show("Email incorrecto");
                return false;

            }
            if (!CompruebaRequistosPassword(usuario.Password))
            {
                MessageBox.Show("Contraseña no cumple los requisitos");
                return false;
            }
            return true;

        }

        private bool CompruebaExisteUsuario(Entidades.Usuario usuarioActual)
        {
            var resultado = this.usuarioService.GetAll();

            foreach (var usuario in resultado)
            {
                if (usuario.Mail == usuarioActual.Mail)
                {
                    MessageBox.Show("Ya existe el Mail");
                    return false;
                }
                if (usuario.NombreUsuario == usuarioActual.NombreUsuario)
                {
                    MessageBox.Show("Ya existe el usuario");
                    return false;
                }
            }
            return true;
        }

        private bool CompruebaEmailIsOk(string mail)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(mail))
                {
                    return false;
                }
                else
                {
                    // Comprueba si el formato de la dirección de correo electrónico es válido.
                    var match = Regex.Match(mail, @"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.IgnoreCase);
                    if (!match.Success)
                    {
                        MessageBox.Show("Email es incorrecto");
                        return false;
                    }
                }

            }
            catch
            {

            }
            return true;
        }
        static bool CompruebaRequistosPassword(string password)
        {
            //Logitud contraseña
            if (password.Length < 8)
                return false;

            if (!Regex.IsMatch(password, @"[a-z]"))
                return false;
            //Tiene mayusculas
            if (!Regex.IsMatch(password, @"[A-Z]"))
                return false;
            //Tiene numeros
            if (!Regex.IsMatch(password, @"[0-9]"))
                return false;

            return true;
        }

    }
}
