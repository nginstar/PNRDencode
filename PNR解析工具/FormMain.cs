using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
using System.Threading;
using System.Net;

namespace PNR解析工具
{
    public partial class FormMain : Form
    {
        bool bStopProc = false;//解析文件
        bool bStopScan = false;//扫描
        string[] sAddr = new string[] { "AQG","安庆","JUH","池州","FUG","阜阳","HFE","合肥","TXN","黄山","NAY","北京南苑","PEK","北京首都","FOC","福州","JJN","晋江","LCX","连城","WUS","武夷山","XMN","厦门","CHW","酒泉","DNH","敦煌","IQN","庆阳","JGN","嘉峪关","LHW","兰州","CAN","广州","FUO","佛山","MXZ","梅县","SWA","揭阳","SZX","深圳","ZHA","湛江","ZUH","珠海","BHY","北海","KWL","桂林","LZH","柳州","NNG","南宁","WUZ","梧州","ACX","兴义","AEB","百色","KWE","贵阳","TEN","铜仁","ZYI","遵义","HZH","黎平","AVA","安顺","HAK","海口","SYX","三亚","HDG","邯郸","SHP","秦皇岛","SJW","石家庄","AYN","安阳","CGO","郑州","LYA","洛阳","NNY","南阳","DQA","大庆","HEK","黑河","HRB","哈尔滨","JMU","佳木斯","MDG","牡丹江","NDG","齐齐哈尔","ENH","恩施","WUH","武汉","XFN","襄樊","YIH","宜昌","CGD","常德","CSX","长沙","DYG","张家界","HJJ","芷江","LLF","永州","CGQ","长春","JIL","吉林","TNH","通化","CZX","常州","LYG","连云港","NKG","南京","NTG","南通","WUX","无锡","XUZ","徐州","YTY","扬州泰州","YNZ","盐城","SZV","苏州","JDZ","景德镇","JGS","井冈山","JIU","九江","KHN","南昌","KOW","赣州","AOG","鞍山","CHG","朝阳","CNI","长海","DDG","丹东","DLC","大连","JNZ","锦州","SHE","沈阳","YNJ","延吉","BAV","包头","CIF","赤峰","DSN","鄂尔多斯","HET","呼和浩特","HLD","海拉尔","HLH","乌兰浩特","NZH","满洲里","TGO","通辽","WUA","乌海","XIL","锡林浩特","INC","银川","GOQ","格尔木","XNN","西宁","DOY","东营","JNG","济宁","TAO","青岛","TNA","济南","WEF","潍坊","WEH","威海","YNT","烟台","CIH","长治","DAT","大同","LYI","临沂","TYN","太原","YCU","运城","AKA","安康","ENY","延安","HZG","汉中","UYN","榆林","XIY","西安","PVG","上海浦东","CTU","成都","DAX","达县","GNY","广元","JZH","九寨沟","LZO","泸州","MIG","绵阳","NAO","南充","PZI","攀枝花","WXN","万州","XIC","西昌","YBP","宜宾","TSN","天津","BPX","昌都","LXA","拉萨","AKU","阿克苏","FYN","富蕴","HMI","哈密","HTN","和田","IQM","且末","KCA","库车","KHG","喀什","KRL","库尔勒","KRY","克拉玛依","TCG","塔城","URC","乌鲁木齐","YIN","伊宁","BSD","保山","DIG","迪庆","DLU","大理","JHG","西双版纳","KMG","昆明","LJG","丽江","LNJ","临沧","LUM","德宏","SYM","思茅","ZAT","昭通","HGH","杭州","HSN","舟山","HYN","黄岩","JUZ","衢州","NGB","宁波","WNZ","温州","YIW","义乌","CKG","重庆","HKG","香港","MFM","澳门","OHE","漠河","HIV","淮安","KGT","甘孜","LLV","吕梁","JGD","加格达","WUH","武汉","BFJ","毕节","TCZ","腾冲","SHA","上海虹桥","NGQ","阿里","TVS","唐山","HIA","淮安","JIC","金昌","JIQ","黔江","WUX","无锡","WNH","文山","NBS","白山","DCY","甘孜","ZQZ","张家口","JXA","鸡西","LZY","林芝","GYS","广元","ERL","二连浩特","AAT","阿勒泰","KJI","喀纳斯","LLB","荔波","BPL","博乐","RLK","巴彦淖尔","KJH","凯里","AXF","阿拉善左旗"};
        string[] sAirLine = new string[] {"CA","中国国航","8L","祥鹏航空","KN","联合航空","BK","奥凯航空","HO","吉祥航空","GS","天津航空","G5","华夏航空","PN","西部航空","JD","首都航空","OQ","重庆航空","MU","东方航空","CZ","南方航空","CN","大新华航空","NS","河北航空","VD","祥鹏航空","JR","幸福航空","KY","昆明航空","9C","春秋航空","3U","四川航空","EU","成都航空","FM","上海航空","HU","海南航空","MF","厦门航空","SC","山东航空","ZH","深圳航空","TV","西藏航空","CJ","北方航空","SZ","西南航空","WH","西北航空","X2","新华航空","F6","航空股份","3Q","云南航空","XO","新疆航空","Z2","中原航空","WU","武汉航空","G4","贵州航空","GP","通用航空","3W","南京航空","ZJ","浙江航空","GW","长城航空","FJ","福建航空","2Z","长安航空","GJ","长龙航空","UQ","乌鲁木齐航空","QW","青岛航空","DR","瑞丽航空","DZ","东海航空" };
        string sFilePath = "";
        string []sFilePathUrlList;
        ArrayList ALTel = new ArrayList();
        string sCurrentDir = "";
        public delegate void set_LB_Log(string s); //定义委托
        set_LB_Log Set_LB_Log;
        int i总数据量 = 0;
        int i有效数据量 = 0;
        int i联系人错误 = 0;
        int i航班错误 = 0;
        int i无号码 = 0;
        int i号码重复 =0;
        int i组用户信息 = 0;
        DateTime DTStart;
        DateTime DTEnd;
        StreamWriter SW;
        int iThreadNum = 50;
        int iThreadNumCount = 0;//线程计数
        int iTryCount = 10;
        int iTryTime = 5000;
        object oLockThread = new object();
        object oLockWriteFile = new object();
        struct sAirInfo
        {
          public  string 大编码;
          public string 姓名;
          public string 乘客身份;
          public string 日期;
          public string 航空公司;
          public string 航班号;
          public string 起点终点;
          public string 起飞时间;
          public string 降落时间;
          public string 票号信息;
          public string 联系人手机号码;
        }
        public void LoadIni()
        {
            Ini ini = new Ini(sCurrentDir + "/Config.ini");
            try
            {
                CB_SelLog.Checked = Convert.ToBoolean(Convert.ToInt32(ini.ReadValue("Setting", "CB_SelLog")));
                CB_TxtLog.Checked = Convert.ToBoolean(Convert.ToInt32(ini.ReadValue("Setting", "CB_TxtLog")));
                CB_Kilo.Checked = Convert.ToBoolean(Convert.ToInt32(ini.ReadValue("Setting", "CB_Kilo")));
                sFilePath = ini.ReadValue("Setting", "sFilePath");
                iThreadNum =Convert.ToInt32(ini.ReadValue("Setting", "iThreadNum"));
                 iTryCount =Convert.ToInt32(ini.ReadValue("Setting", "iTryCount"));
                iTryTime =Convert.ToInt32(ini.ReadValue("Setting", "iTryTime"));
               
            }
            catch
            {
                SaveIni();
            }
        }
        public void SaveIni()
        {
            Ini ini = new Ini(sCurrentDir + "/Config.ini");

            if (this.WindowState == FormWindowState.Normal)
            {
                ini.Writue("Setting", "FormMain_Width", this.Width.ToString());
                ini.Writue("Setting", "FormMain_Height", this.Height.ToString());

            }
            ini.Writue("Setting", "sFilePath", sFilePath);
          
            ini.Writue("Setting", "CB_SelLog", Convert.ToString(Convert.ToInt32(CB_SelLog.Checked)));
            ini.Writue("Setting", "CB_TxtLog", Convert.ToString(Convert.ToInt32(CB_TxtLog.Checked)));
            ini.Writue("Setting", "CB_Kilo", Convert.ToString(Convert.ToInt32(CB_Kilo.Checked)));
            ini.Writue("Setting", "iThreadNum", this.iThreadNum.ToString());
            ini.Writue("Setting", "iTryCount", this.iTryCount.ToString());
            ini.Writue("Setting", "iTryTime", this.iTryTime.ToString());

        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            sCurrentDir = Application.StartupPath;
            LoadIni();
            Set_LB_Log = new set_LB_Log(AddLogInvok);
            CB_ThreadNum.Text = iThreadNum.ToString();
            CB_TryNum.Text = iTryCount.ToString();
            CB_TryTime.Text = iTryTime.ToString() + "ms";
            try
            {
                if (!Directory.Exists(sCurrentDir + "/Logs/"))
                {
                    Directory.CreateDirectory(sCurrentDir + "/Logs/");
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("创建系统缓存目录的时候，出现错误,可能会导致无法查询\r\n错误描述:" + ex.Message, "创建系统缓存目录失败", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
             TB_FilePath.Text = sFilePath;
          this.Text+="[V:" + System.Windows.Forms.Application.ProductVersion + "]最后更新:" + File.GetLastWriteTime(System.Windows.Forms.Application.ExecutablePath);


        }
        public void AddLog(string sStr)
        {
            try
            {
                LB_Log.Invoke(Set_LB_Log, new object[] { sStr });
            }
            catch
            {
            }

        }
        public void AddLogInvok(string sStr)//添加日志
        {
            if (sStr.StartsWith("有效数据量"))//状态信息，直接写到状态位
            {
                LBState.Text = sStr;
                return;
            }

            LB_Log.Items.Add(DateTime.Now.ToLongTimeString() + "  " + sStr);
            if (CB_SelLog.Checked)
            {
                LB_Log.SelectedIndex = LB_Log.Items.Count - 1;

            }
            if (CB_Kilo.Checked && LB_Log.Items.Count >= 1000)
            {
                LB_Log.Items.Clear();
            }
            if (CB_TxtLog.Checked)
            {
                try
                {
                    StreamWriter sw = new StreamWriter(sCurrentDir + "/Logs/Log_" + DateTime.Now.ToString("yy-MM-dd") + ".log", true);

                    //Write a line of text
                    sw.WriteLine(DateTime.Now.ToShortTimeString() + " " + sStr);

                    //Close the file
                    sw.Close();
                    sw.Dispose();
                }
                catch (Exception ex)
                {
                    LB_Log.Items.Add(DateTime.Now.ToLongTimeString() + "  写日志错误：" + ex.Message);
                }
            }
        }

        private void BTN_Choose_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "请选择PNR原始文本文件";
            openFileDialog1.ShowDialog();

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            TB_FilePath.Text = openFileDialog1.FileName;
        }

        private void TB_FilePath_TextChanged(object sender, EventArgs e)
        {
            sFilePath = TB_FilePath.Text;
        }

     
 
        private void BG_Proc_DoWork(object sender, DoWorkEventArgs e)
        {
            DTStart = DateTime.Now;
            ALTel.Clear();
            AddLog("开始解析:"+sFilePath);
            StreamReader SR;
            try
            {
               SR = new StreamReader(sFilePath, false);
            }
            catch(Exception ex)
            {
                AddLog("错误:" + ex.Message);
                return;
            }
            SW = new StreamWriter(sFilePath + "_解析结果.txt", false);
            string sItem = "";//一项数据
            string sItemTemp = "";
            string sLine = "";//一行数据
            long lReadLength = 0;
            int iReadCount = 0;
            i总数据量 = 0;
            i有效数据量 = 0;
            i联系人错误 = 0;
            i无号码 = 0;
            i号码重复 = 0;
            i组用户信息 = 0;
            i航班错误 = 0;
            while (!SR.EndOfStream)
            {
                if (bStopProc)
                {
                    SR.Close();
                    SR.Dispose();
                    SW.Close();
                    SW.Dispose();
                    return;
                }
                sItem = "";
                iReadCount = 0;
                AddLog("有效数据量:"+i有效数据量+ "/已解析:" + i总数据量.ToString()); 
                while (!SR.EndOfStream)
                {

                    if (bStopProc)
                    {
                        SR.Close();
                        SR.Dispose();
                         SW.Close();
                         SW.Dispose();
                        return;
                    }
                    sLine = SR.ReadLine();
                    lReadLength += sLine.Length;
                    if ((sLine.Trim().StartsWith("1.") || sLine.Trim().StartsWith("0.")) && sItemTemp != "" && iReadCount>1)
                    {
                        sItem = sItemTemp;
                        sItemTemp = sLine.Trim() + "\r\n";
                        break;

                    }
                    else
                    {
                        sItemTemp += sLine.Trim() + "\r\n";
                        iReadCount++;
                    }
                    
                }
                if (sItem == "")//没有数据了，缓存取出来
                {
                    sItem = sItemTemp;
                }
                
                i总数据量++;
                if (sItem.StartsWith("0."))
                {
                    i组用户信息++;
                    AddLog("组用户信息，忽略:" + sItem.Substring(0, 30) + "...");
                }
                else
                {
                    DoProce(sItem);//解析
                }
            }
            
            SR.Close();
            SR.Dispose();
            SW.Close();
            SW.Dispose();
            AddLog("开始汇总号码...");
            SW = new StreamWriter(sFilePath + "_所有号码汇总.txt", false);
            for (int i = 0; i < ALTel.Count; i++)
            {
                SW.WriteLine((string)ALTel[i]);
            }
            SW.Close();
            SW.Dispose();
            AddLog("号码汇总完成，共[" + ALTel.Count.ToString()+ "]条，保存在:" + sFilePath + "_所有号码汇总.txt");
           
        }
        public bool DoProce(string sItem)
        {
           
            sAirInfo sAI = new sAirInfo();
            Match m;
            MatchCollection mc;
            Regex r;
            string sTelTemp = "";
            string sExpStr = @"^1\.(.+?)\s(\w{6})/MU|^1\.(.+?)\s(\w{6}).+?\n";
            r = new Regex(sExpStr, RegexOptions.Compiled | RegexOptions.Singleline|RegexOptions.IgnoreCase);
            m = r.Match(sItem);
            if (m.Success)
            {
                if (m.Groups[2].Value!="")
                {
                    sAI.大编码 = m.Groups[2].Value;
                    sAI.姓名 = m.Groups[1].Value;
                    sAI.姓名 = Regex.Replace(sAI.姓名, "\\d+\\.", " ");
                    sAI.姓名 = sAI.姓名.Replace("\r\n", "");
                }
                else
                {
                    sAI.大编码 = m.Groups[4].Value;
                    sAI.姓名 = m.Groups[3].Value;
                    sAI.姓名 = Regex.Replace(sAI.姓名, "\\d+\\.", " ");
                    sAI.姓名 = sAI.姓名.Replace("\r\n", "");
                }
               
            }
            else
            {
                i联系人错误++;
                AddLog("联系人错误:"+sItem.Substring(0,30)+"...");
                return false;
            }
           
            sExpStr = @"\d+\.SSR\s*FOID(.+?)\s(\w+/P\d+)\r\n";
            r = new Regex(sExpStr, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            mc = r.Matches(sItem);
            sAI.乘客身份 = "";
             for (int i = 0; i < mc.Count; i++)
            {
                sAI.乘客身份 += mc[i].Groups[2].Value + " ";
               
            }

            sAI.乘客身份 = sAI.乘客身份.Trim();

            //2. *MU9057 T   MO27OCT  PVGZUH RR1   1205 1450      E T1-- OP-FM9057

            sExpStr = @"\d+\.\s(.{6,9})\s[Y|B|M|E|H|K|L|N|R|V|S|T|Z]\s*(\w+)\s*(\w+)\sRR\d+\s*(\d+)\s(\d+)\s*";
             r = new Regex(sExpStr, RegexOptions.Compiled | RegexOptions.IgnoreCase);
             m = r.Match(sItem);
             if (m.Success)
             {
                 sAI.日期 = GetDate(m.Groups[2].Value.Trim());
                 sAI.航班号 = m.Groups[1].Value.Trim().Replace("*", "");
                 sAI.航空公司 = GetAirLine(sAI.航班号);
                 sAI.起点终点 = GetAddr(m.Groups[3].Value.Trim());
                 sAI.起飞时间 = GetTime(m.Groups[4].Value.Trim());
                 sAI.降落时间 = GetTime(m.Groups[5].Value.Trim());

             }
             else
             {
                 i航班错误++;
                 AddLog("航班错误:" + sItem.Substring(0, 30) + "...");
                 return false;
             }
            
             sExpStr = @"\d+\.SSR\s*TKNE(.+?)\s(\d+/\d+/P\d+)\r\n";
             r = new Regex(sExpStr, RegexOptions.Compiled | RegexOptions.IgnoreCase);
             mc = r.Matches(sItem);
             sAI.票号信息 = "";
             for (int i = 0; i < mc.Count; i++)
             {
                 sAI.票号信息 += mc[i].Groups[2].Value + " ";

             }
                 sAI.票号信息 = sAI.票号信息.Trim();

                 sExpStr = @"OSI.+?CTC[A-Z](1[3|4|5|8]\d{9})|(1[3|4|5|8]\d{9})";
             r = new Regex(sExpStr, RegexOptions.Compiled | RegexOptions.IgnoreCase);
             mc = r.Matches(sItem);
             sAI.联系人手机号码 = "";
             for (int i = 0; i < mc.Count; i++)
             {
                 if (mc[i].Groups[1].Value != "")
                 {
                     sTelTemp = mc[i].Groups[1].Value;
                 }
                 else
                 {
                     sTelTemp = mc[i].Groups[2].Value;
                 }
                 if (sTelTemp == "")
                 {
                     continue;
                 }
                 if (sAI.联系人手机号码.IndexOf(sTelTemp) == -1)//去重复
                 {
                     sAI.联系人手机号码 += sTelTemp + " ";
                     for (int j = 0; j < ALTel.Count; j++)
                     {
                         if (sTelTemp == ((string)ALTel[j]))
                         {
                             AddLog("号码重复:" + sItem.Substring(0, 30) + "...");
                             i号码重复++;
                             return false;
                         }

                     }

                     ALTel.Add(sTelTemp);
                     
                 }
             }
            
            sAI.联系人手机号码 = sAI.联系人手机号码.Trim();

            if (sAI.联系人手机号码 == "")
            {
                AddLog("无号码数据:" + sItem.Substring(0, 30) + "...");
                i无号码++;
                return false;
            }
             i有效数据量++;
             SW.WriteLine(sAI.大编码 + "\t" + sAI.姓名 + "\t" + sAI.乘客身份 + "\t" + sAI.日期 + "\t" + sAI.航空公司 + "\t" + sAI.航班号 + "\t" + sAI.起点终点 + "\t" + sAI.起飞时间 + "-" + sAI.降落时间 + "\t" + sAI.票号信息 + "\t" + sAI.联系人手机号码);
            
            return true;


        }
        private string GetDate(string sStr)//日期转换
        {
            if (sStr.Length != 7)
            {
                return sStr;
            }
            string sMon = sStr.Substring(4, 3);
            string sDay=sStr.Substring(2,2);
            string sDate = DateTime.Now.Year.ToString() + "-" + sMon + "-" + sDay;
            DateTime DT = new DateTime();
            DT = Convert.ToDateTime(sDate);

            return DT.ToString("MM月dd日");
        }
        private string GetAirLine(string sStr)//航空公司转换
        {
            if (sStr.Length !=6)
            {
                return sStr;
            }
            string sLineInfo = sStr.Substring(0, 2);
            for (int i = 0; i < sAddr.Length; i = i + 2)
            {
                if (sAirLine[i] == sLineInfo)
                {
                    sLineInfo = sAirLine[i + 1];
                    return sLineInfo;
                }
            }
            return sStr;
        }
        private string GetAddr(string sStr)//地址转换
        {
            if (sStr.Length != 6)
            {
                return sStr;
            }

            string sAdd1 = sStr.Substring(0, 3);
            string sAdd2 = sStr.Substring(3, 3);
            for (int i = 0; i < sAddr.Length; i = i + 2)
            {
                if (sAddr[i] == sAdd1)
                {
                    sAdd1 = sAddr[i + 1];
                    break;
                }
            }
            for (int i = 0; i < sAddr.Length; i = i + 2)
            {
                if (sAddr[i] == sAdd2)
                {
                    sAdd2 = sAddr[i + 1];
                    break;
                }
            }
            sStr = sAdd1 +"-"+ sAdd2;
            return sStr;
        }
        private string GetTime(string sStr)//时间转换
        {
            if (sStr.Length != 4)
            {
                return sStr;
            }
            sStr = sStr.Insert(2, ":");
            return sStr;
        }
        private void BG_Proc_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            DTEnd = DateTime.Now;
            bStopProc = false;
            BTN_StartProc.Text = "开始解析";
            BTN_StartProc.Enabled = true;
            AddLog("任务完成");
            AddLog("**********任务报告**********");
           AddLog("* 保存路径:"+sFilePath + "_解析结果.txt");
            AddLog("* 开始时间:" + DTStart.ToString("hh:mm:ss"));
            AddLog("* 结束时间:" + DTEnd.ToString("hh:mm:ss"));
            AddLog("* 总数据量:" + i总数据量);
            AddLog("* 有效数据量:" + i有效数据量);
            AddLog("* 组用户信息:" + i组用户信息);
            AddLog("* 联系人错误:" + i联系人错误);
            AddLog("* 航班错误:" + i航班错误);
            AddLog("* 无号码:" + i无号码);
            AddLog("* 号码重复:" + i号码重复);
            AddLog("* 号码总数:" + ALTel.Count.ToString());
            AddLog("**********报告结束**********");
           
        }

        private void BTN_ClearLogs_Click(object sender, EventArgs e)
        {
            LB_Log.Items.Clear();
        }

        private void BTN_OpenLogs_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(sCurrentDir + "/Logs/Log_" + DateTime.Now.ToString("yy-MM-dd") + ".log");
            }
            catch
            {

            }
        }

        private void BTN_StartProc_Click(object sender, EventArgs e)
        {
            if (BG_Proc.IsBusy)
            {
                BTN_StartProc.Text = "正在终止";
                BTN_StartProc.Enabled = false;
                bStopProc = true;
                BG_Proc.CancelAsync();
            }
            else
            {
                if (sFilePath == "")
                {
                    MessageBox.Show("请先设置PNR原始数据文件路径", "无法开始解析", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AddLog("无法开始解析，请先设置PNR原始数据文件路径");
                    TB_FilePath.Focus();
                    return;
                }
                bStopProc = false;
                //iProcess = 0;
                BG_Proc.RunWorkerAsync();
                BTN_StartProc.Text = "停止解析";
            }

        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveIni();
        }

        private void BTN_OpenPath_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultPath = sFilePath.Substring(0, sFilePath.LastIndexOf("\\"));
                System.Diagnostics.Process.Start(sResultPath);
            }
            catch
            {

            }
            
        }

        private void CB_ThreadNum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CB_ThreadNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iThreadNum = Convert.ToInt32(CB_ThreadNum.Text);
            }
            catch
            {
                iThreadNum = 50;
            }
        }

        private void CB_TryNum_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iTryCount = Convert.ToInt32(CB_TryNum.Text);
            }
            catch
            {
                iTryCount = 10;
            }

        }

        private void CB_TryTime_TextChanged(object sender, EventArgs e)
        {
            try
            {
                iTryTime = Convert.ToInt32(CB_TryTime.Text.Replace("ms", ""));
            }
            catch
            {
                iTryTime = 1000;

            }
        }

        private void CB_ThreadNum_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void Btn_OpenCur_Click(object sender, EventArgs e)
        {
            try
            {
                string sResultPath = Application.StartupPath;
                System.Diagnostics.Process.Start(sResultPath);
            }
            catch
            {

            }
        }

        private void BTN_AddFile_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
            for (int i = 0; i < openFileDialog2.FileNames.Length; i++)
            {
                if (TB_FilePahtUrlList.Text != "")
                {
                    TB_FilePahtUrlList.Text += "\r\n" + openFileDialog2.FileNames[i];
                }
                else
                {
                    TB_FilePahtUrlList.Text =  openFileDialog2.FileNames[i];
                }
            }
           


        }

        private void BTN_StartScan_Click(object sender, EventArgs e)
        {
            if (BG_Scan.IsBusy)
            {
                BTN_StartScan.Text = "正在终止";
                BTN_StartScan.Enabled = false;
                bStopScan = true;
                BG_Scan.CancelAsync();
            }
            else
            {
                sFilePathUrlList=TB_FilePahtUrlList.Text.Replace("\n","").Split('\r');
                if (TB_FilePahtUrlList.Text.Trim() == "")
                {
                    MessageBox.Show("请先设置URL文件路径列表", "无法开始抓取数据", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    AddLog("无法开始抓取数据，请先设置URL文件路径列表");
                    TB_FilePahtUrlList.Focus();
                    return;
                }
                TB_FilePahtUrlList.Enabled = false;
                CB_ThreadNum.Enabled = false;
                CB_TryNum.Enabled = false;
                CB_TryTime.Enabled = false;
                BTN_AddFile.Enabled = false;
                
                bStopScan = false;
                BG_Scan.RunWorkerAsync();
                BTN_StartScan.Text = "停止抓取";
            }
        }

        private void BG_Scan_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            TB_FilePahtUrlList.Enabled = true;
            CB_ThreadNum.Enabled = true;
            CB_TryNum.Enabled = true;
            CB_TryTime.Enabled = true;
            BTN_AddFile.Enabled = true;
            BTN_StartScan.Text = "开始抓取";
            BTN_StartScan.Enabled = true;
        }

        private void BG_Scan_DoWork(object sender, DoWorkEventArgs e)
        {
            string sLine = "";
            for (int i = 0; i < sFilePathUrlList.Length; i++)
            {
                AddLog("开始读取URL文件:" + sFilePathUrlList[i]);
                StreamReader SR = new StreamReader(sFilePathUrlList[i], Encoding.Default);
                while (!SR.EndOfStream)
                {
                    if (bStopScan)
                    {
                        break; ;
                    }
                    sLine = SR.ReadLine();
                    ThreadStart starter = delegate { ThreadGetInfo(sLine, sFilePathUrlList[i]); };
                    Thread pStartProcess = new Thread(starter);
                    pStartProcess.Start();
                    lock (oLockThread)
                    {
                        iThreadNumCount++;
                    }
                   while (iThreadNumCount >= iThreadNum&&!bStopScan)
                    {
                        Thread.Sleep(10);
                    }
                }
                if (bStopScan)
                {
                    AddLog("用户终止了处理:" + sFilePathUrlList[i]);
                }
                else
                {
                    AddLog("URL文件处理完毕:" + sFilePathUrlList[i]);
                }
                SR.Close();
                SR.Dispose();
               
                
                if (bStopScan)
                {
                    break; ;
                }
            }
        }
        public void ThreadGetInfo(string sUrl, string sFilePathWrite)
        {
            string sContent = "";
            int iTryCountCur = 0;
            WebClient myWebClient = new WebClient(); //创建WebClient实例myWebClient 
            byte[] myDataBuffer;
           
          
        Restart:
            if (bStopScan)
            {
                goto EndScan;
            }

            if (iTryCountCur == 0)
            {
                AddLog("开始抓取URL地址内数据:" + sUrl);
            }
            else
            {
                AddLog("第" + iTryCountCur.ToString()+ "次抓取URL地址内数据:" + sUrl);
            }
             myDataBuffer = myWebClient.DownloadData(sUrl);
             if (bStopScan)
             {
                 goto EndScan;
             }

            sContent = Encoding.GetEncoding("gb2312").GetString(myDataBuffer);
            Match meta = Regex.Match(sContent, "<TD class=\"a\">(.+?)</TD>\\s*</TR>", RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
            if (meta != null && meta.Groups.Count > 0)
            {
                sContent = meta.Groups[1].Value.Trim();
                if (sContent != "")
                {
                    sContent = sContent.Replace("<br>", "\r\n");
                    lock (oLockWriteFile)
                    {
                        StreamWriter SW2 = new StreamWriter(sFilePathWrite + "_扫描结果.txt", true);
                        SW2.WriteLine(sContent);
                        SW2.Close();
                        SW2.Dispose();
                    }
                    AddLog("数据抓取完毕,结果长度[" + sContent.Length.ToString() + "]:" + sUrl);
                }
                else
                {
                    AddLog("数据抓取结果为空:" + sUrl);
                }
            }
            else
            {
                if (iTryCountCur < iTryCount)
                {
                    AddLog("未从[" + sUrl + "]获取到结果," + iTryTime.ToString() + "ms后重新尝试...");
                    Thread.Sleep(iTryTime);
                    iTryCountCur++;
                    goto Restart;
                }
                else
                {
                    AddLog("获取[" + sUrl + "]尝试了"+iTryCountCur.ToString()+"次仍然失败,取消任务...");
                    
                }
               
            }
            EndScan:
            myWebClient.Dispose();

            lock (oLockThread)
            {
                iThreadNumCount--;
            }
        }
       
        

    }
}
