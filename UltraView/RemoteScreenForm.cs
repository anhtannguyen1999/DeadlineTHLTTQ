using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraView
{
    public partial class RemoteScreenForm : Form
    {
        private readonly int port;
        
        public RemoteScreenForm(int Port)
        {
            port = Port;
            MessageBox.Show("Open connect success!");
            InitializeComponent();
        }
        
        private void RemoteScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainForm.RemoteScreenFormCount--;
        }
    }
}
