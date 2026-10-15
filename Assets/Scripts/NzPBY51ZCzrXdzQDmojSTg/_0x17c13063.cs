using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The symbol albums: three rows of six shards. Every row is a C.25 two-band layout - the
// six pips live alone in the indicator gutter and the text column starts well to the
// right of it, so a long album line can never run under a pip.
//
// DRESS THE ROOM is the button rule C.7 cares about: it does not swap a label, it applies
// the highest unlocked room, which repaints the drapes, the arch, the mark tint and the
// room caption of the whole lobby. No constructor (C.59).
public sealed class _0x17c13063
{
    private RectTransform _0x491781b6;
    public void _0xbb86dfeb()
    {
        int _0x11fc6a16 = this._0x4dad982d._0x6f815bb8();
        for (int _0xac606ad9 = 0; _0xac606ad9 < _0x50933d49.AlbumCount; _0xac606ad9++)
        {
            int _0xa5c901f1 = this._0x4dad982d._0x4f0ca564(_0xac606ad9);
            bool _0xb316888b = this._0x4dad982d._0xb7934547(_0xac606ad9);
            for (int _0x8e7e666e = 0; _0x8e7e666e < _0x50933d49.ShardsPerAlbum; _0x8e7e666e++)
            {
                this._0x9a28f072[_0xac606ad9][_0x8e7e666e].color = _0x8e7e666e < _0xa5c901f1 ? _0x0d231d8c.Cream : _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.22f);
            }

            this._0x20f3b9a6[_0xac606ad9].color = _0xb316888b ? _0x0d231d8c.Gold : _0x0d231d8c.Muted;
            _0xf5cbd7d1.SetText(this._0x3200d04a[_0xac606ad9], _0xa5c901f1.ToString() + _0x7d9686a8._0xde3c948f(new byte[1] { 224 }, 207) + _0x50933d49.ShardsPerAlbum.ToString());
            _0xf5cbd7d1.SetText(this._0x6c9accce[_0xac606ad9], _0xb316888b ? _0x7d9686a8._0xde3c948f(new byte[13] { 230, 251, 251, 249, 148, 225, 250, 248, 251, 247, 255, 241, 240 }, 180) : string.Empty);
        }

        this._0xe54be616.gameObject.SetActive(_0x11fc6a16 <= 0);
        int _0xcd22e43b = this._0x4dad982d._0x0c132852();
        _0xf5cbd7d1.SetText(this._0x9784567e, _0xcd22e43b > this._0x4dad982d._0x87920c41 ? _0x7d9686a8._0xde3c948f(new byte[14] { 4, 18, 5, 19, 19, 96, 20, 8, 5, 96, 18, 15, 15, 13 }, 64) : _0x7d9686a8._0xde3c948f(new byte[17] { 105, 106, 104, 96, 11, 127, 100, 11, 127, 99, 110, 11, 103, 100, 105, 105, 114 }, 43));
    }

    private Button _0x7f09ae03;
    public _0x17c13063 _0x14434bb1(RectTransform _0x00caf2aa, _0x41b355c2 _0xead3d4be, _0x50933d49 _0xb6508a60)
    {
        this._0xc701ecec = _0x00caf2aa;
        this._0x45a3b646 = _0xead3d4be;
        this._0x4dad982d = _0xb6508a60;
        Sprite _0x5c985e9d = _0xead3d4be != null ? _0xead3d4be.Round : null;
        TMP_FontAsset _0xd7a4ead3 = _0xead3d4be != null ? _0xead3d4be.Font : null;
        _0x0bb64a0b.Caption(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[11] { 245, 216, 214, 193, 217, 252, 209, 213, 208, 209, 198 }, 180), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[13] { 219, 209, 197, 202, 199, 196, 168, 201, 196, 202, 221, 197, 219 }, 136), 46f, _0x0d231d8c.Gold, new Vector2(0f, 820f), new Vector2(980f, 72f), TextAlignmentOptions.Center);
        _0x0bb64a0b.Caption(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[9] { 55, 26, 20, 3, 27, 52, 25, 18, 15 }, 118), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[34] { 210, 209, 200, 207, 161, 213, 201, 211, 196, 196, 161, 213, 200, 194, 202, 196, 213, 210, 161, 213, 206, 161, 196, 192, 211, 207, 161, 192, 161, 210, 201, 192, 211, 197 }, 129), 28f, _0x0d231d8c.Lilac, new Vector2(0f, 736f), new Vector2(1040f, 46f), TextAlignmentOptions.Center);
        this._0x9a28f072 = new Image[_0x50933d49.AlbumCount][];
        this._0x3200d04a = new TextMeshProUGUI[_0x50933d49.AlbumCount];
        this._0x6c9accce = new TextMeshProUGUI[_0x50933d49.AlbumCount];
        this._0x20f3b9a6 = new Image[_0x50933d49.AlbumCount];
        for (int _0x1fb95257 = 0; _0x1fb95257 < _0x50933d49.AlbumCount; _0x1fb95257++)
        {
            float _0x3127f530 = 460f - _0x1fb95257 * (RowHeight + 24f);
            RectTransform _0x35fe2bda = _0x0bb64a0b.Node(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[8] { 183, 154, 148, 131, 155, 164, 153, 129 }, 246) + _0x1fb95257.ToString(), new Vector2(0f, _0x3127f530), new Vector2(RowWidth, RowHeight));
            this._0x20f3b9a6[_0x1fb95257] = _0x0bb64a0b.Plate(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[4] { 168, 137, 138, 136 }, 237), Vector2.zero, new Vector2(RowWidth, RowHeight), _0x5c985e9d, _0x0d231d8c.Muted, _0x0bb64a0b.RadiusChip);
            _0x0bb64a0b.Plate(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[4] { 60, 19, 22, 22 }, 122), Vector2.zero, new Vector2(RowWidth - 8f, RowHeight - 8f), _0x5c985e9d, _0x0d231d8c.Raised, _0x0bb64a0b.RadiusChip);
            // Six shard pips, two rows of three, inside the 84-unit gutter only.
            RectTransform _0xb9d0319a = _0x0bb64a0b.Node(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[4] { 239, 214, 207, 204 }, 191), _0x0bb64a0b.GutterAt(RowWidth, 0f), new Vector2(_0x0bb64a0b.GutterWidth, 110f));
            this._0x9a28f072[_0x1fb95257] = new Image[_0x50933d49.ShardsPerAlbum];
            for (int _0x2c82874c = 0; _0x2c82874c < _0x50933d49.ShardsPerAlbum; _0x2c82874c++)
            {
                float _0x0cfd5b93 = (_0x2c82874c % 2 == 0 ? -1f : 1f) * 19f;
                float _0xd4a25aaf = 38f - (_0x2c82874c / 2) * 38f;
                this._0x9a28f072[_0x1fb95257][_0x2c82874c] = _0x0bb64a0b.Picture(_0xb9d0319a, _0x7d9686a8._0xde3c948f(new byte[5] { 51, 8, 1, 18, 4 }, 96) + _0x2c82874c.ToString(), new Vector2(_0x0cfd5b93, _0xd4a25aaf), new Vector2(PipSide, PipSide), _0xead3d4be != null ? _0xead3d4be.Shard : null, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.22f));
            }

            _0x0bb64a0b.Caption(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[5] { 192, 253, 224, 248, 241 }, 148), _0xd7a4ead3, AlbumTitle(_0x1fb95257), 34f, _0x0d231d8c.Cream, _0x0bb64a0b.TextAt(RowWidth, 48f), _0x0bb64a0b.TextBox(44f), TextAlignmentOptions.Left);
            _0x0bb64a0b.Caption(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[4] { 14, 47, 40, 50 }, 70), _0xd7a4ead3, AlbumHint(_0x1fb95257), 26f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.80f), _0x0bb64a0b.TextAt(RowWidth, 2f), _0x0bb64a0b.TextBox(36f), TextAlignmentOptions.Left);
            this._0x3200d04a[_0x1fb95257] = _0x0bb64a0b.Caption(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[5] { 110, 66, 88, 67, 89 }, 45), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[3] { 181, 170, 179 }, 133), 30f, _0x0d231d8c.Gold, _0x0bb64a0b.TextAt(RowWidth, -46f), _0x0bb64a0b.TextBox(40f), TextAlignmentOptions.Left);
            this._0x6c9accce[_0x1fb95257] = _0x0bb64a0b.Caption(_0x35fe2bda, _0x7d9686a8._0xde3c948f(new byte[5] { 129, 166, 179, 166, 183 }, 210), _0xd7a4ead3, string.Empty, 26f, _0x0d231d8c.GoldLight, new Vector2(RowWidth * 0.5f - 190f, -46f), new Vector2(320f, 36f), TextAlignmentOptions.Right);
        }

        this._0xe54be616 = _0x0bb64a0b.Caption(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[10] { 129, 172, 162, 181, 173, 133, 173, 176, 180, 185 }, 192), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[33] { 5, 4, 107, 24, 3, 10, 25, 15, 24, 107, 18, 14, 31, 107, 107, 102, 107, 107, 24, 27, 2, 5, 107, 31, 4, 107, 8, 4, 7, 7, 14, 8, 31 }, 75), 30f, _0x0d231d8c.Lilac, new Vector2(0f, 110f), new Vector2(1000f, 52f), TextAlignmentOptions.Center);
        // Built BEFORE the CTA, so the button is the later sibling and can never end up
        // underneath the confirmation card (C.13 / E.1).
        this._0x491781b6 = _0x0bb64a0b.Node(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[12] { 146, 164, 179, 165, 165, 149, 185, 184, 176, 191, 164, 187 }, 214), new Vector2(0f, -40f), new Vector2(720f, 130f));
        _0x0bb64a0b.Plate(this._0x491781b6, _0x7d9686a8._0xde3c948f(new byte[4] { 24, 57, 58, 56 }, 93), Vector2.zero, new Vector2(720f, 130f), _0x5c985e9d, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusChip);
        _0x0bb64a0b.Plate(this._0x491781b6, _0x7d9686a8._0xde3c948f(new byte[4] { 108, 67, 70, 70 }, 42), Vector2.zero, new Vector2(712f, 122f), _0x5c985e9d, _0x0d231d8c.Raised, _0x0bb64a0b.RadiusChip);
        _0x0bb64a0b.Caption(this._0x491781b6, _0x7d9686a8._0xde3c948f(new byte[11] { 91, 119, 118, 126, 113, 106, 117, 84, 113, 118, 125 }, 24), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[10] { 185, 164, 164, 166, 203, 185, 174, 170, 175, 178 }, 235), 40f, _0x0d231d8c.GoldLight, Vector2.zero, new Vector2(660f, 90f), TextAlignmentOptions.Center);
        this._0x491781b6.gameObject.SetActive(false);
        this._0x7f09ae03 = _0x0bb64a0b.Cta(_0x00caf2aa, _0x7d9686a8._0xde3c948f(new byte[8] { 180, 153, 151, 128, 152, 182, 129, 148 }, 245), _0xd7a4ead3, _0x7d9686a8._0xde3c948f(new byte[14] { 72, 94, 73, 95, 95, 44, 88, 68, 73, 44, 94, 67, 67, 65 }, 12), new Vector2(0f, -640f), new Vector2(620f, 150f), _0x5c985e9d, 42f);
        this._0x7f09ae03.onClick.AddListener(() => this._0x6852ce5a());
        this._0x9784567e = this._0x7f09ae03.GetComponentInChildren<TextMeshProUGUI>();
        this._0xbb86dfeb();
        return this;
    }

    private const float RowHeight = 196f;
    public System.Action OnDressed;
    private TextMeshProUGUI _0x9784567e;
    private RectTransform _0xc701ecec;
    private static string AlbumTitle(int _0xf0d0afb3)
    {
        if (_0xf0d0afb3 == 0)
            return _0x7d9686a8._0xde3c948f(new byte[5] { 252, 240, 234, 237, 235 }, 191);
        if (_0xf0d0afb3 == 1)
            return _0x7d9686a8._0xde3c948f(new byte[8] { 184, 190, 169, 173, 191, 185, 190, 169 }, 236);
        return _0x7d9686a8._0xde3c948f(new byte[5] { 146, 148, 136, 149, 146 }, 193);
    }

    private TextMeshProUGUI[] _0x6c9accce;
    private TextMeshProUGUI _0xe54be616;
    private void _0x6852ce5a()
    {
        int _0xc7be347b = this._0x4dad982d._0x0c132852();
        bool _0xe512caee = this._0x4dad982d._0x45484840(_0xc7be347b);
        if (_0xe512caee)
        {
            _0xf5cbd7d1.SetText(this._0x9784567e, _0x7d9686a8._0xde3c948f(new byte[17] { 161, 162, 160, 168, 195, 183, 172, 195, 183, 171, 166, 195, 175, 172, 161, 161, 186 }, 227));
            this._0x491781b6.gameObject.SetActive(true);
            this._0x491781b6.localScale = new Vector3(0.9f, 0.9f, 1f);
            this._0x491781b6.DOScale(1f, 0.26f).SetEase(Ease.OutBack).SetLink(this._0x491781b6.gameObject);
        }

        if (this.OnDressed != null)
        {
            this.OnDressed();
        }
    }

    private _0x50933d49 _0x4dad982d;
    private const float PipSide = 34f;
    private _0x41b355c2 _0x45a3b646;
    private static string AlbumHint(int _0xb10faab9)
    {
        if (_0xb10faab9 == 0)
            return _0x7d9686a8._0xde3c948f(new byte[19] { 146, 131, 158, 134, 159, 241, 144, 159, 149, 241, 155, 158, 154, 148, 131, 241, 144, 131, 133 }, 209);
        if (_0xb10faab9 == 1)
            return _0x7d9686a8._0xde3c948f(new byte[17] { 85, 82, 69, 94, 39, 70, 73, 67, 39, 68, 72, 78, 73, 39, 70, 85, 83 }, 7);
        return _0x7d9686a8._0xde3c948f(new byte[21] { 191, 163, 174, 203, 173, 164, 190, 185, 203, 184, 190, 162, 191, 203, 184, 178, 166, 169, 164, 167, 184 }, 235);
    }

    private const float RowWidth = 1050f;
    private Image[][] _0x9a28f072;
    private TextMeshProUGUI[] _0x3200d04a;
    private Image[] _0x20f3b9a6;
}

internal static class _0x7d9686a8
{
    internal static string _0xde3c948f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}