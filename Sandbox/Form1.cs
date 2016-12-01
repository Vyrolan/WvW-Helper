﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GW2NET.MumbleLink;
using GW2NET;
using GW2NET.Maps;

namespace Sandbox
{
    public partial class Form1 : Form, MapLinks.ITeamMapGetter
    {
        System.Speech.Synthesis.SpeechSynthesizer synth;
        IniFile ini;
        MapLinks links;
        MumbleLinkFile mumble;
        Dictionary<int, string> teamColorDict = new Dictionary<int, string>()
        { { 9, "Blue" }, { 55, "Green" } };
        Dictionary<int, string> mapDict = new Dictionary<int, string>()
        { { 95, "Green" }, { 96, "Blue" }, { 1099, "Red" }, { 38, "EBG" } };

        private string iniRead(string key, string defaultValue = "")
        {
            if (ini.KeyExists(key, "GW2"))
                return ini.Read(key, "GW2");
            return defaultValue;
        }

        public Form1()
        {
            InitializeComponent();
            synth = new System.Speech.Synthesis.SpeechSynthesizer();
            synth.SetOutputToDefaultAudioDevice();
            ini = new IniFile("C:\\rday\\rday.ini");
            links = new MapLinks(this);
            mumble = MumbleLinkFile.CreateOrOpen();

            label1.Text = iniRead("mode", "0");
            mapLabel.Text = iniRead("map");
            teamLabel.Text = iniRead("team");

            pinTextBox.Text = iniRead("SquadPin");
            squadMapTextBox.Text = iniRead("SquadMap");
            squadMessageBox.Text = iniRead("SquadMsg");

            mumbleTimer.Start();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            var mode = ini.Read("mode", "0");
            label1.Text = mode;
            label1.Refresh();

            if (e.KeyChar.Equals('s'))
                synth.Speak(speechBox.Text);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void speakButton_Click(object sender, EventArgs e)
        {
            synth.Speak(speechBox.Text);
        }

        private void mapButtonClick(object sender, EventArgs e)
        {
            setMap(((Button)sender).Text);
        }

        private void setMap(string map)
        {
            mumbleTimer.Stop();
            mumble.Dispose();
            mumble = MumbleLinkFile.CreateOrOpen();
            mumbleTimer.Start();

            mapLabel.Text = map;
            mapLabel.Refresh();
            refreshLinks();
        }
        private void refreshLinks()
        {
            ini.Write("map", mapLabel.Text, "GW2");
            ini.Write("team", teamLabel.Text, "GW2");
            ini.Write("CurrentMapKeep", links.GetCurrentKeep(), "GW2");
            ini.Write("CurrentMapSpawn", links.GetSpawn(), "GW2");
            ini.Write("LeftSpawn", links.GetLeftSpawn(), "GW2");
            ini.Write("RightSpawn", links.GetRightSpawn(), "GW2");
            ini.Write("HomeSpawn", links.GetSpawn(Team), "GW2");
            ini.Write("Garrison", links.GetGarrison(), "GW2");
            ini.Write("EBGSpawn", links.Get(Team, "EBG"), "GW2");
            ini.Write("EBGKeep", links.Get(Team+"Keep", "EBG"), "GW2");
        }

        public string Team
        {
            get { return teamLabel.Text; }
        }

        public string Map
        {
            get { return mapLabel.Text; }
        }

        private void mumbleTimer_Tick(object sender, EventArgs e)
        {
            var a = mumble.Read();
            mapNameLabel.Text = a.Context.MapId.ToString();
            teamColorLabel.Text = a.Identity.TeamColorId.ToString();
            string map;
            if (mapDict.TryGetValue(a.Context.MapId, out map))
            {
                if (!map.Equals(mapLabel.Text))
                {
                    setMap(map);
                }
            }
            string teamColor;
            if (teamColorDict.TryGetValue(a.Identity.TeamColorId, out teamColor))
            {
                if (!teamLabel.Text.Equals(teamColor))
                {
                    teamLabel.Text = teamColor;
                    refreshLinks();
                }

            }
        }

        private void updateSquad()
        {
            var pin = pinTextBox.Text;
            var map = squadMapTextBox.Text;
            var msg = squadMessageBox.Text;
            var message = String.Format("{0} Follow {1} on {2} and JOIN DISCORD...discord.jadequarry.com", msg, pin, map);
            ini.Write("SquadAnnounce", message, "GW2");
            ini.Write("SquadPin", pin, "GW2");
            ini.Write("SquadMap", map, "GW2");
            ini.Write("SquadMsg", msg, "GW2");
        }

        private void squadUpdateButton_Click(object sender, EventArgs e)
        {
            updateSquad();
        }
    }
}