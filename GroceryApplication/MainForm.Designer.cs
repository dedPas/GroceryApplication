
namespace GroceryApplication
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddItem = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.UpdateItem = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.ShareList = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(101, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(0, 0);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.UpdateItem);
            this.panel1.Controls.Add(this.RemoveItem);
            this.panel1.Controls.Add(this.AddItem);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.ItemPrice);
            this.panel1.Controls.Add(this.ItemQuantity);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 219);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CloseForm);
            this.panel2.Controls.Add(this.SaveList);
            this.panel2.Controls.Add(this.ShareList);
            this.panel2.Controls.Add(this.LoadList);
            this.panel2.Location = new System.Drawing.Point(12, 237);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 225);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(350, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 300);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(350, 312);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(691, 150);
            this.panel4.TabIndex = 4;
            // 
            // ItemName
            // 
            this.ItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName.Location = new System.Drawing.Point(112, 15);
            this.ItemName.MaxLength = 25;
            this.ItemName.Name = "ItemName";
            this.ItemName.Size = new System.Drawing.Size(203, 26);
            this.ItemName.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 2;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.Location = new System.Drawing.Point(112, 81);
            this.ItemQuantity.MaxLength = 2;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(49, 26);
            this.ItemQuantity.TabIndex = 2;
            // 
            // ItemPrice
            // 
            this.ItemPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemPrice.Location = new System.Drawing.Point(112, 48);
            this.ItemPrice.MaxLength = 6;
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.Size = new System.Drawing.Size(111, 26);
            this.ItemPrice.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(112, 114);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 24);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Taxable Item";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Item Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Price:";
            // 
            // AddItem
            // 
            this.AddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.Location = new System.Drawing.Point(19, 150);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(93, 50);
            this.AddItem.TabIndex = 9;
            this.AddItem.Text = "Add";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItem_Click);
            // 
            // RemoveItem
            // 
            this.RemoveItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem.Location = new System.Drawing.Point(122, 150);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(90, 50);
            this.RemoveItem.TabIndex = 10;
            this.RemoveItem.Text = "Remove";
            this.RemoveItem.UseVisualStyleBackColor = true;
            // 
            // UpdateItem
            // 
            this.UpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateItem.Location = new System.Drawing.Point(222, 150);
            this.UpdateItem.Name = "UpdateItem";
            this.UpdateItem.Size = new System.Drawing.Size(93, 50);
            this.UpdateItem.TabIndex = 11;
            this.UpdateItem.Text = "Update";
            this.UpdateItem.UseVisualStyleBackColor = true;
            // 
            // LoadList
            // 
            this.LoadList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadList.Location = new System.Drawing.Point(3, 6);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(329, 50);
            this.LoadList.TabIndex = 10;
            this.LoadList.Text = "Load";
            this.LoadList.UseVisualStyleBackColor = true;
            // 
            // ShareList
            // 
            this.ShareList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareList.Location = new System.Drawing.Point(3, 112);
            this.ShareList.Name = "ShareList";
            this.ShareList.Size = new System.Drawing.Size(329, 50);
            this.ShareList.TabIndex = 11;
            this.ShareList.Text = "Share";
            this.ShareList.UseVisualStyleBackColor = true;
            // 
            // SaveList
            // 
            this.SaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveList.Location = new System.Drawing.Point(3, 59);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(329, 50);
            this.SaveList.TabIndex = 12;
            this.SaveList.Text = "Save";
            this.SaveList.UseVisualStyleBackColor = true;
            // 
            // CloseForm
            // 
            this.CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.Location = new System.Drawing.Point(4, 165);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(328, 50);
            this.CloseForm.TabIndex = 13;
            this.CloseForm.Text = "Close";
            this.CloseForm.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(688, 297);
            this.dataGridView1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Item Name:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Item Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Item Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Item Name:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 644);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "Grocery List";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox ItemPrice;
        private System.Windows.Forms.TextBox ItemQuantity;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox ItemName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.Button UpdateItem;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.Button ShareList;
        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

