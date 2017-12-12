namespace ObjectInteractionSimulator
{
    partial class Simulator
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.control = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.Panel();
            this.gravityLabel = new System.Windows.Forms.Label();
            this.GravityToggle = new System.Windows.Forms.CheckBox();
            this.settings = new System.Windows.Forms.TabControl();
            this.add = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numberToAdd = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bBox = new System.Windows.Forms.TextBox();
            this.gBox = new System.Windows.Forms.TextBox();
            this.rBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.labelMass = new System.Windows.Forms.Label();
            this.labelRadius = new System.Windows.Forms.Label();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.radiusBox = new System.Windows.Forms.TextBox();
            this.addObjectButton = new System.Windows.Forms.Button();
            this.speedBox = new System.Windows.Forms.TextBox();
            this.angleBox = new System.Windows.Forms.TextBox();
            this.centerYBox = new System.Windows.Forms.TextBox();
            this.centerXBox = new System.Windows.Forms.TextBox();
            this.massBox = new System.Windows.Forms.TextBox();
            this.modify = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bBoxMod = new System.Windows.Forms.TextBox();
            this.gBoxMod = new System.Windows.Forms.TextBox();
            this.rBoxMod = new System.Windows.Forms.TextBox();
            this.deleteObjectButton = new System.Windows.Forms.Button();
            this.modifyObjectButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.massMod = new System.Windows.Forms.TextBox();
            this.radiusMod = new System.Windows.Forms.TextBox();
            this.speedMod = new System.Windows.Forms.TextBox();
            this.angleMod = new System.Windows.Forms.TextBox();
            this.centerYMod = new System.Windows.Forms.TextBox();
            this.centerXMod = new System.Windows.Forms.TextBox();
            this.constBox = new System.Windows.Forms.TextBox();
            this.setConst = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.deafultConst = new System.Windows.Forms.Button();
            this.menu.SuspendLayout();
            this.settings.SuspendLayout();
            this.add.SuspendLayout();
            this.modify.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Interval = 15;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // control
            // 
            this.control.BackColor = System.Drawing.Color.Lime;
            this.control.Cursor = System.Windows.Forms.Cursors.Hand;
            this.control.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.control.Location = new System.Drawing.Point(74, 10);
            this.control.Name = "control";
            this.control.Size = new System.Drawing.Size(247, 69);
            this.control.TabIndex = 0;
            this.control.Text = "Start";
            this.control.UseVisualStyleBackColor = false;
            this.control.Click += new System.EventHandler(this.control_Click);
            // 
            // menu
            // 
            this.menu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu.Controls.Add(this.deafultConst);
            this.menu.Controls.Add(this.label14);
            this.menu.Controls.Add(this.setConst);
            this.menu.Controls.Add(this.constBox);
            this.menu.Controls.Add(this.gravityLabel);
            this.menu.Controls.Add(this.GravityToggle);
            this.menu.Controls.Add(this.settings);
            this.menu.Controls.Add(this.control);
            this.menu.Location = new System.Drawing.Point(737, 0);
            this.menu.Margin = new System.Windows.Forms.Padding(0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(390, 805);
            this.menu.TabIndex = 4;
            // 
            // gravityLabel
            // 
            this.gravityLabel.AutoSize = true;
            this.gravityLabel.Location = new System.Drawing.Point(144, 91);
            this.gravityLabel.Name = "gravityLabel";
            this.gravityLabel.Size = new System.Drawing.Size(40, 13);
            this.gravityLabel.TabIndex = 6;
            this.gravityLabel.Text = "Gravity";
            // 
            // GravityToggle
            // 
            this.GravityToggle.Appearance = System.Windows.Forms.Appearance.Button;
            this.GravityToggle.BackColor = System.Drawing.Color.Aqua;
            this.GravityToggle.Checked = true;
            this.GravityToggle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.GravityToggle.Location = new System.Drawing.Point(190, 85);
            this.GravityToggle.Name = "GravityToggle";
            this.GravityToggle.Size = new System.Drawing.Size(50, 25);
            this.GravityToggle.TabIndex = 5;
            this.GravityToggle.Text = "On";
            this.GravityToggle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GravityToggle.UseVisualStyleBackColor = false;
            this.GravityToggle.CheckedChanged += new System.EventHandler(this.GravityToggle_CheckedChanged);
            // 
            // settings
            // 
            this.settings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.settings.Controls.Add(this.add);
            this.settings.Controls.Add(this.modify);
            this.settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settings.HotTrack = true;
            this.settings.ItemSize = new System.Drawing.Size(190, 50);
            this.settings.Location = new System.Drawing.Point(0, 160);
            this.settings.Name = "settings";
            this.settings.SelectedIndex = 0;
            this.settings.Size = new System.Drawing.Size(385, 638);
            this.settings.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.settings.TabIndex = 4;
            // 
            // add
            // 
            this.add.Controls.Add(this.label13);
            this.add.Controls.Add(this.numberToAdd);
            this.add.Controls.Add(this.label9);
            this.add.Controls.Add(this.label8);
            this.add.Controls.Add(this.label7);
            this.add.Controls.Add(this.bBox);
            this.add.Controls.Add(this.gBox);
            this.add.Controls.Add(this.rBox);
            this.add.Controls.Add(this.ClearButton);
            this.add.Controls.Add(this.labelMass);
            this.add.Controls.Add(this.labelRadius);
            this.add.Controls.Add(this.labelSpeed);
            this.add.Controls.Add(this.labelAngle);
            this.add.Controls.Add(this.labelY);
            this.add.Controls.Add(this.labelX);
            this.add.Controls.Add(this.radiusBox);
            this.add.Controls.Add(this.addObjectButton);
            this.add.Controls.Add(this.speedBox);
            this.add.Controls.Add(this.angleBox);
            this.add.Controls.Add(this.centerYBox);
            this.add.Controls.Add(this.centerXBox);
            this.add.Controls.Add(this.massBox);
            this.add.Location = new System.Drawing.Point(4, 54);
            this.add.Name = "add";
            this.add.Padding = new System.Windows.Forms.Padding(3);
            this.add.Size = new System.Drawing.Size(377, 580);
            this.add.TabIndex = 0;
            this.add.Text = "Add Object";
            this.add.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(129, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Number of objects to add:";
            // 
            // numberToAdd
            // 
            this.numberToAdd.Location = new System.Drawing.Point(240, 380);
            this.numberToAdd.MaxLength = 3;
            this.numberToAdd.Name = "numberToAdd";
            this.numberToAdd.Size = new System.Drawing.Size(32, 20);
            this.numberToAdd.TabIndex = 21;
            this.numberToAdd.Text = "1";
            this.numberToAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(246, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "B";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(194, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "G";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 302);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "R";
            // 
            // bBox
            // 
            this.bBox.Location = new System.Drawing.Point(229, 318);
            this.bBox.Name = "bBox";
            this.bBox.Size = new System.Drawing.Size(46, 20);
            this.bBox.TabIndex = 17;
            // 
            // gBox
            // 
            this.gBox.Location = new System.Drawing.Point(177, 318);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(46, 20);
            this.gBox.TabIndex = 16;
            // 
            // rBox
            // 
            this.rBox.Location = new System.Drawing.Point(125, 318);
            this.rBox.Name = "rBox";
            this.rBox.Size = new System.Drawing.Size(46, 20);
            this.rBox.TabIndex = 15;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.LightSalmon;
            this.ClearButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(135, 500);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(134, 48);
            this.ClearButton.TabIndex = 14;
            this.ClearButton.Text = "Clear Objects";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // labelMass
            // 
            this.labelMass.AutoSize = true;
            this.labelMass.Location = new System.Drawing.Point(113, 269);
            this.labelMass.Name = "labelMass";
            this.labelMass.Size = new System.Drawing.Size(32, 13);
            this.labelMass.TabIndex = 12;
            this.labelMass.Text = "Mass";
            this.labelMass.Click += new System.EventHandler(this.labelMass_Click);
            // 
            // labelRadius
            // 
            this.labelRadius.AutoSize = true;
            this.labelRadius.Location = new System.Drawing.Point(105, 229);
            this.labelRadius.Name = "labelRadius";
            this.labelRadius.Size = new System.Drawing.Size(40, 13);
            this.labelRadius.TabIndex = 11;
            this.labelRadius.Text = "Radius";
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(107, 189);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(38, 13);
            this.labelSpeed.TabIndex = 10;
            this.labelSpeed.Text = "Speed";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(111, 149);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(34, 13);
            this.labelAngle.TabIndex = 9;
            this.labelAngle.Text = "Angle";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(77, 109);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(68, 13);
            this.labelY.TabIndex = 8;
            this.labelY.Text = "Y Coordinate";
            this.labelY.Click += new System.EventHandler(this.labelY_Click);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(77, 69);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(68, 13);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X Coordinate";
            // 
            // radiusBox
            // 
            this.radiusBox.Location = new System.Drawing.Point(156, 226);
            this.radiusBox.Name = "radiusBox";
            this.radiusBox.Size = new System.Drawing.Size(100, 20);
            this.radiusBox.TabIndex = 6;
            // 
            // addObjectButton
            // 
            this.addObjectButton.BackColor = System.Drawing.Color.LightBlue;
            this.addObjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addObjectButton.Location = new System.Drawing.Point(135, 420);
            this.addObjectButton.Name = "addObjectButton";
            this.addObjectButton.Size = new System.Drawing.Size(134, 48);
            this.addObjectButton.TabIndex = 5;
            this.addObjectButton.Text = "Add Object";
            this.addObjectButton.UseVisualStyleBackColor = false;
            this.addObjectButton.Click += new System.EventHandler(this.addObjectButton_Click);
            // 
            // speedBox
            // 
            this.speedBox.Location = new System.Drawing.Point(156, 186);
            this.speedBox.Name = "speedBox";
            this.speedBox.Size = new System.Drawing.Size(100, 20);
            this.speedBox.TabIndex = 3;
            // 
            // angleBox
            // 
            this.angleBox.Location = new System.Drawing.Point(156, 146);
            this.angleBox.Name = "angleBox";
            this.angleBox.Size = new System.Drawing.Size(100, 20);
            this.angleBox.TabIndex = 2;
            // 
            // centerYBox
            // 
            this.centerYBox.Location = new System.Drawing.Point(156, 106);
            this.centerYBox.Name = "centerYBox";
            this.centerYBox.Size = new System.Drawing.Size(100, 20);
            this.centerYBox.TabIndex = 1;
            // 
            // centerXBox
            // 
            this.centerXBox.Location = new System.Drawing.Point(156, 66);
            this.centerXBox.Name = "centerXBox";
            this.centerXBox.Size = new System.Drawing.Size(100, 20);
            this.centerXBox.TabIndex = 0;
            this.centerXBox.TextChanged += new System.EventHandler(this.centerXBox_TextChanged);
            // 
            // massBox
            // 
            this.massBox.Location = new System.Drawing.Point(156, 266);
            this.massBox.Name = "massBox";
            this.massBox.Size = new System.Drawing.Size(100, 20);
            this.massBox.TabIndex = 4;
            this.massBox.TextChanged += new System.EventHandler(this.massBox_TextChanged);
            // 
            // modify
            // 
            this.modify.Controls.Add(this.label12);
            this.modify.Controls.Add(this.label11);
            this.modify.Controls.Add(this.label10);
            this.modify.Controls.Add(this.bBoxMod);
            this.modify.Controls.Add(this.gBoxMod);
            this.modify.Controls.Add(this.rBoxMod);
            this.modify.Controls.Add(this.deleteObjectButton);
            this.modify.Controls.Add(this.modifyObjectButton);
            this.modify.Controls.Add(this.label6);
            this.modify.Controls.Add(this.label5);
            this.modify.Controls.Add(this.label4);
            this.modify.Controls.Add(this.label3);
            this.modify.Controls.Add(this.label2);
            this.modify.Controls.Add(this.label1);
            this.modify.Controls.Add(this.massMod);
            this.modify.Controls.Add(this.radiusMod);
            this.modify.Controls.Add(this.speedMod);
            this.modify.Controls.Add(this.angleMod);
            this.modify.Controls.Add(this.centerYMod);
            this.modify.Controls.Add(this.centerXMod);
            this.modify.Location = new System.Drawing.Point(4, 54);
            this.modify.Name = "modify";
            this.modify.Padding = new System.Windows.Forms.Padding(3);
            this.modify.Size = new System.Drawing.Size(377, 614);
            this.modify.TabIndex = 1;
            this.modify.Text = "Modify Object";
            this.modify.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(246, 302);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "B";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(194, 302);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "G";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(140, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "R";
            // 
            // bBoxMod
            // 
            this.bBoxMod.Location = new System.Drawing.Point(229, 318);
            this.bBoxMod.Name = "bBoxMod";
            this.bBoxMod.Size = new System.Drawing.Size(46, 20);
            this.bBoxMod.TabIndex = 18;
            // 
            // gBoxMod
            // 
            this.gBoxMod.Location = new System.Drawing.Point(177, 318);
            this.gBoxMod.Name = "gBoxMod";
            this.gBoxMod.Size = new System.Drawing.Size(46, 20);
            this.gBoxMod.TabIndex = 17;
            // 
            // rBoxMod
            // 
            this.rBoxMod.Location = new System.Drawing.Point(125, 318);
            this.rBoxMod.Name = "rBoxMod";
            this.rBoxMod.Size = new System.Drawing.Size(46, 20);
            this.rBoxMod.TabIndex = 16;
            // 
            // deleteObjectButton
            // 
            this.deleteObjectButton.BackColor = System.Drawing.Color.OrangeRed;
            this.deleteObjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteObjectButton.Location = new System.Drawing.Point(135, 500);
            this.deleteObjectButton.Name = "deleteObjectButton";
            this.deleteObjectButton.Size = new System.Drawing.Size(134, 48);
            this.deleteObjectButton.TabIndex = 15;
            this.deleteObjectButton.Text = "Delete Object";
            this.deleteObjectButton.UseVisualStyleBackColor = false;
            this.deleteObjectButton.Click += new System.EventHandler(this.deleteObjectButton_Click);
            // 
            // modifyObjectButton
            // 
            this.modifyObjectButton.BackColor = System.Drawing.Color.Orange;
            this.modifyObjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.modifyObjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyObjectButton.Location = new System.Drawing.Point(135, 420);
            this.modifyObjectButton.Name = "modifyObjectButton";
            this.modifyObjectButton.Size = new System.Drawing.Size(134, 48);
            this.modifyObjectButton.TabIndex = 14;
            this.modifyObjectButton.Text = "Modify Object";
            this.modifyObjectButton.UseVisualStyleBackColor = false;
            this.modifyObjectButton.Click += new System.EventHandler(this.modifyObjectButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mass";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Radius";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Angle";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Y Coordinate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X Coordinate";
            // 
            // massMod
            // 
            this.massMod.Location = new System.Drawing.Point(156, 266);
            this.massMod.Name = "massMod";
            this.massMod.Size = new System.Drawing.Size(100, 20);
            this.massMod.TabIndex = 6;
            // 
            // radiusMod
            // 
            this.radiusMod.Location = new System.Drawing.Point(156, 226);
            this.radiusMod.Name = "radiusMod";
            this.radiusMod.Size = new System.Drawing.Size(100, 20);
            this.radiusMod.TabIndex = 5;
            // 
            // speedMod
            // 
            this.speedMod.Location = new System.Drawing.Point(156, 186);
            this.speedMod.Name = "speedMod";
            this.speedMod.Size = new System.Drawing.Size(100, 20);
            this.speedMod.TabIndex = 4;
            // 
            // angleMod
            // 
            this.angleMod.Location = new System.Drawing.Point(156, 146);
            this.angleMod.Name = "angleMod";
            this.angleMod.Size = new System.Drawing.Size(100, 20);
            this.angleMod.TabIndex = 3;
            // 
            // centerYMod
            // 
            this.centerYMod.Location = new System.Drawing.Point(156, 106);
            this.centerYMod.Name = "centerYMod";
            this.centerYMod.Size = new System.Drawing.Size(100, 20);
            this.centerYMod.TabIndex = 2;
            // 
            // centerXMod
            // 
            this.centerXMod.Location = new System.Drawing.Point(156, 66);
            this.centerXMod.Name = "centerXMod";
            this.centerXMod.Size = new System.Drawing.Size(100, 20);
            this.centerXMod.TabIndex = 1;
            // 
            // constBox
            // 
            this.constBox.Location = new System.Drawing.Point(147, 127);
            this.constBox.Name = "constBox";
            this.constBox.Size = new System.Drawing.Size(93, 20);
            this.constBox.TabIndex = 7;
            // 
            // setConst
            // 
            this.setConst.Location = new System.Drawing.Point(246, 125);
            this.setConst.Name = "setConst";
            this.setConst.Size = new System.Drawing.Size(40, 23);
            this.setConst.TabIndex = 8;
            this.setConst.Text = "Set";
            this.setConst.UseVisualStyleBackColor = true;
            this.setConst.Click += new System.EventHandler(this.setConst_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(29, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(110, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "Gravitational constant";
            // 
            // deafultConst
            // 
            this.deafultConst.Location = new System.Drawing.Point(292, 125);
            this.deafultConst.Name = "deafultConst";
            this.deafultConst.Size = new System.Drawing.Size(75, 23);
            this.deafultConst.TabIndex = 10;
            this.deafultConst.Text = "Deafault";
            this.deafultConst.UseVisualStyleBackColor = true;
            this.deafultConst.Click += new System.EventHandler(this.deafultConst_Click);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 800);
            this.Controls.Add(this.menu);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Simulator_Click);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.settings.ResumeLayout(false);
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.modify.ResumeLayout(false);
            this.modify.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button control;
        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.TabControl settings;
        private System.Windows.Forms.TabPage add;
        private System.Windows.Forms.TabPage modify;
        private System.Windows.Forms.TextBox centerYBox;
        private System.Windows.Forms.TextBox centerXBox;
        private System.Windows.Forms.Button addObjectButton;
        private System.Windows.Forms.TextBox massBox;
        private System.Windows.Forms.TextBox speedBox;
        private System.Windows.Forms.TextBox angleBox;
        private System.Windows.Forms.TextBox radiusBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label labelMass;
        private System.Windows.Forms.Label labelRadius;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelAngle;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox centerYMod;
        private System.Windows.Forms.TextBox centerXMod;
        private System.Windows.Forms.TextBox massMod;
        private System.Windows.Forms.TextBox radiusMod;
        private System.Windows.Forms.TextBox speedMod;
        private System.Windows.Forms.TextBox angleMod;
        private System.Windows.Forms.Button modifyObjectButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteObjectButton;
        private System.Windows.Forms.TextBox bBox;
        private System.Windows.Forms.TextBox gBox;
        private System.Windows.Forms.TextBox rBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox bBoxMod;
        private System.Windows.Forms.TextBox gBoxMod;
        private System.Windows.Forms.TextBox rBoxMod;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox numberToAdd;
        private System.Windows.Forms.CheckBox GravityToggle;
        private System.Windows.Forms.Label gravityLabel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button setConst;
        private System.Windows.Forms.TextBox constBox;
        private System.Windows.Forms.Button deafultConst;
    }
}

