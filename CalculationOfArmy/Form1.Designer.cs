namespace CalculationOfArmy
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
            this.lbArmy = new System.Windows.Forms.ListBox();
            this.btnGetResult = new System.Windows.Forms.Button();
            this.btnGenerateArmy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbArmy
            // 
            this.lbArmy.FormattingEnabled = true;
            this.lbArmy.ItemHeight = 20;
            this.lbArmy.Location = new System.Drawing.Point(12, 12);
            this.lbArmy.Name = "lbArmy";
            this.lbArmy.Size = new System.Drawing.Size(734, 384);
            this.lbArmy.TabIndex = 0;
            // 
            // btnGetResult
            // 
            this.btnGetResult.Location = new System.Drawing.Point(532, 414);
            this.btnGetResult.Name = "btnGetResult";
            this.btnGetResult.Size = new System.Drawing.Size(214, 28);
            this.btnGetResult.TabIndex = 1;
            this.btnGetResult.Text = "Отримати результат";
            this.btnGetResult.UseVisualStyleBackColor = true;
            this.btnGetResult.Click += new System.EventHandler(this.btnGetResult_Click);
            // 
            // btnGenerateArmy
            // 
            this.btnGenerateArmy.Location = new System.Drawing.Point(12, 414);
            this.btnGenerateArmy.Name = "btnGenerateArmy";
            this.btnGenerateArmy.Size = new System.Drawing.Size(214, 28);
            this.btnGenerateArmy.TabIndex = 1;
            this.btnGenerateArmy.Text = "Згенерувати армію";
            this.btnGenerateArmy.UseVisualStyleBackColor = true;
            this.btnGenerateArmy.Click += new System.EventHandler(this.btnGenerateArmy_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 465);
            this.Controls.Add(this.btnGenerateArmy);
            this.Controls.Add(this.btnGetResult);
            this.Controls.Add(this.lbArmy);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Army Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbArmy;
        private System.Windows.Forms.Button btnGetResult;
        private System.Windows.Forms.Button btnGenerateArmy;
    }
}

