Module Module1
    Sub Main()
        Dim conTit As String
        conTit = "Murder Mystery V1.0"
        Console.Title = conTit
        Console.WriteLine(ScriptEngineMajorVersion & "-" & ScriptEngineBuildVersion)
        Threading.Thread.Sleep(500)
        Console.Clear()
        openingStage()
    End Sub
End Module

Module mainStory

    Dim name As String

    Sub openingStage()

        Console.ForegroundColor = ConsoleColor.DarkMagenta

        Console.WriteLine("-=====================================================-")
        Console.WriteLine("-================== Murder Mystery ===================-")
        Console.WriteLine("-=====================================================-")
        Threading.Thread.Sleep(2000)

        Console.Clear()
        nameCorrect()

    End Sub
    Sub nameCorrect()
        Dim selection As Integer
        Console.ForegroundColor = ConsoleColor.DarkBlue

        Console.WriteLine("Hello there, what is your name?")
        name = Console.ReadLine
        Console.WriteLine("Do you wish to continue with this name?")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")
        selection = Console.ReadLine
        If selection = 1 Then
            Console.WriteLine("Ahh. Hello " & name & ", we have a case for you. It is a murder case, with the death of Barack Obama.")
            startGamer()
        Else
            Console.Clear()
            nameCorrect()

        End If
    End Sub

    Sub startGamer()
        Dim selection As Integer
        Console.WriteLine("Will you help us, " & name & "?")
        Console.WriteLine("1. Yes")
        Console.WriteLine("2. No")
        selection = Console.ReadLine

        If selection = 1 Then

            Console.ForegroundColor = ConsoleColor.Yellow

            Console.WriteLine("I knew you had it in you! Let us get the list of suspects.")
            Threading.Thread.Sleep(3000)
            Console.Clear()
            suspects()
        Else
            Threading.Thread.Sleep(500)
            Console.Clear()
            restartQuitA()
        End If
    End Sub

    Sub suspects()

        Dim suspectPick As Integer

        Console.ForegroundColor = ConsoleColor.Yellow

        Console.WriteLine("This is the list of suspects so far:")
        Console.WriteLine("Please select a number to view their alibi:")
        Console.WriteLine("1. David Cameron")
        Console.WriteLine("2. Brendon Urie")
        Console.WriteLine("3. Donald Trump")
        Console.WriteLine("4. Hatsune Miku")
        Console.WriteLine("5. Kazuto Kirigaya")
        Console.WriteLine("Press 6 (or higher) to continue and list the suspects you'd like to bring in and question.")
        suspectPick = Console.ReadLine

        If suspectPick = 1 Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("I was at Number 10 Downing Street, adressing the whole of the UK, on TV! How could I kill someone with a M1911, when the whole of England, Wales and Scotland can confirm I was on TV 10 minutes after the killing!")
            Threading.Thread.Sleep(4000)
            Console.Clear()
            suspects()
        ElseIf suspectPick = 2 Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("I was busy recording a song for 'Panic! At The Disco', my producer can confirm this.")
            Threading.Thread.Sleep(4000)
            Console.Clear()
            suspects()
        ElseIf suspectPick = 3 Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("I was in America, I must have been, how could I be in England when I have to be in America, campagning")
            Threading.Thread.Sleep(4000)
            Console.Clear()
            suspects()
        ElseIf suspectPick = 4 Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("I was on the radio in Japan, all my fans can prove it!")
            Threading.Thread.Sleep(4000)
            Console.Clear()
            suspects()
        ElseIf suspectPick = 5 Then
            Console.Clear()
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("I was playing ALO (ALfhiem Online). The game records can confirm this.")
            Threading.Thread.Sleep(4000)
            Console.Clear()
            suspects()
        Else
            Threading.Thread.Sleep(1000)
            Console.Clear()
            suspectQuestingStart()


        End If

    End Sub

    Sub suspectQuestingStart()

        Dim suspectsIn As Integer
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Blue

        Console.WriteLine("Please input the numbers of the Suspects (PICK TWO) you'd wish to bring in for questioning.")
        Console.WriteLine("Type '0' to return to the suspect list and evidence list.")
        Console.WriteLine("Type the numbers of the suspects in order and as one whole number ('67' if suspect numbers 6/7 existed)")

        suspectsIn = Console.ReadLine

        If suspectsIn = 0 Then
            Threading.Thread.Sleep(500)
            Console.Clear()
            suspects()
        ElseIf suspectsIn = 13 Or 31 Then
            Threading.Thread.Sleep(1000)
            Console.Clear()
            questioningExtended()
        Else
            Console.WriteLine("These numbers you have put in are either wrong or make no sense.")
            restartQuitB()

        End If

    End Sub

    Sub questioningExtended()
        Dim questionPerson As Integer
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("So, we have Donald Trump and David Cameron")
        Console.WriteLine("Who would you like to question first?")
        Console.WriteLine("1. David Cameron")
        Console.WriteLine("2. Donald Trump")
        questionPerson = Console.ReadLine

        If questionPerson = 1 Then
            Console.WriteLine("Right, we'll bring him to the Questioning Room now!")
            Threading.Thread.Sleep(3000)
            Console.Clear()
            davidBeforeTrump()
        Else
            Console.WriteLine("Right, we'll bring him to the Questioning Room as soon as possible!")
            Threading.Thread.Sleep(3000)
            Console.Clear()
            trumpBeforeDavid()
        End If

    End Sub

    Sub davidBeforeTrump()
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("How do you know about the weapon that killed Barack Obama, the M1911 and also, how do you know of the time of death?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("I am the Prime Minister of the United Kingdom, how would I NOT know about this! I'm leaving!")
        Threading.Thread.Sleep(10000)
        Console.Clear()
        trumpAfterDavid()
    End Sub

    Sub trumpAfterDavid()

        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Well, that was just a bit suspicious, I'll get Donald Trump for you!")
        Threading.Thread.Sleep(3000)
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("How come, Donald, no one prove you were in the US?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Because I was in my office... Check my phone logs! Well, I'll be off then?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("Yes, you may leave.")
        Threading.Thread.Sleep(10000)
        Console.Clear()
        bringInandArrest()

    End Sub



    Sub trumpBeforeDavid()

        Console.Clear()
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("How come, Donald, no one prove you were in the US?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("Because I was in my office... Check my phone logs! Well, I'll be off then?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("Yes, you may leave.")
        Threading.Thread.Sleep(10000)
        Console.Clear()
        davidAfterTrump()
    End Sub
    Sub davidAfterTrump()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("Not TOO suspicious, lets ask David!")
        Threading.Thread.Sleep(3000)

        Console.ForegroundColor = ConsoleColor.Magenta
        Console.WriteLine("How do you know about the weapon that killed Barack Obama, the M1911 and also, how do you know of the time of death?")
        Threading.Thread.Sleep(2000)
        Console.ForegroundColor = ConsoleColor.Yellow
        Console.WriteLine("I am the Prime Minister of the United Kingdom, how would I NOT know about this! I'm leaving!")
        Threading.Thread.Sleep(10000)
        Console.Clear()
        bringInandArrest()
    End Sub
    Sub bringInandArrest()
        Dim Arrest As Integer

        Console.WriteLine("If you don't want to look at the text logs again, it's time to deside who to arrest:")
        Console.WriteLine("0. Return to Text Logs")
        Console.WriteLine("1. Donald Trump")
        Console.WriteLine("2. David Cameron")

        Arrest = Console.ReadLine
        If Arrest = 0 Then
            davidBeforeTrump()
        ElseIf Arrest = 1 Then
            QuitRestartC()
        Else
            Console.Clear()
            runCompleteGame()
        End If
    End Sub

    Sub runCompleteGame()

        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("Congratulations on catching the Murderer! - David Cameron")
        Console.WriteLine("If you would like to add to this Program - before the re-release as a 'nice' program - please go to:")
        Console.WriteLine("https://github.com/Visionary-Technologies/Vision-of-the-Future/pulls")
        Threading.Thread.Sleep(3000)
        quitFinish()
    End Sub
End Module

Module quitRestart

    Sub restartQuitA()
        Dim selection As Integer
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkRed

        Console.WriteLine("Ahh, you don't have it in you.")
        Console.WriteLine("Please enter what you would like to do:")
        Console.WriteLine("1. Restart the 'Murder Mystery'")
        Console.WriteLine("2. Quit the 'Murder Mystery'")
        selection = Console.ReadLine
        If selection = 1 Then
            Console.Clear()
            openingStage()
        Else
            Console.WriteLine("Quitting...")
            Threading.Thread.Sleep(1000)
            End
        End If

    End Sub

    Sub restartQuitB()
        Dim selection As Integer
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkRed

        Console.WriteLine("You have took in the wrong set of Suspects")
        Console.WriteLine("Please enter what you would like to do:")
        Console.WriteLine("1. Restart that section of 'Murder Mystery'")
        Console.WriteLine("2. Restart the 'Murder Mystery' completely")
        Console.WriteLine("3. Quit the 'Murder Mystery'")
        selection = Console.ReadLine

        If selection = 1 Then
            Console.Clear()
            suspectQuestingStart()
        ElseIf selection = 2 Then
            Console.Clear()
            openingStage()
        Else
            Console.WriteLine("Quitting...")
            Threading.Thread.Sleep(1000)
            End
        End If
    End Sub

    Sub QuitRestartC()
        Dim selection As Integer
        Console.Clear()
        Console.ForegroundColor = ConsoleColor.DarkRed

        Console.WriteLine("You have took in the wrong person to arrest")
        Console.WriteLine("Please enter what you would like to do:")
        Console.WriteLine("1. Restart that section of 'Murder Mystery'")
        Console.WriteLine("2. Restart the 'Murder Mystery' completely")
        Console.WriteLine("3. Quit the 'Murder Mystery'")
        selection = Console.ReadLine

        If selection = 1 Then
            Console.Clear()
            bringInandArrest()
        ElseIf selection = 2 Then
            Console.Clear()
            openingStage()
        Else
            Console.WriteLine("Quitting...")
            Threading.Thread.Sleep(1000)
            End
        End If
    End Sub

    Sub quitFinish()
        Dim selection As Integer
        Console.WriteLine("Now, you have finished the game, please choose what you would like to do:")
        Console.WriteLine("1. Quit the game")
        Console.WriteLine("2. Restart, (even though it would be pointless...)")

        selection = Console.ReadLine
        If selection = 1 Then
            Console.WriteLine("Quitting...")
            Threading.Thread.Sleep(1000)
            End
        Else
            Console.WriteLine("Restarting...")
            Threading.Thread.Sleep(1000)
            Console.Clear()
            nameCorrect()
        End If

    End Sub
End Module