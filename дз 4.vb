Imports System

Module Program
    Sub Main(args As String())

        Dim S As String
        Dim counter As Integer = 0
        Dim Vowels As Integer = 0
        Dim consonants As Integer = 0
        Dim Symbols As Integer = 0
        Dim marks As Integer = 0
        Dim numbers As Integer = 0

        Console.WriteLine("Введите строчку!")
        S = Console.ReadLine()

        For i = 0 To S.Length - 1
            Console.Write(S.Chars(i))
            Console.WriteLine(Asc(S.Chars(i)))

            Select Case S
                Case S.Chars(i)
                    Symbols = Symbols + 1
                Case Asc(S.Chars(i)) = 32
                    counter = counter + 1
                Case Asc(S.Chars(i)) = 97, 101, 105, 111, 117, 121
                    Vowels = Vowels + 1
                Case Asc(S.Chars(i)) = 65 To 79, 58 To 64, 123 To 126
                    marks = marks + 1
                Case Asc(S.Chars(i)) = 48 To 57
                    numbers = numbers + 1
                Case Else
                    consonants = consonants + 1
            End Select
        Next
        Console.WriteLine("В строке {0} пробелов", counter)
        Console.WriteLine("{0} гласных", Vowels)
        Console.WriteLine("{0} согласных", consonants)
        Console.WriteLine("{0} знаков препинания и др. символов", marks)
        Console.WriteLine("{0} цифер", numbers)
        Console.WriteLine("Всего в строке {0} символов", consonants)

    End Sub
End Module
