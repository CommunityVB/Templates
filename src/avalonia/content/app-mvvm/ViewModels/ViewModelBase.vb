#If CommunityToolkitChosen Then
Imports CommunityToolkit.Mvvm.ComponentModel
#ElseIf ReactiveUIToolkitChosen Then
Imports ReactiveUI
#End If

Namespace ViewModels

  Public Class ViewModelBase
#If CommunityToolkitChosen Then
    Inherits ObservableObject
#ElseIf ReactiveUIToolkitChosen Then
    Inherits ReactiveObject
#End If

  End Class

End Namespace