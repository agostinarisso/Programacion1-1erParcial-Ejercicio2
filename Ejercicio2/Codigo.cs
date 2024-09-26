using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Codigo
    {
        public static List<Cliente> clientes;
        public Cliente guardar(string nombre, string importe)
        {
            Cliente cliente = new Cliente();
            cliente.nombre = nombre;
            cliente.importe = importe;

            if (clientes == null)
            {
                clientes = new List<Cliente>();
                clientes.Add(cliente);
            }
            else
            {
                clientes.Add(cliente);
            }
            return cliente;
        }

        public double sumar()
        {
            double total = 0;
            foreach (Cliente cliente in clientes)
            {
                total += Convert.ToDouble(cliente.importe);
            }
            return total;
        }
    }
}
