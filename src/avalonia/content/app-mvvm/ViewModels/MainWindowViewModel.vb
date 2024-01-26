Namespace ViewModels

  #If CommunityToolkitChosen Then
  Public Partial Class MainWindowViewModel
  #Else
  Public Class MainWindowViewModel
  #End If
    Inherits ViewModelBase
 
    Public ReadOnly Property Greeting As String = "Welcome to Avalonia!"

  End Class

End Namespace