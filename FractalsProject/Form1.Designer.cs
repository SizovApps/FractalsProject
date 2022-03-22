namespace FractalsProject
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
            this.chooseLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chooseCochCurve = new System.Windows.Forms.Button();
            this.chooseCarpet = new System.Windows.Forms.Button();
            this.chooseTriangle = new System.Windows.Forms.Button();
            this.chooseKantorSet = new System.Windows.Forms.Button();
            this.chooseFractalTree = new System.Windows.Forms.Button();
            this.choosePanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.choosePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // chooseLabel
            // 
            this.chooseLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseLabel.Location = new System.Drawing.Point(349, 40);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(593, 25);
            this.chooseLabel.TabIndex = 0;
            this.chooseLabel.Text = "Выберите тип фрактала, который хотите нарисовать";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.chooseCochCurve, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseCarpet, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseTriangle, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseKantorSet, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.chooseFractalTree, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(33, 232);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1205, 226);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // chooseCochCurve
            // 
            this.chooseCochCurve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chooseCochCurve.Location = new System.Drawing.Point(244, 3);
            this.chooseCochCurve.Name = "chooseCochCurve";
            this.chooseCochCurve.Size = new System.Drawing.Size(235, 220);
            this.chooseCochCurve.TabIndex = 1;
            this.chooseCochCurve.Text = "Кривая Коха";
            this.chooseCochCurve.UseVisualStyleBackColor = true;
            this.chooseCochCurve.Click += new System.EventHandler(this.chooseCochCurve_Click);
            // 
            // chooseCarpet
            // 
            this.chooseCarpet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chooseCarpet.Location = new System.Drawing.Point(485, 3);
            this.chooseCarpet.Name = "chooseCarpet";
            this.chooseCarpet.Size = new System.Drawing.Size(235, 220);
            this.chooseCarpet.TabIndex = 2;
            this.chooseCarpet.Text = "Ковер Серпинского";
            this.chooseCarpet.UseVisualStyleBackColor = true;
            this.chooseCarpet.Click += new System.EventHandler(this.chooseCarpet_Click);
            // 
            // chooseTriangle
            // 
            this.chooseTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chooseTriangle.Location = new System.Drawing.Point(726, 3);
            this.chooseTriangle.Name = "chooseTriangle";
            this.chooseTriangle.Size = new System.Drawing.Size(235, 220);
            this.chooseTriangle.TabIndex = 3;
            this.chooseTriangle.Text = "Треугольник Серпинского";
            this.chooseTriangle.UseVisualStyleBackColor = true;
            this.chooseTriangle.Click += new System.EventHandler(this.chooseTriangle_Click);
            // 
            // chooseKantorSet
            // 
            this.chooseKantorSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.chooseKantorSet.Location = new System.Drawing.Point(967, 3);
            this.chooseKantorSet.Name = "chooseKantorSet";
            this.chooseKantorSet.Size = new System.Drawing.Size(235, 220);
            this.chooseKantorSet.TabIndex = 4;
            this.chooseKantorSet.Text = "Множество Кантора";
            this.chooseKantorSet.UseVisualStyleBackColor = true;
            this.chooseKantorSet.Click += new System.EventHandler(this.chooseKantorSet_Click);
            // 
            // chooseFractalTree
            // 
            this.chooseFractalTree.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chooseFractalTree.Location = new System.Drawing.Point(3, 3);
            this.chooseFractalTree.Name = "chooseFractalTree";
            this.chooseFractalTree.Size = new System.Drawing.Size(235, 220);
            this.chooseFractalTree.TabIndex = 0;
            this.chooseFractalTree.Text = "Обдуваемое ветром фрактальное дерево";
            this.chooseFractalTree.UseVisualStyleBackColor = true;
            this.chooseFractalTree.Click += new System.EventHandler(this.chooseFractalTree_Click);
            // 
            // choosePanel
            // 
            this.choosePanel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.choosePanel.Controls.Add(this.tableLayoutPanel1);
            this.choosePanel.Controls.Add(this.chooseLabel);
            this.choosePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.choosePanel.Location = new System.Drawing.Point(0, 0);
            this.choosePanel.Name = "choosePanel";
            this.choosePanel.Size = new System.Drawing.Size(1284, 692);
            this.choosePanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.choosePanel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.choosePanel.ResumeLayout(false);
            this.choosePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button chooseFractalTree;
        private System.Windows.Forms.Button chooseCochCurve;
        private System.Windows.Forms.Button chooseCarpet;
        private System.Windows.Forms.Button chooseTriangle;
        private System.Windows.Forms.Button chooseKantorSet;
        private System.Windows.Forms.Panel choosePanel;
    }
}

