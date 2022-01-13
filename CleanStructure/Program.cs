using System;
using CleanStructure;

// clean structure

GroupViewModel.OnEvent(new GroupEvent.InsertGroup()
{
    Group = new() { Name = "Ali Mohammed Added" }
});

GroupViewModel.OnEvent(new GroupEvent.DeleteGroup()
{
    Group = new() { Name = "Ali Mohammed Deleted" }
});

GroupViewModel.OnEvent(new GroupEvent.UpdateGroup()
{
    Group = new() { Name = "Ali Mohammed Updated" }
});

// pause screen
Console.ReadKey();