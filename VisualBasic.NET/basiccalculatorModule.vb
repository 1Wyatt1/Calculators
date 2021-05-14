Module basiccalculatorModule
    Dim response, fourresposnse, pownumber, exponent, result, rootrepo, rootresult, firstnumber, secondnumber, number, num3, trigresponse, angle
    Sub Main()
        Console.WriteLine("Do you want to do basic math, or geometry?")
        Console.WriteLine("1 - Basic Math")
        Console.WriteLine("2 - Geometry")
        Console.WriteLine("3 - Roots & Powers")
        Console.WriteLine("4 - Other")
        response = Console.ReadLine()
        If response = 3 Then
            Console.WriteLine("What are you looking to do?")
            Console.WriteLine("1 - Power")
            Console.WriteLine("2 - Square Root")
            fourresposnse = Console.ReadLine()
        End If
        If fourresposnse = 1 Then
            Console.Clear()
            Console.WriteLine("What number are you looking to get the power for?")
            number = Console.ReadLine
            Console.Clear()
            Console.WriteLine("What number are you going to put it to the power of?")
            exponent = Console.ReadLine
            result = Math.Exp(number ^ exponent)
            Console.WriteLine("The number " + pownumber + "to the power of " + exponent + " is: " + result)
        End If
        If fourresposnse = 2 Then
            Console.Clear()
            Console.WriteLine("What number are you looking to get the sqaure root for?")
            rootrepo = Console.ReadLine
            Console.Clear()
            rootresult = Math.Sqrt(rootrepo)
            Console.WriteLine("The square root of " + rootrepo + " is " + rootresult)
        End If
        If response = 1 Then
            Console.Clear()

            Console.WriteLine("What is the first number you want to work with?")

            firstnumber = Console.ReadLine()
            Console.Clear()

            Console.WriteLine("What is the second number you want to work with?")

            secondnumber = Console.ReadLine()

            Console.Clear()

            Console.WriteLine("What do you want to do with these numbers? The available options are: + - * /")
            number = Console.ReadLine


            If number = "+" Then
                num3 = firstnumber + secondnumber
            ElseIf number = "-" Then
                num3 = firstnumber - secondnumber
            ElseIf number = "*" Then
                num3 = firstnumber * secondnumber
            ElseIf number = "/" Then
                num3 = firstnumber / secondnumber
            End If
            Console.WriteLine("Your number is: " + num3)
        End If

        If response = 2 Then
            Console.Clear()
            Console.WriteLine("1 - Gives cosine of an angle")
            Console.WriteLine("2 - Gives sine of an angle")
            Console.WriteLine("3 - Gives tangent of an angle")
            trigresponse = Console.ReadLine()
            If trigresponse = 1 Then
                Console.Clear()
                Console.WriteLine("What number are you looking to find the sine for?")
                angle = Console.ReadLine
                result = Math.Cos(angle)
                Console.WriteLine("Cosine is: " + result)
            End If
            If trigresponse = 2 Then
                Console.Clear()
                Console.WriteLine("What number are you looking to find the sine for?")
                angle = Console.ReadLine
                result = Math.Sin(angle)
                Console.WriteLine("Sine is: " + result)
            End If
            If trigresponse = 3 Then
                Console.Clear()
                Console.WriteLine("What number are you looking to find the tangent for?")
                angle = Console.ReadLine
                result = Math.Tan(angle)
                Console.WriteLine("Tangent is: " + result)
            End If
        End If
    End Sub
End Module
