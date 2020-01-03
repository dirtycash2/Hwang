Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Net.Mail
Imports System.Data
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices
Imports System.Net


Public Class BCV771
    Dim p As New OpenParameters

    Private Sub WI_BI_DUTY100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
                'SetColumnColor("CRI_CD")

                'Case MenuType.Cancel
                '    New_Form()
                'Case MenuType.New
                '    New_Form()
                'Case MenuType.Save
                '    If Not Saves() Then Else Me.Open() Exit Sub

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select
    End Sub

    'Private Sub SetColumnColor(columnName)
    '    For i = 0 To g10.RowCount - 1
    '        If g10.FieldName(i) = columnName Then
    '            If g10.Text("CRI_CD", i) = "" Then
    '                g10.
    '            End If
    '            Exit Sub
    '        End If

    '    Next
    'End Sub


End Class

