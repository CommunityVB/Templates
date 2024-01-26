Imports Avalonia.Controls
Imports Avalonia.Controls.Templates
Imports AvaloniaTest.ViewModels

Public Class ViewLocator
  Implements IDataTemplate

  Public Function Build(data As Object) As Control Implements ITemplate(Of Object, Control).Build

    If data Is Nothing Then
      Return Nothing
    End If

    Dim name = data.[GetType]().FullName.Replace("ViewModel", "View", StringComparison.Ordinal)
    Dim type1 = Type.[GetType](name)

    If type1 IsNot Nothing Then
      Return CType(Activator.CreateInstance(type1), Control)
    End If

    Return New TextBlock With {.Text = "Not Found: " & name}

  End Function

  Public Function Match(data As Object) As Boolean Implements IDataTemplate.Match
    Return TypeOf data Is ViewModelBase
  End Function

End Class