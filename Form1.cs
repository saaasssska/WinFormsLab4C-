using System.Data;
using System.Data.OleDb;
using System.Text.RegularExpressions;

namespace WinFormsLab4C_ // Вариант 24
{
    public partial class Form1 : Form
    {
        OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\fedye\\OneDrive\\Рабочий стол\\myDatabase.accdb\"");
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        public Form1()
        {
            InitializeComponent();
            comboInfo();
            comboSchool();
            checkBoxInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;

            if (!CheckingNumber(num))
            {
                Fail();
                return;
            }

            myConn.Open();
            string query = "SELECT district FROM districtTable WHERE district_id = " + num;
            OleDbCommand command = new OleDbCommand(query, myConn);
            object result = command.ExecuteScalar();
            textBox1.Text = result != null ? result.ToString() : "No result found";
            myConn.Close();
        }

        private void task1(object sender, EventArgs e)
        {
            myConn.Open();
            string dist = comboBox1.Text;

            string numQuery = "SELECT district_id FROM districtTable WHERE district = ?";
            OleDbCommand numCommand = new OleDbCommand(numQuery, myConn);
            numCommand.Parameters.AddWithValue("?", dist);
            object result = numCommand.ExecuteScalar();
            string id = result != null ? result.ToString() : "0";

            string query = "SELECT * FROM schoolTable WHERE (year_open <= 1980 AND district_id = ?)";
            OleDbCommand command = new OleDbCommand(query, myConn);
            command.Parameters.AddWithValue("?", id);
            adapter.SelectCommand = command;

            myConn.Close();
            getInfo();
        }

        private void task2(object sender, EventArgs e)
        {
            List<string> numbers = new List<string>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    numbers.Add(checkedListBox1.GetItemText(checkedListBox1.Items[i]));
                    //MessageBox.Show(checkedListBox1.GetItemText(checkedListBox1.Items[i]));
                }
            }

            if (numbers.Count == 0)
            {
                MessageBox.Show("Нет выбранных значений.");
                return;
            }

            try
            {
                myConn.Open();
                string query = $"SELECT * FROM schoolTable WHERE school_number IN ({string.Join(",", numbers.Select((_, index) => $"@Param{index}"))})";
                OleDbCommand command = new OleDbCommand(query, myConn);

                for (int i = 0; i < numbers.Count; i++)
                {
                    command.Parameters.AddWithValue($"@Param{i}", numbers[i]);
                    //MessageBox.Show(numbers[i]);
                }

                adapter.SelectCommand = command;
                myConn.Close();
                getInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
            finally
            {
                myConn.Close();
            }
        }

        private void task3(object sender, EventArgs e)
        {
            myConn.Open();

            string numQuery = "SELECT district_id FROM districtTable";
            OleDbCommand numCommand = new OleDbCommand(numQuery, myConn);

            List<string> districs = new List<string>();

            using (OleDbDataReader reader = numCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string dist = reader["district_id"].ToString();
                    districs.Add(dist);
                }
            }

            List<string> schoolNumbers = new List<string>();
            List<int> teacherCounts = new List<int>();
            List<int> studentCounts = new List<int>();

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Район");
            dataTable.Columns.Add("Кол-во школ");
            dataTable.Columns.Add("Среднее число учеников на одного учителя");

            for (int i = 0; i < districs.Count; i++)
            {
                bool flag = int.TryParse(districs[i], out int dist_id);
                string query = "SELECT school_number, teacher_col, student_col FROM schoolTable WHERE district_id = ?";
                OleDbCommand command = new OleDbCommand(query, myConn);
                command.Parameters.AddWithValue("?", dist_id);


                using (OleDbDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string schoolNumber = reader["school_number"].ToString();
                        int teacherCount = Convert.ToInt32(reader["teacher_col"]);
                        int studentCount = Convert.ToInt32(reader["student_col"]);

                        schoolNumbers.Add(schoolNumber);
                        teacherCounts.Add(teacherCount);
                        studentCounts.Add(studentCount);
                    }
                }

                int schoolCol = schoolNumbers.Count;
                double teachCol = teacherCounts.Sum();
                double studentCol = studentCounts.Sum();
                //MessageBox.Show(teachCol.ToString());

                dataTable.Rows.Add(dist_id.ToString(), schoolCol.ToString(), (Math.Round(studentCol / teachCol, 3)).ToString());
                schoolNumbers.Clear();
                teacherCounts.Clear();
                studentCounts.Clear();
            }
            dataGridView1.DataSource = dataTable;
            myConn.Close();
        }

        private void checkBoxInfo()
        {
            myConn.Open();

            string numQuery = "SELECT school_number FROM schoolTable";
            OleDbCommand numCommand = new OleDbCommand(numQuery, myConn);

            List<string> schoolNumbers = new List<string>();

            using (OleDbDataReader reader = numCommand.ExecuteReader())
            {
                while (reader.Read())
                {
                    string schoolNumber = reader["school_number"].ToString();
                    schoolNumbers.Add(schoolNumber);
                    checkedListBox1.Items.Add(schoolNumber);
                }
            }
            myConn.Close();
        }

        private void task4(object sender, EventArgs e)
        {
            string phone = textBox3.Text;
            if (!checkNumber(phone))
            {
                MessageBox.Show("Некорректный номер телефона");
                return;
            }
            string school = comboBox2.Text;

            try
            {
                myConn.Open();
                string query = "UPDATE schoolTable SET school_phone = ? WHERE school_number = ?";
                OleDbCommand command = new OleDbCommand(query, myConn);
                command.Parameters.AddWithValue("?", phone);
                command.Parameters.AddWithValue("?", school);

                command.ExecuteNonQuery();

                myConn.Close();
                getInfo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при выполнении запроса: " + ex.Message);
            }
        }

        private bool checkNumber(string phoneNumber)
        {
            string pattern = @"^8\d{10}$";
            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void getInfo()
        {
            myConn.Open();
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            ClearDataGridView();
            if (dataSet.Tables.Count > 0 && dataSet.Tables[0].Rows.Count > 0)
            {
                dataGridView1.DataSource = dataSet.Tables[0];
            }
            else
            {
                MessageBox.Show("Данные не найдены");
            }
            myConn.Close();
        }

        private void ClearDataGridView()
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
        }

        private void comboInfo()
        {
            myConn.Open();
            string query = "SELECT district FROM districtTable";
            OleDbCommand command = new OleDbCommand(query, myConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox1.DataSource = dataTable;
            comboBox1.DisplayMember = "district";
            myConn.Close();
        }

        private void comboSchool()
        {
            myConn.Open();
            string query = "SELECT school_number FROM schoolTable";
            OleDbCommand command = new OleDbCommand(query, myConn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            comboBox2.DataSource = dataTable;
            comboBox2.DisplayMember = "school_number";
            myConn.Close();
        }

        private void district(object sender, EventArgs e)
        {
            string query = "SELECT * FROM districtTable";
            OleDbCommand command = new OleDbCommand(query, myConn);
            adapter.SelectCommand = command;
            getInfo();
        }

        private void school(object sender, EventArgs e)
        {
            string query = "SELECT * FROM schoolTable";
            OleDbCommand command = new OleDbCommand(query, myConn);
            adapter.SelectCommand = command;
            getInfo();
        }

        bool CheckingNumber(string text)
        {
            if (double.TryParse(text, out double number))
            {
                return true;
            }
            return false;
        }

        void Fail()
        {
            MessageBox.Show("Некорректные данные");
        }

    }
}
