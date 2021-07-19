using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleLicenseTax
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }

        private void SelectCarType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] MotoCycle = new string[] { "150以下 / 12HP以下(12.2PS以下)", "151-250 / 12.1-20HP(12.3-20.3PS)", "251-500 / 20.1HP以上(20.4PS以上)", "501-600", "601-1200", "1201-1800",
                "1801或以上" };

            string[] TruckCar = new string[] { "500以下", "501-600", "601-1200", "1201-1800", "1801-2400", "2401-3000 / 138HP以下(140.1PS以下)"
                , "3001-3600", "3601-4200 / 138.1-200HP(140.2-203.0PS)", "4201-4800", "4801-5400 / 200.1-247HP(203.1-250.7PS)","5401-6000","6001-6600 / 247.1-286HP(250.8-290.3PS)","6601-7200","7201-7800 / 286.1-336HP(290.4-341.0PS)"
                ,"7801-8400","9001-9600","9601-10200 / 361.1HP以上(366.5PS以上)","10201以上" };

            string[] CoachCar = new string[] {"600以下", "601-1200", "1201-1800", "1801-2400", "2401-3000 / 138HP以下(140.1PS以下)"
                , "3001-3600", "3601-4200 / 138.1-200HP(140.2-203.0PS)", "4201-4800", "4801-5400 / 200.1-247HP(203.1-250.7PS)","5401-6000","6001-6600 / 247.1-286HP(250.8-290.3PS)","6601-7200","7201-7800 / 286.1-336HP(290.4-341.0PS)"
                ,"7801-8400","9001-9600","9601-10200 / 361.1HP以上(366.5PS以上)","10201以上" };

            string[] Private_Passenger_Car = new string[] { "500以下 / 38HP以下(38.6PS以下)", "501~600 / 38.1-56HP(38.7-56.8PS)", "601~1200 / 56.1-83HP(56.9-84.2PS)", "1201~1800 / 83.1-182HP(84.3-184.7PS)" , "1801~2400 / 182.1-262HP(184.8-265.9PS)", "2401~3000 / 262.1-322HP(266-326.8PS)",
                "3001-4200 / 322.1-414HP(326.9-420.2PS", "4201-5400 / 414.1-469HP(420.3-476.0PS)", "5401-6600 / 469.1-509HP(476.1-516.6PS)", "6601-7800 / 509.1HP以上(516.7PS以上)", "7801以上" };

            string[] Commercial_Passenger_Car = new string[] { "500以下 / 38HP以下(38.6PS以下)", "501~600 / 38.1-56HP(38.7-56.8PS)", "601~1200 / 56.1-83HP(56.9-84.2PS)", "1201~1800 / 83.1-182HP(84.3-184.7PS)", "1801~2400 / 182.1-262HP(184.8-265.9PS)", "2401~3000 / 262.1-322HP(266-326.8PS)", "3001-4200 / 322.1-414HP(326.9-420.2PS)", "4201-5400 / 414.1-469HP(420.3-476.0PS)", "5401-6600 / 469.1-509HP(476.1-516.6PS)",
                "6601-7800 / 509.1HP以上(516.7PS以上)", "7801以上" };

            string CarType = SelectCarType.Text;


            if (CarType == "機車")
            {
                MotorCC_Type.Items.Clear();
                foreach (var bike in MotoCycle)
                {
                    MotorCC_Type.Items.Add($"{bike}");
                }
                MotorCC_Type.SelectedIndex = 0;
            }
            else if (CarType == "貨車")
            {
                MotorCC_Type.Items.Clear();
                foreach (var truck in TruckCar)
                {
                    MotorCC_Type.Items.Add($"{truck}");
                }
                MotorCC_Type.SelectedIndex = 0;
            }
            else if (CarType == "大客車")
            {
                MotorCC_Type.Items.Clear();
                foreach (var coaches in CoachCar)
                {
                    MotorCC_Type.Items.Add($"{coaches}");
                }
                MotorCC_Type.SelectedIndex = 0;
            }
            else if (CarType == "自用小客車")
            {
                MotorCC_Type.Items.Clear();
                foreach (var P_P_Car in Private_Passenger_Car)
                {
                    MotorCC_Type.Items.Add($"{P_P_Car}");
                }
                MotorCC_Type.SelectedIndex = 0;
            }
            else
            {
                MotorCC_Type.Items.Clear();
                foreach (var C_P_Car in Commercial_Passenger_Car)
                {
                    MotorCC_Type.Items.Add($"{C_P_Car}");
                }
                MotorCC_Type.SelectedIndex = 0;
            }

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            DayGroup.Visible = false;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.DayGroup.Visible = true;
        }
        private void Btn_SendData_Click(object sender, EventArgs e)
        {

            int years = 365;
            ShowResult.Text = string.Empty;
            this.ShowResult.Visible = true;
            if (this.dateTimePicker1.Value >= this.dateTimePicker2.Value)
            {
                MessageBox.Show("結束日一定要比起始日還晚，請重新選擇");
                return;
            }


            //計算公式
            decimal Formula = GetFormula();

            //當年度總天數
            int YearsDays = GetThisYearDays();
            int DiffDays = GetFromDayTo();

            //所得稅率
            decimal GetStamp = GetFormula();

            //所得當年度總額
            decimal Amount_ThisYear = Math.Truncate(GetStamp * YearsDays / YearsDays);

            //所得依期間總額
            decimal Amount_DiffDays = Math.Truncate(GetStamp * DiffDays / YearsDays);

            bool ThisYearCheck = radioButton1.Checked;
            bool diffDateCheck = radioButton2.Checked;
            DateTime dec31 = new DateTime(DateTime.Now.Year, 12, 31);

            DateTime StartDays = dateTimePicker1.Value;
            DateTime startYear_1 = new DateTime(StartDays.Year, 1, 1);
            DateTime endYear_1 = new DateTime(StartDays.Year, 12, 31);

            DateTime EndDays = dateTimePicker2.Value;
            DateTime startYear_2 = new DateTime(EndDays.Year, 1, 1);
            DateTime endYear_2 = new DateTime(EndDays.Year, 12, 31);

            //當年度總天數變數↓
            int dateToDisplay = dec31.DayOfYear;

            //依期間天數差變數↓
            int diffDateDays = GetFromDayTo();

            DateTime Moment = new DateTime(DateTime.Now.Year, 01, 01);
            int ThisYear = Moment.Year;
            if (ThisYearCheck == true)
            {
                ShowResult.Text += $"使用期間:{ThisYear}-01-01~{ThisYear}-12-31 " + Environment.NewLine +
                    $"計算天數:{YearsDays}" + Environment.NewLine + $"汽缸CC數:{MotorCC_Type.SelectedItem.ToString()}"
                    + Environment.NewLine + $"用途:{SelectCarType.SelectedItem.ToString()}" + Environment.NewLine
                    + $"計算公式:{Formula}*{YearsDays}/{YearsDays} ={Amount_ThisYear}" + Environment.NewLine
                    + $"應納稅額:共{Amount_ThisYear.ToString("#,0")}元";


            }
            else if (diffDateCheck == true)
            {

                //依期間開始與結束變數
                DateTime date1 = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;



                int s_Month;
                int s_Day;
                int e_Month;
                int e_Day;

                for (int countYear = date1.Year; countYear <= date2.Year; countYear++)
                {
                    if (countYear > date1.Year)
                    {
                        s_Month = 1;
                        s_Day = 1;
                    }
                    else
                    {
                        s_Month = date1.Month;
                        s_Day = date1.Day;
                    }
                    DateTime start2 = new DateTime(countYear, s_Month, s_Day);
                    if (countYear < date2.Year)
                    {
                        e_Month = 12;
                        e_Day = 31;
                    }
                    else
                    {
                        e_Month = date2.Month;
                        e_Day = date2.Day;
                    }
                    DateTime end2 = new DateTime(countYear, e_Month, e_Day);
                    int timeSpan = (end2 - start2).Days + 1;

                    if (countYear % 4 == 0 && countYear % 100 != 0)
                        years = 366;
                    else
                        years = 365;
                    decimal money = Formula * timeSpan / years;
                    ShowResult.Text += $"使用期間:{countYear}-{s_Month}-{s_Day}~{countYear}-" +
                       $"{e_Month}-{e_Day} " + Environment.NewLine + $"計算天數:{timeSpan}" + Environment.NewLine
                     + $"汽缸CC數:{MotorCC_Type.SelectedItem.ToString()}" + Environment.NewLine +
                       $"用途:{SelectCarType.SelectedItem.ToString()}" + Environment.NewLine +
                       $"計算公式:{Formula}*{timeSpan}/{years} ={money.ToString("#,0")}" + Environment.NewLine +
                       $"應納稅額:共{money.ToString("#,0")}元" + Environment.NewLine
                      ;

                    ShowResult.Text += Environment.NewLine;
                }

            }
        }

        //重製按鈕
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Init();
        }

        #region "Custom Method"
        /// <summary> 初始化計算表 </summary>
        private void Init()
        {
            radioButton1.Checked = true;
            SelectCarType.SelectedIndex = 0;
            MotorCC_Type.SelectedIndex = 0;
            DayGroup.Visible = false;
            ShowResult.Text = string.Empty;
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dateTimePicker2.Value = new DateTime(DateTime.Now.Year, 12, 31);
        }
        /// <summary> 獲得計算公式</summary>
        private decimal GetFormula()
        {
            string CarType = SelectCarType.Text;
            string MotorCC = MotorCC_Type.Text;

            //選擇"機車"和"當年度"時回傳的公式
            if (CarType == "機車" && MotorCC == "150以下 / 12HP以下(12.2PS以下)")
            {
                return 0;
            }
            else if (CarType == "機車" && MotorCC == "151-250 / 12.1-20HP(12.3-20.3PS)")
            {
                return 800;
            }
            else if (CarType == "機車" && MotorCC == "251-500 / 20.1HP以上(20.4PS以上)")
            {
                return 1620;
            }
            else if (CarType == "機車" && MotorCC == "501-600")
            {
                return 2160;
            }
            else if (CarType == "機車" && MotorCC == "601-1200")
            {
                return 4320;
            }
            else if (CarType == "機車" && MotorCC == "1201-1800")
            {
                return 7120;
            }
            else if (CarType == "機車" && MotorCC == "1801或以上")
            {
                return 11230;
            }

            //選擇"貨車"以及"當年度"時回傳的公式
            else if (CarType == "貨車" && MotorCC == "500以下")
            {
                return 900;
            }
            else if (CarType == "貨車" && MotorCC == "501-600")
            {
                return 1080;
            }
            else if (CarType == "貨車" && MotorCC == "601-1200")
            {
                return 1800;
            }
            else if (CarType == "貨車" && MotorCC == "1201-1800")
            {
                return 2700;
            }
            else if (CarType == "貨車" && MotorCC == "1201-1800")
            {
                return 2700;
            }
            else if (CarType == "貨車" && MotorCC == "1801-2400")
            {
                return 3600;
            }
            else if (CarType == "貨車" && MotorCC == "2401-3000 / 138HP以下(140.1PS以下)")
            {
                return 4500;
            }
            else if (CarType == "貨車" && MotorCC == "3001-3600")
            {
                return 5400;
            }
            else if (CarType == "貨車" && MotorCC == "3601-4200 / 138.1-200HP(140.2-203.0PS)")
            {
                return 6300;
            }
            else if (CarType == "貨車" && MotorCC == "4201-4800")
            {
                return 7200;
            }
            else if (CarType == "貨車" && MotorCC == "4801-5400 / 200.1-247HP(203.1-250.7PS)")
            {
                return 8100;
            }
            else if (CarType == "貨車" && MotorCC == "5401-6000")
            {
                return 9000;
            }
            else if (CarType == "貨車" && MotorCC == "6001-6600 / 247.1-286HP(250.8-290.3PS)")
            {
                return 9900;
            }
            else if (CarType == "貨車" && MotorCC == "6601-7200")
            {
                return 10800;
            }
            else if (CarType == "貨車" && MotorCC == "7201-7800 / 286.1-336HP(290.4-341.0PS)")
            {
                return 11700;
            }
            else if (CarType == "貨車" && MotorCC == "7801-8400")
            {
                return 12600;
            }
            else if (CarType == "貨車" && MotorCC == "8401-9000 / 336.1-361HP(341.1-366.4PS)")
            {
                return 13500;
            }
            else if (CarType == "貨車" && MotorCC == "9001-9600")
            {
                return 14400;
            }
            else if (CarType == "貨車" && MotorCC == "9601-10200 / 361.1HP以上(366.5PS以上)")
            {
                return 15300;
            }
            else if (CarType == "貨車" && MotorCC == "10201以上")
            {
                return 16200;
            }

            //選擇"大客車"和"當年度"時回傳的公式
            else if (CarType == "大客車" && MotorCC == "600以下")
            {
                return 1080;
            }
            else if (CarType == "大客車" && MotorCC == "601-1200")
            {
                return 1800;
            }
            else if (CarType == "大客車" && MotorCC == "1201-1800")
            {
                return 2700;
            }
            else if (CarType == "大客車" && MotorCC == "1801-2400")
            {
                return 3600;
            }
            else if (CarType == "大客車" && MotorCC == "2401-3000 / 138HP以下(140.1PS以下)")
            {
                return 4500;
            }
            else if (CarType == "大客車" && MotorCC == "3001-3600")
            {
                return 5400;
            }
            else if (CarType == "大客車" && MotorCC == "3601-4200 / 138.1-200HP(140.2-203.0PS)")
            {
                return 6300;
            }
            else if (CarType == "大客車" && MotorCC == "4201-4800")
            {
                return 7200;
            }
            else if (CarType == "大客車" && MotorCC == "4801-5400 / 200.1-247HP(203.1-250.7PS)")
            {
                return 8100;
            }
            else if (CarType == "大客車" && MotorCC == "5401-6000")
            {
                return 9000;
            }
            else if (CarType == "大客車" && MotorCC == "6001-6600 / 247.1-286HP(250.8-290.3PS)")
            {
                return 9900;
            }
            else if (CarType == "大客車" && MotorCC == "6601-7200")
            {
                return 10800;
            }
            else if (CarType == "大客車" && MotorCC == "7201-7800 / 286.1-336HP(290.4-341.0PS)")
            {
                return 11700;
            }
            else if (CarType == "大客車" && MotorCC == "7801-8400")
            {
                return 12600;
            }
            else if (CarType == "大客車" && MotorCC == "8401-9000 / 336.1-361HP(341.1-366.4PS)")
            {
                return 13500;
            }
            else if (CarType == "大客車" && MotorCC == "9001-9600")
            {
                return 14400;
            }
            else if (CarType == "大客車" && MotorCC == "9601-10200 / 361.1HP以上(366.5PS以上)")
            {
                return 15300;
            }
            else if (CarType == "大客車" && MotorCC == "10201以上")
            {
                return 16200;
            }

            //選擇"自用小客車"和"當年度"時回傳的公式
            else if (CarType == "自用小客車" && MotorCC == "500以下 / 38HP以下(38.6PS以下)")
            {
                return 1620;
            }
            else if (CarType == "自用小客車" && MotorCC == "501~600 / 38.1-56HP(38.7-56.8PS)")
            {
                return 2160;
            }
            else if (CarType == "自用小客車" && MotorCC == "601~1200 / 56.1-83HP(56.9-84.2PS)")
            {
                return 4320;
            }
            else if (CarType == "自用小客車" && MotorCC == "1201~1800 / 83.1-182HP(84.3-184.7PS)")
            {
                return 7120;
            }
            else if (CarType == "自用小客車" && MotorCC == "1801~2400 / 182.1-262HP(184.8-265.9PS)")
            {
                return 11230;
            }
            else if (CarType == "自用小客車" && MotorCC == "2401~3000 / 262.1-322HP(266-326.8PS)")
            {
                return 15210;
            }
            else if (CarType == "自用小客車" && MotorCC == "3001-4200 / 322.1-414HP(326.9-420.2PS")
            {
                return 28220;
            }
            else if (CarType == "自用小客車" && MotorCC == "4201-5400 / 414.1-469HP(420.3-476.0PS)")
            {
                return 46170;
            }
            else if (CarType == "自用小客車" && MotorCC == "5401-6600 / 469.1-509HP(476.1-516.6PS)")
            {
                return 69690;
            }
            else if (CarType == "自用小客車" && MotorCC == "6601-7800 / 509.1HP以上(516.7PS以上)")
            {
                return 117000;
            }
            else if (CarType == "自用小客車" && MotorCC == "7801以上")
            {
                return 151200;
            }

            //選擇"營業用小客車"和"當年度"時回傳的公式
            else if (CarType == "營業用小客車" && MotorCC == "500以下 / 38HP以下(38.6PS以下)")
            {
                return 900;
            }
            else if (CarType == "營業用小客車" && MotorCC == "501~600 / 38.1-56HP(38.7-56.8PS)")
            {
                return 1260;
            }
            else if (CarType == "營業用小客車" && MotorCC == "601~1200 / 56.1-83HP(56.9-84.2PS)")
            {
                return 2160;
            }
            else if (CarType == "營業用小客車" && MotorCC == "1201~1800 / 83.1-182HP(84.3-184.7PS)")
            {
                return 3060;
            }
            else if (CarType == "營業用小客車" && MotorCC == "1801~2400 / 182.1-262HP(184.8-265.9PS)")
            {
                return 6480;
            }
            else if (CarType == "營業用小客車" && MotorCC == "2401~3000 / 262.1-322HP(266-326.8PS)")
            {
                return 9900;
            }
            else if (CarType == "營業用小客車" && MotorCC == "3001-4200 / 322.1-414HP(326.9-420.2PS")
            {
                return 16380;
            }
            else if (CarType == "營業用小客車" && MotorCC == "4201-5400 / 414.1-469HP(420.3-476.0PS)")
            {
                return 24300;
            }
            else if (CarType == "營業用小客車" && MotorCC == "5401-6600 / 469.1-509HP(476.1-516.6PS)")
            {
                return 33660;
            }
            else if (CarType == "營業用小客車" && MotorCC == "6601-7800 / 509.1HP以上(516.7PS以上)")
            {
                return 44460;
            }
            else
            {
                return 56700;
            }
        }

        /// <summary> 計算當年度總天數</summary>
        private int GetThisYearDays()
        {
            DateTime dec31 = new DateTime(DateTime.Now.Year, 12, 31);

            //當年度總天數變數↓
            int dateToDisplay = dec31.DayOfYear;
            return dateToDisplay;
        }

        /// <summary>計算依期間的日期差 </summary>
        private int GetFromDayTo()
        {

            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            TimeSpan span = date2 - date1;
            int diffDays = span.Days + 1;
            return diffDays;
        }
    }
    #endregion
}


