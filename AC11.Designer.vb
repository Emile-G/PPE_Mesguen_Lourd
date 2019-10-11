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
        Me.DataTable2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LabelTournee = New System.Windows.Forms.Label()
        Me.DataTable1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TOURNEEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New PPE_Mesguen_Lourd.DataSet1()
        Me.TOURNEETableAdapter = New PPE_Mesguen_Lourd.DataSet1TableAdapters.TOURNEETableAdapter()
        Me.DataTable1BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable1TableAdapter = New PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable1TableAdapter()
        Me.TRNNUMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CHFPRENOMDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.REMORQUEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNDTEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VEHIMMATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEDEPARTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ETAPEARRIVERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataSet11 = New PPE_Mesguen_Lourd.DataSet1()
        Me.DataTable2BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataTable2TableAdapter = New PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable2TableAdapter()
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListeTournees
        '
        Me.ListeTournees.AllowUserToAddRows = False
        Me.ListeTournees.AllowUserToDeleteRows = False
        Me.ListeTournees.AutoGenerateColumns = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ListeTournees.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.ListeTournees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ListeTournees.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TRNNUMDataGridViewTextBoxColumn, Me.CHFPRENOMDataGridViewTextBoxColumn, Me.REMORQUEDataGridViewTextBoxColumn, Me.TRNCOMMENTAIREDataGridViewTextBoxColumn, Me.TRNDTEDataGridViewTextBoxColumn, Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn, Me.VEHIMMATDataGridViewTextBoxColumn, Me.ETAPEDEPARTDataGridViewTextBoxColumn, Me.ETAPEARRIVERDataGridViewTextBoxColumn})
        Me.ListeTournees.DataSource = Me.DataTable2BindingSource1
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ListeTournees.DefaultCellStyle = DataGridViewCellStyle6
        Me.ListeTournees.Location = New System.Drawing.Point(171, 39)
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
        Me.ListeTournees.Size = New System.Drawing.Size(934, 335)
        Me.ListeTournees.TabIndex = 0
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
        'DataTable1BindingSource1
        '
        Me.DataTable1BindingSource1.DataMember = "DataTable1"
        Me.DataTable1BindingSource1.DataSource = Me.DataSet1
        '
        'DataTable1TableAdapter
        '
        Me.DataTable1TableAdapter.ClearBeforeFill = True
        '
        'TRNNUMDataGridViewTextBoxColumn
        '
        Me.TRNNUMDataGridViewTextBoxColumn.DataPropertyName = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.HeaderText = "TRNNUM"
        Me.TRNNUMDataGridViewTextBoxColumn.Name = "TRNNUMDataGridViewTextBoxColumn"
        Me.TRNNUMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CHFPRENOMDataGridViewTextBoxColumn
        '
        Me.CHFPRENOMDataGridViewTextBoxColumn.DataPropertyName = "CHFPRENOM"
        Me.CHFPRENOMDataGridViewTextBoxColumn.HeaderText = "CHFPRENOM"
        Me.CHFPRENOMDataGridViewTextBoxColumn.Name = "CHFPRENOMDataGridViewTextBoxColumn"
        Me.CHFPRENOMDataGridViewTextBoxColumn.ReadOnly = True
        '
        'REMORQUEDataGridViewTextBoxColumn
        '
        Me.REMORQUEDataGridViewTextBoxColumn.DataPropertyName = "REMORQUE"
        Me.REMORQUEDataGridViewTextBoxColumn.HeaderText = "REMORQUE"
        Me.REMORQUEDataGridViewTextBoxColumn.Name = "REMORQUEDataGridViewTextBoxColumn"
        Me.REMORQUEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNCOMMENTAIREDataGridViewTextBoxColumn
        '
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.DataPropertyName = "TRNCOMMENTAIRE"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.HeaderText = "TRNCOMMENTAIRE"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.Name = "TRNCOMMENTAIREDataGridViewTextBoxColumn"
        Me.TRNCOMMENTAIREDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNDTEDataGridViewTextBoxColumn
        '
        Me.TRNDTEDataGridViewTextBoxColumn.DataPropertyName = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.HeaderText = "TRNDTE"
        Me.TRNDTEDataGridViewTextBoxColumn.Name = "TRNDTEDataGridViewTextBoxColumn"
        Me.TRNDTEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TRNPECCHAUFFEURDataGridViewTextBoxColumn
        '
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.DataPropertyName = "TRNPECCHAUFFEUR"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.HeaderText = "TRNPECCHAUFFEUR"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.Name = "TRNPECCHAUFFEURDataGridViewTextBoxColumn"
        Me.TRNPECCHAUFFEURDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VEHIMMATDataGridViewTextBoxColumn
        '
        Me.VEHIMMATDataGridViewTextBoxColumn.DataPropertyName = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.HeaderText = "VEHIMMAT"
        Me.VEHIMMATDataGridViewTextBoxColumn.Name = "VEHIMMATDataGridViewTextBoxColumn"
        Me.VEHIMMATDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETAPEDEPARTDataGridViewTextBoxColumn
        '
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_DEPART"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.HeaderText = "ETAPE_DEPART"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.Name = "ETAPEDEPARTDataGridViewTextBoxColumn"
        Me.ETAPEDEPARTDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ETAPEARRIVERDataGridViewTextBoxColumn
        '
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.DataPropertyName = "ETAPE_ARRIVER"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.HeaderText = "ETAPE_ARRIVER"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.Name = "ETAPEARRIVERDataGridViewTextBoxColumn"
        Me.ETAPEARRIVERDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataTable2BindingSource1
        '
        Me.DataTable2BindingSource1.DataMember = "DataTable2"
        Me.DataTable2BindingSource1.DataSource = Me.DataSet11
        '
        'DataTable2TableAdapter
        '
        Me.DataTable2TableAdapter.ClearBeforeFill = True
        '
        'AC11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.YellowGreen
        Me.ClientSize = New System.Drawing.Size(1274, 614)
        Me.Controls.Add(Me.LabelTournee)
        Me.Controls.Add(Me.ListeTournees)
        Me.Name = "AC11"
        Me.Text = "AC11"
        CType(Me.ListeTournees, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TOURNEEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable1BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataTable2BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListeTournees As System.Windows.Forms.DataGridView
    Friend WithEvents DataSet1 As PPE_Mesguen_Lourd.DataSet1
    Friend WithEvents TOURNEEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TOURNEETableAdapter As PPE_Mesguen_Lourd.DataSet1TableAdapters.TOURNEETableAdapter
    Friend WithEvents LabelTournee As System.Windows.Forms.Label
    Friend WithEvents DataTable1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable1TableAdapter As PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable1TableAdapter
    Friend WithEvents TRNNUMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CHFPRENOMDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents REMORQUEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNCOMMENTAIREDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNDTEDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TRNPECCHAUFFEURDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VEHIMMATDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEDEPARTDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ETAPEARRIVERDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataSet11 As PPE_Mesguen_Lourd.DataSet1
    Friend WithEvents DataTable2BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataTable2TableAdapter As PPE_Mesguen_Lourd.DataSet1TableAdapters.DataTable2TableAdapter
End Class
