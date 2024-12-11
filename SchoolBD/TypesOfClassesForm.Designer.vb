<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TypesOfClassesForm
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim НаименованиеLabel As System.Windows.Forms.Label
        Dim ОписаниеLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TypesOfClassesForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolDataSet = New SchoolBD.SchoolDataSet()
        Me.Виды_классовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Виды_классовTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.Виды_классовTableAdapter()
        Me.TableAdapterManager = New SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager()
        Me.Виды_классовBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Виды_классовBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ОписаниеTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Виды_классовBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ВидыклассовBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        НаименованиеLabel = New System.Windows.Forms.Label()
        ОписаниеLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Виды_классовBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Виды_классовBindingNavigator.SuspendLayout()
        CType(Me.Виды_классовBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ВидыклассовBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'НаименованиеLabel
        '
        НаименованиеLabel.AutoSize = True
        НаименованиеLabel.Location = New System.Drawing.Point(262, 121)
        НаименованиеLabel.Name = "НаименованиеLabel"
        НаименованиеLabel.Size = New System.Drawing.Size(110, 17)
        НаименованиеLabel.TabIndex = 2
        НаименованиеLabel.Text = "Наименование:"
        '
        'ОписаниеLabel
        '
        ОписаниеLabel.AutoSize = True
        ОписаниеLabel.Location = New System.Drawing.Point(294, 162)
        ОписаниеLabel.Name = "ОписаниеLabel"
        ОписаниеLabel.Size = New System.Drawing.Size(78, 17)
        ОписаниеLabel.TabIndex = 4
        ОписаниеLabel.Text = "Описание:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(270, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Виды классов"""
        '
        'SchoolDataSet
        '
        Me.SchoolDataSet.DataSetName = "SchoolDataSet"
        Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Виды_классовBindingSource
        '
        Me.Виды_классовBindingSource.DataMember = "Виды_классов"
        Me.Виды_классовBindingSource.DataSource = Me.SchoolDataSet
        '
        'Виды_классовTableAdapter
        '
        Me.Виды_классовTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Виды_классовTableAdapter = Me.Виды_классовTableAdapter
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'Виды_классовBindingNavigator
        '
        Me.Виды_классовBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Виды_классовBindingNavigator.BindingSource = Me.Виды_классовBindingSource
        Me.Виды_классовBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Виды_классовBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Виды_классовBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Виды_классовBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Виды_классовBindingNavigatorSaveItem})
        Me.Виды_классовBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Виды_классовBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Виды_классовBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Виды_классовBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Виды_классовBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Виды_классовBindingNavigator.Name = "Виды_классовBindingNavigator"
        Me.Виды_классовBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Виды_классовBindingNavigator.Size = New System.Drawing.Size(800, 27)
        Me.Виды_классовBindingNavigator.TabIndex = 1
        Me.Виды_классовBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'Виды_классовBindingNavigatorSaveItem
        '
        Me.Виды_классовBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Виды_классовBindingNavigatorSaveItem.Image = CType(resources.GetObject("Виды_классовBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Виды_классовBindingNavigatorSaveItem.Name = "Виды_классовBindingNavigatorSaveItem"
        Me.Виды_классовBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.Виды_классовBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ОписаниеTextBox
        '
        Me.ОписаниеTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_классовBindingSource, "Описание", True))
        Me.ОписаниеTextBox.Location = New System.Drawing.Point(378, 159)
        Me.ОписаниеTextBox.Name = "ОписаниеTextBox"
        Me.ОписаниеTextBox.Size = New System.Drawing.Size(187, 22)
        Me.ОписаниеTextBox.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Виды_классовBindingSource, "Наименование", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Общеобразовательный", "Математический", "Гуманитарный", "Естественнонаучный", "Лингвистический"})
        Me.ComboBox1.Location = New System.Drawing.Point(378, 118)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 24)
        Me.ComboBox1.TabIndex = 6
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(338, 308)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 33)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(512, 260)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 33)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(338, 260)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 33)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(163, 260)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 33)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(512, 215)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 33)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(338, 215)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(163, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(163, 308)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 33)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(512, 308)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(130, 33)
        Me.Button9.TabIndex = 44
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'TypesOfClassesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 368)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(ОписаниеLabel)
        Me.Controls.Add(Me.ОписаниеTextBox)
        Me.Controls.Add(НаименованиеLabel)
        Me.Controls.Add(Me.Виды_классовBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TypesOfClassesForm"
        Me.Text = "TypesOfClassesForm"
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Виды_классовBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Виды_классовBindingNavigator.ResumeLayout(False)
        Me.Виды_классовBindingNavigator.PerformLayout()
        CType(Me.Виды_классовBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ВидыклассовBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolDataSet As SchoolDataSet
    Friend WithEvents Виды_классовBindingSource As BindingSource
    Friend WithEvents Виды_классовTableAdapter As SchoolDataSetTableAdapters.Виды_классовTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Виды_классовBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Виды_классовBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ОписаниеTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Виды_классовBindingSource1 As BindingSource
    Friend WithEvents ВидыклассовBindingSource As BindingSource
End Class
