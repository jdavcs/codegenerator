using System;
using System.Collections;
using c = Wid.Core;

namespace Wid.Data
{
	public class LineupTextList : c.AbstractDataTable
	{
		#region static IDataField IdField 
		public static c.IDataField IdField { get { return new IdFieldClass(); } }
		#endregion

		#region static IDataField NameField 
		public static c.IDataField NameField { get { return new NameFieldClass(); } }
		#endregion

		#region static IDataField SelectedField 
		public static c.IDataField SelectedField { get { return new SelectedRecord(); } }
		#endregion

		#region constructor 
		public LineupTextList(ArrayList rows, int totalCount) : base(rows, totalCount) {}
		#endregion

		#region int FieldCount
		public override int FieldCount { get { return 7; } }
		#endregion

		#region LineupTextListRow this[int row]
		public LineupTextListRow this[int row] { get { return (LineupTextListRow)Rows[row]; } }
		#endregion

		#region private
		private class IdFieldClass : c.IDataField
		{
			public string DataField { get { return "Id"; } }
			public string SortExpression { get { return "LineupText.Id"; } }
			public string Display { get { return "Id"; } }
		}

		private class NameFieldClass : c.IDataField
		{
			public string DataField { get { return "Name"; } }
			public string SortExpression { get { return "LineupText.Name"; } }
			public string Display { get { return "Name"; } }
		}

		private class SelectedRecord : c.IDataField
		{
			public string DataField { get { return "Selected"; } }
			public string SortExpression { get { return "Selected"; } }
			public string Display { get { return "Selected"; } }
		}
		#endregion
	}

	public class LineupTextListRow : c.IDataRow
	{
		#region int Id
		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		#endregion

		#region string Name
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		#endregion

		#region bool Selected
		public bool Selected
		{
			get { return selected; }
			set { selected = value; }
		}
		#endregion

		#region private
		private int id;
		private string name;
		private bool selected;
		#endregion
	}
}