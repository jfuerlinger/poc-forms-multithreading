using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace TraunbauerDemo2.FormsApp
{
  public partial class Form1 : Form
  {
    readonly BackgroundWorker _worker;

    public Form1()
    {
      InitializeComponent();
      
      _worker = new BackgroundWorker();
      _worker.DoWork += DoSomeWorkBackground;

      pnlMain.Focus();
    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
      Debug.WriteLine(keyData);
      return true;
    }

    private void DoSomeWorkBackground(object sender, DoWorkEventArgs e)
    {
      while (true)
      {
        Debug.WriteLine("Sending data to server ...");
        Thread.Sleep(500);
      }
    }

    private void BtnStart_Click(object sender, EventArgs e)
    {
      _worker.RunWorkerAsync();
    }
  }
}
