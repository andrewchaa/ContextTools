using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CopyFullPath
{
    public class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            string fullPath = args[0];
            System.Windows.Forms.Clipboard.SetText(fullPath);
        }
    }
}
