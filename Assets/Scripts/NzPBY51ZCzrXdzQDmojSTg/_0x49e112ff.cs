using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The menu scene, start to finish. One MonoBehaviour owns the whole lobby: it builds the
// composition into DefaultPanel/Content, dresses the template PLAY button in place,
// brands the splash and keeps the three overlay sheets.
//
// Everything on screen is OUR object. Nothing is hung on a template placeholder and no
// template slot is referenced (C.2), because generated code reliably controls only what
// it created itself. The template objects we DO touch are reached through the public
// template API (PanelController.Panels, LoadSceneButton by COMPONENT TYPE) - never by
// name, path or Find (C.1).
//
// Set-up runs in Start(), never Awake: the template does its own set-up in Awake and the
// order between two Awakes is undefined (C.59). No constructor anywhere.
public sealed class _0x49e112ff : MonoBehaviour
{
    // ---------------------------------------------------------------- behaviour
    private void _0xa5ed6f32(int _0x90e203e6)
    {
        if (_0x90e203e6 == 0 && this._0x1253653f != null)
        {
            this._0x1253653f._0xd49510aa();
        }

        if (_0x90e203e6 == 1 && this._0xf49859a8 != null)
        {
            this._0xf49859a8._0xbb86dfeb();
        }

        if (this._0x11e2bc62 != null)
        {
            this._0x11e2bc62._0xb305fa6c(_0x90e203e6);
        }
    }

    private void _0x3f385a9c()
    {
        // The sheet closes so the re-dressed lobby is what the player actually sees -
        // that visible repaint IS the confirmation rule C.7 asks for.
        if (this._0x11e2bc62 != null)
        {
            this._0x11e2bc62._0xd41055c1();
        }

        this._0xe506cd08 = this._0x0f1c00de._0x87920c41;
        this._0xacd20020._0xf5d5498e(this._0xe506cd08, true);
        this._0xf6222255(this._0xe506cd08, true);
        this._0x67bf1d73();
    }

    private void _0xf6222255(int _0x5cdcfa78, bool _0xd7eb9c5a)
    {
        Color _0x89f43bad = _0xdd6c3e6b.Trim(_0x5cdcfa78);
        Color _0xbcac8b7b = _0xdd6c3e6b.Drape(_0x5cdcfa78);
        Color _0x38c3577f = _0xdd6c3e6b.Arch(_0x5cdcfa78);
        float _0x2a2d390c = _0xd7eb9c5a ? 1f : 0.35f;
        if (this._0xfe17e4d6 != null)
        {
            this._0xb243eac3(this._0xfe17e4d6[0], _0xbcac8b7b, 0.30f * _0x2a2d390c);
            this._0xb243eac3(this._0xfe17e4d6[1], _0xbcac8b7b, 0.55f * _0x2a2d390c);
            this._0xb243eac3(this._0xfe17e4d6[2], _0xbcac8b7b, 0.55f * _0x2a2d390c);
            this._0xb243eac3(this._0xfe17e4d6[3], _0x38c3577f, 0.80f * _0x2a2d390c);
            this._0xb243eac3(this._0xfe17e4d6[4], _0x38c3577f, 0.55f * _0x2a2d390c);
        }

        if (this._0xa8bb852b != null)
        {
            this._0xa8bb852b.DOColor(_0xd7eb9c5a ? _0x89f43bad : _0x0d231d8c.Fade(_0x89f43bad, 0.40f), 0.32f).SetLink(this._0xa8bb852b.gameObject);
        }

        _0xf5cbd7d1.SetText(this._0x28e60451, _0xdd6c3e6b.Title(_0x5cdcfa78));
        _0xf5cbd7d1.SetText(this._0x1f217c2d, _0xdd6c3e6b.Flavour(_0x5cdcfa78));
        _0xf5cbd7d1.SetText(this._0xa67594c3, _0xd7eb9c5a ? _0x8bc18bfb._0x85fb5578(new byte[16] { 13, 27, 12, 26, 26, 12, 13, 105, 8, 7, 13, 105, 6, 25, 12, 7 }, 73) : _0x8bc18bfb._0x85fb5578(new byte[26] { 31, 28, 16, 24, 22, 23, 115, 115, 126, 115, 115, 21, 26, 29, 26, 0, 27, 115, 18, 29, 115, 18, 31, 17, 6, 30 }, 83));
    }

    private void _0xf097b6b0()
    {
        this._0xe506cd08 = this._0x0f1c00de._0x87920c41;
        this._0xacd20020._0xf5d5498e(this._0xe506cd08, true);
        this._0xf6222255(this._0xe506cd08, true);
        if (this._0x1253653f != null)
        {
            this._0x1253653f._0xd49510aa();
        }

        if (this._0xf49859a8 != null)
        {
            this._0xf49859a8._0xbb86dfeb();
        }

        this._0x67bf1d73();
    }

    // G.3: the PLAY button rect is set in the SCENE (anchors collapsed to a point,
    // 780x170 of a 1242x2688 reference) - this only gives it a face. The template button
    // renders nothing of its own and its caption ships inactive, so exactly one PLAY
    // literal ends up on screen.
    private void _0x68c38e51(RectTransform _0x0d7e3d20)
    {
        _0x63af5fe7 _0x2a949588 = _0x0d7e3d20.GetComponentInChildren<_0x63af5fe7>(true);
        if (_0x2a949588 == null)
        {
            return;
        }

        RectTransform _0x352ca760 = _0x2a949588.transform as RectTransform;
        if (_0x352ca760 == null)
        {
            return;
        }

        this._0xa509b0ff = _0x2a949588.GetComponent<Button>();
        _0x0bb64a0b.DressButton(_0x352ca760, this._art != null ? this._art.Font : null, _0x8bc18bfb._0x85fb5578(new byte[4] { 188, 160, 173, 181 }, 236), this._art != null ? this._art.Round : null, 56f, _0x0d231d8c.RoyalDeep, _0x0d231d8c.Cream);
        _0x352ca760.localScale = new Vector3(0.9f, 0.9f, 1f);
        _0x352ca760.DOScale(1f, 0.42f).SetEase(Ease.OutBack).SetLink(_0x352ca760.gameObject);
    }

    private Image _0xa8bb852b;
    // The showcase is the room you are looking at: two drape columns, an arch band and a
    // footlight, all tinted from the room. NEXT ROOM really repaints them, which is the
    // visible confirmation rule C.7 asks of a button that changes something.
    private void _0x2fe526cb()
    {
        Sprite _0xb9b445dd = this._art != null ? this._art.Round : null;
        Sprite _0x5d63b277 = this._art != null ? this._art.Soft : null;
        TMP_FontAsset _0x8660150d = this._art != null ? this._art.Font : null;
        RectTransform _0xd9c5fe3b = _0x0bb64a0b.Card(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[12] { 116, 73, 73, 75, 117, 78, 73, 81, 69, 71, 85, 67 }, 38), _0x0bb64a0b.At(0.5f, 0.610f), new Vector2(1100f, 352f), _0xb9b445dd, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        this._0xfe17e4d6 = new Image[5];
        this._0xfe17e4d6[0] = _0x0bb64a0b.Plate(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[8] { 244, 215, 216, 210, 241, 218, 217, 193 }, 182), new Vector2(0f, 24f), new Vector2(1000f, 220f), _0x5d63b277, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.30f), 1.0f);
        this._0xfe17e4d6[1] = _0x0bb64a0b.Plate(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[9] { 195, 245, 230, 247, 226, 203, 226, 225, 243 }, 135), new Vector2(-404f, 10f), new Vector2(150f, 268f), _0xb9b445dd, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.55f), 2.4f);
        this._0xfe17e4d6[2] = _0x0bb64a0b.Plate(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[10] { 229, 211, 192, 209, 196, 243, 200, 198, 201, 213 }, 161), new Vector2(404f, 10f), new Vector2(150f, 268f), _0xb9b445dd, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.55f), 2.4f);
        this._0xfe17e4d6[3] = _0x0bb64a0b.Plate(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[8] { 22, 37, 52, 63, 21, 54, 57, 51 }, 87), new Vector2(0f, 126f), new Vector2(900f, 22f), _0xb9b445dd, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.80f), 8f);
        this._0xfe17e4d6[4] = _0x0bb64a0b.Plate(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[8] { 165, 150, 135, 140, 182, 145, 136, 129 }, 228), new Vector2(0f, -132f), new Vector2(760f, 8f), _0xb9b445dd, _0x0d231d8c.Fade(_0x0d231d8c.GoldLight, 0.55f), 8f);
        this._0xa67594c3 = _0x0bb64a0b.Caption(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[9] { 10, 55, 55, 53, 11, 44, 57, 44, 61 }, 88), _0x8660150d, _0x8bc18bfb._0x85fb5578(new byte[16] { 10, 28, 11, 29, 29, 11, 10, 110, 15, 0, 10, 110, 1, 30, 11, 0 }, 78), 28f, _0x0d231d8c.Lilac, new Vector2(-150f, -92f), new Vector2(560f, 44f), TextAlignmentOptions.Center);
        Button _0x2fe73d99 = _0x0bb64a0b.Minor(_0xd9c5fe3b, _0x8bc18bfb._0x85fb5578(new byte[8] { 152, 179, 174, 162, 132, 185, 185, 187 }, 214), _0x8660150d, _0x8bc18bfb._0x85fb5578(new byte[9] { 99, 104, 117, 121, 13, 127, 98, 98, 96 }, 45), new Vector2(360f, -112f), new Vector2(300f, 90f), _0xb9b445dd, 28f);
        _0x2fe73d99.onClick.AddListener(() => this._0xd3dfd8f6());
    }

    private void _0xb243eac3(Image _0xc9ac95ac, Color _0xab1b9cda, float _0xc9b2265b)
    {
        if (_0xc9ac95ac == null)
        {
            return;
        }

        _0xc9ac95ac.DOColor(_0x0d231d8c.Fade(_0xab1b9cda, _0xc9b2265b), 0.32f).SetLink(_0xc9ac95ac.gameObject);
    }

    private _0x997c96d0 _0x1253653f;
    private int _0xe506cd08;
    private _0x50933d49 _0x0f1c00de;
    private _0xff37bc54 _0x94d4ac19;
    private void Start()
    {
        this._0xc5bd6d47 = new _0x8ae00696()._0x2f7442c7();
        this._0x0f1c00de = new _0x50933d49()._0x4f8e33d1();
        this._0xe6d5cd60 = new _0x9fe11fc8()._0xe31e93af();
        this._0xe506cd08 = this._0x0f1c00de._0x87920c41;
        this._0x6a59c5bb = new _0xe394cc0d()._0x11488d7f(this._art);
        this._0x6a59c5bb._0x1561f239();
        new _0x6c06c1a1()._0xe6fed157();
        _0x2f6bc10c _0x053aaad1 = this._0xaaef4eb6();
        if (_0x053aaad1 == null || _0x053aaad1.Content == null)
        {
            return;
        }

        RectTransform _0xabc2c910 = _0x053aaad1.Content.transform as RectTransform;
        if (_0xabc2c910 == null)
        {
            return;
        }

        // The template PLAY button is already a child of Content. Our backdrop goes
        // UNDER it (first sibling) and the sheet overlay ON TOP of it (last sibling), so
        // the button is never covered and the sheets always cover the button.
        this._0xe927d8f8 = _0x0bb64a0b.Stretch(_0xabc2c910, _0x8bc18bfb._0x85fb5578(new byte[9] { 48, 19, 30, 30, 5, 62, 29, 31, 23 }, 124));
        this._0xe927d8f8.SetAsFirstSibling();
        this._0xacd20020 = new _0x8ddb910d()._0x588decef(this._0xe927d8f8, this._art, this._0x0f1c00de._0x87920c41);
        this._0xffa629e1();
        this._0x751d6484();
        this._0x2fe526cb();
        this._0x3dd23949();
        this._0xc17e372d();
        this._0x97b81a0e();
        this._0x68c38e51(_0xabc2c910);
        this._0x63e2566a = _0x0bb64a0b.Stretch(_0xabc2c910, _0x8bc18bfb._0x85fb5578(new byte[10] { 196, 231, 234, 234, 241, 206, 250, 231, 230, 252 }, 136));
        this._0x63e2566a.SetAsLastSibling();
        this._0x11e2bc62 = new _0x333088b0()._0x9c99bccf(this._0x63e2566a, this._art);
        this._0x1253653f = new _0x997c96d0()._0xa0aac095(this._0x11e2bc62._0xf1e1d8c9(0), this._art, this._0xc5bd6d47, this._0x0f1c00de);
        this._0xf49859a8 = new _0x17c13063()._0x14434bb1(this._0x11e2bc62._0xf1e1d8c9(1), this._art, this._0x0f1c00de);
        this._0x94d4ac19 = new _0xff37bc54()._0xdd5f78b2(this._0x11e2bc62._0xf1e1d8c9(2), this._art, this._0xc5bd6d47, this._0x0f1c00de, this._0xe6d5cd60);
        this._0x1253653f.OnClaimed = () => this._0xbc2f904f();
        this._0x1253653f.OnSeeCollection = () => this._0xa5ed6f32(1);
        this._0xf49859a8.OnDressed = () => this._0x3f385a9c();
        this._0x94d4ac19.OnReset = () => this._0xf097b6b0();
        this._0xf6222255(this._0xe506cd08, this._0xe506cd08 <= this._0x0f1c00de._0x0c132852());
        this._0x67bf1d73();
    }

    private TextMeshProUGUI _0x278951f7;
    private TextMeshProUGUI _0x28e60451;
    private TextMeshProUGUI _0x95d33c3f;
    private _0xe394cc0d _0x6a59c5bb;
    private _0x9fe11fc8 _0xe6d5cd60;
    [SerializeField]
    private _0x41b355c2 _art;
    private _0x8ae00696 _0xc5bd6d47;
    // Three rows, each a C.25 two-band layout: the pip gutter and the text column never
    // share an x-band, so a long mission title can never run under the indicator.
    private void _0x3dd23949()
    {
        Sprite _0x2f65a63f = this._art != null ? this._art.Round : null;
        TMP_FontAsset _0x27f53381 = this._art != null ? this._art.Font : null;
        const float _0x55a5fad4 = 1020f;
        RectTransform _0x766e184f = _0x0bb64a0b.Card(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[11] { 199, 227, 249, 249, 227, 229, 228, 201, 235, 248, 238 }, 138), _0x0bb64a0b.At(0.5f, 0.448f), new Vector2(1100f, 300f), _0x2f65a63f, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        if (this._0xe6d5cd60._0x451ba924())
        {
            _0x0bb64a0b.Caption(_0x766e184f, _0x8bc18bfb._0x85fb5578(new byte[13] { 62, 26, 0, 0, 26, 28, 29, 0, 54, 30, 3, 7, 10 }, 115), _0x27f53381, _0x8bc18bfb._0x85fb5578(new byte[37] { 246, 251, 251, 151, 250, 254, 228, 228, 254, 248, 249, 228, 151, 244, 251, 242, 246, 229, 242, 243, 189, 249, 242, 224, 151, 228, 242, 227, 151, 227, 248, 250, 248, 229, 229, 248, 224 }, 183), 30f, _0x0d231d8c.GoldLight, Vector2.zero, new Vector2(960f, 120f), TextAlignmentOptions.Center);
            return;
        }

        for (int _0xdce917a5 = 0; _0xdce917a5 < _0x9fe11fc8.MissionCount; _0xdce917a5++)
        {
            float _0x57d58e0a = 86f - _0xdce917a5 * 86f;
            RectTransform _0xf7688841 = _0x0bb64a0b.Node(_0x766e184f, _0x8bc18bfb._0x85fb5578(new byte[10] { 79, 107, 113, 113, 107, 109, 108, 80, 109, 117 }, 2) + _0xdce917a5.ToString(), new Vector2(0f, _0x57d58e0a), new Vector2(_0x55a5fad4, 78f));
            _0x0bb64a0b.Plate(_0xf7688841, _0x8bc18bfb._0x85fb5578(new byte[7] { 205, 240, 232, 217, 246, 243, 243 }, 159), Vector2.zero, new Vector2(_0x55a5fad4, 72f), _0x2f65a63f, _0x0d231d8c.Fade(_0x0d231d8c.Raised, 0.85f), _0x0bb64a0b.RadiusChip);
            int _0xac8ea084 = this._0xe6d5cd60._0xc9e982f8(_0xdce917a5);
            int _0xea0009a8 = this._0xe6d5cd60._0x451f3ea9(_0xdce917a5);
            float _0x5da16253 = _0xac8ea084 > 0 ? (float)_0xea0009a8 / _0xac8ea084 : 0f;
            RectTransform _0x0674c610 = _0x0bb64a0b.Node(_0xf7688841, _0x8bc18bfb._0x85fb5578(new byte[4] { 248, 193, 216, 219 }, 168), _0x0bb64a0b.GutterAt(_0x55a5fad4, 0f), new Vector2(_0x0bb64a0b.GutterWidth, 62f));
            for (int _0x159f965d = 0; _0x159f965d < 3; _0x159f965d++)
            {
                bool _0x83286930 = _0x5da16253 >= (_0x159f965d + 1) / 3f;
                _0x0bb64a0b.Plate(_0x0674c610, _0x8bc18bfb._0x85fb5578(new byte[3] { 41, 16, 9 }, 121) + _0x159f965d.ToString(), new Vector2(0f, 20f - _0x159f965d * 20f), new Vector2(56f, 12f), _0x2f65a63f, _0x83286930 ? _0x0d231d8c.Gold : _0x0d231d8c.Fade(_0x0d231d8c.Muted, 0.9f), 6f);
            }

            _0x0bb64a0b.Caption(_0xf7688841, _0x8bc18bfb._0x85fb5578(new byte[5] { 159, 162, 191, 167, 174 }, 203), _0x27f53381, this._0xe6d5cd60._0x1e94d6a2(_0xdce917a5), 30f, _0x0d231d8c.Cream, _0x0bb64a0b.TextAt(_0x55a5fad4, 14f), _0x0bb64a0b.TextBox(38f), TextAlignmentOptions.Left);
            _0x0bb64a0b.Caption(_0xf7688841, _0x8bc18bfb._0x85fb5578(new byte[8] { 194, 224, 253, 245, 224, 247, 225, 225 }, 146), _0x27f53381, _0xea0009a8.ToString() + _0x8bc18bfb._0x85fb5578(new byte[1] { 249 }, 214) + _0xac8ea084.ToString() + _0x8bc18bfb._0x85fb5578(new byte[6] { 150, 150, 155, 150, 150, 157 }, 182) + this._0xe6d5cd60._0xc54c193d(_0xdce917a5).ToString() + _0x8bc18bfb._0x85fb5578(new byte[6] { 167, 196, 200, 206, 201, 212 }, 135), 26f, _0x0d231d8c.Gold, _0x0bb64a0b.TextAt(_0x55a5fad4, -20f), _0x0bb64a0b.TextBox(34f), TextAlignmentOptions.Left);
        }
    }

    private _0x8ddb910d _0xacd20020;
    private void _0xd3dfd8f6()
    {
        int _0xf9e603a1 = this._0x0f1c00de._0x0c132852();
        this._0xe506cd08 = this._0xe506cd08 + 1;
        if (this._0xe506cd08 > _0x50933d49.AlbumCount)
        {
            this._0xe506cd08 = 1;
        }

        bool _0xa7b5b28c = this._0xe506cd08 <= _0xf9e603a1;
        if (_0xa7b5b28c)
        {
            this._0x0f1c00de._0x45484840(this._0xe506cd08);
            this._0xacd20020._0xf5d5498e(this._0xe506cd08, true);
        }

        this._0xf6222255(this._0xe506cd08, _0xa7b5b28c);
        this._0x67bf1d73();
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        DOTween.Kill(this.gameObject);
        if (this._0xacd20020 != null)
        {
            this._0xacd20020._0x71079683();
        }

        if (this._0x11e2bc62 != null)
        {
            this._0x11e2bc62._0xa1320efb();
        }

        if (this._0x6a59c5bb != null)
        {
            this._0x6a59c5bb._0x674ae8af();
        }

        if (this._0xa8bb852b != null)
        {
            DOTween.Kill(this._0xa8bb852b.gameObject);
        }

        if (this._0xa509b0ff != null)
        {
            DOTween.Kill(this._0xa509b0ff.gameObject);
        }

        if (this._0xfe17e4d6 != null)
        {
            for (int _0x53156406 = 0; _0x53156406 < this._0xfe17e4d6.Length; _0x53156406++)
            {
                if (this._0xfe17e4d6[_0x53156406] != null)
                {
                    DOTween.Kill(this._0xfe17e4d6[_0x53156406].gameObject);
                }
            }
        }
    }

    private Image[] _0xfe17e4d6;
    private void _0xbc2f904f()
    {
        this._0x67bf1d73();
    }

    private void _0x751d6484()
    {
        TMP_FontAsset _0x48297026 = this._art != null ? this._art.Font : null;
        this._0xa8bb852b = _0x0bb64a0b.Picture(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[13] { 175, 134, 149, 139, 130, 150, 146, 142, 137, 170, 134, 149, 140 }, 231), _0x0bb64a0b.At(0.5f, 0.806f), new Vector2(300f, 300f), this._art != null ? this._art.Emblem : null, _0x0d231d8c.Gold);
        this._0x28e60451 = _0x0bb64a0b.Caption(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[9] { 208, 237, 237, 239, 206, 227, 224, 231, 238 }, 130), _0x48297026, _0x8bc18bfb._0x85fb5578(new byte[12] { 126, 109, 100, 126, 109, 124, 8, 123, 124, 105, 111, 109 }, 40), 38f, _0x0d231d8c.Gold, _0x0bb64a0b.At(0.5f, 0.730f), new Vector2(1000f, 54f), TextAlignmentOptions.Center);
        this._0x1f217c2d = _0x0bb64a0b.Caption(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[11] { 3, 62, 62, 60, 23, 61, 48, 39, 62, 36, 35 }, 81), _0x48297026, _0x8bc18bfb._0x85fb5578(new byte[25] { 85, 73, 68, 33, 73, 78, 84, 82, 68, 33, 77, 72, 70, 73, 85, 82, 33, 82, 85, 64, 88, 33, 77, 78, 86 }, 1), 26f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.82f), _0x0bb64a0b.At(0.5f, 0.705f), new Vector2(1040f, 40f), TextAlignmentOptions.Center);
    }

    private Button _0xa509b0ff;
    // ---------------------------------------------------------------- composition
    private void _0xffa629e1()
    {
        Sprite _0xb7e61fff = this._art != null ? this._art.Round : null;
        TMP_FontAsset _0x6404d374 = this._art != null ? this._art.Font : null;
        RectTransform _0x2710da5e = _0x0bb64a0b.Card(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[10] { 151, 180, 185, 180, 187, 182, 176, 151, 180, 167 }, 213), _0x0bb64a0b.At(0.5f, 0.935f), new Vector2(1060f, 132f), _0xb7e61fff, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Picture(_0x2710da5e, _0x8bc18bfb._0x85fb5578(new byte[9] { 159, 179, 181, 178, 155, 176, 165, 172, 180 }, 220), new Vector2(-360f, 4f), new Vector2(56f, 56f), this._art != null ? this._art.Coin : null, _0x0d231d8c.Cream);
        _0x0bb64a0b.Caption(_0x2710da5e, _0x8bc18bfb._0x85fb5578(new byte[12] { 43, 7, 1, 6, 27, 43, 9, 24, 28, 1, 7, 6 }, 104), _0x6404d374, _0x8bc18bfb._0x85fb5578(new byte[5] { 253, 241, 247, 240, 237 }, 190), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.75f), new Vector2(-120f, -34f), new Vector2(360f, 32f), TextAlignmentOptions.Center);
        this._0x95d33c3f = _0x0bb64a0b.Caption(_0x2710da5e, _0x8bc18bfb._0x85fb5578(new byte[10] { 179, 159, 153, 158, 131, 166, 145, 156, 133, 149 }, 240), _0x6404d374, _0x8bc18bfb._0x85fb5578(new byte[5] { 147, 138, 150, 150, 150 }, 166), 44f, _0x0d231d8c.Gold, new Vector2(-120f, 18f), new Vector2(420f, 56f), TextAlignmentOptions.Center);
        RectTransform _0x4654a29b = _0x0bb64a0b.Node(_0x2710da5e, _0x8bc18bfb._0x85fb5578(new byte[7] { 161, 135, 133, 163, 136, 137, 144 }, 224), new Vector2(404f, 0f), new Vector2(104f, 60f));
        _0x0bb64a0b.Plate(_0x4654a29b, _0x8bc18bfb._0x85fb5578(new byte[4] { 31, 62, 61, 63 }, 90), Vector2.zero, new Vector2(104f, 60f), _0xb7e61fff, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusChip);
        _0x0bb64a0b.Plate(_0x4654a29b, _0x8bc18bfb._0x85fb5578(new byte[4] { 62, 17, 20, 20 }, 120), Vector2.zero, new Vector2(96f, 52f), _0xb7e61fff, _0x0d231d8c.DeepInk, _0x0bb64a0b.RadiusChip);
        _0x0bb64a0b.Caption(_0x4654a29b, _0x8bc18bfb._0x85fb5578(new byte[8] { 138, 172, 174, 135, 170, 169, 174, 167 }, 203), _0x6404d374, _0x8bc18bfb._0x85fb5578(new byte[3] { 160, 169, 186 }, 145), 28f, _0x0d231d8c.GoldLight, Vector2.zero, new Vector2(92f, 44f), TextAlignmentOptions.Center);
    }

    private TextMeshProUGUI _0xa67594c3;
    private TextMeshProUGUI _0x1f217c2d;
    private _0x17c13063 _0xf49859a8;
    private void _0xc17e372d()
    {
        Sprite _0xa1959154 = this._art != null ? this._art.Round : null;
        TMP_FontAsset _0xbbf6a80b = this._art != null ? this._art.Font : null;
        Button _0x9dac4212 = _0x0bb64a0b.Minor(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[16] { 215, 242, 250, 255, 234, 209, 252, 253, 230, 224, 209, 230, 231, 231, 252, 253 }, 147), _0xbbf6a80b, _0x8bc18bfb._0x85fb5578(new byte[11] { 137, 140, 132, 129, 148, 237, 143, 130, 131, 152, 158 }, 205), _0x0bb64a0b.At(0.22f, 0.175f), new Vector2(340f, 108f), _0xa1959154, 28f);
        _0x9dac4212.onClick.AddListener(() => this._0xa5ed6f32(0));
        this._0x278951f7 = _0x0bb64a0b.Caption(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[8] { 197, 232, 233, 242, 244, 215, 238, 247 }, 135), _0xbbf6a80b, _0x8bc18bfb._0x85fb5578(new byte[5] { 186, 173, 169, 172, 177 }, 232), 24f, _0x0d231d8c.GoldLight, _0x0bb64a0b.At(0.22f, 0.228f), new Vector2(340f, 34f), TextAlignmentOptions.Center);
        Button _0x10bc0d75 = _0x0bb64a0b.Minor(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[16] { 48, 28, 31, 31, 22, 16, 7, 26, 28, 29, 49, 6, 7, 7, 28, 29 }, 115), _0xbbf6a80b, _0x8bc18bfb._0x85fb5578(new byte[10] { 110, 98, 97, 97, 104, 110, 121, 100, 98, 99 }, 45), _0x0bb64a0b.At(0.50f, 0.175f), new Vector2(340f, 108f), _0xa1959154, 28f);
        _0x10bc0d75.onClick.AddListener(() => this._0xa5ed6f32(1));
        Button _0x14426c9b = _0x0bb64a0b.Minor(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[14] { 157, 171, 186, 186, 167, 160, 169, 189, 140, 187, 186, 186, 161, 160 }, 206), _0xbbf6a80b, _0x8bc18bfb._0x85fb5578(new byte[8] { 206, 216, 201, 201, 212, 211, 218, 206 }, 157), _0x0bb64a0b.At(0.78f, 0.175f), new Vector2(340f, 108f), _0xa1959154, 28f);
        _0x14426c9b.onClick.AddListener(() => this._0xa5ed6f32(2));
    }

    private RectTransform _0xe927d8f8;
    private _0x333088b0 _0x11e2bc62;
    private void _0x67bf1d73()
    {
        _0xf5cbd7d1.SetText(this._0x95d33c3f, _0x0bb64a0b.Thousands(this._0xc5bd6d47._0xc96bb9a6));
        _0xf5cbd7d1.SetText(this._0x278951f7, this._0x1253653f != null && this._0x1253653f._0xc7f51a64() ? _0x8bc18bfb._0x85fb5578(new byte[5] { 172, 187, 191, 186, 167 }, 254) : string.Empty);
    }

    private _0x2f6bc10c _0xaaef4eb6()
    {
        if (_0xa62f9119.Instance == null || _0xa62f9119.Instance.Panels == null)
        {
            return null;
        }

        if (_0xc3dbd8a4._0x576642f8.DEFAULT >= _0xa62f9119.Instance.Panels.Count)
        {
            return null;
        }

        return _0xa62f9119.Instance.Panels[_0xc3dbd8a4._0x576642f8.DEFAULT];
    }

    private void _0x97b81a0e()
    {
        _0x0bb64a0b.Caption(this._0xe927d8f8, _0x8bc18bfb._0x85fb5578(new byte[10] { 246, 218, 216, 197, 217, 220, 212, 219, 214, 208 }, 181), this._art != null ? this._art.Font : null, _0x8bc18bfb._0x85fb5578(new byte[44] { 12, 5, 22, 29, 29, 16, 29, 29, 107, 116, 111, 105, 104, 124, 113, 29, 126, 114, 116, 115, 110, 29, 114, 115, 113, 100, 29, 29, 16, 29, 29, 115, 114, 29, 111, 120, 124, 113, 29, 112, 114, 115, 120, 100 }, 61), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.62f), _0x0bb64a0b.At(0.5f, 0.062f), new Vector2(1100f, 38f), TextAlignmentOptions.Center);
    }

    private RectTransform _0x63e2566a;
}

internal static class _0x8bc18bfb
{
    internal static string _0x85fb5578(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}