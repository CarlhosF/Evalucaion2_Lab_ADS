using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.DAL
{
    public class StoreDAL
    {
        //LISTADO DE Store, A NIVEL DE MEMORIA DEL PROYECTO
        public static List<Store> lstStore = new List<Store>();



        //CONSTRUCTOR
        public StoreDAL()
        {
        }



        //INSERTAR Store
        public int insertarStore(Store store)
        {
            try
            {
                //SI EL LISTADO TIENE ELEMENTOS ENTONCES SE GENERA EL Id.
                if (lstStore.Count > 0)
                {
                    store.IdStore = lstStore.Last().IdStore + 1;
                }
                else
                {
                    //SI EL LISTADO ESTA VACIO ENTONCES EL Id SERA POR DEFAULT 1
                    store.IdStore = 1;
                }
                lstStore.Add(store);
                return store.IdStore;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //MODIFICAR store
        public int modificarStore(int IdStore, Store store)
        {
            try
            {
                //BUSCANDO EL INDICE EN LA LISTA
                lstStore[lstStore.FindIndex(temp => temp.IdStore == IdStore)] = store;
                return store.IdStore;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //ELIMINAR store
        public bool eliminarStore(int IdStore)
        {
            try
            {
                lstStore.RemoveAt(lstStore.FindIndex(aux => aux.IdStore == IdStore));



                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA LISTAR TODOS los Store
        public List<Store> obtenerTodos()
        {
            return lstStore;
        }



        //BUSCAR store POR Id.
        public Store obtenerPorID(int IdStore)
        {
            try
            {
                var elementos = lstStore.Find(temp => temp.IdStore == IdStore);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;



            }
        }
    }
}