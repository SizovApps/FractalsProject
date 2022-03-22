namespace FractalsProject
{
    partial class TriangleForm
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
            this.components = new System.ComponentModel.Container();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.drawButton = new System.Windows.Forms.Button();
            this.valueOfRecursion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numOnRecursionTrack = new System.Windows.Forms.TrackBar();
            this.valueOfWidthTrack = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthOfLineTrack = new System.Windows.Forms.TrackBar();
            this.backToMenu = new System.Windows.Forms.Button();
            this.useColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFractal = new System.Windows.Forms.Button();
            this.saveName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // paintPanel
            // 
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.paintPanel.Location = new System.Drawing.Point(628, 0);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(656, 692);
            this.paintPanel.TabIndex = 38;
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(9, 232);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(120, 36);
            this.drawButton.TabIndex = 37;
            this.drawButton.Text = "Построить";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.drawButton_Click);
            // 
            // valueOfRecursion
            // 
            this.valueOfRecursion.AutoSize = true;
            this.valueOfRecursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfRecursion.Location = new System.Drawing.Point(297, 181);
            this.valueOfRecursion.Name = "valueOfRecursion";
            this.valueOfRecursion.Size = new System.Drawing.Size(19, 20);
            this.valueOfRecursion.TabIndex = 33;
            this.valueOfRecursion.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Максимальная длина рекурсии (до 7):\r\n";
            // 
            // numOnRecursionTrack
            // 
            this.numOnRecursionTrack.Location = new System.Drawing.Point(9, 181);
            this.numOnRecursionTrack.Maximum = 7;
            this.numOnRecursionTrack.Minimum = 1;
            this.numOnRecursionTrack.Name = "numOnRecursionTrack";
            this.numOnRecursionTrack.Size = new System.Drawing.Size(271, 45);
            this.numOnRecursionTrack.TabIndex = 31;
            this.numOnRecursionTrack.Value = 1;
            this.numOnRecursionTrack.ValueChanged += new System.EventHandler(this.numOnRecursionTrack_ValueChanged);
            // 
            // valueOfWidthTrack
            // 
            this.valueOfWidthTrack.AutoSize = true;
            this.valueOfWidthTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfWidthTrack.Location = new System.Drawing.Point(297, 83);
            this.valueOfWidthTrack.Name = "valueOfWidthTrack";
            this.valueOfWidthTrack.Size = new System.Drawing.Size(29, 20);
            this.valueOfWidthTrack.TabIndex = 30;
            this.valueOfWidthTrack.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(443, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Первоначальная длина отрезка (не меньше 10 и не более половины ширины экрана):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Задайте данные для создания треугольника Серпинского:";
            // 
            // widthOfLineTrack
            // 
            this.widthOfLineTrack.Location = new System.Drawing.Point(9, 83);
            this.widthOfLineTrack.Maximum = 500;
            this.widthOfLineTrack.Minimum = 10;
            this.widthOfLineTrack.Name = "widthOfLineTrack";
            this.widthOfLineTrack.Size = new System.Drawing.Size(271, 45);
            this.widthOfLineTrack.TabIndex = 27;
            this.widthOfLineTrack.Value = 10;
            this.widthOfLineTrack.ValueChanged += new System.EventHandler(this.widthOfLineTrack_ValueChanged);
            // 
            // backToMenu
            // 
            this.backToMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backToMenu.Location = new System.Drawing.Point(9, 640);
            this.backToMenu.Name = "backToMenu";
            this.backToMenu.Size = new System.Drawing.Size(191, 40);
            this.backToMenu.TabIndex = 39;
            this.backToMenu.Text = "Вернуться в главное меню";
            this.backToMenu.UseVisualStyleBackColor = true;
            this.backToMenu.Click += new System.EventHandler(this.backToMenu_Click);
            // 
            // useColor
            // 
            this.useColor.Location = new System.Drawing.Point(9, 295);
            this.useColor.Name = "useColor";
            this.useColor.Size = new System.Drawing.Size(120, 39);
            this.useColor.TabIndex = 40;
            this.useColor.Text = "Использовать градиент";
            this.useColor.UseVisualStyleBackColor = true;
            this.useColor.Click += new System.EventHandler(this.useColor_Click);
            // 
            // saveFractal
            // 
            this.saveFractal.Location = new System.Drawing.Point(9, 467);
            this.saveFractal.Name = "saveFractal";
            this.saveFractal.Size = new System.Drawing.Size(120, 39);
            this.saveFractal.TabIndex = 41;
            this.saveFractal.Text = "Сохранить фрактал:";
            this.saveFractal.UseVisualStyleBackColor = true;
            this.saveFractal.Click += new System.EventHandler(this.saveFractal_Click);
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(9, 441);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(120, 20);
            this.saveName.TabIndex = 42;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 407);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 26);
            this.label3.TabIndex = 44;
            this.label3.Text = "Введите имя файла(без расширения), \r\nв который хотите сохранить фрактал (он будет" +
    " сохранен в папке с исполняемым файлом):";
            // 
            // TriangleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.saveFractal);
            this.Controls.Add(this.useColor);
            this.Controls.Add(this.backToMenu);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.valueOfRecursion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOnRecursionTrack);
            this.Controls.Add(this.valueOfWidthTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthOfLineTrack);
            this.MinimumSize = new System.Drawing.Size(1300, 731);
            this.Name = "TriangleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TriangleForm";
            this.Resize += new System.EventHandler(this.TriangleForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Label valueOfRecursion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar numOnRecursionTrack;
        private System.Windows.Forms.Label valueOfWidthTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar widthOfLineTrack;
        private System.Windows.Forms.Button backToMenu;
        private System.Windows.Forms.Button useColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button saveFractal;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label3;
    }
}