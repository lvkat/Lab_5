namespace Lab_5
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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.buttonSerialize = new System.Windows.Forms.Button();
            this.buttonDeserialize = new System.Windows.Forms.Button();
            this.buttonTureen = new System.Windows.Forms.Button();
            this.buttonSteamer = new System.Windows.Forms.Button();
            this.buttonPan = new System.Windows.Forms.Button();
            this.buttonCup = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.openFileDialogSr = new System.Windows.Forms.OpenFileDialog();
            this.buttonAddPlugin = new System.Windows.Forms.Button();
            this.checkBoxExt = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.Location = new System.Drawing.Point(12, 12);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(114, 108);
            this.listBoxItems.TabIndex = 0;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBoxItems_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(70, 135);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(148, 31);
            this.buttonAdd.TabIndex = 1;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(70, 184);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(148, 31);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Редактировать";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(70, 230);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(148, 31);
            this.buttonRemove.TabIndex = 3;
            this.buttonRemove.Text = "Удалить";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // buttonSerialize
            // 
            this.buttonSerialize.Location = new System.Drawing.Point(70, 278);
            this.buttonSerialize.Name = "buttonSerialize";
            this.buttonSerialize.Size = new System.Drawing.Size(148, 31);
            this.buttonSerialize.TabIndex = 4;
            this.buttonSerialize.Text = "Сериализовать ";
            this.buttonSerialize.UseVisualStyleBackColor = true;
            this.buttonSerialize.Click += new System.EventHandler(this.buttonSerialize_Click);
            // 
            // buttonDeserialize
            // 
            this.buttonDeserialize.Location = new System.Drawing.Point(70, 325);
            this.buttonDeserialize.Name = "buttonDeserialize";
            this.buttonDeserialize.Size = new System.Drawing.Size(148, 31);
            this.buttonDeserialize.TabIndex = 5;
            this.buttonDeserialize.Text = "Десериализовать ";
            this.buttonDeserialize.UseVisualStyleBackColor = true;
            this.buttonDeserialize.Click += new System.EventHandler(this.buttonDesirialized_Click);
            // 
            // buttonTureen
            // 
            this.buttonTureen.Location = new System.Drawing.Point(170, 96);
            this.buttonTureen.Name = "buttonTureen";
            this.buttonTureen.Size = new System.Drawing.Size(124, 22);
            this.buttonTureen.TabIndex = 9;
            this.buttonTureen.Text = "Супница";
            this.buttonTureen.UseVisualStyleBackColor = true;
            this.buttonTureen.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonSteamer
            // 
            this.buttonSteamer.Location = new System.Drawing.Point(170, 68);
            this.buttonSteamer.Name = "buttonSteamer";
            this.buttonSteamer.Size = new System.Drawing.Size(124, 22);
            this.buttonSteamer.TabIndex = 8;
            this.buttonSteamer.Text = "Пароварка";
            this.buttonSteamer.UseVisualStyleBackColor = true;
            this.buttonSteamer.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonPan
            // 
            this.buttonPan.Location = new System.Drawing.Point(170, 40);
            this.buttonPan.Name = "buttonPan";
            this.buttonPan.Size = new System.Drawing.Size(124, 22);
            this.buttonPan.TabIndex = 7;
            this.buttonPan.Text = "Сковорода";
            this.buttonPan.UseVisualStyleBackColor = true;
            this.buttonPan.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonCup
            // 
            this.buttonCup.Location = new System.Drawing.Point(170, 12);
            this.buttonCup.Name = "buttonCup";
            this.buttonCup.Size = new System.Drawing.Size(124, 22);
            this.buttonCup.TabIndex = 6;
            this.buttonCup.Text = "Кружка";
            this.buttonCup.UseVisualStyleBackColor = true;
            this.buttonCup.Click += new System.EventHandler(this.button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(303, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(303, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 20);
            this.textBox2.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(300, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(303, 135);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 20);
            this.textBox3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "label4";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(303, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(125, 20);
            this.textBox4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "label5";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(303, 249);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(125, 20);
            this.textBox5.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "label6";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(303, 303);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 20);
            this.textBox6.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(300, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(303, 359);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 20);
            this.textBox7.TabIndex = 22;
            // 
            // openFileDialogSr
            // 
            this.openFileDialogSr.FileName = "openFileDialogSr";
            // 
            // buttonAddPlugin
            // 
            this.buttonAddPlugin.Location = new System.Drawing.Point(245, 304);
            this.buttonAddPlugin.Name = "buttonAddPlugin";
            this.buttonAddPlugin.Size = new System.Drawing.Size(37, 55);
            this.buttonAddPlugin.TabIndex = 24;
            this.buttonAddPlugin.Text = "button1";
            this.buttonAddPlugin.UseVisualStyleBackColor = true;
            this.buttonAddPlugin.Click += new System.EventHandler(this.buttonAddPlugin_Click);
            // 
            // checkBoxExt
            // 
            this.checkBoxExt.AutoSize = true;
            this.checkBoxExt.Location = new System.Drawing.Point(70, 362);
            this.checkBoxExt.Name = "checkBoxExt";
            this.checkBoxExt.Size = new System.Drawing.Size(80, 17);
            this.checkBoxExt.TabIndex = 25;
            this.checkBoxExt.Text = "checkBox1";
            this.checkBoxExt.UseVisualStyleBackColor = true;
            this.checkBoxExt.Visible = false;
            this.checkBoxExt.CheckedChanged += new System.EventHandler(this.checkBoxExt_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 389);
            this.Controls.Add(this.checkBoxExt);
            this.Controls.Add(this.buttonAddPlugin);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonTureen);
            this.Controls.Add(this.buttonSteamer);
            this.Controls.Add(this.buttonPan);
            this.Controls.Add(this.buttonCup);
            this.Controls.Add(this.buttonDeserialize);
            this.Controls.Add(this.buttonSerialize);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.Button buttonSerialize;
        private System.Windows.Forms.Button buttonDeserialize;
        private System.Windows.Forms.Button buttonTureen;
        private System.Windows.Forms.Button buttonSteamer;
        private System.Windows.Forms.Button buttonPan;
        private System.Windows.Forms.Button buttonCup;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.OpenFileDialog openFileDialogSr;
        private System.Windows.Forms.Button buttonAddPlugin;
        private System.Windows.Forms.CheckBox checkBoxExt;
    }
}

