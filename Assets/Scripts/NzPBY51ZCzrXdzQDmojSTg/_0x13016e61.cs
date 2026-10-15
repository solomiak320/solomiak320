using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The game scene HUD, built from OUR OWN objects only: nothing of ours is hung on a
// template placeholder and no template slot is referenced (C.2). The template's TopPanel
// is switched off in the scene, so this is the only button set on screen (rule H).
// Set-up runs from Build(), called by the director in Start() (C.59).
public sealed class _0x13016e61 : MonoBehaviour
{
    private void _0xe1b94e3d()
    {
        if (this.OnBetUp != null)
        {
            this.OnBetUp();
        }
    }

    private void _0xe070689a()
    {
        if (this.OnPause != null)
        {
            this.OnPause();
        }
    }

    private Button _0x05fb7204;
    public void _0xd390308f(bool _0x6256e475, bool _0xe7389aa8)
    {
        if (this._0x05fb7204 != null)
        {
            this._0x05fb7204.interactable = _0x6256e475;
        }

        if (this._0xca28fb62 != null)
        {
            this._0xca28fb62.interactable = _0xe7389aa8;
        }
    }

    private Button _0xca28fb62;
    public void _0x583940d0(bool _0xec15f131)
    {
        if (this._0xc7bd0f23 != null)
        {
            this._0xc7bd0f23.text = _0xec15f131 ? _0xdc8bbf6f._0xa335ea3f(new byte[8] { 215, 212, 205, 202, 202, 205, 202, 195 }, 132) : _0xdc8bbf6f._0xa335ea3f(new byte[4] { 174, 173, 180, 179 }, 253);
        }

        if (this._0x5306e8e7 != null)
        {
            this._0x5306e8e7.interactable = !_0xec15f131;
        }
    }

    private bool _0x537e495c;
    private _0x41b355c2 _0x945ce7c3;
    private void _0xe287698e()
    {
        if (this.OnBack != null)
        {
            this.OnBack();
        }
    }

    private TextMeshProUGUI _0xdff6c7a3;
    private TextMeshProUGUI _0xc4450b16;
    public void _0xdf481973(string _0x565fec3f, float _0x9deb52e3)
    {
        if (this._0xe2509594 != null)
        {
            this._0xe2509594.text = _0x565fec3f;
        }

        if (this._0x1b92c1ce != null)
        {
            float width = Mathf.Clamp01(_0x9deb52e3) * 680f;
            this._0x1b92c1ce.rectTransform.sizeDelta = new Vector2(width < 10f ? 10f : width, 10f);
        }
    }

    [SerializeField]
    private GameObject _coinPrefab;
    private TextMeshProUGUI _0x06e33fc4;
    public void _0x8250474a(int _0x80020601, bool _0xc29369dd)
    {
        if (this._0x06e33fc4 == null)
        {
            return;
        }

        if (!_0xc29369dd)
        {
            this._0x0c40de13 = _0x80020601;
            this._0x06e33fc4.text = _0x0bb64a0b.Thousands(_0x80020601);
            return;
        }

        int _0x385efc13 = this._0x0c40de13;
        this._0x0c40de13 = _0x80020601;
        DOVirtual.Float(_0x385efc13, _0x80020601, 0.6f, _0x2a8711e0 =>
        {
            if (this._0x06e33fc4 != null)
            {
                this._0x06e33fc4.text = _0x0bb64a0b.Thousands(Mathf.RoundToInt(_0x2a8711e0));
            }
        }).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._0x06e33fc4.rectTransform.DOPunchScale(new Vector3(0.12f, 0.12f, 0f), 0.4f, 6, 0.6f).SetLink(this._0x06e33fc4.gameObject);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        DOTween.Kill(this.gameObject);
    }

    private TextMeshProUGUI _0x565aba6c(RectTransform _0x3b065659, TMP_FontAsset _0x232629b5, string _0x497b0278, string _0x46c20eab, float _0x5539766f, Color _0xe2589136)
    {
        _0x0bb64a0b.Caption(_0x3b065659, _0x497b0278 + _0xdc8bbf6f._0xa335ea3f(new byte[7] { 3, 33, 48, 52, 41, 47, 46 }, 64), _0x232629b5, _0x497b0278, 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.75f), new Vector2(_0x5539766f, -34f), new Vector2(260f, 32f), TextAlignmentOptions.Center);
        return _0x0bb64a0b.Caption(_0x3b065659, _0x497b0278 + _0xdc8bbf6f._0xa335ea3f(new byte[5] { 101, 82, 95, 70, 86 }, 51), _0x232629b5, _0x46c20eab, 42f, _0xe2589136, new Vector2(_0x5539766f, 16f), new Vector2(300f, 52f), TextAlignmentOptions.Center);
    }

    private int _0x7c0c8d7a;
    private Image _0x1b92c1ce;
    private int _0x0c40de13;
    private TextMeshProUGUI _0xe2509594;
    public System.Action OnSpin;
    public System.Action OnBack;
    public System.Action OnPause;
    public void _0x4bd920be(RectTransform _0xc7849cc1, _0x41b355c2 _0x3884e2a6)
    {
        if (this._0x537e495c)
        {
            return;
        }

        this._0x537e495c = true;
        this._0x945ce7c3 = _0x3884e2a6;
        this._0xd4e04d6d = _0x0bb64a0b.Stretch(_0xc7849cc1, _0xdc8bbf6f._0xa335ea3f(new byte[10] { 75, 119, 122, 126, 107, 109, 122, 87, 106, 123 }, 31));
        Sprite _0xbf074459 = _0x3884e2a6 != null ? _0x3884e2a6.Round : null;
        TMP_FontAsset _0xb654e1cc = _0x3884e2a6 != null ? _0x3884e2a6.Font : null;
        // Back and Pause: our own pair, one slot each, same icon size, same plate.
        Button _0x9c1aa85f = _0x0bb64a0b.IconAction(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[10] { 35, 0, 2, 10, 35, 20, 21, 21, 14, 15 }, 97), _0x0bb64a0b.At(0.095f, 0.950f), 112f, _0xbf074459, _0x3884e2a6 != null ? _0x3884e2a6.IconBack : null, 54f, _0x0d231d8c.Surface);
        _0x9c1aa85f.onClick.AddListener(() => this._0xe287698e());
        Button _0x0888dbec = _0x0bb64a0b.IconAction(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[11] { 87, 102, 114, 116, 98, 69, 114, 115, 115, 104, 105 }, 7), _0x0bb64a0b.At(0.905f, 0.950f), 112f, _0xbf074459, _0x3884e2a6 != null ? _0x3884e2a6.IconPause : null, 48f, _0x0d231d8c.Surface);
        _0x0888dbec.onClick.AddListener(() => this._0xe070689a());
        // Balance / bet / win strip.
        RectTransform _0xb18ead21 = _0x0bb64a0b.Card(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[8] { 192, 253, 236, 219, 252, 250, 225, 248 }, 136), _0x0bb64a0b.At(0.5f, 0.868f), new Vector2(1150f, 128f), _0xbf074459, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        this._0x48c9cd4e = _0x0bb64a0b.Node(_0xb18ead21, _0xdc8bbf6f._0xa335ea3f(new byte[10] { 186, 150, 144, 151, 184, 151, 154, 145, 150, 139 }, 249), new Vector2(-1150f * 0.28f, 10f), new Vector2(8f, 8f));
        _0x0bb64a0b.Picture(_0xb18ead21, _0xdc8bbf6f._0xa335ea3f(new byte[9] { 109, 65, 71, 64, 105, 66, 87, 94, 70 }, 46), new Vector2(-1150f * 0.40f, 6f), new Vector2(50f, 50f), _0x3884e2a6 != null ? _0x3884e2a6.Coin : null, _0x0d231d8c.Cream);
        this._0x06e33fc4 = this._0x565aba6c(_0xb18ead21, _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[5] { 217, 213, 211, 212, 201 }, 154), _0xdc8bbf6f._0xa335ea3f(new byte[5] { 92, 69, 89, 89, 89 }, 105), -1150f * 0.26f, _0x0d231d8c.Gold);
        this._0xc4450b16 = this._0x565aba6c(_0xb18ead21, _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[3] { 2, 5, 20 }, 64), _0xdc8bbf6f._0xa335ea3f(new byte[2] { 101, 96 }, 80), 0f, _0x0d231d8c.Cream);
        this._0xdff6c7a3 = this._0x565aba6c(_0xb18ead21, _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[3] { 181, 171, 172 }, 226), _0xdc8bbf6f._0xa335ea3f(new byte[1] { 136 }, 184), 1150f * 0.30f, _0x0d231d8c.GoldLight);
        // The machine, in one line, sitting in the band between the balance strip and the
        // reel frame - a gap that would otherwise be dead space.
        _0x0bb64a0b.Caption(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[11] { 129, 173, 175, 164, 165, 162, 169, 128, 165, 162, 169 }, 204), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[54] { 222, 223, 207, 191, 174, 182, 163, 166, 161, 170, 188, 207, 207, 194, 207, 207, 165, 160, 164, 170, 189, 207, 166, 188, 207, 184, 166, 163, 171, 207, 207, 194, 207, 207, 187, 166, 172, 164, 170, 187, 207, 191, 174, 182, 188, 207, 174, 161, 182, 184, 167, 170, 189, 170 }, 239), 26f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.86f), _0x0bb64a0b.At(0.5f, 0.783f), new Vector2(1120f, 40f), TextAlignmentOptions.Center);
        // Mission ticker.
        RectTransform _0xc82e12db = _0x0bb64a0b.Card(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[13] { 250, 222, 196, 196, 222, 216, 217, 227, 222, 212, 220, 210, 197 }, 183), _0x0bb64a0b.At(0.5f, 0.355f), new Vector2(780f, 86f), _0xbf074459, _0x0d231d8c.Raised, _0x0bb64a0b.RadiusChip);
        this._0xc1cd89b2 = _0x0bb64a0b.Node(_0xc82e12db, _0xdc8bbf6f._0xa335ea3f(new byte[5] { 251, 221, 206, 204, 196 }, 175), new Vector2(0f, -24f), new Vector2(680f, 10f));
        _0x0bb64a0b.Plate(this._0xc1cd89b2, _0xdc8bbf6f._0xa335ea3f(new byte[9] { 97, 71, 84, 86, 94, 115, 92, 89, 89 }, 53), Vector2.zero, new Vector2(680f, 10f), _0xbf074459, _0x0d231d8c.Fade(_0x0d231d8c.DeepInk, 0.85f), 12f);
        this._0x1b92c1ce = _0x0bb64a0b.Plate(this._0xc1cd89b2, _0xdc8bbf6f._0xa335ea3f(new byte[8] { 157, 191, 162, 170, 191, 168, 190, 190 }, 205), new Vector2(-340f, 0f), new Vector2(10f, 10f), _0xbf074459, _0x0d231d8c.Gold, 12f);
        this._0x1b92c1ce.rectTransform.pivot = new Vector2(0f, 0.5f);
        this._0x1b92c1ce.rectTransform.anchoredPosition = new Vector2(-340f, 0f);
        this._0xe2509594 = _0x0bb64a0b.Caption(_0xc82e12db, _0xdc8bbf6f._0xa335ea3f(new byte[11] { 35, 30, 20, 28, 18, 5, 59, 22, 21, 18, 27 }, 119), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[13] { 218, 223, 215, 210, 199, 190, 211, 215, 205, 205, 215, 209, 208 }, 158), 30f, _0x0d231d8c.Cream, new Vector2(0f, 14f), new Vector2(700f, 42f), TextAlignmentOptions.Center);
        // Control hint - permanent, and it lands in the review frame (C.6).
        _0x0bb64a0b.Caption(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[11] { 152, 180, 181, 175, 169, 180, 183, 147, 178, 181, 175 }, 219), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[39] { 109, 120, 105, 25, 106, 105, 112, 119, 25, 25, 20, 25, 25, 108, 106, 124, 25, 20, 25, 120, 119, 125, 25, 18, 25, 109, 118, 25, 106, 124, 109, 25, 109, 113, 124, 25, 123, 124, 109 }, 57), 28f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.92f), _0x0bb64a0b.At(0.5f, 0.268f), new Vector2(1060f, 46f), TextAlignmentOptions.Center);
        // Controls row.
        this._0x05fb7204 = _0x0bb64a0b.Minor(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[7] { 75, 108, 125, 77, 102, 126, 103 }, 9), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[1] { 154 }, 183), _0x0bb64a0b.At(0.19f, 0.150f), new Vector2(138f, 138f), _0xbf074459, 52f);
        this._0x05fb7204.onClick.AddListener(() => this._0x21b7fc78());
        this._0xca28fb62 = _0x0bb64a0b.Minor(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[5] { 243, 212, 197, 228, 193 }, 177), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[1] { 231 }, 204), _0x0bb64a0b.At(0.81f, 0.150f), new Vector2(138f, 138f), _0xbf074459, 52f);
        this._0xca28fb62.onClick.AddListener(() => this._0xe1b94e3d());
        this._0x5306e8e7 = _0x0bb64a0b.Cta(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[10] { 227, 192, 217, 222, 242, 197, 196, 196, 223, 222 }, 176), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[4] { 65, 66, 91, 92 }, 18), _0x0bb64a0b.At(0.5f, 0.150f), new Vector2(560f, 164f), _0xbf074459, 56f);
        this._0x5306e8e7.onClick.AddListener(() => this._0x490cc46b());
        this._0xc7bd0f23 = this._0x5306e8e7.GetComponentInChildren<TextMeshProUGUI>();
        _0x0bb64a0b.Caption(this._0xd4e04d6d, _0xdc8bbf6f._0xa335ea3f(new byte[10] { 157, 177, 179, 174, 178, 183, 191, 176, 189, 187 }, 222), _0xb654e1cc, _0xdc8bbf6f._0xa335ea3f(new byte[31] { 154, 133, 158, 152, 153, 141, 128, 236, 143, 131, 133, 130, 159, 236, 236, 225, 236, 236, 130, 131, 236, 158, 137, 141, 128, 236, 129, 131, 130, 137, 149 }, 204), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.60f), _0x0bb64a0b.At(0.5f, 0.048f), new Vector2(900f, 36f), TextAlignmentOptions.Center);
    }

    private void _0x490cc46b()
    {
        if (this.OnSpin != null)
        {
            this.OnSpin();
        }
    }

    private RectTransform _0x48c9cd4e;
    // Coins fly from the reel frame to the balance: the visible confirmation rule C.7
    // asks for, and it photographs well in the review album.
    public void _0x3bcd5a77(Vector2 _0x5bb0822b, int _0xee8578c5)
    {
        if (this._0xd4e04d6d == null || this._0x48c9cd4e == null)
        {
            return;
        }

        Sprite _0xbb261d5a = this._0x945ce7c3 != null ? this._0x945ce7c3.Coin : null;
        Vector2 _0xd16b9d39 = this._0x48c9cd4e.anchoredPosition + new Vector2(0f, _0x0bb64a0b.PanelHeight * (0.868f - 0.5f));
        int _0x10040647 = _0xee8578c5 < 1 ? 1 : _0xee8578c5;
        for (int _0xe0d45604 = 0; _0xe0d45604 < _0x10040647; _0xe0d45604++)
        {
            Image _0x90c42a00 = _0x0bb64a0b.Spawn(this._0xd4e04d6d, this._coinPrefab, _0xdc8bbf6f._0xa335ea3f(new byte[7] { 209, 251, 238, 212, 248, 254, 249 }, 151), _0x5bb0822b, new Vector2(56f, 56f), _0xbb261d5a, _0x0d231d8c.Cream);
            float _0x0bc150b9 = _0xe0d45604 * 0.04f;
            _0x90c42a00.rectTransform.DOAnchorPos(_0xd16b9d39, 0.55f).SetEase(Ease.InCubic).SetDelay(_0x0bc150b9).SetLink(_0x90c42a00.gameObject).OnComplete(() =>
            {
                if (_0x90c42a00 != null)
                {
                    Destroy(_0x90c42a00.gameObject);
                }
            });
            _0x90c42a00.DOFade(0.15f, 0.55f).SetDelay(_0x0bc150b9).SetLink(_0x90c42a00.gameObject);
        }
    }

    private Button _0x5306e8e7;
    public void _0x778f3f71(int _0xafdd9fd9)
    {
        if (this._0xc4450b16 != null)
        {
            this._0xc4450b16.text = _0x0bb64a0b.Thousands(_0xafdd9fd9);
        }
    }

    private TextMeshProUGUI _0xc7bd0f23;
    public System.Action OnBetUp;
    private RectTransform _0xd4e04d6d;
    public System.Action OnBetDown;
    private void _0x21b7fc78()
    {
        if (this.OnBetDown != null)
        {
            this.OnBetDown();
        }
    }

    public void _0xe166b146(int _0x87af72a4, bool _0xd258a85e)
    {
        if (this._0xdff6c7a3 == null)
        {
            return;
        }

        if (!_0xd258a85e)
        {
            this._0x7c0c8d7a = _0x87af72a4;
            this._0xdff6c7a3.text = _0x0bb64a0b.Thousands(_0x87af72a4);
            return;
        }

        int _0xbdea8e3c = this._0x7c0c8d7a;
        this._0x7c0c8d7a = _0x87af72a4;
        DOVirtual.Float(_0xbdea8e3c, _0x87af72a4, 0.6f, _0x2a8711e0 =>
        {
            if (this._0xdff6c7a3 != null)
            {
                this._0xdff6c7a3.text = _0x0bb64a0b.Thousands(Mathf.RoundToInt(_0x2a8711e0));
            }
        }).SetEase(Ease.OutCubic).SetLink(this.gameObject);
        this._0xdff6c7a3.rectTransform.DOPunchScale(new Vector3(0.14f, 0.14f, 0f), 0.45f, 6, 0.6f).SetLink(this._0xdff6c7a3.gameObject);
    }

    private RectTransform _0xc1cd89b2;
}

internal static class _0xdc8bbf6f
{
    internal static string _0xa335ea3f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}