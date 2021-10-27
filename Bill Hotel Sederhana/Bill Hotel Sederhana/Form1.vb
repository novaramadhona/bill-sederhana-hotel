Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "Ya" Then
            txtdiskon.Text = 20
        Else ComboBox1.Text = "Tidak"
            txtdiskon.Text = 0
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.Text = "VIP" Then
            txtharga.Text = 1000000
        ElseIf ComboBox2.Text = "Deluxe" Then
            txtharga.Text = 750000
        Else
            txtharga.Text = 500000
        End If
    End Sub

    Private Sub btnproses_Click(sender As Object, e As EventArgs) Handles btnproses.Click
        If ComboBox1.Text = "Ya" Then
            txtttl.Text = Str(Val(txtharga.Text * txtjml.Text) - txtharga.Text * txtjml.Text * 0.2)
        Else
            txtttl.Text = Str(Val(txtharga.Text * txtjml.Text))
        End If
    End Sub

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        txtnama.Text = ""
        ComboBox1.Text = "Status"
        ComboBox2.Text = "Pilih Item"
        txtharga.Text = ""
        txtjml.Text = ""
        txtdiskon.Text = ""
        txtttl.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
