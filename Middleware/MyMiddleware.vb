Imports System.Runtime.CompilerServices
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Http

Public Class $fileinputname$Middleware

    Private ReadOnly _next As RequestDelegate

    Public Sub New([next] As RequestDelegate)
        _next = [next]
    End Sub

    Public Function Invoke(httpContext As HttpContext) As Task
        ' Middleware logic goes here
        Return _next(httpContext)
    End Function
End Class

Public Module $fileinputname$MiddlewareExtensions
    <Extension()>
    Public Function Use$fileinputname$(builder As IApplicationBuilder) As IApplicationBuilder
        Return builder.UseMiddleware(Of $fileinputname$Middleware)()
    End Function
End Module
