Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Namespace Views

  Public Partial Class MainWindow
    Inherits Window

    Public Sub New()
      InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
      AvaloniaXamlLoader.Load(Me)
'-:cnd:noEmit
#If DEBUG Then
      AttachDevTools()
#End If
'+:cnd:noEmit
    End Sub

  End Class

End Namespace