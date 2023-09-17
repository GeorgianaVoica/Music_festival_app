using Proiect.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Extensions
{
    public static class DataGridViewExtensions
    {
        public static DataGridView  RefreshDataSource<T>(this DataGridView dataGrid, List<T> stages)
        {
            dataGrid.DataSource = null;
            dataGrid.DataSource = stages;
            return dataGrid;
        }

        public static DataGridView AddColumn(this DataGridView dataGrid, int index, string headerText, string propertyName)
        {
            dataGrid.ColumnCount++;
            dataGrid.Columns[index].HeaderText = headerText;
            dataGrid.Columns[index].DataPropertyName = propertyName;
            return dataGrid;
        }

        public static DataGridView AddButtonColumn(this DataGridView dataGrid, string name, string text, string headerText)
        {
            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Name = name;
            button.Text = text;
            button.HeaderText = headerText;
            button.UseColumnTextForButtonValue = true;
            dataGrid.Columns.Add(button);
            return dataGrid;
        }
    }
}
