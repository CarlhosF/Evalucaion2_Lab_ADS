using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.DAL;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.Servicces
{
    public class ServiceProduct
    {
        //INSTANCIA PARA ACCEDER A TODOS LOS METODOS DE LA DAL
        public ProductDAL productDal = new ProductDAL();



        //PARA INSERTAR Product
        public int insertar(Product product)
        {
            try
            {
                return productDal.insertarProduct(product);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA MODIFICAR UN product
        public int modificar(int IdProduct, Product product)
        {
            try
            {
                return productDal.modificarProduct(IdProduct, product);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA ELIMINAR UNA Product
        public bool eliminar(int IdProduct)
        {
            try
            {
                return productDal.eliminarProduct(IdProduct);
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA OBTENER TODAS LoS Product.
        public List<Product> obtenerTodos()
        {
            return productDal.obtenerTodos();
        }



        //PARA OBTENER POR ID.
        public Product obtenerPorID(int IdProduct)
        {
            try
            {
                return productDal.obtenerPorID(IdProduct);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}