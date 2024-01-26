Imports Avalonia

NotInheritable Class Program

  ' Initialization code. Don't use any Avalonia, third-party APIs or any
  ' SynchronizationContext-reliant code before AppMain is called: things aren't initialized
  ' yet and stuff might break.
  <STAThread>
  Public Shared Sub Main(args As String())
    Call BuildAvaloniaApp.StartWithClassicDesktopLifetime(args)
  End Sub

  ' Avalonia configuration, don't remove; also used by visual designer.
  Public Shared Function BuildAvaloniaApp() As AppBuilder
#If AvaloniaStableChosen Then
    Return AppBuilder.Configure(Of App).UsePlatformDetect.WithInterFont.LogToTrace()
#Else
    Return AppBuilder.Configure(Of App).UsePlatformDetect.LogToTrace()
#End If
  End Function

End Class