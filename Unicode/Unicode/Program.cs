using Microsoft.Win32;
using System.Security.Principal;
using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string unicode = $@"C:\Users\{Environment.UserName}\Unicode";
        if (Directory.Exists(unicode))
        {
            Directory.Delete(unicode, true);
        }
        Directory.CreateDirectory($@"C:\Users\{Environment.UserName}\Unicode");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(@"
                                 _               _      
                                (_)             | |     
                     _   _ _ __  _  ___ ___   __| | ___ 
                    | | | | '_ \| |/ __/ _ \ / _` |/ _ \
                    | |_| | | | | | (_| (_) | (_| |  __/
                     \__,_|_| |_|_|\___\___/ \__,_|\___|
        ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(@"                                  detector
                     - - - - - - - - - - - - - - - - - -");

        try
        {
            string mui = @"Local Settings\Software\Microsoft\Windows\Shell\MuiCache";

            using (RegistryKey key = Registry.ClassesRoot.OpenSubKey(mui))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";

                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }

                }
                else
                {
                    Console.WriteLine("[!] Unable to query MuiCache names");
                }
            }

            string store = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Store";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(store))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }
                }

            }

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            SecurityIdentifier sid = identity.User;
            string bam = $@"SYSTEM\CurrentControlSet\Services\bam\{sid}";

            using (RegistryKey key = Registry.LocalMachine.OpenSubKey(bam))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }
                }
            }

            string persisted = $@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\AppCompatFlags\Compatibility Assistant\Persisted";

            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(persisted))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }
                }
            }

            string switched = $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\AppSwitched";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(switched))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }
                }
            }

            string jump = $@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\FeatureUsage\ShowJumpView";
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(jump))
            {
                if (key != null)
                {
                    string[] valueNames = key.GetValueNames();

                    string nombresVariables = "";

                    foreach (string valueName in valueNames)
                    {
                        nombresVariables += valueName + ", ";
                    }

                    nombresVariables = nombresVariables.TrimEnd(',', ' ');

                    string path = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";
                    using (StreamWriter writer = new StreamWriter(path, true))
                    {
                        writer.WriteLine($"{nombresVariables}");
                    }
                }
            }

            string prefetchDir = $@"C:\\Windows\\Prefetch";
            string outputFile = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";

            string[] fileNames = Directory.GetFiles(prefetchDir);

            using (StreamWriter writer = File.AppendText(outputFile))
            {
                foreach (string fileName in fileNames)
                {
                    writer.WriteLine(fileName);
                }
            }

            string fileContents = File.ReadAllText($"C:\\users\\{Environment.UserName}\\Unicode\\res.txt");

            fileContents = fileContents.Replace(",", Environment.NewLine);

            File.WriteAllText($"C:\\users\\{Environment.UserName}\\Unicode\\res.txt", fileContents);

            fileContents = fileContents.Replace(" ", "");

            File.WriteAllText($"C:\\users\\{Environment.UserName}\\Unicode\\res.txt", fileContents);

            fileContents = fileContents.Replace(".FriendlyAppName", "");

            File.WriteAllText($"C:\\users\\{Environment.UserName}\\Unicode\\res.txt", fileContents);

            fileContents = fileContents.Replace(".ApplicationCompany", "");

            File.WriteAllText($"C:\\users\\{Environment.UserName}\\Unicode\\res.txt", fileContents);

            bool foundUnicode = false;
            string archivo = $"C:\\users\\{Environment.UserName}\\Unicode\\res.txt";

            string[] lines = File.ReadAllLines(archivo);

            foreach (string line in lines)
            {
                if (Regex.IsMatch(line, @"[^\x00-\xFF]"))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("[!]");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" Unicode character found in: {0}", line);
                    foundUnicode = true;
                }
            }

            if (!foundUnicode)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.Write("[+]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(" No Unicode characters found");
            }

            Console.ReadKey();

        }
        catch (Exception ex)
        {
            Console.WriteLine("Ocurrió un error: " + ex.Message);
        }

    }
}