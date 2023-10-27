using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Camioneta : Vehiculo
    {

        private bool cambinaSimple;
        public Camioneta(EPropulsion propulsion, bool cambinaSimple) : base(propulsion)
        {
            this.cambinaSimple = cambinaSimple;
            base.esAWD = true;
        }

        protected override string Tipo { get { return "Camioneta"; } } 
        protected string GetInfo() 
        {
            StringBuilder sb = new StringBuilder();
            string info = base.GetInfo();
            sb.Append(info);
            sb.Append($", con cabina: {this.cambinaSimple}");
            return sb.ToString(); 
        }
        


    }
}
