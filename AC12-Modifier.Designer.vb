﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC12_Modifier
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
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelChauffeur = New System.Windows.Forms.Label()
        Me.LabelCommentaire = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelVehicule = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListeChauffeurs = New System.Windows.Forms.ComboBox()
        Me.ListeVehicules = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.LabelEtapes = New System.Windows.Forms.Label()
        Me.GrilleEtapes = New System.Windows.Forms.DataGridView()
        Me.Valider = New System.Windows.Forms.Button()
        Me.Retour = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.TRNDTE = New System.Windows.Forms.DateTimePicker()
        CType(Me.GrilleEtapes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelDate
        '
        Me.LabelDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.Location = New System.Drawing.Point(21, 86)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(160, 23)
        Me.LabelDate.TabIndex = 0
        Me.LabelDate.Text = "Date"
        '
        'LabelChauffeur
        '
        Me.LabelChauffeur.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelChauffeur.Location = New System.Drawing.Point(21, 152)
        Me.LabelChauffeur.Name = "LabelChauffeur"
        Me.LabelChauffeur.Size = New System.Drawing.Size(160, 23)
        Me.LabelChauffeur.TabIndex = 1
        Me.LabelChauffeur.Text = "Chauffeur"
        '
        'LabelCommentaire
        '
        Me.LabelCommentaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCommentaire.Location = New System.Drawing.Point(21, 319)
        Me.LabelCommentaire.Name = "LabelCommentaire"
        Me.LabelCommentaire.Size = New System.Drawing.Size(160, 23)
        Me.LabelCommentaire.TabIndex = 5
        Me.LabelCommentaire.Text = "Commentaire"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(160, 23)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Prise en charge le"
        '
        'LabelVehicule
        '
        Me.LabelVehicule.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelVehicule.Location = New System.Drawing.Point(21, 210)
        Me.LabelVehicule.Name = "LabelVehicule"
        Me.LabelVehicule.Size = New System.Drawing.Size(160, 23)
        Me.LabelVehicule.TabIndex = 8
        Me.LabelVehicule.Text = "Véhicule"
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(931, 32)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "AC12 - Modifier une tournée"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ListeChauffeurs
        '
        Me.ListeChauffeurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeChauffeurs.FormattingEnabled = True
        Me.ListeChauffeurs.Location = New System.Drawing.Point(245, 147)
        Me.ListeChauffeurs.Name = "ListeChauffeurs"
        Me.ListeChauffeurs.Size = New System.Drawing.Size(248, 28)
        Me.ListeChauffeurs.TabIndex = 11
        '
        'ListeVehicules
        '
        Me.ListeVehicules.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListeVehicules.FormattingEnabled = True
        Me.ListeVehicules.Location = New System.Drawing.Point(245, 210)
        Me.ListeVehicules.Name = "ListeVehicules"
        Me.ListeVehicules.Size = New System.Drawing.Size(248, 28)
        Me.ListeVehicules.TabIndex = 12
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(245, 316)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 82)
        Me.TextBox1.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(245, 259)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(248, 26)
        Me.TextBox2.TabIndex = 15
        '
        'LabelEtapes
        '
        Me.LabelEtapes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelEtapes.Location = New System.Drawing.Point(590, 83)
        Me.LabelEtapes.Name = "LabelEtapes"
        Me.LabelEtapes.Size = New System.Drawing.Size(160, 23)
        Me.LabelEtapes.TabIndex = 19
        Me.LabelEtapes.Text = "Etapes"
        '
        'GrilleEtapes
        '
        Me.GrilleEtapes.AllowUserToAddRows = False
        Me.GrilleEtapes.AllowUserToDeleteRows = False
        Me.GrilleEtapes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.GrilleEtapes.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.GrilleEtapes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrilleEtapes.GridColor = System.Drawing.SystemColors.Control
        Me.GrilleEtapes.Location = New System.Drawing.Point(594, 109)
        Me.GrilleEtapes.Name = "GrilleEtapes"
        Me.GrilleEtapes.ReadOnly = True
        Me.GrilleEtapes.Size = New System.Drawing.Size(325, 150)
        Me.GrilleEtapes.TabIndex = 24
        '
        'Valider
        '
        Me.Valider.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Valider.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Valider.Location = New System.Drawing.Point(12, 416)
        Me.Valider.Name = "Valider"
        Me.Valider.Size = New System.Drawing.Size(118, 49)
        Me.Valider.TabIndex = 25
        Me.Valider.Text = "Valider"
        Me.Valider.UseVisualStyleBackColor = False
        '
        'Retour
        '
        Me.Retour.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Retour.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Retour.Location = New System.Drawing.Point(375, 416)
        Me.Retour.Name = "Retour"
        Me.Retour.Size = New System.Drawing.Size(118, 49)
        Me.Retour.TabIndex = 26
        Me.Retour.Text = "Retour"
        Me.Retour.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ajouter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ajouter.Location = New System.Drawing.Point(594, 275)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(118, 49)
        Me.Ajouter.TabIndex = 27
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Modifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Modifier.Location = New System.Drawing.Point(801, 275)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(118, 49)
        Me.Modifier.TabIndex = 28
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supprimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Supprimer.Location = New System.Drawing.Point(699, 330)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(118, 49)
        Me.Supprimer.TabIndex = 29
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'TRNDTE
        '
        Me.TRNDTE.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TRNDTE.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.TRNDTE.Location = New System.Drawing.Point(245, 83)
        Me.TRNDTE.Name = "TRNDTE"
        Me.TRNDTE.Size = New System.Drawing.Size(248, 26)
        Me.TRNDTE.TabIndex = 10
        Me.TRNDTE.Value = New Date(2019, 12, 18, 15, 48, 0, 0)
        '
        'AC12_Modifier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(931, 477)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.Retour)
        Me.Controls.Add(Me.Valider)
        Me.Controls.Add(Me.GrilleEtapes)
        Me.Controls.Add(Me.LabelEtapes)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ListeVehicules)
        Me.Controls.Add(Me.ListeChauffeurs)
        Me.Controls.Add(Me.TRNDTE)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelVehicule)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.LabelCommentaire)
        Me.Controls.Add(Me.LabelChauffeur)
        Me.Controls.Add(Me.LabelDate)
        Me.Name = "AC12_Modifier"
        Me.Text = "AC12_Modifier"
        CType(Me.GrilleEtapes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelDate As System.Windows.Forms.Label
    Friend WithEvents LabelChauffeur As System.Windows.Forms.Label
    Friend WithEvents LabelCommentaire As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents LabelVehicule As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListeChauffeurs As System.Windows.Forms.ComboBox
    Friend WithEvents ListeVehicules As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents LabelEtapes As System.Windows.Forms.Label
    Friend WithEvents GrilleEtapes As System.Windows.Forms.DataGridView
    Friend WithEvents Valider As System.Windows.Forms.Button
    Friend WithEvents Retour As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents TRNDTE As System.Windows.Forms.DateTimePicker
End Class
