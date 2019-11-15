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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ListeTournees = New System.Windows.Forms.DataGridView()
        Me.TRNNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNDTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHFIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHIMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMORQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TOURNEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PPE_Mesguen_Lourd.DataSet1()
        Me.TOURNEETableAdapter = New PPE_Mesguen_Lourd.DataSet1TableAdapters.TOURNEETableAdapter()
        Me.LabelTournee = New System.Windows.Forms.Label()
        Me.Ajouter = New System.Windows.Forms.Button()
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeTournees
        '
        Me.ListeTournees.AllowUserToAddRows = False
        Me.ListeTournees.AllowUserToDeleteRows = False
        Me.ListeTournees.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.ListeTournees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListeTournees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRNNUMDataGridViewTextBoxColumn, Me.TRNDTEDataGridViewTextBoxColumn, Me.CHFIDDataGridViewTextBoxColumn, Me.VEHIMMATDataGridViewTextBoxColumn, Me.TRNCOMMENTAIREDataGridViewTextBoxColumn, Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn, Me.REMORQUEDataGridViewTextBoxColumn})
        Me.ListeTournees.DataSource = Me.TOURNEEBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListeTournees.DefaultCellStyle = DataGridViewCellStyle9
        Me.ListeTournees.Location = New System.Drawing.Point(217, 39)
        Me.ListeTournees.Name = "ListeTournees"
        Me.ListeTournees.ReadOnly = True
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.RowHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.ListeTournees.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.ListeTournees.RowsDefaultCellStyle = DataGridViewCellStyle11
        Me.ListeTournees.Size = New System.Drawing.Size(802, 335)
        Me.ListeTournees.TabIndex = 0
        '
        'TRNNUMDataGridViewTextBoxColumn
        '
        Me.TRNNUMDataGridViewTextBoxColumn.DataPropertyName = "TRNNUM"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TRNNUMDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.TRNNUMDataGridViewTextBoxColumn.HeaderText = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.Name = "TRNNUMDataGridViewTextBoxColumn"
        Me.TRNNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNDTEDataGridViewTextBoxColumn
        '
        Me.TRNDTEDataGridViewTextBoxColumn.DataPropertyName = "TRNDTE"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TRNDTEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.TRNDTEDataGridViewTextBoxColumn.HeaderText = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.Name = "TRNDTEDataGridViewTextBoxColumn"
        Me.TRNDTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CHFIDDataGridViewTextBoxColumn
        '
        Me.CHFIDDataGridViewTextBoxColumn.DataPropertyName = "CHFID"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.CHFIDDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle4
        Me.CHFIDDataGridViewTextBoxColumn.HeaderText = "CHFID"
        Me.CHFIDDataGridViewTextBoxColumn.Name = "CHFIDDataGridViewTextBoxColumn"
        Me.CHFIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VEHIMMATDataGridViewTextBoxColumn
        '
        Me.VEHIMMATDataGridViewTextBoxColumn.DataPropertyName = "VEHIMMAT"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.VEHIMMATDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.VEHIMMATDataGridViewTextBoxColumn.HeaderText = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.Name = "VEHIMMATDataGridViewTextBoxColumn"
        Me.VEHIMMATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNCOMMENTAIREDataGridViewTextBoxColumn
        '
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "TRNCOMMENTAIRE"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle6
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "TRNCOMMENTAIRE"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.Name = "TRNCOMMENTAIREDataGridViewTextBoxColumn"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = True
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.Width = 125
        '
        'TRNPECCHAUFFEURDataGridViewTextBoxColumn
        '
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.DataPropertyName = "TRNPECCHAUFFEUR"
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.HeaderText = "TRNPECCHAUFFEUR"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.Name = "TRNPECCHAUFFEURDataGridViewTextBoxColumn"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.ReadOnly = True
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.Width = 135
        '
        'REMORQUEDataGridViewTextBoxColumn
        '
        Me.REMORQUEDataGridViewTextBoxColumn.DataPropertyName = "REMORQUE"
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.REMORQUEDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle8
        Me.REMORQUEDataGridViewTextBoxColumn.HeaderText = "REMORQUE"
        Me.REMORQUEDataGridViewTextBoxColumn.Name = "REMORQUEDataGridViewTextBoxColumn"
        Me.REMORQUEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TOURNEEBindingSource
        '
        Me.TOURNEEBindingSource.DataMember = "TOURNEE"
        Me.TOURNEEBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TOURNEETableAdapter
        '
        Me.TOURNEETableAdapter.ClearBeforeFill = True
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
        'Ajouter
        '
        Me.Ajouter.Location = New System.Drawing.Point(217, 480)
        Me.Ajouter.Name = "Ajouter"
        Me.Ajouter.Size = New System.Drawing.Size(102, 23)
        Me.Ajouter.TabIndex = 2
        Me.Ajouter.Text = "Ajouter"
        Me.Ajouter.UseVisualStyleBackColor = True
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1274, 614)
        Me.Controls.Add(Me.Ajouter)
        Me.Controls.Add(Me.LabelTournee)
        Me.Controls.Add(Me.ListeTournees)
        Me.Name = "AC11"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AC11"
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeTournees As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As PPE_Mesguen_Lourd.DataSet1
    Friend WithEvents TOURNEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOURNEETableAdapter As PPE_Mesguen_Lourd.DataSet1TableAdapters.TOURNEETableAdapter
    Friend WithEvents LabelTournee As System.Windows.Forms.Label
    Friend WithEvents TRNNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNDTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHFIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHIMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNCOMMENTAIREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNPECCHAUFFEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMORQUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ajouter As System.Windows.Forms.Button
End Class
