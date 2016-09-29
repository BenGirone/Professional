using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budget_Windows
{
    class Data
    {
        public double expense { get; set; }
        public string date { get; set; }

        public Data()
        {
            this.expense = 0;
            this.date = "";
        }

        public Data(string d, double e)
        {
            this.date = d;
            this.expense = e;
        }

        public string toStringAll()
        {
            StringBuilder dataString = new StringBuilder();
            dataString.AppendFormat("{0} {1}", this.date, this.expense);

            return dataString.ToString();
        }

        public string toStringExpense()
        {
            StringBuilder dataString = new StringBuilder();
            dataString.AppendFormat("{0}", this.expense);

            return dataString.ToString();
        }

        public string toStringDate()
        {
            StringBuilder dataString = new StringBuilder();
            dataString.AppendFormat("{0}", this.date);

            return dataString.ToString();
        }
    }
}
