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

        private delegate List<MemberObject> TableFilter(List<MemberObject> memberList);

        private void loadTableData (TableFilter filter)
        {
            DataTable memberTable = new DataTable();
            memberTable.Columns.Add("ID");
            memberTable.Columns.Add("Name");
            memberTable.Columns.Add("Email");
            memberTable.Columns.Add("City");
            memberTable.Columns.Add("Country");
            memberTable.Columns.Add("Role");

            //load data
            List<MemberObject> members = memberRepository.GetAllMembers(admin);

            //filter in here
            List<MemberObject> membersAfterFilter = filter(members);

            foreach(MemberObject member in membersAfterFilter)
            {
                memberTable.Rows.Add(member.MemberID, member.MemberName, member.Email, member.City, member.Country, member.Role);
            }

            memberDataGrid.DataSource = memberTable;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //logout
            loginForm.Show();
            admin = null;

            this.Hide();
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            loadTableData(delegate (List<MemberObject> list)
            {
                return list; //get all
            });
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchId = tbId.Text;
            string searchName = tbName.Text;

            if (!string.IsNullOrWhiteSpace(searchId) || !string.IsNullOrWhiteSpace(searchName))
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return memberRepository.SearchMemberByIdAndName(admin, searchName, searchId);
                });
            } else
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return list; //get all
                });
            }
        }

        private void filter_Click(object sender, EventArgs e)
        {
            string searchCity = cbCity.Text;
            string searchCountry = cbCountry.Text;

            if (!string.IsNullOrWhiteSpace(searchCity) || !string.IsNullOrWhiteSpace(searchCountry))
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return memberRepository.GetMemberByCityAndCountry(admin, searchCity, searchCountry);
                });
            } else
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return list; //get all
                });
            }
        }
    }
}
