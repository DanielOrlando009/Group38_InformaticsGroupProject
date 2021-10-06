<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGUI
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
        Me.btnBegin = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.RichTextBox()
        Me.lblMoney = New System.Windows.Forms.Label()
        Me.txtMoney = New System.Windows.Forms.TextBox()
        Me.lblAward = New System.Windows.Forms.Label()
        Me.txtAward = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnBegin
        '
        Me.btnBegin.Location = New System.Drawing.Point(204, 12)
        Me.btnBegin.Name = "btnBegin"
        Me.btnBegin.Size = New System.Drawing.Size(115, 53)
        Me.btnBegin.TabIndex = 0
        Me.btnBegin.Text = "Enter Data"
        Me.btnBegin.UseVisualStyleBackColor = True
        '
        'txtOutput
        '
        Me.txtOutput.Enabled = False
        Me.txtOutput.Location = New System.Drawing.Point(12, 71)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(495, 234)
        Me.txtOutput.TabIndex = 1
        Me.txtOutput.Text = ""
        '
        'lblMoney
        '
        Me.lblMoney.AutoSize = True
        Me.lblMoney.Location = New System.Drawing.Point(12, 320)
        Me.lblMoney.Name = "lblMoney"
        Me.lblMoney.Size = New System.Drawing.Size(72, 13)
        Me.lblMoney.TabIndex = 2
        Me.lblMoney.Text = "Money Made:"
        '
        'txtMoney
        '
        Me.txtMoney.Location = New System.Drawing.Point(112, 313)
        Me.txtMoney.Name = "txtMoney"
        Me.txtMoney.Size = New System.Drawing.Size(148, 20)
        Me.txtMoney.TabIndex = 3
        '
        'lblAward
        '
        Me.lblAward.AutoSize = True
        Me.lblAward.Location = New System.Drawing.Point(12, 358)
        Me.lblAward.Name = "lblAward"
        Me.lblAward.Size = New System.Drawing.Size(89, 13)
        Me.lblAward.TabIndex = 4
        Me.lblAward.Text = "Award Received:"
        '
        'txtAward
        '
        Me.txtAward.Location = New System.Drawing.Point(112, 351)
        Me.txtAward.Name = "txtAward"
        Me.txtAward.Size = New System.Drawing.Size(148, 20)
        Me.txtAward.TabIndex = 5
        '
        'frmGUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 415)
        Me.Controls.Add(Me.txtAward)
        Me.Controls.Add(Me.lblAward)
        Me.Controls.Add(Me.txtMoney)
        Me.Controls.Add(Me.lblMoney)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnBegin)
        Me.Name = "frmGUI"
        Me.Text = "Enviromental Bonus Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBegin As Button
    Friend WithEvents txtOutput As RichTextBox
    Friend WithEvents lblMoney As Label
    Friend WithEvents txtMoney As TextBox
    Friend WithEvents lblAward As Label
    Friend WithEvents txtAward As TextBox
End Class
