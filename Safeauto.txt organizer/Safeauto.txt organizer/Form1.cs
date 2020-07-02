using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Safeauto.txt_organizer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		OpenFileDialog ofd = new OpenFileDialog();

		string text = "";

		private void TxtButton_Click(object sender, EventArgs e)
		{
			ofd.Filter = "TXT|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				fileName.Text = ofd.SafeFileName;
				fileLocation.Text = ofd.FileName;
				StreamReader sr = new StreamReader(ofd.FileName);
				while ((text = sr.ReadLine()) != null)
				{


					if (text != null)
					{

						listBox1.Items.Add(text);

					}
				}
				sr.Close();
			}
		}



		private void Reset_Click(object sender, EventArgs e)
		{
			fileName.Text = String.Empty;
			fileLocation.Text = String.Empty;
			listBox1.Items.Clear();
		}


	}
}
