<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.viewbox = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.submit = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jumlah = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.hybrid = New System.Windows.Forms.RadioButton()
        Me.ag = New System.Windows.Forms.RadioButton()
        Me.aa = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namajet = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.viewbox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.viewbox)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-3, -4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 459)
        Me.Panel1.TabIndex = 0
        '
        'viewbox
        '
        Me.viewbox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.viewbox.Location = New System.Drawing.Point(436, 78)
        Me.viewbox.Name = "viewbox"
        Me.viewbox.Size = New System.Drawing.Size(376, 342)
        Me.viewbox.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.submit)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.harga)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.jumlah)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.hybrid)
        Me.Panel2.Controls.Add(Me.ag)
        Me.Panel2.Controls.Add(Me.aa)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.namajet)
        Me.Panel2.Location = New System.Drawing.Point(42, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(376, 342)
        Me.Panel2.TabIndex = 1
        '
        'submit
        '
        Me.submit.Location = New System.Drawing.Point(41, 288)
        Me.submit.Name = "submit"
        Me.submit.Size = New System.Drawing.Size(75, 23)
        Me.submit.TabIndex = 10
        Me.submit.Text = "Submit"
        Me.submit.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(38, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Harga (Rp)"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(41, 224)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(229, 20)
        Me.harga.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(38, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 17)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Jumlah"
        '
        'jumlah
        '
        Me.jumlah.Location = New System.Drawing.Point(41, 158)
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Size = New System.Drawing.Size(229, 20)
        Me.jumlah.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(38, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tipe Jet"
        '
        'hybrid
        '
        Me.hybrid.AutoSize = True
        Me.hybrid.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hybrid.ForeColor = System.Drawing.Color.White
        Me.hybrid.Location = New System.Drawing.Point(230, 106)
        Me.hybrid.Name = "hybrid"
        Me.hybrid.Size = New System.Drawing.Size(61, 19)
        Me.hybrid.TabIndex = 4
        Me.hybrid.TabStop = True
        Me.hybrid.Text = "Hybrid"
        Me.hybrid.UseVisualStyleBackColor = True
        '
        'ag
        '
        Me.ag.AutoSize = True
        Me.ag.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ag.ForeColor = System.Drawing.Color.White
        Me.ag.Location = New System.Drawing.Point(123, 106)
        Me.ag.Name = "ag"
        Me.ag.Size = New System.Drawing.Size(101, 19)
        Me.ag.TabIndex = 3
        Me.ag.TabStop = True
        Me.ag.Text = "Air-to-Ground"
        Me.ag.UseVisualStyleBackColor = True
        '
        'aa
        '
        Me.aa.AutoSize = True
        Me.aa.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.aa.ForeColor = System.Drawing.Color.White
        Me.aa.Location = New System.Drawing.Point(41, 106)
        Me.aa.Name = "aa"
        Me.aa.Size = New System.Drawing.Size(76, 19)
        Me.aa.TabIndex = 2
        Me.aa.TabStop = True
        Me.aa.Text = "Air-to-Air"
        Me.aa.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(38, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama Jet"
        '
        'namajet
        '
        Me.namajet.Location = New System.Drawing.Point(41, 47)
        Me.namajet.Name = "namajet"
        Me.namajet.Size = New System.Drawing.Size(229, 20)
        Me.namajet.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(64, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(280, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Database Inventori Jet"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.viewbox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.jumlah, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents hybrid As RadioButton
    Friend WithEvents ag As RadioButton
    Friend WithEvents aa As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents namajet As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents jumlah As NumericUpDown
    Friend WithEvents viewbox As DataGridView
    Friend WithEvents submit As Button
End Class
