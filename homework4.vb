Imports System

Module homework4
    Private brush As Char = "0"c
    Dim num01 As Byte, num03 As Byte
    Dim num02 As Integer, x As Integer, y As Integer, x1 As Integer, y1 As Integer
    Sub Main(args As String())

        Console.WriteLine("1 - гор. линия, 2 - верт. линия, 3 - закр. куб, 4 - пуст. куб, 5 - сетка 6 - лестница, 7-орнамент")
        num01 = Console.ReadLine


        Select Case num01
            Case 1
                If num03 = 1 Then
                    horizon(x, y, x1)
                Else
                    horizon(5, 5, 15)
                End If

            Case 2
                If num03 = 1 Then
                    vertically(x, y, x1)
                Else
                    vertically(5, 5, 15)
                End If

            Case 3
                If num03 = 1 Then
                    closcube(x, y, x1, y1)
                Else
                    closcube(5, 5, 50, 25)
                End If

            Case 4
                If num03 = 1 Then
                    empcube(x, y, x1, y1)
                Else
                    empcube(10, 10, 20, 10)
                End If

            Case 5
                If num03 = 1 Then
                    grid(x, y, x1, y1)
                Else
                    grid(10, 10, 40, 7)
                End If

            Case 6
                stairs(10, 5, 30)

            Case 7
                ornament(10, 5, 30)

        End Select
    End Sub

    Sub horizon(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)

        For i = 1 To length
            Console.Write(brush)
        Next

    End Sub
    Sub vertically(leftx As Byte, topy As Byte, length As Byte)
        Console.SetCursorPosition(leftx, topy)

        For i = 1 To length
            Console.Write(brush)
            Console.SetCursorPosition(leftx, topy + i)
        Next

    End Sub
    Sub closcube(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)

        For j = 1 To height
            For i = 1 To width
                Console.Write(brush)
            Next
            Console.SetCursorPosition(leftx, topy + j)
        Next

    End Sub
    Sub empcube(leftx As Byte, topy As Byte, width As Byte, height As Byte)
        Console.SetCursorPosition(leftx, topy)

        For i = 1 To width
            Console.Write(brush)
        Next

        For j = 1 To height - 3
            Console.SetCursorPosition(leftx, topy + j)
            Console.Write(brush)
            Console.SetCursorPosition(leftx + width - 1, topy + j)
            Console.WriteLine(brush)
        Next

        Console.SetCursorPosition(leftx, topy + height - 2)
        For i = 1 To width
            Console.Write(brush)
        Next

    End Sub
    Sub grid(leftx As Byte, topy As Byte, width As Integer, kletki As Byte)
        Console.SetCursorPosition(leftx, topy)
        For i = 2 To width
            Console.Write(brush)
        Next

        For i = 1 To 8
            horizon(2 + 7, 2 + i * 3, 50)
            vertically(2 + 7 * i, 2 + 3, 27)
        Next

        Console.SetCursorPosition(10, 10)
    End Sub

    Sub stairs(leftX As Byte, topY As Byte, length As Byte)

        For i = 1 To 46
            horizon(2, i, 2 * i)
        Next
    End Sub

    Sub ornament(leftX As Byte, topY As Byte, length As Byte)

        For j = 1 To 5
            For i = 1 To 5
                closcube(7 + 10 * i, 5 + j * 10, 7, 7)
            Next
        Next
    End Sub

End Module
