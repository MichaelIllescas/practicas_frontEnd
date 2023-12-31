using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaAlumnos
{
    public partial class Form_ValoresPorDefecto : Form
    {
        public Form_ValoresPorDefecto()
        {
            InitializeComponent();
        }

        private void Form_ValoresPorDefecto_Load(object sender, EventArgs e)
        {
            /*              
              
            CONCEPTOS
            VALOR POR DEFECTO DE TIPOS
            
            int -> 0
            string -> null
            datetime -> 01/01/0001
             

            ACEPTAN NULL POR DEFECTO?
            int -> NO
            string -> SI (REFERENCIA)
            datetime -> 01/01/0001

            */

            Persona persona = new Persona();

            //valores por defecto
            //MessageBox.Show(persona.edad.ToString());
            //MessageBox.Show(persona.nombre.ToString());
            //MessageBox.Show(persona.fechaNacimiento.ToString());
            //MessageBox.Show(persona.esProgramador.ToString());

            // aceptan null por defecto
            //persona.edad = null;
            //persona.nombre = null;
            //persona.fechaNacimiento = null;
            //persona.esProgramador = null;

            //MessageBox.Show(persona.edad.ToString());

            //https://learn.microsoft.com/es-es/dotnet/csharp/language-reference/builtin-types/default-values

        }
    }

    class Persona
    {
        public int? edad;
        public string nombre;
        public DateTime? fechaNacimiento;
        //public bool? esProgramador;
    }

}


