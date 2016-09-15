using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WHATechChallenge
{
    public partial class Form1 : Form
    {
        public DataTable TableSettled = new DataTable();
        public DataTable TableUnsettled = new DataTable();

        public DataTable TableSettledSum = new DataTable();
        public DataTable TableUnsettledSum = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        public string GetFileLoc()
        {
            OpenFileDialog _fileLoc = new OpenFileDialog();

            _fileLoc.ShowDialog();

            return _fileLoc.FileName;
        }


        public DataTable FillTable(DataTable DT, string Path)
        {
            int x, y;
            string[] alllines = File.ReadAllLines(Path);

            for (x = 0; x <= alllines.Count() - 1; x++)
            {
                if (x != 0)
                {
                    string[] MyRow = alllines[x].Split(',');
                    DT.Rows.Add();

                    for (y = 0; y <= DT.Columns.Count - 1; y++)
                    {
                        DT.Rows[x - 1][y] = MyRow[y];
                    }
                }
                else
                {
                    string[] Myheaders = alllines[x].Split(',');
                    foreach (string header in Myheaders)
                    {
                        DT.Columns.Add(header);
                    }
                }
            }

            return DT;
        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            string Path = GetFileLoc();
            if(!Path.Contains("Settled.csv"))
            {
                MessageBox.Show("Please select Settled.csv");
                txtSettled.Text = "";
            }
            else
            {
                txtSettled.Text = Path;
            }
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            string Path = GetFileLoc();
            if (!Path.Contains("Unsettled.csv"))
            {
                MessageBox.Show("Please select Unsettled.csv");
                txtUnsettled.Text = "";
            }
            else
            {
                txtUnsettled.Text = Path;
            }
        }

        private void btnEvaluate_Click(object sender, EventArgs e)
        {
            TableSettled = FillTable(TableSettled, txtSettled.Text);
            TableUnsettled = FillTable(TableUnsettled, txtUnsettled.Text);

            DataView MyView = new DataView(TableSettled);

            TableSettledSum = MyView.ToTable(true, "Customer");
            TableSettledSum.Columns.Add("Win Rate");

            int x,y;

            for(x = 0; x <= TableSettledSum.Rows.Count -1; x++)
            {
                decimal BetCount = 0, WinCount = 0;
                for(y=0; y <= TableSettled.Rows.Count -1; y++)
                {
                    if(TableSettledSum.Rows[x][0].ToString() == TableSettled.Rows[y][0].ToString())
                    {
                        BetCount++;
                        if(TableSettled.Rows[y]["Win"].ToString() != "0")
                        {
                            WinCount++;
                        }
                    }
                }
                TableSettledSum.Rows[x]["Win Rate"] = Math.Round(((WinCount / BetCount) * 100),2);
            }

            dgvSettled.DataSource = TableSettled;
            dgvSettledSum.DataSource = TableSettledSum;

            dgvUnsettled.DataSource = TableUnsettled;
        }
    }
}
