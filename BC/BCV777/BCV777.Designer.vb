<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BCV777
    Inherits Base7.Form

    'UserControl1은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.g_list = New Frame7.eGrid()
        Me.EPanel1 = New Frame7.ePanel()
        Me.f_cust_cd = New Frame7.eText()
        Me.f_cust_no = New Frame7.eText()
        Me.f_cust_nm = New Frame7.eText()
        Me.SplitContainer5 = New System.Windows.Forms.SplitContainer()
        Me.EPanel2 = New Frame7.ePanel()
        Me.indu_nm = New Frame7.eText()
        Me.list_dt = New Frame7.eText()
        Me.inco_dt = New Frame7.eText()
        Me.fax_no = New Frame7.eText()
        Me.biz_cond = New Frame7.eText()
        Me.corp_no = New Frame7.eText()
        Me.cust_no = New Frame7.eText()
        Me.indu_cd = New Frame7.eText()
        Me.cls_mo = New Frame7.eText()
        Me.empl_cnt = New Frame7.eText()
        Me.tel = New Frame7.eText()
        Me.biz_type = New Frame7.eText()
        Me.addr_n = New Frame7.eText()
        Me.own_nm = New Frame7.eText()
        Me.cust_nm = New Frame7.eText()
        Me.XtraTabControl1 = New DevExpress.XtraTab.XtraTabControl()
        Me.XtraTabPage1 = New DevExpress.XtraTab.XtraTabPage()
        Me.SplitContainer4 = New System.Windows.Forms.SplitContainer()
        Me.g10 = New Frame7.eGrid()
        Me.g20 = New Frame7.eGrid()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel1.SuspendLayout()
        Me.SplitContainer5.Panel1.SuspendLayout()
        Me.SplitContainer5.Panel2.SuspendLayout()
        Me.SplitContainer5.SuspendLayout()
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EPanel2.SuspendLayout()
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.XtraTabControl1.SuspendLayout()
        Me.XtraTabPage1.SuspendLayout()
        Me.SplitContainer4.Panel1.SuspendLayout()
        Me.SplitContainer4.Panel2.SuspendLayout()
        Me.SplitContainer4.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.g_list)
        Me.SplitContainer1.Panel1.Controls.Add(Me.EPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer5)
        Me.SplitContainer1.Size = New System.Drawing.Size(1175, 568)
        Me.SplitContainer1.SplitterDistance = 333
        Me.SplitContainer1.TabIndex = 0
        '
        'g_list
        '
        Me.g_list.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g_list.Location = New System.Drawing.Point(0, 121)
        Me.g_list.Name = "g_list"
        Me.g_list.ReadOnly = False
        Me.g_list.RowHeight = -1
        Me.g_list.Size = New System.Drawing.Size(333, 447)
        Me.g_list.TabIndex = 3
        '
        'EPanel1
        '
        Me.EPanel1.Controls.Add(Me.f_cust_cd)
        Me.EPanel1.Controls.Add(Me.f_cust_no)
        Me.EPanel1.Controls.Add(Me.f_cust_nm)
        Me.EPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.EPanel1.Location = New System.Drawing.Point(0, 0)
        Me.EPanel1.Name = "EPanel1"
        Me.EPanel1.Size = New System.Drawing.Size(333, 121)
        Me.EPanel1.TabIndex = 0
        Me.EPanel1.Text = "     검색조건"
        '
        'f_cust_cd
        '
        Me.f_cust_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_cd.Location = New System.Drawing.Point(18, 81)
        Me.f_cust_cd.Name = "f_cust_cd"
        Me.f_cust_cd.Size = New System.Drawing.Size(240, 20)
        Me.f_cust_cd.TabIndex = 5
        Me.f_cust_cd.Title = "거래처코드(%)"
        '
        'f_cust_no
        '
        Me.f_cust_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_no.Location = New System.Drawing.Point(18, 29)
        Me.f_cust_no.Name = "f_cust_no"
        Me.f_cust_no.Size = New System.Drawing.Size(240, 20)
        Me.f_cust_no.TabIndex = 3
        Me.f_cust_no.Title = "사업자번호(%)"
        '
        'f_cust_nm
        '
        Me.f_cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.f_cust_nm.Location = New System.Drawing.Point(18, 55)
        Me.f_cust_nm.Name = "f_cust_nm"
        Me.f_cust_nm.Size = New System.Drawing.Size(240, 20)
        Me.f_cust_nm.TabIndex = 4
        Me.f_cust_nm.Title = "거래처명(%)"
        '
        'SplitContainer5
        '
        Me.SplitContainer5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer5.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer5.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer5.Name = "SplitContainer5"
        Me.SplitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer5.Panel1
        '
        Me.SplitContainer5.Panel1.Controls.Add(Me.EPanel2)
        '
        'SplitContainer5.Panel2
        '
        Me.SplitContainer5.Panel2.Controls.Add(Me.XtraTabControl1)
        Me.SplitContainer5.Size = New System.Drawing.Size(838, 568)
        Me.SplitContainer5.SplitterDistance = 263
        Me.SplitContainer5.TabIndex = 1
        '
        'EPanel2
        '
        Me.EPanel2.Controls.Add(Me.indu_nm)
        Me.EPanel2.Controls.Add(Me.list_dt)
        Me.EPanel2.Controls.Add(Me.inco_dt)
        Me.EPanel2.Controls.Add(Me.fax_no)
        Me.EPanel2.Controls.Add(Me.biz_cond)
        Me.EPanel2.Controls.Add(Me.corp_no)
        Me.EPanel2.Controls.Add(Me.cust_no)
        Me.EPanel2.Controls.Add(Me.indu_cd)
        Me.EPanel2.Controls.Add(Me.cls_mo)
        Me.EPanel2.Controls.Add(Me.empl_cnt)
        Me.EPanel2.Controls.Add(Me.tel)
        Me.EPanel2.Controls.Add(Me.biz_type)
        Me.EPanel2.Controls.Add(Me.addr_n)
        Me.EPanel2.Controls.Add(Me.own_nm)
        Me.EPanel2.Controls.Add(Me.cust_nm)
        Me.EPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.EPanel2.Location = New System.Drawing.Point(0, 0)
        Me.EPanel2.Name = "EPanel2"
        Me.EPanel2.Size = New System.Drawing.Size(838, 263)
        Me.EPanel2.TabIndex = 64
        Me.EPanel2.Text = "     휴폐업서비스 거래처정보"
        '
        'indu_nm
        '
        Me.indu_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.indu_nm.Location = New System.Drawing.Point(396, 215)
        Me.indu_nm.Name = "indu_nm"
        Me.indu_nm.Size = New System.Drawing.Size(290, 20)
        Me.indu_nm.TabIndex = 92
        Me.indu_nm.Title = "산업코드명"
        Me.indu_nm.TitleWidth = 98
        '
        'list_dt
        '
        Me.list_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.list_dt.Location = New System.Drawing.Point(396, 190)
        Me.list_dt.Name = "list_dt"
        Me.list_dt.Size = New System.Drawing.Size(218, 20)
        Me.list_dt.TabIndex = 91
        Me.list_dt.Title = "상장일"
        Me.list_dt.TitleWidth = 98
        '
        'inco_dt
        '
        Me.inco_dt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.inco_dt.Location = New System.Drawing.Point(396, 164)
        Me.inco_dt.Name = "inco_dt"
        Me.inco_dt.Size = New System.Drawing.Size(218, 20)
        Me.inco_dt.TabIndex = 90
        Me.inco_dt.Title = "설립일자"
        Me.inco_dt.TitleWidth = 98
        '
        'fax_no
        '
        Me.fax_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.fax_no.Location = New System.Drawing.Point(396, 138)
        Me.fax_no.Name = "fax_no"
        Me.fax_no.Size = New System.Drawing.Size(218, 20)
        Me.fax_no.TabIndex = 89
        Me.fax_no.Title = "팩스"
        Me.fax_no.TitleWidth = 98
        '
        'biz_cond
        '
        Me.biz_cond.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.biz_cond.Location = New System.Drawing.Point(396, 112)
        Me.biz_cond.Name = "biz_cond"
        Me.biz_cond.Size = New System.Drawing.Size(290, 20)
        Me.biz_cond.TabIndex = 88
        Me.biz_cond.Title = "업태"
        Me.biz_cond.TitleWidth = 98
        '
        'corp_no
        '
        Me.corp_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.corp_no.Location = New System.Drawing.Point(396, 59)
        Me.corp_no.Name = "corp_no"
        Me.corp_no.Size = New System.Drawing.Size(218, 20)
        Me.corp_no.TabIndex = 87
        Me.corp_no.Title = "법인등록번호"
        Me.corp_no.TitleWidth = 98
        '
        'cust_no
        '
        Me.cust_no.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_no.Location = New System.Drawing.Point(396, 33)
        Me.cust_no.Name = "cust_no"
        Me.cust_no.Size = New System.Drawing.Size(218, 20)
        Me.cust_no.TabIndex = 86
        Me.cust_no.Title = "사업자번호"
        Me.cust_no.TitleWidth = 98
        '
        'indu_cd
        '
        Me.indu_cd.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.indu_cd.Location = New System.Drawing.Point(59, 215)
        Me.indu_cd.Name = "indu_cd"
        Me.indu_cd.Size = New System.Drawing.Size(204, 20)
        Me.indu_cd.TabIndex = 85
        Me.indu_cd.Title = "산업코드"
        Me.indu_cd.TitleWidth = 98
        '
        'cls_mo
        '
        Me.cls_mo.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cls_mo.Location = New System.Drawing.Point(59, 189)
        Me.cls_mo.Name = "cls_mo"
        Me.cls_mo.Size = New System.Drawing.Size(204, 20)
        Me.cls_mo.TabIndex = 84
        Me.cls_mo.Title = "결산월"
        Me.cls_mo.TitleWidth = 98
        '
        'empl_cnt
        '
        Me.empl_cnt.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.empl_cnt.Location = New System.Drawing.Point(59, 164)
        Me.empl_cnt.Name = "empl_cnt"
        Me.empl_cnt.Size = New System.Drawing.Size(204, 20)
        Me.empl_cnt.TabIndex = 83
        Me.empl_cnt.Title = "종업원수"
        Me.empl_cnt.TitleWidth = 98
        '
        'tel
        '
        Me.tel.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.tel.Location = New System.Drawing.Point(59, 138)
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(204, 20)
        Me.tel.TabIndex = 82
        Me.tel.Title = "전화"
        Me.tel.TitleWidth = 98
        '
        'biz_type
        '
        Me.biz_type.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.biz_type.Location = New System.Drawing.Point(59, 112)
        Me.biz_type.Name = "biz_type"
        Me.biz_type.Size = New System.Drawing.Size(204, 20)
        Me.biz_type.TabIndex = 81
        Me.biz_type.Title = "업종"
        Me.biz_type.TitleWidth = 98
        '
        'addr_n
        '
        Me.addr_n.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.addr_n.Location = New System.Drawing.Point(59, 86)
        Me.addr_n.Name = "addr_n"
        Me.addr_n.Size = New System.Drawing.Size(627, 20)
        Me.addr_n.TabIndex = 80
        Me.addr_n.Title = "주소"
        Me.addr_n.TitleWidth = 98
        '
        'own_nm
        '
        Me.own_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.own_nm.Location = New System.Drawing.Point(59, 60)
        Me.own_nm.Name = "own_nm"
        Me.own_nm.Size = New System.Drawing.Size(204, 20)
        Me.own_nm.TabIndex = 79
        Me.own_nm.Title = "대표자"
        Me.own_nm.TitleWidth = 98
        '
        'cust_nm
        '
        Me.cust_nm.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.cust_nm.Location = New System.Drawing.Point(59, 34)
        Me.cust_nm.Name = "cust_nm"
        Me.cust_nm.Size = New System.Drawing.Size(257, 20)
        Me.cust_nm.TabIndex = 77
        Me.cust_nm.Title = "거래처명"
        Me.cust_nm.TitleWidth = 98
        '
        'XtraTabControl1
        '
        Me.XtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.XtraTabControl1.Location = New System.Drawing.Point(0, 0)
        Me.XtraTabControl1.Name = "XtraTabControl1"
        Me.XtraTabControl1.SelectedTabPage = Me.XtraTabPage1
        Me.XtraTabControl1.Size = New System.Drawing.Size(838, 301)
        Me.XtraTabControl1.TabIndex = 3
        Me.XtraTabControl1.TabPages.AddRange(New DevExpress.XtraTab.XtraTabPage() {Me.XtraTabPage1})
        '
        'XtraTabPage1
        '
        Me.XtraTabPage1.AlwaysScrollActiveControlIntoView = False
        Me.XtraTabPage1.AutoScroll = True
        Me.XtraTabPage1.Controls.Add(Me.SplitContainer4)
        Me.XtraTabPage1.Name = "XtraTabPage1"
        Me.XtraTabPage1.Size = New System.Drawing.Size(831, 272)
        Me.XtraTabPage1.Text = "휴폐업정보"
        '
        'SplitContainer4
        '
        Me.SplitContainer4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer4.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer4.Name = "SplitContainer4"
        Me.SplitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer4.Panel1
        '
        Me.SplitContainer4.Panel1.Controls.Add(Me.g10)
        '
        'SplitContainer4.Panel2
        '
        Me.SplitContainer4.Panel2.Controls.Add(Me.g20)
        Me.SplitContainer4.Size = New System.Drawing.Size(831, 272)
        Me.SplitContainer4.SplitterDistance = 146
        Me.SplitContainer4.TabIndex = 2
        '
        'g10
        '
        Me.g10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g10.Location = New System.Drawing.Point(0, 0)
        Me.g10.Name = "g10"
        Me.g10.ReadOnly = False
        Me.g10.RowHeight = -1
        Me.g10.Size = New System.Drawing.Size(831, 146)
        Me.g10.TabIndex = 0
        '
        'g20
        '
        Me.g20.Dock = System.Windows.Forms.DockStyle.Fill
        Me.g20.Location = New System.Drawing.Point(0, 0)
        Me.g20.Name = "g20"
        Me.g20.ReadOnly = False
        Me.g20.RecordNavigator = False
        Me.g20.RowHeight = -1
        Me.g20.Size = New System.Drawing.Size(831, 122)
        Me.g20.TabIndex = 1
        '
        'BCV777
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "BCV777"
        Me.Size = New System.Drawing.Size(1182, 611)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.EPanel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel1.ResumeLayout(False)
        Me.SplitContainer5.Panel1.ResumeLayout(False)
        Me.SplitContainer5.Panel2.ResumeLayout(False)
        Me.SplitContainer5.ResumeLayout(False)
        CType(Me.EPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EPanel2.ResumeLayout(False)
        CType(Me.XtraTabControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.XtraTabControl1.ResumeLayout(False)
        Me.XtraTabPage1.ResumeLayout(False)
        Me.SplitContainer4.Panel1.ResumeLayout(False)
        Me.SplitContainer4.Panel2.ResumeLayout(False)
        Me.SplitContainer4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel1 As Frame7.ePanel
    Friend WithEvents f_cust_no As Frame7.eText
    Friend WithEvents f_cust_nm As Frame7.eText
    Friend WithEvents g_list As Frame7.eGrid
    Friend WithEvents SplitContainer5 As System.Windows.Forms.SplitContainer
    Friend WithEvents EPanel2 As Frame7.ePanel
    Friend WithEvents XtraTabControl1 As DevExpress.XtraTab.XtraTabControl
    Friend WithEvents XtraTabPage1 As DevExpress.XtraTab.XtraTabPage
    Friend WithEvents cust_nm As Frame7.eText
    Friend WithEvents indu_nm As Frame7.eText
    Friend WithEvents list_dt As Frame7.eText
    Friend WithEvents inco_dt As Frame7.eText
    Friend WithEvents fax_no As Frame7.eText
    Friend WithEvents biz_cond As Frame7.eText
    Friend WithEvents corp_no As Frame7.eText
    Friend WithEvents cust_no As Frame7.eText
    Friend WithEvents indu_cd As Frame7.eText
    Friend WithEvents cls_mo As Frame7.eText
    Friend WithEvents empl_cnt As Frame7.eText
    Friend WithEvents tel As Frame7.eText
    Friend WithEvents biz_type As Frame7.eText
    Friend WithEvents addr_n As Frame7.eText
    Friend WithEvents own_nm As Frame7.eText
    Friend WithEvents f_cust_cd As Frame7.eText
    Friend WithEvents SplitContainer4 As SplitContainer
    Friend WithEvents g10 As Frame7.eGrid
    Friend WithEvents g20 As Frame7.eGrid
End Class
