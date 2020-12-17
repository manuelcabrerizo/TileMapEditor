using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileMapEditor
{
    class Map
    {
        private int tileWidth;
        private int tileHeight;
        private int scale;
        private Bitmap sourceBmp;
        private PictureBox[,] tiles = new PictureBox[600, 3];
        private int[,] map = new int[600, 3];
        private int burshValue = 0;
        private int currentLayer = 0;
        private int tileSheetRows;
        private int tileSheetColumns;


        public Map(int tileWidth, int tileHeight, int scale)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.scale = scale;
        }


        private void Paint_Tile(object sender, MouseEventArgs e)
        {
            if(e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Control control = (Control)sender;

                if(control.Capture)
                {
                    control.Capture = false;
                }

                if(control.ClientRectangle.Contains(e.Location))
                {
                    PictureBox pictureBox = sender as PictureBox;
                    Point tilePos = (Point)pictureBox.Tag;

                    map[(tilePos.Y * 30) + tilePos.X, currentLayer] = burshValue;
                    int row = 0;
                    int column = 0;

                    try
                    {
                        row = map[(tilePos.Y * 30) + tilePos.X, currentLayer] % tileSheetColumns;
                        column = map[(tilePos.Y * 30) + tilePos.X, currentLayer] / tileSheetRows;
                        column = 5 - column;
                    }
                    catch (DivideByZeroException err)
                    {
                    }

                    Size destSize = new Size(tileWidth * scale, tileHeight * scale);
                    Size srcSize = new Size(tileWidth, tileHeight);
                    Point destLoc = new Point(0, 0);
                    Point srcLoc = new Point(tileHeight * row, tileWidth * column);
                    Rectangle destRect = new Rectangle(destLoc, destSize);
                    Rectangle srcRect = new Rectangle(srcLoc, srcSize);

                    Bitmap tile = new Bitmap((tileWidth * scale) - 2, (tileHeight * scale) - 2, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    tile.MakeTransparent();
                    Graphics G = Graphics.FromImage(tile);
                    G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

                    try
                    {
                        G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);
                    }
                    catch (ArgumentNullException err)
                    {
                    }
                    tiles[(tilePos.Y * 30) + tilePos.X, currentLayer].Image = tile;
                }
            }
        }

        public void LoadBMP(string filePath)
        {
            sourceBmp = new Bitmap(filePath);
        }

        public void SetUpTileMap()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 30; x++)
                {
                    for (int y = 0; y < 20; y++)
                    {
                        PictureBox p = new PictureBox();
                        if (i == 0)
                        {
                            p.BackColor = Color.FromArgb(100, 0, 0, 0);
                        }
                        else
                        {
                            p.BackColor = Color.Transparent;
                        }
                        p.Size = new Size(tileWidth * scale, tileHeight * scale);
                        p.Tag = new Point(x, y);
                        p.MouseMove += Paint_Tile;
                        p.MouseDown += Paint_Tile;
                        tiles[(y * 30) + x, i] = p;
                    }
                }
            }
        }
        public void DrawTileMAp(TableLayoutPanel tileMap)
        {
            for (int x = 0; x < 30; x++)
            {
                tileMap.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                for (int y = 0; y < 20; y++)
                {
                    if (x == 0)
                    {
                        tileMap.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    }
                    tiles[(y * 30) + x, 0].Controls.Add(tiles[(y * 30) + x, 1]);
                    tiles[(y * 30) + x, 1].Controls.Add(tiles[(y * 30) + x, 2]);
                    tileMap.Controls.Add(tiles[(y * 30) + x, 0], x, y);
                }
            }
        }
        public void SetBush(int value)
        {
            this.burshValue = value;
        }

        public void SetCurrentLayer(int layer)
        {
            this.currentLayer = layer;            
        }

        public void SetTileSheetInfo(int columns, int rows)
        {
            this.tileSheetColumns = columns;
            this.tileSheetRows = rows;
        }

        public int[,] GetMap()
        {

            return this.map;
        
        }
    }
}

