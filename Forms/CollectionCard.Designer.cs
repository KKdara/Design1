namespace design
{
    partial class CollectionCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CollectionCard));
            Picture7 = new PictureBox();
            EditButton = new Button();
            SaveButton = new Button();
            Title = new Label();
            NameText = new TextBox();
            ((System.ComponentModel.ISupportInitialize)Picture7).BeginInit();
            SuspendLayout();
            // 
            // Picture7
            // 
            resources.ApplyResources(Picture7, "Picture7");
            Picture7.Name = "Picture7";
            Picture7.TabStop = false;
            // 
            // EditButton
            // 
            resources.ApplyResources(EditButton, "EditButton");
            EditButton.BackColor = Color.Gainsboro;
            EditButton.ForeColor = SystemColors.ActiveCaptionText;
            EditButton.Name = "EditButton";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            resources.ApplyResources(SaveButton, "SaveButton");
            SaveButton.BackColor = Color.Gainsboro;
            SaveButton.ForeColor = SystemColors.ActiveCaptionText;
            SaveButton.Name = "SaveButton";
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // Title
            // 
            resources.ApplyResources(Title, "Title");
            Title.BackColor = Color.Transparent;
            Title.ForeColor = SystemColors.ActiveCaptionText;
            Title.Name = "Title";
            // 
            // NameText
            // 
            resources.ApplyResources(NameText, "NameText");
            NameText.BackColor = Color.WhiteSmoke;
            NameText.BorderStyle = BorderStyle.None;
            NameText.ForeColor = SystemColors.ActiveCaptionText;
            NameText.Name = "NameText";
            // 
            // CollectionCard
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(NameText);
            Controls.Add(Title);
            Controls.Add(SaveButton);
            Controls.Add(EditButton);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "CollectionCard";
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox Picture7;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button SaveButton;
        new private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox NameText;
    }
}