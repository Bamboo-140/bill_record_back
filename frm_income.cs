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
using System.Collections;
using System.Configuration;
using NPOI.SS.UserModel;
using System.IO;
using NPOI.XSSF.UserModel;
using NPOI.HSSF.UserModel;

namespace bill_record
{
    public partial class frm_income : Form
    {
        //自定义控件
        DateTimePicker dtp = new DateTimePicker();
        ComboBox cmb_type = new ComboBox();
        string filterReg = "Excel 2003兼容格式|*.xls|Excel 2007文件格式|*.xlsx";

        private string _connectString = ConfigurationManager.ConnectionStrings["mycon"].ToString();

        public frm_income()
        {
            InitializeComponent();
        }

        private void dgv_income_view_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            dgv_income_view.ReadOnly = false;
            DataRow dRow = xsd_income_view.tbl_income.NewRow();
            dRow["inc_date"] = DateTime.Now.ToString("yyyy/MM/dd");
            dRow["inc_amount"] = 0;
            dRow["inc_valid"] = true;
            dRow["inc_public"] = false;
            xsd_income_view.tbl_income.Rows.Add(dRow);
         }

        private void dgv_income_view_CurrentCellChanged(object sender, EventArgs e)
        {
            try
            {
                cmb_type.Text = dgv_income_view[2, dgv_income_view.CurrentRow.Index].Value.ToString();
                dtp.Value = DateTime.Parse(dgv_income_view[1, dgv_income_view.CurrentRow.Index].Value.ToString());
                //MessageBox.Show("当前行号是：("+dgv_income_view.CurrentRow.Index.ToString()+")");
                dtp.Visible = false;
                //if (dgv_income_view.CurrentRow.Index >= 0)
                {
                    if (dgv_income_view.CurrentCell.ColumnIndex == 1)
                    {
                        cmb_type.Visible = false;
                        Rectangle rec = dgv_income_view.GetCellDisplayRectangle(dgv_income_view.CurrentCell.ColumnIndex, dgv_income_view.CurrentCell.RowIndex, false);
                        dtp.Height = rec.Height;
                        dtp.Width = rec.Width;
                        dtp.Location = new Point(rec.X, rec.Y);
                        dgv_income_view.Controls.Add(dtp);
                        //dgv_income_view[1, dgv_income_view.CurrentRow.Index].Value = dtp.Value.ToString("yyyy/MM/dd").Trim();
                        dtp.Visible = true;
                    }
                    else if (dgv_income_view.CurrentCell.ColumnIndex == 2)
                {
                    dtp.Visible = false;
                    Rectangle rec = dgv_income_view.GetCellDisplayRectangle(dgv_income_view.CurrentCell.ColumnIndex, dgv_income_view.CurrentRow.Index, false);
                    cmb_type.Height = rec.Height;
                    cmb_type.Width = rec.Width;
                    cmb_type.Location = new Point(rec.X, rec.Y);
                    dgv_income_view.Controls.Add(cmb_type);
                    //dgv_income_view[2, dgv_income_view.CurrentRow.Index].Value = cmb_type.Text.Trim();
                    cmb_type.Visible = true;
                }
                else
                {
                    cmb_type.Visible = false;
                }
                }
               
            }
            catch
            {
             
            }
        }
        private void dtp_begin_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_end.Value < dtp_begin.Value)
            {
                dtp_end.Value = dtp_begin.Value;
            }
        }

        #region 自定义控件方法
        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            //dgv_income_view.CurrentCell.Value = dtp.Value.ToString("yyyy/MM/dd");
            dgv_income_view[1,dgv_income_view.CurrentRow.Index].Value = dtp.Value.ToString("yyyy/MM/dd");
        }

        private void cmb_type_ValueChanged(object sender, EventArgs e)
        {
            dgv_income_view[2, dgv_income_view.CurrentRow.Index].Value = cmb_type.Text.Trim();
        }


        private void cmb_type_Validating(object sender, EventArgs e)
        {
            dgv_income_view[2, dgv_income_view.CurrentRow.Index].Value = cmb_type.Text.Trim();
        }

        private void cmb_type_MouseDown(object sender, EventArgs e)
        {
            dgv_income_view[2, dgv_income_view.CurrentRow.Index].Value = cmb_type.Text.Trim();
        }
        #endregion

        private void frm_income_Load(object sender, EventArgs e)
        {
            dtp.ValueChanged += new EventHandler(dtp_ValueChanged);
            cmb_type.SelectedIndexChanged += new EventHandler(cmb_type_ValueChanged);
            cmb_type.Validating += new CancelEventHandler(cmb_type_Validating);
            cmb_type.MouseDown += new MouseEventHandler(cmb_type_MouseDown);
            dtp.Enabled = false;
            cmb_type.Enabled = false;

            btn_delete.Enabled = false;
            btn_new.Enabled = false;
            btn_reject.Enabled = false;
            btn_save.Enabled = false;

            List<object> sourc = new List<object>();
            using (SqlConnection con = new SqlConnection(_connectString))
            {
                con.Open();
                string sqlText = "select distinct inc_source from tbl_income";
                using (SqlCommand command = new SqlCommand(sqlText, con))
                {
                    SqlDataReader dReader = command.ExecuteReader();
                    while (dReader.Read())
                    {
                        sourc.Add(dReader["inc_source"]);
                    }
                }
            }
            cmb_type.Items.AddRange(sourc.ToArray());
            cmb_source.Items.AddRange(sourc.ToArray());
            do_query();
        }



        private void dgv_income_view_Scroll(object sender, ScrollEventArgs e)
        {
            dtp.Visible = false;
            cmb_type.Visible = false;
        }

        private void dgv_income_view_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //权限校验
            int i = Update_dataSet(xsd_income_view, "tbl_income");
            if (i < 0)
            {
                MessageBox.Show("更新失败！");
            }
            else if (i == 0)
            {
                MessageBox.Show("没有要更新的数据！");
            }
            else
            {
                MessageBox.Show("更新成功！");
            }
            do_query();
            btn_delete.Enabled = false;
            btn_new.Enabled = false;
            btn_reject.Enabled = false;
            btn_save.Enabled = false;
        }

        /// <summary>
        /// 获取更新并提交更改到数据库
        /// </summary>
        /// <returns>成功返回值为更新数量;失败返回 -1;0没有要更新的数据</returns>
        private int Update_dataSet(DataSet dataSet,string dataTable)
        {
            //dataSet.AcceptChanges();
            int count = -1;

            DataSet change = new DataSet();
            change = dataSet.GetChanges();
            if (change == null)
            {
                //MessageBox.Show("没有更改任何数据！");
               count = 0;
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(_connectString))
                    {
                        conn.Open();
                        string queyText = "SELECT * FROM " + dataTable.Trim();
                        using (SqlDataAdapter da = new SqlDataAdapter(queyText, conn))
                        {
                            SqlCommandBuilder builder = new SqlCommandBuilder(da);
                            count = da.Update(change,dataTable);
                        }
                    }
                }
                catch
                { }
            }

            return count;
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            do_query();
        }

        private void do_query()
        {

            dtp.Visible = false;
            cmb_type.Visible = false;

            double temp = 0;
            StringBuilder sqlText = new StringBuilder();
            try
            {
                sqlText.Append("select * from tbl_income where 1 = 1 ");
                if (chk_date.Checked)
                {
                    sqlText.AppendFormat(" and inc_date between '{0}' and '{1}' ", dtp_begin.Value, dtp_end.Value);
                }
                if (!chk_valid.Checked)
                {
                    sqlText.Append(" and inc_valid = 1 ");
                }
                else
                {
                    sqlText.Append(" ");
                }
                if(chk_only_public.Checked)
                {
                    sqlText.Append(" and inc_public = 1");
                }
                else
                {
                    sqlText.Append(" and inc_public = 0");
                }
                if (!String.IsNullOrEmpty(cmb_source.Text.Trim()))
                {
                    sqlText.Append(" and inc_source = '" + cmb_source.Text.Trim() + "'");
                }
                if (double.TryParse(txt_amountBegin.Text,out temp) && double.TryParse(txt_amountEnd.Text,out temp))
                {
                    sqlText.AppendFormat(" and inc_amount between {0} and {1} ", txt_amountBegin.Text.Trim(), txt_amountEnd.Text.Trim());
                }
                else if (!String.IsNullOrWhiteSpace(txt_amountEnd.Text.Trim()))
                {
                    if (string.IsNullOrWhiteSpace(txt_amountBegin.Text))
                    {
                        sqlText.AppendFormat(" and inc_amount = {0} ", txt_amountEnd.Text);
                        txt_amountBegin.Text = "=";
                    }
                    else
                    {
                        sqlText.AppendFormat(" and inc_amount {0} {1} ", txt_amountBegin.Text.Trim(), txt_amountEnd.Text);
                    }
                }
                using (SqlConnection con = new SqlConnection(_connectString))
                {
                    con.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlText.ToString(), con))
                    {
                        xsd_income_view.tbl_income.Clear();
                        da.Fill(xsd_income_view, "tbl_income");
                    }
                }
            }
            catch
            {
                // MessageBox.Show(ex.Message);
            }
        }
        private void btn_reject_Click(object sender, EventArgs e)
        {
            xsd_income_view.RejectChanges();
            dgv_income_view.ReadOnly = true;
            dtp.Enabled = false;
            cmb_type.Enabled = false;
            btn_delete.Enabled = false;
            btn_new.Enabled = false;
            btn_reject.Enabled = false;
            btn_save.Enabled = false;
        }

        private void txt_amountBegin_TextChanged(object sender, EventArgs e)
        {
          //  double d = 0;
          //if(!(Double.TryParse(txt_amountBegin.Text, out d)
          //          ||txt_amountBegin.Text.Trim().Equals(">") 
          //          || txt_amountBegin.Text.Trim().Equals(">=")
          //          || txt_amountBegin.Text.Trim().Equals("=") 
          //          || txt_amountBegin.Text.Trim().Equals("<=")
          //          || txt_amountBegin.Text.Trim().Equals("<")))
          //  {
          //      txt_amountBegin.Clear();
          //  }
        }

        private void txt_amountBegin_Validated(object sender, EventArgs e)
        {
            double d = 0;
            if (!(Double.TryParse(txt_amountBegin.Text, out d)
                      || txt_amountBegin.Text.Trim().Equals(">")
                      || txt_amountBegin.Text.Trim().Equals(">=")
                      || txt_amountBegin.Text.Trim().Equals("=")
                      || txt_amountBegin.Text.Trim().Equals("<=")
                      || txt_amountBegin.Text.Trim().Equals("<")))
            {
                txt_amountBegin.Clear();
                errorProvider1.SetError(txt_amountBegin, "只能是数字或比较运算符：<、>、<=、<= ");
            }
            else
                errorProvider1.Clear();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            // dgv_income_view[4, dgv_income_view.CurrentRow.Index].Value = false;
            string sqlText = "update tbl_income set inc_valid = 0 where inc_serial = " + dgv_income_view[0, dgv_income_view.CurrentRow.Index].Value;
            using (SqlConnection conn = new SqlConnection(_connectString))
            {
                conn.Open();
                using (SqlCommand com = new SqlCommand(sqlText, conn))
                {
                    int i = 0;
                    i = com.ExecuteNonQuery();
                    if (i > 0)
                        MessageBox.Show("删除成功！");
                    else
                        MessageBox.Show("没有执行删除命令");
                }
            }
            do_query();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            dgv_income_view.ReadOnly = false;
            cmb_type.Enabled = true;
            dtp.Enabled = true;
            btn_delete.Enabled = true;
            btn_new.Enabled = true;
            btn_reject.Enabled = true;
            btn_save.Enabled = true;
        }

        private void txt_amountEnd_Validating(object sender, CancelEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txt_amountEnd.Text))
            {
                if (is_number(txt_amountEnd.Text))
                {
                    errorProvider1.SetError(txt_amountEnd, "只能是数字！");
                    txt_amountEnd.Clear();
                }
            }
        }

        private bool is_number(string s)
        {

            double tmp = 0.0;
            return double.TryParse(s, out tmp);
        }

        private void dtp_end_ValueChanged(object sender, EventArgs e)
        {
            if (dtp_end.Value < dtp_begin.Value)
            {
                dtp_begin.Value = dtp_end.Value;
            }
        }

        private void frm_income_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (xsd_income_view.GetChanges() != null)
            {
                DialogResult dResult =
                MessageBox.Show("数据有更改是否要保存？", "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dResult == DialogResult.Yes)
                {
                    Update_dataSet(xsd_income_view, "tbl_income");
                }
                else if (dResult == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                }
            }
        }

        //传入DataGridView
        /// <summary>
        /// 输出数据到Excel
        /// </summary>
        /// <param name="dataGridView">DataGridView</param>
        /// <param name="includeHeader">是否包含字段名</param>
        /// <param name="savePath">保存路径</param>
        /// <returns>成功TRUE/失败FALSE</returns>
        public static bool ExportExcel(DataGridView dataGridView, bool includeHeader, string savePath)
        {
            bool succeed = true;
            try
            {
                //创建工作薄
                IWorkbook wbook = null;
                //创建工作表
                ISheet sheet = null;
                wbook = ICreateIWorkBook(savePath, null);
                sheet = wbook.CreateSheet("Sheet1");           //创建工作表                
                int columnCount = dataGridView.ColumnCount;    //获取行数
                int rowCount = dataGridView.RowCount;          //获取列数
                int rowIndex = 0;
                IRow row = null;
                ICell cell;
                int start = 0;    //是否包含表头行数
                //dataGridView是否有数据
                if (rowCount <= 0)
                {
                    succeed = false;
                    Exception error = new Exception("无可用于导出的数据");
                    throw error;
                }
                //是否包含表头
                if (includeHeader)
                {
                    row = sheet.CreateRow(rowIndex);
                    //输入标题表头行
                    for (int i = 0; i < columnCount; i++)
                    {
                        cell = row.CreateCell(i);
                        cell.SetCellValue(dataGridView.Columns[i].HeaderText);
                    }
                    ++start;     //如果包含表头行索引累加
                }

                //DataGridView有多少行
                for (; rowIndex < rowCount; ++rowIndex)
                {
                    row = sheet.CreateRow(rowIndex + start);    //创建行
                    for (int cellIndex = 0; cellIndex < columnCount; ++cellIndex)
                    {
                        Type type = dataGridView[cellIndex, rowIndex].ValueType;
                        object value = dataGridView[cellIndex, rowIndex].Value;
                        if (value == DBNull.Value)
                        {
                            value = "";
                        }
                        cell = row.CreateCell(cellIndex);     //创建单元格
                        //写入数据
                        if (type == typeof(Int32))
                        {
                            cell.SetCellValue((int)dataGridView[cellIndex, rowIndex].Value);
                        }
                        else if (type == typeof(Double))
                        {
                            cell.SetCellValue((double)value);
                        }
                        else if (type == typeof(float))
                        {
                            cell.SetCellValue((float)value);
                        }
                        else if (type == typeof(DateTime))
                        {
                            cell.SetCellValue((DateTime)value);
                        }
                        else if (type == typeof(Boolean))
                        {
                            cell.SetCellValue((bool)value);
                        }
                        else
                        {
                            cell.SetCellValue((string)value);
                        }
                    }
                }
                //保存的文件流保存或创建
                FileStream fs = new FileStream(savePath, FileMode.OpenOrCreate);
                wbook.Write(fs);   //写入文件
                wbook.Close();
                fs.Close();

            }
            catch (Exception ex)
            {
                succeed = false;
                throw ex;
            }
            return succeed;
        }


        /// <summary>
        /// 根据文件格式返回表文件
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <param name="fs">文件流</param>
        /// <returns>IWorkBook 表</returns>
        private static IWorkbook ICreateIWorkBook(string filePath, FileStream fs)
        {
            IWorkbook wbook = null;
            //读取用户选择的保存格式
            string extesion = Path.GetExtension(filePath).ToLower();
            if (extesion.Equals(".xlsx"))
            //if( saveFile.FileName.IndexOf(".xlsx") > 0);
            {
                if (null != fs)
                {
                    wbook = new XSSFWorkbook(fs);
                }
                else
                {
                    wbook = new XSSFWorkbook();
                }
            }
            else if (extesion.Equals(".xls"))
            //else if (saveFile.FileName.IndexOf(".xls") > 0) ;    //这种方法也可以实现但.xlsx必须在前面
            {
                if (null != fs)
                {
                    wbook = new HSSFWorkbook(fs);
                }
                else
                {
                    wbook = new HSSFWorkbook();
                }
            }
            else    //如果不是上述两种格式,因为设置了过滤器几乎不会出现下面的情况
            {
                //MessageBox.Show("对不起，您所输入的文件格式不受支持！");
                //return null;
                Exception error = new Exception("文件格式不正确!");
                throw error;
            }
            return wbook;
        }

        private void btn_export2Excel_Click(object sender, EventArgs e)
        {
            //创建保存对话框
            SaveFileDialog saveFile = new SaveFileDialog();
            //设置文件过滤器
            saveFile.Filter = filterReg;
            //保存用户的操作
            DialogResult isSave = new DialogResult();
            isSave = saveFile.ShowDialog();
            if (DialogResult.OK == isSave && saveFile.FileName != null)
            {
                ExportExcel(dgv_income_view, true, saveFile.FileName);
            }
        }


        //如有问题欢迎大家指正

    }
}
