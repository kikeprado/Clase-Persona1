using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
   public class Profesor:Persona
    {
        private int cantMat;

        public int CantMat
        {
            get { return cantMat; }
            set { cantMat = value; }
        }
        private int AnnosTrabajando;

        public int AnnosTrabajando1
        {
            get { return AnnosTrabajando; }
            set { AnnosTrabajando = value; }
        }
        private string area;

        public string Area
        {
            get { return area; }
            set { area = value; }
        }

       public Profesor(string nombre, byte edad, double peso, int cantMat, int AnnosTrabajando, string area)
           : base(nombre, edad, peso)
       {
           this.cantMat = cantMat;
           this.AnnosTrabajando = AnnosTrabajando;
           this.area = area;
       }

    }
}
