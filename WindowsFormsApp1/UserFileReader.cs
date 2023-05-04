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
        public void FileOpen()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }
    }
}
