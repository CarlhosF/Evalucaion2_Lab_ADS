using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using _2Evaluacion_LabADS.Models;
namespace _2Evaluacion_LabADS.DAL
{
    public class ProductDAL
    {
        //LISTADO DE Product, A NIVEL DE MEMORIA DEL PROYECTO
        public static List<Product> lstProduct = new List<Product>();



        //CONSTRUCTOR
        public ProductDAL()
        {
        }



        //INSERTAR Product
        public int insertarProduct(Product product)
        {
            try
            {
                //SI EL LISTADO TIENE ELEMENTOS ENTONCES SE GENERA EL Id.
                if (lstProduct.Count > 0)
                {
                    product.IdProduct = lstProduct.Last().IdProduct + 1;
                }
                else
                {
                    //SI EL LISTADO ESTA VACIO ENTONCES EL Id SERA POR DEFAULT 1
                    product.IdProduct = 1;
                }
                lstProduct.Add(product);
                return product.IdProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //MODIFICAR Product
        public int modificarProduct(int IdProduct, Product product)
        {
            try
            {
                //BUSCANDO EL INDICE EN LA LISTA
                lstProduct[lstProduct.FindIndex(temp => temp.IdProduct == IdProduct)] = product;
                return product.IdProduct;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //ELIMINAR Product
        public bool eliminarProduct(int IdProduct)
        {
            try
            {
                lstProduct.RemoveAt(lstProduct.FindIndex(aux => aux.IdProduct == IdProduct));



                return true;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        //PARA LISTAR TODOS los Product
        public List<Product> obtenerTodos()
        {
            return lstProduct;
        }



        //BUSCAR Product POR Id.
        public Product obtenerPorID(int IdProduct)
        {
            try
            {
                var elementos = lstProduct.Find(temp => temp.IdProduct == IdProduct);
                return elementos;
            }
            catch (Exception ex)
            {
                throw;



            }
        }
    }
}