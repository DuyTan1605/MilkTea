using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;


namespace ePOSOne.btnProduct
{
   
public class ButtonModified : System.Windows.Forms.Button
    {
        //we can use this to modify the color of the border 
        public Color BorderColor = Color.White;
        //we can use this to modify the border size
        public int BorderSize = 3;
        public ButtonModified()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.DeepSkyBlue;
            FlatAppearance.BorderColor = BorderColor;
            FlatAppearance.BorderSize = BorderSize;
            Font = new System.Drawing.Font("VAGRounded-Light",
            30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));

        }


        int top;
        int left;
        int right;
        int bottom;

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // to draw the control using base OnPaint
            base.OnPaint(pevent);
            //to modify the corner radius
            int CornerRadius = 23;

            Pen DrawPen = new Pen(BorderColor);
            GraphicsPath gfxPath_mod = new GraphicsPath();

            top = 0;
            left = 0;
            right = Width;
            bottom = Height;

            gfxPath_mod.AddArc(left, top, CornerRadius, CornerRadius, 180, 90);
            gfxPath_mod.AddArc(right - CornerRadius, top, CornerRadius, CornerRadius, 270, 90);
            gfxPath_mod.AddArc(right - CornerRadius, bottom - CornerRadius,
                CornerRadius, CornerRadius, 0, 90);
            gfxPath_mod.AddArc(left, bottom - CornerRadius, CornerRadius, CornerRadius, 90, 90);

            gfxPath_mod.CloseAllFigures();

            pevent.Graphics.DrawPath(DrawPen, gfxPath_mod);

            int inside = 1;

            Pen newPen = new Pen(BorderColor, BorderSize);
            GraphicsPath gfxPath = new GraphicsPath();
            gfxPath.AddArc(left + inside + 1, top + inside, CornerRadius, CornerRadius, 180, 100);

            gfxPath.AddArc(right - CornerRadius - inside - 2,
                top + inside, CornerRadius, CornerRadius, 270, 90);
            gfxPath.AddArc(right - CornerRadius - inside - 2,
                bottom - CornerRadius - inside - 1, CornerRadius, CornerRadius, 0, 90);

            gfxPath.AddArc(left + inside + 1,
            bottom - CornerRadius - inside, CornerRadius, CornerRadius, 95, 95);
            pevent.Graphics.DrawPath(newPen, gfxPath);

            this.Region = new System.Drawing.Region(gfxPath_mod);
        }
    }


public class RoundLabel : Label
{
    [Browsable(true)]
    public Color _BackColor = Color.DeepSkyBlue;

    public RoundLabel()
    {
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        using (var graphicsPath = _getRoundRectangle(this.ClientRectangle))
        {
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using (var brush = new SolidBrush(_BackColor))
                e.Graphics.FillPath(brush, graphicsPath);
            using (var pen = new Pen(_BackColor, 1.0f))
                e.Graphics.DrawPath(pen, graphicsPath);
            TextRenderer.DrawText(e.Graphics, Text, this.Font, this.ClientRectangle, this.ForeColor);
        }

        ControlPaint.DrawBorder(e.Graphics, ClientRectangle,
                                    Color.White, 3, ButtonBorderStyle.Solid,
                                    Color.White, 3, ButtonBorderStyle.Solid,
                                    Color.White, 3, ButtonBorderStyle.Solid,
                                    Color.White, 3, ButtonBorderStyle.Solid);

    }

    private GraphicsPath _getRoundRectangle(Rectangle rectangle)
    {

        int cornerRadius = 20; // change this value according to your needs
        int diminisher = 1;
        GraphicsPath path = new GraphicsPath();
        path.AddArc(rectangle.X, rectangle.Y, cornerRadius, cornerRadius, 180, 90);
        path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y, cornerRadius, cornerRadius, 270, 90);
        path.AddArc(rectangle.X + rectangle.Width - cornerRadius - diminisher, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 0, 90);
        path.AddArc(rectangle.X, rectangle.Y + rectangle.Height - cornerRadius - diminisher, cornerRadius, cornerRadius, 90, 90);
        path.CloseAllFigures();
        return path;
    }
}

}