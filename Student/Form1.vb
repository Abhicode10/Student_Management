Imports System.Data.OleDb
Imports System.Data
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Table1' table. You can move, or remove it, as needed.
        Me.Table1TableAdapter.Fill(Me.Database1DataSet.Table1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim uname As String
        Dim pword As String
        Dim pass As String

        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Please Fill all the information")
        Else
            uname = TextBox1.Text
            pword = TextBox2.Text


            Dim querry As String = "Select Password from Table1 where name = '" & uname & "' ;"
            Dim dbsource As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\abhis\OneDrive\Documents\Database Projects\Database1.accdb"
            Dim conn = New OleDbConnection(dbsource)
            Dim cmd As New OleDbCommand(querry, conn)
            conn.Open()

            Try
                pass = cmd.ExecuteScalar().ToString

            Catch ex As Exception
                MsgBox("Username Does not Exist")


            End Try

            If (pword = pass) Then
                MsgBox("Login Success")

                Form2.Show()
                If Form2.Visible Then
                    Me.Hide()
                End If
            Else
                MsgBox("Login failed")
                TextBox1.Clear()
                TextBox2.Clear()


            End If


        End If
    End Sub
End Class
