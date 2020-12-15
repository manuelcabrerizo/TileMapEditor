using System;
using System.Drawing;
using System.Windows.Forms;

namespace TileMapEditor
{
    public partial class Form1 : Form
    {
        static private Map map = new Map(16, 16, 4);
        private TileSheet tileSheetContainer = new TileSheet(16, 16, 4, ref map);
        public Form1()
        {
            InitializeComponent();
            this.KeyDown += keyEventHandler;

            tileMap.RowCount = 0;
            tileMap.ColumnCount = 0;
            tileMap.RowStyles.Clear();
            tileMap.ColumnStyles.Clear();
            tileMap.AutoScroll = true;
            tileMap.BackColor = Color.FromArgb(100, 0, 0, 0);

            tileSheet.RowCount = 0;
            tileSheet.ColumnCount = 0;
            tileSheet.RowStyles.Clear();
            tileSheet.ColumnStyles.Clear();
            tileSheet.AutoScroll = true;
            tileSheet.BackColor = Color.FromArgb(100, 0, 0, 0);

            
            map.SetUpTileMap(this.tileMap);
            map.DrawTileMAp(this.tileMap);
        }

        private void keyEventHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1)
            {
                map.SetCurrentLayer(0);
                MessageBox.Show("1");
            }

            if (e.KeyCode == Keys.D2)
            {
                map.SetCurrentLayer(1);
                MessageBox.Show("2");
            }

            if (e.KeyCode == Keys.D3)
            {
                map.SetCurrentLayer(2);
                MessageBox.Show("3");
            }

            if (e.KeyCode == Keys.Escape)
            {
                loadFile.Enabled = true;
                columnNumber.Enabled = true;
                rowsNumber.Enabled = true;
            }
        }

        private void loadFile_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                map.LoadBMP(file);
                map.SetTileSheetInfo(Convert.ToInt32(columnNumber.Value), Convert.ToInt32(rowsNumber.Value));
                tileSheetContainer.SetBitMap(file);
                tileSheetContainer.ClearTileSheet(this.tileSheet);
                tileSheetContainer.DrawTileSheet(Convert.ToInt32(columnNumber.Value), Convert.ToInt32(rowsNumber.Value), this.tileSheet);
                loadFile.Enabled = false;
                columnNumber.Enabled = false;
                rowsNumber.Enabled = false;
            }
        }
    }
}

