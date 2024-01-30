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
    public partial class DataUploadForm : Form
    {
        private List<RowOFData> _data = new List<RowOFData>();

        public DataUploadForm()
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

            dataGrid.Columns.Add(column1);
            dataGrid.Columns.Add(column2);
            dataGrid.Columns.Add(column3);
            dataGrid.Columns.Add(column4);
            dataGrid.Columns.Add(column5);
            dataGrid.Columns.Add(column6);
            dataGrid.Columns.Add(column7);
            dataGrid.Columns.Add(column8);

            dataGrid.AllowUserToAddRows = false;
        }

        private void AddDataGrid(RowOFData row)
        {
            dataGrid.Rows.Add(row.id, row.Category, row.Brand, row.Model, row.Year, row.Fuel, row.Inspection, row.Owner);
        }

        private void DataUploadForm_Shown(object sender, EventArgs e)
        {
            HeaderOfTheTable();
            dataGrid.Columns[0].ReadOnly = true;
        }

        private void Create_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            dataGrid.RowCount = Convert.ToInt32(numericUpDown_forAddData.Value);
            dataGrid.ReadOnly = false;

            for (int i=0; i<dataGrid.Rows.Count; i++) 
            {
                dataGrid.Rows[i].Cells[0].ReadOnly = true;
            }
        }

        private void Choose_Click(object sender, EventArgs e)
        {
            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            _data.Clear();

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

                int i = Convert.ToInt32(numericUpDown_forSelected.Value) - 1;

                if (i >= 0 && i < _data.Count)
                {
                    AddDataGrid(_data[i]);
                }
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

        private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _data.Clear();

            DataBaseManager _manager = new DataBaseManager();
            MySqlCommand _command = new MySqlCommand("SELECT * FROM `Transp`", _manager.getConnection());
            MySqlDataReader _reader;

            dataGrid.DataSource = null;
            dataGrid.Rows.Clear();

            try
            {
                _manager.openConnection();
                _reader = _command.ExecuteReader();

                while (_reader.Read())
                {
                    RowOFData row = new RowOFData(_reader["id"], _reader["Category"], _reader["Brand"], _reader["Model"], _reader["Year"], _reader["Fuel"], _reader["Inspection"], _reader["Owner"]);
                    _data.Add(row);
                }

                for (int i = 0; i < _data.Count; i++)
                {
                    AddDataGrid(_data[i]);
                    dataGrid.Rows[i].Cells[0].ReadOnly = true;
                }
                MessageBox.Show("Данные загружены!", "Внимание!");
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

        private void ВыгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Добавить эти данные в базу данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBaseManager _manager = new DataBaseManager();

                try
                {
                    bool add = true;

                    _manager.openConnection();
                    
                    for (int i=0; i<numericUpDown_forAddData.Value; i++)
                    {
                        if (Convert.ToString(this.dataGrid.Rows[i].Cells[1].Value) != "" && 
                            Convert.ToString(this.dataGrid.Rows[i].Cells[2].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[3].Value) != "" && 
                            Convert.ToString(this.dataGrid.Rows[i].Cells[4].Value) != "" && 
                            Convert.ToString(this.dataGrid.Rows[i].Cells[5].Value) != "" && 
                            Convert.ToString(this.dataGrid.Rows[i].Cells[6].Value) != "" &&
                            Convert.ToString(this.dataGrid.Rows[i].Cells[7].Value) != "")
                        {
                            string _commandString = "INSERT INTO `Transp` (`Category`, `Brand`, `Model`, `Year`, `Fuel`, `Inspection`, `Owner`) VALUES(@C, @B, @M, @Y, @F, @I, @O)";
                            MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                            _command.Parameters.Add("@C", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[1].Value;
                            _command.Parameters.Add("@B", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[2].Value;
                            _command.Parameters.Add("@M", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[3].Value;
                            _command.Parameters.Add("@Y", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[4].Value;
                            _command.Parameters.Add("@F", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[5].Value;
                            _command.Parameters.Add("@I", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[6].Value;
                            _command.Parameters.Add("@O", MySqlDbType.VarChar).Value = this.dataGrid.Rows[i].Cells[7].Value;

                            if (_command.ExecuteNonQuery() != 1)
                            {
                                add = false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Не все поля заполнены!", "Внимание!");
                        }
                    }

                    if (add)
                    {
                        MessageBox.Show("Данные добавлены!", "Внимание!");
                    }
                    else
                    {
                        MessageBox.Show("Ошибка добавления данных!", "Ошибка!");
                    }
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
        }

        private void удалитьВыбранныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите изменить эти данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGrid.SelectedRows.Count == 0)
                {
                    int index = Convert.ToInt32(numericUpDown_forSelected.Value);

                    if (index > 0 && index <= _data.Count)
                    {
                        DataBaseManager _manager = new DataBaseManager();

                        string id = Convert.ToString(this.dataGrid.Rows[0].Cells[0].Value);

                        string _commandString = "DELETE FROM `Transp` WHERE `id` = " + id;

                        MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                        try
                        {
                            _manager.openConnection();
                            _command.ExecuteNonQuery();
                            MessageBox.Show("Данные извлечены!", "Внимание!");
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
                    else
                    {
                        MessageBox.Show("Выбран не верный элемент!", "Ошибка!");
                    }
                }
                else
                {
                    DataBaseManager _manager = new DataBaseManager();
                    _manager.openConnection();

                    bool delete = true;

                    foreach(DataGridViewRow row in dataGrid.SelectedRows)
                    {
                        string id = Convert.ToString(row.Cells[0].Value);

                        string _commandString = "DELETE FROM `Transp` WHERE `Transp`.`id` = " + id;

                        MySqlCommand _command = new MySqlCommand(_commandString, _manager.getConnection());

                        try
                        {
                            dataGrid.Rows.Remove(row);
                            if (_command.ExecuteNonQuery() != 1)
                            {
                                delete = false;
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Ошибка работы с базой данных!", "Ошибка!");
                        }
                    }

                    if(delete)
                    {
                        MessageBox.Show("Данные удалены", "Внимание!");
                    }
                    else
                    {
                        MessageBox.Show("Не все данные удалены", "Внимание!");
                    }

                    _manager.closeConnection();
                }
            }
        }

        private void удалитьВсеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы точно хотите удалить все данные?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataBaseManager _manager = new DataBaseManager();

                MySqlCommand _command = new MySqlCommand("TRUNCATE TABLE `Transp`", _manager.getConnection());

                try
                {
                    _manager.openConnection();

                    _command.ExecuteNonQuery();

                    MessageBox.Show("Данные удалены", "Внимание!");
                }
                catch
                {
                    MessageBox.Show("Ошибка удаления данных!", "Ошибка!");
                }
                finally
                {
                    _manager.closeConnection();
                }
            }
        }

        private void перейтиКПросмотруДанныхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Перейти в окно просмотра данных?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                DataForm form = new DataForm();
                this.Hide();
                form.Show();
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