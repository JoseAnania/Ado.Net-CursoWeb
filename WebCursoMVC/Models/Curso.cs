using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCursoMVC.Models
{
    public class Curso
    {
        public int IdCurso { get; set; }
        public string Nombre { get; set; }
        public string Aula { get; set; }

        public Curso (int idCurso, string nombre, string aula)
        {
            IdCurso = idCurso;
            Nombre = nombre;
            Aula = aula;
        }

        public Curso()
        {

        }
    }
}