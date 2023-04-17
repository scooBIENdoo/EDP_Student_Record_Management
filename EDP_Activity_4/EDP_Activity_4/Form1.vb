Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub TxtBox_Username_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_Username.TextChanged

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click
        With Me
            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand
            Dim myreader As MySqlDataReader


            strSQL = "Select * from administrations where username = '" _
                & .TxtBox_Username.Text & "' and password = '" _
                & .TxtBox_Pwd.Text & "'"

            mycmd.CommandText = strSQL
            mycmd.Connection = myconn
            myreader = mycmd.ExecuteReader
            Dim yearLevel As Integer = 0
            If myreader.HasRows Then
                myreader.Read()
                yearLevel = myreader.GetInt16("yead_lvl_id")
                Hide()
            Else
                MessageBox.Show("Invalid username or password")
                .TxtBox_Username.Text = ""
                .TxtBox_Pwd.Text = ""
            End If

            If yearLevel = 1 Then
                Form2.Show()
            ElseIf yearLevel = 2 Then
                Form3.Show()
            ElseIf yearLevel = 3 Then
                Form4.Show()
            ElseIf yearLevel = 4 Then
                Form5.Show()
            End If

            Call Disconnect_to_DB()
        End With
    End Sub

    Private Sub btn_cancel_login_Click(sender As Object, e As EventArgs) Handles btn_cancel_login.Click
        Me.Close()
    End Sub

    Private Sub TxtBox_Pwd_TextChanged(sender As Object, e As EventArgs) Handles TxtBox_Pwd.TextChanged

    End Sub
End Class
