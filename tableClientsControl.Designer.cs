namespace Internet_service_provider
{
    partial class tableClientsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableSubscribers = new System.Windows.Forms.DataGridView();
            this.updateTableButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscribers)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableSubscribers
            // 
            this.tableSubscribers.AllowUserToDeleteRows = false;
            this.tableSubscribers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tableSubscribers.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tableSubscribers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSubscribers.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableSubscribers.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableSubscribers.Location = new System.Drawing.Point(0, 0);
            this.tableSubscribers.Margin = new System.Windows.Forms.Padding(5);
            this.tableSubscribers.MultiSelect = false;
            this.tableSubscribers.Name = "tableSubscribers";
            this.tableSubscribers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.tableSubscribers.Size = new System.Drawing.Size(1047, 348);
            this.tableSubscribers.TabIndex = 0;
            this.tableSubscribers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // updateTableButton
            // 
            this.updateTableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(83)))), ((int)(((byte)(79)))));
            this.updateTableButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.updateTableButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateTableButton.ForeColor = System.Drawing.Color.White;
            this.updateTableButton.Location = new System.Drawing.Point(354, 5);
            this.updateTableButton.Margin = new System.Windows.Forms.Padding(5);
            this.updateTableButton.Name = "updateTableButton";
            this.updateTableButton.Size = new System.Drawing.Size(339, 74);
            this.updateTableButton.TabIndex = 0;
            this.updateTableButton.Text = "Синхронизировать с БД";
            this.updateTableButton.UseVisualStyleBackColor = false;
            this.updateTableButton.Click += new System.EventHandler(this.updateTableButton_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.updateTableButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 356);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 84);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(343, 78);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button2.Location = new System.Drawing.Point(701, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(343, 78);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // tableClientsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableSubscribers);
            this.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "tableClientsControl";
            this.Size = new System.Drawing.Size(1047, 440);
            ((System.ComponentModel.ISupportInitialize)(this.tableSubscribers)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tableSubscribers;
        private System.Windows.Forms.Button updateTableButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
