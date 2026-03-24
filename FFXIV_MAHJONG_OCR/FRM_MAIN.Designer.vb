<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_MAIN
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        GRP_OCR_IMAGE = New GroupBox()
        PNL_OCR_IMAGE_RESULT = New Panel()
        LST_OCR_IMAGE_RESULT = New ListBox()
        PNL_OCR_IMAGE_VIEW = New Panel()
        BTN_OCR_IMAGE_DO = New Button()
        PCB_OCR_IMAGE_VIEW = New PictureBox()
        PNL_OCR_IMAGE_PATH = New Panel()
        BTN_OCR_IMAGE_LOAD_PATH = New Button()
        TXT_OCR_IMAGE_PATH = New TextBox()
        LBL_OCR_IMAGE__PATH_GUIDE = New Label()
        GRP_ADD_SPREADSHEET = New GroupBox()
        BTN_ADD_SPREADSHEET = New Button()
        PNL_ID_SPREADSHEET = New Panel()
        TXT_ID_SPREADSHEET = New TextBox()
        LBL_ID_SPREADSHEET_GUIDE = New Label()
        GRP_OCR_IMAGE.SuspendLayout()
        PNL_OCR_IMAGE_RESULT.SuspendLayout()
        PNL_OCR_IMAGE_VIEW.SuspendLayout()
        CType(PCB_OCR_IMAGE_VIEW, ComponentModel.ISupportInitialize).BeginInit()
        PNL_OCR_IMAGE_PATH.SuspendLayout()
        GRP_ADD_SPREADSHEET.SuspendLayout()
        PNL_ID_SPREADSHEET.SuspendLayout()
        SuspendLayout()
        ' 
        ' GRP_OCR_IMAGE
        ' 
        GRP_OCR_IMAGE.Controls.Add(PNL_OCR_IMAGE_RESULT)
        GRP_OCR_IMAGE.Controls.Add(PNL_OCR_IMAGE_VIEW)
        GRP_OCR_IMAGE.Controls.Add(PNL_OCR_IMAGE_PATH)
        GRP_OCR_IMAGE.Location = New Point(10, 10)
        GRP_OCR_IMAGE.Name = "GRP_OCR_IMAGE"
        GRP_OCR_IMAGE.Size = New Size(760, 430)
        GRP_OCR_IMAGE.TabIndex = 0
        GRP_OCR_IMAGE.TabStop = False
        GRP_OCR_IMAGE.Text = "OCR Image"
        ' 
        ' PNL_OCR_IMAGE_RESULT
        ' 
        PNL_OCR_IMAGE_RESULT.Controls.Add(LST_OCR_IMAGE_RESULT)
        PNL_OCR_IMAGE_RESULT.Location = New Point(10, 260)
        PNL_OCR_IMAGE_RESULT.Name = "PNL_OCR_IMAGE_RESULT"
        PNL_OCR_IMAGE_RESULT.Size = New Size(740, 160)
        PNL_OCR_IMAGE_RESULT.TabIndex = 3
        ' 
        ' LST_OCR_IMAGE_RESULT
        ' 
        LST_OCR_IMAGE_RESULT.FormattingEnabled = True
        LST_OCR_IMAGE_RESULT.Location = New Point(10, 10)
        LST_OCR_IMAGE_RESULT.Name = "LST_OCR_IMAGE_RESULT"
        LST_OCR_IMAGE_RESULT.Size = New Size(720, 132)
        LST_OCR_IMAGE_RESULT.TabIndex = 0
        ' 
        ' PNL_OCR_IMAGE_VIEW
        ' 
        PNL_OCR_IMAGE_VIEW.Controls.Add(BTN_OCR_IMAGE_DO)
        PNL_OCR_IMAGE_VIEW.Controls.Add(PCB_OCR_IMAGE_VIEW)
        PNL_OCR_IMAGE_VIEW.Location = New Point(10, 60)
        PNL_OCR_IMAGE_VIEW.Name = "PNL_OCR_IMAGE_VIEW"
        PNL_OCR_IMAGE_VIEW.Size = New Size(740, 200)
        PNL_OCR_IMAGE_VIEW.TabIndex = 2
        ' 
        ' BTN_OCR_IMAGE_DO
        ' 
        BTN_OCR_IMAGE_DO.Location = New Point(640, 160)
        BTN_OCR_IMAGE_DO.Name = "BTN_OCR_IMAGE_DO"
        BTN_OCR_IMAGE_DO.Size = New Size(100, 30)
        BTN_OCR_IMAGE_DO.TabIndex = 3
        BTN_OCR_IMAGE_DO.Text = "OCR"
        BTN_OCR_IMAGE_DO.UseVisualStyleBackColor = True
        ' 
        ' PCB_OCR_IMAGE_VIEW
        ' 
        PCB_OCR_IMAGE_VIEW.Location = New Point(10, 10)
        PCB_OCR_IMAGE_VIEW.Name = "PCB_OCR_IMAGE_VIEW"
        PCB_OCR_IMAGE_VIEW.Size = New Size(630, 180)
        PCB_OCR_IMAGE_VIEW.SizeMode = PictureBoxSizeMode.Zoom
        PCB_OCR_IMAGE_VIEW.TabIndex = 0
        PCB_OCR_IMAGE_VIEW.TabStop = False
        ' 
        ' PNL_OCR_IMAGE_PATH
        ' 
        PNL_OCR_IMAGE_PATH.Controls.Add(BTN_OCR_IMAGE_LOAD_PATH)
        PNL_OCR_IMAGE_PATH.Controls.Add(TXT_OCR_IMAGE_PATH)
        PNL_OCR_IMAGE_PATH.Controls.Add(LBL_OCR_IMAGE__PATH_GUIDE)
        PNL_OCR_IMAGE_PATH.Location = New Point(10, 20)
        PNL_OCR_IMAGE_PATH.Name = "PNL_OCR_IMAGE_PATH"
        PNL_OCR_IMAGE_PATH.Size = New Size(740, 40)
        PNL_OCR_IMAGE_PATH.TabIndex = 1
        ' 
        ' BTN_OCR_IMAGE_LOAD_PATH
        ' 
        BTN_OCR_IMAGE_LOAD_PATH.Location = New Point(640, 4)
        BTN_OCR_IMAGE_LOAD_PATH.Name = "BTN_OCR_IMAGE_LOAD_PATH"
        BTN_OCR_IMAGE_LOAD_PATH.Size = New Size(100, 30)
        BTN_OCR_IMAGE_LOAD_PATH.TabIndex = 2
        BTN_OCR_IMAGE_LOAD_PATH.Text = "Load"
        BTN_OCR_IMAGE_LOAD_PATH.UseVisualStyleBackColor = True
        ' 
        ' TXT_OCR_IMAGE_PATH
        ' 
        TXT_OCR_IMAGE_PATH.Location = New Point(60, 5)
        TXT_OCR_IMAGE_PATH.Name = "TXT_OCR_IMAGE_PATH"
        TXT_OCR_IMAGE_PATH.Size = New Size(580, 27)
        TXT_OCR_IMAGE_PATH.TabIndex = 1
        ' 
        ' LBL_OCR_IMAGE__PATH_GUIDE
        ' 
        LBL_OCR_IMAGE__PATH_GUIDE.AutoSize = True
        LBL_OCR_IMAGE__PATH_GUIDE.Location = New Point(10, 10)
        LBL_OCR_IMAGE__PATH_GUIDE.Name = "LBL_OCR_IMAGE__PATH_GUIDE"
        LBL_OCR_IMAGE__PATH_GUIDE.Size = New Size(27, 16)
        LBL_OCR_IMAGE__PATH_GUIDE.TabIndex = 0
        LBL_OCR_IMAGE__PATH_GUIDE.Text = "File"
        ' 
        ' GRP_ADD_SPREADSHEET
        ' 
        GRP_ADD_SPREADSHEET.Controls.Add(BTN_ADD_SPREADSHEET)
        GRP_ADD_SPREADSHEET.Controls.Add(PNL_ID_SPREADSHEET)
        GRP_ADD_SPREADSHEET.Location = New Point(10, 450)
        GRP_ADD_SPREADSHEET.Name = "GRP_ADD_SPREADSHEET"
        GRP_ADD_SPREADSHEET.Size = New Size(760, 100)
        GRP_ADD_SPREADSHEET.TabIndex = 1
        GRP_ADD_SPREADSHEET.TabStop = False
        GRP_ADD_SPREADSHEET.Text = "Add  Spreadsheet"
        ' 
        ' BTN_ADD_SPREADSHEET
        ' 
        BTN_ADD_SPREADSHEET.Location = New Point(10, 60)
        BTN_ADD_SPREADSHEET.Name = "BTN_ADD_SPREADSHEET"
        BTN_ADD_SPREADSHEET.Size = New Size(100, 30)
        BTN_ADD_SPREADSHEET.TabIndex = 1
        BTN_ADD_SPREADSHEET.Text = "Add"
        BTN_ADD_SPREADSHEET.UseVisualStyleBackColor = True
        ' 
        ' PNL_ID_SPREADSHEET
        ' 
        PNL_ID_SPREADSHEET.Controls.Add(TXT_ID_SPREADSHEET)
        PNL_ID_SPREADSHEET.Controls.Add(LBL_ID_SPREADSHEET_GUIDE)
        PNL_ID_SPREADSHEET.Location = New Point(10, 20)
        PNL_ID_SPREADSHEET.Name = "PNL_ID_SPREADSHEET"
        PNL_ID_SPREADSHEET.Size = New Size(740, 40)
        PNL_ID_SPREADSHEET.TabIndex = 0
        ' 
        ' TXT_ID_SPREADSHEET
        ' 
        TXT_ID_SPREADSHEET.Location = New Point(60, 5)
        TXT_ID_SPREADSHEET.Name = "TXT_ID_SPREADSHEET"
        TXT_ID_SPREADSHEET.Size = New Size(297, 27)
        TXT_ID_SPREADSHEET.TabIndex = 1
        ' 
        ' LBL_ID_SPREADSHEET_GUIDE
        ' 
        LBL_ID_SPREADSHEET_GUIDE.AutoSize = True
        LBL_ID_SPREADSHEET_GUIDE.Location = New Point(10, 10)
        LBL_ID_SPREADSHEET_GUIDE.Name = "LBL_ID_SPREADSHEET_GUIDE"
        LBL_ID_SPREADSHEET_GUIDE.Size = New Size(20, 16)
        LBL_ID_SPREADSHEET_GUIDE.TabIndex = 0
        LBL_ID_SPREADSHEET_GUIDE.Text = "ID"
        ' 
        ' FRM_MAIN
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 561)
        Controls.Add(GRP_ADD_SPREADSHEET)
        Controls.Add(GRP_OCR_IMAGE)
        Font = New Font("游ゴシック", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(128))
        FormBorderStyle = FormBorderStyle.FixedSingle
        KeyPreview = True
        Margin = New Padding(3, 4, 3, 4)
        MaximizeBox = False
        Name = "FRM_MAIN"
        StartPosition = FormStartPosition.CenterScreen
        Text = "***"
        GRP_OCR_IMAGE.ResumeLayout(False)
        PNL_OCR_IMAGE_RESULT.ResumeLayout(False)
        PNL_OCR_IMAGE_VIEW.ResumeLayout(False)
        CType(PCB_OCR_IMAGE_VIEW, ComponentModel.ISupportInitialize).EndInit()
        PNL_OCR_IMAGE_PATH.ResumeLayout(False)
        PNL_OCR_IMAGE_PATH.PerformLayout()
        GRP_ADD_SPREADSHEET.ResumeLayout(False)
        PNL_ID_SPREADSHEET.ResumeLayout(False)
        PNL_ID_SPREADSHEET.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents GRP_OCR_IMAGE As GroupBox
    Friend WithEvents GRP_ADD_SPREADSHEET As GroupBox
    Friend WithEvents PNL_ID_SPREADSHEET As Panel
    Friend WithEvents LBL_ID_SPREADSHEET_GUIDE As Label
    Friend WithEvents TXT_ID_SPREADSHEET As TextBox
    Friend WithEvents BTN_ADD_SPREADSHEET As Button
    Friend WithEvents PNL_OCR_IMAGE_PATH As Panel
    Friend WithEvents TXT_OCR_IMAGE_PATH As TextBox
    Friend WithEvents LBL_OCR_IMAGE__PATH_GUIDE As Label
    Friend WithEvents BTN_OCR_IMAGE_LOAD_PATH As Button
    Friend WithEvents PNL_OCR_IMAGE_VIEW As Panel
    Friend WithEvents PCB_OCR_IMAGE_VIEW As PictureBox
    Friend WithEvents PNL_OCR_IMAGE_RESULT As Panel
    Friend WithEvents LST_OCR_IMAGE_RESULT As ListBox
    Friend WithEvents BTN_OCR_IMAGE_DO As Button

End Class
