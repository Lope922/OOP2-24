Public Class TicketQueue

    Inherits CollectionBase

    Public Sub add(newTicket As Ticket)

        'Add the new ticket in order - highest severity at the front of the list

        'If list if empty, add the ticket and return.
        If Me.List.Count = 0 Then
            Me.List.Add(newTicket)
            Return
        End If

        'Otherwise, need to add the ticket in order. 
        'Search the list. When we find a ticket with severity equal or less than this new ticket,
        'then add this new ticket to this position.
        'For example, we have tickets with severity 5, 4, 2. Our new ticket is 3.
        'The loop will pass over 5, 4 and then 3 is <= 2 so it will be inserted where the severity 2 ticket is.
        For indexCounter As Integer = 0 To Me.List.Count
            If (Me.Item(indexCounter)).severity <= newTicket.severity Then
                Me.List.Insert(indexCounter, newTicket)
                Return
            End If
        Next

        'What if we don't find a ticket with severity <= ours? That means our ticket has lower severity
        'than any other ticket in the list. So, add the new ticket at the end. 
        Me.List.Add(newTicket)

    End Sub

    Public Sub Remove(oldTicket As Ticket)
        Me.List.Remove(oldTicket)
    End Sub

    Public Property Item(index As Integer) As Ticket
        Get
            Return CType(Me.List.Item(index), Ticket)
        End Get
        Set(value As Ticket)
            Me.List.Item(index) = value
        End Set
    End Property

End Class

' new line character 