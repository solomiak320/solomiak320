using System.Collections.Generic;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// The loading screen, which BOTH scenes show. It must not look like the lobby (a loader
// that reads as the menu fails the screenshot gate), so it is a DARKENED version of the
// same world: a heavy scrim over the background, the abstract harlequin mark, one
// functional caption and the template's own loading bar - no cards, no chips, no PLAY
// button, and no app name anywhere.
//
// A plain class, not a MonoBehaviour: it owns no frame of its own and the director that
// builds it already runs in Start(), after every template Awake (C.59).
public sealed class _0xe394cc0d
{
    private Image _0x350ebcd8;
    public void _0x1561f239()
    {
        if (this._0x5b46a01c)
        {
            return;
        }

        if (_0xa62f9119.Instance == null || _0xa62f9119.Instance.Panels == null)
        {
            return;
        }

        List<_0x2f6bc10c> _0x9e3828d4 = _0xa62f9119.Instance.Panels;
        if (_0xc3dbd8a4._0x576642f8.SPLASH >= _0x9e3828d4.Count)
        {
            return;
        }

        _0x2f6bc10c _0x6e610180 = _0x9e3828d4[_0xc3dbd8a4._0x576642f8.SPLASH];
        if (_0x6e610180 == null || _0x6e610180.Content == null)
        {
            return;
        }

        RectTransform _0xdd0fa7af = _0x6e610180.Content.transform as RectTransform;
        if (_0xdd0fa7af == null)
        {
            return;
        }

        this._0x5b46a01c = true;
        // Remember what the template already had (the loading bar) so it can be put back
        // on top after our backdrop is inserted.
        List<Transform> _0x2de10888 = new List<Transform>();
        for (int _0x85944874 = 0; _0x85944874 < _0xdd0fa7af.childCount; _0x85944874++)
        {
            _0x2de10888.Add(_0xdd0fa7af.GetChild(_0x85944874));
        }

        Sprite _0x4df2c2d9 = this._0x2ecacbef != null ? this._0x2ecacbef.Round : null;
        Sprite _0x6febbd9b = this._0x2ecacbef != null ? this._0x2ecacbef.Soft : null;
        TMP_FontAsset _0xcdfd57e8 = this._0x2ecacbef != null ? this._0x2ecacbef.Font : null;
        RectTransform _0xd7352e5f = _0x0bb64a0b.Stretch(_0xdd0fa7af, _0x846167ac._0xb9e608c8(new byte[11] { 155, 184, 164, 169, 187, 160, 140, 186, 173, 187, 187 }, 200));
        _0xd7352e5f.SetAsFirstSibling();
        _0x0bb64a0b.Wash(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[5] { 214, 230, 247, 236, 232 }, 133), _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.84f));
        _0x0bb64a0b.Plate(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[8] { 129, 190, 176, 185, 178, 163, 163, 178 }, 215), Vector2.zero, new Vector2(_0x0bb64a0b.PanelWidth + 140f, _0x0bb64a0b.PanelHeight + 140f), _0x6febbd9b, _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.55f), 0.9f);
        _0x0bb64a0b.Plate(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[4] { 125, 84, 89, 90 }, 53), _0x0bb64a0b.At(0.5f, 0.62f), new Vector2(760f, 760f), _0x6febbd9b, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.26f), 1.0f);
        this._0x4673209a = _0x0bb64a0b.Node(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[7] { 235, 198, 211, 211, 206, 196, 194 }, 167), _0x0bb64a0b.At(0.5f, 0.62f), new Vector2(470f, 470f));
        _0x0bb64a0b.Plate(this._0x4673209a, _0x846167ac._0xb9e608c8(new byte[8] { 4, 41, 60, 60, 33, 43, 45, 9 }, 72), Vector2.zero, new Vector2(330f, 330f), _0x4df2c2d9, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.18f), 2.0f);
        RectTransform _0x054521ca = _0x0bb64a0b.Node(this._0x4673209a, _0x846167ac._0xb9e608c8(new byte[8] { 25, 52, 33, 33, 60, 54, 48, 23 }, 85), Vector2.zero, new Vector2(330f, 330f));
        _0x054521ca.localRotation = Quaternion.Euler(0f, 0f, 45f);
        _0x0bb64a0b.Plate(_0x054521ca, _0x846167ac._0xb9e608c8(new byte[12] { 3, 46, 59, 59, 38, 44, 42, 13, 9, 38, 35, 35 }, 79), Vector2.zero, new Vector2(330f, 330f), _0x4df2c2d9, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.22f), 2.0f);
        this._0x350ebcd8 = _0x0bb64a0b.Picture(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[13] { 238, 199, 212, 202, 195, 215, 211, 207, 200, 235, 199, 212, 205 }, 166), _0x0bb64a0b.At(0.5f, 0.62f), new Vector2(420f, 420f), this._0x2ecacbef != null ? this._0x2ecacbef.Emblem : null, _0x0d231d8c.Gold);
        _0x0bb64a0b.Plate(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[4] { 87, 112, 105, 96 }, 5), _0x0bb64a0b.At(0.5f, 0.345f), new Vector2(420f, 4f), _0x4df2c2d9, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.55f), 8f);
        _0x0bb64a0b.Caption(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[14] { 25, 58, 52, 49, 60, 59, 50, 22, 52, 37, 33, 60, 58, 59 }, 85), _0xcdfd57e8, _0x846167ac._0xb9e608c8(new byte[17] { 170, 169, 167, 162, 175, 168, 161, 198, 178, 174, 163, 198, 174, 169, 179, 181, 163 }, 230), 32f, _0x0d231d8c.Cream, _0x0bb64a0b.At(0.5f, 0.300f), new Vector2(980f, 52f), TextAlignmentOptions.Center);
        _0x0bb64a0b.Caption(_0xd7352e5f, _0x846167ac._0xb9e608c8(new byte[10] { 251, 216, 214, 211, 222, 217, 208, 228, 194, 213 }, 183), _0xcdfd57e8, _0x846167ac._0xb9e608c8(new byte[26] { 208, 217, 202, 193, 193, 204, 193, 193, 183, 168, 179, 181, 180, 160, 173, 193, 162, 174, 168, 175, 178, 193, 174, 175, 173, 184 }, 225), 24f, _0x0d231d8c.Fade(_0x0d231d8c.Lilac, 0.70f), _0x0bb64a0b.At(0.5f, 0.150f), new Vector2(980f, 40f), TextAlignmentOptions.Center);
        for (int _0x9e4a4674 = 0; _0x9e4a4674 < _0x2de10888.Count; _0x9e4a4674++)
        {
            if (_0x2de10888[_0x9e4a4674] != null)
            {
                _0x2de10888[_0x9e4a4674].SetAsLastSibling();
            }
        }

        this._0x57102397();
        // A short entrance, then stillness. The capture waits for a frame that stops
        // changing, so a loader that animates forever costs a screenshot.
        this._0x350ebcd8.rectTransform.localScale = new Vector3(0.72f, 0.72f, 1f);
        this._0x350ebcd8.rectTransform.DOScale(1f, 0.62f).SetEase(Ease.OutBack).SetLink(this._0x350ebcd8.gameObject);
        this._0x350ebcd8.color = _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0f);
        this._0x350ebcd8.DOFade(1f, 0.42f).SetLink(this._0x350ebcd8.gameObject);
    }

    public void _0x674ae8af()
    {
        if (this._0x350ebcd8 != null)
        {
            DOTween.Kill(this._0x350ebcd8.gameObject);
        }

        if (this._0x4673209a != null)
        {
            DOTween.Kill(this._0x4673209a.gameObject);
        }
    }

    public _0xe394cc0d _0x11488d7f(_0x41b355c2 _0x399b58a5)
    {
        this._0x2ecacbef = _0x399b58a5;
        return this;
    }

    // The template ships the bar's fill plain white at alpha 1 on a track that is white
    // at alpha 0.0039 - white on invisible. Each scene shows its OWN splash, so the
    // colours are set here rather than in a scene file, and the bar's SIZE is left
    // exactly as the prefab authored it: "Fill Area" insets itself inside the root, so
    // shrinking the root is what collapses the bar to nothing (ANDROID-3578).
    // Elements are reached by COMPONENT, never by name - obfuscation renames names.
    private void _0x57102397()
    {
        Slider _0xa1ed9312 = _0x2f7b6011.Instance != null ? _0x2f7b6011.Instance.AnimationSlider : null;
        if (_0xa1ed9312 == null || _0xa1ed9312.fillRect == null)
        {
            return;
        }

        Image _0x474f3d35 = _0xa1ed9312.fillRect.GetComponent<Image>();
        if (_0x474f3d35 != null)
        {
            _0x474f3d35.color = _0x0d231d8c.Gold;
        }

        Transform _0xbfd1cce2 = _0xa1ed9312.fillRect.parent;
        Image _0xa8955f67 = _0xbfd1cce2 != null ? _0xbfd1cce2.GetComponent<Image>() : null;
        if (_0xa8955f67 != null)
        {
            _0xa8955f67.color = _0x0d231d8c.Fade(_0x0d231d8c.DeepInk, 0.92f);
        }
    }

    private RectTransform _0x4673209a;
    private bool _0x5b46a01c;
    private _0x41b355c2 _0x2ecacbef;
}

internal static class _0x846167ac
{
    internal static string _0xb9e608c8(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}