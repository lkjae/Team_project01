using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject_Server_Collect
{
    public partial class OrderInfo_Form : Form
    {
        Delivery_Form delivery_form;

        //public string ;

        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;
        StreamReader streamReader1;
        StreamWriter streamWriter1;

        private delegate void Lookup();
        public OrderInfo_Form()
        {
            InitializeComponent();
        }
        public OrderInfo_Form(object Form)
        {
            InitializeComponent();
            delivery_form = (Delivery_Form)Form;
        }
        private void OrderInfo_Form_Load(object sender, EventArgs e)
        {
            Thread thread1 = new Thread(connect);
            thread1.IsBackground = true;
            thread1.Start();
        }
        private void connect()
        {
            TcpListener tcpListener1 = new TcpListener(IPAddress.Any, 12300);
            tcpListener1.Start();
            writeRichTextbox("서버 준비 클라이언트 연결중...");

            TcpClient tcpClient = tcpListener1.AcceptTcpClient();
            writeRichTextbox("클라이언트 연결됨");

            streamReader1 = new StreamReader(tcpClient.GetStream());
            streamWriter1 = new StreamWriter(tcpClient.GetStream());
            streamWriter1.AutoFlush = true;
        }
        public void writeRichTextbox(string str)
        {
            richTextBox1.Invoke((MethodInvoker)
                delegate { richTextBox1.AppendText(str + "\r\n"); });
            richTextBox1.Invoke((MethodInvoker)
                delegate { richTextBox1.ScrollToCaret(); });
        }
        private void OrderLookup()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string OrderInfo = "SELECT * FROM ORDERINFO_TABLE";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(OrderInfo, conn);
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
        private void Shipping(string Recv_Data_Words, int Book_Count)
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string order_one = $"UPDATE SERVERDB_TABLE SET STOCK_QUANTITY = STOCK_QUANTITY - {Book_Count} WHERE BOOK_NAME = '{Recv_Data_Words}'";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(order_one, conn);
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
        private void STOCK_COUNT(string Book_Count, string Recv_Data_Words)
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string order_one = $"UPDATE SERVERDB_TABLE SET STOCK_QUANTITY = STOCK_QUANTITY - {Book_Count} WHERE BOOK_NAME = '{Recv_Data_Words}'";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(order_one, conn);
                adapt.Fill(ds);

                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ConnectLookup()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();

                string Recv_Data = streamReader1.ReadLine();
                string[] Recv_Data_words = Recv_Data.Split(',');

                string[] bookname = new string[(Recv_Data_words.Length - 3) / 2];
                string[] bookamount = new string[(Recv_Data_words.Length - 3) / 2];

                int cnt = 0;

                for (int i = 0; i < Recv_Data_words.Length - 3; i += 2)
                {
                    bookname[cnt] = Recv_Data_words[i];
                    cnt++;
                }

                cnt = 0;

                for (int i = 1; i < Recv_Data_words.Length - 3; i += 2)
                {
                    bookamount[cnt] = Recv_Data_words[i];
                    cnt++;
                }

                string address = Recv_Data_words[Recv_Data_words.Length - 1];
                string ph = Recv_Data_words[Recv_Data_words.Length - 2];
                string name = Recv_Data_words[Recv_Data_words.Length - 3];

                for (int i = 0; i < bookname.Length; i++)
                {
                    string orderinfo = $"INSERT INTO ORDERINFO_TABLE (BOOK_NAME, ORDER_QUANTITY, OD_NAME, ADDRESS, HP) VALUES ('{bookname[i]}','{bookamount[i]}','{name}','{address}','{ph}')";
                    DataTable ds = new DataTable();
                    OracleDataAdapter adapt = new OracleDataAdapter(orderinfo, conn);
                    adapt.Fill(ds);
                }

                conn.Close();

                conn.Open();

                string orderinfo2 = "UPDATE ORDERINFO_TABLE O SET O.BOOK_WEIGHT = (SELECT B.BOOK_WEIGHT FROM BOOKINFO_TABLE B WHERE O.BOOK_NAME = B.BOOK_NAME) WHERE EXISTS(SELECT 0 FROM BOOKINFO_TABLE B WHERE O.BOOK_NAME = B.BOOK_NAME)";
                DataTable ds2 = new DataTable();
                OracleDataAdapter adapt2 = new OracleDataAdapter(orderinfo2, conn);
                adapt2.Fill(ds2);

                conn.Close();

                OrderLookup();

                for (int i = 0; i < bookname.Length; i++)
                {
                    STOCK_COUNT(bookamount[i], bookname[i]);
                }

                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 조회하기_Click(object sender, EventArgs e)
        {
            ConnectLookup();

            conn.Close();

        }

        private void 배송하기_Click(object sender, EventArgs e)
        {
            string Recv_Data = streamReader1.ReadLine();
            string[] Recv_Data_words = Recv_Data.Split(',');
            string[] bookname = new string[(Recv_Data_words.Length - 3) / 2];
            string[] bookamount = new string[(Recv_Data_words.Length - 3) / 2];

            int cnt = 0;

            for (int i = 0; i < Recv_Data_words.Length - 3; i += 2)
            {
                bookname[cnt] = Recv_Data_words[i];
                cnt++;
            }

            cnt = 0;

            for (int i = 1; i < Recv_Data_words.Length - 3; i += 2)
            {
                bookamount[cnt] = Recv_Data_words[i];
                cnt++;
            }

            for (int i = 0; i <= bookname.Length; i++)
            {
                Shipping(bookname[i], int.Parse(bookamount[i]));
            }

            MessageBox.Show("배송시작");
        }

        private void 재고관리_Click(object sender, EventArgs e)
        {
            Buy_Form form2 = new Buy_Form();
            form2.ShowDialog();
        }

        private void 선별하기_Click(object sender, EventArgs e)
        {
            Sorting_Form form3 = new Sorting_Form();
            form3.ShowDialog();
        }

        private void 배송_Click(object sender, EventArgs e)
        {
            Delivery_Form form4 = new Delivery_Form(this);
            form4.ShowDialog();
        }

        private void 통계보기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Chart_Form form5 = new Chart_Form();
            form5.ShowDialog();
        }

        private void 종료버튼_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void 갱신_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }

                conn.Open();

                string orderinfo = "SELECT * FROM ORDERINFO_TABLE";
                DataTable ds = new DataTable();
                OracleDataAdapter adapt = new OracleDataAdapter(orderinfo, conn);
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
    }
}
