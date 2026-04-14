Module MOD_MAIN

#Region "プロジェクト用・構造体"
    Private Structure SRT_NDLOCR
        Public SOURCE_IMG As String
        Public OUTPUT As String
    End Structure
#End Region

#Region "プロジェクト用・変数"
    Private STR_PATH_NDL_OCR As String = "C:\Users\d.user\source\repos\ndlocr-lite\src"
    Friend STR_PATH_NDL_OCR_OUTPUT As String = "C:\Users\d.user\Desktop\TEMP"

#End Region

    Friend Function FUNC_DO_NDLOCR(ByVal STR_IMAGE As String) As Boolean

        Dim STR_COMMAND_LINE As String
        STR_COMMAND_LINE = ""
        STR_COMMAND_LINE &= "" & STR_PATH_NDL_OCR & "\" & "ocr.py"
        STR_COMMAND_LINE &= " " & "--sourceimg"
        STR_COMMAND_LINE &= " " & STR_IMAGE
        STR_COMMAND_LINE &= " " & "--output"
        STR_COMMAND_LINE &= " " & STR_PATH_NDL_OCR_OUTPUT

        If Not FUNC_DO_PROCESS("python", STR_COMMAND_LINE) Then
            Return False
        End If

        Return True
    End Function

    Private Function FUNC_DO_PROCESS(ByVal STR_PROCESS As String, ByVal STR_COMMAND_LINE As String) As Boolean
        Dim PSI_INFO As System.Diagnostics.ProcessStartInfo
        PSI_INFO = New System.Diagnostics.ProcessStartInfo
        With PSI_INFO
            .FileName = STR_PROCESS
            .Arguments = STR_COMMAND_LINE
        End With

        Dim P_DO As System.Diagnostics.Process
        P_DO = New System.Diagnostics.Process
        P_DO.StartInfo = PSI_INFO
        Dim BLN_RESULT As Boolean
        Try
            BLN_RESULT = P_DO.Start()
        Catch ex As Exception
            Return False
        End Try
        If Not BLN_RESULT Then
            Return False
        End If

        Call P_DO.WaitForExit()
        Return True
    End Function

    Public Function FUNC_PATH_TO_FILENAME(
    ByVal strHFilePath As String
    ) As String
        Dim intWLoopIndex As Integer
        Dim strWRetFileName As String

        strWRetFileName = ""
        intWLoopIndex = Len(strHFilePath)

        Do Until intWLoopIndex = 0
            If Mid(strHFilePath, intWLoopIndex, 1) = "\" Then
                strWRetFileName = Mid(strHFilePath, intWLoopIndex + 1, Len(strHFilePath) - intWLoopIndex)
                Exit Do
            End If
            intWLoopIndex = intWLoopIndex - 1
        Loop

        Return strWRetFileName
    End Function

    Public Function FUNC_GET_FILENAME_REMOVE_EXCTENT(
    ByVal strHFileStr As String
    ) As String
        Dim intWPoint As Integer
        Dim strWTemp As String
        Dim intWLen As Integer
        Dim intWIdx As Integer
        Dim strRET As String

        intWLen = Len(strHFileStr)
        intWPoint = 0

        For intWIdx = 1 To intWLen - 1
            strWTemp = Mid(strHFileStr, intWLen - (intWIdx - 1), 1)
            If strWTemp = "." Then
                intWPoint = intWIdx
                Exit For
            End If
        Next intWIdx

        strRET = Mid(strHFileStr, 1, intWLen - intWPoint)

        Return strRET
    End Function

    Public Function FUNC_GET_FILE_DETAIL(ByVal STR_PATH As String, ByRef STR_DETAIL() As String) As Boolean

        Dim ENC_FILE As System.Text.Encoding
        ENC_FILE = System.Text.Encoding.UTF8

        Dim STR_FILE() As String
        Try
            STR_FILE = System.IO.File.ReadAllLines(STR_PATH, ENC_FILE)
        Catch ex As Exception
            Return False
        End Try

        ReDim STR_DETAIL(0)
        For i = 0 To (STR_FILE.Length - 1)
            Call SUB_ADD_ROW_STRING(STR_DETAIL, STR_FILE(i))
        Next
        Return True
    End Function

    Public Function FUNC_CHECK_STR_ROW(ByRef STR_ROW() As String, ByVal STR_CHECK_STR As String) As Boolean

        For i = 1 To (STR_ROW.Length - 1)
            Dim STR_TEMP As String
            STR_TEMP = STR_ROW(i)

            If STR_TEMP.Contains(STR_CHECK_STR) Then
                Return True
            End If
        Next

        Return False
    End Function

    Public Sub SUB_ADD_ROW_STRING(ByRef STR_ROW() As String, ByVal STR_ADD As String)
        Dim INT_INDEX As Integer
        INT_INDEX = STR_ROW.Length
        ReDim Preserve STR_ROW(INT_INDEX)
        STR_ROW(INT_INDEX) = STR_ADD
    End Sub

    Public Sub SUB_ADD_ROW_INTEGER(ByRef INT_ROW() As Integer, ByVal INT_ADD As Integer)
        Dim INT_INDEX As Integer
        INT_INDEX = INT_ROW.Length
        ReDim Preserve INT_ROW(INT_INDEX)
        INT_ROW(INT_INDEX) = INT_ADD
    End Sub

    Public Function FUNC_GET_WHERE_ROW_STRING(ByRef STR_ROW() As String, ByRef STR_CHECK() As String) As String()
        Dim STR_RET() As String
        ReDim STR_RET(0)
        For i = 1 To (STR_ROW.Length - 1)
            For j = 1 To (STR_CHECK.Length - 1)
                If STR_ROW(i) = STR_CHECK(j) Then
                    Call SUB_ADD_ROW_STRING(STR_RET, STR_ROW(i))
                End If
            Next
        Next

        Return STR_RET
    End Function

    Public Function FUNC_GET_INTEGER_ROW_STRING(ByRef STR_ROW() As String) As Integer()
        Dim INT_RET() As Integer
        ReDim INT_RET(0)
        For i = 1 To (STR_ROW.Length - 1)
            If IsNumeric(STR_ROW(i)) Then
                Dim INT_TEMP As Integer
                INT_TEMP = CInt(STR_ROW(i))
                Call SUB_ADD_ROW_INTEGER(INT_RET, INT_TEMP)
            End If
        Next

        Return INT_RET
    End Function

End Module
