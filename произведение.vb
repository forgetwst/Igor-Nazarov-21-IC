Imports System
Imports System.Linq.Expressions

Module Program
    Sub Main(args As String())
        Dim C As Integer
        Dim Pr As Integer = 1
        Do
            Console.WriteLine("Введите множитель: ")
            C = Console.ReadLine()
            If C < Int32.MaxValue / Pr Then
                Pr = C * Pr
            Else
                Console.WriteLine("!Переполнение памяти!")
                Exit Do
            End If
        Loop Until C = 1
        Console.WriteLine("Произведение = {0}", Pr)
    End Sub
End Module

