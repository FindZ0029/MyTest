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

        public void GetSettledSum()
        {
            DataView MyView = new DataView(TableSettled);
            TableSettledSum = MyView.ToTable(true, "Customer");
            TableSettledSum.Columns.Add("Win Rate");
            TableSettledSum.Columns.Add("Average Bet");

            int x, y;

            for (x = 0; x <= TableSettledSum.Rows.Count - 1; x++)
            {
                decimal BetCount = 0, WinCount = 0, TotalBet = 0;
                for (y = 0; y <= TableSettled.Rows.Count - 1; y++)
                {
                    if (TableSettledSum.Rows[x][0].ToString() == TableSettled.Rows[y][0].ToString())
                    {
                        BetCount++;
                        TotalBet = TotalBet + Convert.ToDecimal(TableSettled.Rows[y]["Stake"]);
                        if (TableSettled.Rows[y]["Win"].ToString() != "0")
                        {
                            WinCount++;
                        }
                    }
                }

                TableSettledSum.Rows[x]["Average Bet"] = Math.Round(TotalBet / BetCount, 2);
                TableSettledSum.Rows[x]["Win Rate"] = Math.Round(((WinCount / BetCount) * 100), 2);
            }
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
            if (txtSettled.Text != "" && txtUnsettled.Text != "")
            {
                TableSettled = FillTable(TableSettled, txtSettled.Text);
                TableUnsettled = FillTable(TableUnsettled, txtUnsettled.Text);

                GetSettledSum();

                dgvSettled.DataSource = TableSettled;
                dgvSettledSum.DataSource = TableSettledSum;

                TableUnsettled.Columns.Add("Risks");
                CheckRisks();

                dgvUnsettled.DataSource = TableUnsettled;
            }
            else
            {
                MessageBox.Show("Please map both Settled.csv and Unsettled.csv");
            }
        }

        private void riskLegendToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Leg = new Form2();
            Leg.ShowDialog();
        }

        public void CheckRisks()
        {
            int x,y;

            for(x = 0; x <= TableUnsettled.Rows.Count-1; x++)
            {
                for(y=0; y <= TableSettledSum.Rows.Count -1; y++)
                {
                    if(TableUnsettled.Rows[x][0].ToString() == TableSettledSum.Rows[y][0].ToString())
                    {
                        if(Convert.ToDecimal(TableSettledSum.Rows[y]["Win Rate"]) > 60)
                        {
                            TableUnsettled.Rows[x]["Risks"] = 1;
                        }
                        if(Convert.ToDecimal(TableSettledSum.Rows[y]["Average Bet"]) * 10 > Convert.ToDecimal(TableUnsettled.Rows[x]["Stake"]))
                        {
                            if(TableUnsettled.Rows[x]["Risks"].ToString() != "")
                            {
                                TableUnsettled.Rows[x]["Risks"] = TableUnsettled.Rows[x]["Risks"] + ",2";
                            }
                            else
                            {
                                TableUnsettled.Rows[x]["Risks"] = 2;
                            }
                        }
                        if (Convert.ToDecimal(TableSettledSum.Rows[y]["Average Bet"]) * 30 > Convert.ToDecimal(TableUnsettled.Rows[x]["Stake"]))
                        {
                            if (TableUnsettled.Rows[x]["Risks"].ToString() != "")
                            {
                                TableUnsettled.Rows[x]["Risks"] = TableUnsettled.Rows[x]["Risks"] + ",3";
                            }
                            else
                            {
                                TableUnsettled.Rows[x]["Risks"] = 3;
                            }
                        }
                        if(Convert.ToDecimal(TableUnsettled.Rows[x]["To Win"]) > 1000)
                        {
                            if (TableUnsettled.Rows[x]["Risks"].ToString() != "")
                            {
                                TableUnsettled.Rows[x]["Risks"] = TableUnsettled.Rows[x]["Risks"] + ",4";
                            }
                            else
                            {
                                TableUnsettled.Rows[x]["Risks"] = 4;
                            }
                        }
                    }
                }
            }
        }
    }
}
