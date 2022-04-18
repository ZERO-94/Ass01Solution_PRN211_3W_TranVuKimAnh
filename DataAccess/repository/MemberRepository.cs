using BusinessObject;
using DataAccess.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public class MemberRepository : IMemberRepository
    {
        private MemberDAO daoInstance;

        public MemberRepository()
        {
            daoInstance = MemberDAO.Instance;
        }

        public MemberObject CheckLogin(string email, string password)
        {
            MemberObject authenticatedMember =  daoInstance.CheckLogin(email, password);
            if (authenticatedMember != null && authenticatedMember.Role.Equals("Admin")) //authorized
            {
                return new Admin() { 
                    MemberID = authenticatedMember.MemberID,
                    MemberName = authenticatedMember.MemberName,
                    City = authenticatedMember.City,
                    Country = authenticatedMember.Country,
                    Email = authenticatedMember.Email,
                    Password = authenticatedMember.Password,
                    Role = authenticatedMember.Role,
                };
            }

            return authenticatedMember;
        }

        public bool CreateMember(Object caller, MemberObject newMember)
        {
            if(caller is Admin)
            {
                return daoInstance.CreateMember(newMember);
            }

            return false;
        }

        public bool DeleteMember(Object caller, string id)
        {
            if (caller is Admin)
            {
                Admin admin = (Admin)caller;
                if(!admin.MemberID.Equals(id))//can't delete itself
                {
                    return daoInstance.DeleteMember(id);
                }
            }

            return false;
        }

        public List<MemberObject> GetAllMembers(Object caller)
        {
            if (caller is Admin)
            {
                return daoInstance.GetAllMembers();
            }

            return null;
        }

        public List<MemberObject> GetMemberByCity(Object caller, string city)
        {
            if (caller is Admin)
            {
                return daoInstance.GetMemberByCity(city);
            }

            return null;
        }

        public List<MemberObject> GetMemberByCountry(Object caller, string country)
        {
            if (caller is Admin)
            {
                return daoInstance.GetMemberByCountry(country);
            }

            return null;
        }

        public MemberObject GetMemberById(Object caller, string id)
        {
            if (caller is Admin)
            {
                return daoInstance.GetMemberById(id);
            } 
            else
            {
                if(caller is MemberObject)
                {
                    MemberObject member = (MemberObject)caller;
                    if(member.MemberID.Equals(id))
                        return daoInstance.GetMemberById(id);

                    return null;
                }

                return null;
            } 
        }

        public List<MemberObject> SearchMemberByName(Object caller, string searchValue)
        {
            if (caller is Admin)
            {
                return daoInstance.SearchMemberByName(searchValue);
            }

            return null;
        }

        public List<MemberObject> SearchMemberById(Object caller, string searchValue)
        {
            if (caller is Admin)
            {
                return daoInstance.SearchMemberById(searchValue);
            }

            return null;
        }

        public bool UpdateMember(Object caller, string id, MemberObject updatedMemberInfo)
        {
            if (caller is Admin)
            {
                return daoInstance.UpdateMember(id, updatedMemberInfo);
            }
            else
            {
                if (caller is MemberObject)
                {
                    MemberObject member = (MemberObject)caller;
                    if (member.MemberID.Equals(id))
                        return daoInstance.UpdateMember(id, updatedMemberInfo);

                    return false;
                }

                return false;
            }
        }

        public bool ChangePassword(Object caller, string id, string oldPassword, string newPassword)
        {
            if (caller is Admin)
            {
                return daoInstance.ChangePassword(id, oldPassword, newPassword);
            }
            else
            {
                if (caller is MemberObject)
                {
                    MemberObject member = (MemberObject)caller;
                    if (member.MemberID.Equals(id))
                        return daoInstance.ChangePassword(id, oldPassword, newPassword);

                    return false;
                }

                return false;
            }
        }

        public List<MemberObject> SearchMemberByIdAndName(Object caller, string searchName, string searchId)
        {
            if (caller is Admin)
            {
                return daoInstance.SearchMemberByIdAndName(searchName, searchId);
            }

            return null;
        }

        public List<MemberObject> GetMemberByCityAndCountry(Object caller, string city, string country)
        {
            if (caller is Admin)
            {
                return daoInstance.GetMemberByCityAndCountry(city, country);
            }

            return null;
        }
    }
}
