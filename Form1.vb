Imports System.Data.SqlClient
Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = " " Then
            MsgBox("Username is Required!", MsgBoxStyle.Critical)
            TextBox1.Focus()
        ElseIf TextBox2.Text = " " Then
            MsgBox("Password is Required!", MsgBoxStyle.Critical)
            TextBox1.Focus()
        Else
            Dim connection As New SqlConnection("Server=kv-optiplex-304\sqlexpress;database=login;integrated security=true")
            Dim command As New SqlCommand("select * from login_table where Username=@username and Passord=@password", connection)
            command.Parameters.Add("@username", SqlDbType.value = TextBox1.Text)

        End If
    End Sub
End Class
