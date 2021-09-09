namespace DormAndMealPlanCalculator
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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dormsListView
            // 
            this.dormsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dormNameHeader,
            this.dormCostHeader});
            this.dormsListView.HideSelection = false;
            this.dormsListView.Location = new System.Drawing.Point(90, 71);
            this.dormsListView.Name = "dormsListView";
            this.dormsListView.Size = new System.Drawing.Size(299, 97);
            this.dormsListView.TabIndex = 0;
            this.dormsListView.UseCompatibleStateImageBehavior = false;
            this.dormsListView.View = System.Windows.Forms.View.Details;
            this.dormsListView.SelectedIndexChanged += new System.EventHandler(this.dormsListView_SelectedIndexChanged);
            // 
            // dormNameHeader
            // 
            this.dormNameHeader.Text = "Dormitory";
            this.dormNameHeader.Width = 171;
            // 
            // dormCostHeader
            // 
            this.dormCostHeader.Text = "Cost";
            this.dormCostHeader.Width = 109;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Location = new System.Drawing.Point(87, 40);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(501, 13);
            this.instructionsLabel.TabIndex = 1;
            this.instructionsLabel.Text = "Select a dormitory and meal plan option. Once selected, click \"Calculate\" to see " +
    "your total semester cost.";
            // 
            // SelectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.dormsListView);
            this.Name = "SelectionsForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dormsListView;
        private System.Windows.Forms.ColumnHeader dormNameHeader;
        private System.Windows.Forms.ColumnHeader dormCostHeader;
        private System.Windows.Forms.Label instructionsLabel;
    }
}

