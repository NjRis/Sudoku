Module Responsive
    Public Sub CenterControls(form As Form)
        For Each ctrl As Control In form.Controls
            CenterControl(form, ctrl)
        Next
    End Sub

    Private Sub CenterControl(form As Form, ctrl As Control)
        Dim formWidth As Integer = form.ClientSize.Width
        Dim formHeight As Integer = form.ClientSize.Height
        ctrl.Left = (formWidth - ctrl.Width) \ 2
        ctrl.Top = (formHeight - ctrl.Height) \ 2
    End Sub
End Module
