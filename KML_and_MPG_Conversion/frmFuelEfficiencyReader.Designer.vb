<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFuelEfficiencyReader
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
        Me.txtMPG = New System.Windows.Forms.TextBox()
        Me.txtKPL = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblMPG = New System.Windows.Forms.Label()
        Me.lblKPL = New System.Windows.Forms.Label()
        Me.lblIstructions = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtMPG
        '
        Me.txtMPG.Location = New System.Drawing.Point(58, 116)
        Me.txtMPG.Name = "txtMPG"
        Me.txtMPG.Size = New System.Drawing.Size(100, 20)
        Me.txtMPG.TabIndex = 0
        '
        'txtKPL
        '
        Me.txtKPL.Location = New System.Drawing.Point(343, 116)
        Me.txtKPL.Name = "txtKPL"
        Me.txtKPL.Size = New System.Drawing.Size(100, 20)
        Me.txtKPL.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(196, 114)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(75, 23)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 157)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 3
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'lblMPG
        '
        Me.lblMPG.AutoSize = True
        Me.lblMPG.Location = New System.Drawing.Point(21, 116)
        Me.lblMPG.Name = "lblMPG"
        Me.lblMPG.Size = New System.Drawing.Size(31, 13)
        Me.lblMPG.TabIndex = 4
        Me.lblMPG.Text = "MPG"
        '
        'lblKPL
        '
        Me.lblKPL.AutoSize = True
        Me.lblKPL.Location = New System.Drawing.Point(308, 116)
        Me.lblKPL.Name = "lblKPL"
        Me.lblKPL.Size = New System.Drawing.Size(27, 13)
        Me.lblKPL.TabIndex = 5
        Me.lblKPL.Text = "KPL"
        '
        'lblIstructions
        '
        Me.lblIstructions.AutoSize = True
        Me.lblIstructions.Location = New System.Drawing.Point(12, 28)
        Me.lblIstructions.Name = "lblIstructions"
        Me.lblIstructions.Size = New System.Drawing.Size(449, 13)
        Me.lblIstructions.TabIndex = 6
        Me.lblIstructions.Text = "Instructions: 1.)  Type in the kilometers per liter or the miles per gallon in th" & _
            "e corresponding box"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "2.) Click ""Convert"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "3.) When finished click ""Clear"" to begin a new conversion"
        '
        'frmFuelEfficiencyReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(496, 262)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblIstructions)
        Me.Controls.Add(Me.lblKPL)
        Me.Controls.Add(Me.lblMPG)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtKPL)
        Me.Controls.Add(Me.txtMPG)
        Me.Name = "frmFuelEfficiencyReader"
        Me.Text = "Fuel Efficiency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMPG As System.Windows.Forms.TextBox
    Friend WithEvents txtKPL As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblMPG As System.Windows.Forms.Label
    Friend WithEvents lblKPL As System.Windows.Forms.Label
    Friend WithEvents lblIstructions As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
