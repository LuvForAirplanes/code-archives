Public Class Form1
    Public Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        TextBox2.Clear()
        If TextBox1.Text = "the" Then
            MessageBox.Show("Invalid search term", "Invalid")
        ElseIf TextBox1.Text = "Christian" Then
            MessageBox.Show("Invalid search term", "Invalid")
        ElseIf TextBox1.Text = "Hymnal" Then
            MessageBox.Show("Invalid search term", "Invalid")
        ElseIf TextBox1.Text = "" Then
            MessageBox.Show("Invalid search term", "Invalid")

        Else


            If My.Resources.comethou.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.comethou

            End If
            If My.Resources.blessedjeh.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.blessedjeh

            End If
            If My.Resources.blessbe.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.blessbe

            End If
            If My.Resources.singabout.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.singabout

            End If
            If My.Resources.worthyart.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.worthyart

            End If
            If My.Resources.glorytohis.ToString.ToLower().IndexOf(TextBox1.Text.ToLower) <> -1 Then
                TextBox2.Text = TextBox2.Text & ControlChars.NewLine & ControlChars.NewLine & My.Resources.glorytohis

            End If
            End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.KeyDown
        
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        MessageBox.Show("Searches must follow these rules:" & ControlChars.NewLine & ControlChars.NewLine & "Do not splice verses" & ControlChars.NewLine & "Must be 3 or more words" & ControlChars.NewLine & "Cannot be numbers" & ControlChars.NewLine & "Cannot be blank" & ControlChars.NewLine & ControlChars.NewLine & "To search for titles, simply type the title", "Search Rules")

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Due to copyright laws; only the first" & ControlChars.NewLine & "verse and chorus on copyrighted songs" & ControlChars.NewLine & "will be searchable", "Copyright")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
