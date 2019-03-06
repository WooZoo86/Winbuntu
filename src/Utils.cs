using System.Collections.Generic;
using System;

namespace Winbuntu
{
    /// <summary>
    ///  Class which defines what a command should contain
    /// </summary>
    public abstract class Command
    {
        // This is the function or command that should be executed
        public virtual void Execute() => Console.WriteLine("This command has not yet been implemented.");
        // Full name for each argument
        public virtual string Name { get; }
        // Single letter short name for each argument
        public virtual string ShortName { get; }
        // A short and simple description for each argument
        public virtual string Description { get; }
    }

    /// <summary>
    /// A nice compact class for misc utilites that help Winbuntu tick
    /// </summary>
    class Util
    {        
        public static readonly string Version = "v0.1";

        /// <summary>
        /// The master list of all commands in Winbuntu
        /// </summary>
        public static readonly List<Command> Commands = new List<Command>()
        {
            new Add(),
            new Help(),
            new Install(),
            new Registry(),
            new Uninstall(),
            new Version()
        };
    }
}