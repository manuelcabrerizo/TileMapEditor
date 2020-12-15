
namespace TileMapEditor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tileSheet = new System.Windows.Forms.TableLayoutPanel();
            this.tileMap = new System.Windows.Forms.TableLayoutPanel();
            this.loadFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.columnNumber = new System.Windows.Forms.NumericUpDown();
            this.rowsNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tileSheet
            // 
            this.tileSheet.ColumnCount = 2;
            this.tileSheet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileSheet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileSheet.Location = new System.Drawing.Point(1109, 13);
            this.tileSheet.Name = "tileSheet";
            this.tileSheet.RowCount = 2;
            this.tileSheet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileSheet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileSheet.Size = new System.Drawing.Size(428, 498);
            this.tileSheet.TabIndex = 1;
            // 
            // tileMap
            // 
            this.tileMap.ColumnCount = 2;
            this.tileMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileMap.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileMap.Location = new System.Drawing.Point(13, 13);
            this.tileMap.Name = "tileMap";
            this.tileMap.RowCount = 2;
            this.tileMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileMap.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tileMap.Size = new System.Drawing.Size(1090, 792);
            this.tileMap.TabIndex = 0;
            // 
            // loadFile
            // 
            this.loadFile.Location = new System.Drawing.Point(1292, 595);
            this.loadFile.Name = "loadFile";
            this.loadFile.Size = new System.Drawing.Size(75, 23);
            this.loadFile.TabIndex = 2;
            this.loadFile.Text = "Load File";
            this.loadFile.UseVisualStyleBackColor = true;
            this.loadFile.Click += new System.EventHandler(this.loadFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1270, 553);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1270, 514);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "columns";
            // 
            // columnNumber
            // 
            this.columnNumber.Location = new System.Drawing.Point(1273, 531);
            this.columnNumber.Name = "columnNumber";
            this.columnNumber.Size = new System.Drawing.Size(120, 20);
            this.columnNumber.TabIndex = 7;
            // 
            // rowsNumber
            // 
            this.rowsNumber.Location = new System.Drawing.Point(1273, 569);
            this.rowsNumber.Name = "rowsNumber";
            this.rowsNumber.Size = new System.Drawing.Size(120, 20);
            this.rowsNumber.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1556, 805);
            this.Controls.Add(this.rowsNumber);
            this.Controls.Add(this.columnNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadFile);
            this.Controls.Add(this.tileSheet);
            this.Controls.Add(this.tileMap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.columnNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rowsNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tileSheet;
        private System.Windows.Forms.TableLayoutPanel tileMap;
        private System.Windows.Forms.Button loadFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown columnNumber;
        private System.Windows.Forms.NumericUpDown rowsNumber;
    }
}

