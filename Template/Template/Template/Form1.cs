using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Template
{
    public partial class Form1 : Form
    {
        List<Cliente> _clientes;
        List<String> _creditos;
        public Form1()
        {
            InitializeComponent();

            _clientes = new List<Cliente>();
            _clientes.Add(new Cliente() {Nombre = "Roberto Gómez"});
            _clientes.Add(new Cliente() { Nombre = "Marta Sánchez" });
            this.cboClientes.DataSource = _clientes;

            _creditos = new List<String>();
            _creditos.Add("Personal");
            _creditos.Add("Hipotecario");
            this.cboCreditos.DataSource = _creditos;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmd_Solicitar_Click(object sender, EventArgs e)
        {
            var credito = this.cboCreditos.SelectedItem.ToString();
            var cliente = (Cliente) this.cboClientes.SelectedItem;

            try
            {
                if (credito == null) throw new Exception("Debes seleccionar un crédito");

                Credito c;

                switch (credito)
                {
                    case "Hipotecario":
                        c = new CreditoHipotecario(cliente);
                        break;
                    case "Personal":
                        c = new CreditoPersonal(cliente);
                        break;
                    default:
                        throw new Exception("Debes seleccionar un crédito");

                }
                this.resultado.Clear();
                this.resultado.Lines = c.Verificar();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
