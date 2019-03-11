﻿using System.Drawing;
using DxLibDLL;
using DxLibUtilities;

namespace Diagram
{
    /// <summary>
    /// 四角形クラス描画部
    /// </summary>
    public partial class Rectangle
    {
        private void draw(Color color, bool isFill)
        {
            int x = Origin.X, y = Origin.Y;
            int w = Size.w, h = Size.h;
            
            DX.DrawBox(x, y, x + w, y + h, color.ToDxColor(), isFill ? 1:0);
        }

        public void Draw(Color color)
        {
            draw(color, isFill: true);
        }

        public void DrawFrame(Color color)
        {
            draw(color, isFill: false);
        }
        
        public bool Intersects(Rectangle rect)
        {
            return Intersections.Intersects(this, rect);
        }

        public bool Intersects(Circle circle)
        {
            return Intersections.Intersects(this, circle);
        }

        public bool Intersects(Line line)
        {
            return Intersections.Intersects(this, line);
        }
    }
}
