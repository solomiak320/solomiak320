using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// One overlay container with three content pages: the daily bonus, the symbol albums and
// the settings. It is ONE object with three roots rather than three template panel
// indices, because an m_IsActive aimed at a template panel from a scene is silently
// discarded (C.2) - generated code reliably controls only what it created itself.
//
// The dim behind the card takes raycasts, so a tap outside the card cannot reach the
// lobby underneath (including the template PLAY button). No constructor (C.59).
public sealed class _0x333088b0
{
    public void _0xa1320efb()
    {
        if (this._0x5ec47c35 != null)
        {
            DOTween.Kill(this._0x5ec47c35.gameObject);
        }
    }

    public void _0xb305fa6c(int _0x5f940be6)
    {
        if (this._0x861ff521 == null || _0x5f940be6 < 0 || _0x5f940be6 >= this._0x861ff521.Length)
        {
            return;
        }

        for (int _0xf664cbe3 = 0; _0xf664cbe3 < this._0x861ff521.Length; _0xf664cbe3++)
        {
            this._0x861ff521[_0xf664cbe3].gameObject.SetActive(_0xf664cbe3 == _0x5f940be6);
        }

        this._0x2745a61f = _0x5f940be6;
        this._0xf592c465.Show();
        this._0x5ec47c35.localScale = new Vector3(0.92f, 0.92f, 1f);
        this._0x5ec47c35.DOScale(1f, 0.24f).SetEase(Ease.OutBack).SetLink(this._0x5ec47c35.gameObject);
    }

    public bool _0xe9313fc9
    {
        get
        {
            return this._0xf592c465 != null && this._0xf592c465._0x4fd4b597;
        }
    }

    public void _0xd41055c1()
    {
        if (this._0xf592c465 == null)
        {
            return;
        }

        this._0x5ec47c35.DOScale(0.94f, 0.18f).SetEase(Ease.InSine).OnComplete(() => this._0x96530091()).SetLink(this._0x5ec47c35.gameObject);
    }

    private _0x41b355c2 _0x3c62be1a;
    private RectTransform _0x5ec47c35;
    public const float CardHeight = 1908f; // spans canvas y 0.165 .. 0.875
    private void _0x96530091()
    {
        this._0xf592c465._0x8e086730();
        this._0x5ec47c35.localScale = Vector3.one;
    }

    public _0x333088b0 _0x9c99bccf(RectTransform _0x515f7666, _0x41b355c2 _0xda2d2c80)
    {
        this._0x3c62be1a = _0xda2d2c80;
        Sprite _0x31bd16fc = _0xda2d2c80 != null ? _0xda2d2c80.Round : null;
        Sprite _0x9c159bfe = _0xda2d2c80 != null ? _0xda2d2c80.Soft : null;
        this._0x007a43f9 = _0x0bb64a0b.Stretch(_0x515f7666, _0x509ef372._0x9d74d324(new byte[9] { 17, 42, 39, 39, 54, 10, 45, 49, 54 }, 66));
        Image _0xf757c6bd = _0x0bb64a0b.Wash(this._0x007a43f9, _0x509ef372._0x9d74d324(new byte[8] { 159, 164, 169, 169, 184, 136, 165, 161 }, 204), _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.72f));
        _0xf757c6bd.raycastTarget = true;
        this._0x5ec47c35 = _0x0bb64a0b.Node(this._0x007a43f9, _0x509ef372._0x9d74d324(new byte[9] { 239, 212, 217, 217, 200, 255, 221, 206, 216 }, 188), _0x0bb64a0b.At(0.5f, CardCentreY), new Vector2(CardWidth, CardHeight));
        _0x0bb64a0b.Plate(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[10] { 21, 55, 36, 50, 5, 62, 55, 50, 57, 33 }, 86), new Vector2(0f, -16f), new Vector2(CardWidth + 44f, CardHeight + 44f), _0x9c159bfe, _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.60f), 1.1f);
        _0x0bb64a0b.Plate(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[8] { 26, 56, 43, 61, 28, 61, 62, 60 }, 89), Vector2.zero, new Vector2(CardWidth, CardHeight), _0x31bd16fc, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Plate(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[8] { 209, 243, 224, 246, 212, 251, 254, 254 }, 146), Vector2.zero, new Vector2(CardWidth - 10f, CardHeight - 10f), _0x31bd16fc, _0x0d231d8c.Surface, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Plate(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[9] { 52, 22, 5, 19, 36, 31, 18, 18, 25 }, 119), new Vector2(0f, CardHeight * 0.5f - 190f), new Vector2(CardWidth - 40f, 340f), _0x31bd16fc, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.20f), _0x0bb64a0b.RadiusCard);
        this._0x861ff521 = new RectTransform[3];
        for (int _0x273d8f86 = 0; _0x273d8f86 < this._0x861ff521.Length; _0x273d8f86++)
        {
            this._0x861ff521[_0x273d8f86] = _0x0bb64a0b.Node(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[9] { 126, 69, 72, 72, 89, 125, 76, 74, 72 }, 45) + _0x273d8f86.ToString(), Vector2.zero, new Vector2(CardWidth, CardHeight));
            this._0x861ff521[_0x273d8f86].gameObject.SetActive(false);
        }

        // Last child of the card, so the cross is drawn over every page.
        Button _0xe203a789 = _0x0bb64a0b.IconAction(this._0x5ec47c35, _0x509ef372._0x9d74d324(new byte[10] { 249, 194, 207, 207, 222, 233, 198, 197, 217, 207 }, 170), new Vector2(CardWidth * 0.5f - 70f, CardHeight * 0.5f - 70f), 92f, _0x31bd16fc, _0xda2d2c80 != null ? _0xda2d2c80.IconClose : null, 44f, _0x0d231d8c.Raised);
        _0xe203a789.onClick.AddListener(() => this._0xd41055c1());
        this._0xf592c465 = new _0x0d8ed0b6()._0xadf5ef62(this._0x007a43f9.gameObject);
        this._0xf592c465._0x8e086730();
        return this;
    }

    public const float CardWidth = 1150f;
    public RectTransform _0xf1e1d8c9(int _0xbd37f130)
    {
        return this._0x861ff521[_0xbd37f130];
    }

    public int _0x970a3290
    {
        get
        {
            return this._0x2745a61f;
        }
    }

    private _0x0d8ed0b6 _0xf592c465;
    public const float CardCentreY = 0.52f; // fraction of the panel height
    private int _0x2745a61f;
    private RectTransform[] _0x861ff521;
    private RectTransform _0x007a43f9;
}

internal static class _0x509ef372
{
    internal static string _0x9d74d324(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}