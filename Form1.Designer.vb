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
        GroupBox1 = New GroupBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        NumericUpDown2 = New NumericUpDown()
        NumericUpDown1 = New NumericUpDown()
        Label2 = New Label()
        Label1 = New Label()
        GroupBox2 = New GroupBox()
        TextBox3 = New TextBox()
        Label6 = New Label()
        TextBox2 = New TextBox()
        Label5 = New Label()
        NumericUpDown3 = New NumericUpDown()
        Label4 = New Label()
        GroupBox3 = New GroupBox()
        TextBox4 = New TextBox()
        Label8 = New Label()
        TextBox5 = New TextBox()
        Label7 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox2.SuspendLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox3.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(NumericUpDown2)
        GroupBox1.Controls.Add(NumericUpDown1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Location = New Point(13, 14)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(251, 119)
        GroupBox1.TabIndex = 0
        GroupBox1.TabStop = False
        GroupBox1.Text = "Repeat Region"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(110, 86)
        TextBox1.Name = "TextBox1"
        TextBox1.ReadOnly = True
        TextBox1.Size = New Size(135, 23)
        TextBox1.TabIndex = 5
        TextBox1.Text = "0 Samples"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(7, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 16)
        Label3.TabIndex = 4
        Label3.Text = "Repeat Length:"
        ' 
        ' NumericUpDown2
        ' 
        NumericUpDown2.Location = New Point(110, 57)
        NumericUpDown2.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        NumericUpDown2.Name = "NumericUpDown2"
        NumericUpDown2.Size = New Size(135, 23)
        NumericUpDown2.TabIndex = 3
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(110, 25)
        NumericUpDown1.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(135, 23)
        NumericUpDown1.TabIndex = 2
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(7, 59)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 16)
        Label2.TabIndex = 1
        Label2.Text = "Repeat End:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(7, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(76, 16)
        Label1.TabIndex = 0
        Label1.Text = "Repeat Start:"
        ' 
        ' GroupBox2
        ' 
        GroupBox2.Controls.Add(TextBox3)
        GroupBox2.Controls.Add(Label6)
        GroupBox2.Controls.Add(TextBox2)
        GroupBox2.Controls.Add(Label5)
        GroupBox2.Controls.Add(NumericUpDown3)
        GroupBox2.Controls.Add(Label4)
        GroupBox2.Location = New Point(13, 140)
        GroupBox2.Name = "GroupBox2"
        GroupBox2.Size = New Size(251, 116)
        GroupBox2.TabIndex = 1
        GroupBox2.TabStop = False
        GroupBox2.Text = "Crossfade Region"
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(110, 84)
        TextBox3.Name = "TextBox3"
        TextBox3.ReadOnly = True
        TextBox3.Size = New Size(135, 23)
        TextBox3.TabIndex = 10
        TextBox3.Text = "0 Samples"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(7, 87)
        Label6.Name = "Label6"
        Label6.Size = New Size(86, 16)
        Label6.TabIndex = 9
        Label6.Text = "Crossfade End:"
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(110, 53)
        TextBox2.Name = "TextBox2"
        TextBox2.ReadOnly = True
        TextBox2.Size = New Size(135, 23)
        TextBox2.TabIndex = 8
        TextBox2.Text = "0 Samples"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(7, 57)
        Label5.Name = "Label5"
        Label5.Size = New Size(91, 16)
        Label5.TabIndex = 7
        Label5.Text = "Crossfade Start:"
        ' 
        ' NumericUpDown3
        ' 
        NumericUpDown3.Location = New Point(110, 25)
        NumericUpDown3.Maximum = New Decimal(New Integer() {Integer.MaxValue, 0, 0, 0})
        NumericUpDown3.Name = "NumericUpDown3"
        NumericUpDown3.Size = New Size(135, 23)
        NumericUpDown3.TabIndex = 6
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(7, 27)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 16)
        Label4.TabIndex = 0
        Label4.Text = "Crossfade Length:"
        ' 
        ' GroupBox3
        ' 
        GroupBox3.Controls.Add(TextBox4)
        GroupBox3.Controls.Add(Label8)
        GroupBox3.Controls.Add(TextBox5)
        GroupBox3.Controls.Add(Label7)
        GroupBox3.Location = New Point(280, 14)
        GroupBox3.Name = "GroupBox3"
        GroupBox3.Size = New Size(272, 119)
        GroupBox3.TabIndex = 2
        GroupBox3.TabStop = False
        GroupBox3.Text = "Final Loop Region"
        ' 
        ' TextBox4
        ' 
        TextBox4.Location = New Point(82, 80)
        TextBox4.Name = "TextBox4"
        TextBox4.ReadOnly = True
        TextBox4.Size = New Size(135, 23)
        TextBox4.TabIndex = 12
        TextBox4.Text = "0 Samples"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(12, 43)
        Label8.Name = "Label8"
        Label8.Size = New Size(65, 16)
        Label8.TabIndex = 6
        Label8.Text = "Loop Start:"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(82, 39)
        TextBox5.Name = "TextBox5"
        TextBox5.ReadOnly = True
        TextBox5.Size = New Size(135, 23)
        TextBox5.TabIndex = 11
        TextBox5.Text = "0 Samples"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 83)
        Label7.Name = "Label7"
        Label7.Size = New Size(60, 16)
        Label7.TabIndex = 7
        Label7.Text = "Loop End:"
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(405, 210)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 25)
        Button1.TabIndex = 3
        Button1.Text = "License"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(324, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 25)
        Button2.TabIndex = 4
        Button2.Text = "Help"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 16F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(564, 272)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox3)
        Controls.Add(GroupBox2)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Loop Point Calculator by sylvia-leaf"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        CType(NumericUpDown2, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        GroupBox2.ResumeLayout(False)
        GroupBox2.PerformLayout()
        CType(NumericUpDown3, ComponentModel.ISupportInitialize).EndInit()
        GroupBox3.ResumeLayout(False)
        GroupBox3.PerformLayout()
        ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown3 As NumericUpDown
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label7 As Label
End Class
