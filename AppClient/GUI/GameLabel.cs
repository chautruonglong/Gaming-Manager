using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI {
    class GameLabel : Label {
        public string Directory { get; set; }

        public GameLabel() {
            this.Size = new Size(100, 100);
            this.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            this.TextAlign = ContentAlignment.BottomCenter;
            this.ImageAlign = ContentAlignment.TopCenter;
            this.MouseDown += GameLabel_MouseDown;
            this.MouseEnter += GameLabel_MouseEnter;
            this.MouseLeave += GameLabel_MouseLeave;
        }

        private void GameLabel_MouseDown(object sender, MouseEventArgs e) {
            if(e.Button == MouseButtons.Left) {
                System.Diagnostics.Process.Start("Cmd.exe", "/C" + this.Directory);
            }
        }

        private void GameLabel_MouseEnter(object sender, EventArgs e) {
            this.BackColor = Color.LightGray;
        }

        private void GameLabel_MouseLeave(object sender, EventArgs e) {
            this.BackColor = Color.FromName("Control");
        }
    }
}
