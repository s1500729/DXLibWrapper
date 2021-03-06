﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Utilities;

namespace DiagramTest
{
    using Point = Vector2D;
    using Vec2 = Vector2D;

    [TestClass]
    public class Vector2DTest
    {
        [TestMethod]
        public void コンストラクタ()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(p1);

            Assert.AreEqual(p1, p2);
        }

        [TestMethod]
        public void ゼロであるか()
        {
            Point p1 = new Point(0, 0);

            Assert.IsTrue(p1.IsZero());
        }

        [TestMethod]
        public void 等価()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(1, 2);

            Assert.IsTrue(p1 == p2);
            Assert.IsTrue(p1.Equals(p2));

            p2 = new Point(2, 1);
            Assert.IsTrue(p1 != p2);
        }

        [TestMethod]
        public void 足し算()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(-2, 3);
            Point ans = new Point(-1, 5);

            Assert.AreEqual(p1 + p2, ans);
            Assert.AreEqual(p2 + p1, ans);
        }

        [TestMethod]
        public void 引き算()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(-2, 3);

            Assert.AreEqual(p1 - p2, new Point(3, -1));
            Assert.AreEqual(p2 - p1, new Point(-3, 1));
        }

        [TestMethod]
        public void 掛け算()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(-2, 3);
            Point ans = new Point(-2, 6);

            Assert.AreEqual(p1 * p2, ans);
            Assert.AreEqual(p2 * p1, ans);

            Assert.AreEqual(p1 * 3, new Point(3, 6));
        }

        [TestMethod]
        public void 割り算()
        {
            Vec2 p1 = new Vec2(4, 2);
            Vec2 p2 = new Vec2(-2, 2);

            Assert.AreEqual(p1 / p2, new Vec2(-2, 1));
            Assert.AreEqual(p2 / p1, new Vec2(0, 1));

            Assert.AreEqual(p1 / 2, new Vec2(2, 1));
        }

        [TestMethod]
        public void Move1()
        {
            Point p1 = new Point(1, 2);

            Assert.AreEqual(p1.MovedBy(2, 2), new Point(3, 4));

            p1.MoveBy(2, 2);
            Assert.AreEqual(p1, new Point(3, 4));
        }

        [TestMethod]
        public void Move2()
        {
            Point p1 = new Point(1, 2);
            Point p2 = new Point(2, 2);

            Assert.AreEqual(p1.MovedBy(p2), new Point(3, 4));

            p1.MoveBy(p2);
            Assert.AreEqual(p1, new Point(3, 4));
        }

        [TestMethod]
        public void 距離()
        {
            Point p1 = new Point(2, 2);
            Point p2 = new Point(1, 2);

            Assert.AreEqual(p2.DistanceFrom(p1), 1.0);
        }

        [TestMethod]
        public void 回転()
        {
            Vec2 p1 = new Vec2(1, 2);
            p1.Rotate(Math.PI);
            
            Assert.AreEqual(p1, new Vec2(-1, -2));
        }

        [TestMethod]
        public void 角度()
        {
            Vec2 p1 = new Vec2(1, 1);
            Vec2 p2 = new Vec2(-1, 1);

            Assert.AreEqual(p1.GetAngle(p2) * 180 / Math.PI, -90);
        }

        [TestMethod]
        public void 座標()
        {
            int x = 1, y = 2;
            Point p1 = new Point(x, y);

            Assert.AreEqual(p1.XX, new Point(x, x));
            Assert.AreEqual(p1.XY, new Point(x, y));
            Assert.AreEqual(p1.YX, new Point(y, x));
            Assert.AreEqual(p1.YY, new Point(y, y));
        }
    }

}