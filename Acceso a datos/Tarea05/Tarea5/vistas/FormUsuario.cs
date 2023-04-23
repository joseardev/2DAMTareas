using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tarea5.Entidades;
using Tarea5.Servicios;

namespace Tarea5.vistas
{
    public partial class FormUsuario : Form
    {
        private UsuarioService usuarioService = new UsuarioService();
        public FormUsuario()
        {
            InitializeComponent();
            //Carga al configuracion datagrid
            ConfigurarDataGridView();
            //Carga lista de usuarios en el datagrid
            CargarListUsuarios();
        }

        public void CargarListUsuarios()
        {
            this.dgwUsuario.Rows.Clear();
            List<Usuario> listaUsuarios = this.usuarioService.GetAll();
            //Ordenamos  la lista desc por el idusuario
            //Para que se muestre ordenada
            foreach (Usuario usuario in listaUsuarios.OrderByDescending(x => x.IdUsuario))
            {
                this.dgwUsuario.Rows.Add(usuario.IdUsuario, usuario.Nombre, usuario.Apellido, usuario.Mail, usuario.NombreUsuario, usuario.Password);
            }
        }

        private void ConfigurarDataGridView()
        {
            //Botones para añadir al datagridview
            DataGridViewButtonColumn columnActualizar = new DataGridViewButtonColumn();
            DataGridViewButtonColumn columnEliminar = new DataGridViewButtonColumn();

            columnActualizar.HeaderText = "Actualizar";
            columnActualizar.Name = "Actualizar";
            columnActualizar.Text = "Actualizar";
            columnActualizar.UseColumnTextForButtonValue = true;

            columnEliminar.HeaderText = "Eliminar";
            columnEliminar.Name = "Eliminar";
            columnEliminar.Text = "Eliminar";
            columnEliminar.UseColumnTextForButtonValue = true;

            //Add columnas al datagrid
            this.dgwUsuario.Columns.Add("IdUsuario", "id");
            this.dgwUsuario.Columns.Add("Nombre", "Nombre");
            this.dgwUsuario.Columns.Add("Apellido", "Apellido");
            this.dgwUsuario.Columns.Add("Mail", "Mail");
            this.dgwUsuario.Columns.Add("NombreUsuario", "Nombre Usuario");
            this.dgwUsuario.Columns.Add("Password", "contraseña");
            this.dgwUsuario.Columns.Add(columnActualizar);
            this.dgwUsuario.Columns.Add(columnEliminar);
        }

        private void dgwUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dgwUsuario.Columns[e.ColumnIndex].Name == "Eliminar")
            {
                object value = dgwUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value;
                if (value != null)
                {
                    if (MessageBox.Show("¿Quieres eliminar el usuario?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = (int)dgwUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value;
                        EliminarUsuario(id);
                        CargarListUsuarios();
                    }
                }

            }
            else if (dgwUsuario.Columns[e.ColumnIndex].Name == "Actualizar")
            {
                Entidades.Usuario usuario = new Entidades.Usuario();
                object value = dgwUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value;
                try
                {
                    if (value != null)
                    {
                        usuario.IdUsuario = (int)dgwUsuario.Rows[e.RowIndex].Cells["IdUsuario"].Value;

                        this.ActualizarUsuario(usuario.IdUsuario);
                        CargarListUsuarios();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(e.ToString());
                }
            }
        }

        private void ActualizarUsuario(int idUsuario)
        {
            Usuario usuario = this.usuarioService.GetById(idUsuario);
            this.CargarFormModificarUsuario(usuario);

        }

        private void CargarFormModificarUsuario(Usuario usuario)
        {
            FormModificarUsuario formModificarUsuario = new FormModificarUsuario(usuario);
            formModificarUsuario.Show();
        }

        private void EliminarUsuario(int id)
        {
            Usuario _usuario = this.usuarioService.GetById(id);
            this.usuarioService.Delete(_usuario);
        }

        private void btCrearUsuario_Click(object sender, EventArgs e)
        {
            SetupCrearUsuario();
            CargarListUsuarios();
        }
        private void SetupCrearUsuario()
        {

            Entidades.Usuario usuario = new Entidades.Usuario();
            try
            {


                //Comprobamos que no faltan valores
                if (tbNombreUsuario.Text.Length > 0 && tbEmail.Text.Length > 0 && tbPassword.Text.Length > 0 && tbNombre.Text.Length > 0 && tbApellidos.Text.Length > 0)
                {
                    usuario.Nombre = tbNombre.Text;
                    usuario.NombreUsuario = tbNombreUsuario.Text;
                    usuario.Apellido = tbApellidos.Text;
                    usuario.Mail = tbEmail.Text;
                    usuario.Password = tbPassword.Text;
                    //validamos los datos introduccidos
                    if (CompruebaExisteUsuario(usuario))
                    {
                        if (CompruebaDatosUsuario(usuario))
                        {
                            this.usuarioService.Save(usuario);
                            MessageBox.Show("Usuario creado");
                        }
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
        //Comprobamos que no existe el usuario y mail idicado

        private bool CompruebaExisteUsuario(Entidades.Usuario usuarioActual)
        {
            try
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
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            return true;
        }
        //Comrpueba formato email
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
            //Tiene minusculas
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

        private void btRefrescar_Click(object sender, EventArgs e)
        {
            CargarListUsuarios();
        }
    }
}
