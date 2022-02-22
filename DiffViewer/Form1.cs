using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using DiffPlex.DiffBuilder;
using DiffPlex.DiffBuilder.Model;

namespace DiffViewer
{
	public partial class Form1 : Form
	{
		private string OldText =
			@"We the people 
of the united states of america
establish justice
ensure domestic tranquility
provide for the common defence
secure the blessing of liberty
to ourselves and our posterity
";

		private string NewText =
			@"We the people
in order to form a more perfect union
establish justice
ensure domestic tranquility
promote the general welfare and
secure the blessing of liberty
to ourselves and our posterity
do ordain and establish this constitution
for the United States of America
";

		public Form1()
		{
			InitializeComponent();
			PerformSideBySideDiff();
		}


		private void PerformSideBySideDiff()
		{
			var builder = SideBySideDiffBuilder.Diff(OldText, NewText);
			if (builder.OldText.HasDifferences || builder.NewText.HasDifferences)
			{
				foreach (var line in builder.OldText.Lines)
				{
					if (!string.IsNullOrWhiteSpace(richTextBox1.Text))
					{
						richTextBox1.AppendText(Environment.NewLine);
					}
					if (line.SubPieces.Any())
					{
						foreach (var piece in line.SubPieces)
						{
							AddText(richTextBox1, piece);
						}
					}
					else
					{
						AddText(richTextBox1, line);
					}
				}

				foreach (var line in builder.NewText.Lines)
				{
					if (!string.IsNullOrWhiteSpace(richTextBox2.Text))
					{
						richTextBox2.AppendText(Environment.NewLine);
					}
					if (line.SubPieces.Any())
					{
						foreach (var piece in line.SubPieces)
						{
							AddText(richTextBox2, piece);
						}
					}
					else
					{
						AddText(richTextBox2, line);
					}
				}
			}
			else
			{
				richTextBox1.AppendText(OldText);
				richTextBox2.AppendText(NewText);
			}
		}

	
		private void AddText(RichTextBox box, DiffPiece piece)
		{
			switch (piece.Type)
			{
				case ChangeType.Unchanged:
					box.AppendText(piece.Text);
					break;
				case ChangeType.Deleted:
					box.SelectionColor = Color.Red;
					box.AppendText(piece.Text);
					break;
				case ChangeType.Inserted:
					box.SelectionColor = Color.Blue;
					box.AppendText(piece.Text);
					break;
				case ChangeType.Imaginary:
					box.AppendText(String.Empty);
					break;
				case ChangeType.Modified:
					box.SelectionColor = Color.Green;
					box.AppendText(piece.Text);
					break;
				default:
					box.SelectionColor = Color.Purple;
					box.AppendText(piece.Text);
					break;
			}
		}
	}
}