using lib_j.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j.control
{
    public class Manager
    {
        public void manager()
        {
            string managerPw = "990304";
            Screen.Instance.basicScreen();
            Console.Write("      관리자 비밀번호를 입력하세요 : ");

            bool isPw = false;
            while (isPw == false)
            {
                string pw = Console.ReadLine();

                if (pw == managerPw)
                {
                    isPw = true;
                    break;
                }
                else
                {
                    Console.Write("      비밀번호가 틀렸습니다. 다시 입력하세요. (English and Number) : ");
                }
            }

            bool isManager = true;
            while (isManager == true)
            {
                Console.Clear();
                Screen.Instance.managerScreen();
                string num = Console.ReadLine();

                if (num == "1")
                {
                    Console.Clear();
                    Custom.Instance.readMemberListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                   ▣ 등록 회원 리스트 ▣");
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < Library.memberList.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("   회원 이름 : " + Library.memberList[i].Name);
                        Console.WriteLine();
                        Console.WriteLine("   회원 나이 : " + Library.memberList[i].Age);
                        Console.WriteLine();
                        Console.WriteLine("   회원 휴대폰 번호 : " + Library.memberList[i].Phone);
                        Console.WriteLine();
                        Console.WriteLine("   회원 주소 : " + Library.memberList[i].Address);
                        Console.WriteLine();
                        Console.WriteLine("   대출한 권 수 : " + Library.memberList[i].BookNum);
                        Console.WriteLine();
                        Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("      등록된 총 회원 수 : " + Library.memberList.Count + " 명");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }

                } //등록회원 리스트
                else if (num == "2")
                {
                    Console.Clear();
                    Custom.Instance.readBookListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 책 리스트 ▣");
                    Console.WriteLine();
                    Console.WriteLine();

                    for (int i = 0; i < Library.bookList.Count; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine("   책 ID 넘버 : " + Library.bookList[i].Id);
                        Console.WriteLine();
                        Console.WriteLine("   책 이름 : " + Library.bookList[i].Title);
                        Console.WriteLine();
                        Console.WriteLine("   책 저자 : " + Library.bookList[i].Writer);
                        Console.WriteLine();
                        Console.WriteLine("   책 출판사 : " + Library.bookList[i].Publisher);
                        Console.WriteLine();
                        Console.WriteLine("   책 가격 : " + Library.bookList[i].Price);
                        Console.WriteLine();
                        Console.WriteLine("   책 수량 : " + Library.bookList[i].Quantity);
                        Console.WriteLine();
                        Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
                    }

                    Console.WriteLine();
                    Console.WriteLine("      등록된 총 책의 수 : " + Library.bookList.Count + " 권");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }
                } //책 리스트
                else if (num == "3")
                {
                    Console.Clear();
                    Custom.Instance.readMemberListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 회원 검색 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   검색 하려는 회원의 이름 : ");

                    bool isName = false;
                    while(isName == false)
                    {
                        string name = Console.ReadLine();

                        for (int i = 0; i < Library.memberList.Count; i++)
                        {
                            if (Library.memberList[i].Name == name)
                            {
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("   이름 : " + Library.memberList[i].Name);
                                Console.WriteLine();
                                Console.WriteLine("   나이 : " + Library.memberList[i].Age);
                                Console.WriteLine();
                                Console.WriteLine("   핸드폰 번호 : " + Library.memberList[i].Phone);
                                Console.WriteLine();
                                Console.WriteLine("   주소 : " + Library.memberList[i].Address);
                                isName = true;
                                break;
                            }
                        }
                        if (isName == false)
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                      ▣ 회원 검색 ▣");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   검색하려는 회원의 이름을 정확히 입력하세요. : ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }

                } //회원 검색
                else if (num == "4")
                {
                    Console.Clear();
                    Custom.Instance.readMemberListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 회원 삭제 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   삭제 하려는 회원의 이름 : ");

                    bool isName = false;
                    while (isName == false)
                    {
                        string name = Console.ReadLine();

                        for (int i = 0; i < Library.memberList.Count; i++)
                        {
                            if (Library.memberList[i].Name == name)
                            {
                                Library.memberList.Remove(Library.memberList[i]);
                                Custom.Instance.updataMemberListData();
                                isName = true;
                                break;
                            }
                        }
                        if (isName == false)
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                      ▣ 회원 삭제 ▣");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   삭제하려는 회원의 이름을 정확히 입력하세요. : ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("   정상적으로 삭제 되었습니다 ! ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }
                } //회원 삭제
                else if (num == "5")
                {
                    Console.Clear();
                    Custom.Instance.readBookListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                    ▣ 책 정보 수정 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   수량 수정하려는 책의 이름 (띄어쓰기 상관없이 입력 가능) : ");

                    bool isTitle = false;
                    while (isTitle == false)
                    {
                        string title = Console.ReadLine();

                        for (int i = 0; i < Library.bookList.Count; i++)
                        {
                            if (Library.bookList[i].Title == title)
                            {
                                Console.Clear();
                                Screen.Instance.basicScreen();
                                Console.WriteLine();
                                Console.WriteLine("                    ▣ 책 정보 수정 ▣");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("   책 '" + Library.bookList[i].Title + "' 수정할 수량 입력 : ");
                                Library.bookList[i].Quantity = Convert.ToInt32(Console.ReadLine()); ;
                                Custom.Instance.updataBookListData();
                                isTitle = true;
                                break;
                            }
                        }

                        if (isTitle == false)
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                    ▣ 책 정보 수정 ▣");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   정확한 책의 이름을 입력해 주세요. (띄어쓰기 상관없이 입력 가능) : ");
                        }
                    }
                        Console.WriteLine();
                        Console.WriteLine("   책 정보가 수정 되었습니다 ! ");
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                        string outNum = Console.ReadLine();

                        if (outNum == "1")
                        {
                            isManager = false;
                            break;
                        }
                    
                } //책 정보 수정
                else if (num == "6")
                {
                    Console.Clear();
                    Custom.Instance.readBookListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                    ▣ 신규 책 등록 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("      책 ID 입력 (입력 예시 : ID 1234) : ");
                    string id = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("      책 이름 입력 : ");
                    string title = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("      책 저자 입력 : ");
                    string writer = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("      책 출판사 입력 : ");
                    string publisher = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("      책 가격 입력 : ");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.Write("      책 수량 입력 : ");
                    int quantity = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("      정상적으로 등록 되었습니다 ! ");

                    Book.Instance.Id = id;
                    Book.Instance.Title = title;
                    Book.Instance.Writer = writer;
                    Book.Instance.Publisher = publisher;
                    Book.Instance.Price = price;
                    Book.Instance.Quantity = quantity;

                    Library.bookList.Add(Book.Instance);

                    Custom.Instance.updataBookListData();

                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();
                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }

                } //신규 책 등록
                else if (num == "7")
                {
                    Console.Clear();
                    Custom.Instance.readBookListData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 책 삭제 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   삭제 하려는 책의 이름 : ");

                    bool isTitle = false;
                    while (isTitle == false)
                    {
                        string title = Console.ReadLine();

                        for (int i = 0; i < Library.bookList.Count; i++)
                        {
                            if (Library.bookList[i].Title == title)
                            {
                                Library.bookList.Remove(Library.bookList[i]);
                                isTitle = true;
                                break;
                            }
                        }
                        if (isTitle == false)
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                      ▣ 책 삭제 ▣");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   삭제하려는 책의 이름을 정확히 입력하세요. : ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("   정상적으로 삭제 되었습니다 ! ");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }
                } //책 삭제
                else if (num == "8")
                {
                    Console.Clear();
                    Custom.Instance.readHistoryData();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                 ▣ 책 대여 / 반납 기록 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    for (int i = 0; i < Library.historyList.Count; i++)
                    {
                        Console.WriteLine("   " + Library.historyList[i].Name + "님이 책 '" + Library.historyList[i].Title + "' 을(를) " +
                            Library.historyList[i].Time + "에 " + Library.historyList[i].Lib + "했습니다.");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.Write("   관리자 메뉴로 돌아가기는 'Enter'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Console.ReadLine();

                    if (outNum == "1")
                    {
                        isManager = false;
                        break;
                    }
                } //책 대여 반납 기록
                else if (num == "9")
                {
                    isManager = false;
                    break;
                } //처음으로 돌아가기

            }

            Console.Clear();

        }
    }
}

