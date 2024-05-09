namespace design
{
    partial class MyCollections
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyCollections));
            Picture7 = new PictureBox();
            AddCollectionButton = new Button();
            Text1 = new Label();
            ((System.ComponentModel.ISupportInitialize)Picture7).BeginInit();
            SuspendLayout();
            // 
            // Picture7
            // 
            resources.ApplyResources(Picture7, "Picture7");
            Picture7.Name = "Picture7";
            Picture7.TabStop = false;
            // 
            // AddCollectionButton
            // 
            resources.ApplyResources(AddCollectionButton, "AddCollectionButton");
            AddCollectionButton.BackColor = Color.Gainsboro;
            AddCollectionButton.ForeColor = SystemColors.ActiveCaptionText;
            AddCollectionButton.Name = "AddCollectionButton";
            AddCollectionButton.UseVisualStyleBackColor = false;
            AddCollectionButton.Click += AddCollectionButton_Click;
            // 
            // Text1
            // 
            resources.ApplyResources(Text1, "Text1");
            Text1.ForeColor = SystemColors.ActiveCaptionText;
            Text1.Name = "Text1";
            // 
            // MyCollections
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Text1);
            Controls.Add(AddCollectionButton);
            Controls.Add(Picture7);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "MyCollections";
            ((System.ComponentModel.ISupportInitialize)Picture7).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.PictureBox Picture7;
        private Button AddCollectionButton;
        private Label Text1;
    }
}