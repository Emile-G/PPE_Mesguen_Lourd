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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListeTournees = New System.Windows.Forms.DataGridView()
        Me.NTourneeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemorqueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentaireDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArriverDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PPE_Mesguen_Lourd.DataSet1()
        Me.LabelTournee = New System.Windows.Forms.Label()
        Me.Supprimer = New System.Windows.Forms.Button()
        Me.DataTable1TableAdapter = New PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.Modifier = New System.Windows.Forms.Button()
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeTournees
        '
        Me.ListeTournees.AllowUserToAddRows = False
        Me.ListeTournees.AllowUserToDeleteRows = False
        Me.ListeTournees.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListeTournees.AutoGenerateColumns = False
        Me.ListeTournees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.ListeTournees.BackgroundColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListeTournees.ColumnHeadersHeight = 24
        Me.ListeTournees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NTourneeDataGridViewTextBoxColumn, Me.NomDataGridViewTextBoxColumn, Me.RemorqueDataGridViewTextBoxColumn, Me.CommentaireDataGridViewTextBoxColumn, Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn, Me.DepartDataGridViewTextBoxColumn, Me.ArriverDataGridViewTextBoxColumn})
        Me.ListeTournees.DataSource = Me.DataTable1BindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.YellowGreen
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListeTournees.DefaultCellStyle = DataGridViewCellStyle6
        Me.ListeTournees.GridColor = System.Drawing.SystemColors.Control
        Me.ListeTournees.Location = New System.Drawing.Point(12, 39)
        Me.ListeTournees.Name = "ListeTournees"
        Me.ListeTournees.ReadOnly = True
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.RowHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.ListeTournees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ListeTournees.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.ListeTournees.Size = New System.Drawing.Size(1007, 410)
        Me.ListeTournees.TabIndex = 0
        '
        'NTourneeDataGridViewTextBoxColumn
        '
        Me.NTourneeDataGridViewTextBoxColumn.DataPropertyName = "N° Tournee"
        Me.NTourneeDataGridViewTextBoxColumn.HeaderText = "N° Tournee"
        Me.NTourneeDataGridViewTextBoxColumn.Name = "NTourneeDataGridViewTextBoxColumn"
        Me.NTourneeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NomDataGridViewTextBoxColumn
        '
        Me.NomDataGridViewTextBoxColumn.DataPropertyName = "Nom"
        Me.NomDataGridViewTextBoxColumn.HeaderText = "Nom"
        Me.NomDataGridViewTextBoxColumn.Name = "NomDataGridViewTextBoxColumn"
        Me.NomDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemorqueDataGridViewTextBoxColumn
        '
        Me.RemorqueDataGridViewTextBoxColumn.DataPropertyName = "Remorque"
        Me.RemorqueDataGridViewTextBoxColumn.HeaderText = "Remorque"
        Me.RemorqueDataGridViewTextBoxColumn.Name = "RemorqueDataGridViewTextBoxColumn"
        Me.RemorqueDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CommentaireDataGridViewTextBoxColumn
        '
        Me.CommentaireDataGridViewTextBoxColumn.DataPropertyName = "Commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.HeaderText = "Commentaire"
        Me.CommentaireDataGridViewTextBoxColumn.Name = "CommentaireDataGridViewTextBoxColumn"
        Me.CommentaireDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ImmatriculationVéhiculeDataGridViewTextBoxColumn
        '
        Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn.DataPropertyName = "Immatriculation véhicule"
        Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn.HeaderText = "Immatriculation véhicule"
        Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn.Name = "ImmatriculationVéhiculeDataGridViewTextBoxColumn"
        Me.ImmatriculationVéhiculeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DepartDataGridViewTextBoxColumn
        '
        Me.DepartDataGridViewTextBoxColumn.DataPropertyName = "Depart"
        Me.DepartDataGridViewTextBoxColumn.HeaderText = "Depart"
        Me.DepartDataGridViewTextBoxColumn.Name = "DepartDataGridViewTextBoxColumn"
        Me.DepartDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ArriverDataGridViewTextBoxColumn
        '
        Me.ArriverDataGridViewTextBoxColumn.DataPropertyName = "Arriver"
        Me.ArriverDataGridViewTextBoxColumn.HeaderText = "Arriver"
        Me.ArriverDataGridViewTextBoxColumn.Name = "ArriverDataGridViewTextBoxColumn"
        Me.ArriverDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataTable1BindingSource
        '
        Me.DataTable1BindingSource.DataMember = "DataTable1"
        Me.DataTable1BindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LabelTournee
        '
        Me.LabelTournee.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelTournee.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTournee.Location = New System.Drawing.Point(0, 0)
        Me.LabelTournee.Name = "LabelTournee"
        Me.LabelTournee.Size = New System.Drawing.Size(1274, 36)
        Me.LabelTournee.TabIndex = 1
        Me.LabelTournee.Text = "Liste des Tournées"
        Me.LabelTournee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Supprimer
        '
        Me.Supprimer.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Supprimer.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Supprimer.Location = New System.Drawing.Point(1144, 39)
        Me.Supprimer.Name = "Supprimer"
        Me.Supprimer.Size = New System.Drawing.Size(118, 49)
        Me.Supprimer.TabIndex = 2
        Me.Supprimer.Text = "Supprimer"
        Me.Supprimer.UseVisualStyleBackColor = False
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'Modifier
        '
        Me.Modifier.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Modifier.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Modifier.Location = New System.Drawing.Point(1144, 112)
        Me.Modifier.Name = "Modifier"
        Me.Modifier.Size = New System.Drawing.Size(118, 49)
        Me.Modifier.TabIndex = 3
        Me.Modifier.Text = "Modifier"
        Me.Modifier.UseVisualStyleBackColor = False
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1274, 614)
        Me.Controls.Add(Me.Modifier)
        Me.Controls.Add(Me.Supprimer)
        Me.Controls.Add(Me.LabelTournee)
        Me.Controls.Add(Me.ListeTournees)
        Me.Name = "AC11"
        Me.Text = "AC11"
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeTournees As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As PPE_Mesguen_Lourd.DataSet1
    Friend WithEvents LabelTournee As System.Windows.Forms.Label
    Friend WithEvents Supprimer As System.Windows.Forms.Button
    Friend WithEvents TRNPECCHAUFFEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents NTourneeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemorqueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CommentaireDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ImmatriculationVéhiculeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ArriverDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modifier As System.Windows.Forms.Button
End Class
