using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiEscuela
{
    public enum FrecuenciaPago
    {
        Quincenal,
        Mensual,
        Bimestral
    }
    public class Empleado<Tipo>
    {
        #region Atributos
        private Tipo id;
        private string nombre;
        private bool activo;
        private int edad;
        private string nac;
        private decimal pago;
        #endregion

        #region Propiedades
        public Tipo Id { get; set; }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public bool Activo { get; set; }
        public int Edad { get; set; }
        public string Nac { get; set; }
        public string Pago { get; }
        #endregion

        #region Métodos
        public void CalcularPago()
        {

        }
        #endregion

        #region Constructor
        public Empleado()
        {
            this.Activo = true;

        }
        public Empleado(string nombre)
        {
            Nombre = nombre;
            this.Activo = true;
        }
        #endregion
    }
}
