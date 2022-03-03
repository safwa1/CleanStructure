using System;
using System.Threading.Tasks;
using CleanStructure.ConsoleUtil;
using static CleanStructure.ConsoleUtil.Messages;

namespace CleanStructure
{
    // pseudo ViewModel to simulation 
    public static class GroupViewModel
    {
        public static void OnEvent(GroupEvent e)
        {
            _ = e switch
            {
                InsertGroup @event => Handle(@event.Group, EventType.Insert),
                UpdateGroup @event => Handle(@event.Group, EventType.Update),
                DeleteGroup @event => Handle(@event.Group, EventType.Delete),
                FindGroup   @event => FindGroup(@event.Name),
                _ => throw new ArgumentOutOfRangeException(nameof(e))
            };
        }

        private static Task Handle(Group? group, EventType type)
        {
            Println(Enum.GetName(typeof(EventType), type), MessageType.Success);
            Println($"{group}\n");
            return Task.CompletedTask;
        }

        private static Task<Group> FindGroup(string name)
        {
            Println(nameof(EventType.Find), MessageType.Success);
            Println($"Finding Group where Group.Name = {name}");
            return Task.FromResult(new Group { Name = name });
        }
    }
}