
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
            this.UpdateItem = new System.Windows.Forms.Button();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Taxable = new System.Windows.Forms.CheckBox();
            this.ItemPrice = new System.Windows.Forms.TextBox();
            this.ItemQuantity = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.ItemName = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseForm = new System.Windows.Forms.Button();
            this.SaveList = new System.Windows.Forms.Button();
            this.ShareList = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TaxableItems = new System.Windows.Forms.Label();
            this.SubTotal = new System.Windows.Forms.Label();
            this.TotalItems = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel4.SuspendLayout();
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
            this.panel1.Controls.Add(this.Taxable);
            this.panel1.Controls.Add(this.ItemPrice);
            this.panel1.Controls.Add(this.ItemQuantity);
            this.panel1.Controls.Add(this.textBox3);
            this.panel1.Controls.Add(this.ItemName);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 219);
            this.panel1.TabIndex = 1;
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
            this.UpdateItem.Click += new System.EventHandler(this.UpdateItem_Click);
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
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItem_Click);
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
            // Taxable
            // 
            this.Taxable.AutoSize = true;
            this.Taxable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taxable.Location = new System.Drawing.Point(112, 114);
            this.Taxable.Name = "Taxable";
            this.Taxable.Size = new System.Drawing.Size(119, 24);
            this.Taxable.TabIndex = 3;
            this.Taxable.Text = "Taxable Item";
            this.Taxable.UseVisualStyleBackColor = true;
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
            // ItemQuantity
            // 
            this.ItemQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemQuantity.Location = new System.Drawing.Point(112, 81);
            this.ItemQuantity.MaxLength = 2;
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.Size = new System.Drawing.Size(49, 26);
            this.ItemQuantity.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(112, 63);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(0, 20);
            this.textBox3.TabIndex = 2;
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
            // CloseForm
            // 
            this.CloseForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseForm.Location = new System.Drawing.Point(4, 165);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(328, 50);
            this.CloseForm.TabIndex = 13;
            this.CloseForm.Text = "Close";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // SaveList
            // 
            this.SaveList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveList.Location = new System.Drawing.Point(3, 59);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(329, 50);
            this.SaveList.TabIndex = 11;
            this.SaveList.Text = "Save";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // ShareList
            // 
            this.ShareList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareList.Location = new System.Drawing.Point(3, 112);
            this.ShareList.Name = "ShareList";
            this.ShareList.Size = new System.Drawing.Size(329, 50);
            this.ShareList.TabIndex = 12;
            this.ShareList.Text = "Share";
            this.ShareList.UseVisualStyleBackColor = true;
            this.ShareList.Click += new System.EventHandler(this.ShareList_Click);
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
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridView1);
            this.panel3.Location = new System.Drawing.Point(350, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(475, 281);
            this.panel3.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 15);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 266);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.TaxableItems);
            this.panel4.Controls.Add(this.SubTotal);
            this.panel4.Controls.Add(this.TotalItems);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(350, 296);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(475, 166);
            this.panel4.TabIndex = 4;
            // 
            // TaxableItems
            // 
            this.TaxableItems.AutoSize = true;
            this.TaxableItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxableItems.Location = new System.Drawing.Point(288, 63);
            this.TaxableItems.Name = "TaxableItems";
            this.TaxableItems.Size = new System.Drawing.Size(20, 24);
            this.TaxableItems.TabIndex = 17;
            this.TaxableItems.Text = "0";
            // 
            // SubTotal
            // 
            this.SubTotal.AutoSize = true;
            this.SubTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubTotal.Location = new System.Drawing.Point(288, 93);
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.Size = new System.Drawing.Size(55, 24);
            this.SubTotal.TabIndex = 16;
            this.SubTotal.Text = "$0.00";
            // 
            // TotalItems
            // 
            this.TotalItems.AutoSize = true;
            this.TotalItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItems.Location = new System.Drawing.Point(288, 35);
            this.TotalItems.Name = "TotalItems";
            this.TotalItems.Size = new System.Drawing.Size(20, 24);
            this.TotalItems.TabIndex = 15;
            this.TotalItems.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(150, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Taxable Items:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(200, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(177, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 12;
            this.label4.Text = "Total Items:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 476);
            this.ControlBox = false;
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Grocery List";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox Taxable;
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TaxableItems;
        private System.Windows.Forms.Label SubTotal;
        private System.Windows.Forms.Label TotalItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}

