Module Program
    Sub Main(args As String())
        Dim left As Integer = 20
        Console.SetCursorPosition(l, 10)
        For j = 0 To 5
            For i As Integer = 0 To 10
                Console.Write("H")
            Next
            Console.SetCursorPosition(l, Console.GetCursorPosition().Top + 1)
        Next
    End Sub
End Module
