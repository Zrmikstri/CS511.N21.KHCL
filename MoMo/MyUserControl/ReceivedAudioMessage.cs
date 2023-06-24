using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Devices;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoMo.MyUserControl
{
    public partial class ReceivedAudioMessage : UserControl, IMessage
    {
        private DateTime date;
        private bool isPlaying = false;
        private byte[] _audio = null!;

        private WaveOutEvent waveOutEvent = null!;

        public ReceivedAudioMessage()
        {
            InitializeComponent();
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
            set
            {
                date = value;
                label1.Text = date.ToString("HH:mm");
            }
        }

        public byte[] ReceivedAudio
        {
            get
            {
                return _audio;
            }
            set
            {
                _audio = value;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            // Start playing the audio using NAudio
            if (isPlaying)
            {
                isPlaying = false;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;

                if (waveOutEvent != null)
                    waveOutEvent.Stop();

            }
            else
            {
                isPlaying = true;
                iconButton1.IconChar = FontAwesome.Sharp.IconChar.Pause;

                WaveFileReader reader = new WaveFileReader(new MemoryStream(_audio));

                waveOutEvent = new WaveOutEvent();
                waveOutEvent.Init(reader);
                waveOutEvent.PlaybackStopped += (s, a) =>
                {
                    isPlaying = false;
                    iconButton1.IconChar = FontAwesome.Sharp.IconChar.Play;

                    waveOutEvent.Dispose();
                    waveOutEvent = null!;
                };

                waveOutEvent.Play();
            }
        }
    }
}

