namespace CustomerApp
{
    partial class CustomerForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblName       = new System.Windows.Forms.Label();
            this.lblSurname    = new System.Windows.Forms.Label();
            this.lblPhone      = new System.Windows.Forms.Label();
            this.lblAddress    = new System.Windows.Forms.Label();
            this.lblBalance    = new System.Windows.Forms.Label();
            this.txtName       = new System.Windows.Forms.TextBox();
            this.txtSurname    = new System.Windows.Forms.TextBox();
            this.txtPhone      = new System.Windows.Forms.TextBox();
            this.txtAddress    = new System.Windows.Forms.TextBox();
            this.txtBalance    = new System.Windows.Forms.TextBox();
            this.btnAdd        = new System.Windows.Forms.Button();
            this.btnUpdate     = new System.Windows.Forms.Button();
            this.btnDelete     = new System.Windows.Forms.Button();
            this.btnClear      = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblName.
            this.lblName.Text     = "Ad:";
            this.lblName.Location = new System.Drawing.Point(20, 20);
            this.lblName.Size     = new System.Drawing.Size(80, 20);

            // txtName
            this.txtName.Location = new System.Drawing.Point(110, 17);
            this.txtName.Size     = new System.Drawing.Size(200, 22);

            // lblSurname
            this.lblSurname.Text     = "Soyad:";
            this.lblSurname.Location = new System.Drawing.Point(20, 55);
            this.lblSurname.Size     = new System.Drawing.Size(80, 20);

            // txtSurname
            this.txtSurname.Location = new System.Drawing.Point(110, 52);
            this.txtSurname.Size     = new System.Drawing.Size(200, 22);

            // lblPhone
            this.lblPhone.Text     = "Telefon:";
            this.lblPhone.Location = new System.Drawing.Point(20, 90);
            this.lblPhone.Size     = new System.Drawing.Size(80, 20);

            // txtPhone
            this.txtPhone.Location = new System.Drawing.Point(110, 87);
            this.txtPhone.Size     = new System.Drawing.Size(200, 22);

            // lblAddress
            this.lblAddress.Text     = "Adres:";
            this.lblAddress.Location = new System.Drawing.Point(20, 125);
            this.lblAddress.Size     = new System.Drawing.Size(80, 20);

            // txtAddress
            this.txtAddress.Location = new System.Drawing.Point(110, 122);
            this.txtAddress.Size     = new System.Drawing.Size(200, 22);

            // lblBalance
            this.lblBalance.Text     = "Bakiye:";
            this.lblBalance.Location = new System.Drawing.Point(20, 160);
            this.lblBalance.Size     = new System.Drawing.Size(80, 20);

            // txtBalance
            this.txtBalance.Location = new System.Drawing.Point(110, 157);
            this.txtBalance.Size     = new System.Drawing.Size(200, 22);

            // btnAdd
            this.btnAdd.Text          = "Ekle";
            this.btnAdd.Location      = new System.Drawing.Point(20, 200);
            this.btnAdd.Size          = new System.Drawing.Size(85, 32);
            this.btnAdd.BackColor     = System.Drawing.Color.FromArgb(46, 117, 182);
            this.btnAdd.ForeColor     = System.Drawing.Color.White;
            this.btnAdd.FlatStyle     = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Click        += new System.EventHandler(this.btnAdd_Click);

            // btnUpdate
            this.btnUpdate.Text       = "Güncelle";
            this.btnUpdate.Location   = new System.Drawing.Point(115, 200);
            this.btnUpdate.Size       = new System.Drawing.Size(85, 32);
            this.btnUpdate.BackColor  = System.Drawing.Color.FromArgb(255, 153, 0);
            this.btnUpdate.ForeColor  = System.Drawing.Color.White;
            this.btnUpdate.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Click     += new System.EventHandler(this.btnUpdate_Click);

            // btnDelete
            this.btnDelete.Text       = "Sil";
            this.btnDelete.Location   = new System.Drawing.Point(210, 200);
            this.btnDelete.Size       = new System.Drawing.Size(85, 32);
            this.btnDelete.BackColor  = System.Drawing.Color.FromArgb(192, 0, 0);
            this.btnDelete.ForeColor  = System.Drawing.Color.White;
            this.btnDelete.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Click     += new System.EventHandler(this.btnDelete_Click);

            // btnClear
            this.btnClear.Text        = "Temizle";
            this.btnClear.Location    = new System.Drawing.Point(305, 200);
            this.btnClear.Size        = new System.Drawing.Size(85, 32);
            this.btnClear.BackColor   = System.Drawing.Color.FromArgb(89, 89, 89);
            this.btnClear.ForeColor   = System.Drawing.Color.White;
            this.btnClear.FlatStyle   = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Click      += new System.EventHandler(this.btnClear_Click);

            // dataGridView1
            this.dataGridView1.Location                  = new System.Drawing.Point(20, 250);
            this.dataGridView1.Size                      = new System.Drawing.Size(740, 300);
            this.dataGridView1.ReadOnly                  = true;
            this.dataGridView1.AllowUserToAddRows        = false;
            this.dataGridView1.AllowUserToDeleteRows     = false;
            this.dataGridView1.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.AutoSizeColumnsMode       = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor           = System.Drawing.Color.White;
            this.dataGridView1.CellClick                += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);

            // CustomerForm
            this.Text            = "Müşteri Yönetimi";
            this.ClientSize      = new System.Drawing.Size(780, 580);
            this.StartPosition   = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox     = false;

            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblSurname);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataGridView1);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label      lblName, lblSurname, lblPhone, lblAddress, lblBalance;
        private System.Windows.Forms.TextBox    txtName, txtSurname, txtPhone, txtAddress, txtBalance;
        private System.Windows.Forms.Button     btnAdd, btnUpdate, btnDelete, btnClear;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
