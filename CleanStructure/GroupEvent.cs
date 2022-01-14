namespace CleanStructure
{

    public enum EventType
    {
        None,
        Insert,
        Update,
        Delete,
        Find,
        Select
    }
    
    public abstract record GroupEvent
    {
        public Group? Group { get; set; }
    }
    
    public sealed record InsertGroup : GroupEvent;
    public sealed record UpdateGroup : GroupEvent;
    public sealed record DeleteGroup : GroupEvent;
}