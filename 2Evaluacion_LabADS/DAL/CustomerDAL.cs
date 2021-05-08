using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.DAL
{
    public class CustomerDAL
    {
        //LISTADO DE CARRERAS, A NIVEL DE MEMORIA DEL PROYECTO
        public static List<Customer> lstCustomer = new List<Customer>();

        //CONSTRUCTOR
        public CustomerDAL()
        {
        }


        //INSERTAR CARRERA
        public int insertarCustomer(Customer customer)
        {
            try
            {
                //SI EL LISTADO TIENE ELEMENTOS ENTONCES SE GENERA EL Id.
                if (lstCustomer.Count > 0)
                {
                    customer.IdCustomer = lstCustomer.Last().IdCustomer + 1;
                }
                else
                {
                    //SI EL LISTADO ESTA VACIO ENTONCES EL Id SERA POR DEFAULT 1
                    customer.IdCustomer = 1;
                }
                lstCustomer.Add(customer);
                return customer.IdCustomer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //MODIFICAR customer
        public int modificarCustomer(int IdCustomer, Customer customer)
        {
            try
            {
                //BUSCANDO EL INDICE EN LA LISTA
                lstCustomer[lstCustomer.FindIndex(temp => temp.IdCustomer == IdCustomer)] = customer;
                return customer.IdCustomer;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //ELIMINAR customer
        public bool eliminarCustomer(int IdCustomer)
        {
            try
            {
                lstCustomer.RemoveAt(lstCustomer.FindIndex(aux => aux.IdCustomer == IdCustomer));



                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA LISTAR TODOS los Customer
        public List<Customer> obtenerTodos()
        {
            return lstCustomer;
        }



        //BUSCAR Customer POR Id.
        public Customer obtenerPorID(int IdCustomer)
        {
            try
            {
                var elementos = lstCustomer.Find(temp => temp.IdCustomer == IdCustomer);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;



            }
        }
    }
}