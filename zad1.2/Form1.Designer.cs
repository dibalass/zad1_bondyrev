namespace zad1_bondyrev
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.products = new System.Windows.Forms.ListBox();
            this.add_market = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.count_add = new System.Windows.Forms.TextBox();
            this.market_add = new System.Windows.Forms.TextBox();
            this.price_add = new System.Windows.Forms.TextBox();
            this.name_add = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_tovar = new System.Windows.Forms.Button();
            this.count_buy = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.profit_market = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.name_buy = new System.Windows.Forms.TextBox();
            this.buy_stuff = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.choose_market = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ClearPlaylist = new System.Windows.Forms.Button();
            this.startOnIndex = new System.Windows.Forms.Button();
            this.deleteOnIndex = new System.Windows.Forms.Button();
            this.firstTrack = new System.Windows.Forms.Button();
            this.deleteCurrientTrack = new System.Windows.Forms.Button();
            this.index_track = new System.Windows.Forms.NumericUpDown();
            this.currientTrack = new System.Windows.Forms.Label();
            this.Next = new System.Windows.Forms.Button();
            this.Start_Stop = new System.Windows.Forms.Button();
            this.Back = new System.Windows.Forms.Button();
            this.addTrackButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.file = new System.Windows.Forms.TextBox();
            this.track = new System.Windows.Forms.TextBox();
            this.author = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_buy)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index_track)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(791, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.products);
            this.tabPage1.Controls.Add(this.add_market);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.market_add);
            this.tabPage1.Controls.Add(this.count_add);
            this.tabPage1.Controls.Add(this.choose_market);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.price_add);
            this.tabPage1.Controls.Add(this.buy_stuff);
            this.tabPage1.Controls.Add(this.name_add);
            this.tabPage1.Controls.Add(this.name_buy);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.profit_market);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.add_tovar);
            this.tabPage1.Controls.Add(this.count_buy);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(783, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "zad1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // products
            // 
            this.products.FormattingEnabled = true;
            this.products.Location = new System.Drawing.Point(334, 29);
            this.products.Name = "products";
            this.products.Size = new System.Drawing.Size(418, 121);
            this.products.TabIndex = 44;
            // 
            // add_market
            // 
            this.add_market.Location = new System.Drawing.Point(23, 82);
            this.add_market.Name = "add_market";
            this.add_market.Size = new System.Drawing.Size(116, 33);
            this.add_market.TabIndex = 2;
            this.add_market.Text = "Добавить магазин";
            this.add_market.UseVisualStyleBackColor = true;
            this.add_market.Click += new System.EventHandler(this.addMarketButton_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 13);
            this.label14.TabIndex = 1;
            this.label14.Text = "Название магазина";
            // 
            // count_add
            // 
            this.count_add.Location = new System.Drawing.Point(485, 291);
            this.count_add.Name = "count_add";
            this.count_add.Size = new System.Drawing.Size(100, 20);
            this.count_add.TabIndex = 43;
            // 
            // market_add
            // 
            this.market_add.Location = new System.Drawing.Point(23, 56);
            this.market_add.Name = "market_add";
            this.market_add.Size = new System.Drawing.Size(116, 20);
            this.market_add.TabIndex = 0;
            // 
            // price_add
            // 
            this.price_add.Location = new System.Drawing.Point(486, 252);
            this.price_add.Name = "price_add";
            this.price_add.Size = new System.Drawing.Size(100, 20);
            this.price_add.TabIndex = 42;
            // 
            // name_add
            // 
            this.name_add.Location = new System.Drawing.Point(486, 213);
            this.name_add.Name = "name_add";
            this.name_add.Size = new System.Drawing.Size(100, 20);
            this.name_add.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 236);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Цена товара";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(482, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Количество товара";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(482, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Название товара";
            // 
            // add_tovar
            // 
            this.add_tovar.Location = new System.Drawing.Point(485, 317);
            this.add_tovar.Name = "add_tovar";
            this.add_tovar.Size = new System.Drawing.Size(101, 35);
            this.add_tovar.TabIndex = 36;
            this.add_tovar.Text = "Добавить товар";
            this.add_tovar.UseVisualStyleBackColor = true;
            this.add_tovar.Click += new System.EventHandler(this.button2_Click);
            // 
            // count_buy
            // 
            this.count_buy.Location = new System.Drawing.Point(334, 252);
            this.count_buy.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.count_buy.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.count_buy.Name = "count_buy";
            this.count_buy.Size = new System.Drawing.Size(120, 20);
            this.count_buy.TabIndex = 17;
            this.count_buy.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(331, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Количество товара";
            // 
            // profit_market
            // 
            this.profit_market.AutoSize = true;
            this.profit_market.Location = new System.Drawing.Point(332, 166);
            this.profit_market.Name = "profit_market";
            this.profit_market.Size = new System.Drawing.Size(108, 13);
            this.profit_market.TabIndex = 5;
            this.profit_market.Text = "Прибыль магазина:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 197);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Название товара";
            // 
            // name_buy
            // 
            this.name_buy.Location = new System.Drawing.Point(334, 213);
            this.name_buy.Name = "name_buy";
            this.name_buy.Size = new System.Drawing.Size(120, 20);
            this.name_buy.TabIndex = 3;
            // 
            // buy_stuff
            // 
            this.buy_stuff.Location = new System.Drawing.Point(334, 278);
            this.buy_stuff.Name = "buy_stuff";
            this.buy_stuff.Size = new System.Drawing.Size(120, 23);
            this.buy_stuff.TabIndex = 2;
            this.buy_stuff.Text = "Купить";
            this.buy_stuff.UseVisualStyleBackColor = true;
            this.buy_stuff.Click += new System.EventHandler(this.buyButton_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(168, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Выберите магазин";
            // 
            // choose_market
            // 
            this.choose_market.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.choose_market.FormattingEnabled = true;
            this.choose_market.Location = new System.Drawing.Point(169, 56);
            this.choose_market.Name = "choose_market";
            this.choose_market.Size = new System.Drawing.Size(121, 21);
            this.choose_market.TabIndex = 0;
            this.choose_market.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Добавить магазин",
            "Магазин"});
            this.comboBox1.Location = new System.Drawing.Point(142, -83);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(210, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.addTrackButton);
            this.tabPage2.Controls.Add(this.ClearPlaylist);
            this.tabPage2.Controls.Add(this.Back);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.Start_Stop);
            this.tabPage2.Controls.Add(this.startOnIndex);
            this.tabPage2.Controls.Add(this.Next);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.currientTrack);
            this.tabPage2.Controls.Add(this.deleteOnIndex);
            this.tabPage2.Controls.Add(this.index_track);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.author);
            this.tabPage2.Controls.Add(this.firstTrack);
            this.tabPage2.Controls.Add(this.deleteCurrientTrack);
            this.tabPage2.Controls.Add(this.file);
            this.tabPage2.Controls.Add(this.track);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(783, 371);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "zad2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ClearPlaylist
            // 
            this.ClearPlaylist.Location = new System.Drawing.Point(15, 326);
            this.ClearPlaylist.Margin = new System.Windows.Forms.Padding(2);
            this.ClearPlaylist.Name = "ClearPlaylist";
            this.ClearPlaylist.Size = new System.Drawing.Size(128, 42);
            this.ClearPlaylist.TabIndex = 9;
            this.ClearPlaylist.Text = "Очистить плейлист";
            this.ClearPlaylist.UseVisualStyleBackColor = true;
            this.ClearPlaylist.Click += new System.EventHandler(this.clearPlayListButton_Click);
            // 
            // startOnIndex
            // 
            this.startOnIndex.Location = new System.Drawing.Point(15, 188);
            this.startOnIndex.Margin = new System.Windows.Forms.Padding(2);
            this.startOnIndex.Name = "startOnIndex";
            this.startOnIndex.Size = new System.Drawing.Size(128, 42);
            this.startOnIndex.TabIndex = 8;
            this.startOnIndex.Text = "Включить трек по индексу";
            this.startOnIndex.UseVisualStyleBackColor = true;
            this.startOnIndex.Click += new System.EventHandler(this.startTrackOnIndexButton_Click);
            // 
            // deleteOnIndex
            // 
            this.deleteOnIndex.Location = new System.Drawing.Point(15, 280);
            this.deleteOnIndex.Margin = new System.Windows.Forms.Padding(2);
            this.deleteOnIndex.Name = "deleteOnIndex";
            this.deleteOnIndex.Size = new System.Drawing.Size(128, 42);
            this.deleteOnIndex.TabIndex = 7;
            this.deleteOnIndex.Text = "Удалить трек по индексу";
            this.deleteOnIndex.UseVisualStyleBackColor = true;
            this.deleteOnIndex.Click += new System.EventHandler(this.deleteTrackOnIndexButton_Click);
            // 
            // firstTrack
            // 
            this.firstTrack.Location = new System.Drawing.Point(15, 142);
            this.firstTrack.Margin = new System.Windows.Forms.Padding(2);
            this.firstTrack.Name = "firstTrack";
            this.firstTrack.Size = new System.Drawing.Size(128, 42);
            this.firstTrack.TabIndex = 6;
            this.firstTrack.Text = "Вернуться к первому";
            this.firstTrack.UseVisualStyleBackColor = true;
            this.firstTrack.Click += new System.EventHandler(this.firstTrackButton_Click);
            // 
            // deleteCurrientTrack
            // 
            this.deleteCurrientTrack.Location = new System.Drawing.Point(15, 234);
            this.deleteCurrientTrack.Margin = new System.Windows.Forms.Padding(2);
            this.deleteCurrientTrack.Name = "deleteCurrientTrack";
            this.deleteCurrientTrack.Size = new System.Drawing.Size(128, 42);
            this.deleteCurrientTrack.TabIndex = 5;
            this.deleteCurrientTrack.Text = "Удалить текущий трек";
            this.deleteCurrientTrack.UseVisualStyleBackColor = true;
            this.deleteCurrientTrack.Click += new System.EventHandler(this.deleteCurrientTrackButton_Click);
            // 
            // index_track
            // 
            this.index_track.Location = new System.Drawing.Point(173, 146);
            this.index_track.Margin = new System.Windows.Forms.Padding(2);
            this.index_track.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.index_track.Name = "index_track";
            this.index_track.Size = new System.Drawing.Size(113, 20);
            this.index_track.TabIndex = 4;
            // 
            // currientTrack
            // 
            this.currientTrack.AutoSize = true;
            this.currientTrack.Location = new System.Drawing.Point(173, 119);
            this.currientTrack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.currientTrack.Name = "currientTrack";
            this.currientTrack.Size = new System.Drawing.Size(0, 13);
            this.currientTrack.TabIndex = 3;
            // 
            // Next
            // 
            this.Next.Location = new System.Drawing.Point(251, 170);
            this.Next.Margin = new System.Windows.Forms.Padding(2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(35, 35);
            this.Next.TabIndex = 2;
            this.Next.Text = ">";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.nextTrackButton_Click);
            // 
            // Start_Stop
            // 
            this.Start_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Start_Stop.Location = new System.Drawing.Point(212, 170);
            this.Start_Stop.Margin = new System.Windows.Forms.Padding(2);
            this.Start_Stop.Name = "Start_Stop";
            this.Start_Stop.Size = new System.Drawing.Size(35, 35);
            this.Start_Stop.TabIndex = 1;
            this.Start_Stop.Text = "⏯️";
            this.Start_Stop.UseVisualStyleBackColor = true;
            this.Start_Stop.Click += new System.EventHandler(this.stopAndStartButton_Click);
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(173, 170);
            this.Back.Margin = new System.Windows.Forms.Padding(2);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(35, 35);
            this.Back.TabIndex = 0;
            this.Back.Text = "<";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.previousTrackButton_Click);
            // 
            // addTrackButton
            // 
            this.addTrackButton.Location = new System.Drawing.Point(344, 255);
            this.addTrackButton.Margin = new System.Windows.Forms.Padding(2);
            this.addTrackButton.Name = "addTrackButton";
            this.addTrackButton.Size = new System.Drawing.Size(136, 31);
            this.addTrackButton.TabIndex = 6;
            this.addTrackButton.Text = "Добавить трек";
            this.addTrackButton.UseVisualStyleBackColor = true;
            this.addTrackButton.Click += new System.EventHandler(this.addTrackButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(341, 216);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(142, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Файл (с разрешение .wav)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(341, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Название песни";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 142);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Автор";
            // 
            // file
            // 
            this.file.Location = new System.Drawing.Point(344, 231);
            this.file.Margin = new System.Windows.Forms.Padding(2);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(136, 20);
            this.file.TabIndex = 2;
            // 
            // track
            // 
            this.track.Location = new System.Drawing.Point(344, 194);
            this.track.Margin = new System.Windows.Forms.Padding(2);
            this.track.Name = "track";
            this.track.Size = new System.Drawing.Size(136, 20);
            this.track.TabIndex = 1;
            // 
            // author
            // 
            this.author.Location = new System.Drawing.Point(344, 157);
            this.author.Margin = new System.Windows.Forms.Padding(2);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(136, 20);
            this.author.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Сейчас играет";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 397);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count_buy)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.index_track)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button ClearPlaylist;
        private System.Windows.Forms.Button startOnIndex;
        private System.Windows.Forms.Button deleteOnIndex;
        private System.Windows.Forms.Button firstTrack;
        private System.Windows.Forms.Button deleteCurrientTrack;
        private System.Windows.Forms.NumericUpDown index_track;
        private System.Windows.Forms.Label currientTrack;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Start_Stop;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button addTrackButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.TextBox track;
        private System.Windows.Forms.TextBox author;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button add_tovar;
        private System.Windows.Forms.NumericUpDown count_buy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label profit_market;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox name_buy;
        private System.Windows.Forms.Button buy_stuff;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox choose_market;
        private System.Windows.Forms.Button add_market;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox market_add;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox price_add;
        private System.Windows.Forms.TextBox name_add;
        private System.Windows.Forms.TextBox count_add;
        private System.Windows.Forms.ListBox products;
        private System.Windows.Forms.Label label4;
    }
}

