using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace TeamProject_Server_Collect
{
    public partial class Delivery_Form : Form
    {
        OrderInfo_Form orderinfoForm;

        private int start_Sec = 0;
        private int start_Min = 0;

        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;
        OracleDataAdapter adapter = new OracleDataAdapter();

        private List<string> frames = new List<string>(new string[] { "1.PNG", "2.PNG", "3.PNG", "4.PNG", "5.PNG", "6.PNG", "7.PNG" });
        public Delivery_Form()
        {
            InitializeComponent();
        }
        public Delivery_Form(object Form)
        {
            InitializeComponent();
            orderinfoForm = (OrderInfo_Form)Form;
        }

        public string address;
        private void timer_Tick(object sender, EventArgs e)
        {
            if (start_Sec < 0)
            {
                start_Sec = 59;
                start_Min--;
            }
            if (start_Min < 0)
            {
                start_Min = 0;
                start_Sec = 0;
                timer1.Stop();

                try
                {
                    if (conn == null)
                    {
                        conn = new OracleConnection(strCon);
                    }
                    conn.Open();

                    string REGION_LIST = $"UPDATE ORDERINFO_TABLE SET Shipment = 'O' WHERE ADDRESS = '{배송지목록.Text}' AND Shipment = 'X'";
                    OracleDataAdapter adapt = new OracleDataAdapter();
                    adapt.SelectCommand = new OracleCommand(REGION_LIST, conn);
                    DataSet ds = new DataSet();
                    adapt.Fill(ds);

                    conn.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                MessageBox.Show("배송완료!");
                status_label.Text = "배송 대기 중 입니다...";

                orderinfoForm.car_status.Text = "배송 대기 중";
                orderinfoForm.shipping_destination.Text = "-";
                orderinfoForm.arrival_time.Text = "-";

                address = "";

                
            }
            var start_Time = start_Min + "분" + start_Sec + "초";

            예상대기시간.Text = start_Time;
            start_Sec--;

        }
        private void 예상대기시간버튼_Click(object sender, EventArgs e)
        {

            status_label.Text = "현재 " + 배송지목록.Text + " 지역으로 배송 중 입니다 ...";

            switch (address)
            {
                case "경상북도":
                    start_Min = 0;
                    start_Sec = 3;
                    break;
                case "경상남도":
                    start_Min = 0;
                    start_Sec = 6;
                    break;
                case "강원도":
                    start_Min = 0;
                    start_Sec = 10;
                    break;
                case "경기도":
                    start_Min = 0;
                    start_Sec = 12;
                    break;
                case "전라남도":
                    start_Min = 0;
                    start_Sec = 12;
                    break;
                case "전라북도":
                    start_Min = 0;
                    start_Sec = 13;
                    break;
                case "충청남도":
                    start_Min = 0;
                    start_Sec = 8;
                    break;
                case "충청북도":
                    start_Min = 0;
                    start_Sec = 10;
                    break;
                case "":
                    MessageBox.Show("지역을 선택해주세요 !");
                    break;
                default:
                    start_Min = 0;
                    start_Sec = 0;
                    break;
            }

            timer1.Start();
        }
        private void Delivery_Form_Load(object sender, EventArgs e)
        {
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

                배송지목록.DataSource = ds.Tables[0];
                배송지목록.DisplayMember = "REGION_NAME";

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        private void 배송지목록_Click(object sender, EventArgs e)
        {
            address = 배송지목록.Text;
            MessageBox.Show(address + "지역으로 배송을 시작합니다.");
        }

        private void 종료_Click(object sender, EventArgs e)
        {

            if (status_label.Text != "배송 대기 중 입니다 ...")
            {
                orderinfoForm.car_status.Text = "배송 중";
                orderinfoForm.shipping_destination.Text = address;
                orderinfoForm.arrival_time.Text = 예상대기시간.Text + " 미만";
            }

            Dispose();
        }
    }
}
