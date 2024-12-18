using System.Drawing;
using System.Windows.Forms;

namespace ComputerGraphics_Filters
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.file_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAs_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undo_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.repeat_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.invert_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grayScale_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.binarization_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increaseBrightness_ЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decreaseBrightness_ЯркостьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.increase_contrast_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.decrease_contrast_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cancel_button = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.file_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1582, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // file_ToolStripMenuItem
            // 
            this.file_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_ToolStripMenuItem,
            this.saveAs_ToolStripMenuItem});
            this.file_ToolStripMenuItem.Name = "file_ToolStripMenuItem";
            this.file_ToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.file_ToolStripMenuItem.Text = "Файл";
            // 
            // open_ToolStripMenuItem
            // 
            this.open_ToolStripMenuItem.Name = "open_ToolStripMenuItem";
            this.open_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_ToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.open_ToolStripMenuItem.Text = "Открыть";
            this.open_ToolStripMenuItem.Click += new System.EventHandler(this.Open_ToolStripMenuItem_Click);
            // 
            // saveAs_ToolStripMenuItem
            // 
            this.saveAs_ToolStripMenuItem.Name = "saveAs_ToolStripMenuItem";
            this.saveAs_ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAs_ToolStripMenuItem.Size = new System.Drawing.Size(261, 26);
            this.saveAs_ToolStripMenuItem.Text = "Сохранить как...";
            this.saveAs_ToolStripMenuItem.Click += new System.EventHandler(this.Save_as_ToolStripMenuItem_Click);
            // 
            // undo_ToolStripMenuItem
            // 
            this.undo_ToolStripMenuItem.Name = "undo_ToolStripMenuItem";
            this.undo_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // repeat_ToolStripMenuItem
            // 
            this.repeat_ToolStripMenuItem.Name = "repeat_ToolStripMenuItem";
            this.repeat_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // invert_ToolStripMenuItem
            // 
            this.invert_ToolStripMenuItem.Name = "invert_ToolStripMenuItem";
            this.invert_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // grayScale_ToolStripMenuItem
            // 
            this.grayScale_ToolStripMenuItem.Name = "grayScale_ToolStripMenuItem";
            this.grayScale_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // binarization_ToolStripMenuItem
            // 
            this.binarization_ToolStripMenuItem.Name = "binarization_ToolStripMenuItem";
            this.binarization_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // increaseBrightness_ЯркостьToolStripMenuItem
            // 
            this.increaseBrightness_ЯркостьToolStripMenuItem.Name = "increaseBrightness_ЯркостьToolStripMenuItem";
            this.increaseBrightness_ЯркостьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // decreaseBrightness_ЯркостьToolStripMenuItem
            // 
            this.decreaseBrightness_ЯркостьToolStripMenuItem.Name = "decreaseBrightness_ЯркостьToolStripMenuItem";
            this.decreaseBrightness_ЯркостьToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // increase_contrast_ToolStripMenuItem
            // 
            this.increase_contrast_ToolStripMenuItem.Name = "increase_contrast_ToolStripMenuItem";
            this.increase_contrast_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // decrease_contrast_ToolStripMenuItem
            // 
            this.decrease_contrast_ToolStripMenuItem.Name = "decrease_contrast_ToolStripMenuItem";
            this.decrease_contrast_ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image files | *.png; *.jpg; *.bmp; | All files(*.*) | *.*";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "filename.png";
            this.saveFileDialog1.Filter = "Image files | *.png; *.jpg; *.bmp; | All files(*.*) | *.*";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.amountTextBox.Location = new System.Drawing.Point(1256, 866);
            this.amountTextBox.Margin = new System.Windows.Forms.Padding(10);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(147, 22);
            this.amountTextBox.TabIndex = 4;
            this.amountTextBox.Text = "50";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Label1.Location = new System.Drawing.Point(1007, 866);
            this.Label1.Margin = new System.Windows.Forms.Padding(10);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(229, 49);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Параметры преобразований: ";
            // 
            // cancel_button
            // 
            this.cancel_button.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cancel_button.Location = new System.Drawing.Point(1256, 791);
            this.cancel_button.Margin = new System.Windows.Forms.Padding(10);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(147, 55);
            this.cancel_button.TabIndex = 3;
            this.cancel_button.Text = "Отмена";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.Repeat_ToolStripMenuItem_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox2, 3);
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(1007, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(10, 0, 20, 100);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(555, 681);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.tableLayoutPanel1.SetColumnSpan(this.pictureBox1, 4);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(20, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(20, 0, 50, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(927, 681);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 234F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 282F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 249F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 167F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169F));
            this.tableLayoutPanel1.Controls.Add(this.button6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.cancel_button, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Label1, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button4, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.amountTextBox, 5, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1582, 925);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Location = new System.Drawing.Point(10, 866);
            this.button6.Margin = new System.Windows.Forms.Padding(10);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(209, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "Уменьшить контрастность";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(239, 866);
            this.button5.Margin = new System.Windows.Forms.Padding(10);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(214, 49);
            this.button5.TabIndex = 9;
            this.button5.Text = "Увеличить контрастность";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(10, 791);
            this.button1.Margin = new System.Windows.Forms.Padding(10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Негатив";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(239, 791);
            this.button2.Margin = new System.Windows.Forms.Padding(10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 55);
            this.button2.TabIndex = 6;
            this.button2.Text = "Увеличить яркость";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(473, 791);
            this.button3.Margin = new System.Windows.Forms.Padding(10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(232, 55);
            this.button3.TabIndex = 7;
            this.button3.Text = "Уменьшить яркость";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(725, 791);
            this.button4.Margin = new System.Windows.Forms.Padding(10);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(262, 55);
            this.button4.TabIndex = 8;
            this.button4.Text = "Оттенки серого";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 953);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "Form1";
            this.Text = "Обработка изображений";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem file_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem invert_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_ToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem grayScale_ToolStripMenuItem; 
        private System.Windows.Forms.ToolStripMenuItem binarization_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAs_ToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem increaseBrightness_ЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decreaseBrightness_ЯркостьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem increase_contrast_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem decrease_contrast_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undo_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem repeat_ToolStripMenuItem;
        private TextBox amountTextBox;
        private Label Label1;
        private Button cancel_button;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button6;
        private Button button5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}

