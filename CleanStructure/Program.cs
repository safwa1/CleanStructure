using CleanStructure;

var group = new Group { Name = "John Doe" };

GroupViewModel.OnEvent(new InsertGroup(group));
GroupViewModel.OnEvent(new DeleteGroup(group));
GroupViewModel.OnEvent(new UpdateGroup(group));
GroupViewModel.OnEvent(new FindGroup("DemoGroupName"));
