using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_j.model
{
    [Serializable]
    public class History
    {
        private static History HistoryInstance = null;

        public static History Instance               //싱글톤 패턴으로 선언
        {
            get
            {
                if (HistoryInstance == null)
                    HistoryInstance = new History();
                return HistoryInstance;
            }
        }
        private string name;
        private string title;
        private string time;
        private string lib;

        public History()
        {

        }

        public History(string name, string title, string time, string lib)
        {
            this.name = name;
            this.title = title;
            this.time = time;
            this.lib = lib;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Lib
        {
            get { return lib; }
            set { lib = value; }
        }
    }
}
