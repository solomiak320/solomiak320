using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The seven-day strip. Coins are fictional and the only clock is the device's own, so
// nothing here touches a network and nothing can be bought: the day advances when the
// local date does, and the reward is coins that exist only inside this app.
//
// Claiming has to be VISIBLE in a screenshot (C.7), so it is not a label swap: the tile
// flips to its gold frame, coins fly across the card, an award line slides in and the
// caption on the CTA changes to the next thing worth doing. No constructor (C.59).
public sealed class _0x997c96d0
{
    private const float TileWidth = 132f;
    private const float TileGap = 14f;
    private void _0xa42f2f93()
    {
        int _0x88a7c4e3 = this._0x634c5fad();
        int _0x709f71fe = _0x24e3537a[_0x88a7c4e3];
        this._0x37e8f256._0x6789d0c8(_0x709f71fe);
        int _0x7076b88f = _0x88a7c4e3 == _0x24e3537a.Length - 1 ? 1 : 0;
        int _0x81007219 = _0x7076b88f > 0 ? this._0x0fcb2d1a._0x861447e9(_0x7076b88f) : 0;
        PlayerPrefs.SetInt(_0xe3d66f71._0x69dd2580(new byte[14] { 195, 206, 221, 135, 203, 198, 199, 220, 218, 250, 221, 200, 196, 217 }, 169), this._0x0b3e71a9());
        PlayerPrefs.SetInt(_0xe3d66f71._0x69dd2580(new byte[12] { 71, 74, 89, 3, 79, 66, 67, 88, 94, 105, 76, 84 }, 45), (_0x88a7c4e3 + 1) % _0x24e3537a.Length);
        PlayerPrefs.Save();
        string _0x3b737d08 = _0xe3d66f71._0x69dd2580(new byte[1] { 192 }, 235) + _0x0bb64a0b.Thousands(_0x709f71fe) + _0xe3d66f71._0x69dd2580(new byte[6] { 190, 221, 209, 215, 208, 205 }, 158);
        if (_0x81007219 > 0)
        {
            _0x3b737d08 = _0x3b737d08 + _0xe3d66f71._0x69dd2580(new byte[2] { 138, 171 }, 128) + _0x81007219.ToString() + _0xe3d66f71._0x69dd2580(new byte[6] { 83, 32, 59, 50, 33, 55 }, 115);
        }

        _0xf5cbd7d1.SetText(this._0x389abcd6, _0x3b737d08);
        this._0x78eb84b3.gameObject.SetActive(true);
        this._0x78eb84b3.localScale = new Vector3(0.9f, 0.9f, 1f);
        this._0x78eb84b3.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0x78eb84b3.gameObject);
        this._0x9d1e5312(_0x88a7c4e3);
        this._0xd49510aa();
        if (this.OnClaimed != null)
        {
            this.OnClaimed();
        }
    }

    private void _0x3c7f458f()
    {
        if (!this._0xc7f51a64())
        {
            if (this.OnSeeCollection != null)
            {
                this.OnSeeCollection();
            }

            return;
        }

        this._0xa42f2f93();
    }

    public void _0xd49510aa()
    {
        int _0xbf0e68ef = this._0x634c5fad();
        bool _0xb50e4bb8 = this._0xc7f51a64();
        for (int _0xde1bbd66 = 0; _0xde1bbd66 < _0x24e3537a.Length; _0xde1bbd66++)
        {
            bool _0x697bff7c = _0xde1bbd66 < _0xbf0e68ef || (_0xde1bbd66 == _0xbf0e68ef && !_0xb50e4bb8);
            bool _0x5a62cf5d = _0xde1bbd66 == _0xbf0e68ef && _0xb50e4bb8;
            this._0xc1b50620[_0xde1bbd66].color = _0x697bff7c ? _0x0d231d8c.Gold : (_0x5a62cf5d ? _0x0d231d8c.GoldLight : _0x0d231d8c.Muted);
            this._0x8408ddbf[_0xde1bbd66].color = _0x697bff7c ? _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.22f) : _0x0d231d8c.Raised;
            _0xf5cbd7d1.SetText(this._0x6298084e[_0xde1bbd66], _0x697bff7c ? _0xe3d66f71._0x69dd2580(new byte[1] { 161 }, 138) : string.Empty);
        }

        if (_0xb50e4bb8)
        {
            _0xf5cbd7d1.SetText(this._0x1f88ffed, _0xe3d66f71._0x69dd2580(new byte[4] { 109, 104, 112, 9 }, 41) + (_0xbf0e68ef + 1) + _0xe3d66f71._0x69dd2580(new byte[18] { 31, 118, 108, 31, 109, 122, 126, 123, 102, 31, 107, 112, 31, 124, 115, 126, 118, 114 }, 63));
            _0xf5cbd7d1.SetText(this._0xd6a5b61c, _0xe3d66f71._0x69dd2580(new byte[5] { 253, 242, 255, 247, 243 }, 190));
        }
        else
        {
            _0xf5cbd7d1.SetText(this._0x1f88ffed, _0xe3d66f71._0x69dd2580(new byte[8] { 51, 56, 37, 41, 93, 52, 51, 93 }, 125) + this._0x494642ac());
            _0xf5cbd7d1.SetText(this._0xd6a5b61c, _0xe3d66f71._0x69dd2580(new byte[14] { 229, 243, 243, 150, 245, 249, 250, 250, 243, 245, 226, 255, 249, 248 }, 182));
        }
    }

    private _0x8ae00696 _0x37e8f256;
    // Coins leave the claimed tile and travel to the top of the card: the change is
    // visible in a still frame, which is what rule C.7 asks for.
    private void _0x9d1e5312(int _0xdf1c1c29)
    {
        float _0x9584d65d = _0x24e3537a.Length * TileWidth + (_0x24e3537a.Length - 1) * TileGap;
        float _0x995536f2 = -_0x9584d65d * 0.5f + TileWidth * 0.5f;
        Vector2 _0x9967053d = new Vector2(_0x995536f2 + _0xdf1c1c29 * (TileWidth + TileGap), StripY);
        Vector2 _0xa7b2af21 = new Vector2(0f, 880f);
        Sprite _0x373cf64e = this._0x5ebde115 != null ? this._0x5ebde115.Coin : null;
        for (int _0x2cd68692 = 0; _0x2cd68692 < 12; _0x2cd68692++)
        {
            Image _0x98e2052d = _0x0bb64a0b.Picture(this._0x2b9c1e75, _0xe3d66f71._0x69dd2580(new byte[9] { 214, 251, 250, 225, 231, 215, 251, 253, 250 }, 148) + _0x2cd68692.ToString(), _0x9967053d, new Vector2(52f, 52f), _0x373cf64e, _0x0d231d8c.Cream);
            float _0xb3404ee4 = _0x2cd68692 * 0.04f;
            _0x98e2052d.rectTransform.DOAnchorPos(_0xa7b2af21, 0.55f).SetEase(Ease.InCubic).SetDelay(_0xb3404ee4).OnComplete(() => this._0x1dc6cece(_0x98e2052d)).SetLink(_0x98e2052d.gameObject);
            _0x98e2052d.DOFade(0.15f, 0.55f).SetDelay(_0xb3404ee4).SetLink(_0x98e2052d.gameObject);
        }
    }

    private const float TileHeight = 160f;
    private void _0x1dc6cece(Image _0xd3dd070d)
    {
        if (_0xd3dd070d != null)
        {
            Object.Destroy(_0xd3dd070d.gameObject);
        }
    }

    private _0x41b355c2 _0x5ebde115;
    private const float StripY = 480f;
    private _0x50933d49 _0x0fcb2d1a;
    private const float CtaY = -685f;
    private RectTransform _0x2b9c1e75;
    private int _0x634c5fad()
    {
        int _0x26b78332 = PlayerPrefs.GetInt(_0xe3d66f71._0x69dd2580(new byte[12] { 95, 82, 65, 27, 87, 90, 91, 64, 70, 113, 84, 76 }, 53), 0);
        if (_0x26b78332 < 0)
            _0x26b78332 = 0;
        if (_0x26b78332 > _0x24e3537a.Length - 1)
            _0x26b78332 = 0;
        return _0x26b78332;
    }

    private Image[] _0x8408ddbf;
    private TextMeshProUGUI _0xd6a5b61c;
    public _0x997c96d0 _0xa0aac095(RectTransform _0x27b95331, _0x41b355c2 _0x00f2ea85, _0x8ae00696 _0x513cf3af, _0x50933d49 _0x24ee4787)
    {
        this._0x2b9c1e75 = _0x27b95331;
        this._0x5ebde115 = _0x00f2ea85;
        this._0x37e8f256 = _0x513cf3af;
        this._0x0fcb2d1a = _0x24ee4787;
        Sprite _0x65af9d20 = _0x00f2ea85 != null ? _0x00f2ea85.Round : null;
        TMP_FontAsset _0xf05205e9 = _0x00f2ea85 != null ? _0x00f2ea85.Font : null;
        _0x0bb64a0b.Caption(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[11] { 72, 101, 100, 127, 121, 66, 111, 107, 110, 111, 120 }, 10), _0xf05205e9, _0xe3d66f71._0x69dd2580(new byte[11] { 227, 230, 238, 235, 254, 135, 229, 232, 233, 242, 244 }, 167), 46f, _0x0d231d8c.Gold, new Vector2(0f, 820f), new Vector2(980f, 72f), TextAlignmentOptions.Center);
        _0x0bb64a0b.Caption(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[9] { 250, 215, 214, 205, 203, 250, 215, 220, 193 }, 184), _0xf05205e9, _0xe3d66f71._0x69dd2580(new byte[42] { 50, 38, 49, 49, 84, 55, 59, 61, 58, 39, 88, 84, 49, 34, 49, 38, 45, 84, 38, 49, 53, 56, 84, 48, 53, 45, 84, 84, 89, 84, 84, 58, 59, 84, 36, 33, 38, 55, 60, 53, 39, 49 }, 116), 28f, _0x0d231d8c.Lilac, new Vector2(0f, 730f), new Vector2(1040f, 46f), TextAlignmentOptions.Center);
        this._0xc1b50620 = new Image[_0x24e3537a.Length];
        this._0x8408ddbf = new Image[_0x24e3537a.Length];
        this._0x6298084e = new TextMeshProUGUI[_0x24e3537a.Length];
        float _0x2dd576f8 = _0x24e3537a.Length * TileWidth + (_0x24e3537a.Length - 1) * TileGap;
        float _0x650bf063 = -_0x2dd576f8 * 0.5f + TileWidth * 0.5f;
        for (int _0x22519261 = 0; _0x22519261 < _0x24e3537a.Length; _0x22519261++)
        {
            float _0x9e698296 = _0x650bf063 + _0x22519261 * (TileWidth + TileGap);
            RectTransform _0x0e402ea9 = _0x0bb64a0b.Node(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[9] { 28, 49, 48, 43, 45, 10, 55, 50, 59 }, 94) + _0x22519261.ToString(), new Vector2(_0x9e698296, StripY), new Vector2(TileWidth, TileHeight));
            this._0xc1b50620[_0x22519261] = _0x0bb64a0b.Plate(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[4] { 237, 204, 207, 205 }, 168), Vector2.zero, new Vector2(TileWidth, TileHeight), _0x65af9d20, _0x0d231d8c.Muted, _0x0bb64a0b.RadiusChip);
            this._0x8408ddbf[_0x22519261] = _0x0bb64a0b.Plate(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[4] { 153, 182, 179, 179 }, 223), Vector2.zero, new Vector2(TileWidth - 8f, TileHeight - 8f), _0x65af9d20, _0x0d231d8c.Raised, _0x0bb64a0b.RadiusChip);
            _0x0bb64a0b.Caption(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[3] { 251, 222, 198 }, 191), _0xf05205e9, _0xe3d66f71._0x69dd2580(new byte[1] { 84 }, 16) + (_0x22519261 + 1).ToString(), 28f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.85f), new Vector2(0f, 52f), new Vector2(TileWidth - 16f, 36f), TextAlignmentOptions.Center);
            _0x0bb64a0b.Picture(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[4] { 51, 31, 25, 30 }, 112), new Vector2(0f, 6f), new Vector2(54f, 54f), _0x00f2ea85 != null ? _0x00f2ea85.Coin : null, _0x0d231d8c.Cream);
            _0x0bb64a0b.Caption(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[5] { 33, 22, 27, 2, 18 }, 119), _0xf05205e9, _0x0bb64a0b.Thousands(_0x24e3537a[_0x22519261]), 28f, _0x0d231d8c.Gold, new Vector2(0f, -44f), new Vector2(TileWidth - 12f, 36f), TextAlignmentOptions.Center);
            this._0x6298084e[_0x22519261] = _0x0bb64a0b.Caption(_0x0e402ea9, _0xe3d66f71._0x69dd2580(new byte[4] { 46, 2, 17, 8 }, 99), _0xf05205e9, string.Empty, 44f, _0x0d231d8c.Cream, new Vector2(0f, 6f), new Vector2(TileWidth - 20f, 56f), TextAlignmentOptions.Center);
        }

        this._0x1f88ffed = _0x0bb64a0b.Caption(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[11] { 209, 252, 253, 230, 224, 192, 231, 242, 231, 230, 224 }, 147), _0xf05205e9, string.Empty, 30f, _0x0d231d8c.Lilac, new Vector2(0f, 250f), new Vector2(1040f, 48f), TextAlignmentOptions.Center);
        // Built BEFORE the CTA so the button is the later sibling and can never end up
        // underneath the award card (C.13 / E.1).
        this._0x78eb84b3 = _0x0bb64a0b.Node(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[10] { 115, 94, 95, 68, 66, 112, 70, 80, 67, 85 }, 49), new Vector2(0f, 60f), new Vector2(760f, 150f));
        _0x0bb64a0b.Plate(this._0x78eb84b3, _0xe3d66f71._0x69dd2580(new byte[4] { 149, 180, 183, 181 }, 208), Vector2.zero, new Vector2(760f, 150f), _0x65af9d20, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusChip);
        _0x0bb64a0b.Plate(this._0x78eb84b3, _0xe3d66f71._0x69dd2580(new byte[4] { 238, 193, 196, 196 }, 168), Vector2.zero, new Vector2(752f, 142f), _0x65af9d20, _0x0d231d8c.Raised, _0x0bb64a0b.RadiusChip);
        this._0x389abcd6 = _0x0bb64a0b.Caption(this._0x78eb84b3, _0xe3d66f71._0x69dd2580(new byte[9] { 48, 6, 16, 3, 21, 61, 24, 31, 20 }, 113), _0xf05205e9, string.Empty, 44f, _0x0d231d8c.GoldLight, Vector2.zero, new Vector2(700f, 100f), TextAlignmentOptions.Center);
        this._0x78eb84b3.gameObject.SetActive(false);
        this._0xe7fad34e = _0x0bb64a0b.Cta(_0x27b95331, _0xe3d66f71._0x69dd2580(new byte[8] { 24, 53, 52, 47, 41, 25, 46, 59 }, 90), _0xf05205e9, _0xe3d66f71._0x69dd2580(new byte[5] { 140, 131, 142, 134, 130 }, 207), new Vector2(0f, CtaY), new Vector2(620f, 150f), _0x65af9d20, 48f);
        this._0xe7fad34e.onClick.AddListener(() => this._0x3c7f458f());
        this._0xd6a5b61c = this._0xe7fad34e.GetComponentInChildren<TextMeshProUGUI>();
        this._0xd49510aa();
        return this;
    }

    public bool _0xc7f51a64()
    {
        return this._0x175390ae() != this._0x0b3e71a9();
    }

    private string _0xa770a07a(int _0xd25618c3)
    {
        return _0xd25618c3 < 10 ? _0xe3d66f71._0x69dd2580(new byte[1] { 179 }, 131) + _0xd25618c3.ToString() : _0xd25618c3.ToString();
    }

    public System.Action OnSeeCollection;
    private Image[] _0xc1b50620;
    private TextMeshProUGUI _0x1f88ffed;
    private RectTransform _0x78eb84b3;
    private static readonly int[] _0x24e3537a =
    {
        250,
        300,
        400,
        500,
        650,
        800,
        1200
    };
    private Button _0xe7fad34e;
    // Local clock only, so the line is honest without ever asking anything outside.
    private string _0x494642ac()
    {
        System.DateTime _0x3b1e8896 = System.DateTime.Now;
        System.DateTime _0x3406ac96 = _0x3b1e8896.Date.AddDays(1.0);
        System.TimeSpan _0x8e13d268 = _0x3406ac96 - _0x3b1e8896;
        int _0x2c0b4abd = _0x8e13d268.Hours;
        int _0x951d83e7 = _0x8e13d268.Minutes;
        int _0xb99198d2 = _0x8e13d268.Seconds;
        return this._0xa770a07a(_0x2c0b4abd) + _0xe3d66f71._0x69dd2580(new byte[1] { 34 }, 24) + this._0xa770a07a(_0x951d83e7) + _0xe3d66f71._0x69dd2580(new byte[1] { 141 }, 183) + this._0xa770a07a(_0xb99198d2);
    }

    private TextMeshProUGUI _0x389abcd6;
    public System.Action OnClaimed;
    private int _0x175390ae()
    {
        return PlayerPrefs.GetInt(_0xe3d66f71._0x69dd2580(new byte[14] { 142, 131, 144, 202, 134, 139, 138, 145, 151, 183, 144, 133, 137, 148 }, 228), 0);
    }

    private TextMeshProUGUI[] _0x6298084e;
    // The strip is read from the local clock only: no network, no server day.
    private int _0x0b3e71a9()
    {
        System.DateTime _0x4ca8a59a = System.DateTime.Now;
        return _0x4ca8a59a.Year * 10000 + _0x4ca8a59a.Month * 100 + _0x4ca8a59a.Day;
    }
}

internal static class _0xe3d66f71
{
    internal static string _0x69dd2580(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}