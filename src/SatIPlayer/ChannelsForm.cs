using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils.DragDrop;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;


namespace SatIPlayer
{
	public partial class ChannelsForm : Form
	{
		private BindingList<ChannelInfo> _favorites = new BindingList<ChannelInfo>();

		public ChannelsForm()
		{
			InitializeComponent();

		}

		public List<ChannelInfo> Channels { get; internal set; }
		public ChannelInfo SelectedEntry { get; internal set; }

		public List<ChannelInfo> FavoriteChannels
		{
			get
			{
				List<ChannelInfo> result = new List<ChannelInfo>();
				result.AddRange(_favorites);
				return result;
			}
			internal set
			{
				if (value == null)
				{
					return;
				}
				_favorites = new BindingList<ChannelInfo>(value);
			}
		}


		private void Form1_Load(object sender, EventArgs e)
		{
			gridControlAllChannels.DataSource = Channels;

			gridControlFavoriteChannels.DataSource = _favorites;
		}

		private void gridControl1_DoubleClick(object sender, EventArgs e)
		{
			ChannelInfo entry = gridViewAllChannels.GetFocusedRow() as ChannelInfo;
			if (entry == null)
			{
				return;
			}
			SelectedEntry = entry;
			base.Close();
		}

		private void dragDropEvents1_DragOver(object sender, DevExpress.Utils.DragDrop.DragOverEventArgs e)
		{
			// The data on GRID1 can´t be sorted using the drag&Drop.
			//if (e.Source == e.Target)
			//{
			//	e.InsertType = InsertType.None;
			//	e.Action = DragDropActions.None;
			//	Cursor = System.Windows.Forms.Cursors.No;
			//	e.Handled = true;
			//}
		}

		private void dragDropEventsFav_DragOver(object sender, DevExpress.Utils.DragDrop.DragOverEventArgs e)
		{
			DragOverGridEventArgs args = DragOverGridEventArgs.GetDragOverGridEventArgs(e);
			if (e.Target == e.Source && args.InsertType == InsertType.After && args.HitInfo.RowHandle != _favorites.Count - 1)
			{
				Trace.WriteLine($"## {args.HitInfo.RowHandle:X}");
				e.InsertType = InsertType.None;
				e.Action = DragDropActions.None;
				//Cursor = Cursors.No;
				e.Handled = true;
				return;
			}
			//if (args.HitInfo.HitTest == DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitTest.EmptyRow)
			//{
			//	//e.Action = DragDropActions.;
			//	Cursor.Current = Cursors.Hand;//keine sichtbare auswirkung
			//	args.Handled = true;
			//	return;
			//}
			e.InsertType = args.InsertType;
			//e.InsertType = InsertType.After;//keine sichtbare auswirkung
			e.InsertIndicatorLocation = args.InsertIndicatorLocation;
			e.Action = args.Action;
			Cursor.Current = args.Cursor;
			args.Handled = true;
		}

		private void dragDropEventsFav_DragDrop(object sender, DevExpress.Utils.DragDrop.DragDropEventArgs e)
		{
			DragDropGridEventArgs args = (DragDropGridEventArgs)e;
			GridView targetGrid = e.Target as GridView;
			GridView sourceGrid = e.Source as GridView;
			if (e.Action == DragDropActions.None)
			{
				return;
			}

			if (targetGrid == sourceGrid)
			{
				int targetIndex = args.HitInfo.RowHandle;
				if (args.InsertType == InsertType.After)
				{
					targetIndex = _favorites.Count;
				}
				List<ChannelInfo> toAdd = new List<ChannelInfo>();
				foreach (ChannelInfo dataRow in args.DataRows)
				{
					int removeIndex = _favorites.IndexOf(dataRow);
					if (removeIndex <= targetIndex)
					{
						--targetIndex;
					}
					_favorites.Remove(dataRow);
					toAdd.Add(dataRow);
				}
				for (int rowIndex = toAdd.Count - 1; rowIndex >= 0; rowIndex--)
				{
					_favorites.Insert(targetIndex, (ChannelInfo)toAdd[rowIndex]);
				}
			}
			else
			{
				//wenn die grids unterschiedliche klassen als Daten nutzen
				// https://www.devexpress.com/Support/Center/Question/Details/T636981/drag-drop-betwen-2-bandedgridview-with-diferent-data
				int index = args.HitInfo.RowHandle;

				if (index == GridControl.AutoFilterRowHandle)
				{
					index = 0;
				}


				for (int rowIndex = args.DataRows.Length - 1; rowIndex >= 0; rowIndex--)
				{
					_favorites.Insert(index, (ChannelInfo)args.DataRows[rowIndex]);
				}
				args.Handled = true;
			}
		}
	}
}
