using UnityEngine;

// Three dressed rooms. A room changes the drape tint, the arch tint, the trim colour,
// the emblem tint and the reel-frame tint - a real, screenshot-visible change, which is
// what rule C.7 asks of the button that applies it. Room names are ROOM names, never the
// app name. No constructor (C.59): static lookups only.
public static class _0xdd6c3e6b
{
    public static Color Trim(int _0x0f2c2430)
    {
        if (_0x0f2c2430 <= 1)
            return new Color(0.576f, 0.200f, 0.918f, 1f); // royal amethyst
        if (_0x0f2c2430 == 2)
            return new Color(0.918f, 0.702f, 0.031f, 1f); // gold
        return new Color(0.882f, 0.114f, 0.282f, 1f); // crimson
    }

    public static string Flavour(int _0xe307ceff)
    {
        if (_0xe307ceff <= 1)
            return _0xcd88a1f7._0x2240bfc3(new byte[25] { 4, 24, 21, 112, 24, 31, 5, 3, 21, 112, 28, 25, 23, 24, 4, 3, 112, 3, 4, 17, 9, 112, 28, 31, 7 }, 80);
        if (_0xe307ceff == 2)
            return _0xcd88a1f7._0x2240bfc3(new byte[20] { 72, 91, 72, 95, 84, 45, 95, 76, 68, 65, 45, 68, 94, 45, 74, 68, 65, 73, 72, 73 }, 13);
        return _0xcd88a1f7._0x2240bfc3(new byte[24] { 180, 163, 162, 198, 176, 163, 170, 176, 163, 178, 202, 198, 177, 167, 170, 170, 198, 178, 169, 198, 177, 167, 170, 170 }, 230);
    }

    public static string Title(int _0xe90e0cdf)
    {
        if (_0xe90e0cdf <= 1)
            return _0xcd88a1f7._0x2240bfc3(new byte[12] { 177, 162, 171, 177, 162, 179, 199, 180, 179, 166, 160, 162 }, 231);
        if (_0xe90e0cdf == 2)
            return _0xcd88a1f7._0x2240bfc3(new byte[10] { 47, 33, 36, 44, 45, 44, 72, 42, 39, 48 }, 104);
        return _0xcd88a1f7._0x2240bfc3(new byte[15] { 23, 6, 29, 25, 7, 27, 26, 116, 19, 21, 24, 24, 17, 6, 13 }, 84);
    }

    public static Color Drape(int _0x90abfbab)
    {
        if (_0x90abfbab <= 1)
            return new Color(0.247f, 0.102f, 0.400f, 1f);
        if (_0x90abfbab == 2)
            return new Color(0.345f, 0.251f, 0.063f, 1f);
        return new Color(0.361f, 0.071f, 0.141f, 1f);
    }

    public static Color Arch(int _0xaa805abe)
    {
        if (_0xaa805abe <= 1)
            return new Color(0.420f, 0.129f, 0.659f, 1f);
        if (_0xaa805abe == 2)
            return new Color(0.961f, 0.843f, 0.478f, 1f);
        return new Color(0.961f, 0.431f, 0.498f, 1f);
    }
}

internal static class _0xcd88a1f7
{
    internal static string _0x2240bfc3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}