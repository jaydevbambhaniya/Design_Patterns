using State.Context;

EmployeeContext context = new();

//Internal state changes and based on that behavior changes but no change on core side.
context.Process();
context.Process();
context.Process();