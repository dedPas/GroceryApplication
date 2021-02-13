using GroceryApplication.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace GroceryApplication
{
    public partial class MainForm : Form
    {
        public static IAppDao Dao;
        public static DataTable ItemData;

        #region Constructors

        public MainForm()
        {
            InitializeComponent();
        }

        static MainForm()
        {
            Dao = new AppDao();
            ItemData = Dao.CreateDataTable();
        }

        #endregion

        #region Event Handlers

        private void MainForm_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above
            Initialize();
        }

        private void RemoveItem_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above
            Dao.DeleteRecord();
        }

        private void UpdateItem_Click(object sender, EventArgs e)
        {
            //TODO - at the end of all the code above
            Dao.UpdateRecord
        }

        private void LoadList_Click(object sender, EventArgs e)
        {

        }

        private void SaveList_Click(object sender, EventArgs e)
        {

        }

        private void ShareList_Click(object sender, EventArgs e)
        {

        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            var selection = MessageBox.Show("Do you want to exit?", "Exit Grocery App", MessageBoxButtons.YesNo);
            
            if(selection.ToString() == "Yes")
            {
                this.Close();
            }
            
        }

        #endregion

        #region Worker Methods

        private void Initialize()
        {
            ItemName.Text = "Enter Item";
            ItemPrice.Text = "0.00";
            ItemQuantity.Text = "0";
            Taxable.Checked = false;
        }



        #endregion
    }
}
