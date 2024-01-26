Imports Foundation
Imports UIKit
Imports Avalonia
Imports Avalonia.Controls
Imports Avalonia.iOS
Imports Avalonia.Media
Imports Avalonia.ReactiveUI

Namespace iOS

  ' The UIApplicationDelegate for the application. This class is responsible for launching the 
  ' User Interface of the application, as well as listening (and optionally responding) to 
  ' application events from iOS.
  <Register("AppDelegate")>
  Public Partial Class AppDelegate
    Inherits AvaloniaAppDelegate(Of App)

    Protected Overrides Function CustomizeAppBuilder(builder As AppBuilder) As AppBuilder
      Return MyBase.CustomizeAppBuilder(builder).WithInterFont().UseReactiveUI()
    End Function

  End Class

End Namespace