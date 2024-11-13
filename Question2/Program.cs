// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

var stack  = new Question2.Stack<int>();

//verify list is empty
Console.WriteLine(stack.IsEmpty());

//should throw exception
//stack.Pop();

//stack.Peek();

stack.Push(1);
stack.Push(5);
stack.Push(6);

Console.WriteLine(stack.IsEmpty());
Console.WriteLine(stack.Count());

//check last element
Console.WriteLine(stack.Peek());

//remove 6 from stack
stack.Pop();