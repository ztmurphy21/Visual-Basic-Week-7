<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPay = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lstRates = New System.Windows.Forms.ListBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(128, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "&Principal:"
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(132, 78)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(100, 37)
        Me.txtPrincipal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(262, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "&Rate (%):"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Payment_Project.My.Resources.Resources.Mortgage
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 95)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(200, 31)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Monthly payment:"
        '
        'lblPay
        '
        Me.lblPay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPay.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblPay.Location = New System.Drawing.Point(16, 162)
        Me.lblPay.Name = "lblPay"
        Me.lblPay.Size = New System.Drawing.Size(157, 95)
        Me.lblPay.TabIndex = 7
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(179, 222)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(86, 35)
        Me.btnCalc.TabIndex = 4
        Me.btnCalc.Text = "&Calculate"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 222)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(78, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lstRates
        '
        Me.lstRates.FormattingEnabled = True
        Me.lstRates.ItemHeight = 31
        Me.lstRates.Location = New System.Drawing.Point(271, 88)
        Me.lstRates.Name = "lstRates"
        Me.lstRates.Size = New System.Drawing.Size(95, 97)
        Me.lstRates.TabIndex = 3
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(13.0!, 31.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 277)
        Me.Controls.Add(Me.lstRates)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblPay)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Monthly Payment"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPay As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lstRates As ListBox
End Class
