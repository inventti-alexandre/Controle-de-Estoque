﻿namespace GUI
{
    partial class frmRelatorioVenda
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DTControleDeEstoque = new GUI.DTControleDeEstoque();
            this.pnPrincipal = new System.Windows.Forms.Panel();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTControleDeEstoque)).BeginInit();
            this.pnPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "venda";
            this.vendaBindingSource.DataSource = this.DTControleDeEstoque;
            // 
            // DTControleDeEstoque
            // 
            this.DTControleDeEstoque.DataSetName = "DTControleDeEstoque";
            this.DTControleDeEstoque.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnPrincipal
            // 
            this.pnPrincipal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnPrincipal.Controls.Add(this.btPesquisar);
            this.pnPrincipal.Controls.Add(this.txtPesquisar);
            this.pnPrincipal.Controls.Add(this.label1);
            this.pnPrincipal.Location = new System.Drawing.Point(12, 12);
            this.pnPrincipal.Name = "pnPrincipal";
            this.pnPrincipal.Size = new System.Drawing.Size(984, 65);
            this.pnPrincipal.TabIndex = 1;
            // 
            // btPesquisar
            // 
            this.btPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btPesquisar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btPesquisar.BackgroundImage = global::GUI.Properties.Resources.search;
            this.btPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPesquisar.Location = new System.Drawing.Point(495, 14);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(115, 46);
            this.btPesquisar.TabIndex = 9;
            this.btPesquisar.UseVisualStyleBackColor = false;
            this.btPesquisar.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPesquisar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPesquisar.Location = new System.Drawing.Point(4, 31);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(373, 27);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pesquisar determinada Venda";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vendaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.repRelatorioVenda.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(-1, 83);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1179, 671);
            this.reportViewer1.TabIndex = 2;
            // 
            // frmRelatorioVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(182)))), ((int)(((byte)(182)))));
            this.ClientSize = new System.Drawing.Size(1175, 750);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.pnPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Name = "frmRelatorioVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatorio Venda";
            this.Load += new System.EventHandler(this.frmRelatorioVenda_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRelatorioVenda_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTControleDeEstoque)).EndInit();
            this.pnPrincipal.ResumeLayout(false);
            this.pnPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPrincipal;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private DTControleDeEstoque DTControleDeEstoque;
    }
}