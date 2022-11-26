using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sla
{
    public partial class frm_dificil : Form
    {
        bool allowClick = false;
        PictureBox firstGuess;
        Random rand = new Random();
        Timer clickTimer = new Timer();
        int tempo = 100, pares, tempoGasto;
        Timer timer = new Timer { Interval = 1000 };
   
        


        public frm_dificil()
        {
            InitializeComponent();
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
                    Properties.Resources.galinha,
                    Properties.Resources.tartaruga,
                    Properties.Resources.ursoPanda,
                    Properties.Resources.ursoPolar,
                    Properties.Resources.urso,
                    Properties.Resources.leao,
                    Properties.Resources.onca,
                    Properties.Resources.tigre

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
                    // mostrar um form de perder
                    MessageBox.Show("Acabou seu tempo");
                    pares = 0;
                    tempo = 0;
                    lbl_contador.Text = "00: 00";
                    lbl_acertos.Text = "0".ToString();
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
            tempo = 100;
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
                num = rand.Next(0, 32);
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
            tempoGasto = 100 - tempo;
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
                pares++;
                lbl_acertos.Text = pares.ToString() + " /16";
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
                frm_ganhar frm_Ganhar = new frm_ganhar(tempoGasto);
                frm_Ganhar.Show();
                this.Close();
                pares = 0;
                HideImages();
                ResetImages();
                foreach (PictureBox item in pictureBoxes)
                {
                    item.Enabled = false;
                }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            timer.Stop();
            if (MessageBox.Show("Deseja realmente terminar a partida?", "Saída", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                timer.Start();
            }
        }

        private void startGame(object sender, EventArgs e)
        {
            tempo = 100;
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
