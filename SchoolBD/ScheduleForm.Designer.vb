<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ScheduleForm
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
        Dim ДатаLabel As System.Windows.Forms.Label
        Dim День_неделиLabel As System.Windows.Forms.Label
        Dim Код_классаLabel As System.Windows.Forms.Label
        Dim Код_предметаLabel As System.Windows.Forms.Label
        Dim Время_началаLabel As System.Windows.Forms.Label
        Dim Время_окончанияLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolDataSet = New SchoolBD.SchoolDataSet()
        Me.РасписаниеBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.РасписаниеTableAdapter()
        Me.TableAdapterManager = New SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager()
        Me.РасписаниеBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.РасписаниеBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ДатаDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.КлассыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлассыTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.КлассыTableAdapter()
        Me.ПредметыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ПредметыTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.ПредметыTableAdapter()
        Me.КлассыBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.КлассыBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ПредметыBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBox2 = New System.Windows.Forms.MaskedTextBox()
        ДатаLabel = New System.Windows.Forms.Label()
        День_неделиLabel = New System.Windows.Forms.Label()
        Код_классаLabel = New System.Windows.Forms.Label()
        Код_предметаLabel = New System.Windows.Forms.Label()
        Время_началаLabel = New System.Windows.Forms.Label()
        Время_окончанияLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.РасписаниеBindingNavigator.SuspendLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ПредметыBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ДатаLabel
        '
        ДатаLabel.AutoSize = True
        ДатаLabel.Location = New System.Drawing.Point(260, 143)
        ДатаLabel.Name = "ДатаLabel"
        ДатаLabel.Size = New System.Drawing.Size(46, 17)
        ДатаLabel.TabIndex = 2
        ДатаLabel.Text = "Дата:"
        '
        'День_неделиLabel
        '
        День_неделиLabel.AutoSize = True
        День_неделиLabel.Location = New System.Drawing.Point(208, 188)
        День_неделиLabel.Name = "День_неделиLabel"
        День_неделиLabel.Size = New System.Drawing.Size(98, 17)
        День_неделиLabel.TabIndex = 4
        День_неделиLabel.Text = "День недели:"
        '
        'Код_классаLabel
        '
        Код_классаLabel.AutoSize = True
        Код_классаLabel.Location = New System.Drawing.Point(220, 241)
        Код_классаLabel.Name = "Код_классаLabel"
        Код_классаLabel.Size = New System.Drawing.Size(86, 17)
        Код_классаLabel.TabIndex = 6
        Код_классаLabel.Text = "Код класса:"
        '
        'Код_предметаLabel
        '
        Код_предметаLabel.AutoSize = True
        Код_предметаLabel.Location = New System.Drawing.Point(201, 292)
        Код_предметаLabel.Name = "Код_предметаLabel"
        Код_предметаLabel.Size = New System.Drawing.Size(105, 17)
        Код_предметаLabel.TabIndex = 8
        Код_предметаLabel.Text = "Код предмета:"
        '
        'Время_началаLabel
        '
        Время_началаLabel.AutoSize = True
        Время_началаLabel.Location = New System.Drawing.Point(200, 345)
        Время_началаLabel.Name = "Время_началаLabel"
        Время_началаLabel.Size = New System.Drawing.Size(106, 17)
        Время_началаLabel.TabIndex = 10
        Время_началаLabel.Text = "Время начала:"
        '
        'Время_окончанияLabel
        '
        Время_окончанияLabel.AutoSize = True
        Время_окончанияLabel.Location = New System.Drawing.Point(177, 394)
        Время_окончанияLabel.Name = "Время_окончанияLabel"
        Время_окончанияLabel.Size = New System.Drawing.Size(129, 17)
        Время_окончанияLabel.TabIndex = 12
        Время_окончанияLabel.Text = "Время окончания:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(262, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Расписание"""
        '
        'SchoolDataSet
        '
        Me.SchoolDataSet.DataSetName = "SchoolDataSet"
        Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'РасписаниеBindingSource
        '
        Me.РасписаниеBindingSource.DataMember = "Расписание"
        Me.РасписаниеBindingSource.DataSource = Me.SchoolDataSet
        '
        'РасписаниеTableAdapter
        '
        Me.РасписаниеTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Me.РасписаниеTableAdapter
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'РасписаниеBindingNavigator
        '
        Me.РасписаниеBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.РасписаниеBindingNavigator.BindingSource = Me.РасписаниеBindingSource
        Me.РасписаниеBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.РасписаниеBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.РасписаниеBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.РасписаниеBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.РасписаниеBindingNavigatorSaveItem})
        Me.РасписаниеBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.РасписаниеBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.РасписаниеBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.РасписаниеBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.РасписаниеBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.РасписаниеBindingNavigator.Name = "РасписаниеBindingNavigator"
        Me.РасписаниеBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.РасписаниеBindingNavigator.Size = New System.Drawing.Size(800, 31)
        Me.РасписаниеBindingNavigator.TabIndex = 1
        Me.РасписаниеBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 28)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 31)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 31)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(29, 28)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'РасписаниеBindingNavigatorSaveItem
        '
        Me.РасписаниеBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.РасписаниеBindingNavigatorSaveItem.Image = CType(resources.GetObject("РасписаниеBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.РасписаниеBindingNavigatorSaveItem.Name = "РасписаниеBindingNavigatorSaveItem"
        Me.РасписаниеBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.РасписаниеBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ДатаDateTimePicker
        '
        Me.ДатаDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.РасписаниеBindingSource, "Дата", True))
        Me.ДатаDateTimePicker.Location = New System.Drawing.Point(312, 139)
        Me.ДатаDateTimePicker.Name = "ДатаDateTimePicker"
        Me.ДатаDateTimePicker.Size = New System.Drawing.Size(281, 22)
        Me.ДатаDateTimePicker.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "День_недели", True))
        Me.ComboBox1.DisplayMember = "Код_сотрудника"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"ПН", "ВТ", "СР", "ЧТ", "ПТ", "СБ"})
        Me.ComboBox1.Location = New System.Drawing.Point(312, 185)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(181, 24)
        Me.ComboBox1.TabIndex = 14
        Me.ComboBox1.ValueMember = "Код_сотрудника"
        '
        'КлассыBindingSource
        '
        Me.КлассыBindingSource.DataMember = "Классы"
        Me.КлассыBindingSource.DataSource = Me.SchoolDataSet
        '
        'КлассыTableAdapter
        '
        Me.КлассыTableAdapter.ClearBeforeFill = True
        '
        'ПредметыBindingSource
        '
        Me.ПредметыBindingSource.DataMember = "Предметы"
        Me.ПредметыBindingSource.DataSource = Me.SchoolDataSet
        '
        'ПредметыTableAdapter
        '
        Me.ПредметыTableAdapter.ClearBeforeFill = True
        '
        'КлассыBindingSource1
        '
        Me.КлассыBindingSource1.DataMember = "Классы"
        Me.КлассыBindingSource1.DataSource = Me.SchoolDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.РасписаниеBindingSource, "Код_класса", True))
        Me.ComboBox2.DataSource = Me.КлассыBindingSource2
        Me.ComboBox2.DisplayMember = "Код_класса"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(313, 241)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(180, 24)
        Me.ComboBox2.TabIndex = 15
        Me.ComboBox2.ValueMember = "Код_класса"
        '
        'КлассыBindingSource2
        '
        Me.КлассыBindingSource2.DataMember = "Классы"
        Me.КлассыBindingSource2.DataSource = Me.SchoolDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.РасписаниеBindingSource, "Код_предмета", True))
        Me.ComboBox3.DataSource = Me.ПредметыBindingSource1
        Me.ComboBox3.DisplayMember = "Код_предмета"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(313, 292)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(180, 24)
        Me.ComboBox3.TabIndex = 16
        Me.ComboBox3.ValueMember = "Код_предмета"
        '
        'ПредметыBindingSource1
        '
        Me.ПредметыBindingSource1.DataMember = "Предметы"
        Me.ПредметыBindingSource1.DataSource = Me.SchoolDataSet
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(330, 550)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 33)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(504, 502)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 33)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(330, 502)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 33)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(155, 502)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 33)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(504, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 33)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(330, 457)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(155, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(155, 550)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 33)
        Me.Button8.TabIndex = 42
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(504, 550)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(130, 33)
        Me.Button9.TabIndex = 43
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Время_начала", True))
        Me.MaskedTextBox1.Location = New System.Drawing.Point(313, 342)
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(181, 22)
        Me.MaskedTextBox1.TabIndex = 44
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.РасписаниеBindingSource, "Время_окончания", True))
        Me.MaskedTextBox2.Location = New System.Drawing.Point(313, 391)
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(181, 22)
        Me.MaskedTextBox2.TabIndex = 45
        '
        'ScheduleForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 621)
        Me.Controls.Add(Me.MaskedTextBox2)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Время_окончанияLabel)
        Me.Controls.Add(Время_началаLabel)
        Me.Controls.Add(Код_предметаLabel)
        Me.Controls.Add(Код_классаLabel)
        Me.Controls.Add(День_неделиLabel)
        Me.Controls.Add(ДатаLabel)
        Me.Controls.Add(Me.ДатаDateTimePicker)
        Me.Controls.Add(Me.РасписаниеBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ScheduleForm"
        Me.Text = "Form6"
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.РасписаниеBindingNavigator.ResumeLayout(False)
        Me.РасписаниеBindingNavigator.PerformLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ПредметыBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolDataSet As SchoolDataSet
    Friend WithEvents РасписаниеBindingSource As BindingSource
    Friend WithEvents РасписаниеTableAdapter As SchoolDataSetTableAdapters.РасписаниеTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents РасписаниеBindingNavigator As BindingNavigator
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
    Friend WithEvents РасписаниеBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ДатаDateTimePicker As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents КлассыBindingSource As BindingSource
    Friend WithEvents КлассыTableAdapter As SchoolDataSetTableAdapters.КлассыTableAdapter
    Friend WithEvents ПредметыBindingSource As BindingSource
    Friend WithEvents ПредметыTableAdapter As SchoolDataSetTableAdapters.ПредметыTableAdapter
    Friend WithEvents КлассыBindingSource1 As BindingSource
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents КлассыBindingSource2 As BindingSource
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ПредметыBindingSource1 As BindingSource
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
End Class
