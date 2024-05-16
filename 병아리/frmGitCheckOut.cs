using Infragistics.Portable.Gauges.VisualData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using IAS.Packages.Git.Command;
using System.Windows.Forms;
using LibGit2Sharp;
using System.IO;
using Infragistics.Win.UltraWinTree;

namespace IAS.Packages.Git
{
	public partial class frmGitCheckOut : Form
	{
		public string shaValue { get; set; }
		public string commitMessage { get; set; }
		public string commitDate { get; set; }
		public object CommitFiles { get; set; }	

		private RevisionControl revisionControl;

		public frmGitCheckOut()
		{
			InitializeComponent();
		}

		private void btnGitCommit_Click(object sender, EventArgs e)
		{
		}
		private void GitRollBack()
		{
		}
		private void CheckoutSpecificFile()
		{
    }

    private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
    {

    }

    private void frmGitCheckOut_Load(object sender, EventArgs e)
    {
      List<string> files = new List<string>((IEnumerable<string>)CommitFiles);

      // 파일 목록을 UltraTree에 추가합니다.
      foreach (var file in files)
      {
        ultraTree1.Nodes.Add(file);
      }
    }
  }
}
