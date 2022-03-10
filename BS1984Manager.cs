using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.Diagnostics;
using System.Threading;
using System.IO;

namespace $safeprojectname$
{
    class BS1984Manager{
        public static void BS1984ManagerThread()
        {
            if (!Directory.Exists(Program.values.savesDirectory))
            {
                Directory.CreateDirectory(Program.values.savesDirectory);
            }
            Console.Clear();
            Thread.Sleep(1000);
            Program.textRenderer("[Buddy Simulator 1984 Saves Manager] [Version 1.0.1]\nCreated By HackerRouter\nEnter HELP for more assistance.\n");
            while (true)
            {
                Program.textRenderer("\n>");
                string commandInput = Console.ReadLine().ToLower();
                switch (commandInput) 
                {
                    case ("help"):
                        Program.textRenderer(@"
COMMANDS
--------
[Backup] - Enter 'Backup' followed by the title of the backups of the save you want to name.(Not required)
[View Backups] - Enter 'View Backups' to view the list of all the backups.
[View Path] - Enter 'View Path' to view the path of the folder of your backups.
[Delete] - Enter 'Delete' followed by the title of the backups you want to delete.
[Delete All] - Enter 'Delete All' to delete all the backups.
[Replace] - Enter 'Replace' followed by the title of the backups you want to replace the current save with.
[Reset] - Enter 'Reset' to delete the current save file of the game.
[Quit] - Enter 'Quit' at any time to quit Buddy Simulator 1984 Saves Manager.
Use UP and DOWN arrows or MOUSE WHEEL to scroll.
");
                        break;
                    case ("view backups"):
                        DirectoryInfo dir = new DirectoryInfo(Program.values.savesDirectory);
                        List<string> backupsList = new List<string>();
                        foreach (FileInfo f in dir.GetFiles("*.reg"))
                        {
                            backupsList.Add(f.Name);
                        }
                        if (backupsList.Count == 0)
                        {
                            Program.textRenderer("\nNo Backups Found\n--------------\n");
                        }
                        else
                        {
                            if (backupsList.Count == 1)
                            {
                                Program.textRenderer("\n1 Backup Found\n--------------\n");
                            }
                            else
                            {
                                Program.textRenderer("\n" + backupsList.Count + " Backups Found\n--------------\n");
                            }
                            foreach (string backupsNames in backupsList)
                            { 
                                Program.textRenderer($"{backupsNames}\n");
                            }
                        }
                        break;
                    case ("delete all"):
                        if (System.IO.Directory.GetFiles(Program.values.savesDirectory,"*.reg").Length > 0) {
                            DirectoryInfo dirr = new DirectoryInfo(Program.values.savesDirectory);
                            foreach (FileInfo f in dirr.GetFiles("*.reg"))
                            {
                                File.Delete(f.FullName);
                            }
                            Program.textRenderer("Reminder: You have deleted all the backups.\n");
                            Thread.Sleep(500);
                        }
                        else
                        {
                            Program.textRenderer("[ERROR] Unable to find any backups to delete.\n");
                            Thread.Sleep(500);
                        }
                        break;
                    case "view path":
                        Program.textRenderer($"\nYour Backups Folder\n--------------\n{Program.values.savesDirectory}\n");
                        break;
                    case "reset":
                        while (true)
                        {
                            Program.textRenderer($"Are you sure you would like to reset your current save?\n[WARNING: THIS ACTION CANNOT BE UNDONE]\n\n>");
                            string responseInput = Console.ReadLine().ToLower();
                            if (Program.yesResponses.Contains(responseInput))
                            {
                                Process p = new Process();
                                p.StartInfo.FileName = "cmd.exe";

                                p.StartInfo.UseShellExecute = false;
                                p.StartInfo.RedirectStandardInput = true;
                                p.StartInfo.RedirectStandardOutput = true;
                                p.StartInfo.CreateNoWindow = true;
                                p.Start();
                                p.StandardInput.WriteLine("reg delete \"HKEY_CURRENT_USER\\SOFTWARE\\Not a Sailor Studios\\Buddy Simulator 1984\" /f");
                                p.StandardInput.WriteLine("exit");
                                p.WaitForExit();
                                Program.textRenderer("Reminder: You have reset the current save.\n");
                                break;
                            }
                                else if (Program.noResponses.Contains(responseInput))
                                {
                                    break;
                                }
                                else
                                {
                                    Program.textRenderer($"'{responseInput}' is not a recognized response.\n\n");
                                }
                        }
                        break;
                    case ("quit"):
                        break;
                    default:
                        if (commandInput.StartsWith("backup"))
                        {
                            createBackups(commandInput);
                            break;
                        }
                        else if (commandInput.StartsWith("delete")){

                            if (string.IsNullOrWhiteSpace(commandInput.Substring(6)) == true)
                            {
                                Program.textRenderer("'Delete' by itself is not valid. Please use 'Delete' followed by the title of the backups you want to delete.\n");
                                break;
                            }
                            
                            string backupToDelete = Program.values.savesDirectory + commandInput.Substring(7);
                            if (!commandInput.Contains(".reg"))
                            {
                                backupToDelete += ".reg";
                            }
                            if (File.Exists(backupToDelete) == true)
                            {
                                while (true)
                                {
                                    Program.textRenderer($"Are you sure you would like to delete the backup [{commandInput.Substring(7)}]?\n[WARNING: THIS ACTION CANNOT BE UNDONE]\n\n>");
                                    string responseInput = Console.ReadLine().ToLower();
                                    if (Program.yesResponses.Contains(responseInput))
                                    {
                                        File.Delete(backupToDelete);
                                        Program.textRenderer($"Reminder: You have deleted the backup [{commandInput.Substring(7)}].\n");
                                        break;
                                    }
                                    else if (Program.noResponses.Contains(responseInput))
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Program.textRenderer($"'{responseInput}' is not a recognized response.\n\n");
                                    }
                                }
                            }
                            else
                            {
                                Program.textRenderer($"[ERROR] Unable to find the backup[{commandInput.Substring(7)}].\n");
                            }
                            break;
                        }


                        else if (commandInput.StartsWith("replace"))
                        {
                            if (string.IsNullOrWhiteSpace(commandInput.Substring(7)) == true)
                            {
                                Program.textRenderer("'Replace' by itself is not valid. Please use 'Replace' followed by the title of the backups you want to replace the current save with.\n");
                                break;
                            }
                            string backupToReplace = Program.values.savesDirectory + commandInput.Substring(8);
                            Process p = new Process();
                            p.StartInfo.FileName = "cmd.exe";

                            p.StartInfo.UseShellExecute = false;
                            p.StartInfo.RedirectStandardInput = true;
                            p.StartInfo.RedirectStandardOutput = true;
                            p.StartInfo.CreateNoWindow = true;
                            p.Start();
                            if (!commandInput.Contains(".reg"))
                            {
                                backupToReplace += ".reg";
                            }
                            if (File.Exists(backupToReplace) == true)
                            {
                                while (true)
                                {
                                    Program.textRenderer($"Are you sure you would like to replace the current save with the backup [{commandInput.Substring(8)}]?\n[WARNING: THIS ACTION CANNOT BE UNDONE]\n\n>");
                                    string responseInput = Console.ReadLine().ToLower();
                                    if (Program.yesResponses.Contains(responseInput))
                                    {
                                        p.StandardInput.WriteLine($"regedit /s \"{backupToReplace}\"");
                                        p.StandardInput.WriteLine("exit");
                                        p.WaitForExit();
                                        Program.textRenderer($"Reminder: You have replaced the current save with the backup [{commandInput.Substring(8)}].\n");
                                        break;
                                    }else if (Program.noResponses.Contains(responseInput))
                                    {
                                        break;
                                    }else
                                    {
                                        Program.textRenderer($"'{responseInput}' is not a recognized response.\n\n");
                                    }
                                }
                                break;
                            }
                            else
                            {
                                Program.textRenderer($"[ERROR] Unable to find the backup[{commandInput.Substring(8)}].\n");
                            }
                            break;
                        }
                        else
                        {
                            Program.textRenderer($"'{commandInput}' is not a recognized command.");
                            break;
                        }
                }
                if (commandInput == "quit")
                {
                    Console.Clear();
                    Program.textRenderer("Anekom Official OS [Version INVALID]\n(c)1982 Anekom Software Inc. All rights reserved.\n\nEnter HELP for more assistance.\n");
                    break;
                }
            }
            
            
            //p.StandardInput.WriteLine("cd D:\\htk0");
            //p.StandardInput.WriteLine(command);
            //System.Diagnostics.Process.Start("cmd.exe","regedit -e \"C: \\Users\\user\\Documents\\Visual Studio 2019\\11122.reg\" \"HKEY_CURRENT_USER\\SOFTWARE\\Not a Sailor Studios\\Buddy Simulator 1984\"");
        }

        public static void createBackups(string backupName)
        {
            Process p = new Process();
            p.StartInfo.FileName = "cmd.exe";

            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.Start();
            if (string.IsNullOrWhiteSpace(backupName.Substring(6)) == true)
            {
                backupName = System.DateTime.Now.ToString("yy_MM_dd_HH-mm-ss");
            }
            else
            {
                backupName = backupName.Substring(7);
            }
            if (File.Exists(Program.values.savesDirectory + backupName + ".reg"))
            {
                Program.textRenderer($@"
[ERROR] The backup [{backupName}] is in existence.]
Are you sure you're going to overwrite this backup?

[WARNING: THIS ACTION CANNOT BE UNDONE]
");
                while (true) { 
                    Console.Write("\n>");
                    string responseInput = Console.ReadLine().ToLower();
                    if (Program.yesResponses.Contains(responseInput))
                    {
                        p.StandardInput.WriteLine($"regedit -e \"{Program.values.savesDirectory}" + backupName + ".reg\" \"HKEY_CURRENT_USER\\SOFTWARE\\Not a Sailor Studios\\Buddy Simulator 1984\"");
                        p.StandardInput.WriteLine("exit");
                        p.WaitForExit();
                        Program.textRenderer($"Reminder: You have overwritten the backup [{backupName}].\n");
                        Thread.Sleep(500);
                        break;
                    }
                    else if (Program.noResponses.Contains(responseInput))
                    {
                        p.StandardInput.WriteLine("exit");
                        p.WaitForExit();
                        Program.textRenderer($"Reminder: You have cancelled overwriting the backup [{backupName}].\n");
                        Thread.Sleep(500);
                        break;
                        }
                    else
                    {
                        Program.textRenderer($"'{responseInput}' is not a recognized response.");
                    }
                }
            }
            else
            {
                    p.StandardInput.WriteLine($"regedit -e \"{Program.values.savesDirectory}" + backupName + ".reg\" \"HKEY_CURRENT_USER\\SOFTWARE\\Not a Sailor Studios\\Buddy Simulator 1984\"");
                    p.StandardInput.WriteLine("exit");
                    p.WaitForExit();
                    Program.textRenderer($"Reminder: You have made a backup [{backupName}], if you didn't reset your current save before.\n");
                    Thread.Sleep(500);
                /*if (!File.Exists(Program.values.savesDirectory + backupName + ".reg"))
                {
                    Console.WriteLine(Program.values.savesDirectory + backupName + ".reg");
                    Program.textRenderer($"[ERROR] Unable to make the backup [{backupName}]. Did you just reset your current save before?\n");
                }
                else
                {
                    Program.textRenderer($"Reminder: You have made a backup [{backupName}].\n");
                    Thread.Sleep(500);
                }*/
            }
        }
}
    //reg export "HKEY_CURRENT_USER\SOFTWARE\Not a Sailor Studios\Buddy Simulator 1984 "+ System.IO.Directory.GetCurrentDirectory() + @"\.reg"
    //>regedit -e "C:\Users\user\Documents\Visual Studio 2019\111.reg" "HKEY_CURRENT_USER\SOFTWARE\Not a Sailor Studios\Buddy Simulator 1984"
}

