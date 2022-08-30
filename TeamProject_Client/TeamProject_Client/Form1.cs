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

    public partial class Form1 : Form
    {
        private static string strCon = @"Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))
                                    (CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe))); User Id = hr; Password = hr;";
        private OracleConnection conn;
        OracleDataAdapter adapt = new OracleDataAdapter();

        public StreamReader streamReader;
        public StreamWriter streamWriter;

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
;
            // 오라클 연동
            try
            {
                if (conn == null)
                {
                    conn = new OracleConnection(strCon);
                }
                conn.Open();
                string bookInfo = "SELECT * FROM BOOKINFO_TABLE";
                adapt.SelectCommand = new OracleCommand(bookInfo, conn);
                DataSet ds = new DataSet();
                adapt.Fill(ds);

                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // TCP 통신 스레드
            Thread thread1 = new Thread(connect);
            thread1.IsBackground = true;
            thread1.Start();
        }

        // 통신
        private void connect()
        {
            IPAddress localAddr = IPAddress.Loopback; //IPAddress.Parse("특정 아이피 접속 시 아이피 입력");
            TcpClient tcpClient1 = new TcpClient();  // TcpClient 객체 생성
            IPEndPoint ipEnd = new IPEndPoint(localAddr, 12300);
            tcpClient1.Connect(ipEnd);  // 서버에 연결 요청

            streamReader = new StreamReader(tcpClient1.GetStream());
            streamWriter = new StreamWriter(tcpClient1.GetStream());
            streamWriter.AutoFlush = true;

            while (tcpClient1.Connected)
            {
                string Recv_data = streamReader.ReadLine();
            }
        }
        // 리스트1 클릭 시 중앙에 책 사진 출력
        private void listBox1_Click(object sender, EventArgs e)
        {
            string selectname = listBox1.Text;

            string imgpath = $"C:\\Users\\Admin\\Desktop\\smartfactory_mini\\bookimg\\{selectname}.jpg";

            bookImage.Image = Image.FromFile(imgpath);
            bookImage.SizeMode = PictureBoxSizeMode.Zoom;
        }


        // 장르 선택에서 중복된 부분을 한번에 처리하기 위한 함수
        public void genre_btn(string genre)
        {
            string BOOK_NAME = $"SELECT BOOK_NAME FROM BOOKINFO_TABLE WHERE BOOK_GENRE = '{genre}'";
            adapt.SelectCommand = new OracleCommand(BOOK_NAME, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "BOOK_NAME";
        }

        // 전체(장르) 선택 시 다른 오라클 명령어로 인해 함수 적용시키지 않고 실행 (특이케이스)
        private void all_gen_btn_Click(object sender, EventArgs e)
        {
            string BOOK_NAME = "SELECT BOOK_NAME FROM BOOKINFO_TABLE";
            OracleDataAdapter adapt = new OracleDataAdapter();
            adapt.SelectCommand = new OracleCommand(BOOK_NAME, conn);
            DataSet ds = new DataSet();
            adapt.Fill(ds);

            listBox1.DataSource = ds.Tables[0];
            listBox1.DisplayMember = "BOOK_NAME";
        }

        // 장르 선택 시 함수 실행
        private void lit_gen_btn_Click(object sender, EventArgs e)
        {
            genre_btn("문학");
        }
        private void sf_gen_btn_Click(object sender, EventArgs e)
        {
            genre_btn("SF");
        }
        private void cham_gen_btn_Click(object sender, EventArgs e)
        {
            genre_btn("참고서");
        }
        private void jagi_gen_btn_Click(object sender, EventArgs e)
        {
            genre_btn("자기개발서");
        }


        private void Quit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void shoplist_btn_Click(object sender, EventArgs e)
        {
            if (listBox2.Items.Contains(listBox1.Text) == false)
            {
                listBox2.Items.Add(listBox1.Text);
                shoplist_amount.Items.Add(buy_mount_txt.Text);
            }
            else
            {
                MessageBox.Show("이미 장바구니에 있는 항목입니다");
            }
            
        }

        private void del_shoplist_btn_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex != -1)
            {
                shoplist_amount.Items.Remove(shoplist_amount.Items[listBox2.SelectedIndex]);
                listBox2.Items.Remove(listBox2.SelectedItem);
            }
            else
            {
                MessageBox.Show("장바구니에서 제거할 항목이 선택되지 않았습니다 !");
            }
;
        }

        private void CallForm2_Click(object sender, EventArgs e)
        {
            string[] bookname = new string[listBox2.Items.Count];
            string[] bookamount = new string[shoplist_amount.Items.Count];

            string data = "";

            // 폼2에 전달하기 위해 데이터 정리
            for (int i = 0; i < bookname.Length; i++)
            {
                bookname[i] = listBox2.Items[i].ToString();
            }
            for (int i = 0; i < bookamount.Length; i++)
            {
                bookamount[i] = shoplist_amount.Items[i].ToString();
            }

            for (int i = 0; i < bookname.Length; i++)
            {
                data += bookname[i] + "," ;
                data += bookamount[i] + ",";
            }

            // 폼2에 데이터 전송
            Form2 form2 = new Form2(data, this);

            form2.ShowDialog();
        }
    }
}

