
namespace DB_PD1
{
    partial class MoviesForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridViewMovies = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Budget = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgRating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imax3D = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TicketsSold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxImax3D = new System.Windows.Forms.CheckBox();
            this.dateTimePickerReleaseDateTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReleaseDateFrom = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvgRatingMax = new System.Windows.Forms.TextBox();
            this.textBoxAvgRatingMin = new System.Windows.Forms.TextBox();
            this.textBoxBudgetMax = new System.Windows.Forms.TextBox();
            this.textBoxBudgetMin = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewMovies
            // 
            this.dataGridViewMovies.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.ReleaseDate,
            this.Budget,
            this.AvgRating,
            this.Imax3D,
            this.TicketsSold});
            this.dataGridViewMovies.Location = new System.Drawing.Point(29, 186);
            this.dataGridViewMovies.Name = "dataGridViewMovies";
            this.dataGridViewMovies.Size = new System.Drawing.Size(835, 391);
            this.dataGridViewMovies.TabIndex = 0;
            this.dataGridViewMovies.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewMovies_CellBeginEdit);
            this.dataGridViewMovies.RowValidating += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridViewMovies_RowValidating);
            this.dataGridViewMovies.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridViewMovies_UserDeletingRow);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Title
            // 
            this.Title.DataPropertyName = "Title";
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            // 
            // ReleaseDate
            // 
            this.ReleaseDate.DataPropertyName = "ReleaseDate";
            dataGridViewCellStyle1.Format = "yyyy-MM-dd";
            dataGridViewCellStyle1.NullValue = null;
            this.ReleaseDate.DefaultCellStyle = dataGridViewCellStyle1;
            this.ReleaseDate.HeaderText = "Release Date";
            this.ReleaseDate.Name = "ReleaseDate";
            // 
            // Budget
            // 
            this.Budget.DataPropertyName = "Budget";
            this.Budget.HeaderText = "Budget";
            this.Budget.Name = "Budget";
            // 
            // AvgRating
            // 
            this.AvgRating.DataPropertyName = "AvgRating";
            this.AvgRating.HeaderText = "Avg Rating";
            this.AvgRating.Name = "AvgRating";
            // 
            // Imax3D
            // 
            this.Imax3D.DataPropertyName = "Imax3D";
            this.Imax3D.HeaderText = "3D Imax";
            this.Imax3D.Name = "Imax3D";
            this.Imax3D.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Imax3D.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TicketsSold
            // 
            this.TicketsSold.DataPropertyName = "TicketsSold";
            this.TicketsSold.HeaderText = "Tickets Sold";
            this.TicketsSold.Name = "TicketsSold";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.checkBoxImax3D);
            this.groupBox1.Controls.Add(this.dateTimePickerReleaseDateTo);
            this.groupBox1.Controls.Add(this.dateTimePickerReleaseDateFrom);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBoxAvgRatingMax);
            this.groupBox1.Controls.Add(this.textBoxAvgRatingMin);
            this.groupBox1.Controls.Add(this.textBoxBudgetMax);
            this.groupBox1.Controls.Add(this.textBoxBudgetMin);
            this.groupBox1.Controls.Add(this.textBoxTitle);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(705, 134);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search options";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(48, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "3D Imax";
            // 
            // checkBoxImax3D
            // 
            this.checkBoxImax3D.AutoSize = true;
            this.checkBoxImax3D.Checked = true;
            this.checkBoxImax3D.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.checkBoxImax3D.Location = new System.Drawing.Point(100, 66);
            this.checkBoxImax3D.Name = "checkBoxImax3D";
            this.checkBoxImax3D.Size = new System.Drawing.Size(15, 14);
            this.checkBoxImax3D.TabIndex = 14;
            this.checkBoxImax3D.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxImax3D.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerReleaseDateTo
            // 
            this.dateTimePickerReleaseDateTo.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReleaseDateTo.Location = new System.Drawing.Point(377, 96);
            this.dateTimePickerReleaseDateTo.Name = "dateTimePickerReleaseDateTo";
            this.dateTimePickerReleaseDateTo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReleaseDateTo.TabIndex = 13;
            // 
            // dateTimePickerReleaseDateFrom
            // 
            this.dateTimePickerReleaseDateFrom.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerReleaseDateFrom.Location = new System.Drawing.Point(149, 96);
            this.dateTimePickerReleaseDateFrom.Name = "dateTimePickerReleaseDateFrom";
            this.dateTimePickerReleaseDateFrom.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerReleaseDateFrom.TabIndex = 12;
            this.dateTimePickerReleaseDateFrom.Value = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(355, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "to";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Release Date from";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(526, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "max";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Rating: min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(526, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "max";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Budget: min";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // textBoxAvgRatingMax
            // 
            this.textBoxAvgRatingMax.Location = new System.Drawing.Point(558, 64);
            this.textBoxAvgRatingMax.Name = "textBoxAvgRatingMax";
            this.textBoxAvgRatingMax.Size = new System.Drawing.Size(124, 20);
            this.textBoxAvgRatingMax.TabIndex = 4;
            // 
            // textBoxAvgRatingMin
            // 
            this.textBoxAvgRatingMin.Location = new System.Drawing.Point(396, 64);
            this.textBoxAvgRatingMin.Name = "textBoxAvgRatingMin";
            this.textBoxAvgRatingMin.Size = new System.Drawing.Size(124, 20);
            this.textBoxAvgRatingMin.TabIndex = 3;
            // 
            // textBoxBudgetMax
            // 
            this.textBoxBudgetMax.Location = new System.Drawing.Point(558, 27);
            this.textBoxBudgetMax.Name = "textBoxBudgetMax";
            this.textBoxBudgetMax.Size = new System.Drawing.Size(124, 20);
            this.textBoxBudgetMax.TabIndex = 2;
            // 
            // textBoxBudgetMin
            // 
            this.textBoxBudgetMin.Location = new System.Drawing.Point(396, 27);
            this.textBoxBudgetMin.Name = "textBoxBudgetMin";
            this.textBoxBudgetMin.Size = new System.Drawing.Size(124, 20);
            this.textBoxBudgetMin.TabIndex = 1;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(81, 27);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(228, 20);
            this.textBoxTitle.TabIndex = 0;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(723, 51);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(165, 68);
            this.buttonSearch.TabIndex = 2;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 607);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewMovies);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoviesForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoviesForm_FormClosed);
            this.Load += new System.EventHandler(this.MoviesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovies)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewMovies;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDateTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerReleaseDateFrom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAvgRatingMax;
        private System.Windows.Forms.TextBox textBoxAvgRatingMin;
        private System.Windows.Forms.TextBox textBoxBudgetMax;
        private System.Windows.Forms.TextBox textBoxBudgetMin;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.CheckBox checkBoxImax3D;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Budget;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgRating;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Imax3D;
        private System.Windows.Forms.DataGridViewTextBoxColumn TicketsSold;
    }
}

