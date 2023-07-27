using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace analogcircuitry
{
    class components
    {
        private string component1;
        private string component2;
        public string role;
        public string Component1
        {
            get
            {
                return this.component1;
            }
            set
            {
                this.component1 = value;
            }
        }
        public string Component2
        {
            get
            {
                return this.component2;
            }
            set
            {
                this.component2 = value;
            }
        }
      /*  public string Role
        {
            get
            {
                return this.role;
            }
            set
            {
                this.role = value;
            }
        }*/
        public components()
        {
            this.component1 = "power source";
            this.component2 = " rectifier";
            this.role = " ac to dc";
        }
        public components(string component1,string component2,string role)
        {
            this.component1 = component1;
            this.component2 = component2;
            this.role = role;
        }
        public void problemsFacedByDesigners()
        {
            Console.WriteLine("Insatbility and drift due to temperature variations\nDynamic range of signals" +
                "and non linearity when pressing the limits of the range\n" +
                "Inaccuracies of computation when using analog quantities\n" +
                "Adequate signal frequency range");
        }
        public void identify()
        {
            if (component2 == "inverter")
                role = "dc to ac";
            else
                role = " ac to dc";
                    
        }
    }
}
