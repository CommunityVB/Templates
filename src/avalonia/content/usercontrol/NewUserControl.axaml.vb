Imports Avalonia.Controls
Imports Avalonia.Markup.Xaml

Public Partial Class NewUserControl
  Inherits UserControl

  Public Sub New()
    InitializeComponent()
  End Sub

  Public Sub InitializeComponent()
    AvaloniaXamlLoader.Load(Me)
  End Sub

End Class