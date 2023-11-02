using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PRUEBA_ANDRES
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql =@"SELECT p.ProductID, p.ProductName, C.Description
            FROM Products p
            INNER JOIN Categories C ON p.CategoryID=C.CategoryID
            ORDER BY p.ProductID

            ";//busca solo los productos de la categoria 4
            
            // selec * from la tabla pasa toda la tabla 
            // si le pongo ProductID AS CODIGO se le cambia el nombre de la columna ID
            string cadena = "Data Source=perritoBD.db";
            SQLiteDataAdapter adaptador = new SQLiteDataAdapter(sql, cadena);//crea el adaptador se le pasa la base de datos y la ruta
            DataTable Tabla = new DataTable();
            adaptador.Fill(Tabla);
            dataGridView1.DataSource = Tabla;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
