﻿Module Re_Memorize
    Dim playerName As String
    Dim genRef As String
    Dim year As Integer = 2086
    Dim cWhile As Boolean = True
    Dim memoryHunter As Boolean = False
    Dim leaper As Boolean = False
    'Ferdinan - Doctor
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
        Console.Clear()
        Dim play As Boolean = 0
        While play = 0
            Console.WriteLine()
            Console.WriteLine("Welcome to Re:Memorize")
            Threading.Thread.Sleep(1000)
            Console.WriteLine()
            Console.WriteLine("[1] Start  [2] Credits [3] Exit")
            Console.Write("$")
            Dim start As String = Console.ReadLine()
            If start = "1" Then
                Console.WriteLine("GameStart")
                GameStart()
            ElseIf start = "2" Then
                Credits()
            ElseIf start = "3" Then
                Console.WriteLine("Thank's for playing! Please comeback and visit!")
                Threading.Thread.Sleep(3000)
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
        Console.Write("$")
        nameChk = Console.ReadLine()
        Chapter0_2()
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
                Console.Write("$")
                nameChk = Console.ReadLine()
            End If
        End While
        Console.WriteLine("Well It's nice to meet you " + playerName + ".")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("Are you Male or Female")
        Console.WriteLine("[1] Male  [2] Female")
        Console.Write("$")
        Dim genSwitch As Boolean
        genSwitch = Console.ReadLine
        If genSwitch = 1 Then
            genRef = "him"
        Else
            genRef = "her"
        End If
        Threading.Thread.Sleep(1000)
        Console.WriteLine("I will now tell you how to play.")
        Console.Write("*")
        Console.ReadKey()
        Console.Clear()
        Threading.Thread.Sleep(500)
        'Get Instructions from instructions module
        Instructions()
        Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
        Console.Write("$")
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
                    Console.Write("$")
                    numInput = ""
                    numInput = Console.ReadLine()
                    Exit Select
                Case Else
                    Console.WriteLine()
                    Console.WriteLine("I don't understand what you meant by: " + numInput)
                    Console.WriteLine()
                    Console.WriteLine("[1] Yes I got it. [2] Could you repeat that?")
                    Console.Write("$")
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
        Console.WriteLine("There will also ocasionaly be open ended questions.")
        Console.WriteLine()
        Console.WriteLine("Symbols you will find that you will need to know about:")
        Console.WriteLine("   >>   Is a open ended responce marker. When you see this you can type a responce.")
        Console.WriteLine()
        Console.WriteLine("   $    Is a simple question marker. Here you select a responce from the prompt.")
        Console.WriteLine()
        Console.WriteLine("   *    If you see this marker you press the Enter button to continue.")
        Console.WriteLine()
        Console.WriteLine("Do you understand this " + playerName + "?")
        Console.Write("$")
    End Sub

    Sub MainGame()
        'Start Chapter 0
        Chapter0()

    End Sub

    Sub Chapter0()
        Console.WriteLine("Voice: " + playerName + " Run! You got to get out of there! Quick!")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine(playerName + ": Don't worry, I'll be fine. I'm almost there.")
        Console.WriteLine()
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("You run around a corner and get hit by a S.A.B.R.E. Force Agent")
        Console.WriteLine()
        Threading.Thread.Sleep(2000)
        Console.WriteLine("You blacked out...")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine()
        Console.WriteLine(playerName + ": (Screaming In Pain)")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine(playerName + "AHHHHHHH! AHHHHHHHH! AHHHHHHHHH!")
        Console.Write("*")
        Console.ReadKey()
        Console.Clear()
        Console.WriteLine("Machine shuts off...")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("Robotic Voice: Memory Erase complete.")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine(playerName + ": (breathing heavy)")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("You realize you are laying in the center of a room.")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("A person approches you holding some files. There dressed in a doctor uniform maybe?")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("Stranger: What is your name?")
        Console.Write(">> ")
        Dim nameCheck As String
        nameCheck = Console.ReadLine()
        Dim i As Integer = 0

        'Check if you remember your own name.
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
        Console.Write(">> ")
        Dim vYear As Integer
        vYear = Console.ReadLine()
        If vYear = year Then
            Console.WriteLine("Stranger: Huh..., Dr Ferdnan this paicent is showing resistance.")
            Console.WriteLine("*")
            Console.ReadKey()
            Console.WriteLine("Dr. Ferdnan: Okay, send " + genRef + " to me. I'll take care of " + genRef + " myself.")
            Console.WriteLine("*")
            Console.ReadKey()
            Console.WriteLine("Stranger: Alright. As you wish.")
            Console.WriteLine("*")
            Console.ReadKey()
            Console.WriteLine("Stranger wallks away leaving you alone.")
            Console.Write("*")
            Console.WriteLine()
            Console.ReadKey()
        Else
            nameCheck = ""
            Console.WriteLine("Stranger: What did you say your name was?")
            Console.Write(">>")
            i = 0
            If nameCheck = playerName Then
                i = 1
            End If
            While i = 0
                Console.WriteLine()
                Console.WriteLine("Use your name that you used at the start of the game: " + playerName)
                Console.WriteLine()
                Console.WriteLine("Stranger: What did you say your name was?")
                Console.Write(">> ")
                nameCheck = ""
                nameCheck = Console.ReadLine()
                If nameCheck = playerName Then
                    i = 1
                End If
            End While

            Console.WriteLine("Stranger: Do you know where you are?")
            Console.Write("*")
            Console.ReadKey()
            Console.WriteLine(playerName + ": I don't know")
            Console.Write("*")
            Console.ReadKey()
            Console.WriteLine("Stranger: We'll get those last few memories scraped away soon.")
            Console.Write("*")
            Console.ReadKey()
            Console.WriteLine("Stranger wallks away leaving you alone.")
            Console.Write("*")
            Console.WriteLine()
            Console.ReadKey()
        End If
        Chapter0_1()
        Chapter0_2()
    End Sub

    Sub Chapter0_1()
        Console.WriteLine(playerName + ": Get up " + playerName + ".")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("A flying robot approches you,")
        Console.Write("*")
        Console.ReadKey()
        Console.WriteLine("and scans you with some sort of laser.")
        Console.Write("*")
        Console.ReadKey()
        Dim forRobot As Boolean = False
        While forRobot = False
            Console.WriteLine("Robot: Please step forward.")
            Console.WriteLine("")
            Console.WriteLine("-- Start walking forward? --")

            Console.WriteLine("")
            Console.WriteLine("[1] Walk Forward  [2] Look around  [3] Do nothing")
            Console.Write(">> ")
            Dim pathChoice1 As Integer = 0
            pathChoice1 = Console.ReadLine()
            If pathChoice1 = 1 Then
                forRobot = True
            ElseIf pathChoice1 = 2 Then
                'Look Around
                Console.WriteLine("You look around,")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("In front of you is a glowing hallographic orange path that leads down a hallway.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("To your left is a solid white wall with futuristic style lights decorating the edges.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("You look behind you but it's just another wall.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("Robot: Please step forward.")
                Console.Write("*")
                Console.ReadKey()
                Console.WriteLine("To your right, you see through a pane of glass some people in the same uniform that the other guy was in.")
                Console.WriteLine("They appear to be talking about something.")
            ElseIf pathChoice1 = 3 Then
                Console.WriteLine("You just stared at the robot...")
                Console.Write("*")
                Console.ReadKey()
            Else
                Console.WriteLine("I did not understand that command.")
            End If
        End While
        Console.WriteLine()
    End Sub

    Sub Chapter0_2()
        Console.WriteLine("Robot: Right this way")
        Console.WriteLine("*")
        Console.ReadLine()
        Console.WriteLine("Walking forward...")
        Dim counter As Integer
        For counter = 1 To 40
            Console.Write(". ")
            Threading.Thread.Sleep(600)

            If counter = 7 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: #$%&*$*^(^%$")
                Console.WriteLine("[1] Hello...?  [2] ...")
                Console.Write("$")
                Console.ReadLine() 'Does not take input. This conversation does not effect the story and will happen no matter what.

            ElseIf counter = 13 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: C$n 7o6  Hr4e m3(")
                Console.WriteLine("[1] Hello....?  [2] ...Someone there?  [3] ...")
                Console.Write("$")
                Console.ReadLine()

            ElseIf counter = 20 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: Can you hear me?")
                Threading.Thread.Sleep(200)
                Dim hearL As Boolean = False
                Dim hear As String = ""
                While hearL = False
                    hear = ""
                    Console.WriteLine(playerName + ". Can you hear me?")
                    Console.WriteLine("[1] ...Yes...  [2] ...")
                    Console.Write("$")
                    hear = Console.ReadLine()
                    If hear = "1" Then
                        hearL = True
                    End If
                End While

            ElseIf counter = 25 Then
                Console.WriteLine("")
                Console.WriteLine("Unknown: Good, listen.")
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine("Unknown: Their about to wipe your brain. If you want to live, you need to listen to me.")
                'Start first story arc choice
                Console.Write("*")
                Console.ReadLine()
                Console.WriteLine()
                Dim hearL As Boolean = False
                Dim hear As String = ""
                While hearL = False
                    Console.WriteLine("[1] Okay...  [2] No...")
                    Console.Write("$")
                    hear = Console.ReadLine()
                    If hear = "1" Then
                        Console.WriteLine("Unknown: Be ready to move when I give the word.")
                        MemoryHunter = True
                        hearL = True
                    ElseIf hear = "2" Then
                        Console.WriteLine("Unknown: You have got to believe me. You will not live if you don't trust me here.")
                        hearL = True
                    Else
                        Console.WriteLine("Invalid command")
                    End If
                End While

            ElseIf counter = 30 Then
                If memoryHunter = False Then
                    Dim hear As String = ""
                    Dim hearL As Boolean = False
                    While hearL = False
                        Console.Write("$")
                    Console.WriteLine("[1] Why should I trust you?  [2] I don't trust you. Leave me alone.")
                    hear = Console.ReadLine()
                        If hear = "1" Then
                            Console.WriteLine("Unknown: Because you will cease to exist.")
                        ElseIf hear = "2" Then
                            Console.WriteLine("Unknown: Guess your too far gone to help. This was your decision.")
                            leaper = True
                        Else
                            Console.WriteLine("Invalid command")
                        End If
                    End While
                End If
            End If
        Next
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