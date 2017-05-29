using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace robetsBuildersMock
{
    public partial class RobertsBuilders : Form
    {
        public double Price;
        string Area;
        double dbArea;
        List<string> prices = new List<string>();
        public RobertsBuilders()
        {
            InitializeComponent();
        }

        private void RobertsBuilders_Load(object sender, EventArgs e)
        {
            listMaterials.Items.Add("Bricks");
            listMaterials.Items.Add("100mm Blocks");
            listMaterials.Items.Add("200mm Blocks");
            listMaterials.Items.Add("Concrete");
            listMaterials.Items.Add("Kerbing");

        }

        private void listMaterials_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (listMaterials.SelectedIndex)
            {
                case 0: lblLenght.Visible = true;
                    txtLenght.Visible = true;
                    lblMtrs1.Visible = true;
                    txtLenght.Clear();

                    lblHeightDepth.Text = "Height";
                    lblHeightDepth.Visible = true;
                    txtHeightDepth.Visible = true;
                    lblMtrs2.Visible = true;
                    txtHeightDepth.Clear();

                    lblWidth.Visible = false;
                    txtWidth.Visible = false;
                    lblMtrs3.Visible = false;
                    txtWidth.Clear();

                    lblArea.Visible = true;
                    txtArea.Visible = true;
                    lblSqCuMtrs.Text = "sq meters";
                    lblSqCuMtrs.Visible = true;
                    txtArea.Clear();

                    txtSubTotal.Clear();
                    txtVat.Clear();
                    txtTotal.Clear();

                    Price = 0.25;
                    prices.Clear();
                    break;

                case 1:
                    lblLenght.Visible = true;
                    txtLenght.Visible = true;
                    lblMtrs1.Visible = true;
                    txtLenght.Clear();

                    lblHeightDepth.Text = "Height";
                    lblHeightDepth.Visible = true;
                    txtHeightDepth.Visible = true;
                    lblMtrs2.Visible = true;
                    txtHeightDepth.Clear();

                    lblWidth.Visible = false;
                    txtWidth.Visible = false;
                    lblMtrs3.Visible = false;
                    txtWidth.Clear();

                    lblArea.Visible = true;
                    txtArea.Visible = true;
                    lblSqCuMtrs.Text = "sq meters";
                    lblSqCuMtrs.Visible = true;

                    txtSubTotal.Clear();
                    txtVat.Clear();
                    txtTotal.Clear();

                    Price = 1.50;

                    prices.Clear();
                    break;

                case 2:
                    lblLenght.Visible = true;
                    txtLenght.Visible = true;
                    lblMtrs1.Visible = true;
                    txtLenght.Clear();

                    lblHeightDepth.Text = "Height";
                    lblHeightDepth.Visible = true;
                    txtHeightDepth.Visible = true;
                    lblMtrs2.Visible = true;
                    txtHeightDepth.Clear();

                    lblWidth.Visible = false;
                    txtWidth.Visible = false;
                    lblMtrs3.Visible = false;
                    txtWidth.Clear();

                    lblArea.Visible = true;
                    txtArea.Visible = true;
                    lblSqCuMtrs.Text = "sq meters";
                    lblSqCuMtrs.Visible = true;
                    txtArea.Clear();

                    txtSubTotal.Clear();
                    txtVat.Clear();
                    txtTotal.Clear();

                    Price = 2.50;

                    prices.Clear();
                    break;
                case 3:
                    lblLenght.Visible = true;
                    txtLenght.Visible = true;
                    lblMtrs1.Visible = true;
                    txtLenght.Clear();

                    lblHeightDepth.Visible = true;
                    lblHeightDepth.Text = "Depth";
                    txtHeightDepth.Visible = true;
                    lblMtrs2.Visible = true;
                    txtHeightDepth.Clear();

                    lblWidth.Visible = true;
                    txtWidth.Visible = true;
                    lblMtrs3.Visible = true;
                    txtWidth.Clear();

                    lblArea.Visible = true;
                    txtArea.Visible = true;
                    lblSqCuMtrs.Text = "cu meters";
                    lblSqCuMtrs.Visible = true;
                    txtArea.Clear();

                    txtSubTotal.Clear();
                    txtVat.Clear();
                    txtTotal.Clear();

                    Price = 25;

                    prices.Clear();
                    break;

                case 4:
                    lblLenght.Visible = true;
                    txtLenght.Visible = true;
                    lblMtrs1.Visible = true;
                    txtLenght.Clear();

                    lblHeightDepth.Visible = false;                    
                    txtHeightDepth.Visible = false;
                    lblMtrs2.Visible = false;
                    txtHeightDepth.Clear();

                    lblWidth.Visible = false;
                    txtWidth.Visible = false;
                    lblMtrs3.Visible = false;
                    txtWidth.Clear();

                    lblArea.Visible = false;
                    txtArea.Visible = false;
                    lblSqCuMtrs.Visible = false;
                    txtArea.Clear();

                    txtSubTotal.Clear();
                    txtVat.Clear();
                    txtTotal.Clear();

                    Price = 5;

                    prices.Clear();
                    break;

            }
                
        }
        public string CalculateAreaBricksBlocks(string Lenght, string Height)
        {
            dbArea = double.Parse(Lenght) * double.Parse(Height);

            return Area = dbArea.ToString();
        }
        public string CalculateAreaConcrete(string Lenght, string Depth, string Width)
        {
            dbArea = double.Parse(Lenght) * double.Parse(Depth) * double.Parse(Width);
            return Area = dbArea.ToString(); 
        }
        public List<string> CalculatePriceBricksBlocksConcrete(string Area, double Price)
        {
            prices.Clear();
            double dbArea = double.Parse(Area);
            double dbSubTotal = Price * dbArea;
            double dbVat = Price * dbArea * 17.5;
            double dbTotal = dbSubTotal + dbVat;

            prices.Add("€" + dbSubTotal.ToString());
            prices.Add("€" + dbVat.ToString());
            prices.Add("€" + dbTotal.ToString());
            return prices;
        }
        public List<string> CalculatePriceKerbing(string Lenght, double Price)
        {
            prices.Clear();
            double dbLenght = double.Parse(Lenght);

            double dbSubTotal = Price * dbLenght;
            double dbVat = Price * dbLenght * 17.5;
            double dbTotal = dbSubTotal + dbVat;

            prices.Add("€" + dbSubTotal.ToString());
            prices.Add("€" + dbVat.ToString());
            prices.Add("€" + dbTotal.ToString());
            return prices;
        }

        private void btnNewEstimate_Click(object sender, EventArgs e)
        {
            prices.Clear();
            txtLenght.Clear();
            txtHeightDepth.Clear();
            txtWidth.Clear();
            txtArea.Clear();
            txtSubTotal.Clear();
            txtVat.Clear();
            txtTotal.Clear();
        }

        private void btnCostExcludingVat_Click(object sender, EventArgs e)
        {
            double result;
            switch (listMaterials.SelectedIndex)
            {

                case 0:

                case 1:

                case 2:
                    
                    if (txtLenght.Text.Length == 0 || txtHeightDepth.Text.Length == 0)
                    {
                        MessageBox.Show("You must enter a value for Lenght or Height", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false || double.TryParse(txtHeightDepth.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght or Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalculateAreaBricksBlocks(txtLenght.Text, txtHeightDepth.Text);
                        CalculatePriceBricksBlocksConcrete(Area, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Clear();
                        txtTotal.Clear();
                    }
                    break;
                case 3:
                    
                    if (txtLenght.Text.Length == 0 || txtHeightDepth.Text.Length == 0 || txtWidth.Text.Length == 0)
                    {
                        MessageBox.Show("You must enter a value for Lenght, Width or Height", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false || double.TryParse(txtHeightDepth.Text, out result) == false || double.TryParse(txtWidth.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght,Width or Height", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalculateAreaConcrete(txtLenght.Text, txtHeightDepth.Text, txtWidth.Text);
                        CalculatePriceBricksBlocksConcrete(Area, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Clear();
                        txtTotal.Clear();
                    }
                    break;
                case 4:
                    if (txtLenght.Text.Length == 0)
                    {
                        MessageBox.Show("You must enter a value for Lenght", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalculatePriceKerbing(txtLenght.Text, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Clear();
                        txtTotal.Clear();
                    }
                    break;
            }
        }

        private void btnTotalIncludingVat_Click(object sender, EventArgs e)
        {
            double result;
            switch (listMaterials.SelectedIndex)
            {
                case 0:
                    
                case 1:
                   
                case 2:
                    if (txtLenght.Text.Length == 0 || txtHeightDepth.Text.Length == 0)
                    {
                        MessageBox.Show("You must enter value for Lenght or Height","Missing information",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false || double.TryParse(txtHeightDepth.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght or Height","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalculateAreaBricksBlocks(txtLenght.Text, txtHeightDepth.Text);
                        CalculatePriceBricksBlocksConcrete(Area, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Text = prices[1];
                        txtTotal.Text = prices[2];
                    }
                    break;
                case 3:
                    if (txtLenght.Text.Length == 0 || txtHeightDepth.Text.Length == 0 || txtWidth.Text.Length==0)
                    {
                        MessageBox.Show("You must enter a value for Lenght, Width or Height","Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false || double.TryParse(txtHeightDepth.Text, out result) == false || double.TryParse(txtWidth.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght,Width or Height","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        CalculateAreaConcrete(txtLenght.Text, txtHeightDepth.Text, txtWidth.Text);
                        CalculatePriceBricksBlocksConcrete(Area, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Text = prices[1];
                        txtTotal.Text = prices[2];
                    }
                    break;
                case 4:
                    if (txtLenght.Text.Length == 0)
                    {
                        MessageBox.Show("You must enter a value for Lenght", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (double.TryParse(txtLenght.Text, out result) == false)
                    {
                        MessageBox.Show("You must enter numeric Value for Lenght", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
                    }
                    else
                    {
                        CalculatePriceKerbing(txtLenght.Text, Price);
                        txtSubTotal.Text = prices[0];
                        txtVat.Text = prices[1];
                        txtTotal.Text = prices[2];
                    }
                    break;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtHeightDepth_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (listMaterials.SelectedIndex == 0 || listMaterials.SelectedIndex == 1 || listMaterials.SelectedIndex == 2)
            {
                if (double.TryParse(txtLenght.Text, out result) == true && double.TryParse(txtHeightDepth.Text, out result) == true)
                {

                    if (txtLenght.Text.Length != 0)
                    {
                        txtArea.Text = CalculateAreaBricksBlocks(txtLenght.Text, txtHeightDepth.Text);
                    }
                }
            }
            if (txtLenght.Text.Length==0 || txtHeightDepth.Text.Length==0)
            {
                txtArea.Clear();
            }
        }

        private void txtWidth_TextChanged(object sender, EventArgs e)
        {
            double result;
            if (double.TryParse(txtLenght.Text, out result) == true && double.TryParse(txtHeightDepth.Text, out result) == true && double.TryParse(txtWidth.Text, out result) == true)
            {
                if (txtLenght.Text.Length != 0 && txtHeightDepth.Text.Length != 0)
                {
                    txtArea.Text = CalculateAreaConcrete(txtLenght.Text, txtHeightDepth.Text, txtWidth.Text);
                }
            }
            if (txtLenght.Text.Length == 0 || txtHeightDepth.Text.Length == 0 || txtWidth.Text.Length==0)
            {
                txtArea.Clear();
            }
        }
    }
}
