﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using Utilities;

namespace Graphics
{
    /// <summary>
    /// 四角形クラスロジック部
    /// </summary>
    public partial class Rectangle : IDiagram
    {
        /// <summary>
        /// 長方形の大きさ
        /// </summary>
        public (int w, int h) Size { get; set; }

        /// <summary>
        /// 長方形の左上の座標
        /// </summary>
        public Vector2D TopLeft { get; set; }

        #region コンストラクタ

        /// <summary>
        /// デフォルトコンストラクタ
        /// </summary>
        public Rectangle()
            : this(0, 0)
        { }
        
        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="size">大きさ</param>
        public Rectangle((int w, int h) size)
            : this(Vector2D.GetZero, size)
        {
        }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        public Rectangle(int w, int h)
            : this(Vector2D.GetZero, (w, h))
        {
        }

        public Rectangle((int x, int y) point, (int w, int h) size)
            : this(new Vector2D(point.x, point.y), size)
        { }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="x">基準となる位置のX座標</param>
        /// <param name="y">基準となる位置のY座標</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="pos">起点の位置</param>
        public Rectangle(int x, int y, int w, int h, Location pos = Location.TopLeft)
            : this(new Vector2D(x, y), (w, h), pos)
        {
        }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="x">基準となる位置のX座標</param>
        /// <param name="y">基準となる位置のY座標</param>
        /// <param name="size">大きさ</param>
        /// <param name="pos">起点の位置</param>
        public Rectangle(int x, int y, Vector2D size, Location pos = Location.TopLeft)
            : this(new Vector2D(x, y), (size.X, size.Y), pos)
        {
        }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="point">基準となる位置</param>
        /// <param name="w">幅</param>
        /// <param name="h">高さ</param>
        /// <param name="pos">起点の位置</param>
        public Rectangle(Vector2D point, int w, int h, Location pos = Location.TopLeft)
            : this(point, (w, h), pos)
        {
        }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="point">基準となる位置</param>
        /// <param name="size">大きさ</param>
        /// <param name="pos">起点の位置</param>
        public Rectangle(Vector2D point, (int w, int h) size, Location pos = Location.TopLeft)
        {
            TopLeft = point.ToTopLeft(size, pos);
            Size = size;
        }

        public Rectangle(Vector2D point, Vector2D size, Location pos = Location.TopLeft)
            : this(point, (size.X, size.Y), pos)
        { }

        /// <summary>
        /// 長方形を作成します
        /// </summary>
        /// <param name="rectangle">コピー元の長方形</param>
        public Rectangle(Rectangle rectangle)
            : this(rectangle.TopLeft, rectangle.Size)
        {
        }

        #endregion

        public static bool operator ==(Rectangle r1, Rectangle r2)
        {
            if(r1 as object == null || r2 as object == null)
            {
                return false; 
            }

            return r1.TopLeft == r2.TopLeft
                   && r1.Size == r2.Size;
        }

        public static bool operator !=(Rectangle r1, Rectangle r2)
        {
            return !(r1 == r2);
        }

        public IDiagram MovedBy(int x, int y)
        {
            return new Rectangle(TopLeft.MovedBy(x, y), Size);
        }

        public IDiagram MovedBy(Vector2D v)
        {
            return MovedBy(v.X, v.Y);
        }

        public void MoveBy(int x, int y)
        {
            TopLeft = TopLeft.MovedBy(x, y);
        }

        public void MoveBy(Vector2D v)
        {
            MoveBy(v.X, v.Y);
        }

        /// <summary>
        /// 伸縮した長方形を返す
        /// </summary>
        /// <param name="xy">上下左右の伸縮</param>
        /// <returns>伸縮した長方形</returns>
        public Rectangle Stretched(int xy)
        {
            return Stretched(new Vector2D(xy, xy));
        }

        /// <summary>
        /// 伸縮した長方形を返す
        /// </summary>
        /// <param name="x">左右方向の伸縮</param>
        /// <param name="y">上下方向の伸縮</param>
        /// <returns>伸縮した長方形</returns>
        public Rectangle Stretched(int x, int y)
        {
            return Stretched(new Vector2D(x, y));
        }

        /// <summary>
        /// 伸縮した長方形を返す
        /// </summary>
        /// <param name="xy">上下と左右の伸縮率</param>
        /// <returns>伸縮した長方形</returns>
        public Rectangle Stretched(Vector2D xy)
        {
            return new Rectangle(TopLeft - xy, new Vector2D(Size.w, Size.h) + xy * 2);
        }

        /// <summary>
        /// 伸縮した長方形を返す
        /// </summary>
        /// <param name="top">上への伸縮</param>
        /// <param name="right">右への伸縮</param>
        /// <param name="bottom">下への伸縮</param>
        /// <param name="left">左への伸縮</param>
        /// <returns>伸縮した長方形</returns>
        public Rectangle Stretched(int top, int right, int bottom, int left)
        {
            return new Rectangle(
                TopLeft.X - left, 
                TopLeft.Y - top, 
                Size.w + left + right, 
                Size.h + top + bottom);
        }

        public Rectangle Scaled(double s)
        {
            return Scaled(s, s);
        }

        public Rectangle Scaled(double sx, double sy)
        {
            return new Rectangle(
                TopLeft.X + Size.w / 2,
                TopLeft.Y + Size.h / 2, 
                (int)(Size.w * sx), 
                (int)(Size.h * sy));
        }

        public Rectangle Scaled(Vector2D s)
        {
            return Scaled(s.X, s.Y);
        }

        public Rectangle ScaledAt(double x, double y, double s)
        {
            return ScaledAt(x, y, s, s);
        }

        public Rectangle ScaledAt(double x, double y, double sx, double sy)
        {
            return new Rectangle(
                (int)(x + (TopLeft.X - x) * sx),
                (int)(y + (TopLeft.Y - y) * sy),
                (int)(Size.w * sx),
                (int)(Size.h * sy));
        }

        public Rectangle ScaledAt(double x, double y, Vector2D s)
        {
            return ScaledAt(x, y, s.X, s.Y);
        }

        public Rectangle ScaledAt(Vector2D pos, double s)
        {
            return ScaledAt(pos.X, pos.Y, s, s);
        }

        public Rectangle ScaledAt(Vector2D pos, double sx, double sy)
        {
            return ScaledAt(pos.X, pos.Y, sx, sy);
        }

        public Rectangle ScaledAt(Vector2D pos, Vector2D s)
        {
            return ScaledAt(pos.X, pos.Y, s.X, s.Y);
        }

        #region 座標取得
        public Vector2D TopRight
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w, TopLeft.Y);
            }
        }

        public Vector2D BottomLeft
        {
            get
            {
                return new Vector2D(TopLeft.X, TopLeft.Y + Size.h);
            }
        }

        public Vector2D BottomRight
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w, TopLeft.Y + Size.h);
            }
        }

        public Vector2D TopCenter
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w / 2, TopLeft.Y);
            }
        }

        public Vector2D BottomCenter
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w / 2, TopLeft.Y + Size.h);
            }
        }

        public Vector2D LeftCenter
        {
            get
            {
                return new Vector2D(TopLeft.X, TopLeft.Y + Size.h / 2);
            }
        }

        public Vector2D RightCenter
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w, TopLeft.Y + Size.h / 2);
            }
        }

        public Vector2D Center
        {
            get
            {
                return new Vector2D(TopLeft.X + Size.w / 2, TopLeft.Y + Size.h / 2);
            }
        }

        #endregion

        public override bool Equals(object obj)
        {
            var rect = obj as Rectangle;
            return rect != null && Size.Equals(rect.Size) && TopLeft.Equals(rect.TopLeft);
        }

        public override int GetHashCode()
        {
            return -1986401011 ^ Size.GetHashCode() ^ TopLeft.GetHashCode();
        }

        public override string ToString()
        {
            return $"原点 : {TopLeft}, 大きさ : {Size}";
        }

        public object Clone()
        {
            return new Rectangle(this);
        }

        //  当たり判定

        public bool Intersects(Rectangle rect)
        {
            return Intersections.Intersect(this, rect);
        }

        public bool Intersects(Triangle triangle)
        {
            return Intersections.Intersect(this, triangle);
        }

        public bool Intersects(Line line)
        {
            return Intersections.Intersect(this, line);
        }

        public bool Intersects(Circle circle)
        {
            return Intersections.Intersect(this, circle);
        }
    }
}