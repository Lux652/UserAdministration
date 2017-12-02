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

namespace WindowsFormsUsers
{
    public partial class AddUser : Form
    {
        private readonly Form1 FormUserList;
        public AddUser(Form1 FormUser)
        {
            InitializeComponent();
            FormUserList = FormUser;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User oUser = new User();           
            oUser.sUserFirstName = inptAddName.Text;
            oUser.sUserLastName = inptAddSurname.Text;
            oUser.sUserPassword = inptAddPassword.Text;
            oUser.sUserName = inptAddUsername.Text;
            Crud Crud = new Crud();
            Crud.AddUsers(oUser);
            this.FormUserList.DataGridViewUsers.DataSource = Crud.GetUsers();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
