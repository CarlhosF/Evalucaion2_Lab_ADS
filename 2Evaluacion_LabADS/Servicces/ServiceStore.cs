using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.DAL;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.Servicces
{
    public class ServiceStore
    {//INSTANCIA PARA ACCEDER A TODOS LOS METODOS DE LA DAL
        public StoreDAL storeDAL = new StoreDAL();



        //PARA INSERTAR Store
        public int insertar(Store store)
        {
            try
            {
                return storeDAL.insertarStore(store);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA MODIFICAR UN Store
        public int modificar(int ID, Store store)
        {
            try
            {
                return storeDAL.modificarStore(ID, store);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA ELIMINAR UNA Store
        public bool eliminar(int ID)
        {
            try
            {
                return storeDAL.eliminarStore(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA OBTENER TODAS LAS Store.
        public List<Store> obtenerTodos()
        {
            return storeDAL.obtenerTodos();
        }



        //PARA OBTENER POR ID.
        public Store obtenerPorID(int ID)
        {
            try
            {
                return storeDAL.obtenerPorID(ID);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}