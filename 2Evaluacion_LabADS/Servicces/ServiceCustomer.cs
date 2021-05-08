using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.DAL;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.Servicces
{
    public class ServiceCustomer
    {

        //INSTANCIA PARA ACCEDER A TODOS LOS METODOS DE LA DAL
        public CustomerDAL customerDal = new CustomerDAL();



        //PARA INSERTAR Customer
        public int insertar(Customer customer)
        {
            try
            {
                return customerDal.insertarCustomer(customer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA MODIFICAR UN Customer
        public int modificar(int IdCustomer, Customer customer)
        {
            try
            {
                return customerDal.modificarCustomer(IdCustomer, customer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA ELIMINAR UNA Customer
        public bool eliminar(int IdCustomer)
        {
            try
            {
                return customerDal.eliminarCustomer(IdCustomer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA OBTENER TODAS LAS Customer.
        public List<Customer> obtenerTodos()
        {
            return customerDal.obtenerTodos();
        }



        //PARA OBTENER POR ID.
        public Customer obtenerPorID(int IdCustomer)
        {
            try
            {
                return customerDal.obtenerPorID(IdCustomer);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}