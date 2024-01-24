<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Calculator
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculator))
        TextBox1 = New TextBox()
        ButtonSeven = New Button()
        ButtonEight = New Button()
        ButtonNine = New Button()
        ButtonClear = New Button()
        ButtonFour = New Button()
        ButtonFive = New Button()
        ButtonSix = New Button()
        ButtonMultiply = New Button()
        ButtonOne = New Button()
        ButtonTwo = New Button()
        ButtonThree = New Button()
        ButtonDivision = New Button()
        ButtonEquals = New Button()
        ButtonAddition = New Button()
        ButtonSubtraction = New Button()
        ButtonBack = New Button()
        ButtonZero = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(12, 48)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(290, 54)
        TextBox1.TabIndex = 0
        ' 
        ' ButtonSeven
        ' 
        ButtonSeven.BackColor = SystemColors.HighlightText
        ButtonSeven.FlatStyle = FlatStyle.Popup
        ButtonSeven.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonSeven.ForeColor = SystemColors.ControlText
        ButtonSeven.Location = New Point(12, 122)
        ButtonSeven.Name = "ButtonSeven"
        ButtonSeven.Size = New Size(68, 66)
        ButtonSeven.TabIndex = 1
        ButtonSeven.Text = "7"
        ButtonSeven.UseVisualStyleBackColor = False
        ' 
        ' ButtonEight
        ' 
        ButtonEight.BackColor = SystemColors.HighlightText
        ButtonEight.FlatStyle = FlatStyle.Popup
        ButtonEight.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonEight.ForeColor = SystemColors.ControlText
        ButtonEight.Location = New Point(86, 122)
        ButtonEight.Name = "ButtonEight"
        ButtonEight.Size = New Size(68, 66)
        ButtonEight.TabIndex = 2
        ButtonEight.Text = "8"
        ButtonEight.UseVisualStyleBackColor = False
        ' 
        ' ButtonNine
        ' 
        ButtonNine.BackColor = SystemColors.HighlightText
        ButtonNine.FlatStyle = FlatStyle.Popup
        ButtonNine.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonNine.ForeColor = SystemColors.ControlText
        ButtonNine.Location = New Point(160, 122)
        ButtonNine.Name = "ButtonNine"
        ButtonNine.Size = New Size(68, 66)
        ButtonNine.TabIndex = 3
        ButtonNine.Text = "9"
        ButtonNine.UseVisualStyleBackColor = False
        ' 
        ' ButtonClear
        ' 
        ButtonClear.BackColor = SystemColors.ButtonShadow
        ButtonClear.FlatStyle = FlatStyle.Popup
        ButtonClear.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClear.ForeColor = SystemColors.ControlText
        ButtonClear.Location = New Point(234, 122)
        ButtonClear.Name = "ButtonClear"
        ButtonClear.Size = New Size(68, 66)
        ButtonClear.TabIndex = 4
        ButtonClear.Text = "C"
        ButtonClear.UseVisualStyleBackColor = False
        ' 
        ' ButtonFour
        ' 
        ButtonFour.BackColor = SystemColors.HighlightText
        ButtonFour.FlatStyle = FlatStyle.Popup
        ButtonFour.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonFour.ForeColor = SystemColors.ControlText
        ButtonFour.Location = New Point(12, 194)
        ButtonFour.Name = "ButtonFour"
        ButtonFour.Size = New Size(68, 66)
        ButtonFour.TabIndex = 5
        ButtonFour.Text = "4"
        ButtonFour.UseVisualStyleBackColor = False
        ' 
        ' ButtonFive
        ' 
        ButtonFive.BackColor = SystemColors.HighlightText
        ButtonFive.FlatStyle = FlatStyle.Popup
        ButtonFive.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonFive.ForeColor = SystemColors.ControlText
        ButtonFive.Location = New Point(86, 194)
        ButtonFive.Name = "ButtonFive"
        ButtonFive.Size = New Size(68, 66)
        ButtonFive.TabIndex = 6
        ButtonFive.Text = "5"
        ButtonFive.UseVisualStyleBackColor = False
        ' 
        ' ButtonSix
        ' 
        ButtonSix.BackColor = SystemColors.HighlightText
        ButtonSix.FlatStyle = FlatStyle.Popup
        ButtonSix.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonSix.ForeColor = SystemColors.ControlText
        ButtonSix.Location = New Point(160, 194)
        ButtonSix.Name = "ButtonSix"
        ButtonSix.Size = New Size(68, 66)
        ButtonSix.TabIndex = 7
        ButtonSix.Text = "6"
        ButtonSix.UseVisualStyleBackColor = False
        ' 
        ' ButtonMultiply
        ' 
        ButtonMultiply.BackColor = SystemColors.ButtonShadow
        ButtonMultiply.FlatStyle = FlatStyle.Popup
        ButtonMultiply.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonMultiply.ForeColor = SystemColors.ControlText
        ButtonMultiply.Location = New Point(234, 194)
        ButtonMultiply.Name = "ButtonMultiply"
        ButtonMultiply.Size = New Size(68, 66)
        ButtonMultiply.TabIndex = 8
        ButtonMultiply.Text = "X"
        ButtonMultiply.UseVisualStyleBackColor = False
        ' 
        ' ButtonOne
        ' 
        ButtonOne.BackColor = SystemColors.HighlightText
        ButtonOne.FlatStyle = FlatStyle.Popup
        ButtonOne.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonOne.ForeColor = SystemColors.ControlText
        ButtonOne.Location = New Point(12, 266)
        ButtonOne.Name = "ButtonOne"
        ButtonOne.Size = New Size(68, 66)
        ButtonOne.TabIndex = 9
        ButtonOne.Text = "1"
        ButtonOne.UseVisualStyleBackColor = False
        ' 
        ' ButtonTwo
        ' 
        ButtonTwo.BackColor = SystemColors.HighlightText
        ButtonTwo.FlatStyle = FlatStyle.Popup
        ButtonTwo.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonTwo.ForeColor = SystemColors.ControlText
        ButtonTwo.Location = New Point(86, 266)
        ButtonTwo.Name = "ButtonTwo"
        ButtonTwo.Size = New Size(68, 66)
        ButtonTwo.TabIndex = 10
        ButtonTwo.Text = "2"
        ButtonTwo.UseVisualStyleBackColor = False
        ' 
        ' ButtonThree
        ' 
        ButtonThree.BackColor = SystemColors.HighlightText
        ButtonThree.FlatStyle = FlatStyle.Popup
        ButtonThree.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonThree.ForeColor = SystemColors.ControlText
        ButtonThree.Location = New Point(160, 266)
        ButtonThree.Name = "ButtonThree"
        ButtonThree.Size = New Size(68, 66)
        ButtonThree.TabIndex = 11
        ButtonThree.Text = "3"
        ButtonThree.UseVisualStyleBackColor = False
        ' 
        ' ButtonDivision
        ' 
        ButtonDivision.BackColor = SystemColors.ButtonShadow
        ButtonDivision.FlatStyle = FlatStyle.Popup
        ButtonDivision.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonDivision.ForeColor = SystemColors.ControlText
        ButtonDivision.Location = New Point(234, 266)
        ButtonDivision.Name = "ButtonDivision"
        ButtonDivision.Size = New Size(68, 66)
        ButtonDivision.TabIndex = 12
        ButtonDivision.Text = "/"
        ButtonDivision.UseVisualStyleBackColor = False
        ' 
        ' ButtonEquals
        ' 
        ButtonEquals.BackColor = SystemColors.ButtonShadow
        ButtonEquals.FlatStyle = FlatStyle.Popup
        ButtonEquals.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonEquals.ForeColor = SystemColors.ControlText
        ButtonEquals.Location = New Point(234, 338)
        ButtonEquals.Name = "ButtonEquals"
        ButtonEquals.Size = New Size(68, 66)
        ButtonEquals.TabIndex = 13
        ButtonEquals.Text = "="
        ButtonEquals.UseVisualStyleBackColor = False
        ' 
        ' ButtonAddition
        ' 
        ButtonAddition.BackColor = SystemColors.ButtonShadow
        ButtonAddition.FlatStyle = FlatStyle.Popup
        ButtonAddition.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonAddition.ForeColor = SystemColors.ControlText
        ButtonAddition.Location = New Point(86, 338)
        ButtonAddition.Name = "ButtonAddition"
        ButtonAddition.Size = New Size(68, 66)
        ButtonAddition.TabIndex = 15
        ButtonAddition.Text = "+"
        ButtonAddition.UseVisualStyleBackColor = False
        ' 
        ' ButtonSubtraction
        ' 
        ButtonSubtraction.BackColor = SystemColors.ButtonShadow
        ButtonSubtraction.FlatStyle = FlatStyle.Popup
        ButtonSubtraction.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonSubtraction.ForeColor = SystemColors.ControlText
        ButtonSubtraction.Location = New Point(160, 338)
        ButtonSubtraction.Name = "ButtonSubtraction"
        ButtonSubtraction.Size = New Size(68, 66)
        ButtonSubtraction.TabIndex = 16
        ButtonSubtraction.Text = "-"
        ButtonSubtraction.UseVisualStyleBackColor = False
        ' 
        ' ButtonBack
        ' 
        ButtonBack.BackColor = SystemColors.ButtonShadow
        ButtonBack.FlatStyle = FlatStyle.Popup
        ButtonBack.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        ButtonBack.ForeColor = SystemColors.ControlText
        ButtonBack.Location = New Point(12, 15)
        ButtonBack.Name = "ButtonBack"
        ButtonBack.Size = New Size(75, 23)
        ButtonBack.TabIndex = 17
        ButtonBack.Text = "Back"
        ButtonBack.UseVisualStyleBackColor = False
        ' 
        ' ButtonZero
        ' 
        ButtonZero.BackColor = SystemColors.ButtonShadow
        ButtonZero.FlatStyle = FlatStyle.Popup
        ButtonZero.Font = New Font("Segoe UI Black", 27.75F, FontStyle.Bold)
        ButtonZero.ForeColor = SystemColors.ControlText
        ButtonZero.Location = New Point(12, 338)
        ButtonZero.Name = "ButtonZero"
        ButtonZero.Size = New Size(68, 66)
        ButtonZero.TabIndex = 18
        ButtonZero.Text = "0"
        ButtonZero.UseVisualStyleBackColor = False
        ' 
        ' Calculator
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(314, 421)
        Controls.Add(ButtonZero)
        Controls.Add(ButtonBack)
        Controls.Add(ButtonSubtraction)
        Controls.Add(ButtonAddition)
        Controls.Add(ButtonEquals)
        Controls.Add(ButtonDivision)
        Controls.Add(ButtonThree)
        Controls.Add(ButtonTwo)
        Controls.Add(ButtonOne)
        Controls.Add(ButtonMultiply)
        Controls.Add(ButtonSix)
        Controls.Add(ButtonFive)
        Controls.Add(ButtonFour)
        Controls.Add(ButtonClear)
        Controls.Add(ButtonNine)
        Controls.Add(ButtonEight)
        Controls.Add(ButtonSeven)
        Controls.Add(TextBox1)
        DoubleBuffered = True
        ForeColor = SystemColors.ControlText
        Name = "Calculator"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ButtonSeven As Button
    Friend WithEvents ButtonEight As Button
    Friend WithEvents ButtonNine As Button
    Friend WithEvents ButtonClear As Button
    Friend WithEvents ButtonFour As Button
    Friend WithEvents ButtonFive As Button
    Friend WithEvents ButtonSix As Button
    Friend WithEvents ButtonMultiply As Button
    Friend WithEvents ButtonOne As Button
    Friend WithEvents ButtonTwo As Button
    Friend WithEvents ButtonThree As Button
    Friend WithEvents ButtonDivision As Button
    Friend WithEvents ButtonEquals As Button
    Friend WithEvents ButtonAddition As Button
    Friend WithEvents ButtonSubtraction As Button
    Friend WithEvents ButtonBack As Button
    Friend WithEvents ButtonZero As Button
End Class
