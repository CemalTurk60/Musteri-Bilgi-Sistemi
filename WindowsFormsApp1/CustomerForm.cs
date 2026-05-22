using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CustomerApp
{
    public partial class CustomerForm : Form
    {
        private readonly string connectionString =
            "Server=(localdb)\\MSSQLLocalDB;Database=TicariDB;Trusted_Connection=True;";

        private int selectedCustomerID = -1;

        public CustomerForm()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private SqlConnection GetConnection() => new SqlConnection(connectionString);

        private void LoadCustomers()
        {
            using (var con = GetConnection())
            using (var cmd = new SqlCommand("SELECT CustomerID, Name, Surname, Phone, Address, Balance FROM Customer", con))
            using (var adapter = new SqlDataAdapter(cmd))
            {
                var table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void ClearFields()
        {
            txtName.Clear();
            txtSurname.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
            txtBalance.Clear();
            selectedCustomerID = -1;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtSurname.Text))
            {
                MessageBox.Show("Ad ve Soyad alanları zorunludur.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (!int.TryParse(txtBalance.Text, out _))
            {
                MessageBox.Show("Bakiye sayısal bir değer olmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            using (var con = GetConnection())
            using (var cmd = new SqlCommand(
                "INSERT INTO Customer (Name, Surname, Phone, Address, Balance) VALUES (@Name, @Surname, @Phone, @Address, @Balance)", con))
            {
                cmd.Parameters.AddWithValue("@Name",    txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone",   txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Balance", int.Parse(txtBalance.Text));
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadCustomers();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Lütfen güncellenecek müşteriyi listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateInputs()) return;

            using (var con = GetConnection())
            using (var cmd = new SqlCommand(
                "UPDATE Customer SET Name=@Name, Surname=@Surname, Phone=@Phone, Address=@Address, Balance=@Balance WHERE CustomerID=@ID", con))
            {
                cmd.Parameters.AddWithValue("@Name",    txtName.Text.Trim());
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim());
                cmd.Parameters.AddWithValue("@Phone",   txtPhone.Text.Trim());
                cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                cmd.Parameters.AddWithValue("@Balance", int.Parse(txtBalance.Text));
                cmd.Parameters.AddWithValue("@ID",      selectedCustomerID);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadCustomers();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomerID == -1)
            {
                MessageBox.Show("Lütfen silinecek müşteriyi listeden seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show("Bu müşteriyi silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            using (var con = GetConnection())
            using (var cmd = new SqlCommand("DELETE FROM Customer WHERE CustomerID=@ID", con))
            {
                cmd.Parameters.AddWithValue("@ID", selectedCustomerID);
                con.Open();
                cmd.ExecuteNonQuery();
            }

            MessageBox.Show("Müşteri silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
            LoadCustomers();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dataGridView1.Rows[e.RowIndex];
            selectedCustomerID    = Convert.ToInt32(row.Cells["CustomerID"].Value);
            txtName.Text          = row.Cells["Name"].Value.ToString();
            txtSurname.Text       = row.Cells["Surname"].Value.ToString();
            txtPhone.Text         = row.Cells["Phone"].Value?.ToString() ?? "";
            txtAddress.Text       = row.Cells["Address"].Value?.ToString() ?? "";
            txtBalance.Text       = row.Cells["Balance"].Value.ToString();
        }
    }
}
