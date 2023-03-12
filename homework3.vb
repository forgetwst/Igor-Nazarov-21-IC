Imports System

Module homework3
    Sub Main(args As String())
        Dim Q As String
        Dim W, space, number, other, high, low
        Console.Write("я умею считать количество символов. Напишите предложение:")
        Q = Console.ReadLine()

        For W = 0 To Q.Length - 1
            Select Case Asc(Q.Chars(W))

                Case 32
                    space += 1

                Case 97 To 122
                    low += 1

                Case 65 To 90
                    high += 1

                Case 48 To 57
                    number += 1

                Case Else
                    other += 1
            End Select
        Next

        Console.WriteLine("Пробелы = {0} ", space)
        Console.WriteLine("Цифры = {0} ", number)
        Console.WriteLine("Большие буквы = {0} ", high)
        Console.WriteLine("Маленькие буквы = {0} ", low)
        Console.WriteLine("Другие символы = {0} ", other)
    End Sub
End Module