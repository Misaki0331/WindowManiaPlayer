using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using WMPLib;

namespace WindowManiaPlayer
{
    public partial class Form1 : Form
    {
        const int windowcount = 300;
        notes[] notewindow;
        struct NotesObject
        {
            public int Time;
            public int Keys;
            public int Longs;

        }
        NotesObject[] notesObjects;
        WindowsMediaPlayer _mediaPlayer = new WindowsMediaPlayer();

        string SoundFile = "";
        int counts = 0;
        private void StopSound()
        {
            _mediaPlayer.controls.stop();
        }

        private void PlaySound()
        {
            _mediaPlayer.URL = SoundFullPath;// mp3も使用可能
            _mediaPlayer.controls.play();
        }
        public Form1()
        {
            InitializeComponent();
            notewindow = new notes[windowcount];
            for (int i = 0; i < windowcount; i++)
            {
                notewindow[i] = new notes();
            }
        }
        int endtime=0;

        string SoundFullPath = "";
        debug dw = new debug();
        private void playerplay_Click(object sender, EventArgs e)
        {
            var screen = System.Windows.Forms.Screen.PrimaryScreen;
            int width = screen.Bounds.Width;
            int height = screen.Bounds.Height;
            if (textBox1.Text == string.Empty) return;
            SoundFullPath = $"{Path.GetDirectoryName(textBox1.Text)}\\{SoundFile}";
            bool isdebug = IsDebugMode.Checked;
            if (isdebug)
            {
                dw.Show();
                dw.Location = new Point(10, 10);
            }
            Hide();
            Stopwatch timer = new Stopwatch();
            timer.Reset();
            timer.Start();
            int lps = 0;
            int[] tmplp = new int[50] ;
            int[] tmplpt = new int[50];
            int notecount = 0;
            int currentwindowcount = 0;
            bool started = false;
            int tempsec = 0;
            int shortsize = (int)numericUpDown2.Value;
            int notecounts = 0;
            while (timer.ElapsedMilliseconds - 3000 < endtime||currentwindowcount>0)
            {

                if(isdebug)tmplp[timer.ElapsedMilliseconds / 20 % 50]++;
                int now = (int)timer.ElapsedMilliseconds - 3000;
                if (!started && now > numericUpDown1.Value)
                {
                    PlaySound();
                    started = true;
                }
                Application.DoEvents();
                try
                {
                    if (notecount < notesObjects.Length) while (notesObjects[notecount].Time - now < height/2)
                        {
                            for (int i = 0; i < windowcount; i++)
                            {
                                if (notewindow[i].NoteNumber == -1)
                                {
                                    notewindow[i].Show();
                                    notewindow[i].NoteNumber = notecount;
                                    notewindow[i].Location = new Point((width-512)/2 + notesObjects[notecount].Keys *2-75, -10000);
                                    currentwindowcount++;
                                    if (notesObjects[notecount].Longs == 0)
                                    {
                                    }
                                    else
                                    {
                                        notewindow[i].Size = new Size(150, notesObjects[notecount].Longs * 2 + shortsize);
                                    }
                                    break;
                                }
                                if (i == windowcount - 1) notecounts++;
                            }
                            notecount++;
                        }
                }
                catch
                {

                }
                for (int i = 0; i < windowcount; i++)
                {
                    if (notewindow[i].NoteNumber != -1)
                    {
                        if (notesObjects[notewindow[i].NoteNumber].Longs == 0)
                        {
                            if (notesObjects[notewindow[i].NoteNumber].Time - now < 0)
                            {
                                notewindow[i].NoteNumber = -1;
                                notewindow[i].Hide();
                                notecounts++;
                                currentwindowcount--;
                            }
                            else
                            {
                                notewindow[i].Location = new Point((width - 512*2) / 2 + notesObjects[notewindow[i].NoteNumber].Keys * 2 - 75, height - (notesObjects[notewindow[i].NoteNumber].Time - now) * 2 - shortsize);
                            }
                        }
                        else
                        {
                            if (notesObjects[notewindow[i].NoteNumber].Time + notesObjects[notewindow[i].NoteNumber].Longs - now < 0)
                            {
                                notewindow[i].NoteNumber = -1;
                                notewindow[i].Size = new Size(150, shortsize);
                                notewindow[i].Hide();
                                notecounts++;
                                currentwindowcount--;
                            }
                            else
                            {
                                if (notesObjects[notewindow[i].NoteNumber].Longs >= (height- shortsize) /2)
                                {
                                    if (now >= notesObjects[notewindow[i].NoteNumber].Time && now < notesObjects[notewindow[i].NoteNumber].Time + notesObjects[notewindow[i].NoteNumber].Longs - (height - shortsize) / 2)
                                    {
                                        notewindow[i].Location = new Point((width - 512*2) / 2 + notesObjects[notewindow[i].NoteNumber].Keys * 2 - 75, 0);
                                    }
                                    else
                                    {
                                        if (now > notesObjects[notewindow[i].NoteNumber].Time)
                                        {
                                            notewindow[i].Location = new Point((width - 512*2) / 2 + notesObjects[notewindow[i].NoteNumber].Keys * 2 - 75, height - (notesObjects[notewindow[i].NoteNumber].Time + notesObjects[notewindow[i].NoteNumber].Longs - now) * 2 - shortsize);
                                        }
                                        else
                                        {
                                            notewindow[i].Location = new Point((width - 512*2) / 2 + notesObjects[notewindow[i].NoteNumber].Keys * 2 - 75, height- (notesObjects[notewindow[i].NoteNumber].Time + (height - shortsize) / 2 - now) * 2 - 50);
                                        }
                                    }

                                }
                                else
                                {
                                    notewindow[i].Location = new Point((width - 512*2) / 2 + notesObjects[notewindow[i].NoteNumber].Keys * 2 - 75, height - (notesObjects[notewindow[i].NoteNumber].Time + notesObjects[notewindow[i].NoteNumber].Longs - now) * 2 - shortsize);
                                }

                            }
                        }
                    }
                }
                if (isdebug)
                {
                    lps = 0;
                    for (int i = 0; i < 50; i++)
                    {
                        if (tmplpt[i] != (timer.ElapsedMilliseconds - i * 20) / 1000)
                        {
                            tmplp[i] = 0;
                            tmplpt[i] = (int)(timer.ElapsedMilliseconds - i * 20) / 1000;
                        }
                        else
                        {
                            lps += tmplp[i];
                        }
                    }
                    dw.displaytext.Text = $"Window : {currentwindowcount}\nFPS : {lps}\nUpdate : {timer.ElapsedMilliseconds-tempsec}\n{now / 1000 / 60}:{(now / 1000 % 60).ToString().PadLeft(2, '0')}/{endtime/1000/60}:{(endtime/1000%60).ToString().PadLeft(2,'0')}\n{notecounts}/{notesObjects.Length}";
                    tempsec = (int)timer.ElapsedMilliseconds;
                }
                
            }
            Show();
            if (IsDebugMode.Checked)
            {
                dw.Hide();
            }
        }
        private void beatmap_Click(object sender, EventArgs e)
        {
            filedialog.Filter = "譜面ファイル (*.osu)|*.osu";
            filedialog.ShowDialog();
           
        }

        private void link_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Misaki0331");
        }

        private void link_twitter_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://twitter.com/0x7FF");

        }

        private void link_repository_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Misaki0331/WindowManiaPlayer");
        }

        private void filedialog_FileOk(object sender, CancelEventArgs e)
        {
            textBox1.Text = filedialog.FileName;
            endtime = 0;
            StreamReader sr = new StreamReader(
                textBox1.Text, Encoding.UTF8);

            string text = sr.ReadToEnd();

            sr.Close();
            string[] strs = text.Split('\n');
            int hitobjectstart = 0;

            for (int i = 0; i < strs.Length; i++)
            {

                if (strs[i].Contains("[HitObjects]"))
                {
                    hitobjectstart = i + 1;
                    break;

                }
                if (strs[i].StartsWith("AudioFilename"))
                {
                    SoundFile = strs[i];
                    while (!SoundFile.StartsWith(":"))
                    {
                        SoundFile = SoundFile.Remove(0, 1);
                    }
                    SoundFile = SoundFile.Remove(0, 1);
                    SoundFile = SoundFile.TrimStart();
                    SoundFile = SoundFile.TrimEnd();
                }
            }
            if (hitobjectstart == 0) throw new ArgumentException(paramName: nameof(hitobjectstart),
                message: "ファイル内に\"[HitObjects]\"が存在しませんでした。");
            notesObjects = new NotesObject[strs.Length - hitobjectstart + 1];
            for (int count = 0; count + hitobjectstart < strs.Length; count++)
            {
                string[] lens = strs[count + hitobjectstart].Split(',');
                string[] detaillens;
                try
                {
                    detaillens = lens[5].Split(':');
                }
                catch
                {
                    continue;
                }
                notesObjects[count].Keys = int.Parse(lens[0]);

                notesObjects[count].Time = int.Parse(lens[2]);
                if (int.Parse(lens[3]) == 128) notesObjects[count].Longs = int.Parse(detaillens[0]) - notesObjects[count].Time;
                if (endtime < notesObjects[count].Time + notesObjects[count].Longs) endtime = notesObjects[count].Time + notesObjects[count].Longs;
                counts = count;
            }
        }
    }
}
