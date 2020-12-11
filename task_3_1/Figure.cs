using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_1
{
    class Figure
    {
        PointF[] points;
        float R;
        Color color; 
        RoundedConner roundedConner = new RoundedConner();

        public void DrawFigure(Graphics graphics)
        {
            for (int i = 0, k = 1, z = 2; i < points.Length; i++, k++, z++)
            {
                roundedConner.DrawRoundedCorner(graphics, points[k], points[i], points[z], R, color);
                if (k == points.Length - 1) k = -1;
                if (z == points.Length - 1) z = -1;
            }
        }

        public void setColor(Color color)
        {
            this.color = color; 
        }

        public void setRadious(float R)
        {
            this.R = R; 
        }
        
        public void setPoints(PointF[] points)
        {
            this.points = points; 
        }

        public PointF[] GetPoints()
        {
            return points; 
        }
    }
}
