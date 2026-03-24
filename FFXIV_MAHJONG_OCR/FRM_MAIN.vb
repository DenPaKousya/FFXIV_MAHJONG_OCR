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

#End Region

#Region "画面用・変数"
    Private BLN_APPL_DO_TASK As Boolean = False

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
        STR_CHECK = ""
        If Not FUNC_CHECK_STR_ROW(STR_FILE_DETAIL, STR_CHECK) Then
            Call MessageBox.Show("Error Result Value", Me.Text)
            Exit Sub
        End If


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
    End Sub


End Class
