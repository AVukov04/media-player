using AxWMPLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Media_player_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] paths, files;
        bool showElapsed = true;
        
        List<Track> trackCollection = new List<Track>();

        private void track_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            player.URL = paths[track_list.SelectedIndex];
            player.Ctlcontrols.play();
            lbl_msg1.Text = "Playing...";
            timer1.Start();
            trackBar1.Value = 20;
            lbl_vol2.Text = trackBar1.Value.ToString() + "%";

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.play();
            lbl_msg1.Text = "Playing...";
            
        }

        private void btn_pause_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.pause();
            lbl_msg1.Text = "Paused";
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            player.Ctlcontrols.stop();
            lbl_msg1.Text = "Stopped";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if(track_list.SelectedIndex < track_list.Items.Count - 1)
            {
                track_list.SelectedIndex = track_list.SelectedIndex + 1;
            }
            else
            {
                player.Ctlcontrols.currentPosition = 0;
                player.Ctlcontrols.play();
            }
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            if (track_list.SelectedIndex > 0)
            {
                track_list.SelectedIndex = track_list.SelectedIndex - 1;
            }
            else
            {
                player.Ctlcontrols.currentPosition = 0;
                player.Ctlcontrols.play();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)player.Ctlcontrols.currentItem.duration;
                progressBar1.Value = (int)player.Ctlcontrols.currentPosition;
            }
            if (showElapsed)
            {
                lbl_track_time.Text = player.Ctlcontrols.currentPositionString;
            }
            else
            {
                lbl_track_time.Text = player.currentMedia.durationString;
            }
        }

        private void lbl_track_time_Click(object sender, EventArgs e)
        {
            showElapsed = !showElapsed;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            player.settings.volume = trackBar1.Value;
            lbl_vol2.Text = trackBar1.Value.ToString() + "%";
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
             OpenFileDialog ofd = new OpenFileDialog();
             ofd.Multiselect = true;
             if(ofd.ShowDialog()==System.Windows.Forms.DialogResult.OK)
             {
                files = ofd.SafeFileNames;
                paths = ofd.FileNames;
                for(int i=0; i<files.Length; i++)
                {
                    track_list.Items.Add(files[i]);
                    trackCollection.Add(new Track(files[i], paths[i]));
                }
             }  
        }
    }
}
