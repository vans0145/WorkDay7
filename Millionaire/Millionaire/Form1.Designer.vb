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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWhen = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(75, 81)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(200, 49)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate Years to Become Millionaire"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(175, 33)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtAmount.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(72, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Amount Deposited:"
        '
        'txtWhen
        '
        Me.txtWhen.Location = New System.Drawing.Point(69, 162)
        Me.txtWhen.Name = "txtWhen"
        Me.txtWhen.ReadOnly = True
        Me.txtWhen.Size = New System.Drawing.Size(206, 20)
        Me.txtWhen.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(358, 230)
        Me.Controls.Add(Me.txtWhen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Millionaire"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtWhen As System.Windows.Forms.TextBox

End Class
