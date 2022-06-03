﻿Public Class Form1
    Dim Operacion As String
    Dim ValorResultado As Nullable(Of Double) = Nothing
    Dim Valor2 As Nullable(Of Double) = Nothing
    Dim SePresionaOperador As Boolean
    Private Sub ButtonUno_Click(sender As Object, e As EventArgs) Handles ButtonUno.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "1"
    End Sub

    Private Sub ButtonDos_Click(sender As Object, e As EventArgs) Handles ButtonDos.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "2"
    End Sub

    Private Sub ButtonTres_Click(sender As Object, e As EventArgs) Handles ButtonTres.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "3"
    End Sub

    Private Sub ButtonCuatro_Click(sender As Object, e As EventArgs) Handles ButtonCuatro.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "4"
    End Sub

    Private Sub ButtonCinco_Click(sender As Object, e As EventArgs) Handles ButtonCinco.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "5"
    End Sub

    Private Sub ButtonSeis_Click(sender As Object, e As EventArgs) Handles ButtonSeis.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "6"
    End Sub

    Private Sub ButtonSiete_Click(sender As Object, e As EventArgs) Handles ButtonSiete.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "7"
    End Sub

    Private Sub ButtonOcho_Click(sender As Object, e As EventArgs) Handles ButtonOcho.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "8"
    End Sub

    Private Sub ButtonNueve_Click(sender As Object, e As EventArgs) Handles ButtonNueve.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "9"
    End Sub

    Private Sub ButtonCero_Click(sender As Object, e As EventArgs) Handles ButtonCero.Click
        EvaluaRestriccionesParaConcatenar()
        TextBox1.Text &= "0"
    End Sub

    Private Sub ButtonPunto_Click(sender As Object, e As EventArgs) Handles ButtonPunto.Click
        EvaluaRestriccionesParaConcatenar()
        If InStr(TextBox1.Text, ".", CompareMethod.Text) = 0 Then
            TextBox1.Text &= "."
        End If
    End Sub

    Private Sub ButtonSuma_Click(sender As Object, e As EventArgs) Handles ButtonSuma.Click
        EvaluayHazOperacion()
        Operacion = "+"
    End Sub

    Private Sub ButtonSumar_Click(sender As Object, e As EventArgs) Handles ButtonSumar.Click
        EvaluayHazOperacion()
        Operacion = "-"
    End Sub

    Private Sub ButtonMultiplicar_Click(sender As Object, e As EventArgs) Handles ButtonMultiplicar.Click
        EvaluayHazOperacion()
        Operacion = "*"
    End Sub

    Private Sub ButtonDivision_Click(sender As Object, e As EventArgs) Handles ButtonDivision.Click
        EvaluayHazOperacion()
        Operacion = "/"
    End Sub

    Private Sub ButtonBorrar_Click(sender As Object, e As EventArgs) Handles ButtonBorrar.Click
        TextBox1.Text = "0"
        Valor2 = Nothing
        ValorResultado = Nothing
    End Sub

    Private Sub ButtonIgual_Click(sender As Object, e As EventArgs) Handles ButtonIgual.Click
        EvaluayHazOperacion()
        Operacion = ""
    End Sub
    Public Sub EvaluayHazOperacion()
        Valor2 = Val(TextBox1.Text)
        If ValorResultado IsNot Nothing Then
            Select Case Operacion
                Case "+"
                    ValorResultado = ValorResultado + Valor2
                Case "-"
                    ValorResultado -= Valor2
                Case "*"
                    ValorResultado *= Valor2
                Case "/"
                    ValorResultado /= Valor2
            End Select
            TextBox1.Text = ValorResultado
        Else
            ValorResultado = Valor2
        End If
    End Sub
    Public Sub EvaluaRestriccionesParaConcatenar()
        If SePresionaOperador = True Then
            TextBox1.Text = ""
            SePresionaOperador = False
        ElseIf TextBox1.Text = "0" Then
            TextBox1.Text = ""
        End If
    End Sub
End Class

