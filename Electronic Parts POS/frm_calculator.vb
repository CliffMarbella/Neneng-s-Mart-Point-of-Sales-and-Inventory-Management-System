Public Class frm_calculator

    Dim ans As Double = 0
    Dim operand As Boolean = False
    Dim opUsed As String
    Dim modOp As String
#Region "Operation"

    Private Sub getEqual()
        Try
            Select Case opUsed
                Case "addition"
                    txt_calcInp.Text = getSum(CType(txt_calcInp.Text, Double))
                Case "subtraction"
                    txt_calcInp.Text = getDifference(CType(txt_calcInp.Text, Double))
                Case "multiplication"
                    txt_calcInp.Text = getProduct(CType(txt_calcInp.Text, Double))
                Case "division"
                    txt_calcInp.Text = getQuotient(CType(txt_calcInp.Text, Double))
                Case "mod"
                    txt_calcInp.Text = getMod(CType(txt_calcInp.Text, Double))
            End Select
        Catch ex As Exception
            txt_calcInp.Text = "Syntax Error"
            txt_calcOutp.Text = "Syntax Error"
            ans = 0
            operand = False
            opUsed = ""
            Exit Sub
        End Try
    End Sub

    Private Function getSum(inp As Double) As Double
        ans = ans + inp
        Return ans
    End Function

    Private Function getDifference(inp As Double) As Double
        ans = ans - inp
        Return ans
    End Function

    Private Function getProduct(inp As Double) As Double
        ans = ans * inp
        Return ans
    End Function

    Private Function getQuotient(inp As Double) As Double
        ans = ans / inp
        Return ans
    End Function

    Private Function getMod(inp As Double) As Double
        Dim md
        md = ans * (inp / 100)
        Return md
    End Function
#End Region

#Region "Input Button"
    Private Sub btn_1_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "1"
        operand = False
    End Sub

    Private Sub btn_2_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "2"
        operand = False
    End Sub

    Private Sub btn_3_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "3"
        operand = False
    End Sub

    Private Sub btn_4_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "4"
        operand = False
    End Sub

    Private Sub btn_5_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "5"
        operand = False
    End Sub

    Private Sub btn_6_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "6"
        operand = False
    End Sub

    Private Sub btn_7_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "7"
        operand = False
    End Sub

    Private Sub btn_8_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "8"
        operand = False
    End Sub

    Private Sub btn_9_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "9"
        operand = False
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        If operand Then
            txt_calcInp.Text = ""
        End If
        txt_calcInp.Text = txt_calcInp.Text & "0"
        operand = False
    End Sub

    Private Sub btn_decimal_Click(sender As Object, e As EventArgs) Handles btn_decimal.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If operand Then
                txt_calcInp.Text = ""
            End If
            txt_calcInp.Text = txt_calcInp.Text & "."
            operand = False
        End If
    End Sub

    Private Sub btn_sign_Click(sender As Object, e As EventArgs) Handles btn_sign.Click
        If String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            txt_calcInp.Text = "-"
            operand = False
        End If
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        txt_calcInp.Text = ""
        txt_calcOutp.Text = ""
        ans = 0
        operand = False
        opUsed = ""
    End Sub

    Private Sub btn_clearEntry_Click(sender As Object, e As EventArgs) Handles btn_clearEntry.Click
        txt_calcInp.Text = ""
    End Sub
#End Region

#Region "Operation Button"
    Private Sub btn_add_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                If txt_calcOutp.Text = "" Then
                    txt_calcOutp.Text = txt_calcInp.Text & " + "
                    Try
                        ans = CType(txt_calcInp.Text, Double)
                    Catch ex As Exception
                        txt_calcInp.Text = "Syntax Error"
                        txt_calcOutp.Text = "Syntax Error"
                        ans = 0
                        operand = False
                        opUsed = ""
                        Exit Sub
                    End Try
                Else
                    If opUsed = "mod" Then
                        Dim arr() = txt_calcOutp.Text.ToCharArray
                        Dim counter As Integer
                        Dim con = ""
                        For x = arr.Length - 1 To 0 Step -1
                            If arr(x) = " " Then
                                counter = (arr.Length - 1) - x
                                x = 0
                            End If
                        Next
                        For x = 0 To arr.Length - (1 + counter)
                            con = con & arr(x)
                        Next
                        txt_calcOutp.Text = con & txt_calcInp.Text & " + "
                        opUsed = modOp
                    Else
                        txt_calcOutp.Text = txt_calcOutp.Text & txt_calcInp.Text & " + "
                    End If
                    getEqual()
                    End If
                    opUsed = "addition"
                operand = True
            End If
            End If
    End Sub

    Private Sub btn_divide_Click(sender As Object, e As EventArgs) Handles btn_divide.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                If txt_calcOutp.Text = "" Then
                    txt_calcOutp.Text = txt_calcInp.Text & " ÷ "
                    Try
                        ans = CType(txt_calcInp.Text, Double)
                    Catch ex As Exception
                        txt_calcInp.Text = "Syntax Error"
                        txt_calcOutp.Text = "Syntax Error"
                        ans = 0
                        operand = False
                        opUsed = ""
                        Exit Sub
                    End Try
                Else
                    If opUsed = "mod" Then
                        Dim arr() = txt_calcOutp.Text.ToCharArray
                        Dim counter As Integer
                        Dim con = ""
                        For x = arr.Length - 1 To 0 Step -1
                            If arr(x) = " " Then
                                counter = (arr.Length - 1) - x
                                x = 0
                            End If
                        Next
                        For x = 0 To arr.Length - (1 + counter)
                            con = con & arr(x)
                        Next
                        txt_calcOutp.Text = con & txt_calcInp.Text & " ÷ "
                        opUsed = modOp
                    Else
                        txt_calcOutp.Text = txt_calcOutp.Text & txt_calcInp.Text & " ÷ "
                    End If
                    getEqual()
                End If
                opUsed = "division"
                operand = True
            End If
        End If
    End Sub

    Private Sub btn_multiply_Click(sender As Object, e As EventArgs) Handles btn_multiply.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                If txt_calcOutp.Text = "" Then
                    txt_calcOutp.Text = txt_calcInp.Text & " × "
                    Try
                        ans = CType(txt_calcInp.Text, Double)
                    Catch ex As Exception
                        txt_calcInp.Text = "Syntax Error"
                        txt_calcOutp.Text = "Syntax Error"
                        ans = 0
                        operand = False
                        opUsed = ""
                        Exit Sub
                    End Try
                Else
                    If opUsed = "mod" Then
                        Dim arr() = txt_calcOutp.Text.ToCharArray
                        Dim counter As Integer
                        Dim con = ""
                        For x = arr.Length - 1 To 0 Step -1
                            If arr(x) = " " Then
                                counter = (arr.Length - 1) - x
                                x = 0
                            End If
                        Next
                        For x = 0 To arr.Length - (1 + counter)
                            con = con & arr(x)
                        Next
                        txt_calcOutp.Text = con & txt_calcInp.Text & " × "
                        opUsed = modOp
                    Else
                        txt_calcOutp.Text = txt_calcOutp.Text & txt_calcInp.Text & " × "
                    End If
                    getEqual()
                End If
                opUsed = "multiplication"
                operand = True
            End If
        End If
    End Sub

    Private Sub btn_subtract_Click(sender As Object, e As EventArgs) Handles btn_subtract.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                If txt_calcOutp.Text = "" Then
                    txt_calcOutp.Text = txt_calcInp.Text & " - "
                    Try
                        ans = CType(txt_calcInp.Text, Double)
                    Catch ex As Exception
                        txt_calcInp.Text = "Syntax Error"
                        txt_calcOutp.Text = "Syntax Error"
                        ans = 0
                        operand = False
                        opUsed = ""
                        Exit Sub
                    End Try
                Else
                    If opUsed = "mod" Then
                        Dim arr() = txt_calcOutp.Text.ToCharArray
                        Dim counter As Integer
                        Dim con = ""
                        For x = arr.Length - 1 To 0 Step -1
                            If arr(x) = " " Then
                                counter = (arr.Length - 1) - x
                                x = 0
                            End If
                        Next
                        For x = 0 To arr.Length - (1 + counter)
                            con = con & arr(x)
                        Next
                        txt_calcOutp.Text = con & txt_calcInp.Text & " - "
                        opUsed = modOp
                    Else
                        txt_calcOutp.Text = txt_calcOutp.Text & txt_calcInp.Text & " - "
                    End If
                    getEqual()
                End If
                opUsed = "subtraction"
                operand = True
            End If
        End If
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            Dim arr() = txt_calcInp.Text.ToCharArray
            Dim temp As String = ""
            For x = 0 To arr.Length - 2
                temp = temp & arr(x)
            Next
            txt_calcInp.Text = temp
        End If
    End Sub

    Private Sub btn_equal_Click(sender As Object, e As EventArgs) Handles btn_equal.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                getEqual()
                txt_calcOutp.Text = ""
                ans = 0
                operand = True
            End If
        End If
    End Sub

    Private Sub btn_mod_Click(sender As Object, e As EventArgs) Handles btn_mod.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then
                txt_calcOutp.Text = txt_calcOutp.Text & getMod(CType(txt_calcInp.Text, Double))
                modOp = opUsed
                opUsed = "mod"
                getEqual()
            End If
        End If
    End Sub

    Private Sub btn_sqrt_Click(sender As Object, e As EventArgs) Handles btn_sqrt.Click
        If Not String.IsNullOrWhiteSpace(txt_calcInp.Text) Then
            If Not operand Then

            End If
        End If
    End Sub
#End Region
End Class