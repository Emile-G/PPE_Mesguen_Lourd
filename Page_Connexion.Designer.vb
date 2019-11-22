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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Page_Connexion))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Login = New System.Windows.Forms.TextBox()
        Me.Password = New System.Windows.Forms.TextBox()
        Me.ErreurCo = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Connexion = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(59, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nom d'utilisateur"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(59, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'Login
        '
        Me.Login.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Login.Location = New System.Drawing.Point(63, 138)
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(363, 23)
        Me.Login.TabIndex = 4
        Me.Login.Text = "u_mesguen"
        '
        'Password
        '
        Me.Password.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Password.Location = New System.Drawing.Point(63, 193)
        Me.Password.Name = "Password"
        Me.Password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Password.Size = New System.Drawing.Size(363, 23)
        Me.Password.TabIndex = 5
        Me.Password.Text = "estran"
        '
        'ErreurCo
        '
        Me.ErreurCo.AutoSize = True
        Me.ErreurCo.ForeColor = System.Drawing.Color.Red
        Me.ErreurCo.Location = New System.Drawing.Point(238, 122)
        Me.ErreurCo.Name = "ErreurCo"
        Me.ErreurCo.Size = New System.Drawing.Size(0, 13)
        Me.ErreurCo.TabIndex = 7
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(63, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(363, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Connexion
        '
        Me.Connexion.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Connexion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Connexion.Location = New System.Drawing.Point(183, 222)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(118, 49)
        Me.Connexion.TabIndex = 9
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = False
        '
        'Page_Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(498, 280)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ErreurCo)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Login)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Page_Connexion"
        Me.Text = "Page de connexion"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Login As System.Windows.Forms.TextBox
    Friend WithEvents Password As System.Windows.Forms.TextBox
    Friend WithEvents ErreurCo As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Connexion As System.Windows.Forms.Button

End Class
