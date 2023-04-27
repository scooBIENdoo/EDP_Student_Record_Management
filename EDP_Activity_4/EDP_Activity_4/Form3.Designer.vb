<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_delete_2 = New System.Windows.Forms.Button()
        Me.btn_update_2 = New System.Windows.Forms.Button()
        Me.stud_id_2 = New System.Windows.Forms.TextBox()
        Me.btn_add_2 = New System.Windows.Forms.Button()
        Me.stud_fee_2 = New System.Windows.Forms.TextBox()
        Me.gender_2 = New System.Windows.Forms.TextBox()
        Me.age_2 = New System.Windows.Forms.TextBox()
        Me.mname_2 = New System.Windows.Forms.TextBox()
        Me.lname_2 = New System.Windows.Forms.TextBox()
        Me.fname_2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtBackupLocation = New System.Windows.Forms.TextBox()
        Me.btn_print_record_2 = New System.Windows.Forms.Button()
        Me.btn_locate_data_2 = New System.Windows.Forms.Button()
        Me.btn_backup_data_2 = New System.Windows.Forms.Button()
        Me.btn_upload_2 = New System.Windows.Forms.Button()
        Me.btn_load_user_2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btn_logout_2 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_delete_2)
        Me.Panel1.Controls.Add(Me.btn_update_2)
        Me.Panel1.Controls.Add(Me.stud_id_2)
        Me.Panel1.Controls.Add(Me.btn_add_2)
        Me.Panel1.Controls.Add(Me.stud_fee_2)
        Me.Panel1.Controls.Add(Me.gender_2)
        Me.Panel1.Controls.Add(Me.age_2)
        Me.Panel1.Controls.Add(Me.mname_2)
        Me.Panel1.Controls.Add(Me.lname_2)
        Me.Panel1.Controls.Add(Me.fname_2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 488)
        Me.Panel1.TabIndex = 0
        '
        'btn_delete_2
        '
        Me.btn_delete_2.BackColor = System.Drawing.Color.Firebrick
        Me.btn_delete_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete_2.ForeColor = System.Drawing.Color.White
        Me.btn_delete_2.Location = New System.Drawing.Point(149, 413)
        Me.btn_delete_2.Name = "btn_delete_2"
        Me.btn_delete_2.Size = New System.Drawing.Size(108, 29)
        Me.btn_delete_2.TabIndex = 17
        Me.btn_delete_2.Text = "Delete"
        Me.btn_delete_2.UseVisualStyleBackColor = False
        '
        'btn_update_2
        '
        Me.btn_update_2.BackColor = System.Drawing.Color.Green
        Me.btn_update_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_update_2.ForeColor = System.Drawing.Color.White
        Me.btn_update_2.Location = New System.Drawing.Point(22, 413)
        Me.btn_update_2.Name = "btn_update_2"
        Me.btn_update_2.Size = New System.Drawing.Size(108, 29)
        Me.btn_update_2.TabIndex = 16
        Me.btn_update_2.Text = "Update"
        Me.btn_update_2.UseVisualStyleBackColor = False
        '
        'stud_id_2
        '
        Me.stud_id_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stud_id_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stud_id_2.Location = New System.Drawing.Point(22, 382)
        Me.stud_id_2.Name = "stud_id_2"
        Me.stud_id_2.PlaceholderText = " Input Student ID"
        Me.stud_id_2.Size = New System.Drawing.Size(235, 25)
        Me.stud_id_2.TabIndex = 15
        '
        'btn_add_2
        '
        Me.btn_add_2.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_add_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_add_2.ForeColor = System.Drawing.Color.White
        Me.btn_add_2.Location = New System.Drawing.Point(58, 325)
        Me.btn_add_2.Name = "btn_add_2"
        Me.btn_add_2.Size = New System.Drawing.Size(157, 29)
        Me.btn_add_2.TabIndex = 14
        Me.btn_add_2.Text = "Add Record"
        Me.btn_add_2.UseVisualStyleBackColor = False
        '
        'stud_fee_2
        '
        Me.stud_fee_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stud_fee_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stud_fee_2.Location = New System.Drawing.Point(22, 294)
        Me.stud_fee_2.Name = "stud_fee_2"
        Me.stud_fee_2.PlaceholderText = " Student Fee"
        Me.stud_fee_2.Size = New System.Drawing.Size(235, 25)
        Me.stud_fee_2.TabIndex = 13
        '
        'gender_2
        '
        Me.gender_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gender_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gender_2.Location = New System.Drawing.Point(149, 240)
        Me.gender_2.Name = "gender_2"
        Me.gender_2.PlaceholderText = " Gender"
        Me.gender_2.Size = New System.Drawing.Size(108, 25)
        Me.gender_2.TabIndex = 12
        '
        'age_2
        '
        Me.age_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.age_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.age_2.Location = New System.Drawing.Point(22, 240)
        Me.age_2.Name = "age_2"
        Me.age_2.PlaceholderText = " Age"
        Me.age_2.Size = New System.Drawing.Size(108, 25)
        Me.age_2.TabIndex = 11
        '
        'mname_2
        '
        Me.mname_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mname_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mname_2.Location = New System.Drawing.Point(22, 190)
        Me.mname_2.Name = "mname_2"
        Me.mname_2.PlaceholderText = " Middle Name"
        Me.mname_2.Size = New System.Drawing.Size(235, 25)
        Me.mname_2.TabIndex = 10
        '
        'lname_2
        '
        Me.lname_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lname_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lname_2.Location = New System.Drawing.Point(22, 141)
        Me.lname_2.Name = "lname_2"
        Me.lname_2.PlaceholderText = " Last Name"
        Me.lname_2.Size = New System.Drawing.Size(235, 25)
        Me.lname_2.TabIndex = 9
        '
        'fname_2
        '
        Me.fname_2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fname_2.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fname_2.Location = New System.Drawing.Point(22, 92)
        Me.fname_2.Name = "fname_2"
        Me.fname_2.PlaceholderText = " First Name"
        Me.fname_2.Size = New System.Drawing.Size(235, 25)
        Me.fname_2.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(14, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(258, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = " Second Year Student Record "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.txtBackupLocation)
        Me.Panel2.Controls.Add(Me.btn_print_record_2)
        Me.Panel2.Controls.Add(Me.btn_locate_data_2)
        Me.Panel2.Controls.Add(Me.btn_backup_data_2)
        Me.Panel2.Controls.Add(Me.btn_upload_2)
        Me.Panel2.Controls.Add(Me.btn_load_user_2)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(317, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 488)
        Me.Panel2.TabIndex = 1
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.Location = New System.Drawing.Point(331, 384)
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.Size = New System.Drawing.Size(382, 27)
        Me.txtBackupLocation.TabIndex = 7
        '
        'btn_print_record_2
        '
        Me.btn_print_record_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_print_record_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_print_record_2.Location = New System.Drawing.Point(174, 435)
        Me.btn_print_record_2.Name = "btn_print_record_2"
        Me.btn_print_record_2.Size = New System.Drawing.Size(137, 29)
        Me.btn_print_record_2.TabIndex = 6
        Me.btn_print_record_2.Text = "Print Record"
        Me.btn_print_record_2.UseVisualStyleBackColor = False
        '
        'btn_locate_data_2
        '
        Me.btn_locate_data_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_locate_data_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_locate_data_2.Location = New System.Drawing.Point(174, 383)
        Me.btn_locate_data_2.Name = "btn_locate_data_2"
        Me.btn_locate_data_2.Size = New System.Drawing.Size(137, 29)
        Me.btn_locate_data_2.TabIndex = 5
        Me.btn_locate_data_2.Text = "Locate Data"
        Me.btn_locate_data_2.UseVisualStyleBackColor = False
        '
        'btn_backup_data_2
        '
        Me.btn_backup_data_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_backup_data_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_backup_data_2.Location = New System.Drawing.Point(18, 435)
        Me.btn_backup_data_2.Name = "btn_backup_data_2"
        Me.btn_backup_data_2.Size = New System.Drawing.Size(137, 29)
        Me.btn_backup_data_2.TabIndex = 4
        Me.btn_backup_data_2.Text = "Backup Data"
        Me.btn_backup_data_2.UseVisualStyleBackColor = False
        '
        'btn_upload_2
        '
        Me.btn_upload_2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_upload_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_upload_2.Location = New System.Drawing.Point(18, 382)
        Me.btn_upload_2.Name = "btn_upload_2"
        Me.btn_upload_2.Size = New System.Drawing.Size(137, 29)
        Me.btn_upload_2.TabIndex = 3
        Me.btn_upload_2.Text = "Upload Data"
        Me.btn_upload_2.UseVisualStyleBackColor = False
        '
        'btn_load_user_2
        '
        Me.btn_load_user_2.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_load_user_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_load_user_2.ForeColor = System.Drawing.Color.White
        Me.btn_load_user_2.Location = New System.Drawing.Point(863, 384)
        Me.btn_load_user_2.Name = "btn_load_user_2"
        Me.btn_load_user_2.Size = New System.Drawing.Size(137, 29)
        Me.btn_load_user_2.TabIndex = 2
        Me.btn_load_user_2.Text = "Load Students"
        Me.btn_load_user_2.UseVisualStyleBackColor = False
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 51
        Me.DataGridView2.RowTemplate.Height = 29
        Me.DataGridView2.Size = New System.Drawing.Size(982, 336)
        Me.DataGridView2.TabIndex = 1
        '
        'btn_logout_2
        '
        Me.btn_logout_2.BackColor = System.Drawing.Color.Firebrick
        Me.btn_logout_2.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout_2.ForeColor = System.Drawing.Color.White
        Me.btn_logout_2.Location = New System.Drawing.Point(1180, 38)
        Me.btn_logout_2.Name = "btn_logout_2"
        Me.btn_logout_2.Size = New System.Drawing.Size(137, 45)
        Me.btn_logout_2.TabIndex = 3
        Me.btn_logout_2.Text = "Logout"
        Me.btn_logout_2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EDP_Activity_4.My.Resources.Resources.Second_Year_Page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 653)
        Me.Controls.Add(Me.btn_logout_2)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form3"
        Me.Text = "2nd Year"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents fname_2 As TextBox
    Friend WithEvents lname_2 As TextBox
    Friend WithEvents mname_2 As TextBox
    Friend WithEvents age_2 As TextBox
    Friend WithEvents gender_2 As TextBox
    Friend WithEvents stud_fee_2 As TextBox
    Friend WithEvents btn_add_2 As Button
    Friend WithEvents stud_id_2 As TextBox
    Friend WithEvents btn_update_2 As Button
    Friend WithEvents btn_delete_2 As Button
    Friend WithEvents btn_load_user_2 As Button
    Friend WithEvents btn_logout_2 As Button
    Friend WithEvents btn_backup_data_2 As Button
    Friend WithEvents btn_upload_2 As Button
    Friend WithEvents btn_print_record_2 As Button
    Friend WithEvents btn_locate_data_2 As Button
    Friend WithEvents txtBackupLocation As TextBox
End Class
