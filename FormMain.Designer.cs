namespace WindowsFormsACC
{
    partial class FormMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSIZCOD_P = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSIZESRC_P = new System.Windows.Forms.TextBox();
            this.richTextBoxRES_P = new System.Windows.Forms.RichTextBox();
            this.buttonPack = new System.Windows.Forms.Button();
            this.richTextBoxSRC_P = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSIZE_U = new System.Windows.Forms.TextBox();
            this.richTextBoxRES_U = new System.Windows.Forms.RichTextBox();
            this.buttonUnPack = new System.Windows.Forms.Button();
            this.richTextBoxCOD_U = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelSIZCOD_P);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxSIZESRC_P);
            this.groupBox1.Controls.Add(this.richTextBoxRES_P);
            this.groupBox1.Controls.Add(this.buttonPack);
            this.groupBox1.Controls.Add(this.richTextBoxSRC_P);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "упаковка";
            // 
            // labelSIZCOD_P
            // 
            this.labelSIZCOD_P.AutoSize = true;
            this.labelSIZCOD_P.Location = new System.Drawing.Point(6, 396);
            this.labelSIZCOD_P.Name = "labelSIZCOD_P";
            this.labelSIZCOD_P.Size = new System.Drawing.Size(0, 13);
            this.labelSIZCOD_P.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "размер сжатых данных";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 367);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "размер исходных данных";
            // 
            // textBoxSIZESRC_P
            // 
            this.textBoxSIZESRC_P.Location = new System.Drawing.Point(6, 360);
            this.textBoxSIZESRC_P.Name = "textBoxSIZESRC_P";
            this.textBoxSIZESRC_P.Size = new System.Drawing.Size(100, 20);
            this.textBoxSIZESRC_P.TabIndex = 6;
            // 
            // richTextBoxRES_P
            // 
            this.richTextBoxRES_P.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRES_P.Location = new System.Drawing.Point(6, 219);
            this.richTextBoxRES_P.Name = "richTextBoxRES_P";
            this.richTextBoxRES_P.Size = new System.Drawing.Size(390, 135);
            this.richTextBoxRES_P.TabIndex = 3;
            this.richTextBoxRES_P.Text = "";
            // 
            // buttonPack
            // 
            this.buttonPack.Location = new System.Drawing.Point(6, 180);
            this.buttonPack.Name = "buttonPack";
            this.buttonPack.Size = new System.Drawing.Size(124, 23);
            this.buttonPack.TabIndex = 2;
            this.buttonPack.Text = "Cжать";
            this.buttonPack.UseVisualStyleBackColor = true;
            this.buttonPack.Click += new System.EventHandler(this.buttonPack_Click);
            // 
            // richTextBoxSRC_P
            // 
            this.richTextBoxSRC_P.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxSRC_P.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxSRC_P.Name = "richTextBoxSRC_P";
            this.richTextBoxSRC_P.Size = new System.Drawing.Size(390, 135);
            this.richTextBoxSRC_P.TabIndex = 1;
            this.richTextBoxSRC_P.Text = "текст для дальнейшего сжатия (для наглядности он должен быть большим)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textBoxSIZE_U);
            this.groupBox2.Controls.Add(this.richTextBoxRES_U);
            this.groupBox2.Controls.Add(this.buttonUnPack);
            this.groupBox2.Controls.Add(this.richTextBoxCOD_U);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(418, 418);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "распаковка";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(123, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "размер исходных данных";
            // 
            // textBoxSIZE_U
            // 
            this.textBoxSIZE_U.Location = new System.Drawing.Point(6, 167);
            this.textBoxSIZE_U.Name = "textBoxSIZE_U";
            this.textBoxSIZE_U.Size = new System.Drawing.Size(100, 20);
            this.textBoxSIZE_U.TabIndex = 5;
            // 
            // richTextBoxRES_U
            // 
            this.richTextBoxRES_U.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxRES_U.Location = new System.Drawing.Point(6, 243);
            this.richTextBoxRES_U.Name = "richTextBoxRES_U";
            this.richTextBoxRES_U.Size = new System.Drawing.Size(390, 135);
            this.richTextBoxRES_U.TabIndex = 4;
            this.richTextBoxRES_U.Text = "";
            // 
            // buttonUnPack
            // 
            this.buttonUnPack.Location = new System.Drawing.Point(6, 202);
            this.buttonUnPack.Name = "buttonUnPack";
            this.buttonUnPack.Size = new System.Drawing.Size(128, 23);
            this.buttonUnPack.TabIndex = 3;
            this.buttonUnPack.Text = "Разархивировать";
            this.buttonUnPack.UseVisualStyleBackColor = true;
            this.buttonUnPack.Click += new System.EventHandler(this.buttonUnPack_Click);
            // 
            // richTextBoxCOD_U
            // 
            this.richTextBoxCOD_U.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxCOD_U.Location = new System.Drawing.Point(6, 19);
            this.richTextBoxCOD_U.Name = "richTextBoxCOD_U";
            this.richTextBoxCOD_U.Size = new System.Drawing.Size(390, 135);
            this.richTextBoxCOD_U.TabIndex = 2;
            this.richTextBoxCOD_U.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(830, 418);
            this.splitContainer1.SplitterDistance = 408;
            this.splitContainer1.TabIndex = 3;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 418);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormMain";
            this.Text = "Сжатие арифметическим кодированием";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBoxSRC_P;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richTextBoxCOD_U;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelSIZCOD_P;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxSIZESRC_P;
        private System.Windows.Forms.RichTextBox richTextBoxRES_P;
        private System.Windows.Forms.Button buttonPack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSIZE_U;
        private System.Windows.Forms.RichTextBox richTextBoxRES_U;
        private System.Windows.Forms.Button buttonUnPack;
    }
}

