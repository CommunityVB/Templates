Imports Avalonia
Imports Avalonia.Browser
Imports Avalonia.ReactiveUI
Imports System.Runtime.Versioning
Imports AvaloniaTest

<Assembly: SupportedOSPlatform("browser")>
Friend NotInheritable Partial Class Program

  Public Shared Sub Main(args As String())
    MainAsync(args).GetAwaiter.GetResult()
  End Sub

  Private Shared Function MainAsync(args As String()) As Task
    Return BuildAvaloniaApp.WithInterFont.UseReactiveUI.StartBrowserAppAsync("out")
  End Function

  Public Shared Function BuildAvaloniaApp() As AppBuilder
    Return AppBuilder.Configure(Of App)()
  End Function

End Class