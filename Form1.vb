Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            Exit Sub
        End If
        If Candidatos.FindStringExact(TextBox1.Text) <> -1 Then
            MsgBox(TextBox1.Text & " ya existe en la colección.")
            TextBox1.Focus()
            TextBox1.Text = ""
            Exit Sub
        End If
        Candidatos.Items.Add(TextBox1.Text)
        TextBox1.Focus()
        TextBox1.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Candidatos.SelectedItem = Nothing Then
            MsgBox("Selecciona un candidato")
            Exit Sub
        End If
        If Votados.FindStringExact(Candidatos.SelectedItem) <> -1 Then
            Votos.Items(Votados.FindStringExact(Candidatos.SelectedItem)) += 1
            Exit Sub
        End If
        Votados.Items.Add(Candidatos.SelectedItem)
        Votos.Items.Add(1)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Candidatos.SelectedItem = Nothing Then
            MsgBox("Selecciona un candidato")
            Exit Sub
        End If
        If Votados.FindStringExact(Candidatos.SelectedItem) <> -1 Then
            Votos.Items(Votados.FindStringExact(Candidatos.SelectedItem)) -= 1
            If Votos.Items(Votados.FindStringExact(Candidatos.SelectedItem)) = 0 Then
                Dim posBorrar As Integer = Votados.FindStringExact(Candidatos.SelectedItem)
                Votos.Items.RemoveAt(posBorrar)
                Votados.Items.RemoveAt(posBorrar)
                Exit Sub
            End If
            Exit Sub
        End If
    End Sub
    Private Sub Form1_MouseClick(sender As Object, e As MouseEventArgs) Handles Me.MouseClick
        Votos.SelectedIndex = -1
        Votados.SelectedIndex = -1
        Candidatos.SelectedIndex = -1
    End Sub
    Private Sub Votados_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Votados.SelectedIndexChanged
        Votos.SelectedIndex = Votados.SelectedIndex
        Votos.TopIndex = Votados.TopIndex
    End Sub
    Private Sub Votos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Votos.SelectedIndexChanged
        Votados.SelectedIndex = Votos.SelectedIndex
        Votados.TopIndex = Votos.TopIndex
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Votos.SelectedIndex = Votados.SelectedIndex
        Votados.TopIndex = Votos.TopIndex
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Votados.Items.Count > 0 Then
            Dim tmp As Integer
            Dim tmps As String
            Dim i, j As Integer
            Dim n As Integer = Votos.Items.Count - 1
            For i = 0 To n
                For j = i + 1 To n
                    If Votos.Items.Item(i) < Votos.Items.Item(j) Then
                        tmp = Votos.Items.Item(i)
                        tmps = Votados.Items.Item(i)
                        Votos.Items.Item(i) = Votos.Items.Item(j)
                        Votados.Items.Item(i) = Votados.Items.Item(j)
                        Votos.Items.Item(j) = tmp
                        Votados.Items.Item(j) = tmps
                    End If
                Next j
            Next i
            Label5.Text = Votados.Items.Item(Votados.TopIndex) & ": " & Votos.Items.Item(Votos.TopIndex) & " votos"
            Label6.Text = Votados.Items.Item(Votados.TopIndex + 1) & ": " & Votos.Items.Item(Votos.TopIndex + 1) & " votos"
        End If
    End Sub
End Class
