Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class BCV777
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.NewForm()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.Save

            '    save_mmv100_2(chg_yn)

            '    If Me.Save() Then
            '        Dim saveID As String = g_list.Text("itm_id")

            '        Me.Open()

            '        g_list.Find("itm_id=" + saveID)
            '    End If

            Case MenuType.New
                Me.NewForm()
            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    'Public Overrides Sub NewForm()
    '    f_cust_no.Text = ""
    '    itm_id.Text = ""

    '    Me.OpenTrigger("dma100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

    '    cust_nm.Focus()
    'End Sub

    'Public Overrides Function Save() As Boolean
    '    If MyBase.Save() Then
    '        Me.OpenTrigger("dma100_g10")
    '    End If

    '    cust_nm.Focus()
    'End Function

    'Private Function Delete_Form() As Boolean

    '    If Me.Delete("dma100_f10") = ExcuteResult.Succeeded Then
    '        Me.Open()
    '    End If

    '    cust_nm.Focus()

    'End Function



End Class
