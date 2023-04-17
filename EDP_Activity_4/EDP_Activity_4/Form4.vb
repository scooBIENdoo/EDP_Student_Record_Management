Imports MySql.Data.MySqlClient
Public Class Form4
    Private Sub DataGridView3_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView3.CellContentClick

    End Sub

    Private Sub btn_load_user_3_Click(sender As Object, e As EventArgs) Handles btn_load_user_3.Click
        Call Connect_to_DB()

        Dim sql As String = "SELECT * FROM students WHERE year_level = 3"

        Dim command As New MySqlCommand(sql, myconn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView3.DataSource = dataTable

        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_add_3_Click(sender As Object, e As EventArgs) Handles btn_add_3.Click

        Dim firstName As String = fname_3.Text
        Dim lastName As String = lname_3.Text
        Dim middleName As String = mname_3.Text
        Dim age As Integer = Integer.Parse(age_3.Text)
        Dim gender As String = gender_3.Text
        Dim fees As Decimal = Decimal.Parse(stud_fee_3.Text)
        Dim yearLevel As Integer = 3

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
            .fname_3.Text = ""
            .lname_3.Text = ""
            .mname_3.Text = ""
            .age_3.Text = ""
            .gender_3.Text = ""
            .stud_fee_3.Text = ""
            .stud_id_3.Text = ""
        End With
    End Sub

    Private Sub btn_update_3_Click(sender As Object, e As EventArgs) Handles btn_update_3.Click

        Dim id As Integer = Integer.Parse(stud_id_3.Text)

        Dim yearLevel As Integer = 2

        Call Connect_to_DB()

        Dim sql As String = "UPDATE students SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name, age = @age, gender = @gender, fee = @fees WHERE student_id = @student_id"
        Dim cmd As New MySqlCommand(sql, myconn)
        cmd.Parameters.AddWithValue("@first_name", fname_3.Text)
        cmd.Parameters.AddWithValue("@last_name", lname_3.Text)
        cmd.Parameters.AddWithValue("@middle_name", mname_3.Text)
        cmd.Parameters.AddWithValue("@age", age_3.Text)
        cmd.Parameters.AddWithValue("@gender", gender_3.Text)
        cmd.Parameters.AddWithValue("@fees", stud_fee_3.Text)
        cmd.Parameters.AddWithValue("@student_id", id)
        cmd.ExecuteNonQuery()
        MsgBox("Record Successfully Updated")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_delete_3_Click(sender As Object, e As EventArgs) Handles btn_delete_3.Click
        Dim id As Integer = Integer.Parse(stud_id_3.Text)

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