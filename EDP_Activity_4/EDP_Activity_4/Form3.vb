Imports MySql.Data.MySqlClient

Public Class Form3
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub btn_load_user_2_Click(sender As Object, e As EventArgs) Handles btn_load_user_2.Click
        Call Connect_to_DB()

        Dim sql As String = "SELECT * FROM students WHERE year_level = 2"

        Dim command As New MySqlCommand(sql, myconn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView2.DataSource = dataTable

        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_add_2_Click(sender As Object, e As EventArgs) Handles btn_add_2.Click

        Dim firstName As String = fname_2.Text
        Dim lastName As String = lname_2.Text
        Dim middleName As String = mname_2.Text
        Dim age As Integer = Integer.Parse(age_2.Text)
        Dim gender As String = gender_2.Text
        Dim fees As Decimal = Decimal.Parse(stud_fee_2.Text)
        Dim yearLevel As Integer = 2

        Call Connect_to_DB()

        Dim command As MySqlCommand = New MySqlCommand()
        command.Connection = myconn
        command.CommandText = "INSERT INTO Students (first_name, last_name, middle_name, age, gender, fee, year_level) VALUES (@firstName, @lastName, @middleName, @age, @gender, @fees, @yearLevel);"

        command.Parameters.AddWithValue("@firstName", firstName)
        command.Parameters.AddWithValue("@lastName", lastName)
        command.Parameters.AddWithValue("@middleName", middleName)
        command.Parameters.AddWithValue("@age", age)
        command.Parameters.AddWithValue("@gender", gender)
        command.Parameters.AddWithValue("@fees", fees)
        command.Parameters.AddWithValue("@yearLevel", yearLevel)

        command.ExecuteNonQuery()
        MsgBox("Record Successfully Added")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub Clear_TxtBoxes()
        With Me
            .fname_2.Text = ""
            .lname_2.Text = ""
            .mname_2.Text = ""
            .age_2.Text = ""
            .gender_2.Text = ""
            .stud_fee_2.Text = ""
            .stud_id_2.Text = ""
        End With
    End Sub

    Private Sub btn_update_2_Click(sender As Object, e As EventArgs) Handles btn_update_2.Click

        Dim id As Integer = Integer.Parse(stud_id_2.Text)

        Dim yearLevel As Integer = 2

        Call Connect_to_DB()

        Dim sql As String = "UPDATE students SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name, age = @age, gender = @gender, fee = @fees WHERE student_id = @student_id"
        Dim cmd As New MySqlCommand(sql, myconn)
        cmd.Parameters.AddWithValue("@first_name", fname_2.Text)
        cmd.Parameters.AddWithValue("@last_name", lname_2.Text)
        cmd.Parameters.AddWithValue("@middle_name", mname_2.Text)
        cmd.Parameters.AddWithValue("@age", age_2.Text)
        cmd.Parameters.AddWithValue("@gender", gender_2.Text)
        cmd.Parameters.AddWithValue("@fees", stud_fee_2.Text)
        cmd.Parameters.AddWithValue("@student_id", id)
        cmd.ExecuteNonQuery()
        MsgBox("Record Successfully Updated")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_delete_2_Click(sender As Object, e As EventArgs) Handles btn_delete_2.Click
        Dim id As Integer = Integer.Parse(stud_id_2.Text)

        Call Connect_to_DB()

        Dim sql As String = "DELETE FROM students WHERE student_id = @student_id"

        Dim cmd As New MySqlCommand(sql, myconn)
        cmd.Parameters.AddWithValue("@student_id", id)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Row deleted successfully.")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_logout_2_Click(sender As Object, e As EventArgs) Handles btn_logout_2.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub
End Class