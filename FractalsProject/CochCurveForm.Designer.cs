namespace FractalsProject
{
    partial class CochCurveForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.numOnRecursionTrack = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.widthOfLineTrack = new System.Windows.Forms.TrackBar();
            this.paintPanel = new System.Windows.Forms.Panel();
            this.valueOfRecursion = new System.Windows.Forms.Label();
            this.valueOfWidthTrack = new System.Windows.Forms.Label();
            this.backFromCurve = new System.Windows.Forms.Button();
            this.drawCurveButton = new System.Windows.Forms.Button();
            this.useColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.saveName = new System.Windows.Forms.TextBox();
            this.saveFractal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Максимальная длина рекурсии (до 15):\r\n";
            // 
            // numOnRecursionTrack
            // 
            this.numOnRecursionTrack.Location = new System.Drawing.Point(15, 181);
            this.numOnRecursionTrack.Maximum = 15;
            this.numOnRecursionTrack.Minimum = 1;
            this.numOnRecursionTrack.Name = "numOnRecursionTrack";
            this.numOnRecursionTrack.Size = new System.Drawing.Size(271, 45);
            this.numOnRecursionTrack.TabIndex = 24;
            this.numOnRecursionTrack.Value = 1;
            this.numOnRecursionTrack.ValueChanged += new System.EventHandler(this.numOnRecursionTrack_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Первоначальная длина отрезка (не меньше 10 и не более половины экрана):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Задайте данные для создания кривой Коха:\r\n";
            // 
            // widthOfLineTrack
            // 
            this.widthOfLineTrack.Location = new System.Drawing.Point(15, 83);
            this.widthOfLineTrack.Maximum = 500;
            this.widthOfLineTrack.Minimum = 10;
            this.widthOfLineTrack.Name = "widthOfLineTrack";
            this.widthOfLineTrack.Size = new System.Drawing.Size(271, 45);
            this.widthOfLineTrack.TabIndex = 21;
            this.widthOfLineTrack.Value = 10;
            this.widthOfLineTrack.ValueChanged += new System.EventHandler(this.widthOfLineTrack_ValueChanged);
            // 
            // paintPanel
            // 
            this.paintPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.paintPanel.Location = new System.Drawing.Point(723, 0);
            this.paintPanel.Name = "paintPanel";
            this.paintPanel.Size = new System.Drawing.Size(561, 692);
            this.paintPanel.TabIndex = 26;
            // 
            // valueOfRecursion
            // 
            this.valueOfRecursion.AutoSize = true;
            this.valueOfRecursion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfRecursion.Location = new System.Drawing.Point(292, 181);
            this.valueOfRecursion.Name = "valueOfRecursion";
            this.valueOfRecursion.Size = new System.Drawing.Size(19, 20);
            this.valueOfRecursion.TabIndex = 28;
            this.valueOfRecursion.Text = "1";
            // 
            // valueOfWidthTrack
            // 
            this.valueOfWidthTrack.AutoSize = true;
            this.valueOfWidthTrack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.valueOfWidthTrack.Location = new System.Drawing.Point(292, 83);
            this.valueOfWidthTrack.Name = "valueOfWidthTrack";
            this.valueOfWidthTrack.Size = new System.Drawing.Size(29, 20);
            this.valueOfWidthTrack.TabIndex = 27;
            this.valueOfWidthTrack.Text = "10";
            // 
            // backFromCurve
            // 
            this.backFromCurve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backFromCurve.Location = new System.Drawing.Point(15, 640);
            this.backFromCurve.Name = "backFromCurve";
            this.backFromCurve.Size = new System.Drawing.Size(191, 40);
            this.backFromCurve.TabIndex = 31;
            this.backFromCurve.Text = "Вернуться в главное меню";
            this.backFromCurve.UseVisualStyleBackColor = true;
            this.backFromCurve.Click += new System.EventHandler(this.backFromCurve_Click);
            // 
            // drawCurveButton
            // 
            this.drawCurveButton.Location = new System.Drawing.Point(15, 232);
            this.drawCurveButton.Name = "drawCurveButton";
            this.drawCurveButton.Size = new System.Drawing.Size(120, 36);
            this.drawCurveButton.TabIndex = 30;
            this.drawCurveButton.Text = "Построить";
            this.drawCurveButton.UseVisualStyleBackColor = true;
            this.drawCurveButton.Click += new System.EventHandler(this.drawCurveButton_Click);
            // 
            // useColor
            // 
            this.useColor.Location = new System.Drawing.Point(15, 290);
            this.useColor.Name = "useColor";
            this.useColor.Size = new System.Drawing.Size(120, 39);
            this.useColor.TabIndex = 32;
            this.useColor.Text = "Использовать градиент";
            this.useColor.UseVisualStyleBackColor = true;
            this.useColor.Click += new System.EventHandler(this.useColor_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(470, 26);
            this.label3.TabIndex = 47;
            this.label3.Text = "Введите имя файла(без расширения), \r\nв который хотите сохранить фрактал (он будет" +
    " сохранен в папке с исполняемым файлом):";
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(15, 401);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(120, 20);
            this.saveName.TabIndex = 46;
            // 
            // saveFractal
            // 
            this.saveFractal.Location = new System.Drawing.Point(15, 427);
            this.saveFractal.Name = "saveFractal";
            this.saveFractal.Size = new System.Drawing.Size(120, 39);
            this.saveFractal.TabIndex = 45;
            this.saveFractal.Text = "Сохранить фрактал:";
            this.saveFractal.UseVisualStyleBackColor = true;
            this.saveFractal.Click += new System.EventHandler(this.saveFractal_Click);
            // 
            // CochCurveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.saveFractal);
            this.Controls.Add(this.useColor);
            this.Controls.Add(this.backFromCurve);
            this.Controls.Add(this.drawCurveButton);
            this.Controls.Add(this.valueOfRecursion);
            this.Controls.Add(this.valueOfWidthTrack);
            this.Controls.Add(this.paintPanel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numOnRecursionTrack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.widthOfLineTrack);
            this.MinimumSize = new System.Drawing.Size(1300, 731);
            this.Name = "CochCurveForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CochCurveForm";
            this.Resize += new System.EventHandler(this.CochCurveForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numOnRecursionTrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthOfLineTrack)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar numOnRecursionTrack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar widthOfLineTrack;
        private System.Windows.Forms.Panel paintPanel;
        private System.Windows.Forms.Label valueOfRecursion;
        private System.Windows.Forms.Label valueOfWidthTrack;
        private System.Windows.Forms.Button backFromCurve;
        private System.Windows.Forms.Button drawCurveButton;
        private System.Windows.Forms.Button useColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.Button saveFractal;
    }
}