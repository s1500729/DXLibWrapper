﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DxLibDLL;

namespace DxLibUtilities
{
    public static class KeyCodeExtentions
    {
        public static int ToCode(this ConsoleKey key)
        {
            return key switch
            {
                ConsoleKey.Backspace => DX.KEY_INPUT_BACK,
                ConsoleKey.Tab => DX.KEY_INPUT_TAB,
                ConsoleKey.Enter => DX.KEY_INPUT_ESCAPE,
                ConsoleKey.Pause => DX.KEY_INPUT_PAUSE,
                ConsoleKey.Escape => DX.KEY_INPUT_ESCAPE,
                ConsoleKey.Spacebar => DX.KEY_INPUT_SPACE,
                ConsoleKey.PageUp => DX.KEY_INPUT_PGUP,
                ConsoleKey.PageDown => DX.KEY_INPUT_PGDN,
                ConsoleKey.End => DX.KEY_INPUT_END,
                ConsoleKey.Home => DX.KEY_INPUT_HOME,
                ConsoleKey.LeftArrow => DX.KEY_INPUT_LEFT,
                ConsoleKey.UpArrow => DX.KEY_INPUT_UP,
                ConsoleKey.RightArrow => DX.KEY_INPUT_RIGHT,
                ConsoleKey.DownArrow => DX.KEY_INPUT_DOWN,
                ConsoleKey.Insert => DX.KEY_INPUT_INSERT,
                ConsoleKey.Delete => DX.KEY_INPUT_DELETE,
                ConsoleKey.A => DX.KEY_INPUT_A,
                ConsoleKey.B => DX.KEY_INPUT_B,
                ConsoleKey.C => DX.KEY_INPUT_C,
                ConsoleKey.D => DX.KEY_INPUT_D,
                ConsoleKey.E => DX.KEY_INPUT_E,
                ConsoleKey.F => DX.KEY_INPUT_F,
                ConsoleKey.G => DX.KEY_INPUT_G,
                ConsoleKey.H => DX.KEY_INPUT_H,
                ConsoleKey.I => DX.KEY_INPUT_I,
                ConsoleKey.J => DX.KEY_INPUT_J,
                ConsoleKey.K => DX.KEY_INPUT_K,
                ConsoleKey.L => DX.KEY_INPUT_L,
                ConsoleKey.M => DX.KEY_INPUT_M,
                ConsoleKey.N => DX.KEY_INPUT_N,
                ConsoleKey.O => DX.KEY_INPUT_O,
                ConsoleKey.P => DX.KEY_INPUT_P,
                ConsoleKey.Q => DX.KEY_INPUT_Q,
                ConsoleKey.R => DX.KEY_INPUT_R,
                ConsoleKey.S => DX.KEY_INPUT_S,
                ConsoleKey.T => DX.KEY_INPUT_T,
                ConsoleKey.U => DX.KEY_INPUT_U,
                ConsoleKey.V => DX.KEY_INPUT_V,
                ConsoleKey.W => DX.KEY_INPUT_W,
                ConsoleKey.X => DX.KEY_INPUT_X,
                ConsoleKey.Y => DX.KEY_INPUT_Y,
                ConsoleKey.Z => DX.KEY_INPUT_Z,
                ConsoleKey.NumPad0 => DX.KEY_INPUT_NUMPAD0,
                ConsoleKey.NumPad1 => DX.KEY_INPUT_NUMPAD1,
                ConsoleKey.NumPad2 => DX.KEY_INPUT_NUMPAD2,
                ConsoleKey.NumPad3 => DX.KEY_INPUT_NUMPAD3,
                ConsoleKey.NumPad4 => DX.KEY_INPUT_NUMPAD4,
                ConsoleKey.NumPad5 => DX.KEY_INPUT_NUMPAD5,
                ConsoleKey.NumPad6 => DX.KEY_INPUT_NUMPAD6,
                ConsoleKey.NumPad7 => DX.KEY_INPUT_NUMPAD7,
                ConsoleKey.NumPad8 => DX.KEY_INPUT_NUMPAD8,
                ConsoleKey.NumPad9 => DX.KEY_INPUT_NUMPAD9,
                ConsoleKey.Multiply => DX.KEY_INPUT_MULTIPLY,
                ConsoleKey.Add => DX.KEY_INPUT_ADD,
                ConsoleKey.Subtract => DX.KEY_INPUT_SUBTRACT,
                ConsoleKey.Decimal => DX.KEY_INPUT_DECIMAL,
                ConsoleKey.Divide => DX.KEY_INPUT_DIVIDE,
                ConsoleKey.F1 => DX.KEY_INPUT_F1,
                ConsoleKey.F2 => DX.KEY_INPUT_F2,
                ConsoleKey.F3 => DX.KEY_INPUT_F3,
                ConsoleKey.F4 => DX.KEY_INPUT_F4,
                ConsoleKey.F5 => DX.KEY_INPUT_F5,
                ConsoleKey.F6 => DX.KEY_INPUT_F6,
                ConsoleKey.F7 => DX.KEY_INPUT_F7,
                ConsoleKey.F8 => DX.KEY_INPUT_F8,
                ConsoleKey.F9 => DX.KEY_INPUT_F9,
                ConsoleKey.F10 => DX.KEY_INPUT_F10,
                ConsoleKey.F11 => DX.KEY_INPUT_F11,
                ConsoleKey.F12 => DX.KEY_INPUT_F12,
                ConsoleKey.D0 => DX.KEY_INPUT_0,
                ConsoleKey.D1 => DX.KEY_INPUT_1,
                ConsoleKey.D2 => DX.KEY_INPUT_2,
                ConsoleKey.D3 => DX.KEY_INPUT_3,
                ConsoleKey.D4 => DX.KEY_INPUT_4,
                ConsoleKey.D5 => DX.KEY_INPUT_5,
                ConsoleKey.D6 => DX.KEY_INPUT_6,
                ConsoleKey.D7 => DX.KEY_INPUT_7,
                ConsoleKey.D8 => DX.KEY_INPUT_8,
                ConsoleKey.D9 => DX.KEY_INPUT_9,
                _ => throw new ArgumentException()
            };
        }
    }
}
