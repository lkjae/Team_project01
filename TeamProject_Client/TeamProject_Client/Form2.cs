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

namespace TeamProject_Client
{
    public partial class Form2 : Form
    {
        Form1 form1;

        // 오라클 계정 접속
        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;
        OracleDataAdapter adapt = new OracleDataAdapter();

        // Form1에서 받은 주문정보 데이터 저장공간
        public string ReciveData;
        
        public Form2(string Data, object form)
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;    // 다중 스레드 사용 가능하게 하기 위함

            // Form1에서 받은 데이터 저장
            ReciveData = Data;

            form1 = (Form1)form;
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            // 오라클 명령어 입력
            if (conn == null)
            {
                conn = new OracleConnection(strCon);
            }
            conn.Open();
            string REGION_NAME = "SELECT REGION_NAME FROM REGION_TABLE";
            adapt.SelectCommand = new OracleCommand(REGION_NAME, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            addressCombo.DataSource = ds.Tables[0];
            addressCombo.DisplayMember = "REGION_NAME";
        }

        private void send2server_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("주문이 성공적으로 완료 되었습니다.", "주문 완료");


            ReciveData += name_txt.Text + ",";
            ReciveData += pn_txt.Text + ",";
            ReciveData += addressCombo.Text;

            form1.streamWriter.WriteLine(ReciveData);

            form1.listBox2.Items.Clear();
            form1.shoplist_amount.Items.Clear();

            this.Close();
        }

        private void quit_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
