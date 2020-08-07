namespace broker
{
    partial class broker
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(broker));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelUserBalance = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.listViewAssetsInStock = new System.Windows.Forms.ListView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.labelAmount = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnBuy = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbBuyQuantity = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.listViewAssetsInWallet = new System.Windows.Forms.ListView();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSell = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbSellQuantity = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.labelUserBalance);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.ErrorImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.InitialImage")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 100);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(147)))), ((int)(((byte)(249)))));
            this.labelUsername.Location = new System.Drawing.Point(1289, 21);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(95, 20);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "andre.marra";
            // 
            // labelUserBalance
            // 
            this.labelUserBalance.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUserBalance.AutoSize = true;
            this.labelUserBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.labelUserBalance.Location = new System.Drawing.Point(1288, 50);
            this.labelUserBalance.Name = "labelUserBalance";
            this.labelUserBalance.Size = new System.Drawing.Size(143, 29);
            this.labelUserBalance.TabIndex = 1;
            this.labelUserBalance.Text = "3200,00BRL";
            this.labelUserBalance.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.labelTime.Location = new System.Drawing.Point(732, 21);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(122, 44);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "label1";
            this.labelTime.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.listViewAssetsInStock);
            this.panel3.Controls.Add(this.flowLayoutPanel1);
            this.panel3.Controls.Add(this.labelAmount);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(984, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(250, 761);
            this.panel3.TabIndex = 2;
            // 
            // listViewAssetsInStock
            // 
            this.listViewAssetsInStock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.listViewAssetsInStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAssetsInStock.HideSelection = false;
            this.listViewAssetsInStock.Location = new System.Drawing.Point(0, 70);
            this.listViewAssetsInStock.Name = "listViewAssetsInStock";
            this.listViewAssetsInStock.Size = new System.Drawing.Size(250, 583);
            this.listViewAssetsInStock.TabIndex = 1;
            this.listViewAssetsInStock.UseCompatibleStateImageBehavior = false;
            this.listViewAssetsInStock.SelectedIndexChanged += new System.EventHandler(this.listViewAssetsInStock_SelectedIndexChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 70);
            this.flowLayoutPanel1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(250, 70);
            this.label7.TabIndex = 0;
            this.label7.Text = "Stock";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAmount
            // 
            this.labelAmount.AutoSize = true;
            this.labelAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.labelAmount.Location = new System.Drawing.Point(87, 726);
            this.labelAmount.Name = "labelAmount";
            this.labelAmount.Size = new System.Drawing.Size(28, 13);
            this.labelAmount.TabIndex = 9;
            this.labelAmount.Text = "0,00";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnBuy);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.txbBuyQuantity);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 653);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(250, 108);
            this.panel5.TabIndex = 12;
            // 
            // btnBuy
            // 
            this.btnBuy.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuy.FlatAppearance.BorderSize = 0;
            this.btnBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(250)))), ((int)(((byte)(123)))));
            this.btnBuy.Location = new System.Drawing.Point(170, 0);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(80, 108);
            this.btnBuy.TabIndex = 8;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label5.Location = new System.Drawing.Point(22, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Quantidade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label4.Location = new System.Drawing.Point(22, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Total";
            // 
            // txbBuyQuantity
            // 
            this.txbBuyQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.txbBuyQuantity.ForeColor = System.Drawing.Color.Yellow;
            this.txbBuyQuantity.Location = new System.Drawing.Point(90, 33);
            this.txbBuyQuantity.Name = "txbBuyQuantity";
            this.txbBuyQuantity.Size = new System.Drawing.Size(50, 20);
            this.txbBuyQuantity.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel4.Controls.Add(this.chart1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 100);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 567);
            this.panel4.TabIndex = 3;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.chart1.BorderlineWidth = 0;
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(-271, 0);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(975, 558);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(0, 667);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(892, 194);
            this.webBrowser1.TabIndex = 4;
            this.webBrowser1.Url = new System.Uri("https://www.valor.com.br/rss", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1234, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(250, 761);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.listViewAssetsInWallet);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(250, 583);
            this.panel7.TabIndex = 15;
            // 
            // listViewAssetsInWallet
            // 
            this.listViewAssetsInWallet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(71)))), ((int)(((byte)(90)))));
            this.listViewAssetsInWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewAssetsInWallet.HideSelection = false;
            this.listViewAssetsInWallet.Location = new System.Drawing.Point(0, 0);
            this.listViewAssetsInWallet.Name = "listViewAssetsInWallet";
            this.listViewAssetsInWallet.Size = new System.Drawing.Size(250, 583);
            this.listViewAssetsInWallet.TabIndex = 0;
            this.listViewAssetsInWallet.UseCompatibleStateImageBehavior = false;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label8);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 77);
            this.flowLayoutPanel2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(250, 77);
            this.label8.TabIndex = 1;
            this.label8.Text = "Wallet";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 724);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSell);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.txbSellQuantity);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 653);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(250, 108);
            this.panel6.TabIndex = 13;
            // 
            // btnSell
            // 
            this.btnSell.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSell.FlatAppearance.BorderSize = 0;
            this.btnSell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSell.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSell.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.btnSell.Location = new System.Drawing.Point(170, 0);
            this.btnSell.Name = "btnSell";
            this.btnSell.Size = new System.Drawing.Size(80, 108);
            this.btnSell.TabIndex = 8;
            this.btnSell.Text = "Sell";
            this.btnSell.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(16, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Total";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // txbSellQuantity
            // 
            this.txbSellQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(114)))), ((int)(((byte)(164)))));
            this.txbSellQuantity.Location = new System.Drawing.Point(99, 33);
            this.txbSellQuantity.Name = "txbSellQuantity";
            this.txbSellQuantity.Size = new System.Drawing.Size(50, 20);
            this.txbSellQuantity.TabIndex = 8;
            this.txbSellQuantity.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(248)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(16, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Quantidade";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // broker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1484, 861);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(54)))));
            this.MaximizeBox = false;
            this.Name = "broker";
            this.Text = "BTG Broker";
            this.Load += new System.EventHandler(this.broker_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelUserBalance;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.ListView listViewAssetsInWallet;
        private System.Windows.Forms.ListView listViewAssetsInStock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelAmount;
        private System.Windows.Forms.TextBox txbBuyQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSellQuantity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button btnSell;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
    }
}

