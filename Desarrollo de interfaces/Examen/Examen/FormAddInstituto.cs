using Examen.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class FormAddInstituto : Form
    {
        public FormAddInstituto()
        {
            InitializeComponent();
        }

        private void btAddInstituto_Click(object sender, EventArgs e)
        {
            AddInstitutoNuevo();
        }

        private void AddInstitutoNuevo()
        {
            Instituto institutoNuevo = new Instituto(tbNombreInstituto.Text,tbDireccion.Text,0);

            var formOwner = (Main)this.Owner;
            formOwner.addInstitutoNuevo(institutoNuevo);
        }
    }
}
