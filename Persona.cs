using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCsharp
{
   public class Persona
    {
       //Atributos
       protected string nombre;  //Protected para heredar
       protected byte edad;
       protected double peso;
       int[] calificaciones = { 7, 8, 9 };
       Taller taller;

       //Propiedades
       public string Nombre
       {
           get { return nombre; }
           set { nombre = value; }
       }

       public byte Edad
       {
           get { return edad; }
           set { edad = value; }
       }

       public double Peso
       {
           get { return peso; }
           set { peso = value*2.3; }
       }

       //Constructores
       public Persona(string nombre,byte Edad, double Peso)
       {
           this.nombre = nombre;
           this.edad = Edad;
           this.peso = Peso;
       }

       //Metodo Promedio
      public double Promedio()
       {
           double suma = 0;
           for (int i = 0; i < calificaciones.Length; i++)
           {
               suma = calificaciones[i];
           }
           double promedio = suma / calificaciones.Length;
           return promedio;
       }

       //Metodo Limpiar
      public void limpiarCal()
       {
           Array.Clear(calificaciones, 0, calificaciones.Length);
       }

      public bool AproReo(double clifMin)
      {
          double promedio = Promedio();
          if (promedio >= clifMin)
              return true;
           else
              return false;
      }
      
    }
}
