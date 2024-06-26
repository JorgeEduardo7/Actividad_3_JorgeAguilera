﻿using Actividad.DAL;
using Actividad.MODELOS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad.BSS
{
    public class ClienteBSS
    {
        ClienteDAL dal = new ClienteDAL();
        public DataTable ListarClienteBss()
        {
            return dal.ListarClienteDal();
        }

        public void InsertarClienteBss(Cliente cliente)
        {
            dal.InsertarClienteDAL(cliente);
        }
        public Cliente ObtenerClienteIdBss(int id)
        {
            return dal.ObtenerClienteIdDal(id);
        }
        public void EditarClienteBss(Cliente p)
        {
            dal.EditarClienteDal(p);
        }

        public void EliminarClienteBss(int id)
        {
            dal.EliminarClienteDal(id);
        }
        public DataTable ClienteDatosBSS(int id)
        {
            return dal.ClienteDatosDal(id);
        }
        public DataTable ClienteDatosBSS2(int id)
        {
            return dal.ClienteDatosDal2(id);
        }
        public DataTable ClienteDatosBSS3(int id)
        {
            return dal.ClienteDatosDal3(id);
        }
    }
}
