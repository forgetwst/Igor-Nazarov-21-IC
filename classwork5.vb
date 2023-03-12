Imports System

Module classwork5
    Private brush As Char = "0"c

    Sub Main(args As String())
        FilRect(10, 5, 70, 35)
    End Sub

    Sub Hline(leftX As Byte, topY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, topY)
        For i = 1 To length
            Console.Write(brush)
        Next
    End Sub

    Sub FilRect(leftX As Byte, topY As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftX, topY)
        For j = 0 To height - 1
            Hline(leftX, topY + j, width)
        Next
    End Sub

End Module