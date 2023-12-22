using DoAnQuanLyQuanNhau.DAO;
using DoAnQuanLyQuanNhau.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnQuanLyQuanNhau
{
    public partial class frmAccountProfile : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; InfoAccount(loginAccount); }
        }

        public frmAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }

        private void InfoAccount(Account acc)
        {
            txbNameAcc.Text = LoginAccount.FullName;
            txbAddressAcc.Text = LoginAccount.Address;
            txbPhoneAcc.Text = LoginAccount.Phone;
            txtUsernameAcc.Text = LoginAccount.Username;
        }


        void UpdateAccountInfo()
        {
            string fullName = txbNameAcc.Text;
            string address = txbAddressAcc.Text;
            string phone = txbPhoneAcc.Text;
            string username = txtUsernameAcc.Text;
            string password = txtPasswordAcc.Text;
            string newPass = txtNewPasswordAcc.Text;
            string renewPass = txbReNewPassAcc.Text;

            if (!newPass.Equals(renewPass))
            {
                MessageBox.Show("Không khớp với mật khẩu mới!");
            }
            else
            {
                if (AccountDAO.Instance.UpdateAccount(fullName,address,phone,username,password,newPass))
                {
                    MessageBox.Show("Cập nhật thành công");
                    if (updateAccount != null)
                        updateAccount(this, new AccountEvent(AccountDAO.Instance.GetAccountByUserName(username)));
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khấu");
                }
            }
        }

        private event EventHandler<AccountEvent> updateAccount;
        public event EventHandler<AccountEvent> UpdateAccount
        {
            add { updateAccount += value; }
            remove { updateAccount -= value; }
        }

        private void frmAccountProfile_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txbPhoneAcc_KeyDown(object sender, KeyEventArgs e)
        { 
            
        }

        private void txbPhoneAcc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        public class AccountEvent : EventArgs
        {
            private Account acc;

            public Account Acc
            {
                get { return acc; }
                set { acc = value; }
            }

            public AccountEvent(Account acc)
            {
                this.Acc = acc;
            }
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            UpdateAccountInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnExitAccProfile_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
