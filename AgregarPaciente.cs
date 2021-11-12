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
        private TablaPacientes _tablaPacientes;
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

            //Esta linea sirve para que no se repita la insercion al actualizar
            tablaPacientes.Id = _tablaPacientes != null ? _tablaPacientes.Id : 0;

            _bussinesLogicLayer.SavePaciente(tablaPacientes);
        }

        //--------------------esto es para actualizar datos de la base------------------////////////
        public void LoadPaciente(TablaPacientes tablaPacientes)
        {
            _tablaPacientes = tablaPacientes;

            if(tablaPacientes != null)
            {
                ClearForm();

                txtNombres.Text = tablaPacientes.FirstName;
                txtApellidos.Text = tablaPacientes.LastName;
                txtCelular.Text = tablaPacientes.Phone;
                txtCorreo.Text = tablaPacientes.Email;
            }
        }

        private void ClearForm()
        {
            txtNombres.Text = string.Empty;
            txtApellidos.Text = string.Empty;
            txtCelular.Text = string.Empty;
            txtCorreo.Text = string.Empty;
        }
    }
}
