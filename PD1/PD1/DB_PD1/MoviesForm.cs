using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace DB_PD1
{
    public partial class MoviesForm : Form
    {
        SqlConnection sqlConn;
        bool is_cell_editing = false;

        public MoviesForm()
        {
            InitializeComponent();
        }

        private void MoviesForm_Load(object sender, EventArgs e)
        {
            dataGridViewMovies.AutoGenerateColumns = false;

            sqlConn = new SqlConnection(ConfigurationManager.ConnectionStrings["PD1MoviesDBCS_IS"].ConnectionString);
            sqlConn.Open();
            if (sqlConn.State == ConnectionState.Open)
            {
                SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Movies ORDER BY Id ASC;", sqlConn);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);

                dataGridViewMovies.DataSource = dataTable;
            }
            else
            {
                MessageBox.Show("Cannot open database");
            }
        }

        private void MoviesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sqlConn.Close();
            sqlConn.Dispose();
        }

        private void dataGridViewMovies_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM Movies WHERE Id=@Id;", sqlConn);
            sqlCommand.Parameters.Add(new SqlParameter()
            {
                ParameterName = "Id",
                Value = dataGridViewMovies.Rows[e.Row.Index].Cells["Id"].Value
            });
            sqlCommand.ExecuteNonQuery();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var paramList = new Dictionary<string, string>();
            var condList = new List<string>();

            string paramValue;

            if ((paramValue = textBoxTitle.Text.Trim()) != "")
            {
                condList.Add("Title LIKE @Title");
                paramList.Add("Title", $"%{paramValue}%");
            }

            switch (checkBoxImax3D.CheckState)
            {
                case CheckState.Checked:
                    condList.Add("Imax3D = 1");
                    break;
                case CheckState.Unchecked:
                    condList.Add("Imax3D = 0");
                    break;
            }

            if ((paramValue = textBoxBudgetMin.Text.Trim()) != "")
            {
                condList.Add("Budget >= @BudgetMin");
                paramList.Add("BudgetMin", paramValue);
            }

            if ((paramValue = textBoxBudgetMax.Text.Trim()) != "")
            {
                condList.Add("Budget <= @BudgetMax");
                paramList.Add("BudgetMax", paramValue);
            }

            if ((paramValue = textBoxAvgRatingMin.Text.Trim()) != "")
            {
                condList.Add("AvgRating >= @AvgRatingMin");
                paramList.Add("AvgRatingMin", paramValue);
            }

            if ((paramValue = textBoxAvgRatingMax.Text.Trim()) != "")
            {
                condList.Add("AvgRating <= @AvgRatingMax");
                paramList.Add("AvgRatingMax", paramValue);
            }

            if ((paramValue = dateTimePickerReleaseDateFrom.Value.ToString("yyyy-MM-dd")) != "")
            {
                condList.Add("ReleaseDate >= @ReleaseDateFrom");
                paramList.Add("ReleaseDateFrom", paramValue);
            }

            if ((paramValue = dateTimePickerReleaseDateTo.Value.ToString("yyyy-MM-dd")) != "")
            {
                condList.Add("ReleaseDate <= @ReleaseDateTo");
                paramList.Add("ReleaseDateTo", paramValue);
            }

            SqlCommand sqlCommand = new SqlCommand($"SELECT * FROM Movies WHERE {String.Join(" AND ", condList)} ORDER BY Id ASC;", sqlConn);

            foreach(var param in paramList)
            {
                sqlCommand.Parameters.Add(new SqlParameter()
                {
                    ParameterName = param.Key,
                    Value = param.Value
                });
            }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            dataGridViewMovies.DataSource = dataTable;
        }

        private void dataGridViewMovies_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            is_cell_editing = true;
            var cellImax3D = dataGridViewMovies.Rows[e.RowIndex].Cells["Imax3D"];
            if (cellImax3D.Value == null || cellImax3D.Value == DBNull.Value)
            {
                dataGridViewMovies.Rows[e.RowIndex].Cells["Imax3D"].Value = 0;
            }
        }

        private void dataGridViewMovies_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (is_cell_editing)
            {
                var editRow = dataGridViewMovies.Rows[e.RowIndex];

                var idValue = dataGridViewMovies.Rows[e.RowIndex].Cells["Id"].Value;

                var valueList = new Dictionary<string, string>();
                var paramList = new List<string>();

                for (int i = 1; i < editRow.Cells.Count; i++)
                {
                    var cell = editRow.Cells[i];
                    if (cell.Value == null || cell.Value == DBNull.Value || cell.Value.ToString().Trim() == "")
                    {
                        editRow.Selected = true;
                        cell.Selected = true;
                        dataGridViewMovies.CurrentCell = cell;
                        dataGridViewMovies.BeginEdit(true);
                        e.Cancel = true;
                        //MessageBox.Show("All fields must have value");
                        return;
                    } else
                    {
                        var propertyName = cell.OwningColumn.DataPropertyName;
                        if (propertyName == "ReleaseDate")
                        {
                            var dateTime = DateTime.Parse(cell.Value.ToString().Trim());
                            valueList.Add(cell.OwningColumn.DataPropertyName, dateTime.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            valueList.Add(cell.OwningColumn.DataPropertyName, cell.Value.ToString().Trim());
                        }

                        if (idValue == DBNull.Value)
                        {
                            paramList.Add(cell.OwningColumn.DataPropertyName);
                        }
                        else
                        {
                            paramList.Add($"{cell.OwningColumn.DataPropertyName}=@{cell.OwningColumn.DataPropertyName}");
                        }
                    }
                }

                SqlCommand sqlCommand;

                if (idValue == DBNull.Value)
                    sqlCommand = new SqlCommand($"INSERT INTO Movies({String.Join(",", paramList)}) VALUES (@{String.Join(",@", paramList)});", sqlConn);
                else
                {
                    sqlCommand = new SqlCommand($"UPDATE Movies SET {String.Join(",", paramList)} WHERE Id=@Id;", sqlConn);
                    sqlCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = "Id",
                        Value = idValue
                    });
                }

                foreach(var value in valueList)
                {
                    sqlCommand.Parameters.Add(new SqlParameter()
                    {
                        ParameterName = value.Key,
                        Value = value.Value
                    });
                }

                sqlCommand.ExecuteNonQuery();

                if (idValue == DBNull.Value)
                {
                    SqlCommand sqlLastIdCommand = new SqlCommand("SELECT MAX(ID) FROM Movies;", sqlConn);
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlLastIdCommand);
                    DataTable dataTable = new DataTable();
                    sqlDataAdapter.Fill(dataTable);
                    dataGridViewMovies.Rows[e.RowIndex].Cells["Id"].Value = dataTable.Rows[0][0];
                }

                is_cell_editing = false;
            }
        }
    }
}
