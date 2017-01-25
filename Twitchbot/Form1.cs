using System;
using System.Globalization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib;
using TwitchLib.Models.API;
using TwitchLib.Models.Client;
using TwitchLib.Events.Client;
using TwitchLib.Exceptions.API;
using TwitchLib.Events.PubSub;
using TwitchLib.Events.Services.FollowerService;
using TwitchLib.Events.Services.MessageThrottler;
using TwitchLib.Enums;
using TwitchLib.Extensions.Client;
//Custom Files I made
//using Twitchbot.Properties.Settings;

//get rid of the Dup msg
//TODO:
//Add Sound Board/Current Song
//Add Time Out/Ban Commands
//Add Rules for chat 
//Hard Code rules 
//Blacklisted Words/Phrases
//Excess Caps
//Excess Emotes
//Links
//Excess Symbols
//Repetitions
//Add Hard Command
//!commands - !commercial - !filters - !game - !poll - !regulars - ~!songs - !title - !winner
//Add Custom Commands
//Add Timmers - Random Games -
//Add Events - ~New Donations - New Subscribers - Repeat Subscribers - Follows - Hosts - Bits? - 
//~Check and see what game is currently beening played 
//~Add Twitter Posts ~Add Google+ Posts
//~Add Discord

namespace Twitchbot
{
    public partial class Form1 : Form
    {
        public TwitchClient client = new TwitchClient(new ConnectionCredentials(Properties.Settings.Default.username, Properties.Settings.Default.oauth));

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Strings/Vars Defined with defaults here
            //Add any Need Events on Form Load AKA when program loads up
            client.OnUserJoined += new EventHandler<OnUserJoinedArgs>(newUser);
            txtChatroom.Text = "GLDarkKnight";
            richUserList.AppendText("Connected Users: \n");
            label3.Text = "00:00:00"; //Uptime Defult setting
            label6.Text = Properties.Settings.Default.username;
            OAuth_Key.Text = Properties.Settings.Default.oauth;
        }

        private void button1_Click(object sender, EventArgs e)
        {
			//Check to see if timmed out or Not connected

            if (client.IsConnected)
            {
                //define datetime
                //When message sent via Program
                //var Bot_User = Properties.Settings.Default.username.ToUpper(new CultureInfo("en-US", false));
				richChat.Text += DateTime.Now.ToString("h:mm")+"-"+ Properties.Settings.Default.username + " : " + txtChatBox.Text + "\n";
                richChat.ScrollToCaret();
                client.SendMessage(txtChatBox.Text);
                txtChatBox.Text = "";
            }
			else
			{
                //Also check to see if Button pushed
                //No message sent Disconnect
                richChat.AppendText("<< Disconnected from chat >>\n");
                richUserList.Text = "";
                richChat.ScrollToCaret();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            //Onevent Call Commands

            //ToDo on Load/UserList Pop
            //Get Mods by OnModeratorsReceived
            //Get New Mod OnModeratorJoined
            //Get Update Mod List OnModeratorleft
            //Update Game played by .....
            //Update Title by .....


            client.OnMessageReceived += new EventHandler<OnMessageReceivedArgs>(globalChatMessageRecevied);
            client.OnConnected += new EventHandler<OnConnectedArgs>(OnConnected);
            client.OnDisconnected += new EventHandler<OnDisconnectedArgs>(OnDisconnected);
            this.txtChatBox.KeyPress += new KeyPressEventHandler(CheckEnter);

            if (client.IsConnected == false)
            {
                client.Connect();
            }

            //I will get the Live Time to work some how.
            //GetUpTime evaids me at the moment need to see the format inorder to work the format into an string/date time format
            //TimeSpan uptime = TwitchApi.Streams.GetUptime(txtChatroom.Text);
            richChat.AppendText("Connecting.....\n");
            richChat.ScrollToCaret();

        }
        private void CheckEnter(object sender, KeyPressEventArgs e)
        {
            //if enter is pushed send message
            //user will only chat in current chat room This is designed for Streamers who talk in 1 chat room
            //Could add more down the road if need be.
            if (e.KeyChar == (char)13)
            {
                if (txtChatBox.Text != null)
                {
                    richChat.AppendText(DateTime.Now.ToString("h:mm") + "-" + Properties.Settings.Default.username + " : " + txtChatBox.Text + "\n");
                    richChat.ScrollToCaret();
                    client.SendMessage(txtChatroom.Text, txtChatBox.Text);
                    txtChatBox.Text = "";
                }
            }
        }
        public void newUser(object sender, OnUserJoinedArgs e)
        {
            //var Bot_User = Properties.Settings.Default.username.ToUpper(new CultureInfo("en-US", false));
            var NewUserList = e.Username.ToUpper(new CultureInfo("en-US", false));
            richUserList.AppendText(NewUserList+"\n");
            richUserList.ScrollToCaret();
            
        }

		//Update on Twitch chat comments update.
        public void globalChatMessageRecevied(object sender, OnMessageReceivedArgs e)
        {
            //CheckForIllegalCrossThreadCalls = false;
            richChat.AppendText(DateTime.Now.ToString("h:mm") + "-" + e.ChatMessage.Username + " : " + e.ChatMessage.Message+"\n");
            richChat.ScrollToCaret();
        }

		//Connected to Chat Room /Room is set to txtChatroom
        public void OnConnected(object sender, OnConnectedArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            client.JoinChannel(txtChatroom.Text);
            richChat.AppendText("<< Connected to Chat Server >>\n");
            richChat.AppendText("<< Connected to chatroom " + txtChatroom.Text + " >> \n");
            richChat.ScrollToCaret();
            
        }

		//Not showing room has been Disconnect or takes a long time.
        public void OnDisconnected(object sender, OnDisconnectedArgs e)
        {
            //Need to disconnect to IRC chat we can do this via irc command but want to 
            //do it though the Twichlib. Works sometimes but can not reconnect if was connected?

            //CheckForIllegalCrossThreadCalls = false;
            richChat.AppendText("<< Left chatroom " + txtChatroom.Text + ">> \n");
            richChat.AppendText("<< Disconnnected from server >> \n Have a Nice Day \n");
            richChat.ScrollToCaret();
        }

		//Disconnect Button to leave server?
        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            client.LeaveChannel(txtChatroom.Text);
			client.Disconnect();
            richChat.AppendText("<< Disconnecting..... >>\n");
            richChat.ScrollToCaret();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //This will exit the program very hard to make?
            this.Close();
        }
    }
}
