Public Class ResolveTicket
    Private Sub ResolveTicket_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Suggested resolve date is now
        dtpTicketResolveDate.Value = Date.Now
        'Display ticket information for the user
        'T ag is a property of every form
        'It can store any object. It is often used to send
        'an object from one form to another
        lblTicketInfo.Text = Tag.ToString
        'Clear the text box
        txtTicketResolution.Text = ""

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Dialog1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Suggested resolve date is now
        dtpTicketResolveDate.Value = Date.Now
        'Display ticket information for the user
        'Tag is a property of every form
        'It can store any object. It is often used to send
        'an object from one form to another
        lblTicketInfo.Text = Tag.ToString
        'Clear the text box
        txtTicketResolution.Text = ""

    End Sub
    ' this bit of code will open the save dialog when the user clicks the button to save list 
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        With SaveFileDialog1
            .DefaultExt = "txt"
            .FileName = strfilename
            .Filter = "Text documents (*.txt) | *.txt|All Files (*.*)| *.*"
            .FilterIndex = 1
            .OverwritePrompt = True
            .Title = "Save File As..."
        End With

        ' show the save dialog if the user clicks the button 
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'save the file path and name 
                ' strFileName = SaveFileDialog1.FileName

            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    ' need to write code for how data will be written into the file 

    ' as issues are resolved need to remove them from the initial list 


    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If txtTicketResolution.Text = "" Then
            MessageBox.Show("Please enter a resolution")
            Return
        End If


        Dim ticketToResolve As Ticket = CType(Tag, Ticket)
        ticketToResolve.Resolution = txtTicketResolution.Text
        ticketToResolve.DateResolved = dtpTicketResolveDate.Value
        Me.Tag = ticketToResolve

        Me.DialogResult = System.Windows.Forms.DialogResult.OK

        Me.Close()
    End Sub
End Class

 