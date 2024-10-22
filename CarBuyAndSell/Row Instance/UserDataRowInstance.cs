using CarBuyAndSell.Dto;
using CarBuyAndSell.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarBuyAndSell.Row_Instance
{
    public partial class UserDataRowInstance : UserControl
    {
        GlobalProcedure globalProcedure = new GlobalProcedure();
        private UserDto user;
        public UserDataRowInstance(UserDto bid)
        {
            InitializeComponent();
            this.user = bid;
            if (!this.globalProcedure.FncConnectToDatabase())
                MessageBox.Show("Not Connected");
            lblAddress.Text = user.Address;
            lblName.Text = $"{user.FirstName} {user.LastName}";
            lblNumber.Text = user.Number;
            lblUsername.Text = user.Username;
            lblRole.Text = user.RoleName;
            lblUserId.Text = $"{user.UserId}";
        }

        private void BtnDetails_Click(object sender, EventArgs e)
        { 
            this.Parent.Parent.Controls.Clear();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                globalProcedure.ProcDeleteUser(user.UserId);
                MessageBox.Show("User Deleted");
            }
            else if (dialogResult == DialogResult.No)
            {
                //do nothing
            }
            this.Parent.Invalidate();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            UserForm form = new UserForm(user);
            form.ShowDialog();
            this.Parent.Invalidate();
        }
    }
}
