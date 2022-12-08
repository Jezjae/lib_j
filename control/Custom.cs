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

    }
}
