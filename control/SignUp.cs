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
            Custom.Instance.readMemberListData();
            Screen.Instance.basicScreen();

            Console.Write("      회원 ID 입력 (English and Number) : ");
            string id = "";
            bool isOverlap = true;
            while (isOverlap == true)
            {
                id = Custom.Instance.ReadEngNum();
                int overlapCount = 0;
                for (int i = 0; i < Library.memberList.Count; i++)
                {
                    if (Library.memberList[i].Id == id)
                    {
                        overlapCount += 1;
                    }
                    
                }
                if ( overlapCount > 0 )
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.Write("      이미 가입된 아이디 입니다. 다른 ID를 입력해 주세요 : ");
                }
                else if (overlapCount == 0)
                {
                    isOverlap = false;
                    break;
                }
            }
            
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      회원 비밀번호 입력 (English and Number) : ");
            string pw = Custom.Instance.ReadEngNum();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      회원 이름 입력 (공백 없이 2 ~ 5 글자의 한글) : ");
            string name = "";
            bool isOverlap2 = true;
            while (isOverlap2 == true)
            {
                name = Custom.Instance.ReadKor();
                int overlapCount = 0;
                for (int i = 0; i < Library.memberList.Count; i++)
                {
                    if (Library.memberList[i].Name == name)
                    {
                        overlapCount += 1;
                    }

                }
                if (overlapCount > 0)
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.Write("      회원 ID 입력 (English and Number) : ");
                    Console.WriteLine(id); 
                    Console.WriteLine();
                    Console.Write("      회원 비밀번호 입력 (English and Number) : ");
                    Console.WriteLine(pw);
                    Console.WriteLine();
                    Console.Write("      이미 가입된 이름 입니다. 다른 이름을 입력해 주세요 : ");
                }
                else if (overlapCount == 0)
                {
                    isOverlap2 = false;
                    break;
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      " + name + " 님의 나이 입력 : ");
            int age = Convert.ToInt32(Custom.Instance.ReadPhone());
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      " + name + " 님의 핸드폰 번호 입력 ('-' 제외하고 입력) : ");
            string phone = Custom.Instance.ReadPhone();
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      " + name + " 님의 주소 입력 : ");
            string address = Custom.Instance.ReadString();
            Console.WriteLine();
            Console.WriteLine();

            Membership.Instance.Id = id;
            Membership.Instance.Pw = pw;
            Membership.Instance.Name = name;
            Membership.Instance.Age = age;
            Membership.Instance.Phone = phone;
            Membership.Instance.Address = address;
            Membership.Instance.BookNum = 0;

            Library.memberList.Add(Membership.Instance);

            Custom.Instance.updataMemberListData();

            Console.WriteLine();
            Console.WriteLine("      회원가입이 완료 되었습니다 ! ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("      'Space Bar'를 눌러주세요. ");
            Console.ReadLine();

            Console.Clear();
        }
    }
}
