using Client.ServiceReference1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            errorTextbox.Text = "";
            ServiceReference1.MathServiceClient _obj = new ServiceReference1.MathServiceClient("BasicHttpBinding_IMathService");

            try
            {
                label3.Text = _obj.Addition(textBox1.Text, textBox2.Text).ToString();
            }
            catch (ApplicationException ex)
            {
                errorTextbox.Text = "ProxyState: " + _obj.State + System.Environment.NewLine + "App Exception Type: " + ex.GetType().Name + System.Environment.NewLine + "Message: " + ex.Message;
            }
            catch (FaultException<AppFaultData> ex)
            {
                errorTextbox.Text = "ProxyState: " + _obj.State + System.Environment.NewLine + "Exception Type: " + ex.GetType().Name + System.Environment.NewLine + "Reason Code: " + ex.Reason.ToString() + System.Environment.NewLine + "Detail: " + ex.Detail.ErrorCode + System.Environment.NewLine + "Message: " + ex.Message;
            }
            catch (FaultException ex)
            {
                errorTextbox.Text = "ProxyState: " + _obj.State  + System.Environment.NewLine +  "Exception Type: " + ex.GetType().Name + System.Environment.NewLine + "Reason Code: " + ex.Code.Name + System.Environment.NewLine + "Message: " + ex.Message;
            }
            catch (Exception ex)
            {
                errorTextbox.Text = "ProxyState: " + _obj.State + System.Environment.NewLine + "Exception Type: " + ex.GetType().Name + System.Environment.NewLine + "Reason Code: " + "0" + System.Environment.NewLine + "Message: " + ex.Message;
            }
        }
    }
}
