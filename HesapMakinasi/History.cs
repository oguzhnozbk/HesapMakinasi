using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HesapMakinasi
{
    public partial class History : Form
    {
        static string _path = @"D:\History.txt";
        FileOperations file = new FileOperations(_path);
        public History()
        {
            InitializeComponent();
            try
            {
                HistoryTextBox.Text = file.ReadHistoryFile();
            }
            catch
            {

            }
        }

        private void btnHistoryDelete_Click(object sender, EventArgs e)
        {
            try
            {
                file.DeleteHistory();
                HistoryTextBox.Text = file.ReadHistoryFile();
            }
            catch
            {

            }
        }
    }
}
