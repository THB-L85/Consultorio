using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultorioDental
{
    public class BussinesLogicLayer
    {
        private DataAccessLayer _dataAccessLayer;

        public BussinesLogicLayer()
        {
            _dataAccessLayer = new DataAccessLayer();
        }
        public TablaPacientes SavePaciente(TablaPacientes tablaPacientes)
        {
            if (tablaPacientes.Id == 0)
                _dataAccessLayer.InsertTablaPacientes(tablaPacientes);
            else
                _dataAccessLayer.UpdateTablaPacientes(tablaPacientes);

            return tablaPacientes;
        }

        public List<TablaPacientes> GetTablaPacientes()
        {
            return _dataAccessLayer.GetTablaPacientes();
        }

        public void DeletePaciente(int id)
        {
            _dataAccessLayer.DeletePacientes(id);
        }
    }
}
