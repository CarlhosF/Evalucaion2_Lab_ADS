
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _2Evaluacion_LabADS.Models;
using _2Evaluacion_LabADS.Servicces;
using _2Evaluacion_LabADS.Utilities;
using System.Net;

namespace _2Evaluacion_LabADS.Controllers
{
    public class ProductController : Controller
    {//INSTANCIA DEL SERVICIO ENCARGADO DE PROVEER LOS METODOS
        public ServiceProduct servicio = new ServiceProduct();



        public ProductController() { }



        [HttpGet]
        public ActionResult Index()
        {
            var product = servicio.obtenerTodos();



            return View(product);
        }



        [HttpGet]
        public ActionResult Form(int? Id/*puede aceptar nulos*/, Operacion operacion)
        {
            var product = new Product();
            //SI EL Id TIENE UN VALOR, ENTONCES SE PROCEDE A BUSCAR UNA CARRERA
            if (Id.HasValue)
            {
                product = servicio.obtenerPorID(Id.Value);
            }
            //INDICA LA OPERACION QUE ESTAMOS REALIZANDO EN EL FORMULARIO
            ViewData["Operacion"] = operacion;
            return View(product);
        }



        [HttpPost]
        public ActionResult Form(Product product)
        {
            try
            {
                // Validamos que el modelo sea valido
                // segun las validaciones que le agregamos anteriormente
                if (ModelState.IsValid)
                {
                    int id = 0;//Esta variable nos sirve para saber si un modelo ha sido insertado correctamente.
                               //SI EL Id ES 0, ENTONCES SE ESTA INSERTANDO
                    if (product.IdProduct == 0)
                    {
                        id = servicio.insertar(product);
                    }
                    else
                    {
                        //SI EL Id ES DISTINTO DE 0, ENTONCES ESTAMOS MODIFICANDO
                        id = servicio.modificar(product.IdProduct, product);
                    }



                    //si el id es mayor a cero, entonces la operacion es correcta
                    if (id > 0)
                    {
                        //si la operacion fue exitosa entonces devolvemos un codigo 200(sucess)
                        return new JsonHttpStatusResult(product, HttpStatusCode.OK);
                    }
                    else
                    {
                        //si la operacion no fue exitosa entonces devolvemos un codigo 202(Accepted)
                        return new JsonHttpStatusResult(product, HttpStatusCode.Accepted);
                    }
                }
                else
                {
                    //Si hubo errores en la validacion, entonces devolvemos todos los errores del modelo con un codigo 400(BadRequest)
                    IEnumerable<ModelError> allErrors = ModelState.Values.SelectMany(temp => temp.Errors);
                    return new JsonHttpStatusResult(allErrors, HttpStatusCode.BadRequest);
                }
                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return new JsonHttpStatusResult(product, HttpStatusCode.InternalServerError);
                //throw;
            }
        }



        [HttpPost]
        public JsonResult Delete(int Id, string operacion)
        {
            try
            {
                //variable que permite controlar si fue eliminado correctamente
                bool correcto = false;



                //ELIMINAR UNA CARRERA
                correcto = servicio.eliminar(Id);



                //Si la eliminacion fue correcta
                if (correcto)
                {
                    //se devuelve el id del elemento eliminado
                    // y se retorna un codigo 200(sucess)
                    return new JsonHttpStatusResult(new { Id }, HttpStatusCode.OK);
                }
                else
                {
                    //Si no se puede eliminar, entonces se retorna un codigo 202(Accepted)
                    return new JsonHttpStatusResult(new { Id }, HttpStatusCode.Accepted);
                }



                //return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return new JsonHttpStatusResult(new { Id }, HttpStatusCode.InternalServerError);
                //throw;



            }
        }
    }
}