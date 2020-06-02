using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using AudioSwitcher.AudioApi.CoreAudio;

namespace Tablet_Media_Control
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        CoreAudioDevice defaultPlaybackDevice = new CoreAudioController().DefaultPlaybackDevice;


        bool isPlaying = true;
        bool isMute;
        double currentVolume = 0;
        double sliderVolume = 0;

 

        public Form1()
        {

            InitializeComponent();
            metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            metroStyleManager1.Owner = this;

            currentVolume = defaultPlaybackDevice.Volume;

            lblVolume.Text = currentVolume.ToString();
            volumeSlider.Value = Convert.ToInt32(currentVolume);


            picPlay.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("play-circle-regular1");

            defaultPlaybackDevice.Mute(false);
            isMute = false;



        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        [DllImport("user32.dll")]
        internal static extern void keybd_event(VirtualKeyCode bVk, byte bScan, uint dwFlags, int dwExtraInfo);

        [DllImport("user32.dll")]
        internal static extern uint MapVirtualKey(uint uCode, MapVirtualKeyType uMapType);

        // https://docs.microsoft.com/en-gb/windows/desktop/inputdev/virtual-key-codes

        internal enum VirtualKeyCode : byte
        {
            VK_MEDIA_PLAY_PAUSE = 0xB3,
            VK_MEDIA_NEXT_TRACK = 0xB0,
            VK_MEDIA_PREV_TRACK = 0xB1,
            VK_VOLUME_MUTE = 0xAD

    }

        const uint KEYEVENTF_EXTENDEDKEY = 1;
        const uint KEYEVENTF_KEYUP = 2;

        internal enum MapVirtualKeyType : uint
        {
            MAPVK_VK_TO_VSC = 0,
            MAPVK_VSC_TO_VK = 1,
            MAPVK_VK_TO_CHAR = 2,
            MAPVK_VSC_TO_VK_EX = 3,
            MAPVK_VK_TO_VSC_EX = 4
        }

        public void PlayPause()
        {
            uint scanCode = 0x22;
            // uint scanCode = MapVirtualKey((uint)VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, MapVirtualKeyType.MAPVK_VK_TO_VSC);

            keybd_event(VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | 0, 0);
            // Thread.Sleep ?
            keybd_event(VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public void Next()
        {
            uint scanCode = 0x22;
            // uint scanCode = MapVirtualKey((uint)VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, MapVirtualKeyType.MAPVK_VK_TO_VSC);

            keybd_event(VirtualKeyCode.VK_MEDIA_NEXT_TRACK, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | 0, 0);
            // Thread.Sleep ?
            //keybd_event(VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        public void Previous()
        {
            uint scanCode = 0x22;
            // uint scanCode = MapVirtualKey((uint)VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, MapVirtualKeyType.MAPVK_VK_TO_VSC);

            keybd_event(VirtualKeyCode.VK_MEDIA_PREV_TRACK, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | 0, 0);
            // Thread.Sleep ?
            //keybd_event(VirtualKeyCode.VK_MEDIA_PLAY_PAUSE, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | KEYEVENTF_KEYUP, 0);
        }

        private void picPlay_Click(object sender, EventArgs e)
        {

            PlayPause();
            //"Current Volume:" + defaultPlaybackDevice.Volume);
        }

        private void picNext_Click(object sender, EventArgs e)
        {
            Next();
        }

        private void picPrev_Click(object sender, EventArgs e)
        {
            Previous();
        }

        private void picPlay_MouseDown(object sender, MouseEventArgs e)
        {
            if (isPlaying)
            {
                picPlay.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("pause-circle-regular1");
                picPlay.Refresh();
                isPlaying = false;
            }
            else if (!isPlaying)
            {
                picPlay.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("play-circle-regular1");
                picPlay.Refresh();
                isPlaying = true;
            }


        }

        private void volumeSlider_ValueChanged(object sender, EventArgs e)
        {
            //defaultPlaybackDevice.Volume = 80;
           

            sliderVolume = volumeSlider.Value;
            defaultPlaybackDevice.Volume = sliderVolume;
            lblVolume.Text = sliderVolume.ToString();

        }

        private void lblVolume_Click(object sender, EventArgs e)
        {

        }

        private void picMute_MouseDown(object sender, MouseEventArgs e)
        {
            if (isMute)
            {
                picMute.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("volume-mute");
                picMute.Refresh();
                isMute = false;
            }
            else if (!isMute)
            {
                picMute.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("volume-mute-solid");
                picMute.Refresh();
                isMute = true;
            }
        }
        private void Mute()
        {
            uint scanCode = 0x22;
            keybd_event(VirtualKeyCode.VK_VOLUME_MUTE, (byte)scanCode, KEYEVENTF_EXTENDEDKEY | 0, 0);
           

        }

        public void picMute_Click(object sender, EventArgs e)
        {
            if (!isMute)
            {
                Mute();
                picMute.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("volume-mute-solid");
                lblVolume.Enabled = false;
                volumeSlider.Enabled = false;
                isMute = true;
            }
            else
            {
                Mute();
                picMute.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("volume-mute");
                lblVolume.Enabled = true;
                volumeSlider.Enabled = true;
                isMute = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
