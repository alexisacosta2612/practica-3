using practica_3.modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica_3.datos
{
    public class Usuario
    {
        List<UsuarioModelo> lista = new List<UsuarioModelo>();
        public void Guardar(UsuarioModelo modelo)
        {
            lista.Add(modelo);

        }
        public List<UsuarioModelo> Consultar()
        {
            return lista;
        }
    }
}
