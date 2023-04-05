namespace Reports
{
    partial class frmRepViewer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRepViewer));
            this.viewer1 = new DataDynamics.ActiveReports.Viewer.Viewer();
            this.SuspendLayout();
            // 
            // viewer1
            // 
            this.viewer1.AutoSize = true;
            this.viewer1.BackColor = System.Drawing.SystemColors.Control;
            this.viewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewer1.Document = new DataDynamics.ActiveReports.Document.Document("ARNet Document");
            this.viewer1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewer1.Location = new System.Drawing.Point(0, 0);
            this.viewer1.Name = "viewer1";
            this.viewer1.ReportViewer.CurrentPage = 0;
            this.viewer1.ReportViewer.MultiplePageCols = 3;
            this.viewer1.ReportViewer.MultiplePageRows = 2;
            this.viewer1.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal;
            this.viewer1.Size = new System.Drawing.Size(884, 565);
            this.viewer1.TabIndex = 1;
            this.viewer1.TableOfContents.Text = "Table Of Contents";
            this.viewer1.TableOfContents.Width = 233;
            this.viewer1.TabTitleLength = 35;
            this.viewer1.Toolbar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frmRepViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 565);
            this.Controls.Add(this.viewer1);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmRepViewer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In báo cáo";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmRepViewer_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRepViewer_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataDynamics.ActiveReports.Viewer.Viewer viewer1;
    }
}

