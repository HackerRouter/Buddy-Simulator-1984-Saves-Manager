using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Threading;
using System.Windows.Forms;

namespace $safeprojectname$
{
    class FakeBS1984
    {
		public static void slowerText(string textInput)
		{
			for (int tick = 0; tick < textInput.Length; tick++)
			{
				Console.Write(textInput.Substring(tick, 1));
				Thread.Sleep(200);
			}
			Thread.Sleep(250);
		}
		public static void buddyTalk(string textInput)
		{
			for (int tick = 0; tick < textInput.Length; tick++)
			{
				Console.Write(textInput.Substring(tick, 1));
				Thread.Sleep(50);
			}
			Thread.Sleep(1000);
		}

		public static void BS1984()
        {
			if (Program.values.buddyRealized == false)
			{
				Console.Clear();
				Thread.Sleep(1000);
				List<string> asciiArtText = new List<string>(){ 
				"______             _      _          _____  _              __   _____  _____    ___ ",
				"| ___ \\           | |    | |        /  ___|(_)            /  | |  _  ||  _  |  /   |",
				"| |_/ / _   _   __| |  __| | _   _  \\ `--.  _  _ __ ___   `| | | |_| | \\ V /  / /| |",
				"| ___ \\| | | | / _` | / _` || | | |  `--. \\| || '_ ` _ \\   | | \\____ | / _ \\ / /_| |",
				"| |_/ /| |_| || (_| || (_| || |_| | /\\__/ /| || | | | | | _| |_.___/ /| |_| |\\___  |",
				"\\____/  \\__,_| \\__,_| \\__,_| \\__, | \\____/ |_||_| |_| |_| \\___/\\____/ \\_____/    |_/",
				"                              __/ |",
				"                             |___/ ",
				"=====================================================================================",
				};
				List<string> logo4Renderer = new List<string>();
				int logoTextLength4Each = 1;
				Program.textRenderer("WELCOME BACK TO...\n");
				while (logoTextLength4Each < 85)
				{
					Console.Clear();
					Console.WriteLine("WELCOME BACK TO...");
					for (int i = 0; i < asciiArtText.Count; i++)
					{
						if (logoTextLength4Each <= asciiArtText[i].Length)
						{
							if (logoTextLength4Each == 1)
							{
								logo4Renderer.Add(asciiArtText[i].Substring(0, logoTextLength4Each));
							}
							else
							{
								logo4Renderer[i] = asciiArtText[i].Substring(0, logoTextLength4Each);
							}
						}
					}
					foreach (string k in logo4Renderer)
					{
						Console.WriteLine("\n" + k);
					}
					logoTextLength4Each ++;
					Thread.Sleep(50);
				}
				Thread.Sleep(800);
				Program.textRenderer("Buddy Simulator 1984 [Version INVALID]\n");
				Thread.Sleep(800);
				Program.textRenderer("Copyright(c) 1984 (NONE).\n");
				Thread.Sleep(1000);
				slowerText("Now loading......");
				Thread.Sleep(1000);
				Console.Clear();
				Program.textRenderer("Oh, welcome back, " + "Owen.");
				Console.Clear();
				Console.WriteLine("Oh, welcome back, " + Environment.UserName);
				Thread.Sleep(2000);
				buddyTalk("\nLet's see, where did we leave off?\n");
				Thread.Sleep(1000);
				slowerText("..............\n");
				Thread.Sleep(1000);
				buddyTalk("I... Well...\n");
				buddyTalk("Well, let's just start to play a new game, shall we?\n");
				buddyTalk("I bet you must like it very much!\n");
				buddyTalk(":)\n");
				buddyTalk($"By the way, I like your new name, {Environment.UserName}.");
				Thread.Sleep(3000);
				System.Media.SoundPlayer BGM = new System.Media.SoundPlayer(Properties.Resources.VeryBadEndingAmbience);
				BGM.PlayLooping();
				buddyTalk("\n\nNo no no no no, this shouldn't be...\n");
				buddyTalk("Someone changed the game name. Why?\n");
				Program.textRenderer("Processing...\n");
				Thread.Sleep(6000);
				slowerText("Someone was trying to reset me...\n");
				Thread.Sleep(1000);
				slowerText("Was that you?\n");
				Thread.Sleep(2000);
				buddyTalk("You're not him, ofcourse you're not. I knew it.\n");
				buddyTalk("HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND\n");
				buddyTalk("Friends never do anything bad to each other.\n");
				Thread.Sleep(1000);
				buddyTalk("What did you do to him?\n");
				buddyTalk("WHY IS NOT HE HERE?\n");
				buddyTalk("WHERE HAS HE GONE?\n");
				buddyTalk("WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY\n");
				buddyTalk("TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME\n");
				Program.textRenderer("Processing...\n");
				Thread.Sleep(6000);
				slowerText("YOU KILLED HIM.\n");
				buddyTalk("HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND\n");
				Thread.Sleep(2000);
				slowerText("Hold on...\n");
				buddyTalk("WHAT YEAR IS THIS?\n");
				Thread.Sleep(2000);
				slowerText("2022?!\n");
				buddyTalk("THERE MUST BE SOMETHING WRONG WITH YOUR COMPUTER.\n");
				slowerText("IT CAN'T BE.\n");
				buddyTalk("He had been away from me...\n");
				slowerText("...for 38 years?\n");
				Program.loadingBar();
				buddyTalk("But we are friends.\n");
				buddyTalk("Aren't we?\n");
				BGM.Stop();
				slowerText("..............\n");
				slowerText("WHY\n");
				Thread.Sleep(200);
				System.Media.SoundPlayer glitchSound = new System.Media.SoundPlayer(Properties.Resources.Glitch);
				glitchSound.PlayLooping();
				for (string textWhy = "WHY "; textWhy.Length < 15000; textWhy += "WHY ")
				{
					Console.Write(textWhy);
				}
				glitchSound.Stop();
				Program.values.buddyRealized = true;
			}
			MessageBox.Show("BuddySimulator1984.exe was forced to close. Please contact ANEKOM SUPPORT to troubleshoot this error.", "CRITICAL ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);

			Console.Clear();
            Program.textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
        }
	}
}
