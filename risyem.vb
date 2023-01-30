Module Program
    Private brush As Char = "0"c
    Sub Main(args As String(()

        Console.SetWindowPosition(100, 50)

        Hline(10, 5, 70)

        Console.WriteLine()

    End Sub

    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length
            Console.Write(brush)
        Next
    End Sub
    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length - 1
            Console.Write(brush)
            Console.SetCursorPosition(leftX, topY + i)
        Next
    End Sub

End Module
