using System;
using System.Collections;
using c = Wid.Core;

namespace Wid.Data
{
	public class SuspectList : c.AbstractDataTable
	{
		#region static IDataField IdField 
		public static c.IDataField IdField { get { return new IdFieldClass(); } }
		#endregion

		#region static IDataField SelectedField 
		public static c.IDataField SelectedField { get { return new SelectedRecord(); } }
		#endregion

		#region constructor 
		public SuspectList(ArrayList rows, int totalCount) : base(rows, totalCount) {}
		#endregion

		#region int FieldCount
		public override int FieldCount { get { return 17; } }
		#endregion

		#region SuspectListRow this[int row]
		public SuspectListRow this[int row] { get { return (SuspectListRow)Rows[row]; } }
		#endregion

		#region private
		private class IdFieldClass : c.IDataField
		{
			public string DataField { get { return "Id"; } }
			public string SortExpression { get { return "Suspect.Id"; } }
			public string Display { get { return "Id"; } }
		}

		private class SelectedRecord : c.IDataField
		{
			public string DataField { get { return "Selected"; } }
			public string SortExpression { get { return "Selected"; } }
			public string Display { get { return "Selected"; } }
		}
		#endregion
	}

	public class SuspectListRow : c.IDataRow
	{
		#region int Id
		public int Id
		{
			get { return id; }
			set { id = value; }
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
		private bool selected;
		#endregion
	}
}