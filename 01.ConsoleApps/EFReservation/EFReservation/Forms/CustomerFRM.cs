using EFReservation.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFReservation.Forms;
public partial class CustomerFRM : Form
{
    public CustomerFRM()
    {
        InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void btnCustomerAdd_Click(object sender, EventArgs e)
    {
        Customer customer = new Customer();
        customer.Name = txtName.Text;
        customer.Surname = txtSurname.Text;
        customer.EMail = txtEmail.Text;
        customer.Phone = txtPhone.Text;
        customer.Address = txtAdress.Text;

        EFReservationContext context = new EFReservationContext();

        context.Customers.Add(customer);
        context.SaveChanges();
        CustomerlariGetir();

        MessageBox.Show("Kisi ekleme basarili.");
    }

    private void dGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        CustomerlariGetir();

    }

    private void CustomerlariGetir()
    {
        EFReservationContext context = new EFReservationContext();
        List<Customer> customers = context.Customers.ToList();
        dGVCustomers.DataSource = customers;
    }

    private void CustomerFRM_Load(object sender, EventArgs e)
    {
        CustomerlariGetir();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        int selectedRowId = Convert.ToInt32(dGVCustomers.CurrentRow.Cells["Id"].Value);
        EFReservationContext context = new EFReservationContext();
        Customer customer = context.Customers.FirstOrDefault(x=>x.Id==selectedRowId);
        context.Customers.Remove(customer); 
        context.SaveChanges();

        MessageBox.Show("Kisi Basari ile silindi.");
        CustomerlariGetir();

    }
}
