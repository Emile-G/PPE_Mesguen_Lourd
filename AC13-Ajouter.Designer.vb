<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13_Ajouter
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ListeLieux = New System.Windows.Forms.ComboBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(27, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lieu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rendez vous entre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Et"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Commentaire"
        '
        'ListeLieux
        '
        Me.ListeLieux.FormattingEnabled = True
        Me.ListeLieux.Location = New System.Drawing.Point(273, 53)
        Me.ListeLieux.Name = "ListeLieux"
        Me.ListeLieux.Size = New System.Drawing.Size(200, 21)
        Me.ListeLieux.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(273, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(273, 162)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pris en charge le"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(273, 232)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(200, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(273, 295)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 125)
        Me.TextBox2.TabIndex = 10
        '
        'Valider
        '
        Me.Valider.Location = New System.Drawing.Point(199, 461)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(92, 28)
        Me.Valider.TabIndex = 11
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = True
        '
        'Retour
        '
        Me.Retour.Location = New System.Drawing.Point(199, 520)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(92, 33)
        Me.Retour.TabIndex = 12
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = True
        '
        'AC13_Ajouter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(506, 565)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ListeLieux)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AC13_Ajouter"
        Me.Text = "AC13-Ajouter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ListeLieux As System.Windows.Forms.ComboBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
