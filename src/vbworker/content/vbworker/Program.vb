Option Explicit On 
Option Strict On
Option Infer On

Imports Microsoft.Extensions.DependencyInjection
Imports Microsoft.Extensions.Hosting

Module Program

  Sub Main(args As String())

    Dim builder = Host.CreateApplicationBuilder(args)
    Dim serviceCollection = builder.Services.AddHostedService(Of Worker)

    Dim hoster = builder.Build()
    hoster.Run()

  End Sub

End Module