<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScheduleOfLessonsTable
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ScheduleOfLessonsTable))
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.РасписаниеЗанятийBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SchoolDataSet = New SchoolBD.SchoolDataSet()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Расписание_занятийBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Расписание_занятийTableAdapter = New SchoolBD.SchoolDataSetTableAdapters.Расписание_занятийTableAdapter()
        Me.TableAdapterManager = New SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager()
        Me.Расписание_занятийBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.Расписание_занятийBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.РасписаниеЗанятийBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Расписание_занятийDataGridView = New System.Windows.Forms.DataGridView()
        Me.ДатаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ДеньнеделиDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяначалаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ВремяокончанияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ОписаниеDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КоличествоучениковDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.БукваDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодобученияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ГодсозданияDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ПреподавательDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.КлассныйруководительDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.НаименованиеклассаDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.РасписаниеЗанятийBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеЗанятийBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.РасписаниеЗанятийBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.РасписаниеЗанятийBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Расписание_занятийBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Расписание_занятийBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Расписание_занятийBindingNavigator.SuspendLayout()
        CType(Me.РасписаниеЗанятийBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Расписание_занятийDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.РасписаниеЗанятийBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Items.AddRange(New Object() {"Дата", "День_недели", "Время_начала", "Время_окончания", "Наименование", "Описание", "Количество_учеников", "Буква", "Год_обучения", "Год_создания", "Преподаватель", "Классный_руководитель", "Наименование_класса"})
        Me.ListBox1.Location = New System.Drawing.Point(533, 153)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(250, 148)
        Me.ListBox1.TabIndex = 59
        '
        'РасписаниеЗанятийBindingSource
        '
        Me.РасписаниеЗанятийBindingSource.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource.DataSource = Me.SchoolDataSet
        '
        'SchoolDataSet
        '
        Me.SchoolDataSet.DataSetName = "SchoolDataSet"
        Me.SchoolDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(170, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(565, 29)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Запрос ""Расписание занятий"" (Табличный вид)"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(516, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 306)
        Me.GroupBox1.TabIndex = 60
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Сортировка"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(17, 202)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(217, 21)
        Me.RadioButton1.TabIndex = 11
        Me.RadioButton1.Text = "Сортировка по возрастанию"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(17, 229)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(190, 21)
        Me.RadioButton2.TabIndex = 12
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Сортирока по убыванию"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(17, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(250, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Сортировать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Поле для сортировки"
        '
        'Расписание_занятийBindingSource
        '
        Me.Расписание_занятийBindingSource.DataMember = "Расписание занятий"
        Me.Расписание_занятийBindingSource.DataSource = Me.SchoolDataSet
        '
        'Расписание_занятийTableAdapter
        '
        Me.Расписание_занятийTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = SchoolBD.SchoolDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.UsersTableAdapter = Nothing
        Me.TableAdapterManager.Виды_классовTableAdapter = Nothing
        Me.TableAdapterManager.ДолжностиTableAdapter = Nothing
        Me.TableAdapterManager.КлассыTableAdapter = Nothing
        Me.TableAdapterManager.ПредметыTableAdapter = Nothing
        Me.TableAdapterManager.РасписаниеTableAdapter = Nothing
        Me.TableAdapterManager.СотрудникиTableAdapter = Nothing
        Me.TableAdapterManager.УченикиTableAdapter = Nothing
        '
        'Расписание_занятийBindingNavigator
        '
        Me.Расписание_занятийBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Расписание_занятийBindingNavigator.BindingSource = Me.Расписание_занятийBindingSource
        Me.Расписание_занятийBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Расписание_занятийBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Расписание_занятийBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.Расписание_занятийBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Расписание_занятийBindingNavigatorSaveItem})
        Me.Расписание_занятийBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Расписание_занятийBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Расписание_занятийBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Расписание_занятийBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Расписание_занятийBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Расписание_занятийBindingNavigator.Name = "Расписание_занятийBindingNavigator"
        Me.Расписание_занятийBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Расписание_занятийBindingNavigator.Size = New System.Drawing.Size(833, 31)
        Me.Расписание_занятийBindingNavigator.TabIndex = 63
        Me.Расписание_занятийBindingNavigator.Text = "BindingNavigator1"
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
        'Расписание_занятийBindingNavigatorSaveItem
        '
        Me.Расписание_занятийBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Расписание_занятийBindingNavigatorSaveItem.Enabled = False
        Me.Расписание_занятийBindingNavigatorSaveItem.Image = CType(resources.GetObject("Расписание_занятийBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Расписание_занятийBindingNavigatorSaveItem.Name = "Расписание_занятийBindingNavigatorSaveItem"
        Me.Расписание_занятийBindingNavigatorSaveItem.Size = New System.Drawing.Size(29, 28)
        Me.Расписание_занятийBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'РасписаниеЗанятийBindingSource1
        '
        Me.РасписаниеЗанятийBindingSource1.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource1.DataSource = Me.SchoolDataSet
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(144, 531)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(341, 22)
        Me.TextBox1.TabIndex = 71
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(144, 459)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(341, 24)
        Me.ComboBox1.TabIndex = 70
        '
        'Button5
        '
        Me.Button5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button5.Location = New System.Drawing.Point(661, 514)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(122, 34)
        Me.Button5.TabIndex = 69
        Me.Button5.Text = "Закрыть"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button4.Location = New System.Drawing.Point(533, 514)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(122, 34)
        Me.Button4.TabIndex = 68
        Me.Button4.Text = "Найти"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button3.Location = New System.Drawing.Point(661, 474)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(122, 34)
        Me.Button3.TabIndex = 67
        Me.Button3.Text = "Показать все"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(533, 474)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 34)
        Me.Button2.TabIndex = 66
        Me.Button2.Text = "Фильтровать"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 531)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 17)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Критерий"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 462)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 17)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Дата"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(144, 494)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox2.TabIndex = 73
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 497)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 17)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Год обучения"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(322, 497)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 74
        Me.Label6.Text = "Буква"
        '
        'ComboBox3
        '
        Me.ComboBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(389, 494)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(96, 24)
        Me.ComboBox3.TabIndex = 75
        '
        'Расписание_занятийDataGridView
        '
        Me.Расписание_занятийDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Расписание_занятийDataGridView.AutoGenerateColumns = False
        Me.Расписание_занятийDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Расписание_занятийDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.Расписание_занятийDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Расписание_занятийDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ДатаDataGridViewTextBoxColumn, Me.ДеньнеделиDataGridViewTextBoxColumn, Me.ВремяначалаDataGridViewTextBoxColumn, Me.ВремяокончанияDataGridViewTextBoxColumn, Me.НаименованиеDataGridViewTextBoxColumn, Me.ОписаниеDataGridViewTextBoxColumn, Me.КоличествоучениковDataGridViewTextBoxColumn, Me.БукваDataGridViewTextBoxColumn, Me.ГодобученияDataGridViewTextBoxColumn, Me.ГодсозданияDataGridViewTextBoxColumn, Me.ПреподавательDataGridViewTextBoxColumn, Me.КлассныйруководительDataGridViewTextBoxColumn, Me.НаименованиеклассаDataGridViewTextBoxColumn})
        Me.Расписание_занятийDataGridView.DataSource = Me.РасписаниеЗанятийBindingSource4
        Me.Расписание_занятийDataGridView.Location = New System.Drawing.Point(35, 110)
        Me.Расписание_занятийDataGridView.Name = "Расписание_занятийDataGridView"
        Me.Расписание_занятийDataGridView.RowHeadersWidth = 51
        Me.Расписание_занятийDataGridView.RowTemplate.Height = 24
        Me.Расписание_занятийDataGridView.Size = New System.Drawing.Size(450, 329)
        Me.Расписание_занятийDataGridView.TabIndex = 75
        '
        'ДатаDataGridViewTextBoxColumn
        '
        Me.ДатаDataGridViewTextBoxColumn.DataPropertyName = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.HeaderText = "Дата"
        Me.ДатаDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ДатаDataGridViewTextBoxColumn.Name = "ДатаDataGridViewTextBoxColumn"
        '
        'ДеньнеделиDataGridViewTextBoxColumn
        '
        Me.ДеньнеделиDataGridViewTextBoxColumn.DataPropertyName = "День_недели"
        Me.ДеньнеделиDataGridViewTextBoxColumn.HeaderText = "День_недели"
        Me.ДеньнеделиDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ДеньнеделиDataGridViewTextBoxColumn.Name = "ДеньнеделиDataGridViewTextBoxColumn"
        '
        'ВремяначалаDataGridViewTextBoxColumn
        '
        Me.ВремяначалаDataGridViewTextBoxColumn.DataPropertyName = "Время_начала"
        Me.ВремяначалаDataGridViewTextBoxColumn.HeaderText = "Время_начала"
        Me.ВремяначалаDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ВремяначалаDataGridViewTextBoxColumn.Name = "ВремяначалаDataGridViewTextBoxColumn"
        '
        'ВремяокончанияDataGridViewTextBoxColumn
        '
        Me.ВремяокончанияDataGridViewTextBoxColumn.DataPropertyName = "Время_окончания"
        Me.ВремяокончанияDataGridViewTextBoxColumn.HeaderText = "Время_окончания"
        Me.ВремяокончанияDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ВремяокончанияDataGridViewTextBoxColumn.Name = "ВремяокончанияDataGridViewTextBoxColumn"
        '
        'НаименованиеDataGridViewTextBoxColumn
        '
        Me.НаименованиеDataGridViewTextBoxColumn.DataPropertyName = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.HeaderText = "Наименование"
        Me.НаименованиеDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.НаименованиеDataGridViewTextBoxColumn.Name = "НаименованиеDataGridViewTextBoxColumn"
        '
        'ОписаниеDataGridViewTextBoxColumn
        '
        Me.ОписаниеDataGridViewTextBoxColumn.DataPropertyName = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.HeaderText = "Описание"
        Me.ОписаниеDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ОписаниеDataGridViewTextBoxColumn.Name = "ОписаниеDataGridViewTextBoxColumn"
        '
        'КоличествоучениковDataGridViewTextBoxColumn
        '
        Me.КоличествоучениковDataGridViewTextBoxColumn.DataPropertyName = "Количество_учеников"
        Me.КоличествоучениковDataGridViewTextBoxColumn.HeaderText = "Количество_учеников"
        Me.КоличествоучениковDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.КоличествоучениковDataGridViewTextBoxColumn.Name = "КоличествоучениковDataGridViewTextBoxColumn"
        '
        'БукваDataGridViewTextBoxColumn
        '
        Me.БукваDataGridViewTextBoxColumn.DataPropertyName = "Буква"
        Me.БукваDataGridViewTextBoxColumn.HeaderText = "Буква"
        Me.БукваDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.БукваDataGridViewTextBoxColumn.Name = "БукваDataGridViewTextBoxColumn"
        '
        'ГодобученияDataGridViewTextBoxColumn
        '
        Me.ГодобученияDataGridViewTextBoxColumn.DataPropertyName = "Год_обучения"
        Me.ГодобученияDataGridViewTextBoxColumn.HeaderText = "Год_обучения"
        Me.ГодобученияDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ГодобученияDataGridViewTextBoxColumn.Name = "ГодобученияDataGridViewTextBoxColumn"
        '
        'ГодсозданияDataGridViewTextBoxColumn
        '
        Me.ГодсозданияDataGridViewTextBoxColumn.DataPropertyName = "Год_создания"
        Me.ГодсозданияDataGridViewTextBoxColumn.HeaderText = "Год_создания"
        Me.ГодсозданияDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ГодсозданияDataGridViewTextBoxColumn.Name = "ГодсозданияDataGridViewTextBoxColumn"
        '
        'ПреподавательDataGridViewTextBoxColumn
        '
        Me.ПреподавательDataGridViewTextBoxColumn.DataPropertyName = "Преподаватель"
        Me.ПреподавательDataGridViewTextBoxColumn.HeaderText = "Преподаватель"
        Me.ПреподавательDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ПреподавательDataGridViewTextBoxColumn.Name = "ПреподавательDataGridViewTextBoxColumn"
        '
        'КлассныйруководительDataGridViewTextBoxColumn
        '
        Me.КлассныйруководительDataGridViewTextBoxColumn.DataPropertyName = "Классный_руководитель"
        Me.КлассныйруководительDataGridViewTextBoxColumn.HeaderText = "Классный_руководитель"
        Me.КлассныйруководительDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.КлассныйруководительDataGridViewTextBoxColumn.Name = "КлассныйруководительDataGridViewTextBoxColumn"
        '
        'НаименованиеклассаDataGridViewTextBoxColumn
        '
        Me.НаименованиеклассаDataGridViewTextBoxColumn.DataPropertyName = "Наименование_класса"
        Me.НаименованиеклассаDataGridViewTextBoxColumn.HeaderText = "Наименование_класса"
        Me.НаименованиеклассаDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.НаименованиеклассаDataGridViewTextBoxColumn.Name = "НаименованиеклассаDataGridViewTextBoxColumn"
        '
        'РасписаниеЗанятийBindingSource4
        '
        Me.РасписаниеЗанятийBindingSource4.DataMember = "Расписание занятий"
        Me.РасписаниеЗанятийBindingSource4.DataSource = Me.SchoolDataSet
        '
        'ScheduleOfLessonsTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 577)
        Me.Controls.Add(Me.Расписание_занятийDataGridView)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Расписание_занятийBindingNavigator)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ScheduleOfLessonsTable"
        Me.Text = "Form1"
        CType(Me.РасписаниеЗанятийBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SchoolDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.Расписание_занятийBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Расписание_занятийBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Расписание_занятийBindingNavigator.ResumeLayout(False)
        Me.Расписание_занятийBindingNavigator.PerformLayout()
        CType(Me.РасписаниеЗанятийBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Расписание_занятийDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.РасписаниеЗанятийBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents SchoolDataSet As SchoolDataSet
    Friend WithEvents Расписание_занятийBindingSource As BindingSource
    Friend WithEvents Расписание_занятийTableAdapter As SchoolDataSetTableAdapters.Расписание_занятийTableAdapter
    Friend WithEvents TableAdapterManager As SchoolDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Расписание_занятийBindingNavigator As BindingNavigator
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
    Friend WithEvents Расписание_занятийBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents РасписаниеЗанятийBindingSource As BindingSource
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents РасписаниеЗанятийBindingSource1 As BindingSource
    Friend WithEvents Расписание_занятийDataGridView As DataGridView
    Friend WithEvents РасписаниеЗанятийBindingSource2 As BindingSource
    Friend WithEvents РасписаниеЗанятийBindingSource3 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents РасписаниеЗанятийBindingSource4 As BindingSource
    Friend WithEvents ДатаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ДеньнеделиDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяначалаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ВремяокончанияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ОписаниеDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КоличествоучениковDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents БукваDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодобученияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ГодсозданияDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ПреподавательDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents КлассныйруководительDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents НаименованиеклассаDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
