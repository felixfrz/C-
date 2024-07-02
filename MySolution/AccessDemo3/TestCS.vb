Imports AcessDemo1


Public Class TestCS : Inherits Program

    Shared Sub Main()

        Dim obj As New TestCS() 'Creating an instance
        obj.Test3_Protected()
        obj.Test4_ProtecedInternal()
        obj.Test5_Public()

        Console.ReadLine()
    End Sub

End Class
