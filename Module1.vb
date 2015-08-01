Module Module1


    Function Fib(ByVal intNumber As Integer) As Integer
        If intNumber <= 2 Then
            Return 1
        Else
            Return Fib(intNumber - 2) + Fib(intNumber - 1)
        End If
    End Function

    Sub Main()

        Dim intNumber As Integer = 0

        Console.WriteLine("Enter A Number...")
        intNumber = CInt(Console.ReadLine())

        Console.WriteLine(" Ang ika " & intNumber & " sa fibonacci is = " & Fib(intNumber))
        Console.ReadLine()


    End Sub

End Module
