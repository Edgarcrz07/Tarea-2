namespace RegistroAlumno

{

    public partial class Form1 : Form

    {
        public Form1()
           
        
        {
            InitializeComponent();
        }
        string[] nombres= new string[5];

        int[] edad = new int[5];
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
           
          
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            nombres[i] = txtnombre.Text;
            edad[i] = Convert.ToInt16(txtedad.Text);
            
            MessageBox.Show(" Alumno " + i + " Registrado ");


            if (i == 4)
            {
                MessageBox.Show(" Registro completado ");
            }
            else
            {
                i = i + 1;
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int a = 0;
            listBoxNombre.Items.Clear();
           
            for (a = 0; a <= i - 1; a ++)
            {
                listBoxNombre.Items.Add(" Nombre: "+nombres[a]+ " Edad: "+edad[a]);
               
            }









        }
    }
}