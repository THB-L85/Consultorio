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
    public partial class Pacientes : Form
    {
        private BussinesLogicLayer _bussinesLogicLayer;
        public Pacientes()
        {
            InitializeComponent();
            _bussinesLogicLayer = new BussinesLogicLayer();
        }

    

        #region PRIVATE METHODS

        private void OpenAgregarPaciente()
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente();
            agregarPaciente.ShowDialog(this);
        }
        #endregion

        #region EVENTS
        private void button2_Click(object sender, EventArgs e)
        {
            OpenAgregarPaciente();
        }

        #endregion

        private void Pacientes_Load(object sender, EventArgs e)
        {
            PopulatePacientes();
        }

        public void PopulatePacientes()
        {
            List<TablaPacientes> tablaPacientes = _bussinesLogicLayer.GetTablaPacientes();
            dataGridView1.DataSource = tablaPacientes;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}