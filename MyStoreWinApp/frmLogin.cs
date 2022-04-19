using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessObject;
using DataAccess.repository;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {

        private MemberRepository memberRepository;
        public frmLogin()
        {
            memberRepository = new MemberRepository(); 
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //start authentication
                string email = tbEmail.Text;
                string password = tbPassword.Text;
                MemberObject authenticatedUser = memberRepository.CheckLogin(email, password);

                if(authenticatedUser != null)
                {
                    RedirectForm(authenticatedUser);
                } else
                {
                    MessageBox.Show("Invalid account");
                }

            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Email can't be blank!");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password can't be blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, null);
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void RedirectForm(MemberObject authenticatedUser) 
        {
            if (authenticatedUser != null)
            {
                tbEmail.ResetText();
                tbPassword.ResetText();
                if (authenticatedUser is Admin)
                {

                    frmMemberManagement frmMemberManagement = new frmMemberManagement(authenticatedUser as Admin, this);
                    frmMemberManagement.FormClosed += (s, e) => this.Close();
                    frmMemberManagement.Show();
                    this.Hide();
                } else
                {
                    frmUpdate frmUpdate = new frmUpdate(authenticatedUser, this);
                    frmUpdate.FormClosed += (s, e) => this.Close();
                    frmUpdate.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Can't login, try again!");
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
