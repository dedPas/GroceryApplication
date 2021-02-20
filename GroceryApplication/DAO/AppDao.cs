using GroceryApplication.Models;
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
        bool AddRecord(DataTable dt, ListModel model);
        void UpdateRecord();
        void DeleteRecord(DataTable dt, string value);
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
            dataTable.Columns.Add("Taxable", typeof(string));

            return dataTable;
        }

        public bool AddRecord(DataTable dt, ListModel model)
        {
            try
            {
                DataRow row = dt.NewRow();
                row["ItemName"] = model.ItemName;
                row["ItemPrice"] = model.ItemPrice;
                row["ItemQuantity"] = model.ItemQuantity;
                row["Taxable"] = model.Taxable ? "T" : string.Empty;
                dt.Rows.Add(row);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
            
        }

        public void UpdateRecord()
        {

        }

        public void DeleteRecord(DataTable dt, string value)
        {
            for (int i = dt.Rows.Count - 1; i >= 0; i--)
            {
                var dr = dt.Rows[i];

                if (dr["ItemName"].ToString() == value.ToString())
                {
                    dr.Delete();
                    dt.AcceptChanges();
                }
            }
        }

        public void DeleteAllRecords()
        {

        }
    }
}
