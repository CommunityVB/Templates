Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml

Public Partial Class App
  Inherits Application

  Public Overrides Sub Initialize()
    AvaloniaXamlLoader.Load(Me)
  End Sub

  Public Overrides Sub OnFrameworkInitializationCompleted()
    If TypeOf ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime Then
      CType(ApplicationLifetime, IClassicDesktopStyleApplicationLifetime).MainWindow = New MainWindow
    End If
    MyBase.OnFrameworkInitializationCompleted()
  End Sub

End Class