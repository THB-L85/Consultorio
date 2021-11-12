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
        // Esto abre la ventana para agregar un registro
        private void OpenAgregarPaciente()
        {
            AgregarPaciente agregarPaciente = new AgregarPaciente();
            agregarPaciente.ShowDialog(this);
        }

        // Esto es para que se muestren los datos en el dataGrid
        private void Pacientes_Load(object sender, EventArgs e)
        {
            PopulatePacientes();
        }

        // Aqui se hace el metodo de Pacientes_Load
        public void PopulatePacientes()
        {
            List<TablaPacientes> tablaPacientes = _bussinesLogicLayer.GetTablaPacientes();
            dataGridView1.DataSource = tablaPacientes;
        }

        // Esta linea sirve para complementar la eliminacion por medio del Id
        private void DeletePaciente(int id)
        {
            _bussinesLogicLayer.DeletePaciente(id);
        }
        #endregion

        #region EVENTS
        private void button2_Click(object sender, EventArgs e)
        {
            OpenAgregarPaciente();
        }

        //------------------------Actualiza los datos de la base de datos-----------------------///////////
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewLinkCell cell = (DataGridViewLinkCell)dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];

            if(cell.Value.ToString() == "Edit")
            {
                AgregarPaciente agregarPaciente = new AgregarPaciente();
                agregarPaciente.LoadPaciente(new TablaPacientes
                {
                    Id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()),
                    FirstName = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                    LastName = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                    Phone = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                    Email = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                });
                agregarPaciente.ShowDialog(this);
            }
            else if (cell.Value.ToString() == "Delete")
            {
                DeletePaciente(int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString()));
                PopulatePacientes();
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.Show();
        }
    }
}