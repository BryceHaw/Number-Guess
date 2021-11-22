namespace GUIPizza
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpBoxCrust = new System.Windows.Forms.GroupBox();
            this.radStuffedCrust = new System.Windows.Forms.RadioButton();
            this.radDeepDish = new System.Windows.Forms.RadioButton();
            this.radTraditional = new System.Windows.Forms.RadioButton();
            this.radThinCrust = new System.Windows.Forms.RadioButton();
            this.grpBoxToppings = new System.Windows.Forms.GroupBox();
            this.chkBellPeppers = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.chkChicken = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkPineapple = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkBlackOlives = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.grpboxDining = new System.Windows.Forms.GroupBox();
            this.radDelivery = new System.Windows.Forms.RadioButton();
            this.radTakeOut = new System.Windows.Forms.RadioButton();
            this.radDineIn = new System.Windows.Forms.RadioButton();
            this.txtOrder = new System.Windows.Forms.TextBox();
            this.mTxtBoxPhoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculator = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.picBoxPizza = new System.Windows.Forms.PictureBox();
            this.picBoxSign = new System.Windows.Forms.PictureBox();
            this.timerBlink1 = new System.Windows.Forms.Timer(this.components);
            this.timerBlink2 = new System.Windows.Forms.Timer(this.components);
            this.grpBoxBeverage = new System.Windows.Forms.GroupBox();
            this.chkCoffee = new System.Windows.Forms.CheckBox();
            this.chkSprite = new System.Windows.Forms.CheckBox();
            this.chkPepsi = new System.Windows.Forms.CheckBox();
            this.chkWater = new System.Windows.Forms.CheckBox();
            this.btnAddTip = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.lblTax = new System.Windows.Forms.Label();
            this.grpBoxCrust.SuspendLayout();
            this.grpBoxToppings.SuspendLayout();
            this.grpboxDining.SuspendLayout();
            this.menuMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPizza)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).BeginInit();
            this.grpBoxBeverage.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxCrust
            // 
            this.grpBoxCrust.Controls.Add(this.radStuffedCrust);
            this.grpBoxCrust.Controls.Add(this.radDeepDish);
            this.grpBoxCrust.Controls.Add(this.radTraditional);
            this.grpBoxCrust.Controls.Add(this.radThinCrust);
            this.grpBoxCrust.Location = new System.Drawing.Point(12, 80);
            this.grpBoxCrust.Name = "grpBoxCrust";
            this.grpBoxCrust.Size = new System.Drawing.Size(253, 276);
            this.grpBoxCrust.TabIndex = 0;
            this.grpBoxCrust.TabStop = false;
            this.grpBoxCrust.Text = "Crust";
            // 
            // radStuffedCrust
            // 
            this.radStuffedCrust.AutoSize = true;
            this.radStuffedCrust.Location = new System.Drawing.Point(21, 137);
            this.radStuffedCrust.Name = "radStuffedCrust";
            this.radStuffedCrust.Size = new System.Drawing.Size(227, 29);
            this.radStuffedCrust.TabIndex = 3;
            this.radStuffedCrust.Text = "Stuffed Crust : $17.99";
            this.radStuffedCrust.UseVisualStyleBackColor = true;
            // 
            // radDeepDish
            // 
            this.radDeepDish.AutoSize = true;
            this.radDeepDish.Location = new System.Drawing.Point(21, 102);
            this.radDeepDish.Name = "radDeepDish";
            this.radDeepDish.Size = new System.Drawing.Size(204, 29);
            this.radDeepDish.TabIndex = 2;
            this.radDeepDish.Text = "Deep Dish : $14.99";
            this.radDeepDish.UseVisualStyleBackColor = true;
            // 
            // radTraditional
            // 
            this.radTraditional.AutoSize = true;
            this.radTraditional.Checked = true;
            this.radTraditional.Location = new System.Drawing.Point(21, 67);
            this.radTraditional.Name = "radTraditional";
            this.radTraditional.Size = new System.Drawing.Size(193, 29);
            this.radTraditional.TabIndex = 1;
            this.radTraditional.TabStop = true;
            this.radTraditional.Text = "Traditional : $9.99";
            this.radTraditional.UseVisualStyleBackColor = true;
            // 
            // radThinCrust
            // 
            this.radThinCrust.AutoSize = true;
            this.radThinCrust.Location = new System.Drawing.Point(21, 32);
            this.radThinCrust.Name = "radThinCrust";
            this.radThinCrust.Size = new System.Drawing.Size(204, 29);
            this.radThinCrust.TabIndex = 0;
            this.radThinCrust.Text = "Thin Crust : $12.99";
            this.radThinCrust.UseVisualStyleBackColor = true;
            // 
            // grpBoxToppings
            // 
            this.grpBoxToppings.Controls.Add(this.chkBellPeppers);
            this.grpBoxToppings.Controls.Add(this.chkOnion);
            this.grpBoxToppings.Controls.Add(this.chkChicken);
            this.grpBoxToppings.Controls.Add(this.chkBacon);
            this.grpBoxToppings.Controls.Add(this.chkPineapple);
            this.grpBoxToppings.Controls.Add(this.chkMushrooms);
            this.grpBoxToppings.Controls.Add(this.chkBlackOlives);
            this.grpBoxToppings.Controls.Add(this.chkSausage);
            this.grpBoxToppings.Controls.Add(this.chkPepperoni);
            this.grpBoxToppings.Controls.Add(this.chkExtraCheese);
            this.grpBoxToppings.Location = new System.Drawing.Point(271, 80);
            this.grpBoxToppings.Name = "grpBoxToppings";
            this.grpBoxToppings.Size = new System.Drawing.Size(458, 276);
            this.grpBoxToppings.TabIndex = 1;
            this.grpBoxToppings.TabStop = false;
            this.grpBoxToppings.Text = "Toppings";
            // 
            // chkBellPeppers
            // 
            this.chkBellPeppers.AutoSize = true;
            this.chkBellPeppers.Location = new System.Drawing.Point(246, 174);
            this.chkBellPeppers.Name = "chkBellPeppers";
            this.chkBellPeppers.Size = new System.Drawing.Size(213, 29);
            this.chkBellPeppers.TabIndex = 9;
            this.chkBellPeppers.Text = "Bell Peppers : $0.50";
            this.chkBellPeppers.UseVisualStyleBackColor = true;
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(246, 139);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(156, 29);
            this.chkOnion.TabIndex = 8;
            this.chkOnion.Text = "Onion : $0.50";
            this.chkOnion.UseVisualStyleBackColor = true;
            // 
            // chkChicken
            // 
            this.chkChicken.AutoSize = true;
            this.chkChicken.Location = new System.Drawing.Point(246, 104);
            this.chkChicken.Name = "chkChicken";
            this.chkChicken.Size = new System.Drawing.Size(175, 29);
            this.chkChicken.TabIndex = 7;
            this.chkChicken.Text = "Chicken : $1.99";
            this.chkChicken.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(246, 69);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(159, 29);
            this.chkBacon.TabIndex = 6;
            this.chkBacon.Text = "Bacon : $1.99";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkPineapple
            // 
            this.chkPineapple.AutoSize = true;
            this.chkPineapple.Location = new System.Drawing.Point(246, 33);
            this.chkPineapple.Name = "chkPineapple";
            this.chkPineapple.Size = new System.Drawing.Size(190, 29);
            this.chkPineapple.TabIndex = 5;
            this.chkPineapple.Text = "Pineapple : $0.50";
            this.chkPineapple.UseVisualStyleBackColor = true;
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(25, 173);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(206, 29);
            this.chkMushrooms.TabIndex = 4;
            this.chkMushrooms.Text = "Mushrooms : $0.50";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            // 
            // chkBlackOlives
            // 
            this.chkBlackOlives.AutoSize = true;
            this.chkBlackOlives.Location = new System.Drawing.Point(25, 138);
            this.chkBlackOlives.Name = "chkBlackOlives";
            this.chkBlackOlives.Size = new System.Drawing.Size(211, 29);
            this.chkBlackOlives.TabIndex = 3;
            this.chkBlackOlives.Text = "Black Olives : $0.50";
            this.chkBlackOlives.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(25, 103);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(182, 29);
            this.chkSausage.TabIndex = 2;
            this.chkSausage.Text = "Sausage : $1.99";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(25, 68);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(192, 29);
            this.chkPepperoni.TabIndex = 1;
            this.chkPepperoni.Text = "Pepperoni : $0.50";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(25, 32);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(222, 29);
            this.chkExtraCheese.TabIndex = 0;
            this.chkExtraCheese.Text = "Extra Cheese : $0.50";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            // 
            // grpboxDining
            // 
            this.grpboxDining.Controls.Add(this.radDelivery);
            this.grpboxDining.Controls.Add(this.radTakeOut);
            this.grpboxDining.Controls.Add(this.radDineIn);
            this.grpboxDining.Location = new System.Drawing.Point(232, 362);
            this.grpboxDining.Name = "grpboxDining";
            this.grpboxDining.Size = new System.Drawing.Size(190, 276);
            this.grpboxDining.TabIndex = 2;
            this.grpboxDining.TabStop = false;
            this.grpboxDining.Text = "Dining";
            // 
            // radDelivery
            // 
            this.radDelivery.AutoSize = true;
            this.radDelivery.Location = new System.Drawing.Point(7, 103);
            this.radDelivery.Name = "radDelivery";
            this.radDelivery.Size = new System.Drawing.Size(172, 29);
            this.radDelivery.TabIndex = 2;
            this.radDelivery.Text = "Delivery : $3.99";
            this.radDelivery.UseVisualStyleBackColor = true;
            this.radDelivery.CheckedChanged += new System.EventHandler(this.radDelivery_CheckedChanged);
            // 
            // radTakeOut
            // 
            this.radTakeOut.AutoSize = true;
            this.radTakeOut.Location = new System.Drawing.Point(7, 68);
            this.radTakeOut.Name = "radTakeOut";
            this.radTakeOut.Size = new System.Drawing.Size(175, 29);
            this.radTakeOut.TabIndex = 1;
            this.radTakeOut.Text = "Take Out : Free";
            this.radTakeOut.UseVisualStyleBackColor = true;
            // 
            // radDineIn
            // 
            this.radDineIn.AutoSize = true;
            this.radDineIn.Checked = true;
            this.radDineIn.Location = new System.Drawing.Point(7, 32);
            this.radDineIn.Name = "radDineIn";
            this.radDineIn.Size = new System.Drawing.Size(154, 29);
            this.radDineIn.TabIndex = 0;
            this.radDineIn.TabStop = true;
            this.radDineIn.Text = "Dine In : Free";
            this.radDineIn.UseVisualStyleBackColor = true;
            // 
            // txtOrder
            // 
            this.txtOrder.Location = new System.Drawing.Point(12, 644);
            this.txtOrder.Multiline = true;
            this.txtOrder.Name = "txtOrder";
            this.txtOrder.ReadOnly = true;
            this.txtOrder.Size = new System.Drawing.Size(557, 58);
            this.txtOrder.TabIndex = 3;
            // 
            // mTxtBoxPhoneNumber
            // 
            this.mTxtBoxPhoneNumber.Location = new System.Drawing.Point(12, 720);
            this.mTxtBoxPhoneNumber.Mask = "(999) 000-0000";
            this.mTxtBoxPhoneNumber.Name = "mTxtBoxPhoneNumber";
            this.mTxtBoxPhoneNumber.Size = new System.Drawing.Size(149, 29);
            this.mTxtBoxPhoneNumber.TabIndex = 4;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(12, 764);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(149, 64);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // menuMain
            // 
            this.menuMain.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuFile,
            this.menuCalculator,
            this.menuHelp});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(751, 38);
            this.menuMain.TabIndex = 6;
            this.menuMain.Text = "menuStrip1";
            // 
            // menuFile
            // 
            this.menuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExit});
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(62, 34);
            this.menuFile.Text = "&File";
            // 
            // menuExit
            // 
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(164, 40);
            this.menuExit.Text = "E&xit";
            this.menuExit.Click += new System.EventHandler(this.menuExit_Click);
            // 
            // menuCalculator
            // 
            this.menuCalculator.Name = "menuCalculator";
            this.menuCalculator.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.menuCalculator.Size = new System.Drawing.Size(124, 34);
            this.menuCalculator.Text = "&Calculator";
            this.menuCalculator.Click += new System.EventHandler(this.menuCalculator_Click);
            // 
            // menuHelp
            // 
            this.menuHelp.Name = "menuHelp";
            this.menuHelp.Size = new System.Drawing.Size(74, 34);
            this.menuHelp.Text = "&Help";
            this.menuHelp.Click += new System.EventHandler(this.menuHelp_Click);
            // 
            // picBoxPizza
            // 
            this.picBoxPizza.Image = ((System.Drawing.Image)(resources.GetObject("picBoxPizza.Image")));
            this.picBoxPizza.Location = new System.Drawing.Point(452, 381);
            this.picBoxPizza.Name = "picBoxPizza";
            this.picBoxPizza.Size = new System.Drawing.Size(146, 99);
            this.picBoxPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPizza.TabIndex = 7;
            this.picBoxPizza.TabStop = false;
            // 
            // picBoxSign
            // 
            this.picBoxSign.Image = ((System.Drawing.Image)(resources.GetObject("picBoxSign.Image")));
            this.picBoxSign.Location = new System.Drawing.Point(452, 486);
            this.picBoxSign.Name = "picBoxSign";
            this.picBoxSign.Size = new System.Drawing.Size(151, 99);
            this.picBoxSign.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxSign.TabIndex = 8;
            this.picBoxSign.TabStop = false;
            // 
            // timerBlink1
            // 
            this.timerBlink1.Enabled = true;
            this.timerBlink1.Interval = 1500;
            this.timerBlink1.Tick += new System.EventHandler(this.timerBlink1_Tick);
            // 
            // timerBlink2
            // 
            this.timerBlink2.Interval = 750;
            this.timerBlink2.Tick += new System.EventHandler(this.timerBlink2_Tick);
            // 
            // grpBoxBeverage
            // 
            this.grpBoxBeverage.Controls.Add(this.chkCoffee);
            this.grpBoxBeverage.Controls.Add(this.chkSprite);
            this.grpBoxBeverage.Controls.Add(this.chkPepsi);
            this.grpBoxBeverage.Controls.Add(this.chkWater);
            this.grpBoxBeverage.Location = new System.Drawing.Point(12, 362);
            this.grpBoxBeverage.Name = "grpBoxBeverage";
            this.grpBoxBeverage.Size = new System.Drawing.Size(214, 276);
            this.grpBoxBeverage.TabIndex = 9;
            this.grpBoxBeverage.TabStop = false;
            this.grpBoxBeverage.Text = "Beverage";
            // 
            // chkCoffee
            // 
            this.chkCoffee.AutoSize = true;
            this.chkCoffee.Location = new System.Drawing.Point(17, 159);
            this.chkCoffee.Name = "chkCoffee";
            this.chkCoffee.Size = new System.Drawing.Size(161, 29);
            this.chkCoffee.TabIndex = 8;
            this.chkCoffee.Text = "Coffee : $2.99";
            this.chkCoffee.UseVisualStyleBackColor = true;
            // 
            // chkSprite
            // 
            this.chkSprite.AutoSize = true;
            this.chkSprite.Location = new System.Drawing.Point(17, 124);
            this.chkSprite.Name = "chkSprite";
            this.chkSprite.Size = new System.Drawing.Size(154, 29);
            this.chkSprite.TabIndex = 7;
            this.chkSprite.Text = "Sprite : $1.99";
            this.chkSprite.UseVisualStyleBackColor = true;
            // 
            // chkPepsi
            // 
            this.chkPepsi.AutoSize = true;
            this.chkPepsi.Location = new System.Drawing.Point(17, 89);
            this.chkPepsi.Name = "chkPepsi";
            this.chkPepsi.Size = new System.Drawing.Size(152, 29);
            this.chkPepsi.TabIndex = 6;
            this.chkPepsi.Text = "Pepsi : $1.99";
            this.chkPepsi.UseVisualStyleBackColor = true;
            // 
            // chkWater
            // 
            this.chkWater.AutoSize = true;
            this.chkWater.Location = new System.Drawing.Point(17, 53);
            this.chkWater.Name = "chkWater";
            this.chkWater.Size = new System.Drawing.Size(147, 29);
            this.chkWater.TabIndex = 5;
            this.chkWater.Text = "Water : Free";
            this.chkWater.UseVisualStyleBackColor = true;
            // 
            // btnAddTip
            // 
            this.btnAddTip.Location = new System.Drawing.Point(427, 764);
            this.btnAddTip.Name = "btnAddTip";
            this.btnAddTip.Size = new System.Drawing.Size(149, 64);
            this.btnAddTip.TabIndex = 10;
            this.btnAddTip.Text = "Add Tip";
            this.btnAddTip.UseVisualStyleBackColor = true;
            this.btnAddTip.Click += new System.EventHandler(this.btnAddTip_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(299, 800);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(93, 29);
            this.txtTotal.TabIndex = 14;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(299, 724);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(93, 29);
            this.txtSubtotal.TabIndex = 13;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(203, 803);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 25);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(203, 724);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(90, 25);
            this.lblSubtotal.TabIndex = 11;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(299, 764);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(93, 29);
            this.txtTax.TabIndex = 16;
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(203, 764);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(52, 25);
            this.lblTax.TabIndex = 15;
            this.lblTax.Text = "Tax:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(751, 840);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.btnAddTip);
            this.Controls.Add(this.grpBoxBeverage);
            this.Controls.Add(this.picBoxSign);
            this.Controls.Add(this.picBoxPizza);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.mTxtBoxPhoneNumber);
            this.Controls.Add(this.txtOrder);
            this.Controls.Add(this.grpboxDining);
            this.Controls.Add(this.grpBoxToppings);
            this.Controls.Add(this.grpBoxCrust);
            this.Controls.Add(this.menuMain);
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Tony\'s Pizza";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpBoxCrust.ResumeLayout(false);
            this.grpBoxCrust.PerformLayout();
            this.grpBoxToppings.ResumeLayout(false);
            this.grpBoxToppings.PerformLayout();
            this.grpboxDining.ResumeLayout(false);
            this.grpboxDining.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPizza)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxSign)).EndInit();
            this.grpBoxBeverage.ResumeLayout(false);
            this.grpBoxBeverage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxCrust;
        private System.Windows.Forms.RadioButton radStuffedCrust;
        private System.Windows.Forms.RadioButton radDeepDish;
        private System.Windows.Forms.RadioButton radTraditional;
        private System.Windows.Forms.RadioButton radThinCrust;
        private System.Windows.Forms.GroupBox grpBoxToppings;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkBlackOlives;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.GroupBox grpboxDining;
        private System.Windows.Forms.RadioButton radDelivery;
        private System.Windows.Forms.RadioButton radTakeOut;
        private System.Windows.Forms.RadioButton radDineIn;
        private System.Windows.Forms.TextBox txtOrder;
        private System.Windows.Forms.MaskedTextBox mTxtBoxPhoneNumber;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem menuFile;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuCalculator;
        private System.Windows.Forms.ToolStripMenuItem menuHelp;
        private System.Windows.Forms.PictureBox picBoxPizza;
        private System.Windows.Forms.PictureBox picBoxSign;
        private System.Windows.Forms.Timer timerBlink1;
        private System.Windows.Forms.Timer timerBlink2;
        private System.Windows.Forms.CheckBox chkBellPeppers;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.CheckBox chkChicken;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkPineapple;
        private System.Windows.Forms.GroupBox grpBoxBeverage;
        private System.Windows.Forms.CheckBox chkCoffee;
        private System.Windows.Forms.CheckBox chkSprite;
        private System.Windows.Forms.CheckBox chkPepsi;
        private System.Windows.Forms.CheckBox chkWater;
        private System.Windows.Forms.Button btnAddTip;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.Label lblTax;
    }
}

