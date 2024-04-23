using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ConnectingDb
    {
    public partial class Form1 : Form
        {
        OleDbConnection connection = new OleDbConnection();

        public Form1()
            {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ariv2\Documents\PROG3355L_M7_BASE_DATOS_PUNTAJES.accdb; Persist Security Info = False";
            }

        private void Form1_Load(object sender, EventArgs e)
            {
            try
                {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM PUEBLOS";

                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    {
                    cmbPueblo.Items.Add(reader["PUEBLO"].ToString());
                    }
                MessageBox.Show("Conexión abierta");
                connection.Close();
                }
            catch (Exception ex)
                {
                MessageBox.Show("Error: " + ex.Message);
                }
            cargarListView();
            }

        private void cargarListView()
            {
            listViewProfesores.View = View.Details;
            listViewProfesores.Columns.Add("Nombre", 100);
            listViewProfesores.Columns.Add("Apellido", 150); // Ajusté el ancho
            listViewProfesores.Columns.Add("Edad", 100);
            listViewProfesores.Columns.Add("Pueblo", 100);

            listViewEstudiantes.View = View.Details;
            listViewEstudiantes.Columns.Add("Nombre", 100);
            listViewEstudiantes.Columns.Add("Telefono", 150); // Ajusté el ancho y cambié a "Telefono"
            listViewEstudiantes.Columns.Add("Direccion", 100); // Ajusté el ancho y cambié a "Direccion"
            listViewEstudiantes.Columns.Add("Pueblo", 100);
            listViewEstudiantes.Columns.Add("Zip Code", 100);

            }

        private void listViewProfesores_SelectedIndexChanged(object sender, EventArgs e)
            {
            // Código para el evento SelectedIndexChanged del ListView de profesores
            }

        private void listViewEstudiantes_SelectedIndexChanged(object sender, EventArgs e)
            {
            // Código para el evento SelectedIndexChanged del ListView de estudiantes
            }

        private void comboBoxPueblo_SelectedIndexChanged(object sender, EventArgs e)
            {
            // Código para el evento SelectedIndexChanged del ComboBox de pueblos
            }

        private void btnCargar_Click(object sender, EventArgs e)
            {
            if (string.IsNullOrEmpty(cmbPueblo.Text))
                {
                MessageBox.Show("Por favor seleccione un pueblo");
                return;
                }
            else
                {
                MostrarProfesores();
                MostrarEstudiantes();
                }
            }

        private void MostrarProfesores()
            {
            listViewProfesores.Items.Clear(); // Limpiar el ListView de profesores

            OleDbCommand command = new OleDbCommand();
            ListViewItem li;

            command.Connection = connection;
            command.CommandText = "SELECT * FROM PROFESOR WHERE PUEBLO = '" + cmbPueblo.Text + "'";

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
                {
                li = new ListViewItem(reader["Nombre"].ToString());
                li.SubItems.Add(reader["Apellido"].ToString());
                li.SubItems.Add(reader["Edad"].ToString());
                li.SubItems.Add(reader["Pueblo"].ToString());
                listViewProfesores.Items.Add(li);
                }

            reader.Close();
            connection.Close();
            }

        private void MostrarEstudiantes()
            {
            listViewEstudiantes.Items.Clear(); // Limpiar el ListView de estudiantes

            OleDbCommand command = new OleDbCommand();
            ListViewItem li;

            command.Connection = connection;
            command.CommandText = "SELECT * FROM ESTUDIANTES WHERE PUEBLO = '" + cmbPueblo.Text + "'";

            connection.Open();
            OleDbDataReader reader = command.ExecuteReader();

            while (reader.Read())
                {
                li = new ListViewItem(reader["Nombre"].ToString());
                li.SubItems.Add(reader["Telefono"].ToString());
                li.SubItems.Add(reader["Direccion"].ToString());
                li.SubItems.Add(reader["Pueblo"].ToString());
                li.SubItems.Add(reader["Zip code"].ToString());
                listViewEstudiantes.Items.Add(li);
                }

            reader.Close();
            connection.Close();
            }

        private void btnLimpiar_Click(object sender, EventArgs e)
            {
            listViewProfesores.Items.Clear();
            listViewEstudiantes.Items.Clear();
            cmbPueblo.Items.Clear();
            cmbPueblo.Text = "";

            }
        }
    }
