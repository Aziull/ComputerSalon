
namespace WinFormsUI.Views
{
    partial class MainView
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
            this.btnCheck = new System.Windows.Forms.Button();
            this.lblPowerSupply = new System.Windows.Forms.Label();
            this.lbMemoryCards = new System.Windows.Forms.ListBox();
            this.lblMemoryCard = new System.Windows.Forms.Label();
            this.lblMotherboard = new System.Windows.Forms.Label();
            this.lblProcessor = new System.Windows.Forms.Label();
            this.lblCase = new System.Windows.Forms.Label();
            this.lbPowerSupplies = new System.Windows.Forms.ListBox();
            this.lbMotherboards = new System.Windows.Forms.ListBox();
            this.lbProcessors = new System.Windows.Forms.ListBox();
            this.lbCases = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1019, 571);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(115, 27);
            this.btnCheck.TabIndex = 32;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // lblPowerSupply
            // 
            this.lblPowerSupply.AutoSize = true;
            this.lblPowerSupply.Location = new System.Drawing.Point(190, 285);
            this.lblPowerSupply.Name = "lblPowerSupply";
            this.lblPowerSupply.Size = new System.Drawing.Size(76, 13);
            this.lblPowerSupply.TabIndex = 31;
            this.lblPowerSupply.Text = "Power supply: ";
            // 
            // lbMemoryCards
            // 
            this.lbMemoryCards.FormattingEnabled = true;
            this.lbMemoryCards.Location = new System.Drawing.Point(563, 27);
            this.lbMemoryCards.Name = "lbMemoryCards";
            this.lbMemoryCards.Size = new System.Drawing.Size(553, 108);
            this.lbMemoryCards.TabIndex = 30;
            // 
            // lblMemoryCard
            // 
            this.lblMemoryCard.AutoSize = true;
            this.lblMemoryCard.Location = new System.Drawing.Point(571, 11);
            this.lblMemoryCard.Name = "lblMemoryCard";
            this.lblMemoryCard.Size = new System.Drawing.Size(37, 13);
            this.lblMemoryCard.TabIndex = 29;
            this.lblMemoryCard.Text = "RAM: ";
            // 
            // lblMotherboard
            // 
            this.lblMotherboard.AutoSize = true;
            this.lblMotherboard.Location = new System.Drawing.Point(571, 149);
            this.lblMotherboard.Name = "lblMotherboard";
            this.lblMotherboard.Size = new System.Drawing.Size(67, 13);
            this.lblMotherboard.TabIndex = 28;
            this.lblMotherboard.Text = "Motherboard";
            // 
            // lblProcessor
            // 
            this.lblProcessor.AutoSize = true;
            this.lblProcessor.Location = new System.Drawing.Point(24, 149);
            this.lblProcessor.Name = "lblProcessor";
            this.lblProcessor.Size = new System.Drawing.Size(57, 13);
            this.lblProcessor.TabIndex = 27;
            this.lblProcessor.Text = "Processor:";
            // 
            // lblCase
            // 
            this.lblCase.AutoSize = true;
            this.lblCase.Location = new System.Drawing.Point(24, 11);
            this.lblCase.Name = "lblCase";
            this.lblCase.Size = new System.Drawing.Size(34, 13);
            this.lblCase.TabIndex = 26;
            this.lblCase.Text = "Case:";
            // 
            // lbPowerSupplies
            // 
            this.lbPowerSupplies.FormattingEnabled = true;
            this.lbPowerSupplies.Location = new System.Drawing.Point(179, 301);
            this.lbPowerSupplies.Name = "lbPowerSupplies";
            this.lbPowerSupplies.Size = new System.Drawing.Size(727, 108);
            this.lbPowerSupplies.TabIndex = 25;
            // 
            // lbMotherboards
            // 
            this.lbMotherboards.FormattingEnabled = true;
            this.lbMotherboards.Location = new System.Drawing.Point(563, 165);
            this.lbMotherboards.Name = "lbMotherboards";
            this.lbMotherboards.Size = new System.Drawing.Size(553, 108);
            this.lbMotherboards.TabIndex = 24;
            // 
            // lbProcessors
            // 
            this.lbProcessors.FormattingEnabled = true;
            this.lbProcessors.Location = new System.Drawing.Point(15, 165);
            this.lbProcessors.Name = "lbProcessors";
            this.lbProcessors.Size = new System.Drawing.Size(520, 108);
            this.lbProcessors.TabIndex = 23;
            // 
            // lbCases
            // 
            this.lbCases.FormattingEnabled = true;
            this.lbCases.Location = new System.Drawing.Point(15, 27);
            this.lbCases.Name = "lbCases";
            this.lbCases.Size = new System.Drawing.Size(520, 108);
            this.lbCases.TabIndex = 22;
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 607);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.lblPowerSupply);
            this.Controls.Add(this.lbMemoryCards);
            this.Controls.Add(this.lblMemoryCard);
            this.Controls.Add(this.lblMotherboard);
            this.Controls.Add(this.lblProcessor);
            this.Controls.Add(this.lblCase);
            this.Controls.Add(this.lbPowerSupplies);
            this.Controls.Add(this.lbMotherboards);
            this.Controls.Add(this.lbProcessors);
            this.Controls.Add(this.lbCases);
            this.Name = "MainView";
            this.Text = "MainView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Label lblPowerSupply;
        private System.Windows.Forms.ListBox lbMemoryCards;
        private System.Windows.Forms.Label lblMemoryCard;
        private System.Windows.Forms.Label lblMotherboard;
        private System.Windows.Forms.Label lblProcessor;
        private System.Windows.Forms.Label lblCase;
        private System.Windows.Forms.ListBox lbPowerSupplies;
        private System.Windows.Forms.ListBox lbMotherboards;
        private System.Windows.Forms.ListBox lbProcessors;
        private System.Windows.Forms.ListBox lbCases;
    }
}