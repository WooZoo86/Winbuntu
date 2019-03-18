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
    public class UseData 
    {
        /// <summary>
        /// A method to generate useable data from the registry file
        /// </summary>
        /// <returns> A dynmaic  </returns>
        public static dynamic DataReader()
        {
            StreamReader reader = new StreamReader(@"src/data/registry.json");
            string file = reader.ReadToEnd();
            dynamic data = JsonConvert.DeserializeObject(file);

            return data;
        }
    }
}