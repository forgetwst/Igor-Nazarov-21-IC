Imports System

Module Program

    Sub Main(args As String())
        Dim n As Integer, Pr As Long = 1

        Console.WriteLine("Привет, я перемножаю числа! Хочешь что-нибудь умножить?")

        Do
            n = Console.ReadLine()
            Pr = Pr * n
            Console.WriteLine("Произведение чисел=", Pr)
        Loop Until n = 1
    End Sub
End Module