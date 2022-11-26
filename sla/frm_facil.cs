using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class frm_facil : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rand = new Random();
        Timer clickTimer = new Timer();
        int tempo = 60, pares;
        Timer timer = new Timer { Interval = 1000 };

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
           (
               int left,
               int top,
               int right,
               int bottom,
               int width,
               int height
           );

        public frm_facil()
        {
            InitializeComponent();
        }

        private void Frm_facil_Load(object sender, EventArgs e)
        {
            btn_start.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_start.Width, btn_start.Height, 30, 30));
        }
        private PictureBox[] pictureBoxes
        {
            get { return Controls.OfType<PictureBox>().ToArray(); }
        }
        private static IEnumerable<Image> images
        {
            get
            {
                return new Image[]
                {
                    Properties.Resources.coelho,
                    Properties.Resources.giraffa,
                    Properties.Resources.gorila,
                    Properties.Resources.elefante,
                    Properties.Resources.gog,
                    Properties.Resources.gato,
                    Properties.Resources.zebra,
                    Properties.Resources.crocodilo,
                };
            }
        }
        private void startGameTimer()
        {
            timer.Start();
            timer.Tick += delegate
            {
                tempo--;
                if (tempo < 0)
                {
                    timer.Stop();
                    MessageBox.Show("Acabou seu tempo");
                    pares = 0;
                    lbl_contador.Text = "0".ToString();
                    ResetImages();
                    foreach (PictureBox item in pictureBoxes)
                    {
                        item.Enabled = false;
                    }
                }

                var ssTime = TimeSpan.FromSeconds(tempo);
                lbl_contador.Text = "00: " + tempo.ToString();
            };
        }
        private void ResetImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Tag = null;
                pic.Visible = true;
            }

            HideImages();
            tempo = 60;
            btn_start.Enabled = true;
        }
        private void HideImages()
        {
            foreach (var pic in pictureBoxes)
            {
                pic.Image = Properties.Resources.question;
            }
        }
        private PictureBox getFreeSlot()
        {
            int num;

            do
            {
                num = rand.Next(0, 16);
            }
            while (pictureBoxes[num].Tag != null);

            return pictureBoxes[num];
        }
        private void setRandomImages()
        {
            foreach (var image in images)
            {
                getFreeSlot().Tag = image;
                getFreeSlot().Tag = image;
            }
        }
        private void CLICKTIMER_TICK(object sender, EventArgs e)
        {
            HideImages();
            allowClick = true;
            clickTimer.Stop();
        }
        private void clickImage(object sender, EventArgs e)
        {
            if (!allowClick) return;

            var pic = (PictureBox)sender;
            if (firstGuess == null)
            {
                firstGuess = pic;
                pic.Image = (Image)pic.Tag;
                return;

            }

            pic.Image = (Image)pic.Tag;

            if (pic.Image == firstGuess.Image && pic != firstGuess)
            {
                pic.Visible = firstGuess.Visible = false;
                {
                    firstGuess = pic;
                }
                //HideImages();
                pares++;
                lbl_acertos.Text = pares.ToString() + " /8";
            }
            else
            {
                allowClick = false;
                clickTimer.Start();
            }

            firstGuess = null;
            if (pictureBoxes.Any(p => p.Visible)) return;
            pares = 0;
            timer.Stop();
            MessageBox.Show("Você ganhou!");
            tempo = 0;
            pares = 0;
            HideImages();
            ResetImages();
            foreach (PictureBox item in pictureBoxes)
            {
                item.Enabled = false;
            }
        }
        private void startGame(object sender, EventArgs e)
        {
            allowClick = true;
            setRandomImages();
            HideImages();
            startGameTimer();
            clickTimer.Interval = 1000;
            clickTimer.Tick += CLICKTIMER_TICK;
            btn_start.Enabled = false;

            foreach (PictureBox item in pictureBoxes)
            {
                item.Enabled = true;
            }
        }

    }
}
