using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Work_4
{
    public partial class DataForm : Form
    {
        public DataForm()
        {
            InitializeComponent();
        }

        private void HeaderOfTheTable()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Номер";
            column1.Width = 100;
            column1.Name = "id";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Категория ТС";
            column2.Width = 100;
            column2.Name = "Category";
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Марка";
            column3.Width = 100;
            column3.Name = "Brand";
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Модель";
            column4.Width = 100;
            column4.Name = "Model";
            column4.Frozen = true;
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Год выпуска";
            column5.Width = 100;
            column5.Name = "Year";
            column5.Frozen = true;
            column5.CellTemplate = new DataGridViewTextBoxCell();

            var column6 = new DataGridViewColumn();
            column6.HeaderText = "Тип топлива";
            column6.Width = 100;
            column6.Name = "Fuel";
            column6.Frozen = true;
            column6.CellTemplate = new DataGridViewTextBoxCell();

            var column7 = new DataGridViewColumn();
            column7.HeaderText = "Техосмотр";
            column7.Width = 100;
            column7.Name = "Inspection";
            column7.Frozen = true;
            column7.CellTemplate = new DataGridViewTextBoxCell();

            var column8 = new DataGridViewColumn();
            column8.HeaderText = "Владелец";
            column8.Width = 100;
            column8.Name = "Owner";
            column8.Frozen = true;
            column8.CellTemplate = new DataGridViewTextBoxCell();

            dataGridView1.Columns.Add(column1);
            dataGridView1.Columns.Add(column2);
            dataGridView1.Columns.Add(column3);
            dataGridView1.Columns.Add(column4);
            dataGridView1.Columns.Add(column5);
            dataGridView1.Columns.Add(column6);
            dataGridView1.Columns.Add(column7);
            dataGridView1.Columns.Add(column8);

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.ReadOnly = true;
        }

        private void AddDataGrid(RowOFData row)
        {
            dataGridView1.Rows.Add(row.id, row.Category, row.Brand, row.Model, row.Year, row.Fuel, row.Inspection, row.Owner);
        }

        private void DataForm_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();

            List<RowOFData> _data = new List<RowOFData>();

            DataBaseManager _manager = new DataBaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Transp`", _manager.getConnection());
            MySqlDataReader _reader;

            try
            {
                _manager.openConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read()) 
                {
                    RowOFData row = new RowOFData(_reader["id"], _reader["Category"], _reader["Brand"], _reader["Model"], _reader["Year"], _reader["Fuel"], _reader["Inspection"], _reader["Owner"]);
                    _data.Add(row);
                }

                for (int i = 0; i < _data.Count(); i++)
                {
                    AddDataGrid(_data[i]);
                }
                MessageBox.Show("Данные обновлены!", "Внимание!");
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.closeConnection();
            }
        }

        private void редактироватьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataUploadForm form = new DataUploadForm();
            this.Hide();
            form.Show();
        }

        private void обновитьДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<RowOFData> _data = new List<RowOFData>();

            DataBaseManager _manager = new DataBaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Transp`", _manager.getConnection());
            MySqlDataReader _reader;

            _manager.openConnection();
            _reader = _command.ExecuteReader();

            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();

            try
            {
                while (_reader.Read())
                {
                    RowOFData row = new RowOFData(_reader["id"], _reader["Category"], _reader["Brand"], _reader["Model"], _reader["Year"], _reader["Fuel"], _reader["Inspection"], _reader["Owner"]);
                    _data.Add(row);
                }

                for (int i = 0; i < _data.Count(); i++)
                {
                    AddDataGrid(_data[i]);
                }

                MessageBox.Show("Данные обновлены!", "Внимание!");
            }
            catch
            {
                MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
            }
            finally
            {
                _manager.closeConnection();
            }
        }

        private void обПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Program form = new About_Program();
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}