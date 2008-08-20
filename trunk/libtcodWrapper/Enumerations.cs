﻿using System;
using System.Collections.Generic;
using System.Text;

namespace libtcodWrapper
{
    /// <summary>
    /// Blending mode flags for the background object.
    /// </summary>
    public enum BackgroundFlag
    {
        #pragma warning disable 1591  //Disable warning about lack of xml comments
        None,
        Set,
        Multiply,
        Lighten,
        Darken,
        Screen,
        ColorDodge,
        ColorBurn,
        Add,
        AddA,
        Burn,
        Overlay,
        Alph
        #pragma warning restore 1591
    };

    /// <summary>
    /// Types of "special" keycodes"
    /// </summary>
    public enum KeyCode
    {
        #pragma warning disable 1591    //Disable warning about lack of xml comments
        TCODK_NONE,
        TCODK_ESCAPE,
        TCODK_BACKSPACE,
        TCODK_TAB,
        TCODK_ENTER,
        TCODK_SHIFT,
        TCODK_CONTROL,
        TCODK_ALT,
        TCODK_PAUSE,
        TCODK_CAPSLOCK,
        TCODK_PAGEUP,
        TCODK_PAGEDOWN,
        TCODK_END,
        TCODK_HOME,
        TCODK_UP,
        TCODK_LEFT,
        TCODK_RIGHT,
        TCODK_DOWN,
        TCODK_PRINTSCREEN,
        TCODK_INSERT,
        TCODK_DELETE,
        TCODK_LWIN,
        TCODK_RWIN,
        TCODK_APPS,
        TCODK_0,
        TCODK_1,
        TCODK_2,
        TCODK_3,
        TCODK_4,
        TCODK_5,
        TCODK_6,
        TCODK_7,
        TCODK_8,
        TCODK_9,
        TCODK_KP0,
        TCODK_KP1,
        TCODK_KP2,
        TCODK_KP3,
        TCODK_KP4,
        TCODK_KP5,
        TCODK_KP6,
        TCODK_KP7,
        TCODK_KP8,
        TCODK_KP9,
        TCODK_KPADD,
        TCODK_KPSUB,
        TCODK_KPDIV,
        TCODK_KPMUL,
        TCODK_KPDEC,
        TCODK_KPENTER,
        TCODK_F1,
        TCODK_F2,
        TCODK_F3,
        TCODK_F4,
        TCODK_F5,
        TCODK_F6,
        TCODK_F7,
        TCODK_F8,
        TCODK_F9,
        TCODK_F10,
        TCODK_F11,
        TCODK_F12,
        TCODK_NUMLOCK,
        TCODK_SCROLLLOCK,
        TCODK_SPACE,
        TCODK_CHAR
        #pragma warning restore 1591  //Disable warning about lack of xml comments
    }

    /// <summary>
    /// Is event returned when key is pressed, release, or both?
    /// </summary>
    public enum KeyPressType
    {
        #pragma warning disable 1591    //Disable warning about lack of xml comments
        Pressed = 1,
        Released = 2,
        PressedAndReleased = 3
        #pragma warning restore 1591  //Disable warning about lack of xml comments
    };

    /// <summary>
    /// Types of alignment for printing of strings
    /// </summary>
    public enum LineAlignment
    {
        #pragma warning disable 1591  //Disable warning about lack of xml comments
        Left,
        Right,
        Center
        #pragma warning restore 1591  //Disable warning about lack of xml comments
    }

    /// <summary>
    /// "Special" ascii characters such as arrows and lines
    /// </summary>
    public static class SpecialCharacter
    {
        #pragma warning disable 1591  //Disable warning about lack of xml comments
        public const byte HLINE = 196;
        public const byte VLINE = 179;
        public const byte NE = 191;
        public const byte NW = 218;
        public const byte SE = 217;
        public const byte SW = 192;
        public const byte DHLINE = 205;
        public const byte DVLINE = 186;
        public const byte DNE = 187;
        public const byte DNW = 201;
        public const byte DSE = 188;
        public const byte DSW = 200;
        public const byte TEEW = 180;
        public const byte TEEE = 195;
        public const byte TEEN = 193;
        public const byte TEES = 194;
        public const byte DTEEW = 181;
        public const byte DTEEE = 198;
        public const byte DTEEN = 208;
        public const byte DTEES = 210;
        public const byte CHECKER = 178;
        public const byte BLOCK = 219;
        public const byte BLOCK1 = 178;
        public const byte BLOCK2 = 177;
        public const byte BLOCK3 = 176;
        public const byte BLOCK_B = 220;
        public const byte BLOCK_T = 223;
        public const byte DS_CROSSH = 216;
        public const byte DS_CROSSV = 215;
        public const byte CROSS = 197;
        public const byte LIGHT = 15;
        public const byte TREE = 5;
        public const byte ARROW_N = 24;
        public const byte ARROW_S = 25;
        public const byte ARROW_E = 26;
        public const byte ARROW_W = 27;
        #pragma warning restore 1591  //Disable warning about lack of xml comments
    };
}