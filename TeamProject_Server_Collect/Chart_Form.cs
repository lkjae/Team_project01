using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace TeamProject_Server_Collect
{
    public partial class Chart_Form : Form
    {
        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;
        private OracleCommand cmd;

        public Chart_Form()
        {
            InitializeComponent();
        }

        private void ChartData_Book()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;


                cmd.CommandText =
                    "SELECT (SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '어린왕자' AND SHIPMENT = 'O') AS SUM1," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '소나기' AND SHIPMENT = 'O') AS SUM2," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '마션' AND SHIPMENT = 'O') AS SUM3," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '스타십 트루퍼스' AND SHIPMENT = 'O') AS SUM4," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = 'C# 교과서' AND SHIPMENT = 'O') AS SUM5," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = 'Visual C# Programming' AND SHIPMENT = 'O') AS SUM6," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '위닝' AND SHIPMENT = 'O') AS SUM7," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE BOOK_NAME = '최강의 멘탈관리' AND SHIPMENT = 'O') AS SUM8 FROM ORDERINFO_TABLE";

                OracleDataReader rdr = cmd.ExecuteReader();
                rdr.Read();//행만 읽음
                int[] sell_count = new int[8];

                for (int i = 0; i < sell_count.Length; i++)
                {
                    sell_count[i] = rdr.GetInt32(i);
                }



                chart1.Series.Clear();
                chart1.Legends.Clear();

                chart1.Legends.Add("구매 도서 비율");
                chart1.Legends[0].LegendStyle = LegendStyle.Table;
                chart1.Legends[0].Docking = Docking.Bottom;
                chart1.Legends[0].Alignment = StringAlignment.Center;
                chart1.Legends[0].Title = "구매 도서 비율";
                chart1.Legends[0].BorderColor = Color.Black;

                //add new chart series
                string seriesname = "SELL_CNT";
                chart1.Series.Add(seriesname);
                //set chart type to pie
                chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
                //add datapoints series, values, method

                chart1.Series[seriesname].Points.AddXY("어린왕자", sell_count[0]);
                chart1.Series[seriesname].Points.AddXY("소나기", sell_count[1]);
                chart1.Series[seriesname].Points.AddXY("마션", sell_count[2]);
                chart1.Series[seriesname].Points.AddXY("스타쉽 트루퍼스", sell_count[3]);
                chart1.Series[seriesname].Points.AddXY("C# 교과서", sell_count[4]);
                chart1.Series[seriesname].Points.AddXY("Visual C# Programming", sell_count[5]);
                chart1.Series[seriesname].Points.AddXY("위닝", sell_count[6]);
                chart1.Series[seriesname].Points.AddXY("최강의 멘탈 관리", sell_count[7]);
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ChartData_Region()
        {
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText =
                    "SELECT (SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경기도' AND SHIPMENT = 'O') AS SUM1," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '강원도' AND SHIPMENT = 'O') AS SUM2," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '충청북도' AND SHIPMENT = 'O') AS SUM3," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '충청남도' AND SHIPMENT = 'O') AS SUM4," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '전라북도' AND SHIPMENT = 'O') AS SUM5," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '전라남도' AND SHIPMENT = 'O') AS SUM6," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경상북도' AND SHIPMENT = 'O') AS SUM7," +
                    "(SELECT SUM(ORDER_QUANTITY) FROM ORDERINFO_TABLE WHERE ADDRESS = '경상남도' AND SHIPMENT = 'O') AS SUM8 FROM ORDERINFO_TABLE";



                OracleDataReader rdr = cmd.ExecuteReader();
                rdr.Read();//행만 읽음
                int[] sell_count = new int[8];
                for (int i = 0; i < sell_count.Length; i++)
                {
                    sell_count[i] = rdr.GetInt32(i);
                }


                chart1.Series.Clear();
                chart1.Legends.Clear();

                chart1.Legends.Add("구매 도서 비율");
                chart1.Legends[0].LegendStyle = LegendStyle.Table;
                chart1.Legends[0].Docking = Docking.Bottom;
                chart1.Legends[0].Alignment = StringAlignment.Center;
                chart1.Legends[0].Title = "구매 도서 비율";
                chart1.Legends[0].BorderColor = Color.Black;

                //add new chart series
                string seriesname = "SELL_CNT";
                chart1.Series.Add(seriesname);
                //set chart type to pie
                chart1.Series[seriesname].ChartType = SeriesChartType.Pie;
                //add datapoints series, values, method

                chart1.Series[seriesname].Points.AddXY("경기도", sell_count[0]);
                chart1.Series[seriesname].Points.AddXY("강원도", sell_count[1]);
                chart1.Series[seriesname].Points.AddXY("충청북도", sell_count[2]);
                chart1.Series[seriesname].Points.AddXY("충청남도", sell_count[3]);
                chart1.Series[seriesname].Points.AddXY("전라북도", sell_count[4]);
                chart1.Series[seriesname].Points.AddXY("전라남도", sell_count[5]);
                chart1.Series[seriesname].Points.AddXY("경상북도", sell_count[6]);
                chart1.Series[seriesname].Points.AddXY("경상남도", sell_count[7]);
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
            ChartData_Book();
            conn.Close();
        }
        private void 지역별조회하기_Click(object sender, EventArgs e)
        {
            ChartData_Region();
            conn.Close();
        }
        private void 뒤로가기_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
