namespace robetsBuildersMock
{
    partial class RobertsBuilders
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
            this.lblRobertsBuilders = new System.Windows.Forms.Label();
            this.lblFirstSelect = new System.Windows.Forms.Label();
            this.listMaterials = new System.Windows.Forms.ListBox();
            this.picBuilder = new System.Windows.Forms.PictureBox();
            this.lblEnterDimentions = new System.Windows.Forms.Label();
            this.lblLenght = new System.Windows.Forms.Label();
            this.lblHeightDepth = new System.Windows.Forms.Label();
            this.txtHeightDepth = new System.Windows.Forms.TextBox();
            this.txtLenght = new System.Windows.Forms.TextBox();
            this.txtWidth = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtSubTotal = new System.Windows.Forms.TextBox();
            this.txtVat = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblMtrs1 = new System.Windows.Forms.Label();
            this.lblMtrs2 = new System.Windows.Forms.Label();
            this.lblMtrs3 = new System.Windows.Forms.Label();
            this.lblSqCuMtrs = new System.Windows.Forms.Label();
            this.lblSubTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnNewEstimate = new System.Windows.Forms.Button();
            this.btnCostExcludingVat = new System.Windows.Forms.Button();
            this.btnTotalIncludingVat = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRobertsBuilders
            // 
            this.lblRobertsBuilders.AutoSize = true;
            this.lblRobertsBuilders.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRobertsBuilders.ForeColor = System.Drawing.Color.Green;
            this.lblRobertsBuilders.Location = new System.Drawing.Point(23, 27);
            this.lblRobertsBuilders.Name = "lblRobertsBuilders";
            this.lblRobertsBuilders.Size = new System.Drawing.Size(256, 36);
            this.lblRobertsBuilders.TabIndex = 0;
            this.lblRobertsBuilders.Text = "Robert\'s Builders";
            // 
            // lblFirstSelect
            // 
            this.lblFirstSelect.AutoSize = true;
            this.lblFirstSelect.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstSelect.ForeColor = System.Drawing.Color.Red;
            this.lblFirstSelect.Location = new System.Drawing.Point(27, 104);
            this.lblFirstSelect.Name = "lblFirstSelect";
            this.lblFirstSelect.Size = new System.Drawing.Size(194, 23);
            this.lblFirstSelect.TabIndex = 1;
            this.lblFirstSelect.Text = "First select a material!";
            // 
            // listMaterials
            // 
            this.listMaterials.FormattingEnabled = true;
            this.listMaterials.Location = new System.Drawing.Point(31, 131);
            this.listMaterials.Name = "listMaterials";
            this.listMaterials.Size = new System.Drawing.Size(109, 82);
            this.listMaterials.TabIndex = 2;
            this.listMaterials.SelectedIndexChanged += new System.EventHandler(this.listMaterials_SelectedIndexChanged);
            // 
            // picBuilder
            // 
            this.picBuilder.Image = global::robetsBuildersMock.Properties.Resources.builder;
            this.picBuilder.Location = new System.Drawing.Point(474, 103);
            this.picBuilder.Name = "picBuilder";
            this.picBuilder.Size = new System.Drawing.Size(257, 215);
            this.picBuilder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuilder.TabIndex = 3;
            this.picBuilder.TabStop = false;
            // 
            // lblEnterDimentions
            // 
            this.lblEnterDimentions.AutoSize = true;
            this.lblEnterDimentions.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterDimentions.ForeColor = System.Drawing.Color.Navy;
            this.lblEnterDimentions.Location = new System.Drawing.Point(230, 79);
            this.lblEnterDimentions.Name = "lblEnterDimentions";
            this.lblEnterDimentions.Size = new System.Drawing.Size(238, 23);
            this.lblEnterDimentions.TabIndex = 4;
            this.lblEnterDimentions.Text = "Enter the dimentions below";
            // 
            // lblLenght
            // 
            this.lblLenght.AutoSize = true;
            this.lblLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLenght.Location = new System.Drawing.Point(230, 105);
            this.lblLenght.Name = "lblLenght";
            this.lblLenght.Size = new System.Drawing.Size(52, 18);
            this.lblLenght.TabIndex = 5;
            this.lblLenght.Text = "Lenght";
            this.lblLenght.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLenght.Visible = false;
            // 
            // lblHeightDepth
            // 
            this.lblHeightDepth.AutoSize = true;
            this.lblHeightDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeightDepth.Location = new System.Drawing.Point(230, 131);
            this.lblHeightDepth.Name = "lblHeightDepth";
            this.lblHeightDepth.Size = new System.Drawing.Size(50, 18);
            this.lblHeightDepth.TabIndex = 6;
            this.lblHeightDepth.Text = "Height";
            this.lblHeightDepth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblHeightDepth.Visible = false;
            // 
            // txtHeightDepth
            // 
            this.txtHeightDepth.Location = new System.Drawing.Point(292, 129);
            this.txtHeightDepth.Name = "txtHeightDepth";
            this.txtHeightDepth.Size = new System.Drawing.Size(100, 20);
            this.txtHeightDepth.TabIndex = 8;
            this.txtHeightDepth.Visible = false;
            this.txtHeightDepth.TextChanged += new System.EventHandler(this.txtHeightDepth_TextChanged);
            // 
            // txtLenght
            // 
            this.txtLenght.Location = new System.Drawing.Point(292, 103);
            this.txtLenght.Name = "txtLenght";
            this.txtLenght.Size = new System.Drawing.Size(100, 20);
            this.txtLenght.TabIndex = 9;
            this.txtLenght.Visible = false;
            // 
            // txtWidth
            // 
            this.txtWidth.Location = new System.Drawing.Point(292, 155);
            this.txtWidth.Name = "txtWidth";
            this.txtWidth.Size = new System.Drawing.Size(100, 20);
            this.txtWidth.TabIndex = 10;
            this.txtWidth.Visible = false;
            this.txtWidth.TextChanged += new System.EventHandler(this.txtWidth_TextChanged);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(292, 181);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 20);
            this.txtArea.TabIndex = 11;
            this.txtArea.Visible = false;
            // 
            // txtSubTotal
            // 
            this.txtSubTotal.Enabled = false;
            this.txtSubTotal.Location = new System.Drawing.Point(292, 229);
            this.txtSubTotal.Name = "txtSubTotal";
            this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubTotal.TabIndex = 12;
            // 
            // txtVat
            // 
            this.txtVat.Enabled = false;
            this.txtVat.Location = new System.Drawing.Point(292, 255);
            this.txtVat.Name = "txtVat";
            this.txtVat.Size = new System.Drawing.Size(100, 20);
            this.txtVat.TabIndex = 13;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(292, 281);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWidth.Location = new System.Drawing.Point(230, 157);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(46, 18);
            this.lblWidth.TabIndex = 15;
            this.lblWidth.Text = "Width";
            this.lblWidth.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblWidth.Visible = false;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArea.Location = new System.Drawing.Point(230, 183);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 18);
            this.lblArea.TabIndex = 16;
            this.lblArea.Text = "Area";
            this.lblArea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblArea.Visible = false;
            // 
            // lblMtrs1
            // 
            this.lblMtrs1.AutoSize = true;
            this.lblMtrs1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtrs1.Location = new System.Drawing.Point(401, 107);
            this.lblMtrs1.Name = "lblMtrs1";
            this.lblMtrs1.Size = new System.Drawing.Size(38, 18);
            this.lblMtrs1.TabIndex = 17;
            this.lblMtrs1.Text = "mtrs";
            this.lblMtrs1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMtrs1.Visible = false;
            // 
            // lblMtrs2
            // 
            this.lblMtrs2.AutoSize = true;
            this.lblMtrs2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtrs2.Location = new System.Drawing.Point(401, 130);
            this.lblMtrs2.Name = "lblMtrs2";
            this.lblMtrs2.Size = new System.Drawing.Size(38, 18);
            this.lblMtrs2.TabIndex = 18;
            this.lblMtrs2.Text = "mtrs";
            this.lblMtrs2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMtrs2.Visible = false;
            // 
            // lblMtrs3
            // 
            this.lblMtrs3.AutoSize = true;
            this.lblMtrs3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMtrs3.Location = new System.Drawing.Point(401, 159);
            this.lblMtrs3.Name = "lblMtrs3";
            this.lblMtrs3.Size = new System.Drawing.Size(38, 18);
            this.lblMtrs3.TabIndex = 19;
            this.lblMtrs3.Text = "mtrs";
            this.lblMtrs3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblMtrs3.Visible = false;
            // 
            // lblSqCuMtrs
            // 
            this.lblSqCuMtrs.AutoSize = true;
            this.lblSqCuMtrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSqCuMtrs.Location = new System.Drawing.Point(401, 185);
            this.lblSqCuMtrs.Name = "lblSqCuMtrs";
            this.lblSqCuMtrs.Size = new System.Drawing.Size(58, 18);
            this.lblSqCuMtrs.TabIndex = 20;
            this.lblSqCuMtrs.Text = "sq mtrs";
            this.lblSqCuMtrs.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSqCuMtrs.Visible = false;
            // 
            // lblSubTotal
            // 
            this.lblSubTotal.AutoSize = true;
            this.lblSubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubTotal.Location = new System.Drawing.Point(217, 231);
            this.lblSubTotal.Name = "lblSubTotal";
            this.lblSubTotal.Size = new System.Drawing.Size(71, 18);
            this.lblSubTotal.TabIndex = 21;
            this.lblSubTotal.Text = "Sub Total";
            this.lblSubTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.Location = new System.Drawing.Point(239, 257);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(39, 18);
            this.lblVat.TabIndex = 22;
            this.lblVat.Text = "VAT:";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(236, 283);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 18);
            this.lblTotal.TabIndex = 23;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnNewEstimate
            // 
            this.btnNewEstimate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewEstimate.Location = new System.Drawing.Point(31, 330);
            this.btnNewEstimate.Name = "btnNewEstimate";
            this.btnNewEstimate.Size = new System.Drawing.Size(114, 43);
            this.btnNewEstimate.TabIndex = 24;
            this.btnNewEstimate.Text = "NEW ESTIMATE";
            this.btnNewEstimate.UseVisualStyleBackColor = true;
            this.btnNewEstimate.Click += new System.EventHandler(this.btnNewEstimate_Click);
            // 
            // btnCostExcludingVat
            // 
            this.btnCostExcludingVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCostExcludingVat.Location = new System.Drawing.Point(220, 330);
            this.btnCostExcludingVat.Name = "btnCostExcludingVat";
            this.btnCostExcludingVat.Size = new System.Drawing.Size(114, 43);
            this.btnCostExcludingVat.TabIndex = 25;
            this.btnCostExcludingVat.Text = "COST Excluding Vat";
            this.btnCostExcludingVat.UseVisualStyleBackColor = true;
            this.btnCostExcludingVat.Click += new System.EventHandler(this.btnCostExcludingVat_Click);
            // 
            // btnTotalIncludingVat
            // 
            this.btnTotalIncludingVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalIncludingVat.Location = new System.Drawing.Point(415, 330);
            this.btnTotalIncludingVat.Name = "btnTotalIncludingVat";
            this.btnTotalIncludingVat.Size = new System.Drawing.Size(114, 43);
            this.btnTotalIncludingVat.TabIndex = 26;
            this.btnTotalIncludingVat.Text = "TOTAL Including Vat";
            this.btnTotalIncludingVat.UseVisualStyleBackColor = true;
            this.btnTotalIncludingVat.Click += new System.EventHandler(this.btnTotalIncludingVat_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(617, 330);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(114, 43);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // RobertsBuilders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 434);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotalIncludingVat);
            this.Controls.Add(this.btnCostExcludingVat);
            this.Controls.Add(this.btnNewEstimate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblSubTotal);
            this.Controls.Add(this.lblSqCuMtrs);
            this.Controls.Add(this.lblMtrs3);
            this.Controls.Add(this.lblMtrs2);
            this.Controls.Add(this.lblMtrs1);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtVat);
            this.Controls.Add(this.txtSubTotal);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtWidth);
            this.Controls.Add(this.txtLenght);
            this.Controls.Add(this.txtHeightDepth);
            this.Controls.Add(this.lblHeightDepth);
            this.Controls.Add(this.lblLenght);
            this.Controls.Add(this.lblEnterDimentions);
            this.Controls.Add(this.picBuilder);
            this.Controls.Add(this.listMaterials);
            this.Controls.Add(this.lblFirstSelect);
            this.Controls.Add(this.lblRobertsBuilders);
            this.Name = "RobertsBuilders";
            this.Text = "Robert\'s Builders";
            this.Load += new System.EventHandler(this.RobertsBuilders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBuilder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRobertsBuilders;
        private System.Windows.Forms.Label lblFirstSelect;
        private System.Windows.Forms.ListBox listMaterials;
        private System.Windows.Forms.PictureBox picBuilder;
        private System.Windows.Forms.Label lblEnterDimentions;
        private System.Windows.Forms.Label lblLenght;
        private System.Windows.Forms.Label lblHeightDepth;
        private System.Windows.Forms.TextBox txtHeightDepth;
        private System.Windows.Forms.TextBox txtLenght;
        private System.Windows.Forms.TextBox txtWidth;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtSubTotal;
        private System.Windows.Forms.TextBox txtVat;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblMtrs1;
        private System.Windows.Forms.Label lblMtrs2;
        private System.Windows.Forms.Label lblMtrs3;
        private System.Windows.Forms.Label lblSqCuMtrs;
        private System.Windows.Forms.Label lblSubTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnNewEstimate;
        private System.Windows.Forms.Button btnCostExcludingVat;
        private System.Windows.Forms.Button btnTotalIncludingVat;
        private System.Windows.Forms.Button btnExit;
    }
}

