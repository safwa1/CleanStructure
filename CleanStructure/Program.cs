using CleanStructure;

// clean structure

var group = new Group() { Name = "Ali Mohammed" };

GroupViewModel.OnEvent(new InsertGroup { Group = group });
GroupViewModel.OnEvent(new DeleteGroup { Group = group });
GroupViewModel.OnEvent(new UpdateGroup { Group = group });