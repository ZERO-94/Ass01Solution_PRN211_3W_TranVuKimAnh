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
    public partial class frmMemberForAdmin : Form
    {
        private string operationType;
        private MemberObject member;
        private MemberRepository memberRepository;
        public frmMemberForAdmin(string operationType, MemberObject updateMember)
        {
            this.operationType = operationType;
            member = updateMember;
            memberRepository = new MemberRepository();
            
            InitializeComponent();
            btnCancel.CausesValidation = false;
        }

        public MemberObject GetMemberObject()
        {
            MemberObject newMember = null;
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(cbRole.Text.Equals("Admin"))
                {
                    newMember = new Admin()
                    {
                        MemberName = tbName.Text,
                        Email = tbEmail.Text,
                        City = cbCity.Text,
                        Country = cbCountry.Text,
                        Role = cbRole.Text
                    };
                } else
                {
                    newMember = new MemberObject()
                    {
                        MemberName = tbName.Text,
                        Email = tbEmail.Text,
                        City = cbCity.Text,
                        Country = cbCountry.Text,
                        Role = cbRole.Text
                    };
                }

                if(operationType.Equals("create"))
                {
                    newMember.MemberID = tbId.Text;
                    newMember.Password = tbPassword.Text;
                } else if(operationType.Equals("update"))
                {
                    newMember.MemberID = member.MemberID;
                    newMember.Password = tbPassword.Text;
                }

                return newMember;
            }

            return null;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("create"))
            {
                if (string.IsNullOrWhiteSpace(tbId.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbId, "Id can't be blank!");
                }
                else if (memberRepository.GetMemberById(new Admin(), tbId.Text) != null)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbId, "Id can't be duplicated!");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbName, "Name can't be blank!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Email can't be blank!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbCity, "City can't be blank!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbCountry.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbCountry, "Country can't be blank!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void cbRole_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbRole.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(cbRole, "Country can't be blank!");
            }
            else
            {
                e.Cancel = false;
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("create"))
            {
                if (string.IsNullOrWhiteSpace(tbPassword.Text))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPassword, "Email can't be blank!");
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void frmMemberForAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMemberForAdmin_Load(object sender, EventArgs e)
        {
            

            if(operationType.Equals("create"))
            {
                //show all
                lbOperation.Text = "Create new member";
            } else if(operationType.Equals("update"))
            {
                //hide id and password
                lbOperation.Text = "Update member with ID: " + member.MemberID; 
                tbId.Hide();
                lbId.Hide();
                tbPassword.Hide();
                lbPassword.Hide();

                //load data
                tbId.Text = member.MemberID;
                tbEmail.Text = member.Email;
                tbName.Text = member.MemberName;
                cbCity.Text = member.City;
                cbCountry.Text = member.Country;
                cbRole.Text = member.Role;
                tbPassword.Text = member.Password;
            }
        }
    }
}
