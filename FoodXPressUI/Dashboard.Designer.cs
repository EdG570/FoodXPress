﻿namespace FoodXPressUI
{
    partial class NewOrderForm
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
            this.FoodItemListBox = new System.Windows.Forms.ListBox();
            this.DrinksListButton = new System.Windows.Forms.Button();
            this.MealsListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FoodItemListBox
            // 
            this.FoodItemListBox.FormattingEnabled = true;
            this.FoodItemListBox.Location = new System.Drawing.Point(49, 68);
            this.FoodItemListBox.Name = "FoodItemListBox";
            this.FoodItemListBox.Size = new System.Drawing.Size(233, 329);
            this.FoodItemListBox.TabIndex = 0;
            // 
            // DrinksListButton
            // 
            this.DrinksListButton.BackColor = System.Drawing.Color.LightBlue;
            this.DrinksListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrinksListButton.Location = new System.Drawing.Point(49, 32);
            this.DrinksListButton.Name = "DrinksListButton";
            this.DrinksListButton.Size = new System.Drawing.Size(75, 23);
            this.DrinksListButton.TabIndex = 1;
            this.DrinksListButton.Text = "Drinks";
            this.DrinksListButton.UseVisualStyleBackColor = false;
            this.DrinksListButton.Click += new System.EventHandler(this.DrinksListButton_Click);
            // 
            // MealsListButton
            // 
            this.MealsListButton.Location = new System.Drawing.Point(139, 32);
            this.MealsListButton.Name = "MealsListButton";
            this.MealsListButton.Size = new System.Drawing.Size(75, 23);
            this.MealsListButton.TabIndex = 1;
            this.MealsListButton.Text = "Meals";
            this.MealsListButton.UseVisualStyleBackColor = true;
            this.MealsListButton.Click += new System.EventHandler(this.MealsListButton_Click);
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 476);
            this.Controls.Add(this.MealsListButton);
            this.Controls.Add(this.DrinksListButton);
            this.Controls.Add(this.FoodItemListBox);
            this.Name = "NewOrderForm";
            this.Text = "Food XPress -  New Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox FoodItemListBox;
        private System.Windows.Forms.Button DrinksListButton;
        private System.Windows.Forms.Button MealsListButton;
    }
}

