using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Interface.LogicaNegocio
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class EjemploCalculos : IEjemploCalculos, IEjemploCalculosDos
    {
         string IEjemploCalculos.show()
        {
            var elResultado = "Implementando Iemplocalculos";
            return elResultado;
        }
        string IEjemploCalculos.show(string mensaje)
        {
            var elResultado = "Implementando Iemplocalculos"+mensaje;
            return elResultado;
        }
        string IEjemploCalculosDos.show()
        {
            var elResultado = "Implementando IemplocalculosDos";
            return elResultado;
        }
        string IEjemploCalculosDos.show(string mensaje)
        {
            var elResultado = "Implementando IemplocalculosDos"+mensaje;
            return elResultado;
        }
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
