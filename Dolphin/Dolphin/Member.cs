using System;
using System.Collections.Generic;
using System.Text;

namespace Dolphin
{
    class Member
    {
        string name;
        string address;
        string phoneNumber;
        string birthDay;
        DateTime enrollDate;

        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
        public string BirthDay { get => birthDay; set => birthDay = value; }
        public DateTime EnrollDate { get => enrollDate; set => enrollDate = value; }
    }
}
