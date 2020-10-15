﻿namespace GoFish
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textProgress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBooks = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAsk = new System.Windows.Forms.Button();
            this.listHand = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.serializeDeck = new System.Windows.Forms.Button();
            this.deserializeDeck = new System.Windows.Forms.Button();
            this.serializeBunch = new System.Windows.Forms.Button();
            this.deserializeBunch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your name";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(22, 39);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(158, 23);
            this.textName.TabIndex = 1;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(186, 39);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(123, 23);
            this.buttonStart.TabIndex = 2;
            this.buttonStart.Text = "Start the game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game progress";
            // 
            // textProgress
            // 
            this.textProgress.Location = new System.Drawing.Point(22, 88);
            this.textProgress.Multiline = true;
            this.textProgress.Name = "textProgress";
            this.textProgress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textProgress.Size = new System.Drawing.Size(287, 199);
            this.textProgress.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Books";
            // 
            // textBooks
            // 
            this.textBooks.Location = new System.Drawing.Point(22, 313);
            this.textBooks.Multiline = true;
            this.textBooks.Name = "textBooks";
            this.textBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBooks.Size = new System.Drawing.Size(287, 125);
            this.textBooks.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(325, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your hand";
            // 
            // buttonAsk
            // 
            this.buttonAsk.Location = new System.Drawing.Point(325, 414);
            this.buttonAsk.Name = "buttonAsk";
            this.buttonAsk.Size = new System.Drawing.Size(195, 23);
            this.buttonAsk.TabIndex = 9;
            this.buttonAsk.Text = "Ask for a card";
            this.buttonAsk.UseVisualStyleBackColor = true;
            this.buttonAsk.Click += new System.EventHandler(this.buttonAsk_Click);
            // 
            // listHand
            // 
            this.listHand.FormattingEnabled = true;
            this.listHand.ItemHeight = 15;
            this.listHand.Location = new System.Drawing.Point(325, 39);
            this.listHand.Name = "listHand";
            this.listHand.Size = new System.Drawing.Size(195, 364);
            this.listHand.TabIndex = 10;
            this.listHand.DoubleClick += new System.EventHandler(this.buttonAsk_Click);
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(535, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(2, 437);
            this.label5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(544, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "Serialization";
            // 
            // serializeDeck
            // 
            this.serializeDeck.Location = new System.Drawing.Point(544, 38);
            this.serializeDeck.Name = "serializeDeck";
            this.serializeDeck.Size = new System.Drawing.Size(122, 23);
            this.serializeDeck.TabIndex = 13;
            this.serializeDeck.Text = "Serialize Deck";
            this.serializeDeck.UseVisualStyleBackColor = true;
            this.serializeDeck.Click += new System.EventHandler(this.serializeDeck_Click);
            // 
            // deserializeDeck
            // 
            this.deserializeDeck.Location = new System.Drawing.Point(544, 70);
            this.deserializeDeck.Name = "deserializeDeck";
            this.deserializeDeck.Size = new System.Drawing.Size(122, 23);
            this.deserializeDeck.TabIndex = 14;
            this.deserializeDeck.Text = "Deserialize Deck";
            this.deserializeDeck.UseVisualStyleBackColor = true;
            this.deserializeDeck.Click += new System.EventHandler(this.deserializeDeck_Click);
            // 
            // serializeBunch
            // 
            this.serializeBunch.Location = new System.Drawing.Point(544, 131);
            this.serializeBunch.Name = "serializeBunch";
            this.serializeBunch.Size = new System.Drawing.Size(122, 40);
            this.serializeBunch.TabIndex = 15;
            this.serializeBunch.Text = "Serialize Bunch of Decks";
            this.serializeBunch.UseVisualStyleBackColor = true;
            this.serializeBunch.Click += new System.EventHandler(this.serializeBunch_Click);
            // 
            // deserializeBunch
            // 
            this.deserializeBunch.Location = new System.Drawing.Point(544, 178);
            this.deserializeBunch.Name = "deserializeBunch";
            this.deserializeBunch.Size = new System.Drawing.Size(122, 40);
            this.deserializeBunch.TabIndex = 16;
            this.deserializeBunch.Text = "Deserialize Bunch of Decks";
            this.deserializeBunch.UseVisualStyleBackColor = true;
            this.deserializeBunch.Click += new System.EventHandler(this.deserializeBunch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 459);
            this.Controls.Add(this.deserializeBunch);
            this.Controls.Add(this.serializeBunch);
            this.Controls.Add(this.deserializeDeck);
            this.Controls.Add(this.serializeDeck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listHand);
            this.Controls.Add(this.buttonAsk);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBooks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Go Fish!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBooks;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonAsk;
        private System.Windows.Forms.ListBox listHand;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button serializeDeck;
        private System.Windows.Forms.Button deserializeDeck;
        private System.Windows.Forms.Button serializeBunch;
        private System.Windows.Forms.Button deserializeBunch;
    }
}

