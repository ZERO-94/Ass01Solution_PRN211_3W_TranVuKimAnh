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
    public partial class frmUpdate : Form
    {
        private MemberObject member;
        private frmLogin frmLogin;
        private MemberRepository memberRepository;
        private string operationType = "update";
        public frmUpdate(MemberObject member, frmLogin frmLogin)
        {
            this.member = member;
            this.frmLogin = frmLogin;
            memberRepository = new MemberRepository();
            InitializeComponent();
        }

        private void loadFormData()
        {
            //add data to form
            tbEmail.Text = member.Email;
            tbName.Text = member.MemberName;
            cbCity.Text = member.City;
            cbCountry.Text = member.Country;
            cbRole.Text = member.Role;
        }

        private void frmUpdate_Load(object sender, EventArgs e)
        {
            //init data
            username.Text = member.MemberName;

            //add data to form
            loadFormData();
        }

        private void update_Click(object sender, EventArgs e)
        {
            operationType = "update";
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                // update
                MemberObject newMemberInfo = new MemberObject()
                {
                    MemberID = member.MemberID,
                    MemberName = tbName.Text.Trim(),
                    Email = tbEmail.Text.Trim(),
                    City = cbCity.Text.Trim(),
                    Country = cbCountry.Text.Trim(),
                    Role = cbRole.Text.Trim()
                };

                bool updateRes = memberRepository.UpdateMember(member, member.MemberID, newMemberInfo);
                if (updateRes) MessageBox.Show("Update successfully");
                else MessageBox.Show("Failed to update");

                member = memberRepository.GetMemberById(member, member.MemberID);
                loadFormData();
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(tbName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbName, "Name can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbName, null);
                }
            }
        }

        private void frmUpdate_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(tbEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Email can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbEmail, null);
                }
            }
        }

        private void cbCity_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(cbCity.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbCity, "City can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbCity, null);
                }
            }
        }

        private void cbCountry_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(cbCountry.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbCountry, "Country can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbCountry, null);
                }
            }
        }

        private void cbRole_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(cbRole.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(cbRole, "Role can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(cbRole, null);
                }
            }
        }

        private void logout_Click(object sender, EventArgs e)
        {
            member = null;
            frmLogin.Show();
            this.Hide();
        }

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if(operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbOldPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbOldPassword, "Old password can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbOldPassword, null);
                }
            }
        }

        private void tbReConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbReConfirm.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbReConfirm, "Re-confirm password can't be blank");

                } else if (!tbOldPassword.Text.Equals(tbReConfirm.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbReConfirm, "Re-confirm password must be the same as old password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbReConfirm, null);
                }
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbNewPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbNewPassword, "New password can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbNewPassword, null);
                }
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            operationType = "changePassword";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // change password

                bool changePasswordRes = memberRepository.ChangePassword(member, member.MemberID, tbOldPassword.Text, tbNewPassword.Text);
                if (changePasswordRes) MessageBox.Show("Change password successfully");
                else MessageBox.Show("Invalid old password!");

                member = memberRepository.GetMemberById(member, member.MemberID);
                loadFormData();

                //rest form
                tbOldPassword.ResetText();
                tbReConfirm.ResetText();
                tbNewPassword.ResetText();
            }
        }
    }
}
