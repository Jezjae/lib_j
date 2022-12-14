using lib_j.control;
using lib_j.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j
{
    public class Library
    {
        public static List<Membership> memberList = new List<Membership>();
        public static List<Book> bookList = new List<Book>();
        public static List<History> historyList = new List<History>();
        public static List<History> bookLoanList = new List<History>();
        public void libraryMainControl()
        {
            bool isExit = false;

            while (isExit == false)
            {
                Screen.Instance.libMainScreen();

                string num = Custom.Instance.ReadNum();


                if (num == "1")
                {
                    Login login = new Login();
                    login.logIn();
                }
                else if (num == "2")
                {
                    Console.Clear();
                    SignUp signUp = new SignUp();
                    signUp.signUp();
                }
                else if (num == "3")
                {
                    Console.Clear();
                    Manager manager = new Manager();
                    manager.manager();
                }
                else if (num == "4")
                {
                    isExit = true;
                    break;
                }
                else 
                {
                    Console.Clear();
                }
            }
        }
    }
}
