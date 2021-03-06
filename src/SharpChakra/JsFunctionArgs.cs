﻿using System;

namespace SharpChakra
{
    public struct JsFunctionArgs
    {
        public JsValue Callee { get; set; }

        public bool IsConstructCall { get; set; }

        public JsValue[] Arguments { get; set; }

        public ushort ArgumentCount { get; set; }

        public IntPtr CallbackData { get; set; }
    }
}