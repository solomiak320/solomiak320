using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// WIN (7) / LOSE (8) / PAUSE (6), fully dressed (C.3). The template body of each pop is
// switched off and our own card is built inside Content, so no template wording, no
// "Score:" row without a value and no sprite-less close square survives. The close cross
// carries its sprite through a SERIALIZED reference held by ArtKit - never Resources.Load,
// never a lookup by name. Buttons are built one by one with their own caption, so the
// cross can never inherit an action button's label (C.17).
public sealed class _0x59333f39 : MonoBehaviour
{
    private void _0xa9b58533()
    {
        if (this.OnTakeRefill != null)
        {
            this.OnTakeRefill();
        }
    }

    private void _0x30f15b08()
    {
        if (this.OnSpinAgain != null)
        {
            this.OnSpinAgain();
        }
    }

    private void _0x3f277986()
    {
        if (this.OnResume != null)
        {
            this.OnResume();
        }
    }

    public System.Action OnSpinAgain;
    public void _0xd5e835b7(int _0xe3bfbf3a, int _0xfc1c87de)
    {
        _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.PAUSE);
        _0x8f94dcac _0x0cef9b64 = _0xe6d286ce.Instance._0x9f18a12f(_0xc3dbd8a4._0x92fa9eac.PAUSE);
        this._0x23b70399 = this._0xdcee5d78(_0x0cef9b64, this._0x23b70399, _0xd6e5f15c._0xe2c58af4(new byte[12] { 39, 32, 58, 43, 60, 35, 39, 61, 61, 39, 33, 32 }, 110), _0xd6e5f15c._0xe2c58af4(new byte[20] { 148, 136, 133, 224, 147, 148, 129, 135, 133, 224, 137, 147, 224, 151, 129, 137, 148, 137, 142, 135 }, 192), _0xd6e5f15c._0xe2c58af4(new byte[6] { 149, 153, 159, 152, 133, 246 }, 214) + _0x0bb64a0b.Thousands(_0xe3bfbf3a) + _0xd6e5f15c._0xe2c58af4(new byte[9] { 191, 191, 178, 191, 191, 221, 218, 203, 191 }, 159) + _0x0bb64a0b.Thousands(_0xfc1c87de), _0xd6e5f15c._0xe2c58af4(new byte[6] { 132, 147, 133, 131, 155, 147 }, 214), _0x0d231d8c.Cream, () => this._0x3f277986(), () => this._0x3f277986());
    }

    private void _0xb44121ee()
    {
        _0xe6d286ce.Instance._0x4f14b792();
        _0x05c8a753.Instance._0x8595e80b(_0xc3dbd8a4._0x28f4af65.SCENE_0);
    }

    public void _0xdf2299e1(int _0x4b69fc16)
    {
        _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.LOSE);
        _0x8f94dcac _0xf623c3af = _0xe6d286ce.Instance._0x9f18a12f(_0xc3dbd8a4._0x92fa9eac.LOSE);
        this._0xc7ddb1ed = this._0xdcee5d78(_0xf623c3af, this._0xc7ddb1ed, _0xd6e5f15c._0xe2c58af4(new byte[18] { 40, 52, 57, 92, 52, 51, 41, 47, 57, 92, 53, 47, 92, 45, 41, 53, 57, 40 }, 124), _0xd6e5f15c._0xe2c58af4(new byte[17] { 93, 81, 87, 80, 62, 76, 91, 88, 87, 82, 82, 62, 76, 91, 95, 90, 71 }, 30), _0xd6e5f15c._0xe2c58af4(new byte[1] { 245 }, 222) + _0x0bb64a0b.Thousands(_0x4b69fc16) + _0xd6e5f15c._0xe2c58af4(new byte[11] { 194, 164, 176, 167, 167, 194, 161, 173, 171, 172, 177 }, 226), _0xd6e5f15c._0xe2c58af4(new byte[11] { 155, 142, 132, 138, 239, 157, 138, 137, 134, 131, 131 }, 207), _0x0d231d8c.GoldLight, () => this._0xa9b58533(), () => this._0xa9b58533());
    }

    private RectTransform _0x96a0129d;
    public System.Action OnResume;
    private RectTransform _0xc7ddb1ed;
    // The card is REBUILT per result, never cached: captions and handlers are captured
    // when it is built, so a kept card would offer the previous result's action.
    private RectTransform _0xdcee5d78(_0x8f94dcac _0x9956bb49, RectTransform _0xc1eac711, string _0x1920258b, string _0x61b8cfda, string _0xd2e8b1cf, string _0x1ee17621, Color _0x5666610e, System.Action _0xb3a3a677, System.Action _0xec5332f9)
    {
        if (_0x9956bb49 == null || _0x9956bb49.Content == null)
        {
            return null;
        }

        RectTransform _0x6c8d21d9 = _0x9956bb49.Content.transform as RectTransform;
        if (_0x6c8d21d9 == null)
        {
            return null;
        }

        if (_0xc1eac711 != null)
        {
            DOTween.Kill(_0xc1eac711.gameObject);
            _0xc1eac711.SetParent(null, false);
            Destroy(_0xc1eac711.gameObject);
        }

        // Child 0 is the BASE_PANEL chrome that carries the themed surface - keep it.
        // Children 1.. are the template body (static label rows, stock button banks).
        for (int _0x83ef31d7 = 1; _0x83ef31d7 < _0x6c8d21d9.childCount; _0x83ef31d7++)
        {
            Transform _0xc97112f5 = _0x6c8d21d9.GetChild(_0x83ef31d7);
            if (_0xc97112f5 != null)
            {
                _0xc97112f5.gameObject.SetActive(false);
            }
        }

        Sprite _0x0fe4b87c = this._0x676e7105 != null ? this._0x676e7105.Round : null;
        Sprite _0x06932b54 = _0x0fe4b87c;
        TMP_FontAsset _0xfa4021e5 = this._0x676e7105 != null ? this._0x676e7105.Font : null;
        RectTransform _0x8714482d = _0x0bb64a0b.Node(_0x6c8d21d9, _0xd6e5f15c._0xe2c58af4(new byte[10] { 96, 87, 65, 71, 94, 70, 113, 83, 64, 86 }, 50), Vector2.zero, new Vector2(1000f, 860f));
        _0x0bb64a0b.Plate(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[4] { 24, 57, 58, 56 }, 93), Vector2.zero, new Vector2(1000f, 860f), _0x0fe4b87c, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Plate(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[4] { 116, 91, 94, 94 }, 50), Vector2.zero, new Vector2(988f, 848f), _0x0fe4b87c, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Plate(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[5] { 146, 169, 164, 164, 175 }, 193), new Vector2(0f, 230f), new Vector2(960f, 320f), _0x0fe4b87c, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.22f), _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Picture(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[4] { 225, 205, 222, 199 }, 172), new Vector2(0f, 236f), new Vector2(190f, 190f), this._0x676e7105 != null ? this._0x676e7105.Emblem : null, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.92f));
        _0x0bb64a0b.Caption(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[6] { 204, 225, 229, 224, 225, 246 }, 132), _0xfa4021e5, _0x1920258b, 54f, _0x0d231d8c.Gold, new Vector2(0f, 86f), new Vector2(900f, 78f), TextAlignmentOptions.Center);
        _0x0bb64a0b.Caption(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[4] { 156, 176, 184, 191 }, 209), _0xfa4021e5, _0x61b8cfda, 72f, _0x5666610e, new Vector2(0f, -16f), new Vector2(900f, 96f), TextAlignmentOptions.Center);
        _0x0bb64a0b.Caption(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[5] { 225, 220, 208, 214, 197 }, 164), _0xfa4021e5, _0xd2e8b1cf, 32f, _0x0d231d8c.Lilac, new Vector2(0f, -98f), new Vector2(900f, 54f), TextAlignmentOptions.Center);
        Button _0x7e8ce48a = _0x0bb64a0b.Cta(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[13] { 2, 32, 59, 63, 51, 32, 43, 19, 49, 38, 59, 61, 60 }, 82), _0xfa4021e5, _0x1ee17621, new Vector2(0f, -224f), new Vector2(620f, 150f), _0x06932b54, 48f);
        _0x7e8ce48a.onClick.AddListener(() => this._0xb15e1c12(_0xb3a3a677));
        Button _0x6a8624db = _0x0bb64a0b.Minor(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[11] { 121, 90, 87, 87, 76, 116, 86, 65, 92, 90, 91 }, 53), _0xfa4021e5, _0xd6e5f15c._0xe2c58af4(new byte[5] { 178, 177, 188, 188, 167 }, 254), new Vector2(0f, -346f), new Vector2(420f, 104f), _0x0fe4b87c, 34f);
        _0x6a8624db.onClick.AddListener(() => this._0xb44121ee());
        Button _0xdec078c8 = _0x0bb64a0b.IconAction(_0x8714482d, _0xd6e5f15c._0xe2c58af4(new byte[10] { 117, 90, 89, 69, 83, 117, 68, 89, 69, 69 }, 54), new Vector2(428f, 358f), 96f, _0x0fe4b87c, this._0x676e7105 != null ? this._0x676e7105.IconClose : null, 46f, _0x0d231d8c.Raised);
        // The cross CLOSES; it never repeats the primary action. On WIN that means it must
        // not quietly start (and charge) another spin, while on PAUSE it still has to hand
        // control back - closing without resuming would leave the machine frozen with no
        // way to reach the pause button again. So each pop passes its own close action.
        _0xdec078c8.onClick.AddListener(() => this._0xb15e1c12(_0xec5332f9));
        _0x8714482d.localScale = new Vector3(0.92f, 0.92f, 1f);
        _0x8714482d.DOScale(1f, 0.24f).SetEase(Ease.OutBack).SetLink(_0x8714482d.gameObject);
        return _0x8714482d;
    }

    private void _0xb15e1c12(System.Action _0xd56fc205)
    {
        _0xe6d286ce.Instance._0x4f14b792();
        if (_0xd56fc205 != null)
        {
            _0xd56fc205();
        }
    }

    public System.Action OnTakeRefill;
    private _0x41b355c2 _0x676e7105;
    public void _0xaa0462de(int _0xd7204482, string _0x923bd464)
    {
        _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.WIN);
        _0x8f94dcac _0x0792c149 = _0xe6d286ce.Instance._0x9f18a12f(_0xc3dbd8a4._0x92fa9eac.WIN);
        this._0x96a0129d = this._0xdcee5d78(_0x0792c149, this._0x96a0129d, _0xd6e5f15c._0xe2c58af4(new byte[13] { 246, 245, 234, 241, 233, 236, 226, 237, 241, 133, 242, 236, 235 }, 165), _0xd6e5f15c._0xe2c58af4(new byte[1] { 138 }, 161) + _0x0bb64a0b.Thousands(_0xd7204482) + _0xd6e5f15c._0xe2c58af4(new byte[6] { 91, 56, 52, 50, 53, 40 }, 123), _0x923bd464, _0xd6e5f15c._0xe2c58af4(new byte[10] { 223, 220, 197, 194, 172, 205, 203, 205, 197, 194 }, 140), _0x0d231d8c.Gold, () => this._0x30f15b08(), null);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        if (this._0x96a0129d != null)
        {
            DOTween.Kill(this._0x96a0129d.gameObject);
        }

        if (this._0xc7ddb1ed != null)
        {
            DOTween.Kill(this._0xc7ddb1ed.gameObject);
        }

        if (this._0x23b70399 != null)
        {
            DOTween.Kill(this._0x23b70399.gameObject);
        }
    }

    private RectTransform _0x23b70399;
    public void _0x98db683b(_0x41b355c2 _0x0ed1b65d)
    {
        this._0x676e7105 = _0x0ed1b65d;
    }
}

internal static class _0xd6e5f15c
{
    internal static string _0xe2c58af4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}