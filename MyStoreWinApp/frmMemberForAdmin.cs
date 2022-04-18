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
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if(cbRole.Text.Equals("Admin"))
                {
                    return new Admin()
                    {
                        MemberID = tbId.Text,
                        MemberName = tbName.Text,
                        Email = tbEmail.Text,
                        City = cbCity.Text,
                        Country = cbCountry.Text,
                        Role = cbRole.Text
                    };
                } else
                {
                    return new MemberObject()
                    {
                        MemberID = tbId.Text,
                        MemberName = tbName.Text,
                        Email = tbEmail.Text,
                        City = cbCity.Text,
                        Country = cbCountry.Text,
                        Role = cbRole.Text
                    };
                }
            }

            return null;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbId.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Id can't be blank!");
            } else if (memberRepository.GetMemberById(new Admin(), tbId.Text) != null)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbId, "Id can't be duplicated!");
            } else
            {
                e.Cancel = false;
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

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                btnOk.DialogResult = DialogResult.OK;
            } else
            {
                btnOk.DialogResult = DialogResult.None;
                
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
    }
}
