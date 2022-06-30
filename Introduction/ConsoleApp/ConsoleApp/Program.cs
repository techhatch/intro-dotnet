// See https://aka.ms/new-console-template for more information
using ConsoleApp.MemoryManagment;

Console.WriteLine("Hello, World!");
var managed = new Managed();
Span<char> chars = stackalloc char[14];
CancellationTokenSource token = new();
Task.Delay(1000).ContinueWith(x => token.Cancel());
managed.LoopString(chars, token.Token);
Console.ReadLine();

using (Unmanaged unmanaged = new Unmanaged())
{
    unmanaged.ReadFile();
}
