Module Module1


    Function Fib(ByVal intNumber As Integer) As Integer
        If intNumber = 0 Then
            Return 1
        End If
    End Function

    Sub Main()

        Dim intNumber As Integer = 0

        Console.WriteLine("Enter A Number...")
        intNumber = CInt(Console.ReadLine())


    End Sub

End Module
