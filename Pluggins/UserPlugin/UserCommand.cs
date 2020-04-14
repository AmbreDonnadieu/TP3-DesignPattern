using PluginBase;
using System;

namespace UserPlugin
{
    public class UserCommand : ICommand
    {
        public string Name { get => "User"; }
        public string Description { get => "Displays User message."; }

        public int Execute()
        {
            Console.WriteLine("User !!!");
            return 0;
        }
    }
}