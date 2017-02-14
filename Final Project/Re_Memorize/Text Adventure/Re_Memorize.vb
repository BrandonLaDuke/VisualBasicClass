Module Re_Memorize
    Dim playerName As String
    Sub Main()
        Dim quitGame As Boolean = 0
        Console.WriteLine("The Year is 2086, Memories can be uploaded, downloaded, traded, and shared.")
        Console.WriteLine("It was all safe and secure, well so we thought. Two years ago a company by the name of Memorize, located in Neo Paris, created a network that allowed for the digitising of human memories.")
        Console.WriteLine("Every thing seemed to work alright and be very benificial to the public. Untill things went wrong. Very wrong...")
        Threading.Thread.Sleep(13000)
        Console.WriteLine()
        Console.WriteLine()
        Dim play As Boolean = 0
        While play = 0
            Console.WriteLine("Welcome to Re:Memorize")
            Threading.Thread.Sleep(3000)
            Console.WriteLine()
            Console.WriteLine("[1] Start  [2] Credits [3] Exit")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                GameStart()
            ElseIf start = "2" Then
                Console.WriteLine("---------- Credits ----------")
                Credits()
            ElseIf start = "3" Then
                Console.WriteLine("Thank's for playing! Please comeback and visit!")
                Threading.Thread.Sleep(5000)
                Exit Sub
            Else
                Console.WriteLine("I don't understand what you want me to do.")
            End If
        End While 'Game Start Loop

    End Sub

    Sub GameStart()
        Console.WriteLine()
        Console.WriteLine("Hello, stranger. What's your name?")
        playerName = Console.ReadLine()
        Console.WriteLine("Well It's nice to meet you " + playerName + ".")
        Threading.Thread.Sleep(1000)
        'Get Instructions from instructions module
        Instructions()
        Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
        Dim numInput As String
        numInput = Console.ReadLine()
        Dim Choice As Boolean = False
        While Choice = False
            Console.WriteLine("")


            Select Case numInput
                Case "1"
                    'got it and start main game
                    Choice = True
                    MainGame()
                    Exit Select
                Case "2"
                    'Re-explain instructions
                    Instructions()
                    Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
                    numInput = ""
                    numInput = Console.ReadLine()
                    Exit Select
                Case Else
                    Console.WriteLine("I don't understand what you meant by: " + numInput)
                    numInput = ""
                    numInput = Console.ReadLine()
            End Select

        End While
        Choice = False
        numInput = ""


    End Sub
    Sub Instructions()
        Console.WriteLine("I am VBasic this game will take you on a journey to meet a few of my friends.")
        Console.WriteLine("You will be able to choose from your Voice Control Panel (VCP) to choose what you want to say.")
        Console.WriteLine("To do this you will choose a number from the VCP.")
        Console.WriteLine("Do you understand this " + playerName + "?")
    End Sub

    Sub MainGame()
        Console.WriteLine("Hello from the min game!")
    End Sub

    Sub Credits()
        Console.WriteLine("Credits")
    End Sub
End Module
