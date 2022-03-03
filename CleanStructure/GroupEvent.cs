namespace CleanStructure
{
    public abstract record GroupEvent;

    public sealed record InsertGroup(Group Group) : GroupEvent;

    public sealed record UpdateGroup(Group Group) : GroupEvent;

    public sealed record DeleteGroup(Group Group) : GroupEvent;
    
    public sealed record FindGroup(string Name) : GroupEvent;
}