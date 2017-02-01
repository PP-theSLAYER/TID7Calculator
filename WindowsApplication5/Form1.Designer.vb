<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.datagrid2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Find_G7TID = New System.Windows.Forms.TextBox()
        Me.GenVII_TID_ANS = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.ProgBar = New System.Windows.Forms.ProgressBar()
        CType(Me.datagrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackgroundWorker1
        '
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(195, 351)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(86, 22)
        Me.Button5.TabIndex = 188
        Me.Button5.Text = "TID SID test"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'datagrid2
        '
        Me.datagrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagrid2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column23})
        Me.datagrid2.Location = New System.Drawing.Point(12, 12)
        Me.datagrid2.Name = "datagrid2"
        Me.datagrid2.Size = New System.Drawing.Size(361, 322)
        Me.datagrid2.TabIndex = 186
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "TID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 70
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "SID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 70
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "G7TID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 70
        '
        'Column23
        '
        Me.Column23.HeaderText = "intendedvalue"
        Me.Column23.Name = "Column23"
        '
        'Find_G7TID
        '
        Me.Find_G7TID.Location = New System.Drawing.Point(113, 353)
        Me.Find_G7TID.Name = "Find_G7TID"
        Me.Find_G7TID.Size = New System.Drawing.Size(63, 20)
        Me.Find_G7TID.TabIndex = 183
        '
        'GenVII_TID_ANS
        '
        Me.GenVII_TID_ANS.AutoSize = True
        Me.GenVII_TID_ANS.Location = New System.Drawing.Point(25, 356)
        Me.GenVII_TID_ANS.Name = "GenVII_TID_ANS"
        Me.GenVII_TID_ANS.Size = New System.Drawing.Size(76, 13)
        Me.GenVII_TID_ANS.TabIndex = 63
        Me.GenVII_TID_ANS.Text = "Intended TID7"
        '
        'Button6
        '
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(287, 351)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(86, 22)
        Me.Button6.TabIndex = 189
        Me.Button6.Text = "Cancel"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'ProgBar
        '
        Me.ProgBar.Location = New System.Drawing.Point(-1, 379)
        Me.ProgBar.Name = "ProgBar"
        Me.ProgBar.Size = New System.Drawing.Size(384, 19)
        Me.ProgBar.TabIndex = 187
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 408)
        Me.Controls.Add(Me.Find_G7TID)
        Me.Controls.Add(Me.ProgBar)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.datagrid2)
        Me.Controls.Add(Me.GenVII_TID_ANS)
        Me.Name = "Form1"
        Me.Text = "TID7 Calculator"
        CType(Me.datagrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button5 As Button
    Friend WithEvents datagrid2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column23 As DataGridViewTextBoxColumn
    Friend WithEvents Find_G7TID As TextBox
    Private WithEvents GenVII_TID_ANS As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents ProgBar As ProgressBar
End Class
