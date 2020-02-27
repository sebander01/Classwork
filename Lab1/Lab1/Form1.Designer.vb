<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form
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
        Me.components = New System.ComponentModel.Container()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblday = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblCounter = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.txtOne = New System.Windows.Forms.TextBox()
        Me.ttEnter = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttReset = New System.Windows.Forms.ToolTip(Me.components)
        Me.ttExit = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblAverageTitle = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtInput
        '
        Me.txtInput.BackColor = System.Drawing.Color.White
        Me.txtInput.ForeColor = System.Drawing.SystemColors.ControlText
        Me.txtInput.Location = New System.Drawing.Point(118, 68)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(145, 20)
        Me.txtInput.TabIndex = 3
        '
        'lblday
        '
        Me.lblday.AutoSize = True
        Me.lblday.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblday.Location = New System.Drawing.Point(269, 71)
        Me.lblday.Name = "lblday"
        Me.lblday.Size = New System.Drawing.Size(29, 13)
        Me.lblday.TabIndex = 5
        Me.lblday.Text = "Day:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblUnits.Location = New System.Drawing.Point(73, 71)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 4
        Me.lblUnits.Text = "Units:"
        '
        'lblCounter
        '
        Me.lblCounter.AutoSize = True
        Me.lblCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCounter.Location = New System.Drawing.Point(295, 71)
        Me.lblCounter.Name = "lblCounter"
        Me.lblCounter.Size = New System.Drawing.Size(13, 13)
        Me.lblCounter.TabIndex = 6
        Me.lblCounter.Text = "1"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(252, 357)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.ttExit.SetToolTip(Me.btnExit, "This button exits the program completely.")
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnReset.Location = New System.Drawing.Point(151, 357)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.ttReset.SetToolTip(Me.btnReset, "This button resets the program clearing the list and allowing the useer to restar" &
        "t.")
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnEnter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnEnter.Location = New System.Drawing.Point(42, 357)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(75, 23)
        Me.btnEnter.TabIndex = 0
        Me.btnEnter.Text = "Enter"
        Me.ttEnter.SetToolTip(Me.btnEnter, "This button enters a number into the list up till the seventh day. On the seventh" &
        " day the numbers in the list will be calculated to give the average of all the n" &
        "umbers.")
        Me.btnEnter.UseVisualStyleBackColor = False
        '
        'txtOutput
        '
        Me.txtOutput.BackColor = System.Drawing.Color.Maroon
        Me.txtOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOutput.Location = New System.Drawing.Point(42, 331)
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.ReadOnly = True
        Me.txtOutput.Size = New System.Drawing.Size(285, 20)
        Me.txtOutput.TabIndex = 8
        '
        'txtOne
        '
        Me.txtOne.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.txtOne.Location = New System.Drawing.Point(42, 94)
        Me.txtOne.Multiline = True
        Me.txtOne.Name = "txtOne"
        Me.txtOne.ReadOnly = True
        Me.txtOne.Size = New System.Drawing.Size(285, 204)
        Me.txtOne.TabIndex = 7
        '
        'ttEnter
        '
        Me.ttEnter.ToolTipTitle = "Enter"
        '
        'ttReset
        '
        Me.ttReset.ToolTipTitle = "Reset"
        '
        'ttExit
        '
        Me.ttExit.ToolTipTitle = "Exit"
        '
        'lblAverageTitle
        '
        Me.lblAverageTitle.AutoSize = True
        Me.lblAverageTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTitle.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblAverageTitle.Location = New System.Drawing.Point(147, 301)
        Me.lblAverageTitle.Name = "lblAverageTitle"
        Me.lblAverageTitle.Size = New System.Drawing.Size(81, 24)
        Me.lblAverageTitle.TabIndex = 9
        Me.lblAverageTitle.Text = "Average"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(38, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 24)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Average Units Shipped Calculator"
        '
        'Form
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(367, 397)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAverageTitle)
        Me.Controls.Add(Me.txtOne)
        Me.Controls.Add(Me.txtOutput)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblCounter)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.lblday)
        Me.Controls.Add(Me.txtInput)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblday As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblCounter As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents txtOutput As TextBox
    Friend WithEvents txtOne As TextBox
    Friend WithEvents ttEnter As ToolTip
    Friend WithEvents ttReset As ToolTip
    Friend WithEvents ttExit As ToolTip
    Friend WithEvents lblAverageTitle As Label
    Friend WithEvents Label1 As Label
End Class
