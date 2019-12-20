<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AC11
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListeTournees = New System.Windows.Forms.DataGridView()
        Me.LabelTournee = New System.Windows.Forms.Label()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.Modifier = New System.Windows.Forms.Button()
        Me.Ajouter = New System.Windows.Forms.Button()
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeTournees
        '
        Me.ListeTournees.AllowUserToAddRows = False
        Me.ListeTournees.AllowUserToDeleteRows = False
        Me.ListeTournees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListeTournees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListeTournees.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListeTournees.ColumnHeadersHeight = 24
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListeTournees.DefaultCellStyle = DataGridViewCellStyle2
        Me.ListeTournees.GridColor = System.Drawing.SystemColors.Control
        Me.ListeTournees.Location = New System.Drawing.Point(12, 39)
        Me.ListeTournees.Name = "ListeTournees"
        Me.ListeTournees.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.ListeTournees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ListeTournees.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.ListeTournees.Size = New System.Drawing.Size(1007, 334)
        Me.ListeTournees.TabIndex = 0
        '
        'LabelTournee
        '
        Me.LabelTournee.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTournee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTournee.Location = New System.Drawing.Point(0, 0)
        Me.LabelTournee.Name = "LabelTournee"
        Me.LabelTournee.Size = New System.Drawing.Size(1156, 36)
        Me.LabelTournee.TabIndex = 1
        Me.LabelTournee.Text = "AC11 - Liste des Tournées"
        Me.LabelTournee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supprimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Supprimer.Location = New System.Drawing.Point(1025, 324)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(118, 49)
        Me.Supprimer.TabIndex = 2
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Modifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Modifier.Location = New System.Drawing.Point(1026, 192)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(118, 49)
        Me.Modifier.TabIndex = 3
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'Ajouter
        '
        Me.Ajouter.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Ajouter.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Ajouter.Location = New System.Drawing.Point(1026, 65)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(118, 49)
        Me.Ajouter.TabIndex = 4
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = False
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1156, 385)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.LabelTournee)
        Me.Controls.Add(Me.ListeTournees)
        Me.Name = "AC11"
        Me.Text = "AC11"
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeTournees As System.Windows.Forms.DataGridView
    Friend WithEvents LabelTournee As System.Windows.Forms.Label
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents TRNPECCHAUFFEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modifier As System.Windows.Forms.Button
    Friend WithEvents Ajouter As System.Windows.Forms.Button
End Class
