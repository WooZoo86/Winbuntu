/*
This file is part of Winbuntu by Matt Wollam.

Winbuntu is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

Winbuntu is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with Winbuntu.  If not, see <https://www.gnu.org/licenses/>.
*/
using System;
using System.IO;

namespace Winbuntu
{
    class RegEdit
    {
        public static void Add()
        {
            string target = Program._args[Program._args.Count - 1];
            string targetPath = FindExePath(target);
            Console.WriteLine("Installing {0} at {1}", target, targetPath);
        }

        public static void Remove()
        {
            
        }

        /// <summary>
        /// Determines if the exe is on the system path or the current working directory
        /// </summary>
        /// <param name="exe"> The name of the executable file </param>
        /// <returns> The full path of the executable </returns>
        public static string FindExePath(string exe)
        {
            exe = Environment.ExpandEnvironmentVariables(exe);
            if (!File.Exists(exe))
            {
                if (Path.GetDirectoryName(exe) == String.Empty)
                {
                    foreach (string test in (Environment.GetEnvironmentVariable("PATH") ?? "").Split(';'))
                    {
                        string path = test.Trim();
                        if (!String.IsNullOrEmpty(path) && File.Exists(path = Path.Combine(path, exe)))
                        return Path.GetFullPath(path);
                     }
                }
                Console.WriteLine("{0} is not on the path, please try another program or direct path.", exe);
                Environment.Exit(0);
            }
            return Path.GetFullPath(exe);
        }
        
    }
}