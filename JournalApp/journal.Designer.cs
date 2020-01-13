namespace JournalApp
{
    partial class journal
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
            this.tabNavigationPage2 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabPane1 = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabNavigationPage1 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage3 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage4 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabNavigationPage5 = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).BeginInit();
            this.tabPane1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabNavigationPage2
            // 
            this.tabNavigationPage2.Caption = "Журнал обращения граждан";
            this.tabNavigationPage2.Name = "tabNavigationPage2";
            this.tabNavigationPage2.Size = new System.Drawing.Size(1091, 669);
            // 
            // tabPane1
            // 
            this.tabPane1.Controls.Add(this.tabNavigationPage2);
            this.tabPane1.Controls.Add(this.tabNavigationPage1);
            this.tabPane1.Controls.Add(this.tabNavigationPage3);
            this.tabPane1.Controls.Add(this.tabNavigationPage4);
            this.tabPane1.Controls.Add(this.tabNavigationPage5);
            this.tabPane1.Location = new System.Drawing.Point(1, 1);
            this.tabPane1.Name = "tabPane1";
            this.tabPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Text;
            this.tabPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabNavigationPage2,
            this.tabNavigationPage1,
            this.tabNavigationPage3,
            this.tabNavigationPage4,
            this.tabNavigationPage5});
            this.tabPane1.RegularSize = new System.Drawing.Size(1091, 698);
            this.tabPane1.SelectedPage = this.tabNavigationPage2;
            this.tabPane1.Size = new System.Drawing.Size(1091, 698);
            this.tabPane1.TabIndex = 0;
            this.tabPane1.Text = "tabPane1";
            // 
            // tabNavigationPage1
            // 
            this.tabNavigationPage1.Caption = "Справки";
            this.tabNavigationPage1.Name = "tabNavigationPage1";
            this.tabNavigationPage1.Size = new System.Drawing.Size(1091, 698);
            // 
            // tabNavigationPage3
            // 
            this.tabNavigationPage3.Caption = "Опломбировка";
            this.tabNavigationPage3.Name = "tabNavigationPage3";
            this.tabNavigationPage3.Size = new System.Drawing.Size(1091, 698);
            // 
            // tabNavigationPage4
            // 
            this.tabNavigationPage4.Caption = "Опломбировка(плат)";
            this.tabNavigationPage4.Name = "tabNavigationPage4";
            this.tabNavigationPage4.Size = new System.Drawing.Size(1091, 698);
            // 
            // tabNavigationPage5
            // 
            this.tabNavigationPage5.Caption = "Регистрация писем";
            this.tabNavigationPage5.Name = "tabNavigationPage5";
            this.tabNavigationPage5.Size = new System.Drawing.Size(1091, 698);
            // 
            // journal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 700);
            this.Controls.Add(this.tabPane1);
            this.Name = "journal";
            this.Text = "Журнал";
            ((System.ComponentModel.ISupportInitialize)(this.tabPane1)).EndInit();
            this.tabPane1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage2;
        private DevExpress.XtraBars.Navigation.TabPane tabPane1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage1;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage3;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage4;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabNavigationPage5;
    }
}