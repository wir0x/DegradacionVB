Public Class Form1
    Dim numero, res_div, count As Integer
    Dim acumulador As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        acumulador = ""

        If (Not (TextBox1.Text = "")) Then

            numero = TextBox1.Text

            For i_count = numero To 0 Step -1
                acumulador = acumulador & Chr(10) & Chr(13)

                For j_count = 1 To i_count Step +1
                    acumulador = acumulador & j_count

                Next

            Next

            Label2.Text = acumulador

        Else
            MessageBox.Show("ERROR!!!! Ingrese un numero en el espacio en blanco")
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        acumulador = ""

        If (Not (TextBox1.Text = "")) Then

            numero = TextBox1.Text

            For icount = 0 To numero Step +1
                acumulador = acumulador & Chr(10) & Chr(13)

                For jcount = 1 To icount Step +1
                    acumulador &= jcount

                Next
            Next

            Label2.Text = acumulador

        Else
            MessageBox.Show("ERROR !!!! Ingrese un numero en el espacio en blanco")
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            acumulador = ""
            numero = TextBox1.Text
            res_div = numero / 2

            For icount = 0 To res_div Step +1
                count = 1

                For jcount = 0 To numero - 1 Step +1

                    If (jcount >= res_div - icount And jcount <= res_div + icount) Then
                        acumulador = acumulador & count
                        count += 1

                    Else
                        acumulador = acumulador & 0
                    End If

                Next

                acumulador = acumulador & Chr(10) & Chr(13)

            Next

            Label2.Text = acumulador

        Catch ex As Exception

            MessageBox.Show("ERROR !!!! Ingrese un numero en el espacio en blanco" + ex.ToString)
        End Try

        
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        Label2.Text = ""
    End Sub
End Class
