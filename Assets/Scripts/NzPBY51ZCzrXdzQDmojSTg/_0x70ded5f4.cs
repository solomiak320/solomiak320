using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

// One reel column: five pooled cell Images inside the masked window (three visible, one
// above and one below), a looping upward scroll while spinning and an overshoot settle
// when it lands. Driven by ReelMachine - this is a view, not a MonoBehaviour, so there is
// no Awake/Start to race the template's own set-up (C.59). No constructor: Init() returns
// the object.
public sealed class _0x70ded5f4
{
    private _0xd3edbd6a _0x181dcbb1;
    // Lands the reel on the drawn stop and bounces into place with an 18 unit overshoot.
    public void _0xd2215f3a(int _0x1201dc74, float _0x02ab5bd5)
    {
        this._0x10b6c875 = false;
        this._0x7abd4589 = _0x1201dc74;
        this._0xa46ed715 = 32f;
        this._0x3e6ffb4d();
        this._0x0653a84a();
        if (this._0x7b83a5ca != null)
        {
            this._0x7b83a5ca.DOFade(0f, _0x02ab5bd5 * 0.7f).SetLink(this._0x7b83a5ca.gameObject);
        }

        DOTween.To(() => this._0xa46ed715, _0x2a8711e0 =>
        {
            this._0xa46ed715 = _0x2a8711e0;
            this._0x0653a84a();
        }, 0f, _0x02ab5bd5).SetEase(Ease.OutBack).SetLink(this._0x09b7b30f.gameObject);
    }

    public void _0x52da83bb(float _0xaf43cd9e)
    {
        this._0x10b6c875 = true;
        this._0xebb79139 = this._0xc3102b87 * 22f * _0xaf43cd9e;
        if (this._0x7b83a5ca != null)
        {
            this._0x7b83a5ca.color = _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.35f);
        }
    }

    private _0x41b355c2 _0xf0a3fe12;
    private int _0x6695049d;
    public int _0x64ab50e9
    {
        get
        {
            return this._0x7abd4589;
        }
    }

    private float _0xc3102b87;
    public _0x70ded5f4 _0xd14b7a6c(_0xd3edbd6a _0xf8fc1470, _0x41b355c2 _0xba8c9ff3, GameObject _0x133d7c3f, RectTransform _0x3010b162, int _0x3f2945dc, float _0x38cd6e49, float _0xba3e01dc)
    {
        this._0x181dcbb1 = _0xf8fc1470;
        this._0xf0a3fe12 = _0xba8c9ff3;
        this._0x6695049d = _0x3f2945dc;
        this._0x1c5407b5 = _0x38cd6e49;
        this._0xc3102b87 = _0xba3e01dc;
        this._0x7abd4589 = _0x3f2945dc * 3;
        this._0xa46ed715 = 0f;
        this._0x10b6c875 = false;
        this._0xebb79139 = _0xba3e01dc * 22f;
        this._0x09b7b30f = _0x0bb64a0b.Node(_0x3010b162, _0x68264abd._0x74a1764f(new byte[5] { 130, 165, 163, 184, 161 }, 209), Vector2.zero, new Vector2(_0x38cd6e49, _0xba3e01dc * Slots));
        this._0x315e03f0 = new Image[Slots];
        for (int _0xda2ae0f3 = 0; _0xda2ae0f3 < Slots; _0xda2ae0f3++)
        {
            float _0xd0337096 = (2 - _0xda2ae0f3) * _0xba3e01dc;
            Image _0xf059af20 = _0x0bb64a0b.Spawn(this._0x09b7b30f, _0x133d7c3f, _0x68264abd._0x74a1764f(new byte[4] { 203, 237, 228, 228 }, 136) + _0xda2ae0f3.ToString(), new Vector2(0f, _0xd0337096), new Vector2(_0x38cd6e49 * 0.90f, _0x38cd6e49 * 0.90f), null, _0x0d231d8c.Cream);
            this._0x315e03f0[_0xda2ae0f3] = _0xf059af20;
        }

        this._0x7b83a5ca = _0x0bb64a0b.Plate(_0x3010b162, _0x68264abd._0x74a1764f(new byte[4] { 14, 32, 57, 62 }, 76), Vector2.zero, new Vector2(_0x38cd6e49, _0xba3e01dc * 3f), _0xba8c9ff3 != null ? _0xba8c9ff3.Round : null, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0f), _0x0bb64a0b.RadiusTile);
        this._0x3e6ffb4d();
        this._0x0653a84a();
        return this;
    }

    public void _0xa5bf76da()
    {
        for (int _0xce3bafd3 = 0; _0xce3bafd3 < Slots; _0xce3bafd3++)
        {
            if (this._0x315e03f0[_0xce3bafd3] != null)
            {
                this._0x315e03f0[_0xce3bafd3].color = _0x0d231d8c.Cream;
            }
        }
    }

    public void _0x2f883962(int _0x975f90af, bool _0xf8650913)
    {
        int _0x5f76c5d2 = _0x975f90af + 1;
        if (_0x5f76c5d2 < 0 || _0x5f76c5d2 >= Slots)
        {
            return;
        }

        Image _0x23a84b3d = this._0x315e03f0[_0x5f76c5d2];
        if (_0x23a84b3d == null)
        {
            return;
        }

        _0x23a84b3d.color = _0xf8650913 ? _0x0d231d8c.Cream : _0x0d231d8c.Fade(_0x0d231d8c.Cream, 0.72f);
    }

    private RectTransform _0x09b7b30f;
    public void _0x23a03bb5(float delta)
    {
        if (!this._0x10b6c875)
        {
            return;
        }

        this._0xa46ed715 += this._0xebb79139 * delta;
        int _0x1cd5cd44 = 0;
        while (this._0xa46ed715 >= this._0xc3102b87 && _0x1cd5cd44 < Slots * 4)
        {
            this._0xa46ed715 -= this._0xc3102b87;
            this._0x7abd4589 = (this._0x7abd4589 + 1) % _0xd3edbd6a.StripLength;
            this._0x3e6ffb4d();
            _0x1cd5cd44++;
        }

        this._0x0653a84a();
    }

    public void _0xe4ca9dad(int _0x8fba2494, float _0xe72d855d, float _0xd4f3d39c)
    {
        int _0xd7eae3be = _0x8fba2494 + 1;
        if (_0xd7eae3be < 0 || _0xd7eae3be >= Slots)
        {
            return;
        }

        Image _0x1c29a6b5 = this._0x315e03f0[_0xd7eae3be];
        if (_0x1c29a6b5 == null)
        {
            return;
        }

        _0x1c29a6b5.rectTransform.DOPunchScale(new Vector3(_0xe72d855d, _0xe72d855d, 0f), _0xd4f3d39c, 6, 0.6f).SetLink(_0x1c29a6b5.gameObject);
    }

    private float _0xa46ed715;
    private int _0x7abd4589;
    private Image _0x7b83a5ca;
    private void _0x0653a84a()
    {
        if (this._0x09b7b30f != null)
        {
            this._0x09b7b30f.anchoredPosition = new Vector2(0f, this._0xa46ed715);
        }
    }

    private void _0x3e6ffb4d()
    {
        for (int _0xf1458c69 = 0; _0xf1458c69 < Slots; _0xf1458c69++)
        {
            int _0xb649bc2c = this._0x181dcbb1._0xdfbb28f5(this._0x6695049d, this._0x7abd4589 + _0xf1458c69 - 1);
            Image _0xf1b08fcb = this._0x315e03f0[_0xf1458c69];
            if (_0xf1b08fcb == null)
            {
                continue;
            }

            _0xf1b08fcb.sprite = this._0xf0a3fe12 != null ? this._0xf0a3fe12._0x26facb78(_0xb649bc2c) : null;
            _0xf1b08fcb.preserveAspect = true; // symbol PNGs keep their own aspect (F.2a)
            _0xf1b08fcb.color = _0x0d231d8c.Cream;
            _0xf1b08fcb.rectTransform.localScale = Vector3.one;
        }
    }

    public const int Slots = 5;
    private float _0xebb79139;
    private float _0x1c5407b5;
    public void _0x7dcec9fd()
    {
        if (this._0x09b7b30f != null)
        {
            DOTween.Kill(this._0x09b7b30f.gameObject);
        }

        if (this._0x7b83a5ca != null)
        {
            DOTween.Kill(this._0x7b83a5ca.gameObject);
        }
    }

    private bool _0x10b6c875;
    private Image[] _0x315e03f0;
}

internal static class _0x68264abd
{
    internal static string _0x74a1764f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}