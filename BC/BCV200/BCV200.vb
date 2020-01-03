Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCV200
    Dim p As New OpenParameters


    Private Sub BCV200_Load(sender As Object, e As EventArgs) Handles Me.Load
        p.Clear()
        p.Add("@cust_cd", "XXX")
        p.Add("@cust_nm", "XXX")
        p.Add("@grp3_cd", "XXX")

        Me.Open("bcv200_g10", p)
    End Sub

    'Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Init_Form()
    'End Sub

    'Public Sub Init_Form()
    '    Me.Open()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            'Case MenuType.Save

            Case MenuType.Cancel
                p.Clear()
                p.Add("@cust_cd", "XXX")
                p.Add("@cust_nm", "XXX")
                p.Add("@grp3_cd", "XXX")

                Me.Open("bcv200_g10", p)

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        Me.Open()

    End Sub

End Class
