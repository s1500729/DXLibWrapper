﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DxLibUtilities
{
    interface IInput<T>
    {
        void Update();

        /// <summary>
        /// 押され始めたか
        /// </summary>
        bool IsDown(T code);

        /// <summary>
        /// 押されているか
        /// </summary>
        bool IsPressed(T code);

        /// <summary>
        /// 離され始めたか
        /// </summary>
        bool IsRelease(T code);

        /// <summary>
        /// 離されているか
        /// </summary>
        bool IsUp(T code);
    }
}
