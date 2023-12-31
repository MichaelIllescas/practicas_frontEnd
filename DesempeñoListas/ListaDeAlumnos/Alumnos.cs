using Accessibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Alumnos
    {    /*    
        private int _legajo;        
        public int Legajo
        {
            get
            {

                return _legajo;
            }            
            set
            {                
                _legajo = value;

            }            
        }
        */

        public int Legajo { get; set; }

        public string NombreApellido { get; set; }

        public DateTime FechaNacimiento { get; set; }   

        public int CantidadMaterias { get; set; }

    }
}
