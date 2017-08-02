namespace Tercera_Tarea_Prog_3.Reportes
{
    partial class frmReportes
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
            this.reportCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // reportCrystalReportViewer
            // 
            this.reportCrystalReportViewer.ActiveViewIndex = -1;
            this.reportCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.reportCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.reportCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.reportCrystalReportViewer.Name = "reportCrystalReportViewer";
            this.reportCrystalReportViewer.Size = new System.Drawing.Size(661, 488);
            this.reportCrystalReportViewer.TabIndex = 0;
            this.reportCrystalReportViewer.Load += new System.EventHandler(this.reportCrystalReportViewer_Load);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 488);
            this.Controls.Add(this.reportCrystalReportViewer);
            this.Name = "frmReportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer reportCrystalReportViewer;
    }
}