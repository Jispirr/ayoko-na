<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choices
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Choices))
        ButtonCalculator = New Button()
        ButtonJanken = New Button()
        ButtonGlassgame = New Button()
        ButtonClose = New Button()
        SuspendLayout()
        ' 
        ' ButtonCalculator
        ' 
        ButtonCalculator.Anchor = AnchorStyles.None
        ButtonCalculator.BackColor = SystemColors.HighlightText
        ButtonCalculator.FlatStyle = FlatStyle.Popup
        ButtonCalculator.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCalculator.ForeColor = SystemColors.ControlText
        ButtonCalculator.Location = New Point(231, 69)
        ButtonCalculator.Name = "ButtonCalculator"
        ButtonCalculator.Size = New Size(337, 56)
        ButtonCalculator.TabIndex = 0
        ButtonCalculator.Text = "CALCULATOR"
        ButtonCalculator.UseVisualStyleBackColor = False
        ' 
        ' ButtonJanken
        ' 
        ButtonJanken.Anchor = AnchorStyles.None
        ButtonJanken.BackColor = SystemColors.HighlightText
        ButtonJanken.FlatStyle = FlatStyle.Popup
        ButtonJanken.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonJanken.ForeColor = SystemColors.ControlText
        ButtonJanken.Location = New Point(231, 131)
        ButtonJanken.Name = "ButtonJanken"
        ButtonJanken.Size = New Size(337, 56)
        ButtonJanken.TabIndex = 1
        ButtonJanken.Text = "JANKEN"
        ButtonJanken.UseVisualStyleBackColor = False
        ' 
        ' ButtonGlassgame
        ' 
        ButtonGlassgame.Anchor = AnchorStyles.None
        ButtonGlassgame.BackColor = SystemColors.HighlightText
        ButtonGlassgame.FlatStyle = FlatStyle.Popup
        ButtonGlassgame.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonGlassgame.ForeColor = SystemColors.ControlText
        ButtonGlassgame.Location = New Point(231, 193)
        ButtonGlassgame.Name = "ButtonGlassgame"
        ButtonGlassgame.Size = New Size(337, 56)
        ButtonGlassgame.TabIndex = 2
        ButtonGlassgame.Text = "GLASS GAME"
        ButtonGlassgame.UseVisualStyleBackColor = False
        ' 
        ' ButtonClose
        ' 
        ButtonClose.Anchor = AnchorStyles.None
        ButtonClose.BackColor = SystemColors.HighlightText
        ButtonClose.FlatStyle = FlatStyle.Popup
        ButtonClose.Font = New Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonClose.ForeColor = SystemColors.ControlText
        ButtonClose.Location = New Point(231, 255)
        ButtonClose.Name = "ButtonClose"
        ButtonClose.Size = New Size(337, 56)
        ButtonClose.TabIndex = 3
        ButtonClose.Text = "CLOSE "
        ButtonClose.UseVisualStyleBackColor = False
        ' 
        ' Choices
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(ButtonClose)
        Controls.Add(ButtonGlassgame)
        Controls.Add(ButtonJanken)
        Controls.Add(ButtonCalculator)
        DoubleBuffered = True
        Name = "Choices"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Choices"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ButtonCalculator As Button
    Friend WithEvents ButtonJanken As Button
    Friend WithEvents ButtonGlassgame As Button
    Friend WithEvents ButtonClose As Button
End Class
