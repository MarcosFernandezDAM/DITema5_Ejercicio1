﻿
namespace Prueba
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelTextBox2 = new Ejercicio1.LabelTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DERECHA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTextBox2
            // 
            this.labelTextBox2.Location = new System.Drawing.Point(29, 34);
            this.labelTextBox2.Name = "labelTextBox2";
            this.labelTextBox2.Posicion = Ejercicio1.ePosicion.IZQUIERDA;
            this.labelTextBox2.PswChr = '\0';
            this.labelTextBox2.Separacion = 30;
            this.labelTextBox2.Size = new System.Drawing.Size(165, 20);
            this.labelTextBox2.TabIndex = 1;
            this.labelTextBox2.TextLbl = "label1";
            this.labelTextBox2.TextTxt = "";
            this.labelTextBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.labelTextBox2_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelTextBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ejercicio1";
            this.ResumeLayout(false);

        }

        #endregion

        private Ejercicio1.LabelTextBox labelTextBox2;
        private System.Windows.Forms.Button button1;
    }
}

