Imports System

Module classwork4
    Sub Main(args As String())

        Dim q As Integer = 10
        Console.SetCursorPosition(q, 10)
        For j = 0 To 5

            For i As Integer = 0 To 10
                Console.Write("H")
            Next

            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 1)
        Next

    End Sub
End Module