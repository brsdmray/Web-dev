Imports System.Web.Mvc

Namespace Controllers
    Public Class SharedController
        Inherits Controller

        ' GET: Shared
        Function _Layout() As ActionResult
            Return View()
        End Function
    End Class
End Namespace