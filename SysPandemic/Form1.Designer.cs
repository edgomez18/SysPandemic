﻿namespace SysPandemic
{
    partial class Homeform
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Homeform));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procedimientosRegularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarProcedimientoRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProcedimientosRegularesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearCotizacionDeProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCotizacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeFacturaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suplidoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeFacturaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.verFacturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nominaDeDoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.descuentosADoctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porProcedimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.externoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarSegurosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarProcesosSinSeguroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miselaneasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaDeIncapacidadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartaDeAltaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem,
            this.procedimientosToolStripMenuItem,
            this.agendaToolStripMenuItem,
            this.facturacionToolStripMenuItem,
            this.doctoresToolStripMenuItem,
            this.segurosToolStripMenuItem,
            this.miselaneasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.administrarToolStripMenuItem});
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.agregarToolStripMenuItem.Text = "Agregar";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.administrarToolStripMenuItem.Text = "Administrar";
            this.administrarToolStripMenuItem.Click += new System.EventHandler(this.administrarToolStripMenuItem_Click);
            // 
            // procedimientosToolStripMenuItem
            // 
            this.procedimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.procedimientosRegularesToolStripMenuItem,
            this.cotizacionesToolStripMenuItem});
            this.procedimientosToolStripMenuItem.Name = "procedimientosToolStripMenuItem";
            this.procedimientosToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.procedimientosToolStripMenuItem.Text = "Procedimientos";
            // 
            // procedimientosRegularesToolStripMenuItem
            // 
            this.procedimientosRegularesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarProcedimientoRegularToolStripMenuItem,
            this.administrarProcedimientosRegularesToolStripMenuItem});
            this.procedimientosRegularesToolStripMenuItem.Name = "procedimientosRegularesToolStripMenuItem";
            this.procedimientosRegularesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.procedimientosRegularesToolStripMenuItem.Text = "Procedimientos Regulares";
            // 
            // agregarProcedimientoRegularToolStripMenuItem
            // 
            this.agregarProcedimientoRegularToolStripMenuItem.Name = "agregarProcedimientoRegularToolStripMenuItem";
            this.agregarProcedimientoRegularToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.agregarProcedimientoRegularToolStripMenuItem.Text = "Agregar Procedimiento Regular";
            this.agregarProcedimientoRegularToolStripMenuItem.Click += new System.EventHandler(this.agregarProcedimientoRegularToolStripMenuItem_Click);
            // 
            // administrarProcedimientosRegularesToolStripMenuItem
            // 
            this.administrarProcedimientosRegularesToolStripMenuItem.Name = "administrarProcedimientosRegularesToolStripMenuItem";
            this.administrarProcedimientosRegularesToolStripMenuItem.Size = new System.Drawing.Size(276, 22);
            this.administrarProcedimientosRegularesToolStripMenuItem.Text = "Administrar procedimientos Regulares";
            this.administrarProcedimientosRegularesToolStripMenuItem.Click += new System.EventHandler(this.administrarProcedimientosRegularesToolStripMenuItem_Click);
            // 
            // cotizacionesToolStripMenuItem
            // 
            this.cotizacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearCotizacionDeProcedimientoToolStripMenuItem,
            this.verCotizacionesToolStripMenuItem});
            this.cotizacionesToolStripMenuItem.Name = "cotizacionesToolStripMenuItem";
            this.cotizacionesToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.cotizacionesToolStripMenuItem.Text = "Presupuestos";
            // 
            // crearCotizacionDeProcedimientoToolStripMenuItem
            // 
            this.crearCotizacionDeProcedimientoToolStripMenuItem.Name = "crearCotizacionDeProcedimientoToolStripMenuItem";
            this.crearCotizacionDeProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.crearCotizacionDeProcedimientoToolStripMenuItem.Text = "Crear presupuestos de procedimiento";
            this.crearCotizacionDeProcedimientoToolStripMenuItem.Click += new System.EventHandler(this.crearCotizacionDeProcedimientoToolStripMenuItem_Click);
            // 
            // verCotizacionesToolStripMenuItem
            // 
            this.verCotizacionesToolStripMenuItem.Name = "verCotizacionesToolStripMenuItem";
            this.verCotizacionesToolStripMenuItem.Padding = new System.Windows.Forms.Padding(0);
            this.verCotizacionesToolStripMenuItem.Size = new System.Drawing.Size(272, 20);
            this.verCotizacionesToolStripMenuItem.Text = "Ver presupuestos";
            this.verCotizacionesToolStripMenuItem.Click += new System.EventHandler(this.verCotizacionesToolStripMenuItem_Click);
            // 
            // agendaToolStripMenuItem
            // 
            this.agendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarCitaToolStripMenuItem,
            this.verCitasToolStripMenuItem});
            this.agendaToolStripMenuItem.Name = "agendaToolStripMenuItem";
            this.agendaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.agendaToolStripMenuItem.Text = "Agenda";
            // 
            // agregarCitaToolStripMenuItem
            // 
            this.agregarCitaToolStripMenuItem.Name = "agregarCitaToolStripMenuItem";
            this.agregarCitaToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.agregarCitaToolStripMenuItem.Text = "Agregar Cita";
            this.agregarCitaToolStripMenuItem.Click += new System.EventHandler(this.agregarCitaToolStripMenuItem_Click);
            // 
            // verCitasToolStripMenuItem
            // 
            this.verCitasToolStripMenuItem.Name = "verCitasToolStripMenuItem";
            this.verCitasToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.verCitasToolStripMenuItem.Text = "Ver Citas";
            this.verCitasToolStripMenuItem.Click += new System.EventHandler(this.verCitasToolStripMenuItem_Click);
            // 
            // facturacionToolStripMenuItem
            // 
            this.facturacionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturarToolStripMenuItem,
            this.entradaDeFacturaToolStripMenuItem,
            this.nominaToolStripMenuItem,
            this.cToolStripMenuItem,
            this.cierreToolStripMenuItem});
            this.facturacionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.facturacionToolStripMenuItem.Name = "facturacionToolStripMenuItem";
            this.facturacionToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.facturacionToolStripMenuItem.Text = "Finanzas";
            this.facturacionToolStripMenuItem.Click += new System.EventHandler(this.facturacionToolStripMenuItem_Click);
            // 
            // facturarToolStripMenuItem
            // 
            this.facturarToolStripMenuItem.Name = "facturarToolStripMenuItem";
            this.facturarToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.facturarToolStripMenuItem.Text = "Facturar Procedimiento";
            this.facturarToolStripMenuItem.Click += new System.EventHandler(this.facturarToolStripMenuItem_Click);
            // 
            // entradaDeFacturaToolStripMenuItem
            // 
            this.entradaDeFacturaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.suplidoresToolStripMenuItem1,
            this.entradaDeFacturaToolStripMenuItem1,
            this.verFacturasToolStripMenuItem});
            this.entradaDeFacturaToolStripMenuItem.Name = "entradaDeFacturaToolStripMenuItem";
            this.entradaDeFacturaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.entradaDeFacturaToolStripMenuItem.Text = "Facturas";
            this.entradaDeFacturaToolStripMenuItem.Click += new System.EventHandler(this.entradaDeFacturaToolStripMenuItem_Click);
            // 
            // suplidoresToolStripMenuItem1
            // 
            this.suplidoresToolStripMenuItem1.Name = "suplidoresToolStripMenuItem1";
            this.suplidoresToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.suplidoresToolStripMenuItem1.Text = "Suplidores";
            this.suplidoresToolStripMenuItem1.Click += new System.EventHandler(this.suplidoresToolStripMenuItem1_Click);
            // 
            // entradaDeFacturaToolStripMenuItem1
            // 
            this.entradaDeFacturaToolStripMenuItem1.Name = "entradaDeFacturaToolStripMenuItem1";
            this.entradaDeFacturaToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.entradaDeFacturaToolStripMenuItem1.Text = "Entrada de Factura";
            this.entradaDeFacturaToolStripMenuItem1.Click += new System.EventHandler(this.entradaDeFacturaToolStripMenuItem1_Click);
            // 
            // verFacturasToolStripMenuItem
            // 
            this.verFacturasToolStripMenuItem.Name = "verFacturasToolStripMenuItem";
            this.verFacturasToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.verFacturasToolStripMenuItem.Text = "Ver Facturas";
            this.verFacturasToolStripMenuItem.Click += new System.EventHandler(this.verFacturasToolStripMenuItem_Click);
            // 
            // nominaToolStripMenuItem
            // 
            this.nominaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nominaDeDoctoresToolStripMenuItem,
            this.descuentosADoctoresToolStripMenuItem});
            this.nominaToolStripMenuItem.Name = "nominaToolStripMenuItem";
            this.nominaToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.nominaToolStripMenuItem.Text = "Nomina";
            // 
            // nominaDeDoctoresToolStripMenuItem
            // 
            this.nominaDeDoctoresToolStripMenuItem.Name = "nominaDeDoctoresToolStripMenuItem";
            this.nominaDeDoctoresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.nominaDeDoctoresToolStripMenuItem.Text = "Nomina de Doctores";
            this.nominaDeDoctoresToolStripMenuItem.Click += new System.EventHandler(this.nominaDeDoctoresToolStripMenuItem_Click);
            // 
            // descuentosADoctoresToolStripMenuItem
            // 
            this.descuentosADoctoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porProcedimientoToolStripMenuItem,
            this.externoToolStripMenuItem});
            this.descuentosADoctoresToolStripMenuItem.Name = "descuentosADoctoresToolStripMenuItem";
            this.descuentosADoctoresToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.descuentosADoctoresToolStripMenuItem.Text = "Descuentos a Doctores";
            this.descuentosADoctoresToolStripMenuItem.Click += new System.EventHandler(this.descuentosADoctoresToolStripMenuItem_Click);
            // 
            // porProcedimientoToolStripMenuItem
            // 
            this.porProcedimientoToolStripMenuItem.Name = "porProcedimientoToolStripMenuItem";
            this.porProcedimientoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.porProcedimientoToolStripMenuItem.Text = "Por Procedimiento";
            // 
            // externoToolStripMenuItem
            // 
            this.externoToolStripMenuItem.Name = "externoToolStripMenuItem";
            this.externoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.externoToolStripMenuItem.Text = "Externo";
            this.externoToolStripMenuItem.Click += new System.EventHandler(this.externoToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cToolStripMenuItem.Text = "CxC/CP";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cierreToolStripMenuItem
            // 
            this.cierreToolStripMenuItem.Name = "cierreToolStripMenuItem";
            this.cierreToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
            this.cierreToolStripMenuItem.Text = "Cierre";
            this.cierreToolStripMenuItem.Click += new System.EventHandler(this.cierreToolStripMenuItem_Click);
            // 
            // doctoresToolStripMenuItem
            // 
            this.doctoresToolStripMenuItem.Name = "doctoresToolStripMenuItem";
            this.doctoresToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.doctoresToolStripMenuItem.Text = "Doctores";
            this.doctoresToolStripMenuItem.Click += new System.EventHandler(this.doctoresToolStripMenuItem_Click);
            // 
            // segurosToolStripMenuItem
            // 
            this.segurosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSeguroToolStripMenuItem,
            this.administrarSegurosToolStripMenuItem,
            this.administrarProcesosSinSeguroToolStripMenuItem});
            this.segurosToolStripMenuItem.Name = "segurosToolStripMenuItem";
            this.segurosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.segurosToolStripMenuItem.Text = "Seguros";
            // 
            // agregarSeguroToolStripMenuItem
            // 
            this.agregarSeguroToolStripMenuItem.Name = "agregarSeguroToolStripMenuItem";
            this.agregarSeguroToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.agregarSeguroToolStripMenuItem.Text = "Agregar Seguro";
            this.agregarSeguroToolStripMenuItem.Click += new System.EventHandler(this.agregarSeguroToolStripMenuItem_Click);
            // 
            // administrarSegurosToolStripMenuItem
            // 
            this.administrarSegurosToolStripMenuItem.Name = "administrarSegurosToolStripMenuItem";
            this.administrarSegurosToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.administrarSegurosToolStripMenuItem.Text = "Administrar Seguros";
            this.administrarSegurosToolStripMenuItem.Click += new System.EventHandler(this.administrarSegurosToolStripMenuItem_Click);
            // 
            // administrarProcesosSinSeguroToolStripMenuItem
            // 
            this.administrarProcesosSinSeguroToolStripMenuItem.Name = "administrarProcesosSinSeguroToolStripMenuItem";
            this.administrarProcesosSinSeguroToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.administrarProcesosSinSeguroToolStripMenuItem.Text = "Administrar procesos sin seguro";
            this.administrarProcesosSinSeguroToolStripMenuItem.Click += new System.EventHandler(this.administrarProcesosSinSeguroToolStripMenuItem_Click);
            // 
            // miselaneasToolStripMenuItem
            // 
            this.miselaneasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetaToolStripMenuItem,
            this.cartaDeIncapacidadToolStripMenuItem,
            this.cartaDeAltaToolStripMenuItem});
            this.miselaneasToolStripMenuItem.Name = "miselaneasToolStripMenuItem";
            this.miselaneasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.miselaneasToolStripMenuItem.Text = "Impresiones";
            // 
            // resetaToolStripMenuItem
            // 
            this.resetaToolStripMenuItem.Name = "resetaToolStripMenuItem";
            this.resetaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.resetaToolStripMenuItem.Text = "Prescripción";
            this.resetaToolStripMenuItem.Click += new System.EventHandler(this.resetaToolStripMenuItem_Click);
            // 
            // cartaDeIncapacidadToolStripMenuItem
            // 
            this.cartaDeIncapacidadToolStripMenuItem.Name = "cartaDeIncapacidadToolStripMenuItem";
            this.cartaDeIncapacidadToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cartaDeIncapacidadToolStripMenuItem.Text = "Carta de Incapacidad";
            // 
            // cartaDeAltaToolStripMenuItem
            // 
            this.cartaDeAltaToolStripMenuItem.Name = "cartaDeAltaToolStripMenuItem";
            this.cartaDeAltaToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.cartaDeAltaToolStripMenuItem.Text = "Carta de alta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1209, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // Homeform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1077, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Homeform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SysPandemic";
            this.Load += new System.EventHandler(this.Homeform_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSeguroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarSegurosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProcesosSinSeguroToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem miselaneasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartaDeIncapacidadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartaDeAltaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeFacturaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entradaDeFacturaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem suplidoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem verFacturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearCotizacionDeProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verCotizacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procedimientosRegularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarProcedimientoRegularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarProcedimientosRegularesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nominaDeDoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem descuentosADoctoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porProcedimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem externoToolStripMenuItem;
    }
}

