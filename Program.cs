using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading;

namespace $safeprojectname$
{
    class Program
    {
        public static void textRenderer(string textInput)
        {
            //values.simpleSound.PlayLooping();
            for (int tick = 0;tick < textInput.Length; tick++)
            {
                string textOutput = textInput.Substring(tick, 1);
                Console.Write(textOutput);
                //System.Media.SoundPlayer player = new System.Media.SoundPlayer();
                //player(Properties.Resources.TextPrint);
                //player.Play();
                //why doesn't it play the sound?
                Thread.Sleep(15);
            }
            //values.simpleSound.Stop();
            Thread.Sleep(200);

        }
        public static void loadingBar()
        {
            for (int tick = 0; tick < 14; tick++)
            {
                Console.Write("..............".Substring(tick, 1));
                Thread.Sleep(200);
            }
            Console.Write("\n");
        }

        public class values
        {
            public static bool buddyRealized;
            public static string directory = System.IO.Directory.GetCurrentDirectory() + @"\";
            public static string savesDirectory = directory + "backups\\";
            public static string directoryText = "\n" + System.IO.Directory.GetCurrentDirectory() + @"\";
            public static string responsePWD = "";
            public static int hiddenROMInputTimes = 0;
            public static List<string> ROMSList = new List<string>();
            //public static System.Media.SoundPlayer simpleSound = new System.Media.SoundPlayer(Properties.Resources.test1);
        }

        static void Main(string[] args)
        {
            values.ROMSList.Add("Buddy Simulator 1984");
            values.ROMSList.Add("Buddy Simulator 1984 Saves Manager");
            textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
            while (true)
            {
                textRenderer(values.directoryText);
                string commandInput = Console.ReadLine().ToLower();
                switch (commandInput)
                {
                    case ("help"):
                        textRenderer(@"
COMMANDS
--------
[View ROMS] - Enter 'View ROMS' to view installed roms.
[Run] - Enter 'Run' followed by the title of the ROM you want to launch.
[View Songs] - Enter 'View Songs' to view music files.
[Play] - Enter 'Play' followed by the title of the song you want to play.
[Reset] - Enter 'Reset' to clear all system memory.
[Quit] - Enter 'Quit' at any time to quit Anekom OS.
Use UP and DOWN arrows or MOUSE WHEEL to scroll.
");
                        break;
                    case ("?"):
                        textRenderer(@"
COMMANDS
--------
[View ROMS] - Enter 'View ROMS' to view installed roms.
[Run] - Enter 'Run' followed by the title of the ROM you want to launch.
[View Songs] - Enter 'View Songs' to view music files.
[Play] - Enter 'Play' followed by the title of the song you want to play.
[Reset] - Enter 'Reset' to clear all system memory.
[Quit] - Enter 'Quit' at any time to quit Anekom OS.
Use UP and DOWN arrows or MOUSE WHEEL to scroll.
");
                        break;
                    case ("view roms"):
                        if (values.ROMSList.Count != 1)
                        {
                            textRenderer($@"
INSTALLED ROMS
--------------
{values.ROMSList.Count} ROMS found
");
                        }
                        else
                        {
                            textRenderer($@"
INSTALLED ROM
--------------
1 ROM found
");
                        }
                        foreach (string ROMSNames in values.ROMSList)
                        {
                            Program.textRenderer($"[{ROMSNames}]\n");
                        }

                        break;
                    case ("view songs"):
                        textRenderer(@"
No Songs Found
--------------
");
                        break;
                    case ("quit"):
                        Thread.Sleep(800);
                        System.Environment.Exit(System.Environment.ExitCode);
                        break;
                    case ("run  "):
                        values.hiddenROMInputTimes++;
                        if (values.hiddenROMInputTimes == 4)
                        {
                            values.ROMSList.Add(" ");
                        }
                        if (values.ROMSList.Contains(" "))
                        {
                            textRenderer("\nReminder: Enter 'Quit' at any time to quit the ROM.\n");
                            Thread.Sleep(200);
                            System.Diagnostics.Process.Start("steam://rungameid/1269950");
                            textRenderer("\n[Loading BUDDY SIMULATOR 1984]\n");
                            loadingBar();
                            if (Console.ReadLine().ToLower().StartsWith("quit"))
                            {
                                foreach (System.Diagnostics.Process p in System.Diagnostics.Process.GetProcesses())
                                {
                                    if (p.ProcessName.ToLower().Contains("buddy simulator 1984"))
                                    {
                                        p.Kill();
                                        p.WaitForExit();
                                        Console.Clear();
                                        textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
                                    }
                                }
                            }
                        }
                        else
                        {
                            textRenderer("ROM [ ] not found.");
                        }
                        break;
                    case ("run buddy simulator 1984"):
                        if (values.ROMSList.Contains("Buddy Simulator 1984"))
                        {
                            textRenderer("\nReminder: Enter 'Quit' at any time to quit the ROM.\n");
                            Thread.Sleep(200);
                            textRenderer("\n[Loading BUDDY SIMULATOR 1984]\n");
                            loadingBar();
                            Thread.Sleep(1000);
                            FakeBS1984.BS1984();
                        }
                        else
                        {
                            textRenderer($"ROM [Buddy Simulator 1984] not found.\n");
                        }
                        break;
                    case ("run buddy simulator 1984 saves manager"):
                        textRenderer("\nReminder: Enter 'Quit' at any time to quit the ROM.\n");
                        Thread.Sleep(200);
                        textRenderer("\n[Loading BUDDY SIMULATOR 1984 SAVES MANAGER]\n");
                        loadingBar();
                        BS1984Manager.BS1984ManagerThread();
                        break;


                    case ("run bs1984sm"):
                        textRenderer("\nReminder: Enter 'Quit' at any time to quit the ROM.\n");
                        Thread.Sleep(200);
                        textRenderer("\n[Loading BUDDY SIMULATOR 1984 SAVES MANAGER]\n");
                        loadingBar();
                        BS1984Manager.BS1984ManagerThread();
                        break;


                    case ("uninstall buddy simulator 1984"):
                        textRenderer(@"
You are about to remove [Buddy Simulator 1984]
    Previously known names:
    [The Adventure of Owen]

[CRITICAL WARNING: ID [Buddy] IS DEPENDENT ON THIS APPLICATION]

Are you sure you would like to uninstall [Buddy Simulator 1984]?
>");
                        string responseInput = Console.ReadLine().ToLower();
                        while (true) {
                            //string responseInput = Console.ReadLine().ToLower();
                            if (yesResponses.Contains(responseInput))
                            {
                                while (values.responsePWD != "quit")
                                {
                                    textRenderer(@"

Please type admin password to confirm:
[WARNING: THIS ACTION CANNOT BE UNDONE]

>");
                                    values.responsePWD = Console.ReadLine().ToLower();
                                    if (values.responsePWD == "myfriendmilo")
                                    {
                                        textRenderer("\nBEGINNING REMOVAL OF [Buddy Simulator 1984]\n");
                                        loadingBar();
                                        values.responsePWD = "quit";
                                        values.ROMSList.Remove("Buddy Simulator 1984");
                                        break;
                                    }
                                    else if(values.responsePWD != "quit")
                                    {
                                        textRenderer("\nDENIED.\nReminder: Enter 'Quit' at any time to cancel the uninstallation.");
                                    }
                                }
                                if (values.responsePWD == "quit")
                                {
                                    Thread.Sleep(1000);
                                    Console.Clear();
                                    textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
                                    break;
                                }
                            }
                            else if (noResponses.Contains(responseInput) || responseInput == "quit")
                            {
                                Thread.Sleep(1000);
                                Console.Clear();
                                textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
                                break;
                            }
                            else
                            {
                                textRenderer($"'{responseInput}' is not a recognized response.\n>");
                                responseInput = Console.ReadLine().ToLower();
                            }
                        }
                        break;
                    case "reset":
                        textRenderer("\nYou are about to reset all system memory. Continue?\nWARNING: This cannot be un-done.\n>");
                        while (true)
                        {
                            responseInput = Console.ReadLine().ToLower();
                            if (yesResponses.Contains(responseInput))
                            {
                                textRenderer("RESTART SYSTEM MEMORY\n");
                                Thread.Sleep(400);
                                loadingBar();
                                Thread.Sleep(1000);
                                Console.Clear();
                                Thread.Sleep(3000);
                                textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
                                values.ROMSList.RemoveRange(0, values.ROMSList.Count);
                                values.ROMSList.Add("Buddy Simulator 1984");
                                values.ROMSList.Add("Buddy Simulator 1984 Saves Manager");
                                values.responsePWD = "";
                                values.hiddenROMInputTimes = 0;
                                values.buddyRealized = false;
                                break;
                            }
                            else if(noResponses.Contains(responseInput))
                            {
                                break;
                            }
                            else
                            {
                                textRenderer($"'{responseInput}' is not a recognized response.\n>");
                            }
                        }
                        break;
                    default:
                        if (commandInput.StartsWith("run"))
                        {
                            if (commandInput.Length == 3 || commandInput == "run ")
                            {
                                textRenderer("'Run' by itself is not valid. Please use 'Run' followed by the title of a ROM you want to launch.");
                            }
                            else 
                            {
                                    string romStart = commandInput.Substring(4);
                                    textRenderer($"ROM [{romStart}] not found.");
                            }
                        }
                        else if(commandInput.StartsWith("play"))
                        {
                            if (commandInput.Length == 4|| commandInput == ("play "))
                            {
                                textRenderer("'Play' by itself is not valid. Please use 'Play' followed by the title of a song you want to play.");
                            }
                            else
                            {
                                string songPlay = commandInput.Substring(5);
                                textRenderer($"Song [{songPlay}] not found.");
                            }
                        }
                        else
                        {
                            textRenderer($"'{commandInput}' is not a recognized command.");
                        }
                        break;
                }
            }
        }
        public static string[] yesResponses = new string[]
        {
            "y",
            "yes",
            "yeah",
            "yup",
            "yep",
            "ja",
            "ye",
            "sure",
            "ok",
            "okay",
            "alright",
            "fine",
            "yea",
            "duh",
            "obviously",
            "alrighty",
            "i guess",
            "kinda",
            "kind of",
            "totally",
            "fo sho",
            "roger",
            "yiss",
            "probably",
            "of course",
            "ya",
            "yas",
            "you bet",
            "okey",
            "uh huh",
            "absolutely"
        };

        public static string[] noResponses = new string[]
        {
            "n",
            "no",
            "nope",
            "nein",
            "nah",
            "not really",
            "naw",
            "negative",
            "uh uh",
            "na",
            "meh"
        };

    }
}
