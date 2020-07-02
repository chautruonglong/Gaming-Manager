using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI.Properties;

namespace GUI {
    public partial class GameForm : UserControl {
        public GameForm() {
            InitializeComponent();
            LoadGames();
        }

        private void LoadGames() {
            ComponentResourceManager resource = new ComponentResourceManager(typeof(ResourceImage));
            List<GameLabel> games = new List<GameLabel>();

            games.AddRange(new GameLabel[] {
                new GameLabel() {
                    Text = "Liên minh huyền thoại",
                    Image = (Image)resource.GetObject("lol.Image"),
                    Directory = "start C:\\\"Program Files (x86)\"\\Garena\\Games\\32787\\LeagueClient\\LeagueClient.exe"
                },

                new GameLabel() {
                    Text = "Garena",
                    Image = (Image)resource.GetObject("garena.Image"),
                    Directory = "start C:\\\"Program Files (x86)\"\\Garena\\Garena\\Garena.exe"
                },

                new GameLabel() {
                    Text = "Chrome",
                    Image = (Image)resource.GetObject("chrome.Image"),
                    Directory = "start C:\\\"Program Files (x86)\"\\Google\\Chrome\\Application\\chrome.exe"
                },

                new GameLabel() {
                    Text = "Edge",
                    Image = (Image)resource.GetObject("edge.Image"),
                    Directory = "start C:\\\"Program Files (x86)\"\\Microsoft\\Edge\\Application\\msedge.exe"
                },

                new GameLabel() {
                    Text = "Facebook",
                    Image = (Image)resource.GetObject("facebook.Image"),
                    Directory = "start D:\\University\\Nam-2\\Ky-2\\Do-an-cong-nghe-phan-mem\\GamingManager\\AppClient\\Shortcuts\\facebook.url"
                },

                new GameLabel() {
                    Text = "Youtube",
                    Image = (Image)resource.GetObject("youtube.Image"),
                    Directory = "start D:\\University\\Nam-2\\Ky-2\\Do-an-cong-nghe-phan-mem\\GamingManager\\AppClient\\Shortcuts\\youtube.url"
                },

                new GameLabel() {
                    Text = "PlayerUnknown's Battlegrounds",
                    Image = (Image)resource.GetObject("pubg.Image"),
                    Directory = null
                },

                new GameLabel() {
                    Text = "Dota 2",
                    Image = (Image)resource.GetObject("dota.Image"),
                    Directory = null
                },

                new GameLabel() {
                    Text = "Super Mario",
                    Image = (Image)resource.GetObject("mario.Image"),
                    Directory = null
                },

                new GameLabel() {
                    Text = "Rubik",
                    Image = (Image)resource.GetObject("rubik.Image"),
                    Directory = null
                },

                new GameLabel() {
                    Text = "Rockstar's games",
                    Image = (Image)resource.GetObject("rockstar.Image"),
                    Directory = null
                },

                new GameLabel() {
                    Text = "Word",
                    Image = (Image)resource.GetObject("word.Image"),
                    Directory = "start C:\\\"Program Files\"\\\"Microsoft Office\"\\root\\Office16\\WINWORD.EXE"
                },

                new GameLabel() {
                    Text = "Excel",
                    Image = (Image)resource.GetObject("excel.Image"),
                    Directory = "start C:\\\"Program Files\"\\\"Microsoft Office\"\\root\\Office16\\EXCEL.EXE"
                },

                new GameLabel() {
                    Text = "Power Point",
                    Image = (Image)resource.GetObject("pp.Image"),
                    Directory = "start C:\\\"Program Files\"\\\"Microsoft Office\"\\root\\Office16\\POWERPNT.EXE"
                }
            });

            int hgap = 60, vgap = 50;
            int row = 0, col = 0;
            foreach(GameLabel game in games) {
                game.Location = new Point(hgap + col * game.Width, vgap + row * game.Height);
                ++col;
                hgap += 60;
                if((games.IndexOf(game) + 1) % 5 == 0) {
                    col = 0;
                    ++row;
                    hgap = 60;
                    vgap += 50;
                }
                this.Controls.Add(game);
            }
        }
    }
}
