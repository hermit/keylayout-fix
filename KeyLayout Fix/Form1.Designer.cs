namespace KeyLayout_Fixer
{
  partial class Form1
  {
    /// <summary>
    /// 必要なデザイナ変数です。
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// 使用中のリソースをすべてクリーンアップします。
    /// </summary>
    /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows フォーム デザイナで生成されたコード

    /// <summary>
    /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
    /// コード エディタで変更しないでください。
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.comboBoxKeyName = new System.Windows.Forms.ComboBox();
      this.label2 = new System.Windows.Forms.Label();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBoxLayoutFile = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.comboBoxLayoutText = new System.Windows.Forms.ComboBox();
      this.dgv = new System.Windows.Forms.DataGridView();
      this.entryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.keyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.layoutTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.layoutFileDataGridViewComboBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
      this.groupBox1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // comboBoxKeyName
      // 
      this.comboBoxKeyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		  | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxKeyName.FormattingEnabled = true;
      this.comboBoxKeyName.Location = new System.Drawing.Point(82, 18);
      this.comboBoxKeyName.Name = "comboBoxKeyName";
      this.comboBoxKeyName.Size = new System.Drawing.Size(342, 20);
      this.comboBoxKeyName.TabIndex = 2;
      this.comboBoxKeyName.Text = "0411$";
      this.comboBoxKeyName.TextUpdate += new System.EventHandler(this.comboBoxKeyName_TextUpdate);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(14, 46);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 12);
      this.label2.TabIndex = 3;
      this.label2.Text = "LayoutText";
      // 
      // groupBox1
      // 
      this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		  | System.Windows.Forms.AnchorStyles.Right)));
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.comboBoxLayoutFile);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.comboBoxLayoutText);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.comboBoxKeyName);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(441, 99);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "パターン (正規表現)";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(14, 72);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 12);
      this.label3.TabIndex = 5;
      this.label3.Text = "LayoutFile";
      // 
      // comboBoxLayoutFile
      // 
      this.comboBoxLayoutFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		  | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxLayoutFile.FormattingEnabled = true;
      this.comboBoxLayoutFile.Location = new System.Drawing.Point(82, 69);
      this.comboBoxLayoutFile.Name = "comboBoxLayoutFile";
      this.comboBoxLayoutFile.Size = new System.Drawing.Size(342, 20);
      this.comboBoxLayoutFile.TabIndex = 6;
      this.comboBoxLayoutFile.TextUpdate += new System.EventHandler(this.comboBoxLayoutFile_TextUpdate);
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(14, 21);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(37, 12);
      this.label1.TabIndex = 1;
      this.label1.Text = "キー名";
      // 
      // comboBoxLayoutText
      // 
      this.comboBoxLayoutText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
		  | System.Windows.Forms.AnchorStyles.Right)));
      this.comboBoxLayoutText.FormattingEnabled = true;
      this.comboBoxLayoutText.Location = new System.Drawing.Point(82, 43);
      this.comboBoxLayoutText.Name = "comboBoxLayoutText";
      this.comboBoxLayoutText.Size = new System.Drawing.Size(342, 20);
      this.comboBoxLayoutText.TabIndex = 4;
      this.comboBoxLayoutText.TextUpdate += new System.EventHandler(this.comboBoxLayoutText_TextUpdate);
      // 
      // dgv
      // 
      this.dgv.AllowDrop = true;
      this.dgv.AllowUserToOrderColumns = true;
      this.dgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
		  | System.Windows.Forms.AnchorStyles.Left)
		  | System.Windows.Forms.AnchorStyles.Right)));
      this.dgv.AutoGenerateColumns = false;
      this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyNameDataGridViewTextBoxColumn,
            this.layoutTextDataGridViewTextBoxColumn,
            this.layoutFileDataGridViewComboBoxColumn});
      this.dgv.DataSource = this.entryBindingSource;
      this.dgv.Location = new System.Drawing.Point(13, 118);
      this.dgv.Name = "dgv";
      this.dgv.RowTemplate.Height = 21;
      this.dgv.Size = new System.Drawing.Size(440, 151);
      this.dgv.TabIndex = 3;
      // 
      // entryBindingSource
      // 
      this.entryBindingSource.DataSource = typeof(KeyLayout_Fixer.Form1.Entry);
      // 
      // keyNameDataGridViewTextBoxColumn
      // 
      this.keyNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.keyNameDataGridViewTextBoxColumn.DataPropertyName = "KeyName";
      this.keyNameDataGridViewTextBoxColumn.HeaderText = "KeyName";
      this.keyNameDataGridViewTextBoxColumn.Name = "keyNameDataGridViewTextBoxColumn";
      this.keyNameDataGridViewTextBoxColumn.ReadOnly = true;
      this.keyNameDataGridViewTextBoxColumn.Width = 78;
      // 
      // layoutTextDataGridViewTextBoxColumn
      // 
      this.layoutTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
      this.layoutTextDataGridViewTextBoxColumn.DataPropertyName = "LayoutText";
      this.layoutTextDataGridViewTextBoxColumn.HeaderText = "LayoutText";
      this.layoutTextDataGridViewTextBoxColumn.Name = "layoutTextDataGridViewTextBoxColumn";
      this.layoutTextDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // layoutFileDataGridViewComboBoxColumn
      // 
      this.layoutFileDataGridViewComboBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
      this.layoutFileDataGridViewComboBoxColumn.DataPropertyName = "LayoutFile";
      this.layoutFileDataGridViewComboBoxColumn.HeaderText = "LayoutFile";
      this.layoutFileDataGridViewComboBoxColumn.Name = "layoutFileDataGridViewComboBoxColumn";
      this.layoutFileDataGridViewComboBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
      this.layoutFileDataGridViewComboBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
      this.layoutFileDataGridViewComboBoxColumn.Width = 83;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(465, 281);
      this.Controls.Add(this.dgv);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form1";
      this.Text = "KeyLayout Fix";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.entryBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ComboBox comboBoxKeyName;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBoxLayoutFile;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ComboBox comboBoxLayoutText;
    private System.Windows.Forms.DataGridView dgv;
    private System.Windows.Forms.BindingSource entryBindingSource;
    private System.Windows.Forms.DataGridViewTextBoxColumn keyNameDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn layoutTextDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewComboBoxColumn layoutFileDataGridViewComboBoxColumn;
  }
}
