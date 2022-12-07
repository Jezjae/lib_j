using lib_j.control;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j.model
{

    [Serializable]
    public class Membership
    {
        private static Membership MembershipInstance = null;

        public static Membership Instance               //싱글톤 패턴으로 선언
        {
            get
            {
                if (MembershipInstance == null)
                    MembershipInstance = new Membership();
                return MembershipInstance;
            }
        }

        private string id;
        private string pw;
        private string name;
        private int age;
        private string phone;
        private string address;
        private int bookNum;

        public Membership()
        {

        }

        public Membership(string id, string pw, string name, int age, string phone, string address, int bookNum)
        {
            this.id = id;
            this.pw = pw;
            this.name = name;
            this.age = age;
            this.phone = phone;
            this.address = address;
            this.bookNum = bookNum;
        }

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Phone
        {
            get { return phone; }
            set{ phone = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public int BookNum
        {
            get { return bookNum; }
            set { bookNum = value; }
        }
    }
}
