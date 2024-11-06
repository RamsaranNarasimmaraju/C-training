// See https://aka.ms/new-console-template for more information
using Threads;
Console.WriteLine("Hello, World!");
Thread thread = new Thread(new ThreadStart(Ourclass.Display));
Console.WriteLine("Thread details");
Console.WriteLine("Background:\t"+thread.IsBackground);
Console.WriteLine("Name:\t" + thread.Name);
Console.WriteLine("State:\t"+thread.ThreadState);


thread.Start();
