using QuanLyNhaHang.DAO;
using QuanLyNhaHang.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Menu = QuanLyNhaHang.DTO.Menu;

namespace QuanLyNhaHang
{
    public partial class TableManager : Form
    {
        private Account loginAccount;

        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }
        public TableManager(Account acc)
        {
            InitializeComponent();

            this.LoginAccount = acc;
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cb_SwitchTable);
        }

        #region Method
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1;
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + LoginAccount.DisplayName + ")";
        }

        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAO.Instance.GetListCategory();
            cb_Category.DataSource = listCategory;
            cb_Category.DisplayMember = "Name";
        }

        void LoadFoodListByCategoryID(int id)
        {
            List<Food> listFood = FoodDAO.Instance.GetFoodByCategoryID(id);
            cb_Food.DataSource = listFood;
            cb_Food.DisplayMember = "Name";
        }
        void LoadTable()
        {
            flp_Table.Controls.Clear();

           List<Table> tableList =  TableDAO.Instance.LoadTableList();

            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = TableDAO.TableWidth, Height = TableDAO.TableHeight };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;

                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.LightGray;
                        break;
                    default:
                        btn.BackColor = Color.LimeGreen;
                        break;
                }
                flp_Table.Controls.Add(btn);
            }
        }

        void ShowBill(int id)
        {
            lsv_Bill.Items.Clear();
            List<Menu> listBillInfo = MenuDAO.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName.ToString());
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString());
                lsvItem.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsv_Bill.Items.Add(lsvItem); 
            }
            CultureInfo culture = new CultureInfo("vi-VN");
            txt_totalPrice.Text = totalPrice.ToString("c",culture);   
        }

        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAO.Instance.LoadTableList();
            cb.DisplayMember = "Name";
        }

        #endregion


        #region Events
        private void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsv_Bill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }

        private void lsv_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AccountProfile acc = new AccountProfile(LoginAccount);
            acc.UpdateAccount += Acc_UpdateAccount;
            acc.ShowDialog();
        }

        private void Acc_UpdateAccount(object sender, AccountEvent e)
        {
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản (" + e.Acc.DisplayName + ")";
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.loginAccount = LoginAccount;
            ad.InsertFood += Ad_InsertFood;
            ad.UpdateFood += Ad_UpdateFood;
            ad.DeleteFood += Ad_DeleteFood;
            ad.ShowDialog();
        }

        private void Ad_DeleteFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_Category.SelectedItem as Category).Id);
            if (lsv_Bill.Tag != null)
                ShowBill((lsv_Bill.Tag as Table).ID);
            LoadTable();
        }

        private void Ad_UpdateFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_Category.SelectedItem as Category).Id);
            if (lsv_Bill.Tag != null)
                ShowBill((lsv_Bill.Tag as Table).ID);
        }

        private void Ad_InsertFood(object sender, EventArgs e)
        {
            LoadFoodListByCategoryID((cb_Category.SelectedItem as Category).Id);
            if (lsv_Bill.Tag != null)
                ShowBill((lsv_Bill.Tag as Table).ID);
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;

            if (cb.SelectedItem == null)
                return;

            Category selected = cb.SelectedItem as Category;
            id = selected.Id;

            LoadFoodListByCategoryID(id);
        }

        private void btn_AddFood_Click(object sender, EventArgs e)
        {
            Table table = lsv_Bill.Tag as Table;
            if(table == null)
            {
                MessageBox.Show("Hãy chọn bàn");
                return;
            }

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int foodID = (cb_Food.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;

            if(idBill == -1)
            {
                BillDAO.Instance.InsertBill(table.ID);
                BillInfoDAO.Instance.InsertBillInfo(BillDAO.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAO.Instance.InsertBillInfo(idBill, foodID, count);
            }

            ShowBill(table.ID);
            LoadTable();
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            Table table = lsv_Bill.Tag as Table;

            int idBill = BillDAO.Instance.GetUncheckBillIDByTableID(table.ID);
            int discount = (int)nm_Discount.Value;
            double totalPrice = Convert.ToDouble(txt_totalPrice.Text.Split(',')[000]);
            double finalTotalPrice = totalPrice - (totalPrice / 100) * discount;

            if (idBill != -1)
            {
                if (MessageBox.Show(string.Format("Bạn có muốn thanh toán hóa đơn cho {0} \n Tổng tiền - (Tổng tiền / 100) x Giảm giá \n = {1} - ({1} / 100) x {2} = {3} ",table.Name, totalPrice, discount, finalTotalPrice) + " ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
                {
                    BillDAO.Instance.CheckOut(idBill,discount,(float)finalTotalPrice);
                    ShowBill(table.ID);
                    LoadTable();
                }
            }
        }

        private void btn_SwitchTable_Click(object sender, EventArgs e)
        {
            int id1 = (lsv_Bill.Tag as Table).ID;
            int id2 = (cb_SwitchTable.SelectedItem as Table).ID;

            if (MessageBox.Show(string.Format("Bạn có thật sự muốn chuyển bàn {0} qua bàn {1}", (lsv_Bill.Tag as Table).Name, (cb_SwitchTable.SelectedItem as Table).Name), "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK);
            TableDAO.Instance.SwitchTable(id1, id2);
            LoadTable();
        }

        #endregion

    }
}
