<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolvedTickets
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
        Me.SavebtnResolvedTickets = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstBoxResolvedTickets = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'SavebtnResolvedTickets
        '
        Me.SavebtnResolvedTickets.Location = New System.Drawing.Point(12, 172)
        Me.SavebtnResolvedTickets.Name = "SavebtnResolvedTickets"
        Me.SavebtnResolvedTickets.Size = New System.Drawing.Size(172, 23)
        Me.SavebtnResolvedTickets.TabIndex = 0
        Me.SavebtnResolvedTickets.Text = "Save Resolved Tickets "
        Me.SavebtnResolvedTickets.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(95, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "List of resolved tickets "
        '
        'lstBoxResolvedTickets
        '
        Me.lstBoxResolvedTickets.FormattingEnabled = True
        Me.lstBoxResolvedTickets.Location = New System.Drawing.Point(98, 55)
        Me.lstBoxResolvedTickets.Name = "lstBoxResolvedTickets"
        Me.lstBoxResolvedTickets.Size = New System.Drawing.Size(120, 95)
        Me.lstBoxResolvedTickets.TabIndex = 2
        '
        'ResolvedTickets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lstBoxResolvedTickets)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.SavebtnResolvedTickets)
        Me.Name = "ResolvedTickets"
        Me.Text = "ResolvedTickets"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SavebtnResolvedTickets As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lstBoxResolvedTickets As System.Windows.Forms.ListBox
End Class
