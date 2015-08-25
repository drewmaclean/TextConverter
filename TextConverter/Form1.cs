using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConverter
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void convertBtn_Click(object sender, EventArgs e)
    {
      var sb = new StringBuilder();
      if (convertRtb.Text.Contains('"'))
      {
        foreach (var line in convertRtb.Text.Split('+'))
        {
          var l = line.Trim(new char[] {'"', '+', ' '});
          var k = l.Replace("\"", "");
          sb.Append(k);
        }
        convertRtb.Text = sb.ToString();
      }
      else
      {
        int i = 0;
        var s = convertRtb.Text.Split(new char[] {'\r', '\n'});
        foreach (var line in s)
        {
          i++;
          sb.Append('"');
          sb.Append(line);
          sb.Append(" \"");
          if (i < s.Count())
          {
            sb.Append(" +");
            sb.AppendLine();
          }
         
        }
        convertRtb.Text = sb.ToString();
      }
    }
  }
}
