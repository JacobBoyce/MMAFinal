Imports System.IO
Public Class Login
    Structure CurrentUser
        Public username As String
        Public password As String
        Public payFreq As String
        Public numBills As Integer
        Public bills As Bill()
    End Structure
    Structure Bill
        Public name As String
        Public amount As Integer
        Public due As Integer
    End Structure
    Dim curUser As CurrentUser

    'click login
    Private Sub LoginB_Click(sender As Object, e As EventArgs) Handles LoginB.Click
        ErrorMessage.Hide()
        'read file with input of text box
        Try
            Using myreader As New Microsoft.VisualBasic.FileIO.TextFieldParser(LoginUsernameBox.Text + ".dat")
                ErrorMessage.Hide()
                myreader.TextFieldType = FileIO.FieldType.Delimited
                myreader.SetDelimiters("|")
                Dim currentrow As String()
                'get user info
                currentrow = myreader.ReadFields
                curUser.username = currentrow(0)
                curUser.password = currentrow(1)
                curUser.payFreq = currentrow(2)
                curUser.numBills = currentrow(3)
                'input.Text = LoginPasswordBox.Text
                'userPass.Text = curUser.password

                If (StrComp(LoginPasswordBox.Text, curUser.password, vbTextCompare) = 0) Then
                    ErrorMessage.Hide()
                    curUser.bills = New Bill(curUser.numBills) {}
                    Dim I As Integer = 0
                    'read in all bills
                    While Not myreader.EndOfData
                        currentrow = myreader.ReadFields
                        curUser.bills(I).name = currentrow(0)
                        curUser.bills(I).amount = currentrow(1)
                        curUser.bills(I).due = currentrow(2)
                        I = I + 1
                    End While
                    MainMenu.Show()
                    Me.Hide()
                Else
                    ErrorMessage.Show()
                    ErrorMessage.Text = "Incorrect Password. Please try again"
                End If
                'set num of bills
            End Using
        Catch ex As Exception
            ErrorMessage.Show()
            ErrorMessage.Text = "Incorrect Username. Please try again"
        End Try
    End Sub

    'when form loads
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ErrorMessage.Hide()
    End Sub
End Class
