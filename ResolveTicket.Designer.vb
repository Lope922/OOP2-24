<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ResolveTicket
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
        Me.lblTicketInfo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTicketResolution = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpTicketResolveDate = New System.Windows.Forms.DateTimePicker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.SuspendLayout()
        '
        'lblTicketInfo
        '
        Me.lblTicketInfo.AutoSize = True
        Me.lblTicketInfo.Location = New System.Drawing.Point(12, 9)
        Me.lblTicketInfo.Name = "lblTicketInfo"
        Me.lblTicketInfo.Size = New System.Drawing.Size(94, 13)
        Me.lblTicketInfo.TabIndex = 0
        Me.lblTicketInfo.Text = "Ticket information "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter Resolution : "
        '
        'txtTicketResolution
        '
        Me.txtTicketResolution.Location = New System.Drawing.Point(15, 60)
        Me.txtTicketResolution.Multiline = True
        Me.txtTicketResolution.Name = "txtTicketResolution"
        Me.txtTicketResolution.Size = New System.Drawing.Size(257, 61)
        Me.txtTicketResolution.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Resolution Date"
        '
        'dtpTicketResolveDate
        '
        Me.dtpTicketResolveDate.Location = New System.Drawing.Point(32, 171)
        Me.dtpTicketResolveDate.Name = "dtpTicketResolveDate"
        Me.dtpTicketResolveDate.Size = New System.Drawing.Size(200, 20)
        Me.dtpTicketResolveDate.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(113, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "OK "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 211)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ResolveTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtpTicketResolveDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTicketResolution)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTicketInfo)
        Me.Name = "ResolveTicket"
        Me.Text = "ResolveTicket"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTicketInfo As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtTicketResolution As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dtpTicketResolveDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
End Class
