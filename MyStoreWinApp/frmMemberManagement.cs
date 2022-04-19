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
            //change welcome
            username.Text = admin.MemberName;

            loadTableData(delegate (List<MemberObject> list)
            {
                return list; //get all
            });
        }

        private void search_Click(object sender, EventArgs e)
        {
            string searchId = this.searchId.Text;
            string searchName = this.searchName.Text;

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
            string searchCity = this.searchCity.Text;
            string searchCountry = this.searchCountry.Text;

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

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteId = (string)memberDataGrid.Rows[memberDataGrid.CurrentCell.RowIndex].Cells[0].Value;

                if (deleteId != null)
                {
                    if (deleteId.Equals(admin.MemberID))
                    {
                        MessageBox.Show("You can't delete yourself!");
                    }
                    else
                    {
                        bool deleteRes = memberRepository.DeleteMember(admin, deleteId);
                        if (deleteRes)
                        {
                            MessageBox.Show("Delete successfully");
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete");
                        }
                    }
                }
            } finally
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return list;
                });
            }
        }

        private void createMember_Click(object sender, EventArgs e)
        {
            try
            {
                frmMemberForAdmin frmMemberForAdmin = new frmMemberForAdmin("create", null);

                if (frmMemberForAdmin.ShowDialog() == DialogResult.OK)
                {
                    //create member
                    MemberObject memberObject = frmMemberForAdmin.GetMemberObject();

                    bool createRes = memberRepository.CreateMember(admin, memberObject);
                    if (createRes) MessageBox.Show("Create successfully");
                    else MessageBox.Show("Failed to create");
                }
            } finally
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return list;
                });
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                string updateId = (string)memberDataGrid.Rows[memberDataGrid.CurrentCell.RowIndex].Cells[0].Value;

                if (updateId != null) {
                    MemberObject updateMember = memberRepository.GetMemberById(admin, updateId);
                    frmMemberForAdmin frmMemberForAdmin = new frmMemberForAdmin("update", updateMember);

                        if (frmMemberForAdmin.ShowDialog() == DialogResult.OK)
                        {
                            //create member
                            MemberObject memberObject = frmMemberForAdmin.GetMemberObject();

                            bool updateRes = memberRepository.UpdateMember(admin, updateId, memberObject);
                            if (updateRes) MessageBox.Show("Update successfully");
                            else MessageBox.Show("Failed to update");
                        }
                }
            }
            finally
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    return list;
                });
            }
        }

        private void chkSort_CheckedChanged(object sender, EventArgs e)
        {
            string searchCity = this.searchCity.Text;
            string searchCountry = this.searchCountry.Text;
            string searchId = this.searchId.Text;
            string searchName = this.searchName.Text;
            bool checkedValue = chkSort.Checked;

            if (!string.IsNullOrWhiteSpace(searchId) || !string.IsNullOrWhiteSpace(searchName))
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    List<MemberObject> list1 = memberRepository.SearchMemberByIdAndName(admin, searchName, searchId);
                    List<MemberObject> list2 = memberRepository.GetMemberByCityAndCountry(admin, searchCity, searchCountry);

                    List<MemberObject> combineList = list1.Intersect(list2).ToList();

                    if(checkedValue)
                    {
                        return combineList.OrderBy(s => s.MemberName).ToList();
                    } else
                    {
                        return combineList;
                    }
                });
            }
            else
            {
                loadTableData(delegate (List<MemberObject> list)
                {
                    if (checkedValue)
                    {
                        return list.OrderBy(s => s.MemberName).ToList();
                    }
                    else
                    {
                        return list;
                    }
                });
            }
        }
    }
}
