﻿Imports System.IO
Imports System.Text
Imports System.Windows
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports Mysqlx

Public Class Form2
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub btn_load_user_1_Click(sender As Object, e As EventArgs) Handles btn_load_user_1.Click
        Call Connect_to_DB()

        Dim sql As String = "SELECT * FROM students WHERE year_level = 1"

        Dim command As New MySqlCommand(sql, myconn)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dataTable As New DataTable()

        adapter.Fill(dataTable)
        DataGridView1.DataSource = dataTable

        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_add_1_Click(sender As Object, e As EventArgs) Handles btn_add_1.Click

        Dim firstName As String = fname_1.Text
        Dim lastName As String = lname_1.Text
        Dim middleName As String = mname_1.Text
        Dim age As Integer = Integer.Parse(age_1.Text)
        Dim gender As String = gender_1.Text
        Dim fees As Decimal = Decimal.Parse(stud_fee_1.Text)
        Dim yearLevel As Integer = 1

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
            .fname_1.Text = ""
            .lname_1.Text = ""
            .mname_1.Text = ""
            .age_1.Text = ""
            .gender_1.Text = ""
            .stud_fee_1.Text = ""
            .stud_id_1.Text = ""
        End With
    End Sub

    Private Sub btn_update_1_Click(sender As Object, e As EventArgs) Handles btn_update_1.Click

        Dim id As Integer = Integer.Parse(stud_id_1.Text)

        Dim yearLevel As Integer = 1

        Call Connect_to_DB()

        Dim sql As String = "UPDATE students SET first_name = @first_name, last_name = @last_name, middle_name = @middle_name, age = @age, gender = @gender, fee = @fees WHERE student_id = @student_id"
        Dim cmd As New MySqlCommand(sql, myconn)
        cmd.Parameters.AddWithValue("@first_name", fname_1.Text)
        cmd.Parameters.AddWithValue("@last_name", lname_1.Text)
        cmd.Parameters.AddWithValue("@middle_name", mname_1.Text)
        cmd.Parameters.AddWithValue("@age", age_1.Text)
        cmd.Parameters.AddWithValue("@gender", gender_1.Text)
        cmd.Parameters.AddWithValue("@fees", stud_fee_1.Text)
        cmd.Parameters.AddWithValue("@student_id", id)
        cmd.ExecuteNonQuery()
        MsgBox("Record Successfully Updated")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_delete_1_Click(sender As Object, e As EventArgs) Handles btn_delete_1.Click
        Dim id As Integer = Integer.Parse(stud_id_1.Text)

        Call Connect_to_DB()

        Dim sql As String = "DELETE FROM students WHERE student_id = @student_id"

        Dim cmd As New MySqlCommand(sql, myconn)
        cmd.Parameters.AddWithValue("@student_id", id)

        cmd.ExecuteNonQuery()

        MessageBox.Show("Row deleted successfully.")
        Call Clear_TxtBoxes()
        Call Disconnect_to_DB()
    End Sub

    Private Sub btn_logout_1_Click(sender As Object, e As EventArgs) Handles btn_logout_1.Click
        Dim loginForm As New Form1()
        loginForm.Show()
        Me.Close()
    End Sub

    Private Sub btn_backup_data_1_Click(sender As Object, e As EventArgs) Handles btn_backup_data_1.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to backup your database?", "Backup Database", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then

            Dim backupFileName As String = $"it_student_record_backup_{DateTime.Now.ToString("yyyyMMddHHmmss")}.sql"
            Dim backupFilePath As String = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), backupFileName)

            Try
                Connect_to_DB()
                Dim cmd As New Process()
                cmd.StartInfo.FileName = "cmd.exe"
                cmd.StartInfo.RedirectStandardInput = True
                cmd.StartInfo.RedirectStandardOutput = True
                cmd.StartInfo.CreateNoWindow = True
                cmd.StartInfo.UseShellExecute = False
                cmd.Start()
                Dim backupCommand As String = $"mysqldump -u root -pReu_114606100073 --lock-tables=false --routines --triggers it_student_record_management > ""{backupFilePath}"""
                cmd.StandardInput.WriteLine(backupCommand)
                cmd.StandardInput.Flush()
                cmd.StandardInput.Close()
                cmd.WaitForExit()
                Disconnect_to_DB()

                MessageBox.Show("Database backup completed successfully.", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show($"An error occurred during the backup process: {ex.Message}", "Backup Database", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub btn_locate_data_1_Click(sender As Object, e As EventArgs) Handles btn_locate_data_1.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Backup Files (*.sql)|*.sql|All Files (*.*)|*.*"
        openFileDialog1.Title = "Select a Backup File"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            txtBackupLocation.Text = openFileDialog1.FileName
        End If
    End Sub

    Private Sub txtBackupLocation_TextChanged(sender As Object, e As EventArgs) Handles txtBackupLocation.TextChanged

    End Sub

    Private Sub btn_upload_1_Click(sender As Object, e As EventArgs) Handles btn_upload_1.Click
        Dim openFileDialog1 As New OpenFileDialog With {
            .Filter = "Text Files (*.csv)|*.csv|All Files (*.*)|*.*",
            .FilterIndex = 1,
            .RestoreDirectory = True
        }

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog1.FileName
            Dim path As String = filePath.Replace("\", "/")

            Call Connect_to_DB()
            Dim mycmd As New MySqlCommand

            Try
                strSQL = "Load DATA INFILE '" & path & "' INTO TABLE students " &
                         "FIELDS TERMINATED BY ',' " &
                         "LINES TERMINATED BY '\r\n' " &
                         "IGNORE 1 LINES"

                mycmd.CommandText = strSQL
                mycmd.Connection = myconn
                mycmd.ExecuteNonQuery()
                MessageBox.Show("Data uploaded successfully")

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Disconnect_to_DB()
        End If
    End Sub

    Private Sub btn_print_record_1_Click(sender As Object, e As EventArgs) Handles btn_print_record_1.Click
        Print.PrintToExcel(DataGridView1)
    End Sub
End Class