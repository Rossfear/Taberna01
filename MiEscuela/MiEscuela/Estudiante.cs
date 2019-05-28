using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Estudiante
    {
        #region Atributos
        private int id;
        private string matr;
        string nombre;
        string gradoGrupo;
        bool estatus;
        #endregion

        #region Propiedades
        public int Id { get; }
        public string Matr { get; }
        public string Nombre { get; set; }
        public string GradoGrupo { get; set; }
        public bool Estatus { get; set; }
        #endregion

        #region Métodos
        public string Registrar()
        {
            // registro en la BD
            string resp = "Alumno registrado";
            return resp;
        }

        public string DarDeBaja(string motivo = "")
        {
            this.Estatus = false;
            //Editar en BD el registro, agregar motivo
            string respuesta = "";
            if (motivo != "")
            {
                respuesta = "Alumno dado de baja. Motivo: " + motivo;
            }
            else
            {
                respuesta = "Alumno dado de baja";
            }
           

            return respuesta;
        }
        public void DarDeBaja(string cveUsuario, string pwd, string motivo)
        {
            //consultar que el usuario cuente con los permisos requeridos
            //VerificarUsuario(cveUsuario, pwd)
            //Si usuario verificado :
            //eliminar el registro del estudiante
            //guardar el movimiento en un log
        }
        #endregion

        #region Contructor
        public Estudiante(string nombre, string gradoGrupo)
        {
            Nombre = nombre;
            GradoGrupo = gradoGrupo;
        }
        public Estudiante(bool estatus)
        {
            Estatus = estatus;
            Nombre = "";
        }
        #endregion

    }
}
