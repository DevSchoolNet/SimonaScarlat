using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DependencyInjection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var clientsList = from t in Assembly.GetExecutingAssembly().GetTypes()
                            where t.GetInterfaces().Contains(typeof(IClient))
                                     && t.GetConstructor(Type.EmptyTypes) != null
                            select Activator.CreateInstance(t) as IClient;

            foreach (var client in clientsList)
            {
                sendTo_listBox.Items.Add(client.GetType().Name.ToString().Remove(0,6));
            }
        }

        public void reset()
        {
            message_textBox.Text = "";
            sendTo_listBox.SelectedItems.Clear();
        }
        private void sendMessage_button_Click(object sender, EventArgs e)
        {
            DistributorVedda distributor = new DistributorVedda();
            foreach(string selectedClient in sendTo_listBox.SelectedItems)
            {
                distributor.Client = FactoryClient.makeClientInstance(selectedClient);
                distributor.NotifyClient(message_textBox.Text);           
            }

            reset();
        }
    }
}
