using lib_j.control;
using lib_j.model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j
{
    public class Login
    {
        public void logIn()
        {
            string tempId = ""; //로그인 정보 저장

            Console.Clear();

            Screen.Instance.basicScreen();

            Custom.Instance.readBookListData(); //정보 가져오기
            Custom.Instance.readMemberListData();

            Console.Write("      회원 ID를 입력하세요 (English and Number) : ");

            //반복시작
            bool isId = false;
            while (isId == false)
            {
                string id = Custom.Instance.ReadEngNum();
                Console.WriteLine();

                if (isId == false)
                {
                    for (int i = 0; i < Library.memberList.Count; i++)
                    {
                        if (Library.memberList[i].Id == id)
                        {
                            isId = true;
                            tempId = Library.memberList[i].Id;
                            break;
                        }
                    }
                    if (isId == false)
                    {
                        Console.Clear();
                        Screen.Instance.basicScreen();
                        Console.Write("      존재하지 않는 ID 입니다. 다시 입력하세요. (English and Number) : ");
                    }
                }
               
            }
            Console.WriteLine();
            Console.Write("      회원 비밀번호 입력 (English and Number) : ");
            bool isPw = false;
            while (isPw == false)
            {
                string pw = Custom.Instance.ReadPW();
                
                for (int i = 0; i < Library.memberList.Count; i++)
                {
                    if (Library.memberList[i].Pw == pw)
                    {
                        isPw = true;
                        break;
                    }
                }
                if (isPw == false)
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.Write("      회원 ID 입력 (English and Number) : ");
                    Console.WriteLine(tempId);
                    Console.WriteLine();
                    Console.Write("      비밀번호가 틀렸습니다. 다시 입력하세요. (English and Number) : ");
                }
            }

            bool isOutCheck = false;
            while (isOutCheck == false)
            {
                Console.Clear();
                Screen.Instance.libSub();
                string num = Custom.Instance.ReadPhone();

                if (num == "1")
                {
                    bool isBack = false;
                    while (isBack == false)
                    {
                        Console.Clear();
                        Screen.Instance.bookSearch();
                        string num2 = Custom.Instance.ReadString();

                        if (num2 == "1")
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                   ▣ 책 이름으로 검색 ▣");
                            Console.WriteLine();
                            Console.Write("   검색할 책 이름 입력 : ");
                            
                            bool isTitle = false;
                            while(isTitle == false)
                            {
                                string title = Custom.Instance.ReadString();

                                for (int i = 0; i < Library.bookList.Count; i++)
                                {
                                    if (Library.bookList[i].Title.Contains(title))
                                    {
                                        isTitle = true;
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("      책 ID 넘버 : " + Library.bookList[i].Id);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 이름 : " + Library.bookList[i].Title);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 저자 : " + Library.bookList[i].Writer);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 출판사 : " + Library.bookList[i].Publisher);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 가격 : " + Library.bookList[i].Price);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 수량 : " + Library.bookList[i].Quantity);
                                        Console.WriteLine();
                                    }
                                }
                                if (isTitle == false)
                                {
                                    Console.Clear();
                                    Screen.Instance.basicScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("                      ▣ 책 이름으로 검색 ▣");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.Write("   검색 결과가 없습니다. 검색하려는 책의 이름을 정확히 입력하세요. : ");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                            string outNum = Custom.Instance.ReadPhone();

                            if (outNum == "1")
                            {
                                Console.Clear();
                                isOutCheck = true;
                                break;
                            }

                        } //책 이름
                        else if (num2 == "2")
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                   ▣ 책 저자명으로 검색 ▣");
                            Console.WriteLine();
                            Console.Write("   검색할 책 저자명 입력 : ");

                            bool isWriter = false;
                            while (isWriter == false)
                            {
                                string writer = Custom.Instance.ReadString();

                                for (int i = 0; i < Library.bookList.Count; i++)
                                {
                                    if (Library.bookList[i].Writer.Contains(writer))
                                    {
                                        isWriter = true;
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("      책 ID 넘버 : " + Library.bookList[i].Id);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 이름 : " + Library.bookList[i].Title);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 저자 : " + Library.bookList[i].Writer);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 출판사 : " + Library.bookList[i].Publisher);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 가격 : " + Library.bookList[i].Price);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 수량 : " + Library.bookList[i].Quantity);
                                        Console.WriteLine();
                                    }
                                }
                                if (isWriter == false)
                                {
                                    Console.Clear();
                                    Screen.Instance.basicScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("                      ▣ 책 저자명으로 검색 ▣");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.Write("   검색 결과가 없습니다. 검색하려는 책의 저자명을 정확히 입력하세요. : ");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                            string outNum = Custom.Instance.ReadPhone();

                            if (outNum == "1")
                            {
                                Console.Clear();
                                isOutCheck = true;
                                break;
                            }
                        } // 책 저자명으로 검색
                        else if (num2 == "3")
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                   ▣ 책 출판사로 검색 ▣");
                            Console.WriteLine();
                            Console.Write("   검색할 책 출판사 입력 : ");

                            bool isPublisher = false;
                            while (isPublisher == false)
                            {
                                string publisher = Custom.Instance.ReadString();

                                for (int i = 0; i < Library.bookList.Count; i++)
                                {
                                    if (Library.bookList[i].Writer.Contains(publisher))
                                    {
                                        isPublisher = true;
                                        Console.WriteLine();
                                        Console.WriteLine();
                                        Console.WriteLine("      책 ID 넘버 : " + Library.bookList[i].Id);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 이름 : " + Library.bookList[i].Title);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 저자 : " + Library.bookList[i].Writer);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 출판사 : " + Library.bookList[i].Publisher);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 가격 : " + Library.bookList[i].Price);
                                        Console.WriteLine();
                                        Console.WriteLine("      책 수량 : " + Library.bookList[i].Quantity);
                                        Console.WriteLine();
                                    }
                                }
                                if (isPublisher == false)
                                {
                                    Console.Clear();
                                    Screen.Instance.basicScreen();
                                    Console.WriteLine();
                                    Console.WriteLine("                      ▣ 책 출판사로 검색 ▣");
                                    Console.WriteLine();
                                    Console.WriteLine();
                                    Console.Write("   검색 결과가 없습니다. 검색하려는 책의 출판사를 정확히 입력하세요. : ");
                                }
                            }
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                            string outNum = Custom.Instance.ReadPhone();

                            if (outNum == "1")
                            {
                                Console.Clear();
                                isOutCheck = true;
                                break;
                            }
                        } //책 출판사로 검색
                        else if (num2 == "4")
                        {
                            isBack = true;
                            break;
                        }
                    }
                    
                } //검색
                else if (num == "2")
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 책 대출 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   대여 하려는 책의 이름 : ");

                    bool isTitle = false;
                    while (isTitle == false)
                    {
                        string title = Custom.Instance.ReadString();

                        for (int i = 0; i < Library.bookList.Count; i++)
                        {
                            if (Library.bookList[i].Title.Contains(title))
                            {
                                isTitle = true;
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.WriteLine("      책 ID 넘버 : " + Library.bookList[i].Id);
                                Console.WriteLine();
                                Console.WriteLine("      책 이름 : " + Library.bookList[i].Title);
                                Console.WriteLine();
                                Console.WriteLine("      책 저자 : " + Library.bookList[i].Writer);
                                Console.WriteLine();
                                Console.WriteLine("      책 출판사 : " + Library.bookList[i].Publisher);
                                Console.WriteLine();
                                Console.WriteLine("      책 가격 : " + Library.bookList[i].Price);
                                Console.WriteLine();
                                Console.WriteLine("      책 수량 : " + Library.bookList[i].Quantity);
                                Console.WriteLine();
                            }
                        }
                        if (isTitle == true)
                        {
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   대여하려는 책의 ID 넘버를 입력하세요 (ex. ID1234) : ");

                            bool isBookId = false;
                            while(isBookId == false)
                            {
                                string bookId = Custom.Instance.ReadEngNum();
                                for (int i = 0; i < Library.bookList.Count; i++)
                                {
                                    if (Library.bookList[i].Id == bookId)
                                    {
                                        isBookId = true;

                                        //전체 책 개수 줄이기
                                        Library.bookList[i].Quantity -= 1;

                                        //히스토리 리스트에 넣기
                                        
                                        History.Instance.Title = Library.bookList[i].Title;
                                        History.Instance.Lib = "대출";
                                        for (int j = 0; j < Library.memberList.Count; j++)
                                        {
                                            if (Library.memberList[j].Id == tempId)
                                            {
                                                History.Instance.Name = Library.memberList[j].Name;
                                                Library.memberList[j].BookNum += 1; //개인대여권수 증가
                                            }
                                        }
                                        History.Instance.Time = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분");

                                        Library.bookLoanList.Add(History.Instance); //대출리스트에 넣기
                                        Library.historyList.Add(History.Instance); //히스토리에 넣기

                                        Console.WriteLine();
                                        Console.WriteLine("   책 '" + Library.bookList[i].Title + "' 대출 완료 !");
                                        Custom.Instance.updataBookListData();
                                        Custom.Instance.updataMemberListData();
                                        Custom.Instance.updataHistoryData();

                                    }
                                }
                                if (isBookId == false)
                                {
                                    Console.WriteLine();
                                    Console.Write("   대여하려는 책의 유효한 ID 넘버를 입력하세요 (ex. ID1234) : ");
                                }
                            }
                            
                        }
                        if (isTitle == false)
                        {
                            Console.Clear();
                            Screen.Instance.basicScreen();
                            Console.WriteLine();
                            Console.WriteLine("                      ▣ 책 대출 ▣");
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.Write("   대여하려는 책의 이름을 정확히 입력하세요. : ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Custom.Instance.ReadPhone();
                    if (outNum == "1")
                    {
                        Console.Clear();
                        isOutCheck = true;
                        break;
                    }
                } //책 대출
                else if (num == "3")
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 책 반납 ▣");
                    Console.WriteLine();
                    Console.WriteLine();
                    string tempName = "";
                    for( int i = 0; i < Library.memberList.Count; i++)
                    {
                        if (Library.memberList[i].Id == tempId)
                        {
                            tempName = Library.memberList[i].Name;
                        }
                    }
                    Console.WriteLine("   " + tempName + "님의 대출 책 목록");
                    Console.WriteLine();
                    List<History> tempBook = new List<History>();
                    for (int i = 0; i < Library.bookLoanList.Count; i++)
                    {
                        if (Library.bookLoanList[i].Name == tempName)
                        {
                            History.Instance.Title = Library.bookLoanList[i].Title;
                            tempBook.Add(History.Instance);
                        }
                    }
                    for (int i = 0; i < tempBook.Count; i++)
                    {
                        Console.WriteLine("   " + i+1 + ". 대출한 책 : '" + Library.bookLoanList[i].Title + "'");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   반납할 책의 숫자를 입력해 주세요. : ");

                    bool isNum = false;
                    while(isNum == false)
                    {
                        string selec = Custom.Instance.ReadPhone();
                        int selecNum = Convert.ToInt32(selec);
                        for (int i = 0; i < tempBook.Count; i++)
                        {
                            if (selecNum == i + 1)
                            {
                                isNum = true;

                                for (int k = 0; k < Library.bookList.Count; k++)
                                {
                                    if (Library.bookList[k].Title == tempBook[i].Title)
                                    {
                                        //전체 책 개수 늘이기
                                        Library.bookList[k].Quantity += 1;

                                        //히스토리 리스트에 넣기
                                        History.Instance.Title = Library.bookList[k].Title;
                                        History.Instance.Lib = "반납";
                                        for (int j = 0; j < Library.memberList.Count; j++)
                                        {
                                            if (Library.memberList[j].Id == tempId)
                                            {
                                                History.Instance.Name = Library.memberList[j].Name;
                                                Library.memberList[j].BookNum -= 1; //개인대여권수 감소
                                            }
                                        }
                                        History.Instance.Time = DateTime.Now.ToString("yyyy년 MM월 dd일 HH시 mm분");

                                        Library.historyList.Add(History.Instance); // 히스토리에 넣기

                                        for (int m = 0; m < Library.bookLoanList.Count; m++)
                                        {
                                            if (tempBook[i].Title == Library.bookLoanList[m].Title)
                                            Library.bookLoanList.Remove(Library.bookLoanList[m]); //대출 목록에서 삭제
                                        }
                                        
                                        Console.WriteLine();
                                        Console.WriteLine("   책 '" + tempBook[i].Title + "' 반납 완료 !");

                                        Custom.Instance.updataBookListData();
                                        Custom.Instance.updataMemberListData();
                                        Custom.Instance.updataHistoryData();

                                    }
                                }

                            }
                        }
                        if (isNum == false)
                        {
                            Console.WriteLine();
                            Console.Write("   반납할 책의 숫자를 정확히 입력해 주세요. : ");
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Custom.Instance.ReadPhone();
                    if (outNum == "1")
                    {
                        Console.Clear();
                        isOutCheck = true;
                        break;
                    }

                } //책 반납
                else if (num == "4")
                {
                    Console.Clear();
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
                    Console.Write("   뒤로가기 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                    string outNum = Custom.Instance.ReadPhone();

                    if (outNum == "1")
                    {
                        Console.Clear();
                        isOutCheck = true;
                        break;
                    }
                } //책 리스트
                else if (num == "5")
                {
                    Console.Clear();
                    Screen.Instance.basicScreen();
                    Console.WriteLine();
                    Console.WriteLine("                      ▣ 내 정 보 ▣");
                    Console.WriteLine();
                    for (int i = 0; i < Library.memberList.Count; i++)
                    {
                        if (Library.memberList[i].Id == tempId)
                        {
                            Console.WriteLine();
                            Console.WriteLine("   회원 ID : " + Library.memberList[i].Id);
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
                            Console.WriteLine();
                            Console.WriteLine();
                            Console.WriteLine("   뒤로가기 'Esc'를, 처음 메뉴로 돌아가기는 '1'번을,");
                            Console.WriteLine();
                            Console.Write("   휴대폰 번호를 수정하려면 '2'번을, 주소를 수정하려면 '3'번을 입력해 주세요 : ");
                            string renum = Custom.Instance.ReadPhone();
                            if (renum == "1")
                            {
                                Console.Clear();
                                isOutCheck = true;
                                break;
                            }
                            else if (renum == "2" )
                            {
                                Console.WriteLine();
                                Console.Write("   새 휴대폰 번호를 입력하세요 ('-' 제외하고 입력) : ");
                                Library.memberList[i].Phone = Custom.Instance.ReadPhone();
                                Custom.Instance.updataMemberListData();
                                Console.WriteLine();
                                Console.WriteLine("   휴대폰 번호가 수정되었습니다 ! ");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                                string outNum = Custom.Instance.ReadPhone();

                                if (outNum == "1")
                                {
                                    Console.Clear();
                                    isOutCheck = true;
                                    break;
                                }

                            }
                            else if(renum == "3")
                            {
                                Console.WriteLine();
                                Console.Write("   새 주소를 입력하세요 : ");
                                Library.memberList[i].Address = Custom.Instance.ReadString();
                                Custom.Instance.updataMemberListData();
                                Console.WriteLine();
                                Console.WriteLine("   주소가 수정되었습니다 ! ");
                                Console.WriteLine();
                                Console.WriteLine();
                                Console.Write("   뒤로가기는 'Esc'를, 처음 메뉴로 돌아가기는 '1'을 입력해 주세요. : ");
                                string outNum = Custom.Instance.ReadPhone();

                                if (outNum == "1")
                                {
                                    Console.Clear();
                                    isOutCheck = true;
                                    break;
                                }
                            }

                        }
                    }
                    
                } //내정보
                else if (num == "6")
                {
                    Console.Clear();
                    isOutCheck = true;
                    break;
                } //처음메뉴로 돌아가기
            }
            
        }
    }
}
