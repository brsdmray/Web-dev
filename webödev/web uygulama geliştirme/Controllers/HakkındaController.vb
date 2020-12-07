Imports System.Web.Mvc

Namespace Controllers
    Public Class HakkındaController
        Inherits Controller

        ' GET: Hakkında
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace