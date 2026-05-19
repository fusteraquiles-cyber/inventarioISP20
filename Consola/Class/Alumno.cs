using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consola.Class
{
    public partial class Alumno
    {
        static int instancias_de_alumnos = 0;
        string nombre;
        string apellido;
        int dni;
        DateOnly fechaNacimiento;
        
        //constructor de la clase alumno
        public Alumno(string nombre, string apellido, int dni, DateOnly fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNacimiento = fechaNacimiento;
            instancias_de_alumnos++;
           
        }
        public string ImpresionFichadeDatos()
        {
            return $"Nombre: {nombre} Apellido: {apellido}\nDNI: {dni}\nFecha de Nacimiento: {fechaNacimiento}";
        }


    }
}
