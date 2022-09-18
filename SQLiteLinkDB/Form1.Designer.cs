namespace SQLiteLinkDBTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NOBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PriceBox = new System.Windows.Forms.TextBox();
            this.UpSert = new System.Windows.Forms.Button();
            this.Insert = new System.Windows.Forms.Button();
            this.Selete = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.ShowTable = new System.Windows.Forms.Button();
            this.Upatable = new System.Windows.Forms.Button();
            this.TableNameBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(22, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "商品番号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(22, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "商品名称";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(22, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "商品価格";
            // 
            // NOBox
            // 
            this.NOBox.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NOBox.Location = new System.Drawing.Point(153, 28);
            this.NOBox.Name = "NOBox";
            this.NOBox.Size = new System.Drawing.Size(140, 38);
            this.NOBox.TabIndex = 1;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.NameBox.Location = new System.Drawing.Point(153, 89);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(140, 38);
            this.NameBox.TabIndex = 1;
            // 
            // PriceBox
            // 
            this.PriceBox.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PriceBox.Location = new System.Drawing.Point(153, 147);
            this.PriceBox.Name = "PriceBox";
            this.PriceBox.Size = new System.Drawing.Size(140, 38);
            this.PriceBox.TabIndex = 1;
            // 
            // UpSert
            // 
            this.UpSert.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.UpSert.Location = new System.Drawing.Point(27, 242);
            this.UpSert.Name = "UpSert";
            this.UpSert.Size = new System.Drawing.Size(104, 42);
            this.UpSert.TabIndex = 2;
            this.UpSert.Text = "更新";
            this.UpSert.UseVisualStyleBackColor = true;
            this.UpSert.Click += new System.EventHandler(this.UpSert_Click);
            // 
            // Insert
            // 
            this.Insert.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Insert.Location = new System.Drawing.Point(153, 242);
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(104, 42);
            this.Insert.TabIndex = 2;
            this.Insert.Text = "登録";
            this.Insert.UseVisualStyleBackColor = true;
            this.Insert.Click += new System.EventHandler(this.Insert_Click);
            // 
            // Selete
            // 
            this.Selete.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Selete.Location = new System.Drawing.Point(27, 332);
            this.Selete.Name = "Selete";
            this.Selete.Size = new System.Drawing.Size(104, 42);
            this.Selete.TabIndex = 2;
            this.Selete.Text = "検索";
            this.Selete.UseVisualStyleBackColor = true;
            this.Selete.Click += new System.EventHandler(this.Selete_Click);
            // 
            // Delete
            // 
            this.Delete.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Delete.Location = new System.Drawing.Point(153, 332);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(104, 42);
            this.Delete.TabIndex = 2;
            this.Delete.Text = "削除";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(344, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(413, 183);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(344, 242);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 21;
            this.dataGridView2.Size = new System.Drawing.Size(413, 183);
            this.dataGridView2.TabIndex = 3;
            // 
            // ShowTable
            // 
            this.ShowTable.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ShowTable.Location = new System.Drawing.Point(27, 396);
            this.ShowTable.Name = "ShowTable";
            this.ShowTable.Size = new System.Drawing.Size(104, 42);
            this.ShowTable.TabIndex = 2;
            this.ShowTable.Text = "表示";
            this.ShowTable.UseVisualStyleBackColor = true;
            this.ShowTable.Click += new System.EventHandler(this.ShowTable_Click);
            // 
            // Upatable
            // 
            this.Upatable.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Upatable.Location = new System.Drawing.Point(27, 475);
            this.Upatable.Name = "Upatable";
            this.Upatable.Size = new System.Drawing.Size(104, 42);
            this.Upatable.TabIndex = 2;
            this.Upatable.Text = "テーブル作成";
            this.Upatable.UseVisualStyleBackColor = true;
            this.Upatable.Click += new System.EventHandler(this.UpTable_Click);
            // 
            // TableNameBox
            // 
            this.TableNameBox.Font = new System.Drawing.Font("Meiryo UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TableNameBox.Location = new System.Drawing.Point(153, 475);
            this.TableNameBox.Name = "TableNameBox";
            this.TableNameBox.Size = new System.Drawing.Size(140, 38);
            this.TableNameBox.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 559);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Upatable);
            this.Controls.Add(this.ShowTable);
            this.Controls.Add(this.Selete);
            this.Controls.Add(this.Insert);
            this.Controls.Add(this.UpSert);
            this.Controls.Add(this.TableNameBox);
            this.Controls.Add(this.PriceBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.NOBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NOBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PriceBox;
        private System.Windows.Forms.Button UpSert;
        private System.Windows.Forms.Button Insert;
        private System.Windows.Forms.Button Selete;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button ShowTable;
        private System.Windows.Forms.Button Upatable;
        private System.Windows.Forms.TextBox TableNameBox;
    }
}

