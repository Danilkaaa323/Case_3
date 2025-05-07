namespace casee_3
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
            buttonExecute = new Button();
            drawingPanel = new Panel();
            buttonAddDepot = new Button();
            buttonAddPoint = new Button();
            buttonRemoveDepot = new Button();
            buttonRemovePoint = new Button();
            richTextBoxOutput = new RichTextBox();
            label = new Label();
            buttonGetOrder = new Button();
            SuspendLayout();
            // 
            // buttonExecute
            // 
            buttonExecute.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonExecute.Location = new Point(484, 354);
            buttonExecute.Name = "buttonExecute";
            buttonExecute.Size = new Size(228, 41);
            buttonExecute.TabIndex = 3;
            buttonExecute.Text = "Построить маршрут";
            buttonExecute.UseVisualStyleBackColor = true;
            buttonExecute.Click += ButtonExecute_Click;
            // 
            // drawingPanel
            // 
            drawingPanel.BackColor = Color.White;
            drawingPanel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            drawingPanel.Location = new Point(29, 50);
            drawingPanel.Name = "drawingPanel";
            drawingPanel.Size = new Size(430, 345);
            drawingPanel.TabIndex = 5;
            drawingPanel.Paint += DrawingPanel_Paint;
            // 
            // buttonAddDepot
            // 
            buttonAddDepot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddDepot.ForeColor = Color.Green;
            buttonAddDepot.Location = new Point(484, 50);
            buttonAddDepot.Name = "buttonAddDepot";
            buttonAddDepot.Size = new Size(228, 41);
            buttonAddDepot.TabIndex = 6;
            buttonAddDepot.Text = "Добавить склад";
            buttonAddDepot.UseVisualStyleBackColor = true;
            buttonAddDepot.Click += ButtonAddDepot_Click;
            // 
            // buttonAddPoint
            // 
            buttonAddPoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonAddPoint.ForeColor = Color.Green;
            buttonAddPoint.Location = new Point(484, 108);
            buttonAddPoint.Name = "buttonAddPoint";
            buttonAddPoint.Size = new Size(228, 41);
            buttonAddPoint.TabIndex = 7;
            buttonAddPoint.Text = "Добавить заказ";
            buttonAddPoint.UseVisualStyleBackColor = true;
            buttonAddPoint.Click += ButtonAddPoint_Click;
            // 
            // buttonRemoveDepot
            // 
            buttonRemoveDepot.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRemoveDepot.ForeColor = Color.Red;
            buttonRemoveDepot.Location = new Point(484, 168);
            buttonRemoveDepot.Name = "buttonRemoveDepot";
            buttonRemoveDepot.Size = new Size(228, 41);
            buttonRemoveDepot.TabIndex = 8;
            buttonRemoveDepot.Text = "Удалить склад";
            buttonRemoveDepot.UseVisualStyleBackColor = true;
            buttonRemoveDepot.Click += ButtonRemoveDepot_Click;
            // 
            // buttonRemovePoint
            // 
            buttonRemovePoint.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonRemovePoint.ForeColor = Color.Red;
            buttonRemovePoint.Location = new Point(484, 230);
            buttonRemovePoint.Name = "buttonRemovePoint";
            buttonRemovePoint.Size = new Size(228, 41);
            buttonRemovePoint.TabIndex = 9;
            buttonRemovePoint.Text = "Удалить заказ";
            buttonRemovePoint.UseVisualStyleBackColor = true;
            buttonRemovePoint.Click += ButtonRemovePoint_Click;
            // 
            // richTextBoxOutput
            // 
            richTextBoxOutput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            richTextBoxOutput.Location = new Point(29, 414);
            richTextBoxOutput.Name = "richTextBoxOutput";
            richTextBoxOutput.ReadOnly = true;
            richTextBoxOutput.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxOutput.Size = new Size(683, 78);
            richTextBoxOutput.TabIndex = 10;
            richTextBoxOutput.Text = "";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI Black", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label.ForeColor = Color.Red;
            label.Location = new Point(29, 9);
            label.Name = "label";
            label.Size = new Size(145, 31);
            label.TabIndex = 11;
            label.Text = "Я-доставка";
            // 
            // buttonGetOrder
            // 
            buttonGetOrder.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonGetOrder.ForeColor = Color.Black;
            buttonGetOrder.Location = new Point(484, 292);
            buttonGetOrder.Name = "buttonGetOrder";
            buttonGetOrder.Size = new Size(228, 41);
            buttonGetOrder.TabIndex = 12;
            buttonGetOrder.Text = "Получить заказ";
            buttonGetOrder.UseVisualStyleBackColor = true;
            buttonGetOrder.Click += ButtonGetOrder_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PeachPuff;
            ClientSize = new Size(740, 513);
            Controls.Add(buttonGetOrder);
            Controls.Add(label);
            Controls.Add(richTextBoxOutput);
            Controls.Add(buttonRemovePoint);
            Controls.Add(buttonRemoveDepot);
            Controls.Add(buttonAddPoint);
            Controls.Add(buttonAddDepot);
            Controls.Add(drawingPanel);
            Controls.Add(buttonExecute);
            Name = "Form1";
            Text = "Я-доставка";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonExecute;
        private Panel drawingPanel;
        private Button buttonAddDepot;
        private Button buttonAddPoint;
        private Button buttonRemoveDepot;
        private Button buttonRemovePoint;
        private RichTextBox richTextBoxOutput;
        private Label label;
        private Button buttonGetOrder;
    }
}
