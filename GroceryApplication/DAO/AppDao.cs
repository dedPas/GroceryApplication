using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryApplication.DAO
{
    public interface IAppDao
    {
        DataTable CreateDataTable();
        void AddRecord();
        void UpdateRecord();
        void DeleteRecord();
        void DeleteAllRecords();

    }
    
    public class AppDao : IAppDao
    {
        public DataTable CreateDataTable()
        {
            DataTable dataTable = new DataTable("Items");
            dataTable.Columns.Add("ItemName", typeof(string));
            dataTable.Columns.Add("ItemPrice", typeof(decimal));
            dataTable.Columns.Add("ItemQuantity", typeof(short));
            dataTable.Columns.Add("Taxable", typeof(bool));

            return dataTable;
        }

        public void AddRecord()
        {

        }

        public void UpdateRecord()
        {

        }

        public void DeleteRecord()
        {

        }

        public void DeleteAllRecords()
        {

        }
    }
}
