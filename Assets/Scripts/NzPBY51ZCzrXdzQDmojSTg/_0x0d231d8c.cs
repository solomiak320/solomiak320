using UnityEngine;

// CASINO_GOLD preset with the brief's accents. Every entry is an INDEPENDENT literal:
// no static field here reads another static field and no static method feeds an
// initializer (C.52 - string encryption turns constants into runtime-initialized
// fields and declaration reordering would then kill the whole type).
public static class _0x0d231d8c
{
    public static readonly Color GoldLight = new Color(0.961f, 0.843f, 0.478f, 1f); // #F5D77A
    public static readonly Color Royal = new Color(0.576f, 0.200f, 0.918f, 1f); // #9333EA
    public static readonly Color DeepInk = new Color(0.086f, 0.051f, 0.133f, 1f); // #160D22
    public static readonly Color Surface = new Color(0.118f, 0.071f, 0.188f, 1f); // #1E1230
    public static readonly Color Lilac = new Color(0.804f, 0.737f, 0.902f, 1f); // #CDBCE6
    // Every TEXT tint in this game is one of Cream / Gold / GoldLight / Lilac: the single
    // shared font material carries a DARK outline, so a dark face would merge with it
    // into a blot (C.14). Dark entries above are plate fills only.
    public static Color Fade(Color _0x017b72ed, float _0xbcc05970)
    {
        return new Color(_0x017b72ed.r, _0x017b72ed.g, _0x017b72ed.b, _0xbcc05970);
    }

    public static readonly Color Crimson = new Color(0.882f, 0.114f, 0.282f, 1f); // #E11D48
    public static Color Blend(Color _0x15485ff3, Color _0x32e1e2ae, float amount)
    {
        float _0x3a718170 = Mathf.Clamp01(amount);
        return new Color(_0x15485ff3.r + (_0x32e1e2ae.r - _0x15485ff3.r) * _0x3a718170, _0x15485ff3.g + (_0x32e1e2ae.g - _0x15485ff3.g) * _0x3a718170, _0x15485ff3.b + (_0x32e1e2ae.b - _0x15485ff3.b) * _0x3a718170, _0x15485ff3.a + (_0x32e1e2ae.a - _0x15485ff3.a) * _0x3a718170);
    }

    public static readonly Color Cream = new Color(0.980f, 0.961f, 1.000f, 1f); // #FAF5FF
    public static readonly Color RoyalDeep = new Color(0.420f, 0.129f, 0.659f, 1f); // #6B21A8
    public static readonly Color Muted = new Color(0.227f, 0.165f, 0.322f, 1f); // #3A2A52
    public static readonly Color Gold = new Color(0.918f, 0.702f, 0.031f, 1f); // #EAB308
    public static readonly Color ShadowInk = new Color(0.027f, 0.016f, 0.051f, 1f); // #07040D
    public static readonly Color Raised = new Color(0.141f, 0.082f, 0.220f, 1f); // #241538
}