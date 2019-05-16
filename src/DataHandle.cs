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
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Winbuntu
{
    /// <summary>
    /// The generic structure that Winbuntu registries take
    /// </summary>
    public struct RegistryEntry
    {
        // Full name of the program
        [JsonProperty("title")]
        public string Title { get; set; }

        // Single word name of the program, used for command line
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        // Location of the actual program executable 
        [JsonProperty("execute")]
        public string Execute { get; set; }

        // Platform of choice, either "windows" or "linux"
        [JsonProperty("target")]
        public string Target { get; set; }

        // Path to the parent directory of the program
        [JsonProperty("path")]
        public string Path { get; set; }
    }

    public class UseData 
    {
        /// <summary>
        /// A method to generate useable data from the registry file
        /// </summary>
        /// <returns> A formatted list of registry entries for the rest of the program to use </returns>
        public static List<RegistryEntry> DataReader()
        {
            StreamReader reader = new StreamReader(@"src/data/registry.json");
            string file = reader.ReadToEnd();
            List<RegistryEntry> entries = JsonConvert.DeserializeObject<List<RegistryEntry>>(file);

            return entries;
        }
    }
}