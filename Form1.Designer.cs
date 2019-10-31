namespace PlanBottler1
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Amount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cbSubType = new System.Windows.Forms.ComboBox();
            this.cbDrinks = new System.Windows.Forms.ComboBox();
            this.cbAvail = new System.Windows.Forms.ComboBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.currencyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.euroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dollarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ok = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Drink Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drink Sub Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Drink";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price";
            // 
            // Amount
            // 
            this.Amount.AutoSize = true;
            this.Amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Amount.Location = new System.Drawing.Point(71, 380);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(86, 25);
            this.Amount.TabIndex = 4;
            this.Amount.Text = "Amount";
            this.Amount.Click += new System.EventHandler(this.Amount_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(73, 459);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 28);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 610);
            this.splitter1.TabIndex = 6;
            this.splitter1.TabStop = false;
            // 
            // tbPrice
            // 
            this.tbPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrice.Location = new System.Drawing.Point(262, 290);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(221, 30);
            this.tbPrice.TabIndex = 8;
            this.tbPrice.TextChanged += new System.EventHandler(this.tbPrice_TextChanged);
            // 
            // tbTotal
            // 
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(262, 459);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Size = new System.Drawing.Size(100, 30);
            this.tbTotal.TabIndex = 9;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(262, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 33);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cbSubType
            // 
            this.cbSubType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSubType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cbSubType.FormattingEnabled = true;
            this.cbSubType.Location = new System.Drawing.Point(262, 133);
            this.cbSubType.Name = "cbSubType";
            this.cbSubType.Size = new System.Drawing.Size(309, 33);
            this.cbSubType.TabIndex = 11;
            this.cbSubType.SelectedIndexChanged += new System.EventHandler(this.cbSubType_SelectedIndexChanged);
            // 
            // cbDrinks
            // 
            this.cbDrinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrinks.FormattingEnabled = true;
            this.cbDrinks.Location = new System.Drawing.Point(262, 210);
            this.cbDrinks.Name = "cbDrinks";
            this.cbDrinks.Size = new System.Drawing.Size(309, 33);
            this.cbDrinks.TabIndex = 12;
            this.cbDrinks.SelectedIndexChanged += new System.EventHandler(this.cbDrinks_SelectedIndexChanged);
            // 
            // cbAvail
            // 
            this.cbAvail.FormattingEnabled = true;
            this.cbAvail.Location = new System.Drawing.Point(262, 380);
            this.cbAvail.Name = "cbAvail";
            this.cbAvail.Size = new System.Drawing.Size(100, 24);
            this.cbAvail.TabIndex = 13;
            this.cbAvail.SelectedIndexChanged += new System.EventHandler(this.cbAvail_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.currencyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(969, 28);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // currencyToolStripMenuItem
            // 
            this.currencyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.euroToolStripMenuItem,
            this.dollarToolStripMenuItem});
            this.currencyToolStripMenuItem.Name = "currencyToolStripMenuItem";
            this.currencyToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.currencyToolStripMenuItem.Text = "Currency";
            // 
            // euroToolStripMenuItem
            // 
            this.euroToolStripMenuItem.Name = "euroToolStripMenuItem";
            this.euroToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.euroToolStripMenuItem.Text = "Euro";
            this.euroToolStripMenuItem.Click += new System.EventHandler(this.euroToolStripMenuItem_Click);
            // 
            // dollarToolStripMenuItem
            // 
            this.dollarToolStripMenuItem.Name = "dollarToolStripMenuItem";
            this.dollarToolStripMenuItem.Size = new System.Drawing.Size(125, 26);
            this.dollarToolStripMenuItem.Text = "Dollar";
            this.dollarToolStripMenuItem.Click += new System.EventHandler(this.dollarToolStripMenuItem_Click);
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ok.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ok.Location = new System.Drawing.Point(742, 516);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(72, 39);
            this.ok.TabIndex = 15;
            this.ok.Text = "ok";
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Red;
            this.exit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.exit_btn.Location = new System.Drawing.Point(72, 516);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(75, 42);
            this.exit_btn.TabIndex = 16;
            this.exit_btn.Text = "EXIT";
            this.exit_btn.UseVisualStyleBackColor = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(969, 638);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.cbAvail);
            this.Controls.Add(this.cbDrinks);
            this.Controls.Add(this.cbSubType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Amount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cbSubType;
        private System.Windows.Forms.ComboBox cbDrinks;
        private System.Windows.Forms.ComboBox cbAvail;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem currencyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem euroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dollarToolStripMenuItem;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button exit_btn;
    }
}

