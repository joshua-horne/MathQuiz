<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.plusLeftlabel = New System.Windows.Forms.Label()
        Me.plusRightlabel = New System.Windows.Forms.Label()
        Me.sum = New System.Windows.Forms.NumericUpDown()
        Me.plusSignLabel = New System.Windows.Forms.Label()
        Me.plusEqualsSignLabel = New System.Windows.Forms.Label()
        Me.minusEqualsSignLabel = New System.Windows.Forms.Label()
        Me.difference = New System.Windows.Forms.NumericUpDown()
        Me.minusRightLabel = New System.Windows.Forms.Label()
        Me.minusSignLabel = New System.Windows.Forms.Label()
        Me.minusLeftlabel = New System.Windows.Forms.Label()
        Me.timesEqualsSignLabel = New System.Windows.Forms.Label()
        Me.product = New System.Windows.Forms.NumericUpDown()
        Me.timesRightLabel = New System.Windows.Forms.Label()
        Me.timesSignLabel = New System.Windows.Forms.Label()
        Me.timesLeftLabel = New System.Windows.Forms.Label()
        Me.dividedEqualsSignLabel = New System.Windows.Forms.Label()
        Me.quotient = New System.Windows.Forms.NumericUpDown()
        Me.dividedRightLabel = New System.Windows.Forms.Label()
        Me.dividedSignLabel = New System.Windows.Forms.Label()
        Me.dividedLeftLabel = New System.Windows.Forms.Label()
        Me.startButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.sum, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timeLabel
        '
        Me.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.timeLabel.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timeLabel.Location = New System.Drawing.Point(272, 9)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(200, 30)
        Me.timeLabel.TabIndex = 0
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(167, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 30)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Time Left"
        '
        'plusLeftlabel
        '
        Me.plusLeftlabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusLeftlabel.Location = New System.Drawing.Point(50, 75)
        Me.plusLeftlabel.Name = "plusLeftlabel"
        Me.plusLeftlabel.Size = New System.Drawing.Size(60, 50)
        Me.plusLeftlabel.TabIndex = 2
        Me.plusLeftlabel.Text = "?"
        Me.plusLeftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusRightlabel
        '
        Me.plusRightlabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusRightlabel.Location = New System.Drawing.Point(182, 75)
        Me.plusRightlabel.Name = "plusRightlabel"
        Me.plusRightlabel.Size = New System.Drawing.Size(60, 50)
        Me.plusRightlabel.TabIndex = 4
        Me.plusRightlabel.Text = "?"
        Me.plusRightlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'sum
        '
        Me.sum.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sum.Location = New System.Drawing.Point(314, 82)
        Me.sum.Name = "sum"
        Me.sum.Size = New System.Drawing.Size(100, 39)
        Me.sum.TabIndex = 1
        '
        'plusSignLabel
        '
        Me.plusSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusSignLabel.Location = New System.Drawing.Point(116, 75)
        Me.plusSignLabel.Name = "plusSignLabel"
        Me.plusSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusSignLabel.TabIndex = 3
        Me.plusSignLabel.Text = "+"
        Me.plusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'plusEqualsSignLabel
        '
        Me.plusEqualsSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.plusEqualsSignLabel.Location = New System.Drawing.Point(248, 75)
        Me.plusEqualsSignLabel.Name = "plusEqualsSignLabel"
        Me.plusEqualsSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.plusEqualsSignLabel.TabIndex = 6
        Me.plusEqualsSignLabel.Text = "="
        Me.plusEqualsSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusEqualsSignLabel
        '
        Me.minusEqualsSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusEqualsSignLabel.Location = New System.Drawing.Point(248, 120)
        Me.minusEqualsSignLabel.Name = "minusEqualsSignLabel"
        Me.minusEqualsSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.minusEqualsSignLabel.TabIndex = 11
        Me.minusEqualsSignLabel.Text = "="
        Me.minusEqualsSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'difference
        '
        Me.difference.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.difference.Location = New System.Drawing.Point(314, 127)
        Me.difference.Name = "difference"
        Me.difference.Size = New System.Drawing.Size(100, 39)
        Me.difference.TabIndex = 2
        '
        'minusRightLabel
        '
        Me.minusRightLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusRightLabel.Location = New System.Drawing.Point(182, 120)
        Me.minusRightLabel.Name = "minusRightLabel"
        Me.minusRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.minusRightLabel.TabIndex = 9
        Me.minusRightLabel.Text = "?"
        Me.minusRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusSignLabel
        '
        Me.minusSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusSignLabel.Location = New System.Drawing.Point(116, 120)
        Me.minusSignLabel.Name = "minusSignLabel"
        Me.minusSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.minusSignLabel.TabIndex = 8
        Me.minusSignLabel.Text = "-"
        Me.minusSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minusLeftlabel
        '
        Me.minusLeftlabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.minusLeftlabel.Location = New System.Drawing.Point(50, 120)
        Me.minusLeftlabel.Name = "minusLeftlabel"
        Me.minusLeftlabel.Size = New System.Drawing.Size(60, 50)
        Me.minusLeftlabel.TabIndex = 7
        Me.minusLeftlabel.Text = "?"
        Me.minusLeftlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesEqualsSignLabel
        '
        Me.timesEqualsSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timesEqualsSignLabel.Location = New System.Drawing.Point(248, 165)
        Me.timesEqualsSignLabel.Name = "timesEqualsSignLabel"
        Me.timesEqualsSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesEqualsSignLabel.TabIndex = 16
        Me.timesEqualsSignLabel.Text = "="
        Me.timesEqualsSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'product
        '
        Me.product.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.product.Location = New System.Drawing.Point(314, 172)
        Me.product.Name = "product"
        Me.product.Size = New System.Drawing.Size(100, 39)
        Me.product.TabIndex = 3
        '
        'timesRightLabel
        '
        Me.timesRightLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timesRightLabel.Location = New System.Drawing.Point(182, 165)
        Me.timesRightLabel.Name = "timesRightLabel"
        Me.timesRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesRightLabel.TabIndex = 14
        Me.timesRightLabel.Text = "?"
        Me.timesRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesSignLabel
        '
        Me.timesSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timesSignLabel.Location = New System.Drawing.Point(116, 165)
        Me.timesSignLabel.Name = "timesSignLabel"
        Me.timesSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesSignLabel.TabIndex = 13
        Me.timesSignLabel.Text = "×"
        Me.timesSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timesLeftLabel
        '
        Me.timesLeftLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.timesLeftLabel.Location = New System.Drawing.Point(50, 165)
        Me.timesLeftLabel.Name = "timesLeftLabel"
        Me.timesLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.timesLeftLabel.TabIndex = 12
        Me.timesLeftLabel.Text = "?"
        Me.timesLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedEqualsSignLabel
        '
        Me.dividedEqualsSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dividedEqualsSignLabel.Location = New System.Drawing.Point(248, 210)
        Me.dividedEqualsSignLabel.Name = "dividedEqualsSignLabel"
        Me.dividedEqualsSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedEqualsSignLabel.TabIndex = 21
        Me.dividedEqualsSignLabel.Text = "="
        Me.dividedEqualsSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'quotient
        '
        Me.quotient.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.quotient.Location = New System.Drawing.Point(314, 217)
        Me.quotient.Name = "quotient"
        Me.quotient.Size = New System.Drawing.Size(100, 39)
        Me.quotient.TabIndex = 4
        '
        'dividedRightLabel
        '
        Me.dividedRightLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dividedRightLabel.Location = New System.Drawing.Point(182, 210)
        Me.dividedRightLabel.Name = "dividedRightLabel"
        Me.dividedRightLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedRightLabel.TabIndex = 19
        Me.dividedRightLabel.Text = "?"
        Me.dividedRightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedSignLabel
        '
        Me.dividedSignLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dividedSignLabel.Location = New System.Drawing.Point(116, 210)
        Me.dividedSignLabel.Name = "dividedSignLabel"
        Me.dividedSignLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedSignLabel.TabIndex = 18
        Me.dividedSignLabel.Text = "÷"
        Me.dividedSignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dividedLeftLabel
        '
        Me.dividedLeftLabel.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.dividedLeftLabel.Location = New System.Drawing.Point(50, 210)
        Me.dividedLeftLabel.Name = "dividedLeftLabel"
        Me.dividedLeftLabel.Size = New System.Drawing.Size(60, 50)
        Me.dividedLeftLabel.TabIndex = 17
        Me.dividedLeftLabel.Text = "?"
        Me.dividedLeftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startButton
        '
        Me.startButton.AutoSize = True
        Me.startButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.startButton.Location = New System.Drawing.Point(138, 307)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(170, 42)
        Me.startButton.TabIndex = 0
        Me.startButton.Text = "Start the Quiz"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 361)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.dividedEqualsSignLabel)
        Me.Controls.Add(Me.quotient)
        Me.Controls.Add(Me.dividedRightLabel)
        Me.Controls.Add(Me.dividedSignLabel)
        Me.Controls.Add(Me.dividedLeftLabel)
        Me.Controls.Add(Me.timesEqualsSignLabel)
        Me.Controls.Add(Me.product)
        Me.Controls.Add(Me.timesRightLabel)
        Me.Controls.Add(Me.timesSignLabel)
        Me.Controls.Add(Me.timesLeftLabel)
        Me.Controls.Add(Me.minusEqualsSignLabel)
        Me.Controls.Add(Me.difference)
        Me.Controls.Add(Me.minusRightLabel)
        Me.Controls.Add(Me.minusSignLabel)
        Me.Controls.Add(Me.minusLeftlabel)
        Me.Controls.Add(Me.plusEqualsSignLabel)
        Me.Controls.Add(Me.sum)
        Me.Controls.Add(Me.plusRightlabel)
        Me.Controls.Add(Me.plusSignLabel)
        Me.Controls.Add(Me.plusLeftlabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.timeLabel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Math Quiz"
        CType(Me.sum, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.difference, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.product, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.quotient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents plusLeftlabel As Label
    Friend WithEvents plusRightlabel As Label
    Friend WithEvents sum As NumericUpDown
    Friend WithEvents plusSignLabel As Label
    Friend WithEvents plusEqualsSignLabel As Label
    Friend WithEvents minusEqualsSignLabel As Label
    Friend WithEvents difference As NumericUpDown
    Friend WithEvents minusRightLabel As Label
    Friend WithEvents minusSignLabel As Label
    Friend WithEvents minusLeftlabel As Label
    Friend WithEvents timesEqualsSignLabel As Label
    Friend WithEvents product As NumericUpDown
    Friend WithEvents timesRightLabel As Label
    Friend WithEvents timesSignLabel As Label
    Friend WithEvents timesLeftLabel As Label
    Friend WithEvents dividedEqualsSignLabel As Label
    Friend WithEvents quotient As NumericUpDown
    Friend WithEvents dividedRightLabel As Label
    Friend WithEvents dividedSignLabel As Label
    Friend WithEvents dividedLeftLabel As Label
    Friend WithEvents startButton As Button
    Friend WithEvents Timer1 As Timer
End Class
