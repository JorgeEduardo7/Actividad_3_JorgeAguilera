using Actividad.DAL;
using Actividad.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.BSS
{
    public class PedidoBSS
    {
        PedidoDAL dal = new PedidoDAL();
        public DataTable ListarPedidoBss()
        {
            return dal.ListarPedidoDal();
        }

        public void InsertarPedidoBss(Pedido pedido)
        {
            dal.InsertarPedidoDal(pedido);
        }
        public Pedido ObtenerPedidoIdBss(int id)
        {
            return dal.ObtenerPedidoIdDal(id);
        }
        public void EditarPedidoBss(Pedido p)
        {
            dal.EditarPedidoDal(p);
        }
        public void EliminarPedidoBss(int id)
        {
            dal.EliminarPedidoDal(id);
        }
    }
}
