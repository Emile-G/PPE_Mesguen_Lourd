<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Page_Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Login"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'Login
        '
        Me.Login.Location = New System.Drawing.Point(12, 24)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(317, 20)
        Me.Login.TabIndex = 4
        Me.Login.Text = "u_mesguen"
        '
        'Password
        '
        Me.Password.Location = New System.Drawing.Point(12, 75)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(317, 20)
        Me.Password.TabIndex = 5
        Me.Password.Text = "estran"
        '
        'Connexion
        '
        Me.Connexion.Location = New System.Drawing.Point(100, 114)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(132, 29)
        Me.Connexion.TabIndex = 6
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = True
        '
        'Page_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(343, 150)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Page_Connexion"
        Me.Text = "Page de connexion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents Connexion As System.Windows.Forms.Button

End Class
