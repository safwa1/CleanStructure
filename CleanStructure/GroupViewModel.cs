using System;

namespace CleanStructure
{
    public static class GroupViewModel
    {
        public static void OnEvent(GroupEvent e)
        {
            _ = e switch
            {
                GroupEvent.InsertGroup insertGroup => Handle(e.Group, EventType.Insert),
                GroupEvent.UpdateGroup updateGroup => Handle(e.Group, EventType.Update),
                GroupEvent.DeleteGroup deleteGroup => Handle(e.Group, EventType.Delete),
                _ => throw new ArgumentOutOfRangeException(nameof(e))
            };
        }

        private static Action? Handle(Group? group, EventType? type)
        {
            Console.WriteLine(Enum.GetName(typeof(EventType), type!));
            Console.WriteLine(group?.ToString());
            
            return null;
        }
    }
}