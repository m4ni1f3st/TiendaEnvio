using Newtonsoft.Json;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TiendaEnvio
{
    public partial class frmTienda : Form
    {
        private decimal PrecioProducto = 0;
        private decimal PrecioKilometro = 0;
        private decimal Dolar = 0;
        private decimal Euro = 0;

        public frmTienda()
        {
            this.Dolar = ObtenerDivisa("USD");
            this.Euro = ObtenerDivisa("EUR");
            InitializeComponent();
            AjustarColumnas();
            gridProductos.DataSource = Consulta("select *from producto", "DESKTOP-NBOB4TE", "tienda", "sa", "HOLA");
            txtDolar.Text = Dolar.ToString();
            txtE.Text = Euro.ToString();
        }

        public static decimal ObtenerDivisa(string DivisaBase)
        {
            try
            {
                int amount = 10;
                string currencyFrom = DivisaBase;
                string currencyTo = "MXN";

                string URLString = $"https://v6.exchangerate-api.com/v6/bc4f21f83db138031d15337c/pair/ {currencyFrom}/{currencyTo}/{amount}";
                URLString = Regex.Replace(URLString, @"\s+", "");
                using (var webClient = new System.Net.WebClient())
                {
                    var json = webClient.DownloadString(URLString);
                    API_Obj CurrencyFrom = JsonConvert.DeserializeObject<API_Obj>(json);


                    return CurrencyFrom.conversion_rate;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ocurrió un error al intentar obtener el precio del dólar: " + error.Message);
                return 0;
            }
        }

        public class API_Obj
        {
            public string result { get; set; }
            public string documentation { get; set; }
            public string terms_of_use { get; set; }
            public string time_last_update_unix { get; set; }
            public string time_last_update_utc { get; set; }
            public string time_next_update_unix { get; set; }
            public string time_next_update_utc { get; set; }
            public string base_code { get; set; }
            public decimal conversion_rate { get; set; }
        }


        private void AjustarColumnas()
        {
            gridProductos.AutoResizeColumns();
            gridProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private DataTable Consulta(string query, string instancia, string baseDatos, string user, string pass)
        {
            string cadenaConexion = string.Empty;
            cadenaConexion = @"Data Source =" + instancia + "; Initial Catalog= "
            + baseDatos + ";User ID =" + user + ";Password=" + pass + ";Trusted_Connection = False;";
            Console.WriteLine("Se está consultando: " + query);

            DataTable dt_ubicaciones = new DataTable();

            SqlConnection cnn = new SqlConnection(cadenaConexion);
            SqlCommand cmd = new SqlCommand(query, cnn);
            cmd.CommandTimeout = 3 * 1000;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                da.Fill(dt_ubicaciones);
            }
            catch (Exception error)
            {
                MessageBox.Show("Surgió un error: " + error.Message);
            }
            return dt_ubicaciones;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar la pantalla General?", "Tienda", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                    Application.Exit();
            }
        }



        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtProducto.Text = gridProductos.Rows[e.RowIndex].Cells["CodigoProducto"].Value.ToString();
            PrecioProducto = Convert.ToDecimal(gridProductos.Rows[e.RowIndex].Cells["Precio"].Value);
            PrecioKilometro = Convert.ToDecimal(gridProductos.Rows[e.RowIndex].Cells["PrecioKilometro"].Value);

            if (!string.IsNullOrEmpty(txtExistencias.Text))
                txtExistencias.Text = "";

            if (!string.IsNullOrEmpty(txtKilometros.Text))
                txtKilometros.Text = "";

            if (!string.IsNullOrEmpty(txtSubtotal.Text))
                txtSubtotal.Text = "";

            if (!string.IsNullOrEmpty(txtTotal.Text))
                txtTotal.Text = "";

            if (!string.IsNullOrEmpty(txtUSD.Text))
                txtUSD.Text = "";

            if (!string.IsNullOrEmpty(txtEUR.Text))
                txtEUR.Text = "";

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txtExistencias.Text) && !string.IsNullOrEmpty(txtKilometros.Text))
            {
                decimal subtotal = 0;
                decimal total = 0;

                //Subtotal quitando el IVA
                subtotal = Convert.ToDecimal(txtExistencias.Text) * (PrecioProducto * Convert.ToDecimal(.85))
                    + (Convert.ToDecimal(txtKilometros.Text) * PrecioKilometro);

                total = Convert.ToDecimal(txtExistencias.Text) * (PrecioProducto)
                    + (Convert.ToDecimal(txtKilometros.Text) * PrecioKilometro);

                txtSubtotal.Text = subtotal.ToString();

                txtTotal.Text = total.ToString();

                txtUSD.Text = (total / Dolar).ToString();

                txtEUR.Text = (total / Euro).ToString();
            }
            else
            {
                MessageBox.Show("Es necesario saber las existencias y kilometros a recorrer");
            }
        }
    }
}
