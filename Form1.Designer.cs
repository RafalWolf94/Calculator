namespace WsgCalc
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.zeroButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.soundButton = new System.Windows.Forms.Button();
            this.sqrtButton = new System.Windows.Forms.Button();
            this.factorialButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.clearLastElement = new System.Windows.Forms.Button();
            this.changeSymbolbutton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.powerButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.multipleButton = new System.Windows.Forms.Button();
            this.clearTextBoxButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultTextBox.Enabled = false;
            this.resultTextBox.Font = new System.Drawing.Font("Verdana", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultTextBox.Location = new System.Drawing.Point(0, 0);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resultTextBox.Size = new System.Drawing.Size(361, 50);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resultTextBox.WordWrap = false;
            // 
            // zeroButton
            // 
            this.zeroButton.BackColor = System.Drawing.Color.Chocolate;
            this.zeroButton.FlatAppearance.BorderSize = 0;
            this.zeroButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zeroButton.Location = new System.Drawing.Point(120, 180);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(60, 60);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = false;
            this.zeroButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.NavajoWhite;
            this.panel1.Controls.Add(this.soundButton);
            this.panel1.Controls.Add(this.sqrtButton);
            this.panel1.Controls.Add(this.factorialButton);
            this.panel1.Controls.Add(this.dotButton);
            this.panel1.Controls.Add(this.clearLastElement);
            this.panel1.Controls.Add(this.changeSymbolbutton);
            this.panel1.Controls.Add(this.sumButton);
            this.panel1.Controls.Add(this.powerButton);
            this.panel1.Controls.Add(this.divideButton);
            this.panel1.Controls.Add(this.plusButton);
            this.panel1.Controls.Add(this.minusButton);
            this.panel1.Controls.Add(this.multipleButton);
            this.panel1.Controls.Add(this.clearTextBoxButton);
            this.panel1.Controls.Add(this.nineButton);
            this.panel1.Controls.Add(this.eightButton);
            this.panel1.Controls.Add(this.sevenButton);
            this.panel1.Controls.Add(this.sixButton);
            this.panel1.Controls.Add(this.fiveButton);
            this.panel1.Controls.Add(this.fourButton);
            this.panel1.Controls.Add(this.threeButton);
            this.panel1.Controls.Add(this.twoButton);
            this.panel1.Controls.Add(this.oneButton);
            this.panel1.Controls.Add(this.zeroButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(361, 241);
            this.panel1.TabIndex = 2;
            // 
            // soundButton
            // 
            this.soundButton.BackColor = System.Drawing.Color.Chocolate;
            this.soundButton.BackgroundImage = global::WsgCalc.Properties.Resources.musicOFF;
            this.soundButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.soundButton.FlatAppearance.BorderSize = 0;
            this.soundButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.soundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundButton.Font = new System.Drawing.Font("Solid Edge ISO", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soundButton.Location = new System.Drawing.Point(0, 180);
            this.soundButton.Name = "soundButton";
            this.soundButton.Size = new System.Drawing.Size(60, 60);
            this.soundButton.TabIndex = 23;
            this.soundButton.UseVisualStyleBackColor = false;
            this.soundButton.Click += new System.EventHandler(this.soundButton_Click);
            // 
            // sqrtButton
            // 
            this.sqrtButton.BackColor = System.Drawing.Color.Chocolate;
            this.sqrtButton.FlatAppearance.BorderSize = 0;
            this.sqrtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sqrtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrtButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sqrtButton.Location = new System.Drawing.Point(300, 60);
            this.sqrtButton.Name = "sqrtButton";
            this.sqrtButton.Size = new System.Drawing.Size(60, 60);
            this.sqrtButton.TabIndex = 22;
            this.sqrtButton.Text = "√";
            this.sqrtButton.UseVisualStyleBackColor = false;
            this.sqrtButton.Click += new System.EventHandler(this.sqrtButton_Click);
            // 
            // factorialButton
            // 
            this.factorialButton.BackColor = System.Drawing.Color.Chocolate;
            this.factorialButton.FlatAppearance.BorderSize = 0;
            this.factorialButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.factorialButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.factorialButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.factorialButton.Location = new System.Drawing.Point(0, 120);
            this.factorialButton.Name = "factorialButton";
            this.factorialButton.Size = new System.Drawing.Size(60, 60);
            this.factorialButton.TabIndex = 21;
            this.factorialButton.Text = "n!";
            this.factorialButton.UseVisualStyleBackColor = false;
            this.factorialButton.Click += new System.EventHandler(this.factorialButton_Click);
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.Color.Chocolate;
            this.dotButton.FlatAppearance.BorderSize = 0;
            this.dotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dotButton.Location = new System.Drawing.Point(180, 180);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(60, 60);
            this.dotButton.TabIndex = 20;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            this.dotButton.Click += new System.EventHandler(this.dotButton_Click);
            // 
            // clearLastElement
            // 
            this.clearLastElement.BackColor = System.Drawing.Color.Chocolate;
            this.clearLastElement.FlatAppearance.BorderSize = 0;
            this.clearLastElement.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearLastElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearLastElement.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearLastElement.Location = new System.Drawing.Point(0, 0);
            this.clearLastElement.Name = "clearLastElement";
            this.clearLastElement.Size = new System.Drawing.Size(60, 60);
            this.clearLastElement.TabIndex = 19;
            this.clearLastElement.Text = "CE";
            this.clearLastElement.UseVisualStyleBackColor = false;
            this.clearLastElement.Click += new System.EventHandler(this.clearLastElement_Click);
            // 
            // changeSymbolbutton
            // 
            this.changeSymbolbutton.BackColor = System.Drawing.Color.Chocolate;
            this.changeSymbolbutton.FlatAppearance.BorderSize = 0;
            this.changeSymbolbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.changeSymbolbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeSymbolbutton.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.changeSymbolbutton.Location = new System.Drawing.Point(60, 180);
            this.changeSymbolbutton.Name = "changeSymbolbutton";
            this.changeSymbolbutton.Size = new System.Drawing.Size(60, 60);
            this.changeSymbolbutton.TabIndex = 18;
            this.changeSymbolbutton.Text = "+/-";
            this.changeSymbolbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeSymbolbutton.UseVisualStyleBackColor = false;
            this.changeSymbolbutton.Click += new System.EventHandler(this.changeSymbolbutton_Click);
            // 
            // sumButton
            // 
            this.sumButton.BackColor = System.Drawing.Color.Chocolate;
            this.sumButton.FlatAppearance.BorderSize = 0;
            this.sumButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sumButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sumButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sumButton.Location = new System.Drawing.Point(300, 120);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(60, 120);
            this.sumButton.TabIndex = 17;
            this.sumButton.Text = "=";
            this.sumButton.UseVisualStyleBackColor = false;
            this.sumButton.Click += new System.EventHandler(this.sumButton_Click);
            // 
            // powerButton
            // 
            this.powerButton.BackColor = System.Drawing.Color.Chocolate;
            this.powerButton.FlatAppearance.BorderSize = 0;
            this.powerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.powerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.powerButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.powerButton.Location = new System.Drawing.Point(300, 0);
            this.powerButton.Name = "powerButton";
            this.powerButton.Size = new System.Drawing.Size(60, 60);
            this.powerButton.TabIndex = 16;
            this.powerButton.Text = "x²";
            this.powerButton.UseVisualStyleBackColor = false;
            this.powerButton.Click += new System.EventHandler(this.powerButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.BackColor = System.Drawing.Color.Chocolate;
            this.divideButton.FlatAppearance.BorderSize = 0;
            this.divideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.divideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.divideButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.divideButton.Location = new System.Drawing.Point(240, 180);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(60, 60);
            this.divideButton.TabIndex = 15;
            this.divideButton.Text = "÷";
            this.divideButton.UseVisualStyleBackColor = false;
            this.divideButton.Click += new System.EventHandler(this.GetOperator);
            // 
            // plusButton
            // 
            this.plusButton.BackColor = System.Drawing.Color.Chocolate;
            this.plusButton.FlatAppearance.BorderSize = 0;
            this.plusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.plusButton.Location = new System.Drawing.Point(240, 0);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(60, 60);
            this.plusButton.TabIndex = 14;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = false;
            this.plusButton.Click += new System.EventHandler(this.GetOperator);
            // 
            // minusButton
            // 
            this.minusButton.BackColor = System.Drawing.Color.Chocolate;
            this.minusButton.FlatAppearance.BorderSize = 0;
            this.minusButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.minusButton.Location = new System.Drawing.Point(240, 60);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(60, 60);
            this.minusButton.TabIndex = 13;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = false;
            this.minusButton.Click += new System.EventHandler(this.GetOperator);
            // 
            // multipleButton
            // 
            this.multipleButton.BackColor = System.Drawing.Color.Chocolate;
            this.multipleButton.FlatAppearance.BorderSize = 0;
            this.multipleButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.multipleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multipleButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.multipleButton.Location = new System.Drawing.Point(240, 120);
            this.multipleButton.Name = "multipleButton";
            this.multipleButton.Size = new System.Drawing.Size(60, 60);
            this.multipleButton.TabIndex = 12;
            this.multipleButton.Text = "*";
            this.multipleButton.UseVisualStyleBackColor = false;
            this.multipleButton.Click += new System.EventHandler(this.GetOperator);
            // 
            // clearTextBoxButton
            // 
            this.clearTextBoxButton.BackColor = System.Drawing.Color.Chocolate;
            this.clearTextBoxButton.FlatAppearance.BorderSize = 0;
            this.clearTextBoxButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.clearTextBoxButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearTextBoxButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearTextBoxButton.Location = new System.Drawing.Point(0, 60);
            this.clearTextBoxButton.Name = "clearTextBoxButton";
            this.clearTextBoxButton.Size = new System.Drawing.Size(60, 60);
            this.clearTextBoxButton.TabIndex = 11;
            this.clearTextBoxButton.Text = "C";
            this.clearTextBoxButton.UseVisualStyleBackColor = false;
            this.clearTextBoxButton.Click += new System.EventHandler(this.clearTextBoxButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.BackColor = System.Drawing.Color.Chocolate;
            this.nineButton.FlatAppearance.BorderSize = 0;
            this.nineButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nineButton.Location = new System.Drawing.Point(180, 0);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(60, 60);
            this.nineButton.TabIndex = 10;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = false;
            this.nineButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // eightButton
            // 
            this.eightButton.BackColor = System.Drawing.Color.Chocolate;
            this.eightButton.FlatAppearance.BorderSize = 0;
            this.eightButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.eightButton.Location = new System.Drawing.Point(120, 0);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(60, 60);
            this.eightButton.TabIndex = 9;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = false;
            this.eightButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // sevenButton
            // 
            this.sevenButton.BackColor = System.Drawing.Color.Chocolate;
            this.sevenButton.FlatAppearance.BorderSize = 0;
            this.sevenButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sevenButton.Location = new System.Drawing.Point(60, 0);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(60, 60);
            this.sevenButton.TabIndex = 8;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = false;
            this.sevenButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // sixButton
            // 
            this.sixButton.BackColor = System.Drawing.Color.Chocolate;
            this.sixButton.FlatAppearance.BorderSize = 0;
            this.sixButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sixButton.Location = new System.Drawing.Point(180, 60);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(60, 60);
            this.sixButton.TabIndex = 7;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = false;
            this.sixButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.BackColor = System.Drawing.Color.Chocolate;
            this.fiveButton.FlatAppearance.BorderSize = 0;
            this.fiveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fiveButton.Location = new System.Drawing.Point(120, 60);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(60, 60);
            this.fiveButton.TabIndex = 6;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = false;
            this.fiveButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // fourButton
            // 
            this.fourButton.BackColor = System.Drawing.Color.Chocolate;
            this.fourButton.FlatAppearance.BorderSize = 0;
            this.fourButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.fourButton.Location = new System.Drawing.Point(60, 60);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(60, 60);
            this.fourButton.TabIndex = 5;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = false;
            this.fourButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // threeButton
            // 
            this.threeButton.BackColor = System.Drawing.Color.Chocolate;
            this.threeButton.FlatAppearance.BorderSize = 0;
            this.threeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.threeButton.Location = new System.Drawing.Point(180, 120);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(60, 60);
            this.threeButton.TabIndex = 4;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = false;
            this.threeButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // twoButton
            // 
            this.twoButton.BackColor = System.Drawing.Color.Chocolate;
            this.twoButton.FlatAppearance.BorderSize = 0;
            this.twoButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.twoButton.Location = new System.Drawing.Point(120, 120);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(60, 60);
            this.twoButton.TabIndex = 3;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = false;
            this.twoButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // oneButton
            // 
            this.oneButton.BackColor = System.Drawing.Color.Chocolate;
            this.oneButton.FlatAppearance.BorderSize = 0;
            this.oneButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oneButton.Location = new System.Drawing.Point(60, 120);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(60, 60);
            this.oneButton.TabIndex = 2;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = false;
            this.oneButton.Click += new System.EventHandler(this.GetNumber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 292);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.resultTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(445, 470);
            this.MinimumSize = new System.Drawing.Size(45, 49);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button multipleButton;
        private System.Windows.Forms.Button clearTextBoxButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button powerButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button soundButton;
        private System.Windows.Forms.Button sqrtButton;
        private System.Windows.Forms.Button factorialButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button clearLastElement;
        private System.Windows.Forms.Button changeSymbolbutton;
    }
}

