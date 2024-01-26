Imports Avalonia
Imports Avalonia.Controls.ApplicationLifetimes
#If CommunityToolkitChosen Then
Imports Avalonia.Data.Core
Imports Avalonia.Data.Core.Plugins
#End If
Imports Avalonia.Markup.Xaml
Imports AvaloniaAppTemplate.ViewModels
Imports AvaloniaAppTemplate.Views

Public Class App
  Inherits Application

  Public Overrides Sub Initialize()
    AvaloniaXamlLoader.Load(Me)
  End Sub

  Public Overrides Sub OnFrameworkInitializationCompleted()

    If TypeOf ApplicationLifetime Is IClassicDesktopStyleApplicationLifetime Then
#If CommunityToolkitChosen Then
      ' Line below is needed to remove Avalonia data validation.
      ' Without this line you will get duplicate validations from both Avalonia and CT
#If AvaloniaStableChosen Then
      ExpressionObserver.DataValidators.RemoveAt(0)
#Else
      ExpressionObserver.DataValidators.RemoveAll(Function(x) TypeOf x Is DataAnnotationsValidationPlugin)
#End If      
#End If    
      CType(ApplicationLifetime, IClassicDesktopStyleApplicationLifetime).MainWindow = New MainWindow With {.DataContext = New MainWindowViewModel()}
    End If

    MyBase.OnFrameworkInitializationCompleted()
    
  End Sub

End Class