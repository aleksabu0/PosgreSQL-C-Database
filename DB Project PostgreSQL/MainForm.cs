using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace DB_Project_PostgreSQL
{
    public partial class MainForm : Form
    {
        private string connString = "";
        private NpgsqlConnection npConnect;
        private NpgsqlCommand npCommand;
        private DataTable currentDataTable;
        private string filterSqlCommand;
        public MainForm()
        {
            InitializeComponent();
        } 
        
        //setup the connection to the database
        //run when the user tries to log in
        //returns true if the connection succeded, otherwise returns false
        private bool SetupConnection()
        {
            npConnect = new NpgsqlConnection();
            npConnect.ConnectionString = connString;
            if (npConnect.State == ConnectionState.Closed)
            {
                //check if the connection is succesful
                try
                {
                    npConnect.Open();
                }
                //no host exception
                catch (System.Net.Sockets.SocketException ex)
                {
                    Console.WriteLine("No such host");
                }
                //wrong username/password exception
                catch (Npgsql.PostgresException)
                {
                    Console.WriteLine("Connection failed. Check Username/Password");
                }
            }

            //if the connection failed and the state is closed, return false
            if (npConnect.State == ConnectionState.Closed)
            {
                return false;
            }

            //initialize the command as well
            npCommand = new NpgsqlCommand();
            npCommand.Connection = npConnect;
            return true;
        }

        //get the whole datatable
        //used to show the data in the data grid
        public void GetDataTable(string sql)
        {
            DataTable dataTable = new DataTable();
            npCommand.CommandText = sql;

            NpgsqlDataReader dataReader = npCommand.ExecuteReader();
            dataTable.Load(dataReader);
            currentDataTable = dataTable;
        }

        public void PrintDataTable()
        {
            // Bind DataTable to DataGridView
            EconomyDataGrid.DataSource = currentDataTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //hide all unneeded components at start
            HideComponentsAtStart();
        }

        //setup the combo box when they are shown first time
        private void LoadComboBoxItems(ComboBox comboBox)
        {
            List<string> items = new List<string> { "GDP", "GDP Year over Year", "GDP Quarter over Quarter"
            , "Interest Rate", "Inflation Rate", "Jobless Rate", "Government Budget"
            , "Debt/GDP", "Current Account", "Population"};
            comboBox.DataSource = items;
        }

        //show the database in full
        private void button_showData_click(object sender, EventArgs e)
        {
            filterSqlCommand = "SELECT * FROM economy_by_country";
            GetDataTable(filterSqlCommand);
            PrintDataTable();
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        //method to filter the database based on a parameter from the combobox
        private void filter_button_Click(object sender, EventArgs e)
        {
            string gdpInput = GdpInput.Text;
            if (!IsNumeric(gdpInput))
            {
                gdpInput = "0";
            }
            string selected = ComboBoxSelected(filterDropdown);
            //based on the checkbox, the filtering can be either for values larger or smaller than the input
            if (checkGdpLarger.Checked)
            {
                filterSqlCommand="SELECT * FROM economy_by_country WHERE "+selected+">" + gdpInput;
            }
            else
            {
                filterSqlCommand="SELECT * FROM economy_by_country WHERE "+selected+"<=" + gdpInput;
            }
            GetDataTable(filterSqlCommand);
            PrintDataTable();
        }

        //get a string based on the combo box
        //used in order to pass commands to the database
        public string ComboBoxSelected(ComboBox comboBox)
        {
            string selected = "gdp";
            if (comboBox.SelectedIndex == 0)
            {
                selected = "gdp";
            }
            else if (comboBox.SelectedIndex == 1)
            {
                selected = "gdp_year_over_year";
            }
            else if (comboBox.SelectedIndex == 2)
            {
                selected = "gdp_quarter_over_quarter";
            }
            else if (comboBox.SelectedIndex == 3)
            {
                selected = "interest_rate";
            }
            else if (comboBox.SelectedIndex == 4)
            {
                selected = "inflation_rate";
            }
            else if (comboBox.SelectedIndex == 5)
            {
                selected = "jobless_rate";
            }
            else if (comboBox.SelectedIndex == 6)
            {
                selected = "gov_budget";
            }
            else if (comboBox.SelectedIndex == 7)
            {
                selected = "debt_div_gdp";
            }
            else if (comboBox.SelectedIndex == 8)
            {
                selected = "current_account";
            }
            else if (comboBox.SelectedIndex == 9)
            {
                selected = "population";
            }
            return selected;
        }

        //check if a string is numeric
        public static bool IsNumeric(string input)
        {
            double result;
            return double.TryParse(input, out result);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //method called in order to sort the database based on the selected parameter in the combobox
        private void sort_button_Click(object sender, EventArgs e)
        {
            if (filterSqlCommand == null || filterSqlCommand == "")
            {
                filterSqlCommand = "SELECT * FROM economy_by_country";
            }
            string selected = ComboBoxSelected(sortDropdown);
            //based on the checkbox, the sorting can be either ascending or descending
            if (sortCheckbox.Checked)
            {
                GetDataTable(filterSqlCommand + " ORDER BY "+selected+" ASC");
            }
            else
            {
                GetDataTable(filterSqlCommand + " ORDER BY " + selected + " DESC");
            }
            PrintDataTable();
        }

        //show the panel for entering and updating countries
        private void showInputPanel_Click(object sender, EventArgs e)
        {
            if (!inputPanel.Visible)
            {
                inputPanel.Visible = true;
            }
            else
            {
                inputPanel.Visible = false;
            }

            deleteCountryPanel.Visible = false;
        }

        //method for adding new items to the database, based on the country name
        private void addCountryButton_Click(object sender, EventArgs e)
        {
            string countryName = countryTextInput.Text;
            //check if country name is null
            if (countryName == null)
            {
                return;
            }
            //check if country exists, if it does don't do anything
            GetDataTable("SELECT * FROM economy_by_country WHERE country ILIKE "+"'"+countryName+"'");
            if (currentDataTable.Rows.Count > 0)
            {
                Console.WriteLine("The value already exists in the database.");
                return;
            }

            //check if all entered values are numeric, set them to 0 if not to avoid problems
            string gdpValue = gdpTextInput.Text;
            if (!IsNumeric(gdpValue))
            {
                gdpValue = "0";
            }
            string gdpByYear = gdpYearTextInput.Text;
            if (!IsNumeric(gdpByYear))
            {
                gdpByYear = "0";
            }
            string gdpByQuarter = gdpQuarterTextInput.Text;
            if (!IsNumeric(gdpByQuarter))
            {
                gdpByQuarter = "0";
            }
            string interestRate = interestTextInput.Text;
            if (!IsNumeric(interestRate))
            {
                interestRate = "0";
            }
            string inflationRate = inflationTextInput.Text;
            if (!IsNumeric(inflationRate))
            {
                inflationRate = "0";
            }
            string joblessRate = joblessTextInput.Text;
            if (!IsNumeric(joblessRate))
            {
                joblessRate = "0";
            }
            string govBudget = govTextInput.Text;
            if (!IsNumeric(govBudget))
            {
                govBudget = "0";
            }
            string debt = debtTextInput.Text;
            if (!IsNumeric(debt))
            {
                debt = "0";
            }
            string account = accountTextInput.Text;
            if (!IsNumeric(account))
            {
                account = "0";
            }
            string population = popTextInput.Text;
            if (!IsNumeric(population))
            {
                population = "0";
            }

            string insertSqlCommand = "INSERT INTO economy_by_country(country, gdp, gdp_year_over_year, gdp_quarter_over_quarter, interest_rate, inflation_rate, " +
                "jobless_rate, gov_budget, debt_div_gdp, current_account, population)" +
                " VALUES ('"+countryName+"', '" + gdpValue + "', '" + gdpByYear + "', '" + gdpByQuarter + "', '" + interestRate + "', '" + inflationRate + "', '"
                + joblessRate + "', '" + govBudget + "', '" + debt + "', '" + account + "', '" + population  + "')";
            GetDataTable(insertSqlCommand);
            inputPanel.Visible = false;
            //print the new table
            GetDataTable("SELECT * FROM economy_by_country");
            PrintDataTable();           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //update the database for an item, based on a country name
        private void updateCountryButton_Click(object sender, EventArgs e)
        {
            string countryName = countryTextInput.Text;
            //check if country is null, return if it is
            if (countryName == null)
            {
                return;
            }
            //check if country exists
            GetDataTable("SELECT * FROM economy_by_country WHERE country ILIKE " + "'" + countryName + "'");
            if (currentDataTable.Rows.Count > 0)
            {
                Console.WriteLine("The value already exists in the database.");
            }
            //if it doesn't exist, stop the method
            else
            {
                return;
            }
            //check if all entered values are numeric, set them to 0 to make sure they don't cause problems if something else is entered
            string gdpValue = gdpTextInput.Text;
            if (!IsNumeric(gdpValue))
            {
                gdpValue = "0";
            }
            string gdpByYear = gdpYearTextInput.Text;
            if (!IsNumeric(gdpByYear))
            {
                gdpByYear = "0";
            }
            string gdpByQuarter = gdpQuarterTextInput.Text;
            if (!IsNumeric(gdpByQuarter))
            {
                gdpByQuarter = "0";
            }
            string interestRate = interestTextInput.Text;
            if (!IsNumeric(interestRate))
            {
                interestRate = "0";
            }
            string inflationRate = inflationTextInput.Text;
            if (!IsNumeric(inflationRate))
            {
                inflationRate = "0";
            }
            string joblessRate = joblessTextInput.Text;
            if (!IsNumeric(joblessRate))
            {
                joblessRate = "0";
            }
            string govBudget = govTextInput.Text;
            if (!IsNumeric(govBudget))
            {
                govBudget = "0";
            }
            string debt = debtTextInput.Text;
            if (!IsNumeric(debt))
            {
                debt = "0";
            }
            string account = accountTextInput.Text;
            if (!IsNumeric(account))
            {
                account = "0";
            }
            string population = popTextInput.Text;
            if (!IsNumeric(population))
            {
                population = "0";
            }

            string updateSqlCommand = "UPDATE economy_by_country SET gdp ="+ gdpValue+", "+
                "gdp_year_over_year =" + gdpByYear + ", " +
                "gdp_quarter_over_quarter =" + gdpByQuarter + ", " +
                "interest_rate =" + interestRate + ", " +
                "inflation_rate =" + inflationRate + ", " +
                "jobless_rate =" + joblessRate + ", " +
                "gov_budget =" + govBudget + ", " +
                "debt_div_gdp =" + debt + ", " +
                "current_account =" + account + ", " +
                "population =" + population +
                " WHERE country ILIKE '" + countryName+"'";
            GetDataTable(updateSqlCommand);
            inputPanel.Visible = false;
            //print the new table
            GetDataTable("SELECT * FROM economy_by_country");
            PrintDataTable();
        }

        //open the panel where the name of the country to be deleted is entered
        private void deleteCountryPanelButton_Click(object sender, EventArgs e)
        {
            if (!deleteCountryPanel.Visible)
            {
                deleteCountryPanel.Visible = true;
            }
            else
            {
                deleteCountryPanel.Visible = false;
            }

            inputPanel.Visible = false;
        }

        //method for deleting items from the database, based on the country name
        private void deleteButton_Click(object sender, EventArgs e)
        {
            string countryName = deleteCountryNameInput.Text;
            //check if country is null
            if (countryName == null)
            {
                return;
            }
            //check if country exists, probably not needed here
            GetDataTable("SELECT * FROM economy_by_country WHERE country ILIKE " + "'" + countryName + "'");
            if (currentDataTable.Rows.Count > 0)
            {
                Console.WriteLine("The value already exists in the database.");
            }
            else
            {
                return;
            }

            //delete by country name
            string updateSqlCommand = "DELETE FROM economy_by_country"+
                " WHERE country ILIKE '" + countryName + "'";
            GetDataTable(updateSqlCommand);
            inputPanel.Visible = false;
            deleteCountryPanel.Visible = false;
            GetDataTable("SELECT * FROM economy_by_country");
            PrintDataTable();
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        //method called after clicking on the login button
        //tries to setup connection to the database based on the text inputs for username, password and host
        private void loginButton_Click(object sender, EventArgs e)
        {
            string textUser = nameInput.Text;
            string textPass = passInput.Text;
            string textAdress = adressInput.Text;;
            if (textUser != null && textPass != null && textAdress != null
                && textUser != "" && textPass != "" && textAdress != "")
            {
                connString = connString = "Host=" + textAdress + ";Username=" + textUser + ";Password=" + textPass + ";Database=Economy;CommandTimeout=1";
                //try to connect, if succesfull start the rest of the program
                if (SetupConnection())
                {
                    EnableComponentsLogin();
                    LoadComboBoxItems(filterDropdown);
                    LoadComboBoxItems(sortDropdown);
                }
            }
        }

        //hide all unnenecessary components at start
        private void HideComponentsAtStart()
        {
            inputPanel.Visible = false;
            deleteCountryPanel.Visible = false;
            buttonShowData.Visible = false;
            ButtonQuerry1.Visible = false;
            button1.Visible = false;
            filterDropdown.Visible = false;
            sortDropdown.Visible = false;
            GdpInput.Visible = false;
            checkGdpLarger.Visible = false;
            sortCheckbox.Visible = false;
            showInputPanel.Visible = false;
            deleteCountryButton.Visible = false;
            EconomyDataGrid.Visible = false;
        }

        //show components after login
        private void EnableComponentsLogin()
        {
            buttonShowData.Visible = true;
            ButtonQuerry1.Visible = true;
            button1.Visible = true;
            filterDropdown.Visible = true;
            sortDropdown.Visible = true;
            GdpInput.Visible = true;
            checkGdpLarger.Visible = true;
            sortCheckbox.Visible = true;
            showInputPanel.Visible = true;
            deleteCountryButton.Visible = true;
            EconomyDataGrid.Visible = true;

            nameInput.Visible = false;
            adressInput.Visible = false;
            passInput.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            loginButton.Visible = false;
        }
    }

    public class DataRowModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
