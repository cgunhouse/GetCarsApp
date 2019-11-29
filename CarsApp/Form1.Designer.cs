namespace CarsApp
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
            this.lblSortBy = new System.Windows.Forms.Label();
            this.cbSortBy = new System.Windows.Forms.ComboBox();
            this.lblFilterBy = new System.Windows.Forms.Label();
            this.cbFilterBy = new System.Windows.Forms.ComboBox();
            this.lblMileage = new System.Windows.Forms.Label();
            this.txtMileage = new System.Windows.Forms.TextBox();
            this.lblNames = new System.Windows.Forms.Label();
            this.lbNames = new System.Windows.Forms.ListBox();
            this.lblModels = new System.Windows.Forms.Label();
            this.lbModels = new System.Windows.Forms.ListBox();
            this.lblEngines = new System.Windows.Forms.Label();
            this.lbEngines = new System.Windows.Forms.ListBox();
            this.lblColors = new System.Windows.Forms.Label();
            this.lbColors = new System.Windows.Forms.ListBox();
            this.tbCars = new System.Windows.Forms.TableLayoutPanel();
            this.bGenerate = new System.Windows.Forms.Button();
            this.cbDescending = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblSortBy
            // 
            this.lblSortBy.AutoSize = true;
            this.lblSortBy.Location = new System.Drawing.Point(29, 35);
            this.lblSortBy.Name = "lblSortBy";
            this.lblSortBy.Size = new System.Drawing.Size(44, 13);
            this.lblSortBy.TabIndex = 0;
            this.lblSortBy.Text = "Sort By:";
            // 
            // cbSortBy
            // 
            this.cbSortBy.FormattingEnabled = true;
            this.cbSortBy.Location = new System.Drawing.Point(94, 32);
            this.cbSortBy.Name = "cbSortBy";
            this.cbSortBy.Size = new System.Drawing.Size(121, 21);
            this.cbSortBy.TabIndex = 1;
            this.cbSortBy.SelectedIndexChanged += new System.EventHandler(this.cbSortBy_SelectedIndexChanged);
            // 
            // lblFilterBy
            // 
            this.lblFilterBy.AutoSize = true;
            this.lblFilterBy.Location = new System.Drawing.Point(29, 68);
            this.lblFilterBy.Name = "lblFilterBy";
            this.lblFilterBy.Size = new System.Drawing.Size(47, 13);
            this.lblFilterBy.TabIndex = 2;
            this.lblFilterBy.Text = "Filter By:";
            // 
            // cbFilterBy
            // 
            this.cbFilterBy.FormattingEnabled = true;
            this.cbFilterBy.Location = new System.Drawing.Point(94, 65);
            this.cbFilterBy.Name = "cbFilterBy";
            this.cbFilterBy.Size = new System.Drawing.Size(121, 21);
            this.cbFilterBy.TabIndex = 3;
            this.cbFilterBy.SelectedIndexChanged += new System.EventHandler(this.cbFilterBy_SelectedIndexChanged);
            // 
            // lblMileage
            // 
            this.lblMileage.AutoSize = true;
            this.lblMileage.Location = new System.Drawing.Point(240, 68);
            this.lblMileage.Name = "lblMileage";
            this.lblMileage.Size = new System.Drawing.Size(47, 13);
            this.lblMileage.TabIndex = 4;
            this.lblMileage.Text = "Mileage:";
            // 
            // txtMileage
            // 
            this.txtMileage.Location = new System.Drawing.Point(294, 65);
            this.txtMileage.Name = "txtMileage";
            this.txtMileage.Size = new System.Drawing.Size(129, 20);
            this.txtMileage.TabIndex = 5;
            this.txtMileage.TextChanged += new System.EventHandler(this.txtMileage_TextChanged);
            // 
            // lblNames
            // 
            this.lblNames.AutoSize = true;
            this.lblNames.Location = new System.Drawing.Point(243, 67);
            this.lblNames.Name = "lblNames";
            this.lblNames.Size = new System.Drawing.Size(38, 13);
            this.lblNames.TabIndex = 7;
            this.lblNames.Text = "Name:";
            // 
            // lbNames
            // 
            this.lbNames.FormattingEnabled = true;
            this.lbNames.Location = new System.Drawing.Point(294, 65);
            this.lbNames.Name = "lbNames";
            this.lbNames.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbNames.Size = new System.Drawing.Size(129, 95);
            this.lbNames.TabIndex = 8;
            // 
            // lblModels
            // 
            this.lblModels.AutoSize = true;
            this.lblModels.Location = new System.Drawing.Point(245, 66);
            this.lblModels.Name = "lblModels";
            this.lblModels.Size = new System.Drawing.Size(39, 13);
            this.lblModels.TabIndex = 9;
            this.lblModels.Text = "Model:";
            // 
            // lbModels
            // 
            this.lbModels.FormattingEnabled = true;
            this.lbModels.Location = new System.Drawing.Point(293, 65);
            this.lbModels.Name = "lbModels";
            this.lbModels.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbModels.Size = new System.Drawing.Size(129, 95);
            this.lbModels.TabIndex = 10;
            this.lbModels.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblEngines
            // 
            this.lblEngines.AutoSize = true;
            this.lblEngines.Location = new System.Drawing.Point(243, 65);
            this.lblEngines.Name = "lblEngines";
            this.lblEngines.Size = new System.Drawing.Size(43, 13);
            this.lblEngines.TabIndex = 11;
            this.lblEngines.Text = "Engine:";
            // 
            // lbEngines
            // 
            this.lbEngines.FormattingEnabled = true;
            this.lbEngines.Location = new System.Drawing.Point(294, 65);
            this.lbEngines.Name = "lbEngines";
            this.lbEngines.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbEngines.Size = new System.Drawing.Size(326, 95);
            this.lbEngines.TabIndex = 12;
            // 
            // lblColors
            // 
            this.lblColors.AutoSize = true;
            this.lblColors.Location = new System.Drawing.Point(243, 65);
            this.lblColors.Name = "lblColors";
            this.lblColors.Size = new System.Drawing.Size(34, 13);
            this.lblColors.TabIndex = 13;
            this.lblColors.Text = "Color:";
            // 
            // lbColors
            // 
            this.lbColors.FormattingEnabled = true;
            this.lbColors.Location = new System.Drawing.Point(294, 65);
            this.lbColors.Name = "lbColors";
            this.lbColors.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbColors.Size = new System.Drawing.Size(129, 95);
            this.lbColors.TabIndex = 14;
            // 
            // tbCars
            // 
            this.tbCars.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tbCars.ColumnCount = 5;
            this.tbCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.51565F));
            this.tbCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.95593F));
            this.tbCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.09024F));
            this.tbCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.94334F));
            this.tbCars.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.14643F));
            this.tbCars.Location = new System.Drawing.Point(32, 200);
            this.tbCars.Name = "tbCars";
            this.tbCars.RowCount = 2;
            this.tbCars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbCars.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbCars.Size = new System.Drawing.Size(954, 288);
            this.tbCars.TabIndex = 15;
            this.tbCars.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tbCars_CellPaint_1);
            this.tbCars.Paint += new System.Windows.Forms.PaintEventHandler(this.tbCars_Paint);
            // 
            // bGenerate
            // 
            this.bGenerate.Location = new System.Drawing.Point(766, 29);
            this.bGenerate.Name = "bGenerate";
            this.bGenerate.Size = new System.Drawing.Size(75, 23);
            this.bGenerate.TabIndex = 16;
            this.bGenerate.Text = "Generate";
            this.bGenerate.UseVisualStyleBackColor = true;
            this.bGenerate.Click += new System.EventHandler(this.bGenerate_Click);
            // 
            // cbDescending
            // 
            this.cbDescending.AutoSize = true;
            this.cbDescending.Location = new System.Drawing.Point(246, 35);
            this.cbDescending.Name = "cbDescending";
            this.cbDescending.Size = new System.Drawing.Size(132, 17);
            this.cbDescending.TabIndex = 17;
            this.cbDescending.Text = "Use Descending order";
            this.cbDescending.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 548);
            this.Controls.Add(this.cbDescending);
            this.Controls.Add(this.bGenerate);
            this.Controls.Add(this.tbCars);
            this.Controls.Add(this.lbColors);
            this.Controls.Add(this.lblColors);
            this.Controls.Add(this.lbEngines);
            this.Controls.Add(this.lblEngines);
            this.Controls.Add(this.lbModels);
            this.Controls.Add(this.lblModels);
            this.Controls.Add(this.lbNames);
            this.Controls.Add(this.lblNames);
            this.Controls.Add(this.txtMileage);
            this.Controls.Add(this.lblMileage);
            this.Controls.Add(this.cbFilterBy);
            this.Controls.Add(this.lblFilterBy);
            this.Controls.Add(this.cbSortBy);
            this.Controls.Add(this.lblSortBy);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSortBy;
        private System.Windows.Forms.ComboBox cbSortBy;
        private System.Windows.Forms.Label lblFilterBy;
        private System.Windows.Forms.ComboBox cbFilterBy;
        private System.Windows.Forms.Label lblMileage;
        private System.Windows.Forms.TextBox txtMileage;
        private System.Windows.Forms.Label lblNames;
        private System.Windows.Forms.ListBox lbNames;
        private System.Windows.Forms.Label lblModels;
        private System.Windows.Forms.ListBox lbModels;
        private System.Windows.Forms.Label lblEngines;
        private System.Windows.Forms.ListBox lbEngines;
        private System.Windows.Forms.Label lblColors;
        private System.Windows.Forms.ListBox lbColors;
        private System.Windows.Forms.TableLayoutPanel tbCars;
        private System.Windows.Forms.Button bGenerate;
        private System.Windows.Forms.CheckBox cbDescending;
    }
}

