using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultorioDental
{
    public partial class AgregarPaciente : Form
    {
        private BussinesLogicLayer _bussinesLogicLayer;
        public AgregarPaciente()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SavePaciente();
            this.Close();
            ((Pacientes)this.Owner).PopulatePacientes();
        }

        private void SavePaciente()
        {
            TablaPacientes tablaPacientes = new TablaPacientes();
            tablaPacientes.FirstName = txtNombres.Text;
            tablaPacientes.LastName = txtApellidos.Text;
            tablaPacientes.Phone = txtCelular.Text;
            tablaPacientes.Email = txtCorreo.Text;

            _bussinesLogicLayer.SaveContact(tablaPacientes);
        }
    }
}
