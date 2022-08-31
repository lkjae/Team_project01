using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamProject_Server_Collect
{
    public partial class Sorting_Form : Form
    {
        int cnt;
        public string address;

        string Box_pic = @"C:\Users\Admin\Desktop\TeamProject_Server_Collect\상자2.png";
        string Belt_pic = @"C:\Users\Admin\Desktop\TeamProject_Server_Collect\컨베이어 벨트.png";
        string Car_pic = @"C:\Users\Admin\Desktop\TeamProject_Server_Collect\차량.png";



        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;


        public Sorting_Form()
        {
            InitializeComponent();
        }



        private void Sorting_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string updateoi = "UPDATE ORDERINFO_TABLE SET CAPACITY = BOOK_WEIGHT * ORDER_QUANTITY";
                DataSet ds = new DataSet();
                OracleDataAdapter adapt = new OracleDataAdapter(updateoi, conn);
                adapt.SelectCommand = new OracleCommand(updateoi, conn);
                adapt.Fill(ds);

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ;
            switch (address)
            {
                case "경상북도":
                    string sql = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경상북도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }

                    string sql11 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '경상북도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql11, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "경상남도":

                    string sql1 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경상남도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql1, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql12 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '경상남도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql12, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "강원도":

                    string sql2 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '강원도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql2, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql13 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '강원도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql13, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }

                    break;
                case "경기도":

                    string sql3 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경기도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql3, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql14 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '경기도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql14, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "전라남도":

                    string sql4 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '전라남도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql4, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql15 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '전라남도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql15, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }

                    break;
                case "전라북도":

                    string sql5 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '전라북도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql5, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql16 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '전라북도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql16, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "충청남도":

                    string sql6 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '충청남도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql6, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql17 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '충청남도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql17, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "충청북도":

                    string sql7 = "SELECT SUM(CAPACITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '충청북도'";
                    using (OracleConnection connection = new OracleConnection(strCon))
                    {
                        OracleCommand command = new OracleCommand(sql7, connection);
                        connection.Open();
                        OracleDataReader reader = command.ExecuteReader();

                        try
                        {
                            while (reader.Read())
                            {
                                label4.Text = reader.GetString(0) + 'G';
                            }

                        }
                        finally
                        {
                            reader.Close();
                        }
                    }
                    string sql18 = "SELECT COUNT(*)  FROM ORDERINFO_TABLE WHERE ADDRESS = '충청북도'";
                    using (OracleConnection connection1 = new OracleConnection(strCon))
                    {
                        OracleCommand command1 = new OracleCommand(sql18, connection1);
                        connection1.Open();
                        OracleDataReader reader1 = command1.ExecuteReader();

                        try
                        {
                            while (reader1.Read())
                            {

                                cnt = reader1.GetInt32(0);
                                textBox1.Text = cnt.ToString();

                            }

                        }
                        finally
                        {
                            reader1.Close();
                        }
                    }
                    break;
                case "":
                    MessageBox.Show("지역을 선택해주세요 !");
                    break;
                default:

                    break;
            }


            try
            {
      
                for (int x = 0; x < cnt; x++)
                {
                    int i, j;

                    i = 0;
                    j = 230;
                    pictureBox1.Location = new Point(i, j);
                    pictureBox1.Visible = true;
     

                    while (i < 680)
                    {
                        i += 20;
                        Application.DoEvents();
                        Thread.Sleep(20);
                        pictureBox1.Location = new Point(i, j);

                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("수량을 입력해 주세요");
            }



        }



        private void button2_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("배송이 시작됩니다!!");

            //Delivery_Form deliveryform = new Delivery_Form(this);
            Dispose();

            //deliveryform.ShowDialog();
        }

        private void Sorting_Form_Load_1(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(Box_pic);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox2.Image = Image.FromFile(Car_pic);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox5.Image = Image.FromFile(Belt_pic);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();

                string REGION_LIST = "SELECT REGION_NAME FROM REGION_TABLE";
                OracleDataAdapter adapt = new OracleDataAdapter();
                adapt.SelectCommand = new OracleCommand(REGION_LIST, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);

                listBox1.DataSource = ds.Tables[0];
                listBox1.DisplayMember = "REGION_NAME";

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string OrderInfo = "SELECT DISTINCT B.BOOK_NAME AS 책_제목,  B.BOOK_WEIGHT AS 책_무게,O.ORDER_QUANTITY AS 주문수량, O.OD_NAME AS 주문자,O.ADDRESS AS 배송지, O.HP AS 전화번호, O.SHIPMENT AS 배송상태 FROM BOOKINFO_TABLE B , ORDERINFO_TABLE O WHERE B.BOOK_NAME = O.BOOK_NAME ORDER BY  O.ADDRESS";
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            address = listBox1.Text;
            label3.Text = address + "지역으로 가는 물품을 선별중입니다...";
        }
    }
}