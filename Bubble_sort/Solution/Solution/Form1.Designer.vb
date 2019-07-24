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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.sort = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lb = New System.Windows.Forms.Label()
        Me.start = New System.Windows.Forms.Button()
        Me.bar = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.clock = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.label = New System.Windows.Forms.Label()
        Me.keys = New System.Windows.Forms.TextBox()
        Me.list = New System.Windows.Forms.RichTextBox()
        Me.lebel = New System.Windows.Forms.RichTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ex = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.r1 = New System.Windows.Forms.RadioButton()
        Me.r2 = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.bar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'sort
        '
        Me.sort.BackColor = System.Drawing.Color.DarkSlateGray
        resources.ApplyResources(Me.sort, "sort")
        Me.sort.Name = "sort"
        Me.sort.UseVisualStyleBackColor = False
        '
        'input
        '
        Me.input.BackColor = System.Drawing.SystemColors.ControlDark
        resources.ApplyResources(Me.input, "input")
        Me.input.Name = "input"
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'lb
        '
        resources.ApplyResources(Me.lb, "lb")
        Me.lb.BackColor = System.Drawing.Color.Tomato
        Me.lb.Name = "lb"
        '
        'start
        '
        Me.start.BackColor = System.Drawing.Color.DarkSlateGray
        Me.start.CausesValidation = False
        Me.start.Cursor = System.Windows.Forms.Cursors.AppStarting
        resources.ApplyResources(Me.start, "start")
        Me.start.ForeColor = System.Drawing.Color.Black
        Me.start.Name = "start"
        Me.start.UseCompatibleTextRendering = True
        Me.start.UseVisualStyleBackColor = False
        '
        'bar
        '
        Me.bar.BackColor = System.Drawing.Color.Tomato
        resources.ApplyResources(Me.bar, "bar")
        Me.bar.BackImageWrapMode = System.Windows.Forms.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.bar.BorderlineColor = System.Drawing.Color.Salmon
        Me.bar.BorderlineWidth = 5
        ChartArea2.AlignmentOrientation = System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal
        ChartArea2.BackColor = System.Drawing.Color.Salmon
        ChartArea2.Name = "ChartArea1"
        ChartArea2.ShadowColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bar.ChartAreas.Add(ChartArea2)
        Me.bar.Cursor = System.Windows.Forms.Cursors.Arrow
        Legend2.Name = "Legend1"
        Me.bar.Legends.Add(Legend2)
        Me.bar.Name = "bar"
        Me.bar.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None
        Series2.ChartArea = "ChartArea1"
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.IsXValueIndexed = True
        Series2.Legend = "Legend1"
        Series2.Name = "Value Of Elemnts"
        Me.bar.Series.Add(Series2)
        '
        'clock
        '
        Me.clock.Enabled = True
        Me.clock.Interval = 10000
        '
        'label
        '
        resources.ApplyResources(Me.label, "label")
        Me.label.Name = "label"
        '
        'keys
        '
        Me.keys.BackColor = System.Drawing.SystemColors.ScrollBar
        resources.ApplyResources(Me.keys, "keys")
        Me.keys.Name = "keys"
        '
        'list
        '
        Me.list.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        resources.ApplyResources(Me.list, "list")
        Me.list.BackColor = System.Drawing.Color.Tomato
        Me.list.ForeColor = System.Drawing.SystemColors.ControlText
        Me.list.Name = "list"
        Me.list.ReadOnly = True
        '
        'lebel
        '
        Me.lebel.BackColor = System.Drawing.Color.Tomato
        Me.lebel.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.lebel, "lebel")
        Me.lebel.Name = "lebel"
        Me.lebel.ReadOnly = True
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'ex
        '
        Me.ex.BackColor = System.Drawing.Color.DarkSlateGray
        Me.ex.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.ex, "ex")
        Me.ex.Name = "ex"
        Me.ex.UseVisualStyleBackColor = False
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'r1
        '
        resources.ApplyResources(Me.r1, "r1")
        Me.r1.Checked = True
        Me.r1.Name = "r1"
        Me.r1.TabStop = True
        Me.r1.UseVisualStyleBackColor = True
        '
        'r2
        '
        resources.ApplyResources(Me.r2, "r2")
        Me.r2.Name = "r2"
        Me.r2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.Tomato
        Me.CancelButton = Me.ex
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.r2)
        Me.Controls.Add(Me.r1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ex)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lebel)
        Me.Controls.Add(Me.list)
        Me.Controls.Add(Me.keys)
        Me.Controls.Add(Me.label)
        Me.Controls.Add(Me.bar)
        Me.Controls.Add(Me.start)
        Me.Controls.Add(Me.lb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.sort)
        Me.HelpButton = True
        Me.Name = "Form1"
        CType(Me.bar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sort As System.Windows.Forms.Button
    Friend WithEvents input As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb As System.Windows.Forms.Label
    Friend WithEvents start As System.Windows.Forms.Button
    Friend WithEvents bar As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents clock As System.Windows.Forms.Timer
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents keys As System.Windows.Forms.TextBox
    Friend WithEvents list As System.Windows.Forms.RichTextBox
    Friend WithEvents lebel As System.Windows.Forms.RichTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ex As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents r1 As System.Windows.Forms.RadioButton
    Friend WithEvents r2 As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
