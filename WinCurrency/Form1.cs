using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using System.Net;



namespace WinCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ddlCurrency();
            lblHYearMinRate.Text = "半年最小值";
            lblMonthMinRate.Text = "當月最小值";
            lblToday.Text = "本日匯率";
        }

        public void ddlCurrency()
        {
            string[] currency = new string [3];
            currency[0] = "USD";
            currency[1] = "JPY";
            currency[2] = "EUR";
            listCurrency.DataSource = currency;
        }
       

        
        private void listCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            Rate thisMonth = new Rate("thisMonth", listCurrency.Text);
            thisMonth.getRate();
            tbxMonthMinRate.Text = thisMonth.RateMin.ToString();
            tbxMonthMinDate.Text = thisMonth.DateMin;
            tbxTodayRate.Text = thisMonth.TodayRate.ToString();
            tbxTodayDate.Text = thisMonth.TodayDate;
            

            Rate HalfYear = new Rate("HalfYear", listCurrency.Text);
            HalfYear.getRate();
            tbxHYearMinRate.Text = HalfYear.RateMin.ToString();
            tbxHYearMinDate.Text = HalfYear.DateMin;

            
        }
    }

    public class Rate
    {
        string webUrl;
        string rType;
        string Currency;
        public double RateMin;
        public string DateMin;

        MemoryStream ms;
        WebClient url = new WebClient();
        string date = DateTime.Now.Year.ToString() + "-" + ("0" + DateTime.Now.Month.ToString()).Substring(0, 2);

        string h1;
        string h2;
        //string cDate;

        string[] rDate;
        double[] rRate;

        public string TodayDate;
        public double TodayRate;

        HtmlAgilityPack.HtmlDocument doc;
        HtmlAgilityPack.HtmlDocument hdc;
        HtmlNodeCollection htnode;

        double rate;





        public Rate(string type, string currency)
        {
            rType = type;
            Currency = currency;
        }



        public void getRate()
        {

            if (rType == "thisMonth")
            {
                webUrl = @"http://rate.bot.com.tw/xrt/quote/" + date + "/" + Currency;

            }
            else if (rType == "HalfYear")
            {
                webUrl = @"http://rate.bot.com.tw/xrt/quote/l6m/" + Currency;
            }

            ms = new MemoryStream(url.DownloadData(webUrl));
            doc = new HtmlAgilityPack.HtmlDocument();
            doc.Load(ms, Encoding.UTF8);

            hdc = new HtmlAgilityPack.HtmlDocument();
            hdc.LoadHtml(doc.DocumentNode.SelectSingleNode(" / html[1]/body[1]/div[1]/main[1]/div[4]/table[1]/tbody[1]").InnerHtml);
            htnode = hdc.DocumentNode.SelectNodes("./tr");

            rDate = new string[htnode.Count];
            rRate = new double[htnode.Count];

            for (int a = 0; a < htnode.Count; a++)
            {
                if (Currency != "KRW")
                {
                    h1 = string.Format("./tr[{0}]/td[1]", a + 1);
                    h2 = string.Format("./tr[{0}]/td[4]", a + 1);
                }
                else //韓元沒即期匯率，所以抓現金匯率
                {
                    h1 = string.Format("./tr[{0}]/td[1]", a + 1);
                    h2 = string.Format("./tr[{0}]/td[6]", a + 1);
                }
                rDate[a] = (hdc.DocumentNode.SelectSingleNode(h1).InnerText);
                rRate[a] = Convert.ToDouble(hdc.DocumentNode.SelectSingleNode(h2).InnerText);
            }

            rate = rRate.Min();

            RateMin = rate;
            int index = Array.IndexOf(rRate, rate);

            TodayDate = rDate[0];
            TodayRate = rRate[0];

            DateMin = rDate[index];




        }




    }
}
