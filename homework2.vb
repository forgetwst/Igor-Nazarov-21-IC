Imports System
Module homework2
    Sub Main(args As String())
        Dim N As Integer, F As Integer = 1
        Console.Write("я считаю произведение чисел! введите число:")
        Do
            N = Console.ReadLine
            F = F * N
        Loop Until N = 1
        Console.WriteLine("произведение = {0}", F)

    End Sub
End Module
