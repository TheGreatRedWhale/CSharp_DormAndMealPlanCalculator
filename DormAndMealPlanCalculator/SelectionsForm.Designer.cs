﻿namespace DormAndMealPlanCalculator
{
    partial class SelectionsForm
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
            this.dormsListView = new System.Windows.Forms.ListView();
            this.dormNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dormCostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructionsLabel1 = new System.Windows.Forms.Label();
            this.mealsListView = new System.Windows.Forms.ListView();
            this.mealsPerWeekHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.mealsCostHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.instructionsLabel2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dormsListView
            // 
            this.dormsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dormNameHeader,
            this.dormCostHeader});
            this.dormsListView.FullRowSelect = true;
            this.dormsListView.HideSelection = false;
            this.dormsListView.Location = new System.Drawing.Point(12, 52);
            this.dormsListView.MultiSelect = false;
            this.dormsListView.Name = "dormsListView";
            this.dormsListView.Size = new System.Drawing.Size(186, 231);
            this.dormsListView.TabIndex = 0;
            this.dormsListView.UseCompatibleStateImageBehavior = false;
            this.dormsListView.View = System.Windows.Forms.View.Details;
            // 
            // dormNameHeader
            // 
            this.dormNameHeader.Text = "Dormitory";
            this.dormNameHeader.Width = 109;
            // 
            // dormCostHeader
            // 
            this.dormCostHeader.Text = "Cost";
            this.dormCostHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dormCostHeader.Width = 68;
            // 
            // instructionsLabel1
            // 
            this.instructionsLabel1.AutoSize = true;
            this.instructionsLabel1.Location = new System.Drawing.Point(9, 11);
            this.instructionsLabel1.Name = "instructionsLabel1";
            this.instructionsLabel1.Size = new System.Drawing.Size(195, 13);
            this.instructionsLabel1.TabIndex = 3;
            this.instructionsLabel1.Text = "Select a dormitory and meal plan option.";
            // 
            // mealsListView
            // 
            this.mealsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.mealsPerWeekHeader,
            this.mealsCostHeader});
            this.mealsListView.FullRowSelect = true;
            this.mealsListView.HideSelection = false;
            this.mealsListView.Location = new System.Drawing.Point(209, 52);
            this.mealsListView.MultiSelect = false;
            this.mealsListView.Name = "mealsListView";
            this.mealsListView.Size = new System.Drawing.Size(186, 231);
            this.mealsListView.TabIndex = 1;
            this.mealsListView.UseCompatibleStateImageBehavior = false;
            this.mealsListView.View = System.Windows.Forms.View.Details;
            // 
            // mealsPerWeekHeader
            // 
            this.mealsPerWeekHeader.Text = "Meals per Week";
            this.mealsPerWeekHeader.Width = 109;
            // 
            // mealsCostHeader
            // 
            this.mealsCostHeader.Text = "Cost";
            this.mealsCostHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mealsCostHeader.Width = 68;
            // 
            // instructionsLabel2
            // 
            this.instructionsLabel2.AutoSize = true;
            this.instructionsLabel2.Location = new System.Drawing.Point(9, 26);
            this.instructionsLabel2.Name = "instructionsLabel2";
            this.instructionsLabel2.Size = new System.Drawing.Size(310, 13);
            this.instructionsLabel2.TabIndex = 4;
            this.instructionsLabel2.Text = "Once selected, click \"Calculate\" to see your total semester cost.";
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(12, 294);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(383, 43);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // SelectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 348);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.instructionsLabel2);
            this.Controls.Add(this.mealsListView);
            this.Controls.Add(this.instructionsLabel1);
            this.Controls.Add(this.dormsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SelectionsForm";
            this.Text = "Dorm and Meal Plan Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dormsListView;
        private System.Windows.Forms.ColumnHeader dormNameHeader;
        private System.Windows.Forms.ColumnHeader dormCostHeader;
        private System.Windows.Forms.Label instructionsLabel1;
        private System.Windows.Forms.ListView mealsListView;
        private System.Windows.Forms.ColumnHeader mealsPerWeekHeader;
        private System.Windows.Forms.ColumnHeader mealsCostHeader;
        private System.Windows.Forms.Label instructionsLabel2;
        private System.Windows.Forms.Button calculateButton;
    }
}

