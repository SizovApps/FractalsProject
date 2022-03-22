namespace FractalsProject
{
    partial class TreesForm
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
            this.backFromTree = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.treeRecursionLenInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.treeLenInput = new System.Windows.Forms.TextBox();
            this.treeConfirm = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.secondTreeAngleInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstTreeAngleInput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.treeCoefInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.treePaintPanel = new System.Windows.Forms.Panel();
            this.useColor = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.saveName = new System.Windows.Forms.TextBox();
            this.saveFractal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backFromTree
            // 
            this.backFromTree.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.backFromTree.Location = new System.Drawing.Point(6, 624);
            this.backFromTree.Name = "backFromTree";
            this.backFromTree.Size = new System.Drawing.Size(191, 40);
            this.backFromTree.TabIndex = 28;
            this.backFromTree.Text = "Вернуться в главное меню";
            this.backFromTree.UseVisualStyleBackColor = true;
            this.backFromTree.Click += new System.EventHandler(this.backFromTree_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Максимальная глубина рекурсии (не больше 15):";
            // 
            // treeRecursionLenInput
            // 
            this.treeRecursionLenInput.Location = new System.Drawing.Point(8, 319);
            this.treeRecursionLenInput.Name = "treeRecursionLenInput";
            this.treeRecursionLenInput.Size = new System.Drawing.Size(100, 20);
            this.treeRecursionLenInput.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 232);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(400, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Первоначальная длина отрезка (не меньше 10 и не более половины экрана):";
            // 
            // treeLenInput
            // 
            this.treeLenInput.Location = new System.Drawing.Point(8, 258);
            this.treeLenInput.Name = "treeLenInput";
            this.treeLenInput.Size = new System.Drawing.Size(100, 20);
            this.treeLenInput.TabIndex = 23;
            // 
            // treeConfirm
            // 
            this.treeConfirm.Location = new System.Drawing.Point(8, 355);
            this.treeConfirm.Name = "treeConfirm";
            this.treeConfirm.Size = new System.Drawing.Size(120, 36);
            this.treeConfirm.TabIndex = 22;
            this.treeConfirm.Text = "Построить\r\n";
            this.treeConfirm.UseVisualStyleBackColor = true;
            this.treeConfirm.Click += new System.EventHandler(this.treeConfirm_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Угол наклона второго отрезка в градусах:";
            // 
            // secondTreeAngleInput
            // 
            this.secondTreeAngleInput.Location = new System.Drawing.Point(8, 195);
            this.secondTreeAngleInput.Name = "secondTreeAngleInput";
            this.secondTreeAngleInput.Size = new System.Drawing.Size(100, 20);
            this.secondTreeAngleInput.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Угол наклона первого отрезка в градусах:";
            // 
            // firstTreeAngleInput
            // 
            this.firstTreeAngleInput.Location = new System.Drawing.Point(8, 130);
            this.firstTreeAngleInput.Name = "firstTreeAngleInput";
            this.firstTreeAngleInput.Size = new System.Drawing.Size(100, 20);
            this.firstTreeAngleInput.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(562, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Коэффициент, определяющий отношение длин отрезков на текущей и последующей итерац" +
    "ии (от 0,1 до 0,9):\r\n";
            // 
            // treeCoefInput
            // 
            this.treeCoefInput.Location = new System.Drawing.Point(8, 66);
            this.treeCoefInput.Name = "treeCoefInput";
            this.treeCoefInput.Size = new System.Drawing.Size(100, 20);
            this.treeCoefInput.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Задайте данные для создания дерева:";
            // 
            // treePaintPanel
            // 
            this.treePaintPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treePaintPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.treePaintPanel.Location = new System.Drawing.Point(577, 0);
            this.treePaintPanel.Name = "treePaintPanel";
            this.treePaintPanel.Size = new System.Drawing.Size(707, 692);
            this.treePaintPanel.TabIndex = 27;
            // 
            // useColor
            // 
            this.useColor.Location = new System.Drawing.Point(189, 355);
            this.useColor.Name = "useColor";
            this.useColor.Size = new System.Drawing.Size(120, 36);
            this.useColor.TabIndex = 29;
            this.useColor.Text = "Использовать градиент";
            this.useColor.UseVisualStyleBackColor = true;
            this.useColor.Click += new System.EventHandler(this.useColor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(470, 26);
            this.label7.TabIndex = 47;
            this.label7.Text = "Введите имя файла(без расширения), \r\nв который хотите сохранить фрактал (он будет" +
    " сохранен в папке с исполняемым файлом):";
            // 
            // saveName
            // 
            this.saveName.Location = new System.Drawing.Point(8, 476);
            this.saveName.Name = "saveName";
            this.saveName.Size = new System.Drawing.Size(120, 20);
            this.saveName.TabIndex = 46;
            // 
            // saveFractal
            // 
            this.saveFractal.Location = new System.Drawing.Point(8, 502);
            this.saveFractal.Name = "saveFractal";
            this.saveFractal.Size = new System.Drawing.Size(120, 39);
            this.saveFractal.TabIndex = 45;
            this.saveFractal.Text = "Сохранить фрактал:";
            this.saveFractal.UseVisualStyleBackColor = true;
            this.saveFractal.Click += new System.EventHandler(this.saveFractal_Click);
            // 
            // TreesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 692);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveName);
            this.Controls.Add(this.saveFractal);
            this.Controls.Add(this.useColor);
            this.Controls.Add(this.backFromTree);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.treeRecursionLenInput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.treeLenInput);
            this.Controls.Add(this.treeConfirm);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.secondTreeAngleInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.firstTreeAngleInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.treeCoefInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treePaintPanel);
            this.MaximumSize = new System.Drawing.Size(5000, 5000);
            this.MinimumSize = new System.Drawing.Size(1300, 731);
            this.Name = "TreesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "TreesForm";
            this.ResizeEnd += new System.EventHandler(this.TreesForm_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backFromTree;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox treeRecursionLenInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox treeLenInput;
        private System.Windows.Forms.Button treeConfirm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondTreeAngleInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstTreeAngleInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox treeCoefInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel treePaintPanel;
        private System.Windows.Forms.Button useColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox saveName;
        private System.Windows.Forms.Button saveFractal;
    }
}