using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

using BingoLib;
using BingoUI;

namespace PatternMaskBuilder
{
    public partial class WinPatternMaskBuilder : Form
    {
        private bool _isPatternDirty = false;
        private bool _isTreeDirty = false;

        public WinPatternMaskBuilder()
        {
            InitializeComponent();
        }

        
        #region event handlers
        private void MainForm_Load(object sender, EventArgs e)
        {
            loadPatternTree();
            loadPatternNames();
        }
        
        private void btnDebug_Click(object sender, EventArgs e)
        {
        }

        private void cell_Click(object sender, EventArgs e)
        {
            CellLabel cell = (CellLabel)sender;
            cell.IsSelected = !cell.IsSelected;

            this._isPatternDirty = true;
        }

        private void btnAddPattern_Click(object sender, EventArgs e)
        {
            addPatternToTree();
            _isTreeDirty = true;
            //addPatternToList();
        }

        private void btnRemovePattern_Click(object sender, EventArgs e)
        {
            removePatternFromTree();
        }

        private void cell_MouseEnter(object sender, EventArgs e)
        {
            CellLabel theCell = (CellLabel)sender;
            theCell.IsHighlighted = true;
        }

        private void cell_MouseLeave(object sender, EventArgs e)
        {
            CellLabel theCell = (CellLabel)sender;
            theCell.IsHighlighted = false;
        }

        private void lstPatternSets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstPatternSets.SelectedIndex >= 0)
            {
                WinPatternListItem wpli = (WinPatternListItem)lstPatternSets.Items[lstPatternSets.SelectedIndex];
                displayThumbnail(wpli.GetPattern());
            }
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            if (this._isPatternDirty)
            {
                DialogResult dr = MessageBox.Show(this, "Would you like to save the current pattern?", "Unsaved changes detected", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                if (dr == DialogResult.Yes)
                    btnAddPattern_Click(null, null);

                foreach (Control ctl in this.Controls)
                {
                    if (ctl.GetType() == typeof(CellLabel))
                    {
                        CellLabel cell = (CellLabel)ctl;

                        if (cell.IsSelected)
                        {
                            cell.IsSelected = false;
                        }
                    }
                }

                this._isPatternDirty = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(this);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (_isTreeDirty)
            {
                DialogResult dr = MessageBox.Show(this, "Unsaved win patterns will be lost.  Continue loading?", "Changes not saved!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                if (dr == DialogResult.Yes)
                {
                    serializePatternTree();
                }
            }

            tvPatterns.Nodes.Clear();
            loadPatternTree();
            
            return;

            //WinPatternListItem wpli = (WinPatternListItem)this.lstPatternSets.Items[this.lstPatternSets.SelectedIndex];
            //CardPattern cp = wpli.GetPattern();
            //XmlSerializer xs = new XmlSerializer(cp.GetType());
            //StringWriter sw = new StringWriter();
            ////MemoryStream mem = new MemoryStream();
            //xs.Serialize(sw, cp);

            //MessageBox.Show(sw.ToString());
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (tvPatterns.SelectedNode != null && Type.Equals(tvPatterns.SelectedNode.GetType(), typeof(WinPatternLeafNode)))
            {
                WinPatternLeafNode wptn = (WinPatternLeafNode)tvPatterns.SelectedNode;
                displayThumbnail(wptn.GetPattern());
            }
        }

        private void btnExportList_Click(object sender, EventArgs e)
        {
            serializePatternTree();

            //serializePatternList();

            MessageBox.Show("Export complete.");
        }

        #endregion

        #region treeview helpers
        private void addPatternToTree()
        {
            TreeNode root = tvPatterns.TopNode;
            string patname = (string)cboName.Text;

            if (!root.Nodes.ContainsKey(patname))
            {
                TreeNode tn = new TreeNode(patname);
                tn.Name = patname;
                root.Nodes.Add(tn);
            }

            TreeNode node = root.Nodes[patname];
            int[,] p = buildCardPattern();
            WinPattern wp = new WinPattern(p);

            node.Nodes.Add(new WinPatternLeafNode(patname + (node.Nodes.Count + 1).ToString(), wp));
        }

        private void removePatternFromTree()
        {
            tvPatterns.Nodes.Remove(tvPatterns.SelectedNode);
            displayThumbnail(new CardPattern());
            _isTreeDirty = true;
        }

        #endregion

        #region pattern building
        private int[,] buildCardPattern()
        {
            int[,] p = {
                        { b2i(B0.IsSelected), b2i(I0.IsSelected), b2i(N0.IsSelected), b2i(G0.IsSelected), b2i(O0.IsSelected) },
                        { b2i(B1.IsSelected), b2i(I1.IsSelected), b2i(N1.IsSelected), b2i(G1.IsSelected), b2i(O1.IsSelected) },
                        { b2i(B2.IsSelected), b2i(I2.IsSelected), b2i(N2.IsSelected), b2i(G2.IsSelected), b2i(O2.IsSelected) },
                        { b2i(B3.IsSelected), b2i(I3.IsSelected), b2i(N3.IsSelected), b2i(G3.IsSelected), b2i(O3.IsSelected) },
                        { b2i(B4.IsSelected), b2i(I4.IsSelected), b2i(N4.IsSelected), b2i(G4.IsSelected), b2i(O4.IsSelected) }
                    };

            return p;

        }

        private int b2i(bool b)
        {
            if (b)
                return 1;
            else
                return 0;
        }
        #endregion

        #region load methods
        private void loadPatternNames()
        {
            string[] ptypes = Enum.GetNames(typeof(MatchedPattern));

            for (int i = 0; i < ptypes.Length; i++)
            {
                cboName.Items.Add(ptypes[i]);
            }

            cboName.SelectedIndex = 0;
        }

        private void loadPatternTree()
        {
            TreeNode root = tvPatterns.Nodes.Add("WinPatterns");
            string[] ptypes = Enum.GetNames(typeof(MatchedPattern));

            for (int i = 0; i < ptypes.Length; i++)
            {
                string ptype = ptypes[i];
                TreeNode setNode = new TreeNode(ptype);

                string path = Path.Combine(Application.StartupPath, "data");
                WinPatternSet wps = PatternSerializer.DeserializePatternSet(path, ptype);

                if (wps != null)
                {
                    for (int j = 0; j < wps.PatternCount; j++)
                    {
                        string nn = ptype + ((int)i + i).ToString();
                        WinPatternLeafNode wptn = new WinPatternLeafNode(nn, wps.Patterns[j]);
                        setNode.Nodes.Add(wptn);
                    }
                }
                setNode.Name = ptype;
                root.Nodes.Add(setNode);
            }
            _isTreeDirty = false;
            root.Expand();
        }

        #endregion
        
        #region save methods
        private void serializePatternTree()
        {
            TreeNode treeRoot = tvPatterns.TopNode;
            MatchedPattern en = MatchedPattern.NoMatch;

            foreach (TreeNode tn in treeRoot.Nodes)
            {
                if (Enum.IsDefined(typeof(MatchedPattern), tn.Text))
                {
                    en = (MatchedPattern)Enum.Parse(en.GetType(), tn.Text);
                    serializePatternSetNode(tn, en);
                }
                else
                {
                    en = MatchedPattern.NoMatch;
                }
            }
            _isPatternDirty = false;
        }

        private void serializePatternSetNode(TreeNode tn, MatchedPattern en)
        {
            WinPatternSet wps = new WinPatternSet(en);

            if (tn.Nodes.Count > 0)
            {
                for (int i = 0; i < tn.Nodes.Count; i++)
                {
                    WinPatternLeafNode wptn = (WinPatternLeafNode)tn.Nodes[i];
                    WinPattern wp = new WinPattern(wptn.GetPattern());

                    wps.Add(wp);
                }
                serializePatternSet(wps);
            }
        }

        private void serializePatternSet(WinPatternSet wps)
        {
            string path = Path.Combine(Application.StartupPath, "data");
            path = Path.Combine(path, wps.PatternType.ToString() + ".xml");

            XmlSerializer xs = new XmlSerializer(wps.GetType());
            XmlTextWriter xtw = new XmlTextWriter(path, Encoding.Default);

            xtw.WriteStartDocument();
            xs.Serialize(xtw, wps);

            xtw.Flush();
            xtw.Close();
        }
        #endregion

        #region graphics
        private void displayThumbnail(CardPattern p)
        {
            //throw new Exception("The method or operation is not implemented.");
            //Debug.WriteLine("thumbnail support not yet implemented.");

            Graphics gfx = this.picThumbnail.CreateGraphics();

            Rectangle surface = picThumbnail.ClientRectangle;

            SolidBrush fillBrush = new SolidBrush(Color.Red);
            SolidBrush emptyBrush = new SolidBrush(Color.White);

            Pen pen = new Pen(Color.Black);

            int w = (int)(surface.Width / 5);
            int h = (int)(surface.Height / 5);

            //gfx.Flush();

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (p[i - 1, j - 1] == 1)
                        gfx.FillRectangle(fillBrush, (i * w) - w, (j * h) - h, w, h);
                    else
                        gfx.FillRectangle(emptyBrush, (i * w) - w, (j * h) - h, w, h);

                    gfx.DrawRectangle(pen, (i * w) - w, (j * h) - h, w, h);
                }
            }
        }
        #endregion

    }
}