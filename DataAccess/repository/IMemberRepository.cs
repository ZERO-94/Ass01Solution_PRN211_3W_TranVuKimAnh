using BusinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.repository
{
    public interface IMemberRepository
    {
        public bool CreateMember(Object caller, MemberObject newMember);

        public bool DeleteMember(Object caller, string id);

        public bool UpdateMember(Object caller, string id, MemberObject updatedMemberInfo);

        public MemberObject GetMemberById(Object caller, string id);

        public List<MemberObject> GetAllMembers(Object caller);

        public List<MemberObject> SearchMemberByName(Object caller, string name);

        public List<MemberObject> SearchMemberById(Object caller, string id);

        public List<MemberObject> GetMemberByCity(Object caller, string city);

        public List<MemberObject> GetMemberByCountry(Object caller, string country);

        public MemberObject CheckLogin(string email, string password);

        public bool ChangePassword(Object caller, string id, string oldPassword, string newPassword);

        public List<MemberObject> SearchMemberByIdAndName(Object caller, string searchName, string searchId);

        public List<MemberObject> GetMemberByCityAndCountry(Object caller, string city, string country);
    }
}
