using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{


    public class UserFileReader
    {
       
        public Reader FileOpen()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Text files only(*.txt)|*.txt";
            dialog.Multiselect = false;
            Reader reader = new Reader();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                
            }
            return reader;
        }
    }
}
