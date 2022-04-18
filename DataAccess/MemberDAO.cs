using BusinessObject;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataAccess.dao
{
    public class MemberDAO
    {

        //init member list
        private List<MemberObject> memberList = new List<MemberObject>()
        {
            new MemberObject() {MemberID = "E123", City = "HCM", Country = "VN", Email = "adam@gmail.com", MemberName = "Adam", Password = "123456", Role = "Member"},
            new MemberObject() {MemberID = "E124", City = "HN", Country = "VN", Email = "eva@gmail.com", MemberName = "Eva", Password = "123456", Role = "Member"}
        };

        private static MemberDAO instance;
        private static readonly object instanceLock = new object();

        //Use singleton design pattern
        private MemberDAO()
        {
            //get default account
            using StreamReader streamReader = new StreamReader(Directory.GetCurrentDirectory() + @"\appsettings.json");
            string json = streamReader.ReadToEnd();
            Admin admin = JsonConvert.DeserializeObject<Admin>(json);
            //add to list
            memberList.Add(admin);
        }

        public static MemberDAO Instance
        {
            get
            {
                lock(instanceLock)
                {
                    if(instance == null)
                    {
                        instance = new MemberDAO();
                    }

                    return instance;
                }

            }
        }

        public bool CreateMember(MemberObject newMember)
        {
            if(memberList.Contains(newMember))
            {
                return false;
            }

            memberList.Add(newMember);
            return true;
        }

        public bool DeleteMember(string id)
        {
            MemberObject memberToRemove = memberList.SingleOrDefault(member => member.MemberID.Equals(id));
            if (memberList != null)
            {
                memberList.Remove(memberToRemove);
                return true;
            }

            return false;
        }

        public bool UpdateMember(string id, MemberObject updatedMemberInfo)
        {
            MemberObject updatedMember = memberList.SingleOrDefault(member => member.MemberID.Equals(id));
            if(updatedMember != null)
            {
                updatedMember.City = updatedMemberInfo.City;
                updatedMember.Country = updatedMemberInfo.Country;
                updatedMember.MemberName = updatedMemberInfo.MemberName;
                updatedMember.Email = updatedMemberInfo.Email;
                updatedMember.Role = updatedMemberInfo.Role;
                return true;
            }

            return false;
        }

        public bool ChangePassword(string id, string oldPassword, string newPassword)
        {
            MemberObject updatedMember = memberList.SingleOrDefault(member => member.MemberID.Equals(id) && member.Password.Equals(oldPassword));
            if (updatedMember != null)
            {
                updatedMember.Password = newPassword;
                return true;
            }

            return false;
        }

        public MemberObject GetMemberById(string id) => memberList.SingleOrDefault(member => member.MemberID.Equals(id));

        public List<MemberObject> GetAllMembers() => memberList;

        public List<MemberObject> SearchMemberByName(string searchValue) => memberList.Where(member => member.MemberName.Contains(searchValue)).ToList();

        public List<MemberObject> SearchMemberById(string searchValue) => memberList.Where(member => member.MemberID.Contains(searchValue)).ToList();

        public List<MemberObject> SearchMemberByIdAndName(string searchName, string searchId) => memberList.Where(member => member.MemberName.Contains(searchName) && member.MemberID.Contains(searchId)).ToList();

        public List<MemberObject> GetMemberByCity(string city) => memberList.Where(member => member.City.Equals(city)).ToList();

        public List<MemberObject> GetMemberByCountry(string country) => memberList.Where(member => member.Country.Equals(country)).ToList();

        public List<MemberObject> GetMemberByCityAndCountry(string city, string country) => memberList.Where(member => member.City.Equals(city) && member.Country.Equals(country)).ToList();

        public MemberObject CheckLogin(string email, string password) {
            return memberList.SingleOrDefault(member => member.Email.Equals(email) && member.Password.Equals(password));
        }
    }
}
