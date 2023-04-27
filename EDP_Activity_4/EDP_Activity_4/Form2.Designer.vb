<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.btn_delete_1 = New System.Windows.Forms.Button()
        Me.btn_update_1 = New System.Windows.Forms.Button()
        Me.stud_id_1 = New System.Windows.Forms.TextBox()
        Me.btn_add_1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.stud_fee_1 = New System.Windows.Forms.TextBox()
        Me.gender_1 = New System.Windows.Forms.TextBox()
        Me.age_1 = New System.Windows.Forms.TextBox()
        Me.mname_1 = New System.Windows.Forms.TextBox()
        Me.lname_1 = New System.Windows.Forms.TextBox()
        Me.fname_1 = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_print_record_1 = New System.Windows.Forms.Button()
        Me.btn_upload_1 = New System.Windows.Forms.Button()
        Me.txtBackupLocation = New System.Windows.Forms.TextBox()
        Me.btn_locate_data_1 = New System.Windows.Forms.Button()
        Me.btn_backup_data_1 = New System.Windows.Forms.Button()
        Me.btn_load_user_1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btn_logout_1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btn_delete_1)
        Me.Panel1.Controls.Add(Me.btn_update_1)
        Me.Panel1.Controls.Add(Me.stud_id_1)
        Me.Panel1.Controls.Add(Me.btn_add_1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.stud_fee_1)
        Me.Panel1.Controls.Add(Me.gender_1)
        Me.Panel1.Controls.Add(Me.age_1)
        Me.Panel1.Controls.Add(Me.mname_1)
        Me.Panel1.Controls.Add(Me.lname_1)
        Me.Panel1.Controls.Add(Me.fname_1)
        Me.Panel1.Location = New System.Drawing.Point(12, 135)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(288, 488)
        Me.Panel1.TabIndex = 0
        '
        'btn_delete_1
        '
        Me.btn_delete_1.BackColor = System.Drawing.Color.Firebrick
        Me.btn_delete_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_delete_1.ForeColor = System.Drawing.Color.White
        Me.btn_delete_1.Location = New System.Drawing.Point(149, 413)
        Me.btn_delete_1.Name = "btn_delete_1"
        Me.btn_delete_1.Size = New System.Drawing.Size(108, 29)
        Me.btn_delete_1.TabIndex = 10
        Me.btn_delete_1.Text = "Delete"
        Me.btn_delete_1.UseVisualStyleBackColor = False
        '
        'btn_update_1
        '
        Me.btn_update_1.BackColor = System.Drawing.Color.Green
        Me.btn_update_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_update_1.ForeColor = System.Drawing.Color.White
        Me.btn_update_1.Location = New System.Drawing.Point(22, 413)
        Me.btn_update_1.Name = "btn_update_1"
        Me.btn_update_1.Size = New System.Drawing.Size(108, 29)
        Me.btn_update_1.TabIndex = 9
        Me.btn_update_1.Text = "Update"
        Me.btn_update_1.UseVisualStyleBackColor = False
        '
        'stud_id_1
        '
        Me.stud_id_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stud_id_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stud_id_1.Location = New System.Drawing.Point(22, 382)
        Me.stud_id_1.Name = "stud_id_1"
        Me.stud_id_1.PlaceholderText = " Input Student ID"
        Me.stud_id_1.Size = New System.Drawing.Size(235, 25)
        Me.stud_id_1.TabIndex = 8
        '
        'btn_add_1
        '
        Me.btn_add_1.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_add_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_add_1.ForeColor = System.Drawing.Color.White
        Me.btn_add_1.Location = New System.Drawing.Point(58, 325)
        Me.btn_add_1.Name = "btn_add_1"
        Me.btn_add_1.Size = New System.Drawing.Size(157, 29)
        Me.btn_add_1.TabIndex = 7
        Me.btn_add_1.Text = "Add Record"
        Me.btn_add_1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(248, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(33, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(22, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = " First Year Student Record "
        '
        'stud_fee_1
        '
        Me.stud_fee_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stud_fee_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.stud_fee_1.Location = New System.Drawing.Point(22, 294)
        Me.stud_fee_1.Name = "stud_fee_1"
        Me.stud_fee_1.PlaceholderText = " Student Fee"
        Me.stud_fee_1.Size = New System.Drawing.Size(235, 25)
        Me.stud_fee_1.TabIndex = 5
        '
        'gender_1
        '
        Me.gender_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.gender_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.gender_1.Location = New System.Drawing.Point(149, 240)
        Me.gender_1.Name = "gender_1"
        Me.gender_1.PlaceholderText = " Gender"
        Me.gender_1.Size = New System.Drawing.Size(108, 25)
        Me.gender_1.TabIndex = 4
        '
        'age_1
        '
        Me.age_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.age_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.age_1.Location = New System.Drawing.Point(22, 240)
        Me.age_1.Name = "age_1"
        Me.age_1.PlaceholderText = " Age"
        Me.age_1.Size = New System.Drawing.Size(108, 25)
        Me.age_1.TabIndex = 3
        '
        'mname_1
        '
        Me.mname_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mname_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.mname_1.Location = New System.Drawing.Point(22, 190)
        Me.mname_1.Name = "mname_1"
        Me.mname_1.PlaceholderText = " Middle Name"
        Me.mname_1.Size = New System.Drawing.Size(235, 25)
        Me.mname_1.TabIndex = 2
        '
        'lname_1
        '
        Me.lname_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lname_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lname_1.Location = New System.Drawing.Point(22, 141)
        Me.lname_1.Name = "lname_1"
        Me.lname_1.PlaceholderText = " Last Name"
        Me.lname_1.Size = New System.Drawing.Size(235, 25)
        Me.lname_1.TabIndex = 1
        '
        'fname_1
        '
        Me.fname_1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.fname_1.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.fname_1.Location = New System.Drawing.Point(22, 92)
        Me.fname_1.Name = "fname_1"
        Me.fname_1.PlaceholderText = " First Name"
        Me.fname_1.Size = New System.Drawing.Size(235, 25)
        Me.fname_1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(11, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_print_record_1)
        Me.Panel2.Controls.Add(Me.btn_upload_1)
        Me.Panel2.Controls.Add(Me.txtBackupLocation)
        Me.Panel2.Controls.Add(Me.btn_locate_data_1)
        Me.Panel2.Controls.Add(Me.btn_backup_data_1)
        Me.Panel2.Controls.Add(Me.btn_load_user_1)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(317, 135)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1014, 488)
        Me.Panel2.TabIndex = 1
        '
        'btn_print_record_1
        '
        Me.btn_print_record_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_print_record_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_print_record_1.Location = New System.Drawing.Point(173, 434)
        Me.btn_print_record_1.Name = "btn_print_record_1"
        Me.btn_print_record_1.Size = New System.Drawing.Size(137, 29)
        Me.btn_print_record_1.TabIndex = 6
        Me.btn_print_record_1.Text = "Print Record"
        Me.btn_print_record_1.UseVisualStyleBackColor = False
        '
        'btn_upload_1
        '
        Me.btn_upload_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_upload_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_upload_1.Location = New System.Drawing.Point(18, 381)
        Me.btn_upload_1.Name = "btn_upload_1"
        Me.btn_upload_1.Size = New System.Drawing.Size(137, 29)
        Me.btn_upload_1.TabIndex = 5
        Me.btn_upload_1.Text = "Upload Data"
        Me.btn_upload_1.UseVisualStyleBackColor = False
        '
        'txtBackupLocation
        '
        Me.txtBackupLocation.Location = New System.Drawing.Point(327, 384)
        Me.txtBackupLocation.Name = "txtBackupLocation"
        Me.txtBackupLocation.Size = New System.Drawing.Size(382, 27)
        Me.txtBackupLocation.TabIndex = 4
        '
        'btn_locate_data_1
        '
        Me.btn_locate_data_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_locate_data_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_locate_data_1.Location = New System.Drawing.Point(173, 381)
        Me.btn_locate_data_1.Name = "btn_locate_data_1"
        Me.btn_locate_data_1.Size = New System.Drawing.Size(137, 29)
        Me.btn_locate_data_1.TabIndex = 3
        Me.btn_locate_data_1.Text = "Locate Data"
        Me.btn_locate_data_1.UseVisualStyleBackColor = False
        '
        'btn_backup_data_1
        '
        Me.btn_backup_data_1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btn_backup_data_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_backup_data_1.Location = New System.Drawing.Point(18, 434)
        Me.btn_backup_data_1.Name = "btn_backup_data_1"
        Me.btn_backup_data_1.Size = New System.Drawing.Size(137, 29)
        Me.btn_backup_data_1.TabIndex = 2
        Me.btn_backup_data_1.Text = "Backup Data"
        Me.btn_backup_data_1.UseVisualStyleBackColor = False
        '
        'btn_load_user_1
        '
        Me.btn_load_user_1.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_load_user_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_load_user_1.ForeColor = System.Drawing.Color.White
        Me.btn_load_user_1.Location = New System.Drawing.Point(863, 382)
        Me.btn_load_user_1.Name = "btn_load_user_1"
        Me.btn_load_user_1.Size = New System.Drawing.Size(137, 29)
        Me.btn_load_user_1.TabIndex = 1
        Me.btn_load_user_1.Text = "Load Students"
        Me.btn_load_user_1.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 18)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 29
        Me.DataGridView1.Size = New System.Drawing.Size(982, 336)
        Me.DataGridView1.TabIndex = 0
        '
        'btn_logout_1
        '
        Me.btn_logout_1.BackColor = System.Drawing.Color.Firebrick
        Me.btn_logout_1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_logout_1.ForeColor = System.Drawing.Color.White
        Me.btn_logout_1.Location = New System.Drawing.Point(1180, 38)
        Me.btn_logout_1.Name = "btn_logout_1"
        Me.btn_logout_1.Size = New System.Drawing.Size(137, 45)
        Me.btn_logout_1.TabIndex = 2
        Me.btn_logout_1.Text = "Logout"
        Me.btn_logout_1.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.EDP_Activity_4.My.Resources.Resources.First_Year_Page
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1343, 653)
        Me.Controls.Add(Me.btn_logout_1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Form2"
        Me.Text = "1st Year"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_load_user_1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents stud_fee_1 As TextBox
    Friend WithEvents gender_1 As TextBox
    Friend WithEvents age_1 As TextBox
    Friend WithEvents mname_1 As TextBox
    Friend WithEvents lname_1 As TextBox
    Friend WithEvents fname_1 As TextBox
    Friend WithEvents btn_add_1 As Button
    Friend WithEvents btn_delete_1 As Button
    Friend WithEvents btn_update_1 As Button
    Friend WithEvents stud_id_1 As TextBox
    Friend WithEvents btn_logout_1 As Button
    Friend WithEvents btn_backup_data_1 As Button
    Friend WithEvents btn_locate_data_1 As Button
    Friend WithEvents txtBackupLocation As TextBox
    Friend WithEvents btn_upload_1 As Button
    Friend WithEvents btn_print_record_1 As Button
End Class
