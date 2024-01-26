Imports Avalonia.Controls
Imports Avalonia.Controls.Templates
Imports AvaloniaAppTemplate.ViewModels

Public Class ViewLocator
  Implements IDataTemplate

  Public Function Build(data As Object) As Control Implements ITemplate(Of Object, Control).Build

    If data Is Nothing Then Return Nothing

    Dim name = data.[GetType]().FullName.Replace("ViewModel", "View", StringComparison.Ordinal)
    Dim dataType = Type.[GetType](name)

    If dataType IsNot Nothing Then
      Dim ctrl = CType(Activator.CreateInstance(dataType), Control)
      ctrl.DataContext = data
      Return ctrl
    End If

    Return New TextBlock With {.Text = "Not Found: " & name}

  End Function
  
  Public Function Match(data As Object) As Boolean Implements IDataTemplate.Match
    Return TypeOf data Is ViewModelBase
  End Function

End Class