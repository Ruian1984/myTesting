﻿Module Module1


    Function Fib(ByVal intNumber As Integer) As Integer
        If intNumber <= 2 Then
            Return 1
        Else
            Return Fib(intNumber - 2) + Fib(intNumber - 1)
        End If
    End Function

    Sub FibSequence(ByVal intNumber As Integer)
        Dim str As String = ""
        For x As Integer = 1 To intNumber
            If x <= 2 Then
                str &= "1 "
            Else
                str &= Fib(x) & " "
            End If
        Next
        Console.WriteLine("Sequence is " & str)
    End Sub

    Sub Main()

        Dim intNumber As Integer = 0
        Dim choice As String = ""


        While choice.ToUpper <> "Q"
            Console.WriteLine("A. Display nth term of a fibonacci only")
            Console.WriteLine("B. Display fibonacci Sequence")
            Console.WriteLine("Q. Quit")
            Console.WriteLine("")
            choice = Console.ReadLine()

            If choice.ToUpper = "A" Then
                Console.WriteLine("Enter A Number...")
                intNumber = CInt(Console.ReadLine())
                Console.WriteLine(" Ang ika " & intNumber & " sa fibonacci is = " & Fib(intNumber))
            ElseIf choice.ToUpper = "B" Then
                Console.WriteLine("Enter A Number...")
                intNumber = CInt(Console.ReadLine())
                FibSequence(intNumber)
            End If
        End While



        


        '        Console.ReadLine()



    End Sub

End Module
