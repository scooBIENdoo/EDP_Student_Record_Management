<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.btn_login = New System.Windows.Forms.Button()
        Me.TxtBox_Username = New System.Windows.Forms.TextBox()
        Me.TxtBox_Pwd = New System.Windows.Forms.TextBox()
        Me.btn_cancel_login = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_login
        '
        Me.btn_login.BackColor = System.Drawing.Color.DarkBlue
        Me.btn_login.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_login.ForeColor = System.Drawing.Color.White
        Me.btn_login.Location = New System.Drawing.Point(296, 274)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(94, 29)
        Me.btn_login.TabIndex = 0
        Me.btn_login.Text = "Login"
        Me.btn_login.UseVisualStyleBackColor = False
        '
        'TxtBox_Username
        '
        Me.TxtBox_Username.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBox_Username.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtBox_Username.Location = New System.Drawing.Point(296, 122)
        Me.TxtBox_Username.Name = "TxtBox_Username"
        Me.TxtBox_Username.PlaceholderText = "Input Username"
        Me.TxtBox_Username.Size = New System.Drawing.Size(208, 25)
        Me.TxtBox_Username.TabIndex = 1
        '
        'TxtBox_Pwd
        '
        Me.TxtBox_Pwd.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TxtBox_Pwd.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TxtBox_Pwd.Location = New System.Drawing.Point(296, 185)
        Me.TxtBox_Pwd.Name = "TxtBox_Pwd"
        Me.TxtBox_Pwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtBox_Pwd.PlaceholderText = "Input Password"
        Me.TxtBox_Pwd.Size = New System.Drawing.Size(208, 25)
        Me.TxtBox_Pwd.TabIndex = 2
        '
        'btn_cancel_login
        '
        Me.btn_cancel_login.BackColor = System.Drawing.Color.Firebrick
        Me.btn_cancel_login.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btn_cancel_login.ForeColor = System.Drawing.Color.White
        Me.btn_cancel_login.Location = New System.Drawing.Point(410, 274)
        Me.btn_cancel_login.Name = "btn_cancel_login"
        Me.btn_cancel_login.Size = New System.Drawing.Size(94, 29)
        Me.btn_cancel_login.TabIndex = 3
        Me.btn_cancel_login.Text = "Cancel"
        Me.btn_cancel_login.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.EDP_Activity_4.My.Resources.Resources.Login_BG
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_cancel_login)
        Me.Controls.Add(Me.TxtBox_Pwd)
        Me.Controls.Add(Me.TxtBox_Username)
        Me.Controls.Add(Me.btn_login)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Login Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_login As Button
    Friend WithEvents TxtBox_Username As TextBox
    Friend WithEvents TxtBox_Pwd As TextBox
    Friend WithEvents btn_cancel_login As Button
End Class
