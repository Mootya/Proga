namespace WindowsFormsApp1
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
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.txtBBrkub1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(242, 153);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(179, 60);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "Бросок кубика";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(524, 311);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(93, 39);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "Сменить фон";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // txtBBrkub1
            // 
            this.txtBBrkub1.Location = new System.Drawing.Point(280, 82);
            this.txtBBrkub1.Name = "txtBBrkub1";
            this.txtBBrkub1.Size = new System.Drawing.Size(100, 20);
            this.txtBBrkub1.TabIndex = 3;
            this.txtBBrkub1.TextChanged += new System.EventHandler(this.txtBBrkub1_TextChanged);
            this.txtBBrkub1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBBrkub1_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 362);
            this.Controls.Add(this.txtBBrkub1);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.BackColorChanged += new System.EventHandler(this.btn2_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.TextBox txtBBrkub1;
    }
}

