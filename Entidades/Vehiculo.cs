using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        //Estrella == protected
        //Corazon == internal

        protected bool esAWD;
        protected Guid numeroDeChasis;
        protected EPropulsion propulsion;

        protected Vehiculo(EPropulsion propulsion) 
        {
            this.esAWD = false;
            this.numeroDeChasis = Guid.NewGuid();
        }
        protected Vehiculo(EPropulsion propulsion, bool asAWD) : this(propulsion){ }

        public EPropulsion Propulsion { get { return this.propulsion; } }
        protected abstract string Tipo { get; }

        //METODOS
        /// <summary>
        /// Funcion que genera texto con los datosd del vehiculos en cuestion
        /// </summary>
        /// <returns>Retorna un string que es el texto con la informacion</returns>
        protected string GetInfo() 
        {
            string s = String.Empty;
            s = string.Format($"{this.Tipo} con propulsión a {this.Propulsion}, {this.esAWD} es AWD, numero de chasis {this.numeroDeChasis}.");
            return s; 
        }
        
        public string Tostring()
        {
            return GetInfo();
        }

        public static bool operator == (Vehiculo v1, Vehiculo v2) 
        {
            return (v1.GetType() == v2.GetType() && v1.numeroDeChasis == v2.numeroDeChasis); 
        }
        public static bool operator != (Vehiculo v1, Vehiculo v2) {  return !(v1==v2); }
    }
}