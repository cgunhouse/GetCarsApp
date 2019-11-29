//
// Programmer: Craig Gunhouse
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CarsApp
{
    public partial class Form1 : Form
    {
        // Members
        private CarList crLst = new CarList();

        // Constructors
        public Form1()
        {
            InitializeComponent();
            cbSortBy.Items.Add(CarList.cNone);
            cbSortBy.Items.Add(CarList.cName);
            cbSortBy.Items.Add(CarList.cModel);
            cbSortBy.Items.Add(CarList.cColor);
            cbSortBy.Items.Add(CarList.cEngine);
            cbSortBy.Items.Add(CarList.cMileage);
            cbSortBy.SelectedIndex = cbSortBy.FindString(CarList.cNone);

            cbFilterBy.Items.Add(CarList.cNone);
            cbFilterBy.Items.Add(CarList.cName);
            cbFilterBy.Items.Add(CarList.cModel);
            cbFilterBy.Items.Add(CarList.cColor);
            cbFilterBy.Items.Add(CarList.cEngine);
            cbFilterBy.Items.Add(CarList.cMileage);
            cbFilterBy.SelectedIndex = cbFilterBy.FindString(CarList.cNone);

            lblMileage.Visible = false;
            txtMileage.Visible = false;
            lblNames.Visible = false;
            lbNames.Visible = false;
            lblModels.Visible = false;
            lbModels.Visible = false;
            lblEngines.Visible = false;
            lbEngines.Visible = false;


            String URLString = "https://mobiledev.sunovacu.ca/api/Test/GetCars";

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(URLString);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();

            crLst.Loader(content);
            generateTable();


            //            string sFName = @"c:\Temp\GetCars.xml";
            //            XmlTextReader xmlRdr = new XmlTextReader(sFName);
            //            bool bRtn = crLst.xmlLoader(xmlRdr);

            List<string> lModels = crLst.getUniqueModels();
            List<string> lNames = crLst.getUniqueNames();
            List<string> lEngines = crLst.getUniqueEngines();
            List<string> lColors = crLst.getUniqueColors();

            lbNames.Items.Clear();

            foreach (string sName in lNames)
            {
                lbNames.Items.Add(sName);
            }

            foreach (string sModel in lModels)
            {
                lbModels.Items.Add(sModel);
            }

            foreach (string sEngine in lEngines)
            {
                lbEngines.Items.Add(sEngine);
            }

            foreach (string sColor in lColors)
            {
                lbColors.Items.Add(sColor);
            }

        }

        // Methods
        public void generateTable()
        {
            tbCars.Visible = false;
            List<Car> sflCar = crLst.getList();

            tbCars.Controls.Clear();
            tbCars.RowStyles.Clear();

            tbCars.ColumnCount = 5;
            tbCars.RowCount = 1;
            tbCars.Height = 22 + sflCar.Count * 16;
            tbCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tbCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tbCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tbCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tbCars.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tbCars.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tbCars.Controls.Add(new Label() { Text = "Name", BackColor = Color.LightBlue}, 0, 0);
            tbCars.Controls.Add(new Label() { Text = "Model", BackColor = Color.LightBlue }, 1, 0);
            tbCars.Controls.Add(new Label() { Text = "Engine", BackColor = Color.LightBlue }, 2, 0);
            tbCars.Controls.Add(new Label() { Text = "Color", BackColor = Color.LightBlue }, 3, 0);
            tbCars.Controls.Add(new Label() { Text = "Mileage", BackColor = Color.LightBlue }, 4, 0);

            foreach(Car car in sflCar)
            {
                Color cColor;

                tbCars.RowCount++;

                if (tbCars.RowCount % 2 == 0)
                {
                    cColor = Color.White;
                }
                else
                {
                    cColor = Color.LightGray;
                }

                tbCars.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
                tbCars.Controls.Add(new Label() { Text = car.Name, BackColor = cColor }, 0, tbCars.RowCount - 1);
                tbCars.Controls.Add(new Label() { Text = car.Model, BackColor = cColor }, 1, tbCars.RowCount - 1);
                tbCars.Controls.Add(new Label() { Text = car.Engine, BackColor = cColor, Width = 400 }, 2, tbCars.RowCount - 1);
                tbCars.Controls.Add(new Label() { Text = car.Color, BackColor = cColor }, 3, tbCars.RowCount - 1);
                tbCars.Controls.Add(new Label() { Text = car.Mileage.ToString(), BackColor = cColor }, 4, tbCars.RowCount - 1);
            }

            tbCars.Visible = true;
        }


        private void cbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sRtn = cbFilterBy.GetItemText(cbFilterBy.SelectedItem);

            txtMileage.Visible = false;
            lblMileage.Visible = false;
            lblNames.Visible = false;
            lbNames.Visible = false;
            lblModels.Visible = false;
            lbModels.Visible = false;
            lblEngines.Visible = false;
            lbEngines.Visible = false;
            lblColors.Visible = false;
            lbColors.Visible = false;

            switch (sRtn)
            {
                case CarList.cColor:
                    crLst.filterAttr = CarList.cColor;
                    lblColors.Visible = true;
                    lbColors.Visible = true;
                    break;

                case CarList.cEngine:
                    crLst.filterAttr = CarList.cEngine;
                    lblEngines.Visible = true;
                    lbEngines.Visible = true;
                    break;

                case CarList.cMileage:
                    crLst.filterAttr = CarList.cMileage;
                    txtMileage.Visible = true;
                    lblMileage.Visible = true;
                    break;

                case CarList.cModel:
                    crLst.filterAttr = CarList.cModel;
                    lblModels.Visible = true;
                    lbModels.Visible = true;
                    break;

                case CarList.cName:
                    crLst.filterAttr = CarList.cName;
                    lblNames.Visible = true;
                    lbNames.Visible = true;
                    break;

                case CarList.cNone:
                    crLst.filterAttr = CarList.cNone;
                    break;

            }
        }

        private void txtMileage_TextChanged(object sender, EventArgs e)
        {
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbCars_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbCars_CellPaint_1(object sender, TableLayoutCellPaintEventArgs e)
        {
            if (e.Row == 0)
            {
                e.Graphics.FillRectangle(Brushes.LightBlue, e.CellBounds);
            }
            else
            {

                if (e.Row % 2 == 0)
                {
                    e.Graphics.FillRectangle(Brushes.LightGray, e.CellBounds);
                }
                else
                {
                    e.Graphics.FillRectangle(Brushes.White, e.CellBounds);
                }
            }
        }

        private void bGenerate_Click(object sender, EventArgs e)
        {
            bool bErr = false;
            string sAttr = cbFilterBy.GetItemText(cbFilterBy.SelectedItem);
            crLst.sortAttr = cbSortBy.GetItemText(cbSortBy.SelectedItem);
            crLst.descending = cbDescending.Checked;

            //
            // Process the client filter request.
            //
            switch (sAttr)
            {

                case CarList.cMileage:

                    string sRtn = txtMileage.Text.Trim();

                    // 
                    //  Determine the comparison operator for Mileage.
                    //
                    switch (sRtn[0])
                    {
                        case '<':

                            if (sRtn[1] == '=')
                            {
                                crLst.cmp = crLst.LessThanEqual;
                                crLst.MileageCmp = 2;  // Less than or equal to the Mileage 
                                sRtn = sRtn.Substring(1);
                            }
                            else
                            {
                                crLst.cmp = crLst.LessThan;
                                crLst.MileageCmp = 1;
                            }

                            sRtn = sRtn.Substring(1);
                            break;

                        case '=':

                            if (sRtn[1] == '>')
                            {
                                crLst.cmp = crLst.GreaterThanEqual;
                                crLst.MileageCmp = 3;
                                sRtn = sRtn.Substring(1);
                            }
                            else
                            {

                                if (sRtn[1] == '<')
                                {
                                    crLst.cmp = crLst.LessThanEqual;
                                    crLst.MileageCmp = 2;  // Less than or equal to the Mileage 
                                    sRtn = sRtn.Substring(1);
                                }
                                else
                                {
                                    crLst.cmp = crLst.Equal;
                                    crLst.MileageCmp = 4;
                                }
                            }

                            sRtn = sRtn.Substring(1);
                            break;

                        case '>':

                            if (sRtn[1] == '=')
                            {
                                crLst.cmp = crLst.GreaterThanEqual;
                                crLst.MileageCmp = 3;  // Greater than or equal to the Mileage 
                                sRtn = sRtn.Substring(1);
                            }
                            else
                            {
                                crLst.cmp = crLst.GreaterThan;
                                crLst.MileageCmp = 5;
                            }

                            sRtn = sRtn.Substring(1);
                            break;

                        default:

                            MessageBox.Show("Invalid mileage rule, please use a \'<\', \'<=\', \'=\', \'>\', or \'=>\' followed  by a mileage amount.");
                            bErr = true;
                            break;
                    }

                    if (!bErr)
                    {
                        crLst.MileAmt = Convert.ToInt64(sRtn.Trim());
                    }

                    break;

                case CarList.cName:

                    List<string> lNames = new List<string>();

                    foreach(string sName in lbNames.SelectedItems)
                    {
                        lNames.Add(sName);
                    }

                    crLst.FilterValues = lNames;
                    break;

                case CarList.cModel:

                    List<string> lModels = new List<string>();

                    foreach (string sModel in lbModels.SelectedItems)
                    {
                        lModels.Add(sModel);
                    }

                    crLst.FilterValues = lModels;
                    break;

                case CarList.cEngine:

                    List<string> lEngines = new List<string>();

                    foreach (string sEngine in lbEngines.SelectedItems)
                    {
                        lEngines.Add(sEngine);
                    }

                    crLst.FilterValues = lEngines;
                    break;


                case CarList.cColor:

                    List<string> lColors = new List<string>();

                    foreach (string sColor in lbColors.SelectedItems)
                    {
                        lColors.Add(sColor);
                    }

                    crLst.FilterValues = lColors;
                    break;

            }

            if (!bErr)
            {
                generateTable();
            }

        }
    }
}
