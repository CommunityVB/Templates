Imports Microsoft.Extensions.Hosting
Imports Microsoft.Extensions.Logging
Imports System.Threading

Public Class Worker
  Inherits BackgroundService

  Private ReadOnly m_logger As ILogger(Of Worker)

  Public Sub New(logger As ILogger(Of Worker))
    m_logger = logger
  End Sub

  Protected Overrides Async Function ExecuteAsync(stoppingToken As CancellationToken) As Task
    While Not stoppingToken.IsCancellationRequested
      If m_logger.IsEnabled(LogLevel.Information) Then
        m_logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now)
      End If
      Await Task.Delay(1000, stoppingToken)
    End While
  End Function

End Class