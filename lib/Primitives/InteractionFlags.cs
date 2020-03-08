namespace Elementary.Primitives
{
    using System;

    [Flags]
    public enum InteractionFlags : byte
    {
        None            = 0x0,
        Electromagnetic = 0x1 << 0,
        Weak            = 0x1 << 1,
        Strong          = 0x1 << 2,
        Gravity         = 0x1 << 3,
        /// <summary>
        /// https://en.wikipedia.org/wiki/Fifth_force
        /// </summary>
        Quintessence    = 0x1 << 4
    }
}