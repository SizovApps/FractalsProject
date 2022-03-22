namespace FractalsProject
{
    partial class KantorSetForm
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
            this.widthOfLineTrack = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueOfWidthTrack = new System.Windows.Forms.Label();
            this.valueOfRecursion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOnRecursionTrack = new System.Windows.Forms.TrackBar();
            this.spaceBetweenLinesValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.spaceBetweenLinesTrack = new System.Windows.Forms.TrackBar();
            this.drawKantorButton = new System.Windows.Forms.Button();
            this.kantorSetPaintPanel = new System.Windows.Forms.Panel();
            this.backFromTree = new System.Windows.Forms.Button();
            this.useColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.saveName = new System.Windows.Forms.TextBox();
            this.saveFractal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceBetweenLinesTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // widthOfLineTrack
            // 
            this.widthOfLineTrack.Location = new System.Drawing.Point(15, 83);
            this.widthOfLineTrack.Maximum = 500;
            this.widthOfLineTrack.Minimum = 10;
            this.widthOfLineTrack.Name = "widthOfLineTrack";
            this.widthOfLineTrack.Size = new System.Drawing.Size(271, 45);
            this.widthOfLineTrack.TabIndex = 0;
            this.widthOfLineTrack.Value = 10;
            this.widthOfLineTrack.ValueChanged += new System.EventHandler(this.widthOfLineTrack_ValueChanged);
            this.widthOfLineTrack.Move += new System.EventHandler(this.widthOfLineTrack_Move);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 18);
            this.label1.TabIndex = 16;
            this.label1.Text = "Задайте данные для создания множества Кантора:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Первоначальная длина отрезка (не меньше 10 и не более половины экрана):";
            // 
            // valueOfWidthTrack
            // 
            this.valueOfWidthTrack.AutoSize = true;
            this.valueOfWidthTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfWidthTrack.Location = new System.Drawing.Point(303, 83);
            this.valueOfWidthTrack.Name = "valueOfWidthTrack";
            this.valueOfWidthTrack.Size = new System.Drawing.Size(29, 20);
            this.valueOfWidthTrack.TabIndex = 18;
            this.valueOfWidthTrack.Text = "10";
            // 
            // valueOfRecursion
            // 
            this.valueOfRecursion.AutoSize = true;
            this.valueOfRecursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfRecursion.Location = new System.Drawing.Point(303, 181);
            this.valueOfRecursion.Name = "valueOfRecursion";
            this.valueOfRecursion.Size = new System.Drawing.Size(19, 20);
            this.valueOfRecursion.TabIndex = 21;
            this.valueOfRecursion.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Максимальная длина рекурсии (до 15):\r\n";
            // 
            // numOnRecursionTrack
            // 
            this.numOnRecursionTrack.Location = new System.Drawing.Point(15, 181);
            this.numOnRecursionTrack.Maximum = 15;
            this.numOnRecursionTrack.Minimum = 1;
            this.numOnRecursionTrack.Name = "numOnRecursionTrack";
            this.numOnRecursionTrack.Size = new System.Drawing.Size(271, 45);
            this.numOnRecursionTrack.TabIndex = 19;
            this.numOnRecursionTrack.Value = 1;
            this.numOnRecursionTrack.ValueChanged += new System.EventHandler(this.numOnRecursionTrack_ValueChanged);
            // 
            // spaceBetweenLinesValue
            // 
            this.spaceBetweenLinesValue.AutoSize = true;
            this.spaceBetweenLinesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.spaceBetweenLinesValue.Location = new System.Drawing.Point(303, 283);
            this.spaceBetweenLinesValue.Name = "spaceBetweenLinesValue";
            this.spaceBetweenLinesValue.Size = new System.Drawing.Size(19, 20);
            this.spaceBetweenLinesValue.TabIndex = 24;
            this.spaceBetweenLinesValue.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(275, 26);
            this.label5.TabIndex = 23;
            this.label5.Text = "Расстояние между следующим уровнем множества:\r\n\r\n";
            // 
            // spaceBetweenLinesTrack
            // 
            this.spaceBetweenLinesTrack.Location = new System.Drawing.Point(15, 283);
            this.spaceBetweenLinesTrack.Maximum = 50;
            this.spaceBetweenLinesTrack.Minimum = 1;
            this.spaceBetweenLinesTrack.Name = "spaceBetweenLinesTrack";
            this.spaceBetweenLinesTrack.Size = new System.Drawing.Size(271, 45);
            this.spaceBetweenLinesTrack.TabIndex = 22;
            this.spaceBetweenLinesTrack.Value = 1;
            this.spaceBetweenLinesTrack.ValueChanged += new System.EventHandler(this.spaceBetweenLinesTrack_ValueChanged);
            // 
            // drawKantorButton
            // 
            this.drawKantorButton.Location = new System.Drawing.Point(15, 355);
            this.drawKantorButton.Name = "drawKantorButton";
            this.drawKantorButton.Size = new System.Drawing.Size(120, 36);
            this.drawKantorButton.TabIndex = 25;
            this.drawKantorButton.Text = "Построить";
            this.drawKantorButton.UseVisualStyleBackColor = true;
            this.drawKantorButton.Click += new System.EventHandler(this.drawKantorButton_Click);
            // 
            // kantorSetPaintPanel
            // 
            this.kantorSetPaintPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.kantorSetPaintPanel.Location = new System.Drawing.Point(628, 0);
            this.kantorSetPaintPanel.Name = "kantorSetPaintPanel";
            this.kantorSetPaintPanel.Size = new System.Drawing.Size(656, 692);
            this.kantorSetPaintPanel.TabIndex = 26;
            // 
            // backFromTree
            // 
            this.backFromTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backFromTree.Location = new System.Drawing.Point(15, 640);
            this.backFromTree.Name = "backFromTree";
            this.backFromTree.Size = new System.Drawing.Size(191, 40);
            this.backFromTree.TabIndex = 29;
            this.backFromTree.Text = "Вернуться в главное меню";
            this.backFromTree.UseVisualStyleBackColor = true;
            this.backFromTree.Click += new System.EventHandler(this.backFromTree_Click);
            // 
            // useColor
            // 
            this.useColor.Location = new System.Drawing.Point(15, 412);
            this.useColor.Name = "useColor";
            this.useColor.Size = new System.Drawing.Size(120, 39);
            this.useColor.TabIndex = 41;
            this.useColor.Text = "Использовать градиент";
            this.useColor.UseVisualStyleBackColor = true;
            this.useColor.Click += new System.EventHandler(this.useColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Введите имя файла(без расширения), \r\nв который хотите сохранить фрактал (он будет" +
    " сохранен в папке с исполняемым файлом):";
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(15, 509);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(120, 20);
            this.saveName.TabIndex = 46;
            // 
            // saveFractal
            // 
            this.saveFractal.Location = new System.Drawing.Point(15, 535);
            this.saveFractal.Name = "saveFractal";
            this.saveFractal.Size = new System.Drawing.Size(120, 39);
            this.saveFractal.TabIndex = 45;
            this.saveFractal.Text = "Сохранить фрактал:";
            this.saveFractal.UseVisualStyleBackColor = true;
            this.saveFractal.Click += new System.EventHandler(this.saveFractal_Click);
            // 
            // KantorSetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.saveFractal);
            this.Controls.Add(this.useColor);
            this.Controls.Add(this.backFromTree);
            this.Controls.Add(this.kantorSetPaintPanel);
            this.Controls.Add(this.drawKantorButton);
            this.Controls.Add(this.spaceBetweenLinesValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.spaceBetweenLinesTrack);
            this.Controls.Add(this.valueOfRecursion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOnRecursionTrack);
            this.Controls.Add(this.valueOfWidthTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthOfLineTrack);
            this.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.MinimumSize = new System.Drawing.Size(1300, 731);
            this.Name = "KantorSetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "KantorSetForm";
            this.Resize += new System.EventHandler(this.KantorSetForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spaceBetweenLinesTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar widthOfLineTrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label valueOfWidthTrack;
        private System.Windows.Forms.Label valueOfRecursion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar numOnRecursionTrack;
        private System.Windows.Forms.Label spaceBetweenLinesValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar spaceBetweenLinesTrack;
        private System.Windows.Forms.Button drawKantorButton;
        private System.Windows.Forms.Panel kantorSetPaintPanel;
        private System.Windows.Forms.Button backFromTree;
        private System.Windows.Forms.Button useColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.Button saveFractal;
    }
}