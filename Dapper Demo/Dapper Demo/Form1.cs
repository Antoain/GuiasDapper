using AccesoAdatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dapper_Demo
{
    public partial class Form1 : Form
    {
        CustomerRepositorys customerR = new CustomerRepositorys();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnObtenerTodos_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerTodo();
            dgvObtenerTodos.DataSource = cliente;
        }

        private void btnObtenerid_Click(object sender, EventArgs e)
        {
            var cliente = customerR.ObtenerPorID(txtboxObtenerID.Text);
            dgvObtenerTodos.DataSource = new List<Customer> { cliente };

            if (cliente != null) 
            {
                RellenarForm(cliente);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = CrearCliente();
            var insertados = customerR.insertarCliente(nuevoCliente);
            MessageBox.Show($"{insertados} registrados");
        }


        private Customer CrearCliente()
        {
            var nuevo = new Customer()
            {
                CustomerID = txtboxCustomerID.Text,
                CompanyName = txtboxCompannyName.Text,
                ContactName = txtboxContactName.Text,
                ContactTitle = txtboxContactTitle.Text,
                Address = txtboxAdress.Text

            };
            return nuevo;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var eliminadas = customerR.EliminarCliente(txtboxObtenerID.Text);
            MessageBox.Show($"Se ha eliminado {eliminadas} filas de manera correcta");
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            var clienteActualizado = CrearCliente();
            var actualizados = customerR.ActualizarCliente(clienteActualizado);
            var cliente = customerR.ObtenerPorID(clienteActualizado.CustomerID);
            dgvObtenerTodos.DataSource = new List<Customer> {cliente};  

            MessageBox.Show($"Filas Actualizadas{actualizados}, {clienteActualizado.CustomerID}") ;
            
        }

        private void RellenarForm(Customer customer) 
        {
            txtboxCustomerID.Text = customer.CustomerID;
            txtboxCompannyName.Text = customer.CompanyName;
            txtboxContactName.Text = customer.ContactName;
            txtboxContactTitle.Text = customer.ContactTitle;
            txtboxAdress.Text = customer.Address;



        }
    }
}
