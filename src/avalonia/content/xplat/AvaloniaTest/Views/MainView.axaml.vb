Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Namespace Views

  Public Partial Class MainView
    Inherits UserControl

    Public Sub New()
      InitializeComponent()
    End Sub

    Public Sub InitializeComponent()
      AvaloniaXamlLoader.Load(Me)
    End Sub

  End Class

End Namespace