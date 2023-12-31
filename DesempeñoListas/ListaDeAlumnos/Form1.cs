namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        //declaro la lista
        public List<Alumnos> ListaAlumnos = new List<Alumnos>();

        #region ocultar

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //declaro la lista
            ListaAlumnos = new List<Alumnos>();


            //opcion 2 para agregar un elemento a la lista. Creo el elemento y despues lo agrego
            Alumnos a = new Alumnos();
            a.CantidadMaterias = 5;
            a.FechaNacimiento = new DateTime(1980, 02, 10);
            a.NombreApellido = "Angel";
            a.Legajo = 2;

            ListaAlumnos.Add(a);



            //opcion 1 para aagregar un elemento a la lista, en una sola linea.
            ListaAlumnos.Add(
                new Alumnos
                {
                    Legajo = 1,
                    CantidadMaterias = 10,
                    FechaNacimiento = new DateTime(2000, 10, 20),
                    NombreApellido = "Lionel"
                }
                );



            CargarAlumnosRandom();

            // toda la lista ya esta cargada
            MostrarEnListBox(listBox1, ListaAlumnos);

        }

        private void CargarAlumnosRandom()
        {
            Random rnd = new Random();
            //voy a generar valores random para insertar en la lista
            for (int i = 3; i < 50; i++)
            {
                //opcion 2 para agregar un elemento a la lista. Creo el elemento y despues lo agrego
                Alumnos alu = new Alumnos();


                //materias                 
                alu.CantidadMaterias = rnd.Next(1, 15);

                //genero una fecha nac
                alu.FechaNacimiento = new DateTime(rnd.Next(1950, 2000), rnd.Next(1, 12), rnd.Next(1, 28));

                //nombre al azar -> son solo letra sin sentido...pero sive
                int longitud = 10;
                Guid miGuid = Guid.NewGuid();
                string token = Convert.ToBase64String(miGuid.ToByteArray());
                token = token.Replace("=", "").Replace("+", "");

                alu.NombreApellido = token.Substring(0, longitud);

                //el legajo que no se repita
                alu.Legajo = i;

                ListaAlumnos.Add(alu);
            }
        }

        private void MostrarEnListBox(ListBox lstBox, List<Alumnos> lista)
        {
            lstBox.Items.Clear();
            //muestro en la lista
            foreach (Alumnos item in lista)
            {
                lstBox.Items.Add(item.Legajo + " | "
                    + item.NombreApellido + " | "
                    + item.FechaNacimiento.ToShortDateString() + " | "
                    + item.CantidadMaterias);
            }

            txtCantidad.Text = lista.Count.ToString();

        }


        #endregion


        private void btnLegajoMayor_Click(object sender, EventArgs e)
        {
            //tomo el numero ingresado
            int cant = Convert.ToInt32(txtLegajoMayor.Text);

            //linq
            List<Alumnos> ListaResultado2 = (from a in ListaAlumnos where a.Legajo > cant select a).ToList();

            //lambda
            List<Alumnos> ListaResultado = ListaAlumnos.Where(alias => alias.Legajo > cant).ToList();

            MostrarEnListBox(listBox2, ListaResultado);
        }

        private void btnNombre_Click(object sender, EventArgs e)
        {
            //busco por nombre, en mayus y sin espacios
            string nom = txtNombre.Text.Trim().ToUpper();

            //linq
            List<Alumnos> ListaResultado2 = (from a in ListaAlumnos where a.NombreApellido.Trim().ToUpper().Contains(nom) select a).ToList();

            MessageBox.Show(ListaResultado2.Count.ToString());

            //lambda
            List<Alumnos> ListaResultado = ListaAlumnos.Where(c => c.NombreApellido.Trim().ToUpper().Contains(nom)).ToList();

            MostrarEnListBox(listBox2, ListaResultado);
        }

        private void btndesdeHasta_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}