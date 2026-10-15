using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Settings - and there is NO AUDIO ANYTHING here (C.20, blocking). This game ships
// without sound, so a music toggle, an SFX toggle, a volume slider or a speaker icon
// would be controls that mute silence: the player taps, the knob slides, nothing else
// changes. The row budget goes to three switches that really do something plus a reset.
//
// Each pill is a real state change: the knob slides, the plate recolours and the effect
// is visible on the very next spin (C.7). Preferences live in PlayerPrefs under stable
// literal keys, never nameof - obfuscation renames symbols and a renamed key loses the
// save. No constructor (C.59).
public sealed class _0xff37bc54
{
    public void _0x723386d7()
    {
        int _0x641d1a94 = Flags();
        for (int _0xde9f59f9 = 0; _0xde9f59f9 < 3; _0xde9f59f9++)
        {
            this._0xd7e5e7ee(_0xde9f59f9, (_0x641d1a94 & RowFlag(_0xde9f59f9)) != 0, false);
        }
    }

    private const float PillHeight = 72f;
    private static string RowHint(int _0xdd89e6d5)
    {
        if (_0xdd89e6d5 == 0)
            return _0x93427f2b._0x1a50bba3(new byte[25] { 144, 241, 130, 153, 158, 131, 133, 241, 147, 132, 139, 139, 241, 158, 159, 241, 148, 135, 148, 131, 136, 241, 134, 152, 159 }, 209);
        if (_0xdd89e6d5 == 1)
            return _0x93427f2b._0x1a50bba3(new byte[33] { 101, 121, 116, 17, 99, 116, 116, 125, 98, 17, 98, 116, 101, 101, 125, 116, 17, 120, 127, 17, 121, 112, 125, 119, 17, 101, 121, 116, 17, 101, 120, 124, 116 }, 49);
        return _0x93427f2b._0x1a50bba3(new byte[30] { 203, 194, 207, 197, 163, 215, 203, 198, 163, 208, 211, 194, 209, 200, 208, 175, 163, 203, 194, 207, 197, 163, 215, 203, 198, 163, 196, 207, 204, 212 }, 131);
    }

    private static string RowTitle(int _0x9dc0e84f)
    {
        if (_0x9dc0e84f == 0)
            return _0x93427f2b._0x1a50bba3(new byte[9] { 37, 58, 49, 33, 50, 39, 58, 60, 61 }, 115);
        if (_0x9dc0e84f == 1)
            return _0x93427f2b._0x1a50bba3(new byte[9] { 98, 101, 119, 112, 4, 119, 116, 109, 106 }, 36);
        return _0x93427f2b._0x1a50bba3(new byte[13] { 200, 223, 222, 207, 217, 223, 222, 186, 220, 214, 219, 201, 210 }, 154);
    }

    private void _0xd7e5e7ee(int _0x88b02811, bool _0x42771207, bool _0x2886ade6)
    {
        Image _0x84c471eb = this._0x99bb45c5[_0x88b02811];
        if (_0x84c471eb != null)
        {
            Color _0x0d9dc6ff = _0x42771207 ? _0x0d231d8c.Gold : _0x0d231d8c.Muted;
            if (_0x2886ade6)
            {
                _0x84c471eb.DOColor(_0x0d9dc6ff, 0.16f).SetLink(_0x84c471eb.gameObject);
            }
            else
            {
                _0x84c471eb.color = _0x0d9dc6ff;
            }
        }

        Image _0xe3fd52f5 = this._0x081349e7[_0x88b02811];
        if (_0xe3fd52f5 != null)
        {
            _0xe3fd52f5.color = _0x42771207 ? _0x0d231d8c.DeepInk : _0x0d231d8c.Lilac;
        }

        RectTransform _0x10ed90e4 = this._0x3680ca00[_0x88b02811];
        if (_0x10ed90e4 != null)
        {
            Vector2 _0x5f18563e = new Vector2(_0x42771207 ? KnobTravel * 0.5f : -KnobTravel * 0.5f, 0f);
            if (_0x2886ade6)
            {
                _0x10ed90e4.DOAnchorPos(_0x5f18563e, 0.16f).SetLink(_0x10ed90e4.gameObject);
            }
            else
            {
                _0x10ed90e4.anchoredPosition = _0x5f18563e;
            }
        }

        TextMeshProUGUI _0xf51c3b45 = this._0x8a8ab77c[_0x88b02811];
        if (_0xf51c3b45 != null)
        {
            _0xf5cbd7d1.SetText(_0xf51c3b45, _0x42771207 ? _0x93427f2b._0x1a50bba3(new byte[2] { 74, 75 }, 5) : _0x93427f2b._0x1a50bba3(new byte[3] { 155, 146, 146 }, 212));
            _0xf51c3b45.rectTransform.anchoredPosition = new Vector2(_0x42771207 ? -26f : 26f, 0f);
        }
    }

    private RectTransform[] _0x3680ca00;
    public const int FlagFastSpin = 2;
    public static int Flags()
    {
        return PlayerPrefs.GetInt(_0x93427f2b._0x1a50bba3(new byte[9] { 151, 154, 137, 211, 155, 145, 156, 154, 142 }, 253), FlagVibration);
    }

    private const float PillWidth = 180f;
    private _0x8ae00696 _0xdb8449ae;
    private _0x41b355c2 _0xf0b8f2f2;
    private Image[] _0x99bb45c5;
    private void Reset()
    {
        this._0xdb8449ae._0x82239263();
        this._0x167ff934._0xcbb7043b();
        this._0xb76e8bca._0x90d6d60d();
        PlayerPrefs.SetInt(_0x93427f2b._0x1a50bba3(new byte[12] { 180, 185, 170, 240, 188, 177, 176, 171, 173, 154, 191, 167 }, 222), 0);
        PlayerPrefs.SetInt(_0x93427f2b._0x1a50bba3(new byte[14] { 111, 98, 113, 43, 103, 106, 107, 112, 118, 86, 113, 100, 104, 117 }, 5), 0);
        PlayerPrefs.Save();
        _0xf5cbd7d1.SetText(this._0x87447925, _0x93427f2b._0x1a50bba3(new byte[40] { 228, 230, 251, 243, 230, 241, 231, 231, 148, 230, 241, 231, 241, 224, 148, 148, 153, 148, 148, 129, 152, 132, 132, 132, 148, 247, 251, 253, 250, 231, 152, 148, 251, 250, 241, 148, 230, 251, 251, 249 }, 180));
        if (this._0x87447925 != null)
        {
            this._0x87447925.rectTransform.DOPunchScale(new Vector3(0.1f, 0.1f, 0f), 0.4f, 6, 0.6f).SetLink(this._0x87447925.gameObject);
        }

        if (this.OnReset != null)
        {
            this.OnReset();
        }
    }

    private void _0x27961a04(int _0xb56b0ada)
    {
        int _0xdf102ae1 = RowFlag(_0xb56b0ada);
        int _0x9327ede7 = Flags() ^ _0xdf102ae1;
        PlayerPrefs.SetInt(_0x93427f2b._0x1a50bba3(new byte[9] { 14, 3, 16, 74, 2, 8, 5, 3, 23 }, 100), _0x9327ede7);
        PlayerPrefs.Save();
        bool _0xe4aa7206 = (_0x9327ede7 & _0xdf102ae1) != 0;
        this._0xd7e5e7ee(_0xb56b0ada, _0xe4aa7206, true);
        if (_0xb56b0ada == 0 && _0xe4aa7206)
        {
            Handheld.Vibrate();
        }
    }

    private _0x9fe11fc8 _0xb76e8bca;
    private static int RowFlag(int _0xa4691ca8)
    {
        if (_0xa4691ca8 == 0)
            return FlagVibration;
        if (_0xa4691ca8 == 1)
            return FlagFastSpin;
        return FlagReducedFlash;
    }

    public _0xff37bc54 _0xdd5f78b2(RectTransform _0x8d87a9b1, _0x41b355c2 _0x5e36d608, _0x8ae00696 _0xa1c18647, _0x50933d49 _0xddb9cf10, _0x9fe11fc8 _0xefa9814b)
    {
        this._0x724a78a5 = _0x8d87a9b1;
        this._0xf0b8f2f2 = _0x5e36d608;
        this._0xdb8449ae = _0xa1c18647;
        this._0x167ff934 = _0xddb9cf10;
        this._0xb76e8bca = _0xefa9814b;
        Sprite _0x2ddd3d42 = _0x5e36d608 != null ? _0x5e36d608.Round : null;
        TMP_FontAsset _0x77d0534c = _0x5e36d608 != null ? _0x5e36d608.Font : null;
        _0x0bb64a0b.Caption(_0x8d87a9b1, _0x93427f2b._0x1a50bba3(new byte[14] { 126, 72, 89, 89, 68, 67, 74, 94, 101, 72, 76, 73, 72, 95 }, 45), _0x77d0534c, _0x93427f2b._0x1a50bba3(new byte[8] { 58, 44, 61, 61, 32, 39, 46, 58 }, 105), 46f, _0x0d231d8c.Gold, new Vector2(0f, 820f), new Vector2(980f, 72f), TextAlignmentOptions.Center);
        this._0x99bb45c5 = new Image[3];
        this._0x3680ca00 = new RectTransform[3];
        this._0x081349e7 = new Image[3];
        this._0x8a8ab77c = new TextMeshProUGUI[3];
        for (int _0x3b267cf0 = 0; _0x3b267cf0 < 3; _0x3b267cf0++)
        {
            float _0x5c2850a3 = 580f - _0x3b267cf0 * 150f;
            RectTransform _0x6b8310e9 = _0x0bb64a0b.Node(_0x8d87a9b1, _0x93427f2b._0x1a50bba3(new byte[10] { 97, 87, 70, 70, 91, 92, 85, 96, 93, 69 }, 50) + _0x3b267cf0.ToString(), new Vector2(0f, _0x5c2850a3), new Vector2(1040f, 134f));
            _0x0bb64a0b.Plate(_0x6b8310e9, _0x93427f2b._0x1a50bba3(new byte[4] { 253, 210, 215, 215 }, 187), Vector2.zero, new Vector2(1040f, 128f), _0x2ddd3d42, _0x0d231d8c.Fade(_0x0d231d8c.Raised, 0.9f), _0x0bb64a0b.RadiusChip);
            _0x0bb64a0b.Caption(_0x6b8310e9, _0x93427f2b._0x1a50bba3(new byte[5] { 142, 179, 174, 182, 191 }, 218), _0x77d0534c, RowTitle(_0x3b267cf0), 32f, _0x0d231d8c.Cream, new Vector2(-170f, 24f), new Vector2(640f, 42f), TextAlignmentOptions.Left);
            _0x0bb64a0b.Caption(_0x6b8310e9, _0x93427f2b._0x1a50bba3(new byte[4] { 3, 34, 37, 63 }, 75), _0x77d0534c, RowHint(_0x3b267cf0), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.80f), new Vector2(-170f, -24f), new Vector2(640f, 34f), TextAlignmentOptions.Left);
            Button _0x33bdab44 = _0x0bb64a0b.Action(_0x6b8310e9, _0x93427f2b._0x1a50bba3(new byte[4] { 1, 56, 61, 61 }, 81) + _0x3b267cf0.ToString(), new Vector2(378f, 0f), new Vector2(PillWidth, PillHeight), _0x2ddd3d42, _0x0d231d8c.Muted, _0x0bb64a0b.RadiusChip);
            this._0x99bb45c5[_0x3b267cf0] = _0x33bdab44.targetGraphic as Image;
            RectTransform _0x480688e0 = _0x33bdab44.GetComponent<RectTransform>();
            this._0x3680ca00[_0x3b267cf0] = _0x0bb64a0b.Node(_0x480688e0, _0x93427f2b._0x1a50bba3(new byte[4] { 117, 80, 81, 92 }, 62), new Vector2(-KnobTravel * 0.5f, 0f), new Vector2(58f, 58f));
            this._0x081349e7[_0x3b267cf0] = _0x0bb64a0b.Plate(this._0x3680ca00[_0x3b267cf0], _0x93427f2b._0x1a50bba3(new byte[8] { 50, 23, 22, 27, 63, 16, 21, 21 }, 121), Vector2.zero, new Vector2(58f, 58f), _0x2ddd3d42, _0x0d231d8c.Lilac, 2.6f);
            this._0x8a8ab77c[_0x3b267cf0] = _0x0bb64a0b.Caption(_0x480688e0, _0x93427f2b._0x1a50bba3(new byte[9] { 205, 244, 241, 241, 209, 252, 255, 248, 241 }, 157), _0x77d0534c, _0x93427f2b._0x1a50bba3(new byte[3] { 66, 75, 75 }, 13), 24f, _0x0d231d8c.Cream, new Vector2(26f, 0f), new Vector2(96f, 44f), TextAlignmentOptions.Center);
            int _0x98205561 = _0x3b267cf0;
            _0x33bdab44.onClick.AddListener(() => this._0x27961a04(_0x98205561));
        }

        RectTransform _0x75444a4c = _0x0bb64a0b.Node(_0x8d87a9b1, _0x93427f2b._0x1a50bba3(new byte[8] { 20, 35, 53, 35, 50, 20, 41, 49 }, 70), new Vector2(0f, 110f), new Vector2(1040f, 150f));
        Button _0x72cebaf4 = _0x0bb64a0b.Action(_0x75444a4c, _0x93427f2b._0x1a50bba3(new byte[11] { 42, 29, 11, 29, 12, 58, 13, 12, 12, 23, 22 }, 120), Vector2.zero, new Vector2(560f, 118f), _0x2ddd3d42, _0x0d231d8c.Crimson, _0x0bb64a0b.RadiusCard);
        RectTransform _0x18d6ae48 = _0x72cebaf4.GetComponent<RectTransform>();
        _0x0bb64a0b.Caption(_0x18d6ae48, _0x93427f2b._0x1a50bba3(new byte[10] { 69, 114, 100, 114, 99, 91, 118, 117, 114, 123 }, 23), _0x77d0534c, _0x93427f2b._0x1a50bba3(new byte[14] { 247, 224, 246, 224, 241, 133, 245, 247, 234, 226, 247, 224, 246, 246 }, 165), 34f, _0x0d231d8c.Cream, Vector2.zero, new Vector2(500f, 70f), TextAlignmentOptions.Center);
        _0x72cebaf4.onClick.AddListener(() => this.Reset());
        this._0x87447925 = _0x0bb64a0b.Caption(_0x75444a4c, _0x93427f2b._0x1a50bba3(new byte[10] { 249, 206, 216, 206, 223, 248, 223, 202, 223, 206 }, 171), _0x77d0534c, _0x93427f2b._0x1a50bba3(new byte[38] { 251, 247, 241, 246, 235, 152, 250, 249, 251, 243, 152, 236, 247, 152, 141, 148, 136, 136, 136, 152, 152, 149, 152, 152, 235, 240, 249, 234, 252, 235, 152, 251, 244, 253, 249, 234, 253, 252 }, 184), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.80f), new Vector2(0f, -86f), new Vector2(1000f, 36f), TextAlignmentOptions.Center);
        // The compliance block, in full. Line breaks are placed BY HAND (C.10): the
        // engine never decides where a line ends, so the block is identical everywhere.
        _0x0bb64a0b.Caption(_0x8d87a9b1, _0x93427f2b._0x1a50bba3(new byte[10] { 122, 86, 84, 73, 85, 80, 88, 87, 90, 92 }, 57), _0x77d0534c, _0x93427f2b._0x1a50bba3(new byte[51] { 94, 65, 90, 92, 93, 73, 68, 40, 75, 71, 65, 70, 91, 40, 71, 70, 68, 81, 38, 40, 92, 64, 77, 81, 40, 64, 73, 94, 77, 40, 70, 71, 40, 90, 77, 73, 68, 37, 95, 71, 90, 68, 76, 40, 94, 73, 68, 93, 77, 38, 2 }, 8) + _0x93427f2b._0x1a50bba3(new byte[59] { 201, 200, 167, 215, 210, 213, 196, 207, 198, 212, 194, 212, 171, 167, 201, 200, 167, 195, 194, 215, 200, 212, 206, 211, 212, 171, 167, 201, 200, 167, 208, 206, 211, 207, 195, 213, 198, 208, 198, 203, 212, 171, 167, 201, 200, 167, 196, 198, 212, 207, 167, 215, 213, 206, 221, 194, 212, 169, 141 }, 135) + _0x93427f2b._0x1a50bba3(new byte[51] { 244, 245, 154, 232, 255, 251, 246, 151, 247, 245, 244, 255, 227, 154, 248, 255, 238, 238, 243, 244, 253, 148, 154, 244, 245, 154, 255, 226, 238, 255, 232, 244, 251, 246, 154, 253, 251, 247, 248, 246, 243, 244, 253, 154, 246, 243, 244, 241, 233, 148, 176 }, 186) + _0x93427f2b._0x1a50bba3(new byte[18] { 122, 127, 110, 119, 111, 104, 27, 116, 117, 119, 98, 27, 22, 27, 10, 3, 16, 21 }, 59), 26f, _0x0d231d8c.Lilac, new Vector2(0f, -600f), new Vector2(1060f, 240f), TextAlignmentOptions.Center);
        this._0x723386d7();
        return this;
    }

    private Image[] _0x081349e7;
    public System.Action OnReset;
    private TextMeshProUGUI _0x87447925;
    public static bool Has(int _0x4fecc45c)
    {
        return (Flags() & _0x4fecc45c) != 0;
    }

    private _0x50933d49 _0x167ff934;
    private const float KnobTravel = 50f;
    public const int FlagReducedFlash = 4;
    private RectTransform _0x724a78a5;
    private TextMeshProUGUI[] _0x8a8ab77c;
    public const int FlagVibration = 1;
}

internal static class _0x93427f2b
{
    internal static string _0x1a50bba3(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}