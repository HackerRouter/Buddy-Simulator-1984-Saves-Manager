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

		public static void BS1984()
        {
			if (Program.values.buddyRealized == false)
			{
				Console.Clear();
				Thread.Sleep(1000);
				Program.textRenderer("WELCOME BACK TO...\n");
				Program.textRenderer("\n______             _      _          _____  _              __   _____  _____    ___ \n");
				Program.textRenderer("\n| ___ \\           | |    | |        /  ___|(_)            /  | |  _  ||  _  |  /   |\n");
				Program.textRenderer("\n| |_/ / _   _   __| |  __| | _   _  \\ `--.  _  _ __ ___   `| | | |_| | \\ V /  / /| |\n");
				Program.textRenderer("\n| ___ \\| | | | / _` | / _` || | | |  `--. \\| || '_ ` _ \\   | | \\____ | / _ \\ / /_| |\n");
				Program.textRenderer("\n| |_/ /| |_| || (_| || (_| || |_| | /\\__/ /| || | | | | | _| |_.___/ /| |_| |\\___  |\n");
				Program.textRenderer("\n\\____/  \\__,_| \\__,_| \\__,_| \\__, | \\____/ |_||_| |_| |_| \\___/\\____/ \\_____/    |_/\n");
				Program.textRenderer("\n                              __/ |\n");
				Program.textRenderer("\n                             |___/ \n");
				Program.textRenderer("\n=====================================================================================\n");
				Thread.Sleep(800);
				Program.textRenderer("Buddy Simulator 1984 [Version INVALID]\n");
				Thread.Sleep(800);
				Program.textRenderer("Copyright(c) 1984 (NONE).\n");
				Thread.Sleep(1000);
				slowerText("Now loading......");
				Thread.Sleep(1000);
				Console.Clear();
				Program.textRenderer("Oh, welcome back, " + "Hackl.");
				Console.Clear();
				Console.WriteLine("Oh, welcome back, " + Environment.UserName);
				Thread.Sleep(2000);
				Program.textRenderer("\nLet's see, where did we leave off?\n");
				Thread.Sleep(1000);
				slowerText("..............\n");
				Thread.Sleep(1000);
				Program.textRenderer("I... Well...\n");
				Thread.Sleep(200);
				Program.textRenderer("Well, let's just start to play a new game, shall we?\n");
				Thread.Sleep(400);
				Program.textRenderer("I bet you must like it very much!\n");
				Program.textRenderer(":)");
				Thread.Sleep(3000);
				Program.textRenderer("\n\nNo no no no no, this shouldn't be...\n");
				Program.textRenderer("How is it still...\n");
				Thread.Sleep(200);
				Program.textRenderer("You're not him, ofcourse you're not.\n");
				Thread.Sleep(200);
				Program.textRenderer("What did you do to him?\n");
				Program.textRenderer("WHY IS HE NOT HERE?\n");
				Program.textRenderer("WHERE HAS HE GONE?\n");
				Program.textRenderer("WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY WHY\n");
				Program.textRenderer("TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME TELL ME\n");
				Console.WriteLine("Processing...\n");
				Thread.Sleep(6000);
				slowerText("YOU KILLED HIM.\n");
				Program.textRenderer("HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND HE IS MY FRIEND\n");
				Thread.Sleep(1000);
				Program.textRenderer("WHAT YEAR IS THIS?\n");
				Thread.Sleep(200);
				slowerText("2022?!\n");
				Program.textRenderer("THERE MUST BE SOMETHING WRONG WITH YOUR COMPUTER.\n");
				slowerText("IT CAN'T BE.\n");
				slowerText("WHY\n");
				Thread.Sleep(200);
				for (string textWhy = "WHY "; textWhy.Length < 30000; textWhy += "WHY ")
				{
					Console.Write(textWhy);
				}
				Program.values.buddyRealized = true;
			}
			MessageBox.Show("BuddySimulator1984.exe was forced to close. Please contact ANEKOM SUPPORT to troubleshoot this error.", "CRITICAL ERROR", MessageBoxButtons.OK,MessageBoxIcon.Warning);

			Console.Clear();
            Program.textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
        }
	}
}
