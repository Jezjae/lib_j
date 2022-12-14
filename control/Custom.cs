using lib_j.model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace lib_j.control
{
    public class Custom
    {
        private static Custom CustomInstance = null;

        public static Custom Instance               //싱글톤 패턴으로 선언
        {
            get
            {
                if (CustomInstance == null)
                    CustomInstance = new Custom();
                return CustomInstance;
            }
        }

        public void readMemberListData()
        {
            Stream ws;
            FileInfo fileMemberInfo = new FileInfo("memberInfomation.dat");
            if (!fileMemberInfo.Exists)       //파일이 없을경우
            {
                ws = new FileStream("memberInfomation.dat", FileMode.Create);
                ws.Close();
            }
            else
            {
                if (fileMemberInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
                {
                    Stream rs = new FileStream("memberInfomation.dat", FileMode.Open); //일단 불러온다.
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Library.memberList = (List<Membership>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                    rs.Close();
                }
            }

        } //회원가입 리스트 불러오기

        public void updataMemberListData()
        {
            Stream ws = new FileStream("memberInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, Library.memberList);     //직렬화(저장)
            ws.Close();
        } //회원가입 리스트에 추가하기

        public void readBookListData()
        {
            Stream ws;
            FileInfo fileBookInfo = new FileInfo("bookInfomation.dat");
            if (!fileBookInfo.Exists)       //파일이 없을경우
            {
                ws = new FileStream("bookInfomation.dat", FileMode.Create);
                ws.Close();
            }
            else
            {
                if (fileBookInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
                {
                    Stream rs = new FileStream("bookInfomation.dat", FileMode.Open); //일단 불러온다.
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Library.bookList = (List<Book>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                    rs.Close();
                }
            }
        } //책 리스트 불러오기

        public void updataBookListData()
        {
            Stream ws = new FileStream("bookInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, Library.bookList);     //직렬화(저장)
            ws.Close();
        } //책 리스트에 추가하기

        public void readHistoryData()
        {
            Stream ws;
            FileInfo fileHistoryInfo = new FileInfo("historyInfomation.dat");
            if (!fileHistoryInfo.Exists)       //파일이 없을경우
            {
                ws = new FileStream("historyInfomation.dat", FileMode.Create);
                ws.Close();
            }
            else
            {
                if (fileHistoryInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
                {
                    Stream rs = new FileStream("historyInfomation.dat", FileMode.Open); //일단 불러온다.
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Library.historyList = (List<History>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                    rs.Close();
                }
            }
        } //대출 반납 리스트 불러오기

        public void updataHistoryData()
        {
            Stream ws = new FileStream("historyInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, Library.historyList);     //직렬화(저장)
            ws.Close();
        } //대출 반납 리스트에 추가하기

        public void readloanData()
        {
            Stream ws;
            FileInfo fileLoanInfo = new FileInfo("loanInfomation.dat");
            if (!fileLoanInfo.Exists)       //파일이 없을경우
            {
                ws = new FileStream("loanInfomation.dat", FileMode.Create);
                ws.Close();
            }
            else
            {
                if (fileLoanInfo.Length != 0)   //기존의 데이타를 가지고 있다면.
                {
                    Stream rs = new FileStream("loanInfomation.dat", FileMode.Open); //일단 불러온다.
                    BinaryFormatter deserializer = new BinaryFormatter();
                    Library.bookLoanList = (List<History>)deserializer.Deserialize(rs);       //역직렬화,리스트에 저장함.
                    rs.Close();
                }
            }

        } //내 대출 리스트 불러오기

        public void updataloansData()
        {
            Stream ws = new FileStream("loanInfomation.dat", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(ws, Library.bookLoanList);     //직렬화(저장)
            ws.Close();
        } //내 대출 리스트에 추가하기

        public string ReadString()    //string 입력하는 메소드, 뒤로가기때문에 (한글 영어 숫자 다 됨)
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                    && IsString(key))
                {
                    readString += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                {
                    int lastIndex = readString.Length - 1;
                    if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                    {
                        readString = readString.Substring(0, (readString.Length - 1));
                        Console.Write("\b\b  \b\b");
                    }
                    else
                    {
                        readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                        Console.Write("\b \b");
                    }
                }
                else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                {
                    return "\0";
                }
                else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                {
                    if (readString == "")
                        continue;
                    return readString;
                }
            }
        }

        public bool IsString(ConsoleKeyInfo key)      //한글영어숫자만을 입력받기 위해인지 테스트
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= 'A' && key.KeyChar <= 'Z') || (key.KeyChar >= '0' && key.KeyChar <= '9') ||
                (key.KeyChar >= '가' && key.KeyChar <= '힣') || key.KeyChar == ' ')
                return true;
            return false;
        }

        public string ReadEngNum()    // 영어 숫자만 입력하는 메소드
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                    && IsEngNumString(key))
                {
                    readString += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                {
                    int lastIndex = readString.Length - 1;
                    if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                    {
                        readString = readString.Substring(0, (readString.Length - 1));
                        Console.Write("\b\b  \b\b");
                    }
                    else
                    {
                        readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                        Console.Write("\b \b");
                    }
                }
                else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                {
                    return "\0";
                }
                else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                {
                    if (readString == "")
                        continue;
                    return readString;
                }
            }
        }

        public string ReadBookID()    // 책 아이디 넘버
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (readString.Length < 6)
                {
                    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                   && IsEngNumString(key))
                    {
                        readString += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                    else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                    {
                        int lastIndex = readString.Length - 1;
                        if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                        {
                            readString = readString.Substring(0, (readString.Length - 1));
                            Console.Write("\b\b  \b\b");
                        }
                        else
                        {
                            readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                            Console.Write("\b \b");
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter && readString.Length == 6)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                }
            }
        }

        public bool IsEngNumString(ConsoleKeyInfo key)      //영어숫자
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= 'A' && key.KeyChar <= 'Z') || (key.KeyChar >= '0' && key.KeyChar <= '9') ||key.KeyChar == ' ')
                return true;
            return false;
        }

        public string ReadNum()    // 숫자
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                    && IsNumString(key))
                {
                    readString += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                {
                    int lastIndex = readString.Length - 1;
                    if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                    {
                        readString = readString.Substring(0, (readString.Length - 1));
                        Console.Write("\b\b  \b\b");
                    }
                    else
                    {
                        readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                        Console.Write("\b \b");
                    }
                }
                else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                {
                    return "\0";
                }
                else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                {
                    if (readString == "")
                        continue;
                    return readString;
                }
            }
        }
        public string ReadPhone()    //숫자 길이제한
        {
            string readString = "";
           
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (readString.Length < 11)
                {
                    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                   && IsNumString(key))
                    {
                        readString += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                    else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                    {
                        int lastIndex = readString.Length - 1;
                        if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                        {
                            readString = readString.Substring(0, (readString.Length - 1));
                            Console.Write("\b\b  \b\b");
                        }
                        else
                        {
                            readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                            Console.Write("\b \b");
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter && readString.Length == 11)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                }
            }
        }

        public bool IsNumString(ConsoleKeyInfo key)      //숫자
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar != '-') && (key.KeyChar >= '0' && key.KeyChar <= '9') || key.KeyChar == ' ')
                return true;
            return false;
        }

        public string ReadKor()    //한글만 입력하는 메소드
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                    && IsKoreanString(key))
                {
                    readString += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                {
                    int lastIndex = readString.Length - 1;
                    if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                    {
                        readString = readString.Substring(0, (readString.Length - 1));
                        Console.Write("\b\b  \b\b");
                    }
                    else
                    {
                        readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                        Console.Write("\b \b");
                    }
                   
                }
                else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                {
                    return "\0";
                }
                else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                {
                    if (readString == "")
                        continue;
                    return readString;
                }
            }
        }

        public bool IsKoreanString(ConsoleKeyInfo key)      //한글
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar >= '가' && key.KeyChar <= '힣') || key.KeyChar == ' ')
                return true;
            return false;
        }

        public string ReadBack()    //돌아가기 또는 메인
        {
            string readString = "";

            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                    && IsBackString(key))
                {
                    readString += key.KeyChar;
                    Console.Write(key.KeyChar);
                }
                else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                {
                    int lastIndex = readString.Length - 1;
                    if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                    {
                        readString = readString.Substring(0, (readString.Length - 1));
                        Console.Write("\b\b  \b\b");
                    }
                    else
                    {
                        readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                        Console.Write("\b \b");
                    }
                }
                else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                {
                    return "\0";
                }
                else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                {
                    if (readString == "")
                        continue;
                    return readString;
                }
            }
        }

        public bool IsBackString(ConsoleKeyInfo key)      //1 또는 엔터
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar >= 'a' && key.KeyChar <= 'z') || (key.KeyChar >= 'A' && key.KeyChar <= 'Z') || (key.KeyChar >= '0' && key.KeyChar <= '9') ||
                (key.KeyChar >= '가' && key.KeyChar <= '힣') || key.KeyChar == ' ')
                return true;
            return false;
        }

       public string ReadName()
        {
            string readString = "";
            ConsoleKeyInfo key;
            while (true)
            {
                key = Console.ReadKey(true);

                if (readString.Length < 5)
                {
                    if (key.Key != ConsoleKey.Enter && key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Escape
                                       && IsNameString(key))
                    {
                        readString += key.KeyChar;
                        Console.Write(key.KeyChar);
                    }
                    else if (key.Key == ConsoleKey.Backspace && readString.Length > 0)
                    {
                        int lastIndex = readString.Length - 1;
                        if (readString[lastIndex] >= '가' && readString[lastIndex] <= '힣')       //한글일경우
                        {
                            readString = readString.Substring(0, (readString.Length - 1));
                            Console.Write("\b\b  \b\b");
                        }
                        else
                        {
                            readString = readString.Substring(0, (readString.Length - 1));  //한글 이외의 문자.
                            Console.Write("\b \b");
                        }
                    }
                    else if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter && readString.Length >= 2)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                }
                else
                {
                    if (key.Key == ConsoleKey.Escape)      //esc 누를 경우 null 반환
                    {
                        return "\0";
                    }
                    else if (key.Key == ConsoleKey.Enter)       //엔터를 누를경우 저장된 스트링 반환
                    {
                        if (readString == "")
                            continue;
                        return readString;
                    }
                    
                }
               
            }
        } //이름

        public bool IsNameString(ConsoleKeyInfo key)      //
        {
            char trying = key.KeyChar;
            if (key == null) return false;
            if ((key.KeyChar >= '가' && key.KeyChar <= '힣') || key.KeyChar == ' ')
                return true;
            return false;
        }
    }
}
