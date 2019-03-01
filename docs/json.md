# JSON file explinations
This file contains explinations about the JSON files included with Winbuntu

<!-- TABLE OF CONTENTS -->
## Table of Contents
- [JSON file explinations](#json-file-explinations)
  - [Table of Contents](#table-of-contents)
  - [Winbuntu Registry](#winbuntu-registry)
    - [Registry Structure](#registry-structure)


<!-- REGISTRY -->
## Winbuntu Registry
Saved under `/src/registry.json` this file contains the registry that Winbuntu uses to find and open programs. If the program is not opening with Winbuntu, make sure it is added to this file, and all the information is correct.

### Registry Structure
Winbuntu's registry is layed out like this;
```
{
    "example": {
        "title": "Example Program",
        "execute": "example.exe",
        "target": "windows"
        "path": "C:\\Program Files\\Example"
    }
}
```
- The top level information `"example"` is the shorthand name of the program. For example, this could be `"vscode"` for Visual Studio Code's registry entry
- The next piece of information, `title` is the full name of the piece of software. So with our example, this line would read `"title: Visual Studio Code"`.
- The second line contains the information about the actual file that will be executed. Continuing our example, this line would read `"execute": "code.exe"`. This can have any executable file ending, such as `code.py` or `code.cs`.
- Third, we have our target OS. This allows the user to have both Windows and Linux targets in the registry. This line would read `"target": "windows"` for a Windows target `"linux"` for a Linux target.
- Finally we have the path to the directory containing the executable. Rounding out our example, we would write `"path": "C:\\Program Files\\Code"`. For windows paths you must use double back slashes in the path, and Linux paths *are* case sensitive.

If we take all of the information above and bring it together, our registry entry for VSCode would look like this;
```
{
    "vscode": {
        "title": "Visual Studio Code",
        "execute": "code.exe",
        "target": "windows"
        "path": "C:\\Program Files\\Code"
    }
}
```