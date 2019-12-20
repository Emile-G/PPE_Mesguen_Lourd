<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC13_Modifier
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Valider = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Photo1 = New System.Windows.Forms.PictureBox()
        Me.LabelHeurePhoto = New System.Windows.Forms.Label()
        Me.Photos = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ListePhotos = New System.Windows.Forms.ComboBox()
        Me.PasdePhotos = New System.Windows.Forms.Label()
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Photos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lieu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(160, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rendez vous entre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 169)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Et"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.Location = New System.Drawing.Point(15, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Commentaire"
        '
        'ListeLieux
        '
        Me.ListeLieux.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.ListeLieux.FormattingEnabled = True
        Me.ListeLieux.Location = New System.Drawing.Point(236, 53)
        Me.ListeLieux.Name = "ListeLieux"
        Me.ListeLieux.Size = New System.Drawing.Size(200, 28)
        Me.ListeLieux.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(236, 109)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 6
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.DateTimePicker2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(236, 162)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Pris en charge le"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox1.Location = New System.Drawing.Point(236, 232)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(200, 26)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.TextBox2.Location = New System.Drawing.Point(236, 295)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(200, 125)
        Me.TextBox2.TabIndex = 10
        '
        'Valider
        '
        Me.Valider.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Valider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Valider.Location = New System.Drawing.Point(19, 448)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(118, 49)
        Me.Valider.TabIndex = 28
        Me.Valider.Text = "Ajouter"
        Me.Valider.UseVisualStyleBackColor = False
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Retour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Retour.Location = New System.Drawing.Point(318, 448)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(118, 49)
        Me.Retour.TabIndex = 30
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(989, 32)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "AC13 - Modifier une étape"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Photo1
        '
        Me.Photo1.ImageLocation = ""
        Me.Photo1.Location = New System.Drawing.Point(32, 56)
        Me.Photo1.Name = "Photo1"
        Me.Photo1.Size = New System.Drawing.Size(334, 256)
        Me.Photo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Photo1.TabIndex = 32
        Me.Photo1.TabStop = False
        '
        'LabelHeurePhoto
        '
        Me.LabelHeurePhoto.AutoSize = True
        Me.LabelHeurePhoto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelHeurePhoto.Location = New System.Drawing.Point(126, 315)
        Me.LabelHeurePhoto.Name = "LabelHeurePhoto"
        Me.LabelHeurePhoto.Size = New System.Drawing.Size(149, 20)
        Me.LabelHeurePhoto.TabIndex = 33
        Me.LabelHeurePhoto.Text = "LabelHeurePhoto"
        '
        'Photos
        '
        Me.Photos.Controls.Add(Me.Label7)
        Me.Photos.Controls.Add(Me.ListePhotos)
        Me.Photos.Controls.Add(Me.LabelHeurePhoto)
        Me.Photos.Controls.Add(Me.Photo1)
        Me.Photos.Location = New System.Drawing.Point(535, 94)
        Me.Photos.Name = "Photos"
        Me.Photos.Size = New System.Drawing.Size(402, 346)
        Me.Photos.TabIndex = 34
        Me.Photos.TabStop = False
        Me.Photos.Text = "Photos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Choix de la photo :"
        '
        'ListePhotos
        '
        Me.ListePhotos.FormattingEnabled = True
        Me.ListePhotos.Location = New System.Drawing.Point(130, 19)
        Me.ListePhotos.Name = "ListePhotos"
        Me.ListePhotos.Size = New System.Drawing.Size(121, 21)
        Me.ListePhotos.TabIndex = 34
        '
        'PasdePhotos
        '
        Me.PasdePhotos.AutoSize = True
        Me.PasdePhotos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasdePhotos.Location = New System.Drawing.Point(531, 61)
        Me.PasdePhotos.Name = "PasdePhotos"
        Me.PasdePhotos.Size = New System.Drawing.Size(373, 20)
        Me.PasdePhotos.TabIndex = 36
        Me.PasdePhotos.Text = "Aucune photo n'est associée à cette étape ..."
        Me.PasdePhotos.Visible = False
        '
        'AC13_Modifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(989, 513)
        Me.Controls.Add(Me.PasdePhotos)
        Me.Controls.Add(Me.Label6)
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
        Me.Controls.Add(Me.Photos)
        Me.Name = "AC13_Modifier"
        Me.Text = " "
        CType(Me.Photo1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Photos.ResumeLayout(False)
        Me.Photos.PerformLayout()
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Photo1 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelHeurePhoto As System.Windows.Forms.Label
    Friend WithEvents Photos As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListePhotos As System.Windows.Forms.ComboBox
    Friend WithEvents PasdePhotos As System.Windows.Forms.Label
End Class
