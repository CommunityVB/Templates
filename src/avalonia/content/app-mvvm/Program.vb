Imports Avalonia
#If ReactiveUIToolkitChosen Then
Imports Avalonia.ReactiveUI
#End If

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
#If ReactiveUIToolkitChosen Then
#If AvaloniaStableChosen Then
    Return AppBuilder.Configure(Of App)().UsePlatformDetect.LogToTrace.WithInterFont.UseReactiveUI()
#Else
    Return AppBuilder.Configure(Of App)().UsePlatformDetect.LogToTrace.UseReactiveUI()
#End If
#Else
#If AvaloniaStableChosen Then
    Return AppBuilder.Configure(Of App)().UsePlatformDetect.WithInterFont.LogToTrace()
#Else
    Return AppBuilder.Configure(Of App)().UsePlatformDetect.LogToTrace()
#End If
#End If

  End Function

End Class