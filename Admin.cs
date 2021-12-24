using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaHang
{
    public partial class Admin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        public Account loginAccount;
        public Admin()
        {
            InitializeComponent();
            Load();
        }

        #region methods
        void Load()
        {
            dtgw_Food.DataSource = foodList;
            dtgv_Account.DataSource = accountList;

            LoadDateTimePickerBill();
            LoadListBillByDate(dtpk_FromDay.Value, dtpk_ToDay.Value);     
            LoadListFood();
            LoadAccount();
            LoadCategoryIntoCombobox(cb_FoodCategory);
            AddFoodBinding();
            AddAccountBinding();
        }

        void AddAccountBinding()
        {
            txt_UserName.DataBindings.Add(new Binding("Text", dtgv_Account.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txt_DisplayName.DataBindings.Add(new Binding("Text", dtgv_Account.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nm_AccountType.DataBindings.Add(new Binding("Value", dtgv_Account.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }

        void LoadAccount()
        {
            accountList.DataSource = AccountDAO.Instance.GetListAccount();
        }
        void LoadDateTimePickerBill()
        {
            DateTime today = DateTime.Now;
            dtpk_FromDay.Value = new DateTime(today.Year, today.Month, 1);
            dtpk_ToDay.Value = dtpk_FromDay.Value.AddMonths(1).AddDays(-1);
        }
        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
           dtgv_Bill.DataSource = BillDAO.Instance.GetBillListByDate(checkIn, checkOut);
        }

        void AddFoodBinding()
        {
            txt_FoodName.DataBindings.Add(new Binding("Text", dtgw_Food.DataSource, "Name", true, DataSourceUpdateMode.Never));
            txt_FoodId.DataBindings.Add(new Binding("Text", dtgw_Food.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nm_FoodPrice.DataBindings.Add(new Binding("Value", dtgw_Food.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }

        void LoadCategoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAO.Instance.GetListCategory();
            cb.DisplayMember = "Name";
        }

        void LoadListFood()
        {
            foodList.DataSource = FoodDAO.Instance.GetListFood();
        }

        List<Food> SearchFoodByname(string name)
        {
            List<Food> listFood = FoodDAO.Instance.SearchFoodByName(name);
            return listFood;
        }

        void AddAccount(string userName, string displayName, int type)
        {
            if(AccountDAO.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccount();
        }

        void EditAccount(string userName, string displayName, int type)
        {
            if (AccountDAO.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật tài khoản thất bại");
            }
            LoadAccount();
        }

        void DeleteAccount(string userName)
        {
            if(loginAccount.UserName.Equals(userName))
            {
                MessageBox.Show("Vui lòng đừng xóa tài khoản chính bạn");
                return;
            }
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccount();
        }

        void ResetPass(string userName)
        {
            if (AccountDAO.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Đặt lại mật khẩu thành công");
            }
            else
            {
                MessageBox.Show("Đặt lại mật khẩu thất bại");
            }
            LoadAccount();
        }

        #endregion


        #region events
        private void btn_AddAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string displayName = txt_DisplayName.Text;
            int type = (int)nm_AccountType.Value;

            AddAccount(userName, displayName, type);
        }

        private void btn_DeleteAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DeleteAccount(userName);
            }
        }

        private void btn_EditAccount_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            string displayName = txt_DisplayName.Text;
            int type = (int)nm_AccountType.Value;

            EditAccount(userName, displayName, type);
        }

        private void btn_ResetPassword_Click(object sender, EventArgs e)
        {
            string userName = txt_UserName.Text;
            ResetPass(userName);
        }
       
        private void btn_ViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpk_FromDay.Value, dtpk_ToDay.Value);
        }

        private void btn_ShowFood_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txt_FoodId_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dtgw_Food.SelectedCells.Count > 0)
                {
                    int id = (int)dtgw_Food.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;

                    Category category = CategoryDAO.Instance.GetCategoryByID(id);
                    cb_FoodCategory.SelectedItem = category;

                    int index = -1;
                    int i = 0;
                    foreach (Category item in cb_FoodCategory.Items)
                    {
                        if (item.Id == category.Id)
                        {
                            index = i;
                            break;
                        }
                        i++;
                    }
                    cb_FoodCategory.SelectedIndex = index;
                }
            }
            catch { }
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            string name = txt_FoodName.Text;
            int categoryID = (cb_FoodCategory.SelectedItem as Category).Id;
            float price = (float)nm_FoodPrice.Value;

            if (FoodDAO.Instance.InsertFood(name, categoryID, price))
            {
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
                if (insertFood != null)
                    insertFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Thêm món thất bại");
            }
        }

        private void btn_EditFood_Click(object sender, EventArgs e)
        {
            string name = txt_FoodName.Text;
            int categoryID = (cb_FoodCategory.SelectedItem as Category).Id;
            float price = (float)nm_FoodPrice.Value;
            int id = Convert.ToInt32(txt_FoodId.Text);

            if (FoodDAO.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
                if (updateFood != null)
                    updateFood(this, new EventArgs());
            }
            else
            {
                MessageBox.Show("Sửa món thất bại");
            }
        }

        private void btn_DeleteFood_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int id = Convert.ToInt32(txt_FoodId.Text);

                if (FoodDAO.Instance.DeleteFood(id))
                {
                    MessageBox.Show("Xóa món thành công");
                    LoadListFood();
                    if (deleteFood != null)
                        deleteFood(this, new EventArgs());
                }
                else
                {
                    MessageBox.Show("Xóa món thất bại");
                }
            }
        }

        private void btn_SearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByname(txt_SearchFoodName.Text);
        }

        private void btn_ShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccount();
        }

        

        private event EventHandler insertFood;
        public event EventHandler InsertFood
        {
            add { insertFood += value; }
            remove { insertFood -= value; }
        }

        private event EventHandler deleteFood;
        public event EventHandler DeleteFood
        {
            add { deleteFood += value; }
            remove { deleteFood -= value; }
        }

        private event EventHandler updateFood;
        public event EventHandler UpdateFood
        {
            add { updateFood += value; }
            remove { updateFood -= value; }
        }
        #endregion
    }
}
