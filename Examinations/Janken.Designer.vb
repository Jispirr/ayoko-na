<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Janken
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Janken))
        Label1 = New Label()
        ButtonRock = New Button()
        ButtonPaper = New Button()
        ButtonScissor = New Button()
        Result = New Label()
        ButtonTry = New Button()
        Results = New Label()
        LabelUser = New Label()
        LabelComputer = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.Anchor = AnchorStyles.None
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.HighlightText
        Label1.Font = New Font("Segoe UI Black", 40F, FontStyle.Bold)
        Label1.Location = New Point(202, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 72)
        Label1.TabIndex = 0
        Label1.Text = "JANKENPON"
        Label1.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' ButtonRock
        ' 
        ButtonRock.Anchor = AnchorStyles.None
        ButtonRock.BackColor = SystemColors.HighlightText
        ButtonRock.FlatStyle = FlatStyle.Popup
        ButtonRock.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold)
        ButtonRock.ForeColor = SystemColors.ControlText
        ButtonRock.Location = New Point(130, 233)
        ButtonRock.Name = "ButtonRock"
        ButtonRock.Size = New Size(131, 68)
        ButtonRock.TabIndex = 1
        ButtonRock.Text = "🏔️"
        ButtonRock.UseVisualStyleBackColor = False
        ' 
        ' ButtonPaper
        ' 
        ButtonPaper.Anchor = AnchorStyles.None
        ButtonPaper.BackColor = SystemColors.HighlightText
        ButtonPaper.FlatStyle = FlatStyle.Popup
        ButtonPaper.Font = New Font("Segoe UI Black", 24F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonPaper.ForeColor = SystemColors.ControlText
        ButtonPaper.Location = New Point(314, 233)
        ButtonPaper.Name = "ButtonPaper"
        ButtonPaper.Size = New Size(131, 68)
        ButtonPaper.TabIndex = 2
        ButtonPaper.Text = "📜"
        ButtonPaper.UseVisualStyleBackColor = False
        ' 
        ' ButtonScissor
        ' 
        ButtonScissor.Anchor = AnchorStyles.None
        ButtonScissor.BackColor = SystemColors.HighlightText
        ButtonScissor.FlatStyle = FlatStyle.Popup
        ButtonScissor.Font = New Font("Segoe UI Black", 24F)
        ButtonScissor.ForeColor = SystemColors.ControlText
        ButtonScissor.Location = New Point(501, 233)
        ButtonScissor.Name = "ButtonScissor"
        ButtonScissor.Size = New Size(131, 68)
        ButtonScissor.TabIndex = 3
        ButtonScissor.Text = "💇"
        ButtonScissor.UseVisualStyleBackColor = False
        ' 
        ' Result
        ' 
        Result.Anchor = AnchorStyles.None
        Result.AutoSize = True
        Result.BackColor = Color.Transparent
        Result.ForeColor = SystemColors.HighlightText
        Result.Location = New Point(323, 211)
        Result.Name = "Result"
        Result.Size = New Size(0, 15)
        Result.TabIndex = 6
        ' 
        ' ButtonTry
        ' 
        ButtonTry.Anchor = AnchorStyles.None
        ButtonTry.BackColor = SystemColors.HighlightText
        ButtonTry.FlatStyle = FlatStyle.Popup
        ButtonTry.Font = New Font("Segoe UI Black", 12F)
        ButtonTry.ForeColor = SystemColors.ControlText
        ButtonTry.Location = New Point(314, 337)
        ButtonTry.Name = "ButtonTry"
        ButtonTry.Size = New Size(131, 30)
        ButtonTry.TabIndex = 9
        ButtonTry.Text = "TRY IT AGAIN"
        ButtonTry.UseVisualStyleBackColor = False
        ' 
        ' Results
        ' 
        Results.AutoSize = True
        Results.BackColor = Color.Transparent
        Results.Font = New Font("Segoe UI Black", 16F, FontStyle.Bold)
        Results.ForeColor = SystemColors.HighlightText
        Results.Location = New Point(327, 201)
        Results.Name = "Results"
        Results.Size = New Size(0, 30)
        Results.TabIndex = 10
        ' 
        ' LabelUser
        ' 
        LabelUser.Anchor = AnchorStyles.None
        LabelUser.AutoSize = True
        LabelUser.BackColor = Color.Transparent
        LabelUser.Font = New Font("Segoe UI", 24F)
        LabelUser.ForeColor = SystemColors.ControlText
        LabelUser.Location = New Point(448, 159)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(0, 45)
        LabelUser.TabIndex = 11
        ' 
        ' LabelComputer
        ' 
        LabelComputer.Anchor = AnchorStyles.None
        LabelComputer.AutoSize = True
        LabelComputer.BackColor = Color.Transparent
        LabelComputer.Font = New Font("Segoe UI", 24F)
        LabelComputer.ForeColor = SystemColors.ControlText
        LabelComputer.Location = New Point(261, 159)
        LabelComputer.Name = "LabelComputer"
        LabelComputer.Size = New Size(0, 45)
        LabelComputer.TabIndex = 12
        ' 
        ' Button1
        ' 
        Button1.Anchor = AnchorStyles.None
        Button1.BackColor = SystemColors.HighlightText
        Button1.FlatStyle = FlatStyle.Popup
        Button1.Font = New Font("Segoe UI Black", 12F)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(12, 12)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 30)
        Button1.TabIndex = 13
        Button1.Text = "Back"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Janken
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(LabelComputer)
        Controls.Add(LabelUser)
        Controls.Add(Results)
        Controls.Add(ButtonTry)
        Controls.Add(Result)
        Controls.Add(ButtonScissor)
        Controls.Add(ButtonPaper)
        Controls.Add(ButtonRock)
        Controls.Add(Label1)
        DoubleBuffered = True
        Name = "Janken"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Janken"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents ButtonRock As Button
    Friend WithEvents ButtonPaper As Button
    Friend WithEvents ButtonScissor As Button
    Friend WithEvents ButtonUser As Button
    Friend WithEvents ButtonComputer As Button
    Friend WithEvents Result As Label
    Friend WithEvents Result2 As Label
    Friend WithEvents Result3 As Label
    Friend WithEvents ButtonTry As Button
    Friend WithEvents Results As Label
    Friend WithEvents ResultWin As Label
    Friend WithEvents ResultLose As Label
    Friend WithEvents LabelUser As Label
    Friend WithEvents LabelComputer As Label
    Friend WithEvents Button1 As Button
End Class
