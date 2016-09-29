using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Budget_Windows
{
    //GUI Class
    public partial class bmg_mainForm : Form
    {
        //variable declaration
        private string date;
        private double expense;
        private string month = "All";
        private string year = "All";
        DataBase budgetData = new DataBase();

        //constructor
        public bmg_mainForm()
        {
            //create initial form
            InitializeComponent();
            this.initializeList(this.month, this.year);

            //add months to the month filter
            bmg_monthSelector.Items.Add("All");
            bmg_monthSelector.Items.Add("January");
            bmg_monthSelector.Items.Add("February");
            bmg_monthSelector.Items.Add("March");
            bmg_monthSelector.Items.Add("April");
            bmg_monthSelector.Items.Add("May");
            bmg_monthSelector.Items.Add("June");
            bmg_monthSelector.Items.Add("July");
            bmg_monthSelector.Items.Add("August");
            bmg_monthSelector.Items.Add("September");
            bmg_monthSelector.Items.Add("October");
            bmg_monthSelector.Items.Add("November");
            bmg_monthSelector.Items.Add("December");

            //add years to the year filter
            bmg_yearSelector.Items.Add("All");
            bmg_yearSelector.Items.Add("Current");

            this.listBudgetValues();
        }

        //function to initialize the reord list
        private void initializeList(string m, string y)
        {
            //clear all previous records
            bmg_list.Items.Clear();

            //add records to the list if they pass the current filters
            if (m == "All")
            {
                for (int i = 0; i < budgetData.dataBaseSize; i++)
                {
                    if ((budgetData.getDate(i).EndsWith(y)) || (y == "All")) //check year
                    {
                        ListViewItem new_ = new ListViewItem(budgetData.getDate(i));
                        new_.SubItems.Add(("$" + Convert.ToString(budgetData.getExpense(i))));
                        bmg_list.Items.Add(new_);
                    }
                }
            }
            else
            {
                for (int i = 0; i < budgetData.dataBaseSize; i++)
                {
                    if ((budgetData.getDate(i).Substring(0,2)) == m) //check month
                    {
                        if ((budgetData.getDate(i).EndsWith(y)) || (y == "All")) //check year
                        {
                            ListViewItem new_ = new ListViewItem(budgetData.getDate(i));
                            new_.SubItems.Add(("$" + Convert.ToString(budgetData.getExpense(i))));
                            bmg_list.Items.Add(new_);
                        }
                    }
                }
            }
        }

        //function to add a record to the database
        private void bmg_recordButton_Click(object sender, EventArgs e)
        {
            //variable declaration
            this.date = bmg_dater.Value.ToString(@"MM\/dd\/yyyy");
            this.expense = Convert.ToDouble(bmg_expenser.Text);

            //test if the record can be added or if it already exists
            if (budgetData.addRecord(this.date, this.expense))
            {
                ListViewItem new_ = new ListViewItem(this.date);
                new_.SubItems.Add(("$" + Convert.ToString(this.expense)));
                bmg_list.Items.Add(new_); 
            }
            else //simply update the list if the value is already in the database
            {
                this.initializeList(this.month, this.year);

            }

            //update the budget
            this.listBudgetValues();

            //write the data to the database
            budgetData.writeData();
        }

        //function to remove default texts
        private void bmg_expenser_Click(object sender, EventArgs e)
        {
            bmg_expenser.Text = "";
        }

        //function to apply the month filter
        private void bmg_monthSelector_TextChanged(object sender, EventArgs e)
        {
            switch(bmg_monthSelector.Text)
            {
                case "January":
                    this.month = "01";
                    break;
                case "February":
                    this.month = "02";
                    break;
                case "March":
                    this.month = "03";
                    break;
                case "April":
                    this.month = "04";
                    break;
                case "May":
                    this.month = "05";
                    break;
                case "June":
                    this.month = "06";
                    break;
                case "July":
                    this.month = "07";
                    break;
                case "August":
                    this.month = "08";
                    break;
                case "September":
                    this.month = "09";
                    break;
                case "October":
                    this.month = "10";
                    break;
                case "November":
                    this.month = "11";
                    break;
                case "December":
                    this.month = "12";
                    break;
                default:
                    this.month = "All";
                    break;
            }

            //update the record list
            this.initializeList(this.month, this.year);
        }

        //fucntion to apply the year filter
        private void bmg_yearSelector_TextChanged(object sender, EventArgs e)
        {
            if (bmg_yearSelector.Text != "Current")
            {
                this.year = bmg_yearSelector.Text;
            }
            else
            {
                this.year = DateTime.Today.Year.ToString();
            }

            //update the record list
            this.initializeList(this.month, this.year);
        }

        //function to set the personal budget calculations
        private void listBudgetValues()
        {
            //make the budget calculation
            budgetData.calculate();

            //update the tables
            bmg_calc_1.Text = String.Format("{0:0.00}", budgetData.initialBudget);
            bmg_calc_2.Text = String.Format("{0:0.00}", budgetData.currentBudget);
            bmg_calc_3.Text = String.Format("{0:0.00}", budgetData.dailyExpenses);
            bmg_surplus_label.Text = String.Format("{0:C}", budgetData.surplus);

            //write the new data to a file
            budgetData.userDataOut();
        }

        private void bmg_calc_1_TextChanged(object sender, EventArgs e)
        {
            budgetData.initialBudget = Convert.ToDouble(bmg_calc_1.Text);
            this.listBudgetValues();
        }

        private void bmg_calc_3_TextChanged(object sender, EventArgs e)
        {
            budgetData.dailyExpenses = Convert.ToDouble(bmg_calc_3.Text);
            this.listBudgetValues();
        }
    }
}
