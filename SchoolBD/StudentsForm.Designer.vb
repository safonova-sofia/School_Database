<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentsForm
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
        Dim ФИОLabel As System.Windows.Forms.Label
        Dim Дата_рожденияLabel As System.Windows.Forms.Label
        Dim ПолLabel As System.Windows.Forms.Label
        Dim АдресLabel As System.Windows.Forms.Label
        Dim ФИО_отцаLabel As System.Windows.Forms.Label
        Dim ФИО_материLabel As System.Windows.Forms.Label
        Dim Код_классаLabel As System.Windows.Forms.Label
        Dim Дополнительная_информацияLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentsForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchoolDataSet = New SchoolBD.SchoolDataSet()
        Me.УченикиBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.УченикиTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.УченикиTableAdapter()
        Me.TableAdapterManager = New SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager()
        Me.УченикиBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.УченикиBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ФИОTextBox = New System.Windows.Forms.TextBox()
        Me.Дата_рожденияDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.АдресTextBox = New System.Windows.Forms.TextBox()
        Me.ФИО_отцаTextBox = New System.Windows.Forms.TextBox()
        Me.ФИО_материTextBox = New System.Windows.Forms.TextBox()
        Me.Дополнительная_информацияTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.КлассыBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.КлассыBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлассыBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.КлассыTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.КлассыTableAdapter()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        ФИОLabel = New System.Windows.Forms.Label()
        Дата_рожденияLabel = New System.Windows.Forms.Label()
        ПолLabel = New System.Windows.Forms.Label()
        АдресLabel = New System.Windows.Forms.Label()
        ФИО_отцаLabel = New System.Windows.Forms.Label()
        ФИО_материLabel = New System.Windows.Forms.Label()
        Код_классаLabel = New System.Windows.Forms.Label()
        Дополнительная_информацияLabel = New System.Windows.Forms.Label()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.УченикиBindingNavigator.SuspendLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.КлассыBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ФИОLabel
        '
        ФИОLabel.AutoSize = True
        ФИОLabel.Location = New System.Drawing.Point(343, 115)
        ФИОLabel.Name = "ФИОLabel"
        ФИОLabel.Size = New System.Drawing.Size(46, 17)
        ФИОLabel.TabIndex = 2
        ФИОLabel.Text = "ФИО:"
        '
        'Дата_рожденияLabel
        '
        Дата_рожденияLabel.AutoSize = True
        Дата_рожденияLabel.Location = New System.Drawing.Point(274, 155)
        Дата_рожденияLabel.Name = "Дата_рожденияLabel"
        Дата_рожденияLabel.Size = New System.Drawing.Size(115, 17)
        Дата_рожденияLabel.TabIndex = 4
        Дата_рожденияLabel.Text = "Дата рождения:"
        '
        'ПолLabel
        '
        ПолLabel.AutoSize = True
        ПолLabel.Location = New System.Drawing.Point(351, 199)
        ПолLabel.Name = "ПолLabel"
        ПолLabel.Size = New System.Drawing.Size(38, 17)
        ПолLabel.TabIndex = 6
        ПолLabel.Text = "Пол:"
        '
        'АдресLabel
        '
        АдресLabel.AutoSize = True
        АдресLabel.Location = New System.Drawing.Point(337, 245)
        АдресLabel.Name = "АдресLabel"
        АдресLabel.Size = New System.Drawing.Size(52, 17)
        АдресLabel.TabIndex = 8
        АдресLabel.Text = "Адрес:"
        '
        'ФИО_отцаLabel
        '
        ФИО_отцаLabel.AutoSize = True
        ФИО_отцаLabel.Location = New System.Drawing.Point(308, 295)
        ФИО_отцаLabel.Name = "ФИО_отцаLabel"
        ФИО_отцаLabel.Size = New System.Drawing.Size(81, 17)
        ФИО_отцаLabel.TabIndex = 10
        ФИО_отцаLabel.Text = "ФИО отца:"
        AddHandler ФИО_отцаLabel.Click, AddressOf Me.ФИО_отцаLabel_Click
        '
        'ФИО_материLabel
        '
        ФИО_материLabel.AutoSize = True
        ФИО_материLabel.Location = New System.Drawing.Point(291, 337)
        ФИО_материLabel.Name = "ФИО_материLabel"
        ФИО_материLabel.Size = New System.Drawing.Size(98, 17)
        ФИО_материLabel.TabIndex = 12
        ФИО_материLabel.Text = "ФИО матери:"
        '
        'Код_классаLabel
        '
        Код_классаLabel.AutoSize = True
        Код_классаLabel.Location = New System.Drawing.Point(303, 376)
        Код_классаLabel.Name = "Код_классаLabel"
        Код_классаLabel.Size = New System.Drawing.Size(86, 17)
        Код_классаLabel.TabIndex = 14
        Код_классаLabel.Text = "Код класса:"
        '
        'Дополнительная_информацияLabel
        '
        Дополнительная_информацияLabel.AutoSize = True
        Дополнительная_информацияLabel.Location = New System.Drawing.Point(176, 419)
        Дополнительная_информацияLabel.Name = "Дополнительная_информацияLabel"
        Дополнительная_информацияLabel.Size = New System.Drawing.Size(213, 17)
        Дополнительная_информацияLabel.TabIndex = 16
        Дополнительная_информацияLabel.Text = "Дополнительная информация:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(361, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Таблица ""Ученики"""
        '
        'SchoolDataSet
        '
        Me.SchoolDataSet.DataSetName = "SchoolDataSet"
        Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'УченикиBindingSource
        '
        Me.УченикиBindingSource.DataMember = "Ученики"
        Me.УченикиBindingSource.DataSource = Me.SchoolDataSet
        '
        'УченикиTableAdapter
        '
        Me.УченикиTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Me.УченикиTableAdapter
        '
        'УченикиBindingNavigator
        '
        Me.УченикиBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.УченикиBindingNavigator.BindingSource = Me.УченикиBindingSource
        Me.УченикиBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.УченикиBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.УченикиBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.УченикиBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.УченикиBindingNavigatorSaveItem})
        Me.УченикиBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.УченикиBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.УченикиBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.УченикиBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.УченикиBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.УченикиBindingNavigator.Name = "УченикиBindingNavigator"
        Me.УченикиBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.УченикиBindingNavigator.Size = New System.Drawing.Size(945, 27)
        Me.УченикиBindingNavigator.TabIndex = 1
        Me.УченикиBindingNavigator.Text = "BindingNavigator1"
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
        'УченикиBindingNavigatorSaveItem
        '
        Me.УченикиBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.УченикиBindingNavigatorSaveItem.Image = CType(resources.GetObject("УченикиBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.УченикиBindingNavigatorSaveItem.Name = "УченикиBindingNavigatorSaveItem"
        Me.УченикиBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 24)
        Me.УченикиBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ФИОTextBox
        '
        Me.ФИОTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО", True))
        Me.ФИОTextBox.Location = New System.Drawing.Point(395, 112)
        Me.ФИОTextBox.Name = "ФИОTextBox"
        Me.ФИОTextBox.Size = New System.Drawing.Size(204, 22)
        Me.ФИОTextBox.TabIndex = 3
        '
        'Дата_рожденияDateTimePicker
        '
        Me.Дата_рожденияDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.УченикиBindingSource, "Дата_рождения", True))
        Me.Дата_рожденияDateTimePicker.Location = New System.Drawing.Point(395, 151)
        Me.Дата_рожденияDateTimePicker.Name = "Дата_рожденияDateTimePicker"
        Me.Дата_рожденияDateTimePicker.Size = New System.Drawing.Size(204, 22)
        Me.Дата_рожденияDateTimePicker.TabIndex = 5
        '
        'АдресTextBox
        '
        Me.АдресTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Адрес", True))
        Me.АдресTextBox.Location = New System.Drawing.Point(395, 242)
        Me.АдресTextBox.Name = "АдресTextBox"
        Me.АдресTextBox.Size = New System.Drawing.Size(204, 22)
        Me.АдресTextBox.TabIndex = 9
        '
        'ФИО_отцаTextBox
        '
        Me.ФИО_отцаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО_отца", True))
        Me.ФИО_отцаTextBox.Location = New System.Drawing.Point(395, 292)
        Me.ФИО_отцаTextBox.Name = "ФИО_отцаTextBox"
        Me.ФИО_отцаTextBox.Size = New System.Drawing.Size(204, 22)
        Me.ФИО_отцаTextBox.TabIndex = 11
        '
        'ФИО_материTextBox
        '
        Me.ФИО_материTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "ФИО_матери", True))
        Me.ФИО_материTextBox.Location = New System.Drawing.Point(395, 332)
        Me.ФИО_материTextBox.Name = "ФИО_материTextBox"
        Me.ФИО_материTextBox.Size = New System.Drawing.Size(204, 22)
        Me.ФИО_материTextBox.TabIndex = 13
        '
        'Дополнительная_информацияTextBox
        '
        Me.Дополнительная_информацияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Дополнительная_информация", True))
        Me.Дополнительная_информацияTextBox.Location = New System.Drawing.Point(395, 416)
        Me.Дополнительная_информацияTextBox.Name = "Дополнительная_информацияTextBox"
        Me.Дополнительная_информацияTextBox.Size = New System.Drawing.Size(204, 22)
        Me.Дополнительная_информацияTextBox.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.УченикиBindingSource, "Пол", True))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Мужской", "Женский"})
        Me.ComboBox1.Location = New System.Drawing.Point(395, 199)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(204, 24)
        Me.ComboBox1.TabIndex = 19
        '
        'КлассыBindingSource
        '
        Me.КлассыBindingSource.DataMember = "Классы"
        Me.КлассыBindingSource.DataSource = Me.SchoolDataSet
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(418, 577)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(130, 33)
        Me.Button7.TabIndex = 41
        Me.Button7.Text = "Сохранить"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(592, 529)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(130, 33)
        Me.Button6.TabIndex = 40
        Me.Button6.Text = "Удалить"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(418, 529)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(130, 33)
        Me.Button5.TabIndex = 39
        Me.Button5.Text = "Следующая"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(243, 529)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(130, 33)
        Me.Button4.TabIndex = 38
        Me.Button4.Text = "Последняя"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(592, 484)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 33)
        Me.Button3.TabIndex = 37
        Me.Button3.Text = "Добавить"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(418, 484)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 33)
        Me.Button2.TabIndex = 36
        Me.Button2.Text = "Предыдущая"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(243, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 33)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "Первая"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.УченикиBindingSource, "Код_класса", True))
        Me.ComboBox2.DataSource = Me.КлассыBindingSource2
        Me.ComboBox2.DisplayMember = "Код_класса"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(395, 376)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(204, 24)
        Me.ComboBox2.TabIndex = 42
        Me.ComboBox2.ValueMember = "Код_класса"
        '
        'КлассыBindingSource2
        '
        Me.КлассыBindingSource2.DataMember = "Классы"
        Me.КлассыBindingSource2.DataSource = Me.SchoolDataSet
        '
        'КлассыBindingSource1
        '
        Me.КлассыBindingSource1.DataMember = "Классы"
        Me.КлассыBindingSource1.DataSource = Me.SchoolDataSet
        '
        'КлассыTableAdapter
        '
        Me.КлассыTableAdapter.ClearBeforeFill = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(243, 577)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(130, 33)
        Me.Button8.TabIndex = 44
        Me.Button8.Text = "Таблица"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(592, 577)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(130, 33)
        Me.Button9.TabIndex = 45
        Me.Button9.Text = "Отчет"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'StudentsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 643)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Дополнительная_информацияLabel)
        Me.Controls.Add(Me.Дополнительная_информацияTextBox)
        Me.Controls.Add(Код_классаLabel)
        Me.Controls.Add(ФИО_материLabel)
        Me.Controls.Add(Me.ФИО_материTextBox)
        Me.Controls.Add(ФИО_отцаLabel)
        Me.Controls.Add(Me.ФИО_отцаTextBox)
        Me.Controls.Add(АдресLabel)
        Me.Controls.Add(Me.АдресTextBox)
        Me.Controls.Add(ПолLabel)
        Me.Controls.Add(Дата_рожденияLabel)
        Me.Controls.Add(Me.Дата_рожденияDateTimePicker)
        Me.Controls.Add(ФИОLabel)
        Me.Controls.Add(Me.ФИОTextBox)
        Me.Controls.Add(Me.УченикиBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudentsForm"
        Me.Text = "StudentsForm"
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.УченикиBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.УченикиBindingNavigator.ResumeLayout(False)
        Me.УченикиBindingNavigator.PerformLayout()
        CType(Me.КлассыBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.КлассыBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SchoolDataSet As SchoolDataSet
    Friend WithEvents УченикиBindingSource As BindingSource
    Friend WithEvents УченикиTableAdapter As SchoolDataSetTableAdapters.УченикиTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents УченикиBindingNavigator As BindingNavigator
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
    Friend WithEvents УченикиBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ФИОTextBox As TextBox
    Friend WithEvents Дата_рожденияDateTimePicker As DateTimePicker
    Friend WithEvents АдресTextBox As TextBox
    Friend WithEvents ФИО_отцаTextBox As TextBox
    Friend WithEvents ФИО_материTextBox As TextBox
    Friend WithEvents Дополнительная_информацияTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents КлассыBindingSource As BindingSource
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents КлассыBindingSource1 As BindingSource
    Friend WithEvents КлассыTableAdapter As SchoolDataSetTableAdapters.КлассыTableAdapter
    Friend WithEvents КлассыBindingSource2 As BindingSource
    Friend WithEvents Button8 As Button
    Friend WithEvents Button9 As Button
End Class
