Module Program

  Public Sub Main(args As String())
    MainAsync(args).GetAwaiter.GetResult()
  End Sub

  Private Async Function MainAsync(args As String()) As Task
    ' Replace the following with your Async/Await functionality...
    Console.WriteLine("Hello World!")
    Await Task.Delay(1)
  End Function

End Module