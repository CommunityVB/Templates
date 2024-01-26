Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
Imports Avalonia.Markup.Xaml
Imports AvaloniaTest.ViewModels
Imports AvaloniaTest.Views

Public Partial Class App
  Inherits Application

  Public Overrides Sub Initialize()
    AvaloniaXamlLoader.Load(Me)
  End Sub
 
  Public Overrides Sub OnFrameworkInitializationCompleted()
    If TypeOf ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime Then
      CType(ApplicationLifetime, IClassicDesktopStyleApplicationLifetime).MainWindow = New MainWindow With {.DataContext = New MainViewModel}
    ElseIf TypeOf ApplicationLifetime Is ISingleViewApplicationLifetime Then
      CType(ApplicationLifetime, ISingleViewApplicationLifetime).MainView = New MainView With {.DataContext = New MainViewModel}
    End If
    MyBase.OnFrameworkInitializationCompleted()
  End Sub

End Class