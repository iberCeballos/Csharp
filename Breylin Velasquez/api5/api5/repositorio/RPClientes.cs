using System;
using System.Collections.Generic;
using System.Linq;
using api5.model;
namespace api5.repositorio
{
    public class RPClientes
    {
        /*public static List<cliente> _listaClientes = new List<cliente>()
        {
            new cliente() { id = 1, name = "Cliente 1" , apellido = "Apellido 1" },
            new cliente() { id = 2, name = "Cliente 2" , apellido = "Apellido 2" },
            new cliente() { id = 3, name = "Cliente 3" , apellido = "Apellido 3" }
        };

        public IEnumerable<cliente> ObtenerClientes()
        {
            return _listaClientes;
        }

        public cliente ObtenerCliente(int id)
        {
            var cliente = _listaClientes.Where(cli => cli.id == id);

            return cliente.FirstOrDefault();
        }

        public void Agregar(cliente nuevoCliente)
        {
            _listaClientes.Add(nuevoCliente);
        //}*/
        //public static List<cliente> Getcliente()
        //{
        //    List<cliente> ObtenerClientes = new List<cliente>
        //    {
        //        new cliente
        //        {
        //            id = 1,
        //            name = "breilyn stiven",
        //            apellido = "velasqiez hernandez"
                    
        //        },
        //        new cliente
        //        {
        //            id = 2,
        //            name = "monica alejandra",
        //            apellido = "restrepo moreno"

        //        },
        //        new cliente
        //        {
        //            id = 3,
        //            name = "jeison andres",
        //            apellido = "ortiz"

        //        },

        //    };
        //    return ObtenerClientes;
        //}

        //internal object ObtenerCliente(int id)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
