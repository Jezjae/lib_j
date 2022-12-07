using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j
{
    public class Screen
    {
        private static Screen ScreenInstance = null;

        public static Screen Instance               //싱글톤 패턴으로 선언
        {
            get
            {
                if (ScreenInstance == null)
                    ScreenInstance = new Screen();
                return ScreenInstance;
            }
        }

        public void libMainScreen()
        {
            basicScreen();
            Console.WriteLine("                   1.  로 그 인");
            Console.WriteLine();
            Console.WriteLine("                   2.  회 원 가 입");
            Console.WriteLine();
            Console.WriteLine("                   3.  관 리 자  모 드");
            Console.WriteLine();
            Console.WriteLine("                   4.  종   료");
            Console.WriteLine();
            Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.Write("          번호를 입력해 주세요 : ");
        }

        public void basicScreen()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("       ▣ ◈ ▣ ◈ ▣ L I B R A R Y ▣ ◈ ▣ ◈ ▣");
            Console.WriteLine();
            Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
        }

        public void libSub()
        {
            basicScreen();
            Console.WriteLine("                   1.  책 검 색");
            Console.WriteLine();
            Console.WriteLine("                   2.  책 대 출");
            Console.WriteLine();
            Console.WriteLine("                   3.  책 반 납");
            Console.WriteLine();
            Console.WriteLine("                   4.  책 리 스 트");
            Console.WriteLine();
            Console.WriteLine("                   5.  내 정 보");
            Console.WriteLine();
            Console.WriteLine("                   6.  처음 메뉴로 돌아가기");
            Console.WriteLine();
            Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.Write("          번호를 입력해 주세요 : ");

        }

        public void bookSearch()
        {
            basicScreen();
            Console.WriteLine("                   ▣ 책 검색 메뉴 ▣");
            Console.WriteLine();
            Console.WriteLine("                  1.  책 이름으로 검색");
            Console.WriteLine();
            Console.WriteLine("                  2.  책 저자명으로 검색");
            Console.WriteLine();
            Console.WriteLine("                  3.  책 출판사로 검색");
            Console.WriteLine();
            Console.WriteLine("                  4.  뒤 로 가 기");
            Console.WriteLine();
            Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.Write("          번호를 입력해 주세요 : ");

        }

        public void managerScreen()
        {
            basicScreen();
            Console.WriteLine();
            Console.WriteLine("                   ▣  관리자 메뉴 ▣");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("                   1.  회원 리스트");
            Console.WriteLine();
            Console.WriteLine("                   2.  책 리스트");
            Console.WriteLine();
            Console.WriteLine("                   3.  회원 검색");
            Console.WriteLine();
            Console.WriteLine("                   4.  회원 삭제");
            Console.WriteLine();
            Console.WriteLine("                   5.  책 정보 수정");
            Console.WriteLine();
            Console.WriteLine("                   6.  신규 책 등록");
            Console.WriteLine();
            Console.WriteLine("                   7.  책 삭제");
            Console.WriteLine();
            Console.WriteLine("                   8.  책 대여 / 반납 기록");
            Console.WriteLine();
            Console.WriteLine("                   9.  메뉴로 돌아가기");
            Console.WriteLine();
            Console.WriteLine("    - - - - - - - - - - - - - - - - - - - - - - - - - ");
            Console.WriteLine();
            Console.Write("          번호를 입력해 주세요 : ");
        }
    }
}
