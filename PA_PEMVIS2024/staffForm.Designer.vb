<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class staffForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.panelMenu = New System.Windows.Forms.FlowLayoutPanel()
        Me.panelKeranjang = New System.Windows.Forms.FlowLayoutPanel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1027, 96)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(213, 36)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NAMA KASIR"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Button3)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Location = New System.Drawing.Point(21, 115)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(286, 568)
        Me.Panel2.TabIndex = 1
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(30, 150)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(215, 80)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Keranjang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(30, 35)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(215, 80)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Tambah Pesanan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'panelMenu
        '
        Me.panelMenu.AutoScroll = True
        Me.panelMenu.Location = New System.Drawing.Point(330, 115)
        Me.panelMenu.Name = "panelMenu"
        Me.panelMenu.Size = New System.Drawing.Size(672, 568)
        Me.panelMenu.TabIndex = 2
        '
        'panelKeranjang
        '
        Me.panelKeranjang.AutoScroll = True
        Me.panelKeranjang.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.panelKeranjang.Location = New System.Drawing.Point(330, 115)
        Me.panelKeranjang.Name = "panelKeranjang"
        Me.panelKeranjang.Size = New System.Drawing.Size(672, 568)
        Me.panelKeranjang.TabIndex = 3
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(30, 449)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(215, 80)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Check Out"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'staffForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.PA_PEMVIS2024.My.Resources.Resources.White_Minimal_Furniture_Website_Desktop_Prototype
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1027, 713)
        Me.Controls.Add(Me.panelMenu)
        Me.Controls.Add(Me.panelKeranjang)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "staffForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "staff"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents panelMenu As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents panelKeranjang As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
