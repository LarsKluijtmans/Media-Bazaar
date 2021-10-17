using Sydesoft.NfcDevice;
using System;
using System.Windows.Forms;

namespace acr122_demo
{
    public partial class Form1 : Form
    {
        string last = "";
        DateTime date;
        private static MyACR122U acr122u = new MyACR122U();
        Atendance at;
        public Form1()
        {
            InitializeComponent();
            acr122u.Init(false, 50, 4, 4, 200);  // NTAG213
            acr122u.CardInserted += Acr122u_CardInserted;
            acr122u.CardRemoved += Acr122u_CardRemoved;
            at = new Atendance();
            GetAtendance();
        }

        public void GetAtendance()
        { 
            listBox1.Items.Clear();
            at.getAllAtendance();
            foreach (Ckecks k in at.check)
            {
                listBox1.Items.Add(k);
            }
        }

        private void Acr122u_CardInserted(PCSC.ICardReader reader)
        {
            acr122u.ReadId = BitConverter.ToString(acr122u.GetUID(reader)).Replace("-", "");
        }

        private static void Acr122u_CardRemoved()
        { }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if ((acr122u.ReadId != null && last != acr122u.ReadId) || (acr122u.ReadId != null && date.AddSeconds(5) < DateTime.Now))
            {

                if (at.GetEmployeeID(acr122u.ReadId.ToString()) == 0)
                {
                    last = acr122u.ReadId;
                    date = DateTime.Now;
                    acr122u.ReadId = null;
                    return;
                }
                else if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == false)
                {
                    at.AddCheckIn(at.GetEmployeeID(acr122u.ReadId.ToString()));
                    last = acr122u.ReadId;
                    date = DateTime.Now;
                    acr122u.ReadId = null;
                    GetAtendance();
                    return;
                }


                else if (at.IsAlreadyCheckedIn(at.GetEmployeeID(acr122u.ReadId.ToString())) == true)
                {
                    at.EditCheckOutTime(at.GetEmployeeID(acr122u.ReadId.ToString()));
                    last = acr122u.ReadId;
                    date = DateTime.Now;
                    acr122u.ReadId = null;
                    GetAtendance();
                    return;
                }
                
            }
            acr122u.ReadId = null;
        }
    }

    internal class MyACR122U : ACR122U
    {
        private string readId;
        public string ReadId
        {
            get { return readId; }
            set { readId = value; }
        }
        public MyACR122U()
        { }
    }
}
