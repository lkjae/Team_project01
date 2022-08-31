using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject_Server_Collect
{
    public partial class Buy_Form : Form
    {
        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;

        private delegate void Lookup();
        private delegate void Order1();
        private delegate void BookName();
        private delegate void Proupdate();
        public Buy_Form()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }
        private void DataLookup()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string bookInfo = "SELECT * FROM SERVERDB_TABLE";
                DataSet ds = new DataSet();
                OracleDataAdapter adapt = new OracleDataAdapter(bookInfo, conn);
                adapt.Fill(ds);
                dataGridView1.DataSource = ds.Tables[0];

                conn.Close();


                dataGridView1.Refresh();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void All_Order()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string bookInfo = $"UPDATE SERVERDB_TABLE SET STOCK_QUANTITY = STOCK_QUANTITY + {numericUpDown1.Value}";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(bookInfo, conn);
                adapt.Fill(ds);

                dataGridView1.DataSource = ds;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Order_One_Book()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string bookInfo = $"UPDATE SERVERDB_TABLE SET STOCK_QUANTITY = STOCK_QUANTITY+{numericUpDown1.Value} WHERE BOOK_NAME = '{listBox1.Text}'";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(bookInfo, conn);
                adapt.Fill(ds);

                dataGridView1.DataSource = ds;

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ProgressBar()
        {
            try
            {
                string[] book_name = new string[] { "어린왕자", "소나기", "마션", "스타십 트루퍼스", "C# 교과서", "Visual C# Programming", "최강의 멘탈 관리", "위닝" };

                //Dictionary<string, int> mapName = new Dictionary<string, int>();

                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }

                conn.Open();

                for (int i = 0; i < 8; i++)
                {
                    string book_stock = $"SELECT STOCK_QUANTITY FROM SERVERDB_TABLE WHERE BOOK_NAME = '{book_name[i]}'";

                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(book_stock, connection1);
                        connection1.Open();
                        OracleDataReader reader = command1.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                switch (i)
                                {
                                    case 0:
                                        progressBar1.Value = reader.GetInt32(0);
                                        break;
                                    case 1:
                                        progressBar2.Value = reader.GetInt32(0);
                                        break;
                                    case 2:
                                        progressBar3.Value = reader.GetInt32(0);
                                        break;
                                    case 3:
                                        progressBar4.Value = reader.GetInt32(0);
                                        break;
                                    case 4:
                                        progressBar5.Value = reader.GetInt32(0);
                                        break;
                                    case 5:
                                        progressBar6.Value = reader.GetInt32(0);
                                        break;
                                    case 6:
                                        progressBar7.Value = reader.GetInt32(0);
                                        break;
                                    case 7:
                                        progressBar8.Value = reader.GetInt32(0);
                                        break;
                                }
                            }
                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                }
                conn.Close();
            }


            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Book_name()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string BOOK_NAME = "SELECT BOOK_NAME FROM BOOKINFO_TABLE";
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(BOOK_NAME, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);

                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "BOOK_NAME";

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 모든책주문_Click(object sender, EventArgs e)
        {
            Order1 order = new Order1(All_Order);
            order();
            numericUpDown1.ResetText();
        }

        private void 주문하기_Click(object sender, EventArgs e)
        {
            Order1 orderonebook = new Order1(Order_One_Book);
            orderonebook();
            numericUpDown1.ResetText();
        }


        private void 조회하기_Click(object sender, EventArgs e)
        {
            Lookup lookup = new Lookup(DataLookup);
            lookup();
            BookName bookname = new BookName(Book_name);
            bookname();
            Proupdate pdt = new Proupdate(ProgressBar);
            pdt();
        }

        private void 종료_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void progressBar1_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "어린왕자 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar1, $"{progressBar1.Value}");
        }
        private void progressBar2_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "소나기 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar2, $"{progressBar2.Value}");
        }
        private void progressBar3_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "마션 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar3, $"{progressBar3.Value}");
        }
        private void progressBar4_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "스타십 트루퍼스 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar4, $"{progressBar4.Value}");
        }
        private void progressBar5_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "C# 교과서 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar5, $"{progressBar5.Value}");
        }
        private void progressBar6_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "Visual C# Programming 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar6, $"{progressBar6.Value}");
        }
        private void progressBar7_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "최강의 멘탈 관리 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar7, $"{progressBar7.Value}");
        }
        private void progressBar8_MouseHover(object sender, EventArgs e)
        {
            this.toolTip1.ToolTipTitle = "위닝 재고량";
            this.toolTip1.IsBalloon = true;
            this.toolTip1.SetToolTip(this.progressBar8, $"{progressBar8.Value}");
        }
    }
}

