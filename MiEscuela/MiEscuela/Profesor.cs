﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    class Profesor<Tipo> : Empleado<Tipo>
    {
        #region Atributos
        private string matr;
        //private Materia materia;
        private FrecuenciaPago frecPago;
        #endregion

        #region Propiedades
        public string Matr
        {
            get
            {
                return matr + "_2017";
            }
            set
            {
                this.matr = value;
            }
        }

        public Materia Materia { get; set; }

        public FrecuenciaPago FrecPago { get; set; }

        #endregion


        #region Métodos
        public string Checar()
        {
            DateTime horaActual = DateTime.Now;
            //Guardar la hora en la BD
            string resp = "Hora de registro: " + horaActual;
            return resp;
        }

        public void AsignarMateria(Materia materia)
        {
            Materia = materia;
        }
        #endregion

        #region Constructor
        public Profesor()
        {
            this.Matr = "_2017";
            this.Activo = true;
        }
        #endregion
    }
}
