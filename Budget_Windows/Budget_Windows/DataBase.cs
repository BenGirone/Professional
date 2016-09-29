using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Budget_Windows
{
    class DataBase
    {
        //variable declaration
        public int dataBaseSize { get; set; }
        private List<Data> dataBase = new List<Data>();
        public double initialBudget { get; set; }
        public double currentBudget { get; set; }
        public double dailyExpenses { get; set; }
        public double surplus { get; set; }

    //constructor
    public DataBase()
        {
            this.dataBaseSize = 0;
            this.initialBudget = 0;
            this.currentBudget = 0;
            this.dailyExpenses = 0;
            this.surplus = 0;
            this.readData();
            this.writeData();
            this.userDataIn();
            this.userDataOut();
        }

        //function to read data from a file
        private void readData()
        {
            using (StreamReader sr = new StreamReader("budget.txt"))
            {
                string date = "";
                string expense = "";
                double expenseConversion;
                int i = 1;
                while ((date = sr.ReadLine()) != null)
                {
                    expense = sr.ReadLine();
                    expenseConversion = Convert.ToDouble(expense);
                    Data d = new Data(date, expenseConversion);
                    this.dataBase.Add(d);
                    this.dataBaseSize++;
                }

                sr.Close();
            }
        }

        //function to write data back into file
        public void writeData()
        {
            using (StreamWriter sw = new StreamWriter("budget.txt"))
            {
                foreach(Data d in this.dataBase)
                {
                    sw.WriteLine(d.date);
                    sw.WriteLine(Convert.ToString(d.expense));
                }

                sw.Close();
            }
        }

        //function to add a record to the database
        public bool addRecord(string d, double e)
        {
            bool canAdd = true;

            foreach(Data x in dataBase)
            {
                if(x.date == d)
                {
                    canAdd = false;
                    x.expense = e;
                }
            }

            if (canAdd)
            {
                Data newData = new Data(d, e);
                this.dataBase.Add(newData);
                this.dataBaseSize++;
            }

            return canAdd;
        }
        
        //function to return a date from the data base
        public string getDate(int i)
        {
            return this.dataBase[i].date;
        }

        //function to return an expense from the data base
        public double getExpense(int i)
        {
            return this.dataBase[i].expense;
        }

        //function to calculate the current budget and surplus
        public void calculate()
        {
            
            this.surplus = 0;
            this.currentBudget = this.initialBudget;

            //perform the calculation
            foreach(Data d in dataBase)
            {
                this.surplus += this.dailyExpenses - d.expense;
                this.currentBudget -= d.expense;
            }
        }

        //function to read user data
        private void userDataIn()
        {
            string temp;
            using (StreamReader sr = new StreamReader("userData.txt"))
            {
                if((temp = sr.ReadLine()) != null)
                {
                    this.initialBudget = Convert.ToDouble(temp);
                }

                if ((temp = sr.ReadLine()) != null)
                {
                    this.dailyExpenses = Convert.ToDouble(temp);
                }
                sr.Close();
            }
        }

        //function to write user data
        public void userDataOut()
        {
            using (StreamWriter sw = new StreamWriter("userData.txt"))
            {
                sw.WriteLine(Convert.ToString(this.initialBudget));
                sw.WriteLine(Convert.ToString(this.dailyExpenses));
                sw.Close();
            }
        }
    }
}
