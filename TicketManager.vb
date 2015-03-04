Public Class TicketManager

    Private TicketQueue As New TicketQueue
    ' by adding this line of resolvedticketlist this allows the two lists to communicate
    Private ResolvedTicketList As New TicketQueue

   
    Private Sub btnAddTicket_Click(sender As Object, e As EventArgs) Handles btnAddTicket.Click

        Dim newTicket As New Ticket
        newTicket.Issue = txtTicketIssue.Text
        newTicket.Reporter = txtTicketReporter.Text
        newTicket.Severity = CInt(numTicketSeverity.Value)
        newTicket.dateReported = Date.Now()

        TicketQueue.Add(newTicket)

        'lstTicketList.items.add(newTicket)
        refreshTicketList()
    End Sub

    Public Sub refreshTicketList()
        lstTicketList.Items.Clear()

        For Each t As Ticket In TicketQueue
            lstTicketList.Items.add(t)
        Next
    End Sub

    Private Sub btnDeleteTicket_Click(sender As Object, e As EventArgs) Handles btnDeleteTicket.Click

        'If nothing selected, then don't delete anything
        If lstTicketList.SelectedIndex = -1 Then
            MessageBox.Show("You must select a ticket to resolve")
        Else

            'Open dialog box for user to enter resolution info

            'Use the Tag property to send the Ticket we want to the Dialog box 				 
            'tag is a property belonging to a form. 
            'it can store any object. It is often used to send an object from one form to another. Set the tag property 
            'of the form we want to sent data * to* 
            ResolveTicket.Tag = lstTicketList.SelectedItem
        
            If ResolveTicket.ShowDialog = DialogResult.OK Then
                TicketQueue.Remove(CType(lstTicketList.SelectedItem, Ticket))
                refreshTicketList()
                ResolvedTicketList.add(CType(ResolveTicket.Tag, Ticket))
            End If
        End If
    End Sub

    ' this is the save button on the front of the list when it is clicked write the file into 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SaveFileOption As New SaveFileDialog
        If (SaveFileOption.ShowDialog = Windows.Forms.DialogResult.OK) Then
            'make sure filename is not empty 
            For Each Ticket As Ticket In ResolvedTicketList
                My.Computer.FileSystem.WriteAllText(SaveFileOption.FileName, Ticket.ToString, True) ' my.computer is directory / savefile variable is full directory path. , 
                'after the comma what i am writing to the file, True is actually write to file. 
            Next
        End If
    End Sub
End Class
