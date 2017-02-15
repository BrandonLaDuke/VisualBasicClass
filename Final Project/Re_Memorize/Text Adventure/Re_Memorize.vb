Module Re_Memorize
    Dim playerName As String
    'Ferdinan
    'Johnny
    '
    Sub Main()
        Dim quitGame As Boolean = 0
        Console.WriteLine("The Year is 2086, Memories can be uploaded, downloaded, traded, and shared.")
        Console.WriteLine("It was all safe and secure, well so we thought. Two years ago a company by the name of Memorize, located in Neo Paris,")
        Console.WriteLine("created a network that allowed for the digitizing of human memories.")
        Console.WriteLine("Every thing seemed to work alright and be very benificial to the public. Untill things went wrong. Very wrong...")
        Console.WriteLine()
        Console.WriteLine("Press Any Key to continue.")
        Console.ReadKey()
        Console.WriteLine()
        Console.WriteLine()
        Dim play As Boolean = 0
        While play = 0
            Console.WriteLine()
            Console.WriteLine("Welcome to Re:Memorize")
            Threading.Thread.Sleep(2000)
            Console.WriteLine()
            Console.WriteLine("[1] Start  [2] Credits [3] Exit")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                GameStart()
            ElseIf start = "2" Then
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
        Console.Write(">>")
        Dim nameCor As Boolean = False
        Dim nameChk As Integer = 0
        playerName = Console.ReadLine()
        Console.WriteLine("You said your name is " + playerName + ". Correct?")
        Console.WriteLine("[1] That's Right [2] Nope, that's not right.")
        nameChk = Console.ReadLine()

        While nameCor = False
            If nameChk = 1 Then
                nameCor = True
            ElseIf nameChk = 2 Then
                GetName()
            Else
                nameCor = False
                Console.WriteLine("I did not understand your answer.")
            End If
            If nameCor = False Then
                Console.WriteLine("You said your name is " + playerName + ". Correct?")
                Console.WriteLine("[1] That's Right [2] Nope, that's not right.")
                nameChk = Console.ReadLine()
            End If
        End While
        Console.WriteLine("Well It's nice to meet you " + playerName + ".")
        Threading.Thread.Sleep(1000)
        Console.WriteLine("I will now tell you how to play.")
        Console.ReadKey()
        Console.Clear()
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
                    Console.WriteLine()
                    Console.WriteLine("Great!, Good Luck!")
                    Console.WriteLine()
                    Threading.Thread.Sleep(1500)
                    Console.Clear()
                    Threading.Thread.Sleep(1000)
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
                    Console.WriteLine()
                    Console.WriteLine("I don't understand what you meant by: " + numInput)
                    Console.WriteLine()
                    Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
                    numInput = ""
                    numInput = Console.ReadLine()
            End Select

        End While
        Choice = False
        numInput = ""


    End Sub

    Sub GetName()
        Dim nameCor As Boolean = False
        Dim nameChk As Integer = 0
        playerName = ""
        Console.WriteLine("I'm sorry, What's your name again?")
        Console.Write(">>")
        playerName = Console.ReadLine()
    End Sub

    Sub Instructions()
        Console.WriteLine()
        Console.WriteLine("------------Instructions------------")
        Console.WriteLine()
        Console.WriteLine("This game is played by answering questions by selecting a number option from the menu,")
        Console.WriteLine("and then pressing enter.")
        Console.WriteLine("There will also ocasionaly be an open ended question.")
        Console.WriteLine()
        Console.WriteLine("Do you understand this " + playerName + "?")
    End Sub

    Sub MainGame()
        'Start Chapter 0
        Chapter0()

    End Sub

    Sub Chapter0()
        Console.WriteLine("Voice: " + playerName + " Run! You got to get out of there! Quick!")
        Console.ReadKey()
        Console.WriteLine(playerName + ": Don't worry, I'll be fine. I'm almost there.")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("You run around a corner and get hit by a S.A.B.R.E. Force Agent")
        Console.WriteLine()
        Threading.Thread.Sleep(2000)
        Console.WriteLine("You blacked out...")
        Console.ReadKey()
        Console.WriteLine()
        Console.WriteLine(playerName + ": (Screaming In Pain)")
        Console.ReadKey()
        Console.WriteLine(playerName + "AHHHHHHH! AHHHHHHHH! AHHHHHHHHH!")
        Console.Clear()

        Console.ReadKey()
        Console.WriteLine("Machine shuts off...")
        Console.ReadKey()
        Console.WriteLine("Robotic Voice: Memory Erase complete.")
        Console.ReadKey()
        Console.WriteLine(playerName + ": (breathing heavy)")
        Console.ReadKey()
        Console.WriteLine("You realize you are laying in the center of a room.")
        Console.ReadKey()
        Console.WriteLine("A person approches you holding some files. There dressed in a doctor uniform maybe?")
        Console.ReadKey()
        Console.WriteLine("Stranger: What is your name?")
        Console.Write(">> ")
        Dim nameCheck As String
        nameCheck = Console.ReadLine()
        Dim i As Integer = 0
        If nameCheck = playerName Then
            i = 1
        End If
        While i = 0
            Console.WriteLine()
            Console.WriteLine("Use your name that you used at the start of the game: " + playerName)
            Console.WriteLine()
            Console.WriteLine("Stranger: What is your name?")
            Console.Write(">> ")
            nameCheck = ""
            nameCheck = Console.ReadLine()
            If nameCheck = playerName Then
                i = 1
            End If
        End While
        Console.WriteLine()
        Console.WriteLine("Stranger: What year is it?")
        Console.ReadKey()
        Console.WriteLine(playerName + ": I don't know")
        Console.ReadKey()
        Console.WriteLine("Stranger: What did you say your name was?")
        Console.ReadKey()
        Console.WriteLine(playerName + ": ... " + playerName + ".")
        Console.ReadKey()
        Console.WriteLine("Do you know where you are?")
        Dim localQ As String
        Console.Write(">>")
        localQ = Console.ReadLine()
        If localQ = "IDK" Or "I don't know" Or "idk" Or "i dont know" Or "I dont know" Or "here" Then
            Console.WriteLine()
            Console.WriteLine("Stranger: So you don't know.")
            Console.ReadKey()
            Console.WriteLine("Stranger: Very well.")
        ElseIf localQ = "" Then
            Console.WriteLine("Stranger: How do you know that?")
            Console.ReadKey()

        Else

        End If
    End Sub

    Sub Credits()
        Console.WriteLine("------------Credits------------")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Re:Memorize")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Written by Brandon LaDuke")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Programed by Brandon LaDuke")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Based on the Game 'Remember Me' by DontNod Entertainment. Published by Capcom")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Available for the PS3, Xbox 360 and PC")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("You can check out more of my work at: BrandonLaDuke.com")
        Console.WriteLine()
        Console.ReadKey()
        Console.WriteLine("Thank you for playing!")
        Dim creditTimer As Integer = 5
        While creditTimer > 0
            Threading.Thread.Sleep(1000)
            Console.Write(".")
            creditTimer = creditTimer - 1
        End While
        Console.Clear()
    End Sub
End Module