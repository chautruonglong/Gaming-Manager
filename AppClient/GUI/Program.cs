using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    public static class Program {
        [STAThread]
        public static void Main() {
            Application.Run(new LoginForm());
        }
    }
}
