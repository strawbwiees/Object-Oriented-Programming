
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MachineProblemWInForm
{
    public partial class UsageOfCaretSymbol : Form
    {
        private const double PI = 3.1416;

        private double currentRadius = 0;
        private bool hasCircle = false;

        public UsageOfCaretSymbol()
        {
            InitializeComponent();
            exponentresulttxt.ReadOnly = true;
            areatxt.ReadOnly = true;
            circumferencetxt.ReadOnly = true;
            diametertxt.ReadOnly = true;

            circlePanel.BackColor = Color.White;
            circlePanel.BorderStyle = BorderStyle.FixedSingle;
            circlePanel.Paint += circlePanel_Paint;
        }

        // exponent
        private void equalbtn_Click(object sender, EventArgs e)
        {
            double baseNumber;
            double power;

            if (!double.TryParse(basetxt.Text, out baseNumber) ||
                !double.TryParse(powertxt.Text, out power))
            {
                MessageBox.Show(
                    "Please enter a valid Base and Power.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            double result = Math.Pow(baseNumber, power);

            exponentresulttxt.Text = result.ToString("0.00");
        }

        //area
        private void areabtn_Click(object sender, EventArgs e)
        {
            if (!CalculateCircle())
                return;

            double area = PI * currentRadius * currentRadius;

            areatxt.Text = area.ToString("0.00");

            circlePanel.Invalidate();
        }

        //circum
        private void circumferencebtn_Click(object sender, EventArgs e)
        {
            if (!CalculateCircle())
                return;

            double circumference = 2 * PI * currentRadius;

            circumferencetxt.Text = circumference.ToString("0.00");

            circlePanel.Invalidate();
        }

        //diam
        private void diameter_Click(object sender, EventArgs e)
        {
            if (!CalculateCircle())
                return;

            double diameter = 2 * currentRadius;

            diametertxt.Text = diameter.ToString("0.00");

            circlePanel.Invalidate();
        }

        private bool CalculateCircle()
        {
            double radius;

            if (!double.TryParse(radiustxt.Text, out radius))
            {
                MessageBox.Show(
                    "Please enter a valid radius.",
                    "Invalid Input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                radiustxt.Focus();
                return false;
            }

            if (radius <= 0)
            {
                MessageBox.Show(
                    "Radius must be greater than zero.",
                    "Invalid Radius",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                radiustxt.Focus();
                return false;
            }

            currentRadius = radius;
            hasCircle = true;

            return true;
        }

        // drawing
        private void circlePanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            int panelWidth = circlePanel.ClientSize.Width;
            int panelHeight = circlePanel.ClientSize.Height;

            if (panelWidth <= 0 || panelHeight <= 0)
                return;

            // Display instructions before a radius is entered
            if (!hasCircle)
            {
                using (Font instructionFont =
                    new Font("Segoe UI", 10, FontStyle.Regular))
                using (SolidBrush textBrush =
                    new SolidBrush(Color.Gray))
                {
                    string message =
                        "Enter a radius and click\nArea, Circumference,\nor Diameter.";

                    StringFormat format = new StringFormat();
                    format.Alignment = StringAlignment.Center;
                    format.LineAlignment = StringAlignment.Center;

                    g.DrawString(
                        message,
                        instructionFont,
                        textBrush,
                        new RectangleF(5, 5,
                            panelWidth - 10, panelHeight - 10),
                        format
                    );

                    format.Dispose();
                }

                return;
            }

            float availableWidth = panelWidth - 50;
            float availableHeight = panelHeight - 65;

            if (availableWidth <= 0 || availableHeight <= 0)
                return;

            // Scale the drawing to fit the panel.
            // The actual radius is stored in currentRadius.
            float circleDiameter = Math.Min(
                availableWidth,
                availableHeight
            );

            float centerX = panelWidth / 2f;
            float centerY = (panelHeight - 25) / 2f + 5;

            float drawRadius = circleDiameter / 2f;

            RectangleF circleBounds = new RectangleF(
                centerX - drawRadius,
                centerY - drawRadius,
                circleDiameter,
                circleDiameter
            );

            // Draw a soft pink filled circle
            using (SolidBrush fillBrush =
                new SolidBrush(Color.FromArgb(255, 220, 232)))
            using (Pen outlinePen = new Pen(Color.DeepPink, 2))
            using (Pen radiusPen = new Pen(Color.DarkRed, 2))
            using (SolidBrush centerBrush =
                new SolidBrush(Color.DarkRed))
            using (Font labelFont =
                new Font("Segoe UI", 9, FontStyle.Bold))
            using (SolidBrush labelBrush =
                new SolidBrush(Color.DarkRed))
            {
                g.FillEllipse(fillBrush, circleBounds);
                g.DrawEllipse(outlinePen, circleBounds);

                // Mark the center
                g.FillEllipse(
                    centerBrush,
                    centerX - 3,
                    centerY - 3,
                    6,
                    6
                );

                // Draw the radius from the center to the edge
                g.DrawLine(
                    radiusPen,
                    centerX,
                    centerY,
                    centerX + drawRadius,
                    centerY
                );

                // Label the radius
                g.DrawString(
                    "r = " + currentRadius.ToString("0.##"),
                    labelFont,
                    labelBrush,
                    centerX + 3,
                    centerY - 20
                );

                // Draw the diameter across the circle
                using (Pen diameterPen =
                    new Pen(Color.MediumVioletRed, 1.5f))
                {
                    diameterPen.DashStyle = DashStyle.Dash;

                    g.DrawLine(
                        diameterPen,
                        centerX - drawRadius,
                        centerY,
                        centerX + drawRadius,
                        centerY
                    );
                }

                // Show the diameter value below the circle
                string diameterText =
                    "Diameter = " +
                    (2 * currentRadius).ToString("0.00");

                SizeF textSize =
                    g.MeasureString(diameterText, labelFont);

                g.DrawString(
                    diameterText,
                    labelFont,
                    labelBrush,
                    (panelWidth - textSize.Width) / 2f,
                    panelHeight - textSize.Height - 3
                );
            }
        }

        // CLEAR ALL FIELDS AND RESET THE DRAWING
        private void clearbtn_Click(object sender, EventArgs e)
        {
            basetxt.Clear();
            powertxt.Clear();
            exponentresulttxt.Clear();

            radiustxt.Clear();
            areatxt.Clear();
            circumferencetxt.Clear();
            diametertxt.Clear();

            currentRadius = 0;
            hasCircle = false;

            circlePanel.Invalidate();

            basetxt.Focus();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void basetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void powertxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void exponentresulttxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void radiustxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void areatxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void circumferencetxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void diametertxt_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
