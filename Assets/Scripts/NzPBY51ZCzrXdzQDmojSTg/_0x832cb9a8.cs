using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The game scene, start to finish: it lays out the machine, owns the spin flow and joins
// the reels, the HUD and the three pops together. Everything on screen is OUR object -
// the template TopPanel is switched off in the scene, so this is the only button set.
//
// There is no timer, no energy and no draining meter of any kind: an untouched game
// scene sits on a fully drawn, idle machine indefinitely, so the review capture always
// lands on live gameplay rather than on a defeat card (C.5). A bust is impossible as
// well - dropping below the minimum bet raises the free refill.
//
// Set-up runs in Start(), never Awake (C.59), and no constructor exists anywhere.
public sealed class _0x832cb9a8 : MonoBehaviour
{
    private void Start()
    {
        this._0x1cfffbe4 = new _0x8ae00696()._0x2f7442c7();
        this._0xde3389b5 = new _0x50933d49()._0x4f8e33d1();
        this._0x75429e99 = new _0x9fe11fc8()._0xe31e93af();
        this._0x50e91c6c = new _0xe394cc0d()._0x11488d7f(this._art);
        this._0x50e91c6c._0x1561f239();
        new _0x6c06c1a1()._0xe6fed157();
        _0x2f6bc10c _0xdfa6be2f = this._0xbbe33ba0();
        if (_0xdfa6be2f == null || _0xdfa6be2f.Content == null)
        {
            return;
        }

        RectTransform _0x94f34cf6 = _0xdfa6be2f.Content.transform as RectTransform;
        if (_0x94f34cf6 == null)
        {
            return;
        }

        // A new session every time the scene is entered: different strips, different
        // near misses, never the same board twice (C.11).
        int _0x5ae60d7d = PlayerPrefs.GetInt(_0x006bc2a7._0xb73932bf(new byte[11] { 45, 32, 51, 105, 52, 34, 52, 52, 46, 40, 41 }, 71), 0) + 1;
        PlayerPrefs.SetInt(_0x006bc2a7._0xb73932bf(new byte[11] { 227, 238, 253, 167, 250, 236, 250, 250, 224, 230, 231 }, 137), _0x5ae60d7d);
        this._0x345baad8 = new _0xd3edbd6a()._0xf6142019(_0x5ae60d7d);
        this._0xd5ee8c74 = new _0x8ddb910d()._0x588decef(_0x94f34cf6, this._art, this._0xde3389b5._0x87920c41);
        float _0xc02b4b21 = _0x0bb64a0b.PanelWidth * WindowFraction;
        float _0xee17c0ba = (_0xc02b4b21 - (_0xd3edbd6a.Reels - 1) * CellGap) / _0xd3edbd6a.Reels;
        float _0xb9d62735 = _0xee17c0ba + CellGap;
        float _0xe50b6d2a = _0xd3edbd6a.Rows * _0xb9d62735 - CellGap;
        Vector2 _0x15355047 = _0x0bb64a0b.At(0.5f, WindowCentreY);
        Sprite _0xb700513f = this._art != null ? this._art.Round : null;
        Sprite _0x8c409a6f = this._art != null ? this._art.Soft : null;
        // The trim SURROUNDS the content, so it is created BEFORE it and therefore sits
        // beneath it (C.13). Only the glass highlight, which is meant to be on top, is
        // created afterwards - and it is low alpha, never an opaque middle.
        _0x0bb64a0b.Plate(_0x94f34cf6, _0x006bc2a7._0xb73932bf(new byte[9] { 175, 155, 136, 132, 140, 174, 133, 134, 158 }, 233), _0x15355047, new Vector2(_0xc02b4b21 + 240f, _0xe50b6d2a + 240f), _0x8c409a6f, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.30f), 1.0f);
        _0x0bb64a0b.Plate(_0x94f34cf6, _0x006bc2a7._0xb73932bf(new byte[9] { 91, 111, 124, 112, 120, 88, 121, 122, 120 }, 29), _0x15355047, new Vector2(_0xc02b4b21 + FrameMargin, _0xe50b6d2a + FrameMargin), _0xb700513f, _0x0d231d8c.Gold, _0x0bb64a0b.RadiusCard);
        _0x0bb64a0b.Plate(_0x94f34cf6, _0x006bc2a7._0xb73932bf(new byte[9] { 58, 14, 29, 17, 25, 58, 21, 16, 16 }, 124), _0x15355047, new Vector2(_0xc02b4b21 + FrameMargin - 14f, _0xe50b6d2a + FrameMargin - 14f), _0xb700513f, _0x0d231d8c.DeepInk, _0x0bb64a0b.RadiusCard);
        this._0x62dc923d = _0x0bb64a0b.Node(_0x94f34cf6, _0x006bc2a7._0xb73932bf(new byte[10] { 122, 77, 77, 68, 127, 65, 70, 76, 71, 95 }, 40), _0x15355047, new Vector2(_0xc02b4b21, _0xe50b6d2a));
        this._0x62dc923d.gameObject.AddComponent<RectMask2D>();
        if (this._machine != null)
        {
            this._machine._0x2ecff0c1(this._0x345baad8, this._art, this._0x62dc923d, _0xee17c0ba, _0xb9d62735, _0xb9d62735);
            this._machine._0x7f1ed1d0(_0xff37bc54.Has(_0xff37bc54.FlagFastSpin));
            this._machine.OnResolved = (_0x66795159, _0x510170f5, _0xd1541e95) => this._0x79b2fc83(_0x66795159, _0x510170f5, _0xd1541e95);
        }

        _0x0bb64a0b.Plate(_0x94f34cf6, _0x006bc2a7._0xb73932bf(new byte[10] { 91, 111, 124, 112, 120, 90, 113, 124, 110, 110 }, 29), new Vector2(_0x15355047.x, _0x15355047.y + _0xe50b6d2a * 0.27f), new Vector2(_0xc02b4b21 - 24f, _0xe50b6d2a * 0.40f), _0xb700513f, _0x0d231d8c.Fade(_0x0d231d8c.Cream, 0.07f), _0x0bb64a0b.RadiusCard);
        if (this._hud != null)
        {
            this._hud._0x4bd920be(_0x94f34cf6, this._art);
            this._hud.OnSpin = () => this._0x9e8925c4();
            this._hud.OnBetUp = () => this._0x77dec52b();
            this._hud.OnBetDown = () => this._0xf8247caa();
            this._hud.OnBack = () => this._0xa74a9924();
            this._hud.OnPause = () => this._0x178b9605();
        }

        if (this._pops != null)
        {
            this._pops._0x98db683b(this._art);
            this._pops.OnSpinAgain = () => this._0x9e8925c4();
            this._pops.OnTakeRefill = () => this._0x4d6a7d3d();
            this._pops.OnResume = () => this._0x42b8fee9();
        }

        this._0xcfa38a5b = true;
        this._0x8a202f41(false);
    }

    private _0xe394cc0d _0x50e91c6c;
    [SerializeField]
    private _0x2f625354 _machine;
    private _0x2f6bc10c _0xbbe33ba0()
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

    private void Update()
    {
        if (!this._0xcfa38a5b)
        {
            return;
        }

        if (this._machine != null && this._0xf8715ce4 && !this._machine._0xfcf1cfb6)
        {
            this._0xf8715ce4 = false;
            if (this._hud != null)
            {
                this._hud._0x583940d0(false);
            }
        }

        if (this._0x0f00845c > 0)
        {
            this._0x796cccd2 += Time.deltaTime;
            if (this._machine != null && !this._machine._0xfcf1cfb6 && this._0x796cccd2 >= 0.35f)
            {
                int _0x6d70f5e1 = this._0x0f00845c;
                this._0x0f00845c = 0;
                this._0xdb791860(_0x6d70f5e1);
            }
        }
    }

    private void _0x6f5e93da()
    {
        if (this._pops == null)
        {
            return;
        }

        this._pops._0xdf2299e1(_0x8ae00696.RefillCoins);
    }

    private _0x8ddb910d _0xd5ee8c74;
    private void _0x77dec52b()
    {
        if (this._machine != null && this._machine._0xfcf1cfb6)
        {
            return;
        }

        if (this._0x1cfffbe4._0x1febf943())
        {
            this._0x8a202f41(false);
        }
    }

    private void _0x178b9605()
    {
        if (this._pops == null)
        {
            return;
        }

        this._0x928d189d = true;
        if (this._machine != null)
        {
            this._machine._0xe20c4aad(true);
        }

        this._pops._0xd5e835b7(this._0x1cfffbe4._0xc96bb9a6, this._0x1cfffbe4._0x8ed1f8ee);
    }

    private void OnDestroy()
    {
        DOTween.Kill(this);
        DOTween.Kill(this.gameObject);
        if (this._0xd5ee8c74 != null)
        {
            this._0xd5ee8c74._0x71079683();
        }

        if (this._0x50e91c6c != null)
        {
            this._0x50e91c6c._0x674ae8af();
        }

        if (this._0x62dc923d != null)
        {
            DOTween.Kill(this._0x62dc923d.gameObject);
        }
    }

    private void _0x42b8fee9()
    {
        this._0x928d189d = false;
        if (this._machine != null)
        {
            this._machine._0xe20c4aad(false);
        }
    }

    [SerializeField]
    private _0x41b355c2 _art;
    private void _0x8a202f41(bool _0xa69a43f2)
    {
        if (this._hud == null)
        {
            return;
        }

        this._hud._0x8250474a(this._0x1cfffbe4._0xc96bb9a6, _0xa69a43f2);
        this._hud._0x778f3f71(this._0x1cfffbe4._0x8ed1f8ee);
        this._hud._0xd390308f(this._0x1cfffbe4._0x77d7bec8, this._0x1cfffbe4._0x64654caf);
        this._0xfddb1e28();
    }

    private void _0xfddb1e28()
    {
        if (this._hud == null)
        {
            return;
        }

        int _0x9a3153b8 = this._0x75429e99._0xc5f7772a();
        if (_0x9a3153b8 < 0)
        {
            this._hud._0xdf481973(_0x006bc2a7._0xb73932bf(new byte[26] { 158, 147, 147, 255, 146, 150, 140, 140, 150, 144, 145, 140, 255, 156, 147, 154, 158, 141, 154, 155, 255, 139, 144, 155, 158, 134 }, 223), 1f);
            return;
        }

        int _0x64b80bc1 = this._0x75429e99._0xc9e982f8(_0x9a3153b8);
        int _0xc7ef5115 = this._0x75429e99._0x451f3ea9(_0x9a3153b8);
        float _0x2af37925 = _0x64b80bc1 > 0 ? (float)_0xc7ef5115 / _0x64b80bc1 : 0f;
        this._hud._0xdf481973(this._0x75429e99._0x1e94d6a2(_0x9a3153b8) + _0x006bc2a7._0xb73932bf(new byte[5] { 122, 122, 119, 122, 122 }, 90) + _0xc7ef5115.ToString() + _0x006bc2a7._0xb73932bf(new byte[1] { 120 }, 87) + _0x64b80bc1.ToString(), _0x2af37925);
    }

    [SerializeField]
    private _0x13016e61 _hud;
    private const float CellGap = 12f;
    private float _0x796cccd2;
    private _0x9fe11fc8 _0x75429e99;
    private bool _0xcfa38a5b;
    // Fractions of the panel, so every size below is derived from the canvas and not
    // picked by eye (C.0). 0.885 of 1242 leaves a 71-unit margin on each side for the
    // frame trim, and the cell follows from the five columns and their gaps.
    private const float WindowFraction = 0.885f;
    private const float FrameMargin = 58f;
    [SerializeField]
    private _0x59333f39 _pops;
    private void _0xdb791860(int _0xf8ca26da)
    {
        if (this._pops == null)
        {
            return;
        }

        this._pops._0xaa0462de(_0xf8ca26da, _0x006bc2a7._0xb73932bf(new byte[22] { 212, 217, 217, 181, 193, 208, 219, 181, 217, 220, 219, 208, 198, 181, 181, 184, 181, 181, 215, 208, 193, 181 }, 149) + _0x0bb64a0b.Thousands(this._0x1cfffbe4._0x8ed1f8ee));
    }

    private bool _0xf8715ce4;
    private const float WindowCentreY = 0.590f;
    private int _0x0f00845c;
    private void _0xa74a9924()
    {
        _0x05c8a753.Instance._0x8595e80b(_0xc3dbd8a4._0x28f4af65.SCENE_0);
    }

    private _0x50933d49 _0xde3389b5;
    // ---------------------------------------------------------------- flow
    private void _0x9e8925c4()
    {
        if (!this._0xcfa38a5b || this._machine == null || this._machine._0xfcf1cfb6 || this._0x928d189d)
        {
            return;
        }

        int _0xc05dbc11 = this._0x1cfffbe4._0x8ed1f8ee;
        if (this._0x1cfffbe4._0xc96bb9a6 < _0xc05dbc11)
        {
            this._0x6f5e93da();
            return;
        }

        this._0x1cfffbe4._0xa58f9149(_0xc05dbc11);
        if (this._hud != null)
        {
            this._hud._0x8250474a(this._0x1cfffbe4._0xc96bb9a6, true);
            this._hud._0xe166b146(0, false);
            this._hud._0x583940d0(true);
        }

        this._0xf8715ce4 = this._machine._0xa6e9eaa6(_0xc05dbc11);
    }

    private RectTransform _0x62dc923d;
    private _0xd3edbd6a _0x345baad8;
    private void _0x4d6a7d3d()
    {
        this._0x1cfffbe4._0x4e4dfde1();
        this._0x8a202f41(true);
    }

    private bool _0x928d189d;
    private void _0xf8247caa()
    {
        if (this._machine != null && this._machine._0xfcf1cfb6)
        {
            return;
        }

        if (this._0x1cfffbe4._0x4e6d072b())
        {
            this._0x8a202f41(false);
        }
    }

    private void _0x79b2fc83(int[] _0x6c74ebf4, List<_0xb17cbc9c> _0x09142fc3, int _0xfa1a2538)
    {
        int _0x356491a7 = this._0x1cfffbe4._0x8ed1f8ee;
        if (_0xfa1a2538 > 0)
        {
            this._0x1cfffbe4._0x6789d0c8(_0xfa1a2538);
        }

        int _0xffc0710b = _0xa17acf4e.CountSymbol(_0x6c74ebf4, _0xd3edbd6a.Joker);
        int _0xba7b5791 = _0xa17acf4e.CountSymbol(_0x6c74ebf4, _0xd3edbd6a.Ticket);
        int _0x62cf47bb = _0xba7b5791 >= 3 ? _0xba7b5791 - 2 : 0;
        int _0x28a2f558 = _0x62cf47bb > 0 ? this._0xde3389b5._0x861447e9(_0x62cf47bb) : 0;
        int _0x94dce657 = this._0x75429e99._0x0d2a9c47(_0x9fe11fc8.KindSpins, 1);
        _0x94dce657 += this._0x75429e99._0x0d2a9c47(_0x9fe11fc8.KindJokers, _0xffc0710b);
        _0x94dce657 += this._0x75429e99._0x0d2a9c47(_0x9fe11fc8.KindCoins, _0xfa1a2538);
        if (_0x28a2f558 > 0)
        {
            _0x94dce657 += this._0x75429e99._0x0d2a9c47(_0x9fe11fc8.KindShards, _0x28a2f558);
        }

        if (_0xba7b5791 >= 3)
        {
            _0x94dce657 += this._0x75429e99._0x0d2a9c47(_0x9fe11fc8.KindScatters, 1);
        }

        if (_0x94dce657 > 0)
        {
            this._0x1cfffbe4._0x6789d0c8(_0x94dce657);
        }

        if (this._hud != null)
        {
            this._hud._0xe166b146(_0xfa1a2538, true);
            this._hud._0x8250474a(this._0x1cfffbe4._0xc96bb9a6, true);
            if (_0xfa1a2538 > 0)
            {
                int _0x308172e6 = _0xff37bc54.Has(_0xff37bc54.FlagReducedFlash) ? 6 : 12;
                this._hud._0x3bcd5a77(_0x0bb64a0b.At(0.5f, WindowCentreY), _0x308172e6);
            }
        }

        if (_0xfa1a2538 > 0 && _0xff37bc54.Has(_0xff37bc54.FlagVibration))
        {
            Handheld.Vibrate();
        }

        // The showcase pop waits for the paylines to finish lighting, so the card never
        // covers the win it is announcing.
        if (_0xfa1a2538 >= _0x356491a7 * 10)
        {
            this._0x0f00845c = _0xfa1a2538;
            this._0x796cccd2 = 0f;
        }
        else if (this._0x1cfffbe4._0x7649367a())
        {
            this._0x6f5e93da();
        }

        this._0xfddb1e28();
    }

    private _0x8ae00696 _0x1cfffbe4;
}

internal static class _0x006bc2a7
{
    internal static string _0xb73932bf(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}