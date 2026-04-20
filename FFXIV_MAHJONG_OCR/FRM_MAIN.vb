Public Class FRM_MAIN

#Region "画面用・定数"

#End Region

#Region "画面用・列挙定数"
    Private Enum ENM_MY_TASK
        DO_LOAD_IMAGE
        DO_OCR_IMAGE
        DO_ADD_SPREADSHEET
    End Enum
#End Region

#Region "画面用・構造体"
    Private Structure SRT_RESULT_SCORE
        Public NAME_PLAYER As String
        Public POINT As Integer
    End Structure
#End Region

#Region "画面用・変数"
    Private BLN_APPL_DO_TASK As Boolean = False
    Private SRT_RESULT() As SRT_RESULT_SCORE
#End Region

#Region "実行処理呼出"

    Private Sub SUB_DO_TASK(ByVal ENM_TASK As ENM_MY_TASK)

        If BLN_APPL_DO_TASK Then
            Exit Sub
        End If
        BLN_APPL_DO_TASK = True
        Call Application.DoEvents()

        Select Case ENM_TASK
            Case ENM_MY_TASK.DO_LOAD_IMAGE
                Call SUB_LOAD_IMAGE()
            Case ENM_MY_TASK.DO_OCR_IMAGE
                Call SUB_OCR_IMAGE()
            Case Else

        End Select

        Call Application.DoEvents()
        BLN_APPL_DO_TASK = False
    End Sub
#End Region

#Region "実行処理群"
    Private Sub SUB_LOAD_IMAGE()
        Dim OFD_IMAGE As OpenFileDialog
        OFD_IMAGE = New OpenFileDialog
        With OFD_IMAGE
            .Title = "画像を開く"
            .Filter = "画像ファイル|*.bmp;*.png;*.tif;*.jpg"
            .Multiselect = False
            .InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
        End With

        Dim DR_RESULT As DialogResult
        DR_RESULT = OFD_IMAGE.ShowDialog()
        If Not (DR_RESULT = DialogResult.OK) Then
            Exit Sub
        End If

        Dim STR_PATH_IMAGE As String
        STR_PATH_IMAGE = OFD_IMAGE.FileName
        Call OFD_IMAGE.Dispose()
        OFD_IMAGE = Nothing
        TXT_OCR_IMAGE_PATH.Text = STR_PATH_IMAGE

        PCB_OCR_IMAGE_VIEW.ImageLocation = STR_PATH_IMAGE
        Call PCB_OCR_IMAGE_VIEW.Refresh()
    End Sub

    Private Sub SUB_OCR_IMAGE()
        Dim STR_PATH_IMAGE As String
        STR_PATH_IMAGE = TXT_OCR_IMAGE_PATH.Text
        If Not FUNC_DO_NDLOCR(STR_PATH_IMAGE) Then
            Call MessageBox.Show("Error OCR", Me.Text)
            Exit Sub
        End If

        Dim STR_FILE_NAME_IMAGE As String
        STR_FILE_NAME_IMAGE = FUNC_PATH_TO_FILENAME(STR_PATH_IMAGE)

        Dim STR_FILE_NAME_RESULT_OCR As String
        STR_FILE_NAME_RESULT_OCR = FUNC_GET_FILENAME_REMOVE_EXCTENT(STR_FILE_NAME_IMAGE) & "." & "txt"

        Dim STR_PATH_RESULT_OCR As String
        STR_PATH_RESULT_OCR = STR_PATH_NDL_OCR_OUTPUT & "\" & STR_FILE_NAME_RESULT_OCR

        Dim STR_FILE_DETAIL() As String
        STR_FILE_DETAIL = Nothing
        If Not FUNC_GET_FILE_DETAIL(STR_PATH_RESULT_OCR, STR_FILE_DETAIL) Then
            Call MessageBox.Show("Error Result", Me.Text)
            Exit Sub
        End If

        Dim STR_CHECK As String
        STR_CHECK = "対局結果"
        If Not FUNC_CHECK_STR_ROW(STR_FILE_DETAIL, STR_CHECK) Then
            Call MessageBox.Show("Error Result Value", Me.Text)
            Exit Sub
        End If

        Dim STR_NAME_CHECK() As String
        ReDim STR_NAME_CHECK(0)
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Jin Alex")
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Denpa Kousya")
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Denpa Sousya")
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Denpa Tousya")
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Crow Trismegists")
        Call SUB_ADD_ROW_STRING(STR_NAME_CHECK, "Gigi Bernstad")

        Dim STR_NAME() As String
        STR_NAME = FUNC_GET_WHERE_ROW_STRING(STR_FILE_DETAIL, STR_NAME_CHECK)
        If Not ((STR_NAME.Length - 1) = 4) Then
            Call MessageBox.Show("Member Check Error (4 people)", Me.Text)
            Exit Sub
        End If

        Dim INT_POINT() As Integer
        INT_POINT = FUNC_GET_INTEGER_ROW_STRING(STR_FILE_DETAIL)
        If Not ((INT_POINT.Length - 1) = 4) Then
            Call MessageBox.Show("Score Check Error (4 point)", Me.Text)
            Exit Sub
        End If

        ReDim SRT_RESULT(0)
        For i = 1 To (STR_NAME.Length - 1)
            Dim INT_INDEX As Integer
            INT_INDEX = SRT_RESULT.Length
            ReDim Preserve SRT_RESULT(INT_INDEX)
            With SRT_RESULT(INT_INDEX)
                .NAME_PLAYER = STR_NAME(i)
                .POINT = INT_POINT(i)
            End With
        Next

        For i = 1 To (SRT_RESULT.Length - 1)
            Dim STR_TEMP As String
            With SRT_RESULT(i)
                STR_TEMP = ""
                STR_TEMP &= .NAME_PLAYER
                STR_TEMP &= ":" & CStr(.POINT)

            End With
            Call SUB_ADD_OCR_IMAGE_RESULT(STR_TEMP)
        Next

    End Sub


#End Region

#Region "画面系"
    Private Sub SUB_ADD_OCR_IMAGE_RESULT(ByVal STR_ADD As String)

        Call LST_OCR_IMAGE_RESULT.Items.Add(STR_ADD)
        Call LST_OCR_IMAGE_RESULT.Refresh()
    End Sub
#End Region

#Region "初期化・終了処理"
    Private Sub SUB_CTRL_NEW_INIT()
        Me.Text = "FFXIV Mahjong OCR"
    End Sub

    Private Sub SUB_CTRL_VIEW_INIT()

    End Sub

    Private Sub SUB_CTRL_VALUE_INIT()

    End Sub
#End Region

#Region "New"
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Call SUB_CTRL_NEW_INIT()
    End Sub
#End Region

#Region "イベント-ボタンクリック"

    Private Sub BTN_OCR_IMAGE_LOAD_PATH_Click(sender As Object, e As EventArgs) Handles BTN_OCR_IMAGE_LOAD_PATH.Click
        Call SUB_DO_TASK(ENM_MY_TASK.DO_LOAD_IMAGE)
    End Sub

    Private Sub BTN_OCR_IMAGE_DO_Click(sender As Object, e As EventArgs) Handles BTN_OCR_IMAGE_DO.Click
        Call SUB_DO_TASK(ENM_MY_TASK.DO_OCR_IMAGE)
    End Sub
#End Region

    Private Sub FRM_MAIN_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call SUB_CTRL_VIEW_INIT()
        Call SUB_CTRL_VALUE_INIT()
        'aa
    End Sub


End Class
