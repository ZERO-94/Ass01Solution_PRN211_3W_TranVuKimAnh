using System;

namespace BusinessObject
{
    public class MemberObject: IComparable<MemberObject>
    {
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Role { get; set; }

        public int CompareTo(MemberObject other)
        {
            return MemberID.CompareTo(other.MemberID);
        }
    }
}
