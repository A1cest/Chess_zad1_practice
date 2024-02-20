namespace Zad1_Chess_Kamentseva
{
    partial class ChessCoordinates
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
            this.textBox_coordinates = new System.Windows.Forms.TextBox();
            this.coordinates = new System.Windows.Forms.Label();
            this.button1_СalculationСoordinates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_coordinates
            // 
            this.textBox_coordinates.Location = new System.Drawing.Point(29, 53);
            this.textBox_coordinates.Multiline = true;
            this.textBox_coordinates.Name = "textBox_coordinates";
            this.textBox_coordinates.Size = new System.Drawing.Size(310, 83);
            this.textBox_coordinates.TabIndex = 0;
            this.textBox_coordinates.TextChanged += new System.EventHandler(this.textBox_coordinates_TextChanged);
            // 
            // coordinates
            // 
            this.coordinates.AutoSize = true;
            this.coordinates.Location = new System.Drawing.Point(90, 18);
            this.coordinates.Name = "coordinates";
            this.coordinates.Size = new System.Drawing.Size(185, 16);
            this.coordinates.TabIndex = 1;
            this.coordinates.Text = "Кординаты фигуры и ладьи";
            this.coordinates.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1_СalculationСoordinates
            // 
            this.button1_СalculationСoordinates.Location = new System.Drawing.Point(142, 170);
            this.button1_СalculationСoordinates.Name = "button1_СalculationСoordinates";
            this.button1_СalculationСoordinates.Size = new System.Drawing.Size(75, 23);
            this.button1_СalculationСoordinates.TabIndex = 4;
            this.button1_СalculationСoordinates.Text = "Рассчет";
            this.button1_СalculationСoordinates.UseVisualStyleBackColor = true;
            this.button1_СalculationСoordinates.Click += new System.EventHandler(this.button1_СalculationСoordinates_Click);
            // 
            // ChessCoordinates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 207);
            this.Controls.Add(this.button1_СalculationСoordinates);
            this.Controls.Add(this.coordinates);
            this.Controls.Add(this.textBox_coordinates);
            this.Name = "ChessCoordinates";
            this.Text = "Chess coordinates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_coordinates;
        private System.Windows.Forms.Label coordinates;
        private System.Windows.Forms.Button button1_СalculationСoordinates;
    }
}

