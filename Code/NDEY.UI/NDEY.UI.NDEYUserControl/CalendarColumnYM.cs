using System;
using System.Windows.Forms;

namespace NDEY.UI.NDEYUserControl
{
	public class CalendarColumnYM : DataGridViewColumn
	{
		public class CalendarCell : DataGridViewTextBoxCell
		{
			public override Type EditType
			{
				get
				{
					return typeof(CalendarColumnYM.CalendarEditingControl);
				}
			}

			public override Type ValueType
			{
				get
				{
					return typeof(DateTime);
				}
			}

			public override object DefaultNewRowValue
			{
				get
				{
					return "";
				}
			}

			public CalendarCell()
			{
				base.Style.Format = "yyyy年M月";
			}

			public override void InitializeEditingControl(int rowIndex, object initialFormattedValue, DataGridViewCellStyle dataGridViewCellStyle)
			{
				base.InitializeEditingControl(rowIndex, initialFormattedValue, dataGridViewCellStyle);
				CalendarColumnYM.CalendarEditingControl calendarEditingControl = base.DataGridView.EditingControl as CalendarColumnYM.CalendarEditingControl;
				if (base.Value == null || base.Value == DBNull.Value || base.Value.ToString() == "")
				{
					calendarEditingControl.Value = DateTime.Now;
					base.Value = calendarEditingControl.Value;
					return;
				}
				calendarEditingControl.Value = (DateTime)base.Value;
			}
		}

		private class CalendarEditingControl : DateTimePicker, IDataGridViewEditingControl
		{
			private DataGridView dataGridView;

			private bool valueChanged;

			private int rowIndex;

			public object EditingControlFormattedValue
			{
				get
				{
					return base.Value.ToString("yyyy年M月");
				}
				set
				{
					if (value is string)
					{
						try
						{
							base.Value = DateTime.Parse((string)value);
						}
						catch
						{
							base.Value = DateTime.Now;
						}
					}
				}
			}

			public int EditingControlRowIndex
			{
				get
				{
					return this.rowIndex;
				}
				set
				{
					this.rowIndex = value;
				}
			}

			public bool RepositionEditingControlOnValueChange
			{
				get
				{
					return false;
				}
			}

			public DataGridView EditingControlDataGridView
			{
				get
				{
					return this.dataGridView;
				}
				set
				{
					this.dataGridView = value;
				}
			}

			public bool EditingControlValueChanged
			{
				get
				{
					return this.valueChanged;
				}
				set
				{
					this.valueChanged = value;
				}
			}

			public Cursor EditingPanelCursor
			{
				get
				{
					return base.Cursor;
				}
			}

			public CalendarEditingControl()
			{
				base.Format = DateTimePickerFormat.Custom;
				base.CustomFormat = "yyyy年M月";
				base.ShowUpDown = true;
			}

			public object GetEditingControlFormattedValue(DataGridViewDataErrorContexts context)
			{
				return this.EditingControlFormattedValue;
			}

			public void ApplyCellStyleToEditingControl(DataGridViewCellStyle dataGridViewCellStyle)
			{
				this.Font = dataGridViewCellStyle.Font;
			}

			public bool EditingControlWantsInputKey(Keys key, bool dataGridViewWantsInputKey)
			{
				switch (key & Keys.KeyCode)
				{
				case Keys.Prior:
				case Keys.Next:
				case Keys.End:
				case Keys.Home:
				case Keys.Left:
				case Keys.Up:
				case Keys.Right:
				case Keys.Down:
					return true;
				default:
					return !dataGridViewWantsInputKey;
				}
			}

			public void PrepareEditingControlForEdit(bool selectAll)
			{
			}

			protected override void OnValueChanged(EventArgs eventargs)
			{
				this.valueChanged = true;
				this.EditingControlDataGridView.NotifyCurrentCellDirty(true);
				base.OnValueChanged(eventargs);
			}
		}

		public override DataGridViewCell CellTemplate
		{
			get
			{
				return base.CellTemplate;
			}
			set
			{
				if (value != null && !value.GetType().IsAssignableFrom(typeof(CalendarColumnYM.CalendarCell)))
				{
					throw new InvalidCastException("Must be a CalendarCell");
				}
				base.CellTemplate = value;
			}
		}

		public CalendarColumnYM() : base(new CalendarColumnYM.CalendarCell())
		{
		}
	}
}
