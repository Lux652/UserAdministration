using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DatabaseService;
using System.Configuration;

namespace WindowsFormsUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Crud Crud = new Crud();
            List < User >lUsers= Crud.GetUsers();
            DataGridViewUsers.DataSource = lUsers;

            DataGridViewImageColumn oEditButton = new DataGridViewImageColumn();
            oEditButton.Image = Image.FromFile("F:/dotnet/update.png");
            oEditButton.Width = 20;
            oEditButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oEditButton);


            DataGridViewImageColumn oDeleteButton = new DataGridViewImageColumn();
            oDeleteButton.Image = Image.FromFile("F:/dotnet/delete.png");
            oDeleteButton.Width = 20;
            oDeleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            DataGridViewUsers.Columns.Add(oDeleteButton);

            DataGridViewUsers.AutoGenerateColumns = false; //program neće sam stvoriti sve kolone
        }

        private void DataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewUsers.Rows[e.RowIndex].Selected = true;//koji je retka je kliknut, klikom na gumbic u odredenom retku taj redat bude selektiran, redak se zaplavi n stuff
            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(5) && e.RowIndex != -1)//ako je index trenutne celije jednak 5(broj kolona,krece od  0) i ako index retka nije -1 onda ide radnja
            {
                FormEditUser FormEditUser = new FormEditUser(this);//kreiraj novu formu yo;this salje sam sebe drugoj formi, this je objekt prve forme
                FormEditUser.lblEditUserID.Text =DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();//upuca text u labelu iz pritisnutog retka
                FormEditUser.lblEditUsername.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormEditUser.inptEditPassword.Text =DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormEditUser.inptEditName.Text = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormEditUser.inptEditSurname.Text =DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormEditUser.Show();//prikazi formu yo

            }

            if (DataGridViewUsers.CurrentCell.ColumnIndex.Equals(6) && e.RowIndex != -1)
            {
                FormDeleteUser FormDeleteUser = new FormDeleteUser(this);
                FormDeleteUser.ID = DataGridViewUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
                FormDeleteUser.Username = DataGridViewUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                FormDeleteUser.Password = DataGridViewUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                FormDeleteUser.Name = DataGridViewUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
                FormDeleteUser.Surname = DataGridViewUsers.Rows[e.RowIndex].Cells[4].Value.ToString();
                FormDeleteUser.Show();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            AddUser AddUser = new AddUser(this);
            AddUser.Show();
        }

        private void oProgramuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by Unuk \n Version 0.1 \n Author Crkva \n Year 2017");
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void izlazToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void noviKorisnikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddUser AddBre = new AddUser(this);
            AddBre.Show();

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string sUsername = inptSearch.Text;
            Crud Crud = new Crud();
            DataGridViewUsers.DataSource = Crud.Search(sUsername);
        }
    }
}
