using lib_j.control;
using lib_j.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lib_j
{
    public class SignUp
    {
        public void signUp()
        {
            Screen.Instance.basicScreen();
            Console.Write("      회원 ID 입력 (English and Number) : ");
            string id = Console.ReadLine();
            Console.WriteLine();
            Console.Write("      회원 비밀번호 입력 (English and Number) : ");
            string pw = Console.ReadLine();
            Console.WriteLine();
            Console.Write("      회원 이름 입력 (공백 없이 2 ~ 5 글자의 한글) : ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("      " + name + " 님의 나이 입력 : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("      " + name + " 님의 핸드폰 번호 입력 ('-' 제외하고 입력) : ");
            string phone = Console.ReadLine();
            Console.WriteLine();
            Console.Write("      " + name + " 님의 주소 입력 : ");
            string address = Console.ReadLine();
            Console.WriteLine();

            Membership.Instance.Id = id;
            Membership.Instance.Pw = pw;
            Membership.Instance.Name = name;
            Membership.Instance.Age = age;
            Membership.Instance.Phone = phone;
            Membership.Instance.Address = address;
            Membership.Instance.BookNum = 0;

            Library.memberList.Add(Membership.Instance);

            Custom.Instance.updataMemberListData(Library.memberList);

            Console.WriteLine();
            Console.WriteLine("      회원가입이 완료 되었습니다 ! ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      'Enter'를 눌러주세요. ");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
