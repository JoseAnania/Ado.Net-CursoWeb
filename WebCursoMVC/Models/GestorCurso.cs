using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebCursoMVC.Models
{
    public class GestorCurso
    {
        public void Agregar(Curso nuevoCurso)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS;Initial Catalog=Cursos;Persist Security Info=True;User ID=sa;Password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("INSERT INTO Curso (nombre, aula) VALUES (@nombre, @aula)", conn);

            comm.Parameters.Add(new SqlParameter("@nombre", nuevoCurso.Nombre));
            comm.Parameters.Add(new SqlParameter("@aula", nuevoCurso.Aula));

            comm.ExecuteNonQuery();

            conn.Close();
        }

        public List<Curso>Listar()
        {
            List<Curso> lista = new List<Curso>();

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS;Initial Catalog=Cursos;Persist Security Info=True;User ID=sa;Password=giandjoe");
            conn.Open();
            SqlCommand comm = new SqlCommand("SELECT * FROM Curso", conn);
            SqlDataReader dr = comm.ExecuteReader();

            while(dr.Read())
            {
                int idCurso = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                string aula = dr.GetString(2);

                Curso C = new Curso(idCurso, nombre, aula);

                lista.Add(C);
            }

            conn.Close();
            return lista;
        }
    }
}