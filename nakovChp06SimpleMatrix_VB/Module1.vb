Imports System


Namespace nakovCh06ex10_simpleMatrix

    Public Class Program

        Public Shared Sub Main(ByVal args As String())
            SimpleMatrix()
        End Sub

        Private Shared Sub SimpleMatrix()
            Console.WriteLine("Please enter a number less or equal to 20: ")
            Dim userInp As String = Console.ReadLine()
            Dim num As Integer = 0
            Dim check As Boolean = Integer.TryParse(userInp, num)
            If check <> True Then
                Console.WriteLine("Please enter a number")
            End If

            For i As Integer = 0 To num - 1
                For j As Integer = 1 + i To num + i
                    Console.Write("{0, 3}", j)
                Next

                Console.WriteLine()
            Next
        End Sub
    End Class
End Namespace
