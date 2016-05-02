namespace CoffeeApplication
{
    partial class AdminPanel
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbCoffeeImages = new System.Windows.Forms.PictureBox();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.txtDelete = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblOrigin = new System.Windows.Forms.Label();
            this.lblQuantityinStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblCoffeeGrind = new System.Windows.Forms.Label();
            this.lblCofeeStrength = new System.Windows.Forms.Label();
            this.lblCoffeeName = new System.Windows.Forms.Label();
            this.lblCoffeeID = new System.Windows.Forms.Label();
            this.txtCoffeeQty = new System.Windows.Forms.TextBox();
            this.txtCoffeeGrind = new System.Windows.Forms.TextBox();
            this.txtCoffeeName = new System.Windows.Forms.TextBox();
            this.txtCoffeePrice = new System.Windows.Forms.TextBox();
            this.txtCoffeeStrength = new System.Windows.Forms.TextBox();
            this.txtCoffeeID = new System.Windows.Forms.TextBox();
            this.txtCoffeeOrigin = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgCoffee = new System.Windows.Forms.DataGridView();
            this.coffeeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeOriginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeStrengthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeGrindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeQtyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coffeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coffeeTimeDataSet = new CoffeeApplication.CoffeeTimeDataSet();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.coffeeTableAdapter = new CoffeeApplication.CoffeeTimeDataSetTableAdapters.CoffeeTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffeeImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoffee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeTimeDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbCoffeeImages);
            this.groupBox1.Controls.Add(this.btnLogOut);
            this.groupBox1.Controls.Add(this.txtDelete);
            this.groupBox1.Controls.Add(this.lblDescription);
            this.groupBox1.Controls.Add(this.lblOrigin);
            this.groupBox1.Controls.Add(this.lblQuantityinStock);
            this.groupBox1.Controls.Add(this.lblPrice);
            this.groupBox1.Controls.Add(this.lblCoffeeGrind);
            this.groupBox1.Controls.Add(this.lblCofeeStrength);
            this.groupBox1.Controls.Add(this.lblCoffeeName);
            this.groupBox1.Controls.Add(this.lblCoffeeID);
            this.groupBox1.Controls.Add(this.txtCoffeeQty);
            this.groupBox1.Controls.Add(this.txtCoffeeGrind);
            this.groupBox1.Controls.Add(this.txtCoffeeName);
            this.groupBox1.Controls.Add(this.txtCoffeePrice);
            this.groupBox1.Controls.Add(this.txtCoffeeStrength);
            this.groupBox1.Controls.Add(this.txtCoffeeID);
            this.groupBox1.Controls.Add(this.txtCoffeeOrigin);
            this.groupBox1.Controls.Add(this.txtDescription);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgCoffee);
            this.groupBox1.Controls.Add(this.txtFilter);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbSelect);
            this.groupBox1.Controls.Add(this.lblSearch);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1267, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // pbCoffeeImages
            // 
            this.pbCoffeeImages.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbCoffeeImages.ImageLocation = "C:\\Users\\A Nazir\\documents\\visual studio 2015\\Projects\\CoffeeApplication\\CoffeeWe" +
    "bsite\\CoffeeTime\\images\\Java.png";
            this.pbCoffeeImages.InitialImage = null;
            this.pbCoffeeImages.Location = new System.Drawing.Point(753, 555);
            this.pbCoffeeImages.Name = "pbCoffeeImages";
            this.pbCoffeeImages.Size = new System.Drawing.Size(174, 150);
            this.pbCoffeeImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCoffeeImages.TabIndex = 55;
            this.pbCoffeeImages.TabStop = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(1030, 622);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(183, 46);
            this.btnLogOut.TabIndex = 54;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // txtDelete
            // 
            this.txtDelete.Location = new System.Drawing.Point(38, 632);
            this.txtDelete.Margin = new System.Windows.Forms.Padding(4);
            this.txtDelete.Name = "txtDelete";
            this.txtDelete.Size = new System.Drawing.Size(147, 27);
            this.txtDelete.TabIndex = 53;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(1047, 342);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(149, 20);
            this.lblDescription.TabIndex = 52;
            this.lblDescription.Text = "Coffee Description";
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(597, 508);
            this.lblOrigin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(89, 20);
            this.lblOrigin.TabIndex = 51;
            this.lblOrigin.Text = "Coffee Qty";
            // 
            // lblQuantityinStock
            // 
            this.lblQuantityinStock.AutoSize = true;
            this.lblQuantityinStock.Location = new System.Drawing.Point(597, 447);
            this.lblQuantityinStock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQuantityinStock.Name = "lblQuantityinStock";
            this.lblQuantityinStock.Size = new System.Drawing.Size(104, 20);
            this.lblQuantityinStock.TabIndex = 50;
            this.lblQuantityinStock.Text = "Coffee Grind";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(597, 382);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(126, 20);
            this.lblPrice.TabIndex = 49;
            this.lblPrice.Text = "Coffee Strength";
            // 
            // lblCoffeeGrind
            // 
            this.lblCoffeeGrind.AutoSize = true;
            this.lblCoffeeGrind.Location = new System.Drawing.Point(242, 562);
            this.lblCoffeeGrind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoffeeGrind.Name = "lblCoffeeGrind";
            this.lblCoffeeGrind.Size = new System.Drawing.Size(108, 20);
            this.lblCoffeeGrind.TabIndex = 48;
            this.lblCoffeeGrind.Text = "Coffee Origin";
            // 
            // lblCofeeStrength
            // 
            this.lblCofeeStrength.AutoSize = true;
            this.lblCofeeStrength.Location = new System.Drawing.Point(242, 496);
            this.lblCofeeStrength.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCofeeStrength.Name = "lblCofeeStrength";
            this.lblCofeeStrength.Size = new System.Drawing.Size(102, 20);
            this.lblCofeeStrength.TabIndex = 47;
            this.lblCofeeStrength.Text = "Coffee Price";
            // 
            // lblCoffeeName
            // 
            this.lblCoffeeName.AutoSize = true;
            this.lblCoffeeName.Location = new System.Drawing.Point(242, 438);
            this.lblCoffeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoffeeName.Name = "lblCoffeeName";
            this.lblCoffeeName.Size = new System.Drawing.Size(107, 20);
            this.lblCoffeeName.TabIndex = 46;
            this.lblCoffeeName.Text = "Coffee Name";
            // 
            // lblCoffeeID
            // 
            this.lblCoffeeID.AutoSize = true;
            this.lblCoffeeID.Location = new System.Drawing.Point(242, 384);
            this.lblCoffeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCoffeeID.Name = "lblCoffeeID";
            this.lblCoffeeID.Size = new System.Drawing.Size(80, 20);
            this.lblCoffeeID.TabIndex = 45;
            this.lblCoffeeID.Text = "Coffee ID";
            // 
            // txtCoffeeQty
            // 
            this.txtCoffeeQty.Location = new System.Drawing.Point(741, 505);
            this.txtCoffeeQty.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeQty.Name = "txtCoffeeQty";
            this.txtCoffeeQty.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeQty.TabIndex = 44;
            // 
            // txtCoffeeGrind
            // 
            this.txtCoffeeGrind.Location = new System.Drawing.Point(741, 442);
            this.txtCoffeeGrind.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeGrind.Name = "txtCoffeeGrind";
            this.txtCoffeeGrind.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeGrind.TabIndex = 43;
            // 
            // txtCoffeeName
            // 
            this.txtCoffeeName.Location = new System.Drawing.Point(371, 438);
            this.txtCoffeeName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeName.Name = "txtCoffeeName";
            this.txtCoffeeName.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeName.TabIndex = 42;
            // 
            // txtCoffeePrice
            // 
            this.txtCoffeePrice.Location = new System.Drawing.Point(371, 496);
            this.txtCoffeePrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeePrice.Name = "txtCoffeePrice";
            this.txtCoffeePrice.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeePrice.TabIndex = 41;
            // 
            // txtCoffeeStrength
            // 
            this.txtCoffeeStrength.Location = new System.Drawing.Point(741, 382);
            this.txtCoffeeStrength.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeStrength.Name = "txtCoffeeStrength";
            this.txtCoffeeStrength.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeStrength.TabIndex = 40;
            // 
            // txtCoffeeID
            // 
            this.txtCoffeeID.Location = new System.Drawing.Point(371, 377);
            this.txtCoffeeID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeID.Name = "txtCoffeeID";
            this.txtCoffeeID.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeID.TabIndex = 39;
            // 
            // txtCoffeeOrigin
            // 
            this.txtCoffeeOrigin.Location = new System.Drawing.Point(371, 562);
            this.txtCoffeeOrigin.Margin = new System.Windows.Forms.Padding(4);
            this.txtCoffeeOrigin.Name = "txtCoffeeOrigin";
            this.txtCoffeeOrigin.Size = new System.Drawing.Size(197, 27);
            this.txtCoffeeOrigin.TabIndex = 38;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(996, 384);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 184);
            this.txtDescription.TabIndex = 37;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 549);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(183, 48);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete Coffee by ID";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(13, 450);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(183, 51);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Update Coffee";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(13, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(183, 46);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Coffee";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgCoffee
            // 
            this.dgCoffee.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Salmon;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = null;
            this.dgCoffee.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgCoffee.AutoGenerateColumns = false;
            this.dgCoffee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCoffee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgCoffee.BackgroundColor = System.Drawing.Color.Tan;
            this.dgCoffee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgCoffee.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCoffee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.coffeeIDDataGridViewTextBoxColumn,
            this.coffeeNameDataGridViewTextBoxColumn,
            this.coffeePriceDataGridViewTextBoxColumn,
            this.coffeeOriginDataGridViewTextBoxColumn,
            this.coffeeStrengthDataGridViewTextBoxColumn,
            this.coffeeGrindDataGridViewTextBoxColumn,
            this.coffeeQtyDataGridViewTextBoxColumn,
            this.coffeeDescriptionDataGridViewTextBoxColumn});
            this.dgCoffee.DataSource = this.coffeeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgCoffee.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgCoffee.GridColor = System.Drawing.Color.SandyBrown;
            this.dgCoffee.Location = new System.Drawing.Point(38, 116);
            this.dgCoffee.Name = "dgCoffee";
            this.dgCoffee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Coral;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgCoffee.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCoffee.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgCoffee.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgCoffee.RowTemplate.Height = 24;
            this.dgCoffee.Size = new System.Drawing.Size(1207, 197);
            this.dgCoffee.TabIndex = 1;
            this.dgCoffee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgCoffee_CellContentClick);
            // 
            // coffeeIDDataGridViewTextBoxColumn
            // 
            this.coffeeIDDataGridViewTextBoxColumn.DataPropertyName = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.HeaderText = "CoffeeID";
            this.coffeeIDDataGridViewTextBoxColumn.Name = "coffeeIDDataGridViewTextBoxColumn";
            // 
            // coffeeNameDataGridViewTextBoxColumn
            // 
            this.coffeeNameDataGridViewTextBoxColumn.DataPropertyName = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.HeaderText = "CoffeeName";
            this.coffeeNameDataGridViewTextBoxColumn.Name = "coffeeNameDataGridViewTextBoxColumn";
            // 
            // coffeePriceDataGridViewTextBoxColumn
            // 
            this.coffeePriceDataGridViewTextBoxColumn.DataPropertyName = "CoffeePrice";
            this.coffeePriceDataGridViewTextBoxColumn.HeaderText = "CoffeePrice";
            this.coffeePriceDataGridViewTextBoxColumn.Name = "coffeePriceDataGridViewTextBoxColumn";
            // 
            // coffeeOriginDataGridViewTextBoxColumn
            // 
            this.coffeeOriginDataGridViewTextBoxColumn.DataPropertyName = "CoffeeOrigin";
            this.coffeeOriginDataGridViewTextBoxColumn.HeaderText = "CoffeeOrigin";
            this.coffeeOriginDataGridViewTextBoxColumn.Name = "coffeeOriginDataGridViewTextBoxColumn";
            // 
            // coffeeStrengthDataGridViewTextBoxColumn
            // 
            this.coffeeStrengthDataGridViewTextBoxColumn.DataPropertyName = "CoffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.HeaderText = "CoffeeStrength";
            this.coffeeStrengthDataGridViewTextBoxColumn.Name = "coffeeStrengthDataGridViewTextBoxColumn";
            // 
            // coffeeGrindDataGridViewTextBoxColumn
            // 
            this.coffeeGrindDataGridViewTextBoxColumn.DataPropertyName = "CoffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.HeaderText = "CoffeeGrind";
            this.coffeeGrindDataGridViewTextBoxColumn.Name = "coffeeGrindDataGridViewTextBoxColumn";
            // 
            // coffeeQtyDataGridViewTextBoxColumn
            // 
            this.coffeeQtyDataGridViewTextBoxColumn.DataPropertyName = "CoffeeQty";
            this.coffeeQtyDataGridViewTextBoxColumn.HeaderText = "CoffeeQty";
            this.coffeeQtyDataGridViewTextBoxColumn.Name = "coffeeQtyDataGridViewTextBoxColumn";
            // 
            // coffeeDescriptionDataGridViewTextBoxColumn
            // 
            this.coffeeDescriptionDataGridViewTextBoxColumn.DataPropertyName = "CoffeeDescription";
            this.coffeeDescriptionDataGridViewTextBoxColumn.HeaderText = "CoffeeDescription";
            this.coffeeDescriptionDataGridViewTextBoxColumn.Name = "coffeeDescriptionDataGridViewTextBoxColumn";
            // 
            // coffeeBindingSource
            // 
            this.coffeeBindingSource.DataMember = "Coffee";
            this.coffeeBindingSource.DataSource = this.coffeeTimeDataSet;
            // 
            // coffeeTimeDataSet
            // 
            this.coffeeTimeDataSet.DataSetName = "CoffeeTimeDataSet";
            this.coffeeTimeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(940, 46);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(230, 27);
            this.txtFilter.TabIndex = 4;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(791, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Search Coffee:";
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Items.AddRange(new object[] {
            "CoffeeGrind",
            "CoffeeOrigin",
            "CoffeeName"});
            this.cmbSelect.Location = new System.Drawing.Point(117, 45);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(202, 28);
            this.cmbSelect.TabIndex = 2;
            this.cmbSelect.SelectedIndexChanged += new System.EventHandler(this.cmbSelect_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(50, 48);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(61, 20);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Select:";
            // 
            // coffeeTableAdapter
            // 
            this.coffeeTableAdapter.ClearBeforeFill = true;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(1291, 735);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Panel";
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCoffeeImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCoffee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeTimeDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgCoffee;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private CoffeeTimeDataSet coffeeTimeDataSet;
        private System.Windows.Forms.BindingSource coffeeBindingSource;
        private CoffeeTimeDataSetTableAdapters.CoffeeTableAdapter coffeeTableAdapter;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.Label lblQuantityinStock;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblCoffeeGrind;
        private System.Windows.Forms.Label lblCofeeStrength;
        private System.Windows.Forms.Label lblCoffeeName;
        private System.Windows.Forms.Label lblCoffeeID;
        private System.Windows.Forms.TextBox txtCoffeeQty;
        private System.Windows.Forms.TextBox txtCoffeeGrind;
        private System.Windows.Forms.TextBox txtCoffeeName;
        private System.Windows.Forms.TextBox txtCoffeePrice;
        private System.Windows.Forms.TextBox txtCoffeeStrength;
        private System.Windows.Forms.TextBox txtCoffeeID;
        private System.Windows.Forms.TextBox txtCoffeeOrigin;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDelete;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeOriginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeStrengthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeGrindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeQtyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coffeeDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pbCoffeeImages;
    }
}