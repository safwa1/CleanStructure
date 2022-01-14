using System;

namespace CleanStructure
{
    public static class GroupViewModel
    {
        public static void OnEvent(GroupEvent e)
        {
            _ = e switch
            {
                InsertGroup => Handle(e.Group, EventType.Insert),
                UpdateGroup => Handle(e.Group, EventType.Update),
                DeleteGroup => Handle(e.Group, EventType.Delete),
                _ => throw new ArgumentOutOfRangeException(nameof(e))
            };
        }

        private static Action? Handle(Group? group, EventType? type)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Enum.GetName(typeof(EventType), type!));
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"{@group}\n");

            return null;
        }
    }
}