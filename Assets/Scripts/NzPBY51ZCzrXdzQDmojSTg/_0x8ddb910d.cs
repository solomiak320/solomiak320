using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The room dressing both scenes share: two flanking drape columns, a proscenium arch
// band, a warm footlight gradient and a vignette. Every piece is a tinted UGUI Image, so
// changing the room really repaints the screen - that is the visible confirmation rule
// C.7 asks of DRESS THE ROOM, not a label swap.
// Light here is always a gradient that fades out, never a shape with an edge.
// No constructor (C.59): new TheatreDecor().Init(...).
public sealed class _0x8ddb910d
{
    public void _0x71079683()
    {
        if (this._0xb4d2fba1 != null)
        {
            DOTween.Kill(this._0xb4d2fba1.gameObject);
        }

        if (this._0x12afcb9a != null)
        {
            for (int _0x0b9a3459 = 0; _0x0b9a3459 < this._0x12afcb9a.Length; _0x0b9a3459++)
            {
                if (this._0x12afcb9a[_0x0b9a3459] != null)
                {
                    DOTween.Kill(this._0x12afcb9a[_0x0b9a3459].gameObject);
                }
            }
        }

        if (this._0x33c087a3 != null)
        {
            for (int _0x448e2587 = 0; _0x448e2587 < this._0x33c087a3.Length; _0x448e2587++)
            {
                if (this._0x33c087a3[_0x448e2587] != null)
                {
                    DOTween.Kill(this._0x33c087a3[_0x448e2587].gameObject);
                }
            }
        }

        if (this._0x8df0e47d != null)
        {
            DOTween.Kill(this._0x8df0e47d.gameObject);
        }

        if (this._0x542da1b0 != null)
        {
            DOTween.Kill(this._0x542da1b0.gameObject);
        }
    }

    private Image _0x8df0e47d;
    public void _0xf5d5498e(int _0xcee617e5, bool _0xda06efca)
    {
        Color _0xeb5c72b4 = _0xdd6c3e6b.Drape(_0xcee617e5);
        Color _0xf7a791e6 = _0xdd6c3e6b.Arch(_0xcee617e5);
        for (int _0x4ea20004 = 0; _0x4ea20004 < this._0x12afcb9a.Length; _0x4ea20004++)
        {
            Image _0xab764649 = this._0x12afcb9a[_0x4ea20004];
            if (_0xab764649 == null)
            {
                continue;
            }

            Color _0x2d23d503 = _0x0d231d8c.Fade(_0xeb5c72b4, _0xab764649.color.a);
            if (_0xda06efca)
            {
                _0xab764649.DOColor(_0x2d23d503, 0.32f).SetLink(_0xab764649.gameObject);
            }
            else
            {
                _0xab764649.color = _0x2d23d503;
            }
        }

        for (int _0xc3036056 = 0; _0xc3036056 < this._0x33c087a3.Length; _0xc3036056++)
        {
            Image _0x73c9d337 = this._0x33c087a3[_0xc3036056];
            if (_0x73c9d337 == null)
            {
                continue;
            }

            Color _0x4ac54d93 = _0x0d231d8c.Fade(_0xf7a791e6, _0x73c9d337.color.a);
            if (_0xda06efca)
            {
                _0x73c9d337.DOColor(_0x4ac54d93, 0.32f).SetLink(_0x73c9d337.gameObject);
            }
            else
            {
                _0x73c9d337.color = _0x4ac54d93;
            }
        }

        if (this._0x542da1b0 != null)
        {
            Color _0xead59328 = _0x0d231d8c.Fade(_0xf7a791e6, 0.16f);
            if (_0xda06efca)
            {
                this._0x542da1b0.DOColor(_0xead59328, 0.32f).SetLink(this._0x542da1b0.gameObject);
            }
            else
            {
                this._0x542da1b0.color = _0xead59328;
            }
        }
    }

    private Image[] _0x12afcb9a;
    private Image _0x542da1b0;
    public _0x8ddb910d _0x588decef(RectTransform _0x286fa938, _0x41b355c2 _0xb5a636e8, int _0x2749c4cd)
    {
        Sprite _0x76c86ee6 = _0xb5a636e8 != null ? _0xb5a636e8.Round : null;
        Sprite _0x918cd528 = _0xb5a636e8 != null ? _0xb5a636e8.Soft : null;
        this._0xb4d2fba1 = _0x0bb64a0b.Stretch(_0x286fa938, _0x0c0f611e._0xea4c84b4(new byte[12] { 216, 228, 233, 237, 248, 254, 233, 200, 233, 239, 227, 254 }, 140));
        this._0x8df0e47d = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[8] { 19, 44, 34, 43, 32, 49, 49, 32 }, 69), Vector2.zero, new Vector2(_0x0bb64a0b.PanelWidth + 120f, _0x0bb64a0b.PanelHeight + 120f), _0x918cd528, _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.55f), 0.9f);
        this._0x12afcb9a = new Image[6];
        for (int _0x409e0349 = 0; _0x409e0349 < 3; _0x409e0349++)
        {
            float width = 126f - _0x409e0349 * 26f;
            float _0x621e64c8 = 0.5f * _0x0bb64a0b.PanelWidth - 46f - _0x409e0349 * 86f;
            float _0x2d6b7a37 = 0.20f - _0x409e0349 * 0.045f;
            this._0x12afcb9a[_0x409e0349 * 2] = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[6] { 251, 205, 222, 207, 218, 243 }, 191) + _0x409e0349.ToString(), new Vector2(-_0x621e64c8, 180f), new Vector2(width, _0x0bb64a0b.PanelHeight * 0.78f), _0x76c86ee6, _0x0d231d8c.Fade(_0x0d231d8c.Royal, _0x2d6b7a37), 2.2f);
            this._0x12afcb9a[_0x409e0349 * 2 + 1] = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[6] { 2, 52, 39, 54, 35, 20 }, 70) + _0x409e0349.ToString(), new Vector2(_0x621e64c8, 180f), new Vector2(width, _0x0bb64a0b.PanelHeight * 0.78f), _0x76c86ee6, _0x0d231d8c.Fade(_0x0d231d8c.Royal, _0x2d6b7a37), 2.2f);
        }

        this._0x33c087a3 = new Image[3];
        this._0x33c087a3[0] = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[8] { 25, 42, 59, 48, 26, 57, 54, 60 }, 88), _0x0bb64a0b.At(0.5f, 0.962f), new Vector2(_0x0bb64a0b.PanelWidth - 40f, 26f), _0x76c86ee6, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.55f), 8f);
        this._0x33c087a3[1] = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[8] { 151, 164, 181, 190, 145, 186, 185, 161 }, 214), _0x0bb64a0b.At(0.5f, 0.930f), new Vector2(_0x0bb64a0b.PanelWidth - 140f, 120f), _0x918cd528, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.14f), 1.1f);
        this._0x33c087a3[2] = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[8] { 165, 150, 135, 140, 182, 145, 136, 129 }, 228), _0x0bb64a0b.At(0.5f, 0.900f), new Vector2(_0x0bb64a0b.PanelWidth - 260f, 6f), _0x76c86ee6, _0x0d231d8c.Fade(_0x0d231d8c.GoldLight, 0.40f), 8f);
        this._0x542da1b0 = _0x0bb64a0b.Plate(this._0xb4d2fba1, _0x0c0f611e._0xea4c84b4(new byte[9] { 53, 28, 28, 7, 31, 26, 20, 27, 7 }, 115), _0x0bb64a0b.At(0.5f, 0.02f), new Vector2(_0x0bb64a0b.PanelWidth + 60f, 320f), _0x918cd528, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.16f), 1.0f);
        this._0xf5d5498e(_0x2749c4cd, false);
        return this;
    }

    public RectTransform _0x2d85660f
    {
        get
        {
            return this._0xb4d2fba1;
        }
    }

    private RectTransform _0xb4d2fba1;
    private Image[] _0x33c087a3;
}

internal static class _0x0c0f611e
{
    internal static string _0xea4c84b4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}