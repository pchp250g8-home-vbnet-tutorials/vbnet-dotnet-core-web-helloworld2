Imports System
Imports Microsoft.AspNetCore.Builder
Imports Microsoft.AspNetCore.Http

Module Program
    Sub Main(args As String())
        Dim builder = WebApplication.CreateBuilder(args)
        Dim app = builder.Build()
        app.UseDefaultFiles()
        app.UseStaticFiles()
        app.Map("/HelloWorld", Async Function(context)
                                   context.Response.ContentType = "text/html"
                                   Await context.Response.WriteAsync($"Hello, World!!!</br>")
                                   Await context.Response.WriteAsync($"System info:{Environment.OSVersion}</br>")
                                   Await context.Response.WriteAsync($"Platform info:{Environment.Version}</br>")
                                   Await context.Response.WriteAsync($"Today is:{DateTime.Now}</br>")
                                   Await context.Response.WriteAsync($"<p><a href=""index.html"">Simple Html Page</a></br>")
                               End Function)

        app.Run()
    End Sub
End Module
