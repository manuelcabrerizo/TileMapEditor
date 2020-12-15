using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TileMapEditor
{
    class TileSheet
    {
        private int rows;
        private int tileWidth;
        private int tileHeight;
        private int scale;
        Bitmap sourceBmp;
        Map mapPointer;

        public TileSheet(int tileWidth, int tileHeight, int scale, ref Map map)
        {
            this.tileWidth = tileWidth;
            this.tileHeight = tileHeight;
            this.scale = scale;
            this.mapPointer = map;
        }

        public void SetBitMap(string sourceBmp)
        {
            this.sourceBmp = new Bitmap(sourceBmp);
        }

        public void ClearTileSheet(TableLayoutPanel tileSheet)
        {
            tileSheet.RowCount = 0;
            tileSheet.ColumnCount = 0;
            tileSheet.RowStyles.Clear();
            tileSheet.ColumnStyles.Clear();
            tileSheet.Controls.Clear();
        }

        public void DrawTileSheet(int columns, int rows, TableLayoutPanel tileSheet)
        {
            this.rows = rows;
            for (int x = 0; x < columns; x++)
            {
                tileSheet.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                for (int y = 0; y < rows; y++)
                {
                    if (x == 0)
                    {
                        tileSheet.RowStyles.Add(new ColumnStyle(SizeType.AutoSize));
                    }

                    Size destSize = new Size(tileWidth * scale, tileHeight * scale);
                    Size srcSize = new Size(tileWidth, tileHeight);
                    Point destLoc = new Point(0, 0);
                    Point srcLoc = new Point(tileWidth * x, tileHeight * y);
                    Rectangle destRect = new Rectangle(destLoc, destSize);
                    Rectangle srcRect = new Rectangle(srcLoc, srcSize);

                    Bitmap tile = new Bitmap((tileWidth * scale) - 2, (tileHeight * scale) - 2, System.Drawing.Imaging.PixelFormat.Format24bppRgb);
                    tile.MakeTransparent();
                    Graphics G = Graphics.FromImage(tile);
                    G.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;
                    G.DrawImage(sourceBmp, destRect, srcRect, GraphicsUnit.Pixel);

                    PictureBox p = new PictureBox();
                    p.Size = new Size(tileWidth * scale, tileHeight * scale);
                    p.Tag = new Point(x ,5 - y);
                    p.MouseDown += pictureBox_Click;
                    p.Image = tile;
                    
                    tileSheet.Controls.Add(p, x, y);

                }
            }
        }



        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Point tilePos = (Point)pictureBox.Tag;
            int value = (tilePos.Y * this.rows) + tilePos.X;
            mapPointer.SetBush(value);
            
        }
    }

}
