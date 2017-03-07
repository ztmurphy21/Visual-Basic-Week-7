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
        Me.txtCurrentSales = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblProjSales = New System.Windows.Forms.Label()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Location = New System.Drawing.Point(135, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current &sales:"
        '
        'txtCurrentSales
        '
        Me.txtCurrentSales.Location = New System.Drawing.Point(237, 27)
        Me.txtCurrentSales.Name = "txtCurrentSales"
        Me.txtCurrentSales.Size = New System.Drawing.Size(100, 27)
        Me.txtCurrentSales.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Sales_Project.My.Resources.Resources.Growth
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 99)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = false
        '
        'lblProjSales
        '
        Me.lblProjSales.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.lblProjSales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblProjSales.Location = New System.Drawing.Point(139, 67)
        Me.lblProjSales.Name = "lblProjSales"
        Me.lblProjSales.Size = New System.Drawing.Size(358, 60)
        Me.lblProjSales.TabIndex = 4
        Me.lblProjSales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(201, 155)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(204, 38)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "&Calculate Projected Sales"
        Me.btnCalc.UseVisualStyleBackColor = true
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(422, 155)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 38)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = true
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8!, 20!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(521, 216)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.lblProjSales)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtCurrentSales)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projected Sales"
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentSales As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblProjSales As Label
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnExit As Button
End Class
