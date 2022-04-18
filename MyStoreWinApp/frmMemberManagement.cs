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
    public partial class frmMemberManagement : Form
    {
        private Admin admin;
        private MemberRepository memberRepository;
        private frmLogin loginForm;

        public frmMemberManagement(Admin admin, frmLogin loginForm)
        {
            this.admin = admin;
            this.loginForm = loginForm;
            memberRepository = new MemberRepository();
            InitializeComponent();
        }

        private void loadTableData ()
        {

        }

        private void logout_Click(object sender, EventArgs e)
        {
            //logout
            loginForm.Show();
            admin = null;

            this.Hide();
        }
    }
}
