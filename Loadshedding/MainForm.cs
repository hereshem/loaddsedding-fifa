using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;

namespace Loadshedding
{
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        Maindisplay frmMaindisplay = new Maindisplay();
        Settings frmSettings = new Settings();
        Plan frmPlan = new Plan();
        FullView frmFullView = new FullView();

        List<Group> listGroup = new List<Group>();
        // Deserialize a JSON stream to a Schedule object.
        public static Group ReadToObject(string json)
        {
            Group deserializedSchedule = new Group();
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(json));
            DataContractJsonSerializer sch = new DataContractJsonSerializer(typeof(Group));
            deserializedSchedule = (Group)sch.ReadObject(ms);
            ms.Close();
            return deserializedSchedule;
        }

        [DataContract]
        public class Group
        {
            [DataMember]
            public HourSchedule[] day { get; set; }

            public Group()
            {
                day = new HourSchedule[7];
            }

            //[DataMember]
            //public HourSchedule day1 { get; set; }
            //[DataMember]
            //public HourSchedule day2 { get; set; }
            //[DataMember]
            //public HourSchedule day3 { get; set; }
            //[DataMember]
            //public HourSchedule day4 { get; set; }
            //[DataMember]
            //public HourSchedule day5 { get; set; }
            //[DataMember]
            //public HourSchedule day6 { get; set; }
        }

        [DataContract]
        public class HourSchedule
        {
            [DataMember]
            public string[] hours { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            frmMaindisplay.MdiParent = this;
            frmSettings.MdiParent = this;
            frmPlan.MdiParent = this;
            frmFullView.MdiParent = this;



            StreamReader jsonReader = new StreamReader("nls.json");
            string jsonData = jsonReader.ReadToEnd();
            Group group1 = ReadToObject(jsonData);

            listGroup = makeListGroup(group1);

            pbxMain_Click(sender, e);


        }


        private string GetRemainingTime(DateTime dt, int group)
        {
            string effective = "";
            string[] hrs = listGroup[group].day[(int)dt.DayOfWeek].hours;
            //DateTime dd = new DateTime(dt.ye);
            string date = dt.Year + "/" + dt.Month + "/" + dt.Day;

            TimeSpan tt;
            bool isOnline = false;
            for (int i = 0; i < 4; i++)
            {
                tt = TimeSpan.Parse(hrs[i]);
                DateTime timex = new DateTime(dt.Year, dt.Month, dt.Day, tt.Hours, tt.Minutes, tt.Seconds);
                if (timex > dt)
                {


                    isOnline = (i % 2 == 0) ? true : false;
                    if (isOnline)
                        effective += "Status: On";
                    else
                        effective += "Status: Off";
                    effective += "\n" + (timex - dt).Hours + " hrs " + (timex - dt).Minutes + " mins\nremaining";
                    break;
                }

            }
            return effective;
        }

        private List<Group> makeListGroup(Group group1)
        {
            List<Group> g = new List<Group>();
            for (int i = 0; i < 7; i++)
            {
                Group gg = new Group();

                for (int j = 0; j < 7; j++)
                {
                    gg.day[j] = group1.day[(i + j) % 7];
                }
                g.Add(gg);
            }
            return g;


        }

        private void pbxSettings_Click(object sender, EventArgs e)
        {
            frmSettings.Location = new Point(0, 0);
            hideAll();
            frmSettings.Show();
        }

        private void pbxMain_Click(object sender, EventArgs e)
        {
            frmMaindisplay.Location = new Point(0, 0);
            hideAll();
            frmMaindisplay.Show();

            DateTime dt = DateTime.Now;
            int dayThis = (int)dt.DayOfWeek;
            int grp = Properties.Settings.Default.group;


            string ss = listGroup[grp].day[dayThis].hours[0] + "-" + listGroup[grp].day[dayThis].hours[1] + "\n" + listGroup[grp].day[dayThis].hours[2] + "-" + listGroup[grp].day[dayThis].hours[3];
            frmMaindisplay.label1.Text = ss;
            ss = GetRemainingTime(DateTime.Now, grp);
            frmMaindisplay.label2.Text = ss;
            frmMaindisplay.label3.Text = "Group: " + (grp + 1);
            //Form1_Load(sender, e);
        }

        private void pbxPlan_Click(object sender, EventArgs e)
        {
            frmPlan.Location = new Point(0, 0);
            hideAll();
            frmPlan.Show();
        }

        private void pbxFull_Click(object sender, EventArgs e)
        {
            frmFullView.Location = new Point(0, 0);
            hideAll();
            frmFullView.Show();
        }

        private void hideAll()
        {
            frmSettings.Hide();
            frmMaindisplay.Hide();
            frmFullView.Hide();
            frmPlan.Hide();


        }
    }
}
