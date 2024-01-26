Imports UIKit

Namespace iOS

  Public NotInheritable Class Application

    Public Shared Sub Main(args As String())
      ' if you want to use a different Application Delegate class from "AppDelegate"
      ' you can specify it here.
      UIApplication.Main(args, Nothing, GetType(AppDelegate))
    End Sub

  End Class

End Namespace