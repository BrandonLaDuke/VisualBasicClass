Module Module1

    Sub Main()
        Dim quitGame As Boolean = 0
        Console.WriteLine("Hello, Welcome to the Brandon LaDuke's Text Adventure Game!")

        Dim play As Boolean = 0
        While play = 0
            Console.WriteLine("[1] Start  [2] Exit")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                GameStart()
            ElseIf start = "2" Then
                Console.WriteLine("Sorry to see you go so soon! Please comeback and visit!")
                Threading.Thread.Sleep(5000)
                Exit Sub
            Else
                Console.WriteLine("I don't understand what you want me to do.")
            End If
        End While 'Game Start Loop

    End Sub

    Sub GameStart()
        Console.WriteLine()
        Console.WriteLine("Hi from Game Start!")
    End Sub

End Module
