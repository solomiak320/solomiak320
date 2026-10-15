using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// The five columns and the spin state machine: idle -> spinning -> resolving ->
// celebrating -> idle. Nothing here drives a simulated body; the reels are UGUI
// Images moved by arithmetic and DOTween, so the scene needs no simulation at all.
// Set-up happens in Bind(), called by the director from its Start() (C.59).
public sealed class _0x2f625354 : MonoBehaviour
{
    private void _0xf9a578e2()
    {
        this._0xfa4065a5 = this._0xb531a3e5._0xba72aac0(this._0x54fd0c13);
        this._0x6d408c83 = _0xa17acf4e.Evaluate(this._0xfa4065a5, this._0x567b4aa2);
        this._0x2c6196cb = 0;
        for (int _0x927972fe = 0; _0x927972fe < this._0x6d408c83.Count; _0x927972fe++)
        {
            this._0x2c6196cb += this._0x6d408c83[_0x927972fe].Payout;
        }

        this._0x2d283f5a = 0f;
        this._0x331c1a4a = 0;
        this._0x804ed3ef = StateCelebrating;
        if (this.OnResolved != null)
        {
            this.OnResolved(this._0xfa4065a5, this._0x6d408c83, this._0x2c6196cb);
        }
    }

    private float _0xaea9864b;
    public System.Action<int[], List<_0xb17cbc9c>, int> OnResolved;
    private _0xd3edbd6a _0xb531a3e5;
    [SerializeField]
    private GameObject _cellPrefab;
    private float _0x01ff91a7;
    private Vector2 _0x2e986cdf(int _0x87839675, int _0x02cd6f07)
    {
        return new Vector2((_0x87839675 - 2) * this._0x40493c60, (1 - _0x02cd6f07) * this._0x01ff91a7);
    }

    private int _0x567b4aa2;
    private int _0x331c1a4a;
    public int _0x46dd1262
    {
        get
        {
            return this._0x804ed3ef;
        }
    }

    private void Update()
    {
        if (!this._0x8d52bfa3 || this._0xdefbf54b)
        {
            return;
        }

        float delta = Time.deltaTime;
        if (this._0x804ed3ef == StateSpinning)
        {
            this._0x42a65621 += delta;
            for (int _0x990bc92f = 0; _0x990bc92f < _0xd3edbd6a.Reels; _0x990bc92f++)
            {
                if (!this._0xeea4bc9f[_0x990bc92f] && this._0x42a65621 >= this._0x14179e42(_0x990bc92f))
                {
                    this._0xeea4bc9f[_0x990bc92f] = true;
                    this._0x0b40acb5[_0x990bc92f]._0xd2215f3a(this._0x54fd0c13[_0x990bc92f], this._0x52389d52 ? 0.14f : 0.22f);
                }

                this._0x0b40acb5[_0x990bc92f]._0x23a03bb5(delta);
            }

            if (this._0xeea4bc9f[_0xd3edbd6a.Reels - 1] && this._0x42a65621 >= this._0x14179e42(_0xd3edbd6a.Reels - 1) + 0.26f)
            {
                this._0xf9a578e2();
            }

            return;
        }

        if (this._0x804ed3ef == StateCelebrating)
        {
            this._0x2d283f5a += delta;
            float _0xee03b97a = this._0x52389d52 ? 0.14f : 0.25f;
            while (this._0x6d408c83 != null && this._0x331c1a4a < this._0x6d408c83.Count && this._0x2d283f5a >= _0xee03b97a * (this._0x331c1a4a + 1))
            {
                this._0xc0e812f9(this._0x6d408c83[this._0x331c1a4a]);
                this._0x331c1a4a++;
            }

            float _0x2381a0a1 = this._0x52389d52 ? 0.5f : 0.9f;
            if (this._0x6d408c83 == null || this._0x2d283f5a >= _0xee03b97a * this._0x6d408c83.Count + _0x2381a0a1)
            {
                this._0x804ed3ef = StateIdle;
            }
        }
    }

    private int _0x804ed3ef;
    private void OnDestroy()
    {
        if (this._0x0b40acb5 != null)
        {
            for (int _0x0a537216 = 0; _0x0a537216 < this._0x0b40acb5.Length; _0x0a537216++)
            {
                if (this._0x0b40acb5[_0x0a537216] != null)
                {
                    this._0x0b40acb5[_0x0a537216]._0x7dcec9fd();
                }
            }
        }

        for (int _0x235ae3dd = 0; _0x235ae3dd < this._0x0650f043.Count; _0x235ae3dd++)
        {
            if (this._0x0650f043[_0x235ae3dd] != null)
            {
                DOTween.Kill(this._0x0650f043[_0x235ae3dd]);
            }
        }

        DOTween.Kill(this);
    }

    private float _0x42a65621;
    private int _0x2c6196cb;
    public const int StateIdle = 0;
    private _0x70ded5f4[] _0x0b40acb5;
    private RectTransform _0xe6ca5d3c;
    private float _0x40493c60;
    private int[] _0x54fd0c13;
    public const int StateSpinning = 1;
    private void _0x86de597b(int _0xfa773b44, int _0xb55d1b0b, int _0x56a50f2a, int _0xda00b4ce)
    {
        Vector2 _0x24140e45 = this._0x2e986cdf(_0xfa773b44, _0xb55d1b0b);
        Vector2 _0x2d6750e6 = this._0x2e986cdf(_0x56a50f2a, _0xda00b4ce);
        Vector2 _0x0c288b5a = new Vector2((_0x24140e45.x + _0x2d6750e6.x) * 0.5f, (_0x24140e45.y + _0x2d6750e6.y) * 0.5f);
        float _0x17224e20 = Vector2.Distance(_0x24140e45, _0x2d6750e6);
        Image _0x22563551 = _0x0bb64a0b.Plate(this._0x6bae645f, _0xf91748d4._0xc4ebecd5(new byte[4] { 117, 80, 87, 92 }, 57), _0x0c288b5a, new Vector2(_0x17224e20, 10f), this._0x4e4675ad != null ? this._0x4e4675ad.Round : null, _0x0d231d8c.Fade(_0x0d231d8c.GoldLight, 0f), 12f);
        float _0xcfec35f8 = Mathf.Atan2(_0x2d6750e6.y - _0x24140e45.y, _0x2d6750e6.x - _0x24140e45.x) * Mathf.Rad2Deg;
        _0x22563551.rectTransform.localRotation = Quaternion.Euler(0f, 0f, _0xcfec35f8);
        this._0x0650f043.Add(_0x22563551.gameObject);
        _0x22563551.DOFade(0.85f, 0.22f).SetLink(_0x22563551.gameObject);
    }

    private readonly List<GameObject> _0x0650f043 = new List<GameObject>();
    private bool[] _0xeea4bc9f;
    public bool _0xfcf1cfb6
    {
        get
        {
            return this._0x804ed3ef != StateIdle;
        }
    }

    public const int StateCelebrating = 2;
    private bool _0x52389d52;
    public void _0xe20c4aad(bool _0xbcf2216f)
    {
        this._0xdefbf54b = _0xbcf2216f;
    }

    private bool _0xdefbf54b;
    private int[] _0xfa4065a5;
    private float _0x14179e42(int _0xe451b8b1)
    {
        return this._0x52389d52 ? 0.22f + _0xe451b8b1 * 0.09f : 0.55f + _0xe451b8b1 * 0.18f;
    }

    // Lights one win: the payline is traced with thin gold segments and the symbols it
    // paid on punch. Scatters have no line, so their cells just punch wherever they are.
    private void _0xc0e812f9(_0xb17cbc9c _0x3310ac93)
    {
        if (_0x3310ac93.Scatter)
        {
            for (int _0x996e861f = 0; _0x996e861f < _0xd3edbd6a.Reels; _0x996e861f++)
            {
                for (int _0x9833b8e9 = 0; _0x9833b8e9 < _0xd3edbd6a.Rows; _0x9833b8e9++)
                {
                    if (_0xa17acf4e.Cell(this._0xfa4065a5, _0x996e861f, _0x9833b8e9) == _0xd3edbd6a.Ticket)
                    {
                        this._0x0b40acb5[_0x996e861f]._0xe4ca9dad(_0x9833b8e9, 0.16f, 0.35f);
                        this._0x99384e9b(_0x996e861f, _0x9833b8e9);
                    }
                }
            }

            return;
        }

        int[] _0xe5f4cc97 = _0xa17acf4e.Line(_0x3310ac93.Line);
        for (int _0x3abe0727 = 0; _0x3abe0727 < _0x3310ac93.Count && _0x3abe0727 < _0xd3edbd6a.Reels; _0x3abe0727++)
        {
            this._0x0b40acb5[_0x3abe0727]._0xe4ca9dad(_0xe5f4cc97[_0x3abe0727], 0.12f, 0.35f);
            this._0x99384e9b(_0x3abe0727, _0xe5f4cc97[_0x3abe0727]);
            if (_0x3abe0727 + 1 < _0x3310ac93.Count && _0x3abe0727 + 1 < _0xd3edbd6a.Reels)
            {
                this._0x86de597b(_0x3abe0727, _0xe5f4cc97[_0x3abe0727], _0x3abe0727 + 1, _0xe5f4cc97[_0x3abe0727 + 1]);
            }
        }
    }

    private List<_0xb17cbc9c> _0x6d408c83;
    private RectTransform _0x6bae645f;
    private void _0x74a9cdd1()
    {
        for (int _0x91c25bbd = 0; _0x91c25bbd < this._0x0650f043.Count; _0x91c25bbd++)
        {
            GameObject _0x5fdc41e4 = this._0x0650f043[_0x91c25bbd];
            if (_0x5fdc41e4 == null)
            {
                continue;
            }

            DOTween.Kill(_0x5fdc41e4);
            _0x5fdc41e4.transform.SetParent(null, false);
            Destroy(_0x5fdc41e4);
        }

        this._0x0650f043.Clear();
    }

    private float _0x2d283f5a;
    public bool _0xa6e9eaa6(int _0x57b63394)
    {
        if (!this._0x8d52bfa3 || this._0x804ed3ef != StateIdle)
        {
            return false;
        }

        this._0x567b4aa2 = _0x57b63394;
        this._0x74a9cdd1();
        for (int _0x7bf8e366 = 0; _0x7bf8e366 < _0xd3edbd6a.Reels; _0x7bf8e366++)
        {
            this._0x0b40acb5[_0x7bf8e366]._0xa5bf76da();
            this._0xeea4bc9f[_0x7bf8e366] = false;
        }

        this._0x54fd0c13 = this._0xb531a3e5._0xf0a2bf33(_0x57b63394);
        float _0xdebbc57b = this._0x52389d52 ? 1.9f : 1f;
        for (int _0xf119c28c = 0; _0xf119c28c < _0xd3edbd6a.Reels; _0xf119c28c++)
        {
            this._0x0b40acb5[_0xf119c28c]._0x52da83bb(_0xdebbc57b);
        }

        this._0x42a65621 = 0f;
        this._0x804ed3ef = StateSpinning;
        return true;
    }

    private void _0x99384e9b(int _0xf5a88dcb, int _0x095fef77)
    {
        Vector2 _0xc0675eae = this._0x2e986cdf(_0xf5a88dcb, _0x095fef77);
        Image _0x7c872044 = _0x0bb64a0b.Plate(this._0x6bae645f, _0xf91748d4._0xc4ebecd5(new byte[4] { 29, 49, 34, 59 }, 80), _0xc0675eae, new Vector2(this._0xaea9864b, this._0xaea9864b), this._0x4e4675ad != null ? this._0x4e4675ad.Round : null, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0f), _0x0bb64a0b.RadiusTile);
        this._0x0650f043.Add(_0x7c872044.gameObject);
        _0x7c872044.DOFade(0.30f, 0.22f).SetLink(_0x7c872044.gameObject);
    }

    private bool _0x8d52bfa3;
    private _0x41b355c2 _0x4e4675ad;
    public void _0x2ecff0c1(_0xd3edbd6a _0x53a89df9, _0x41b355c2 _0xd3fb1c8c, RectTransform _0xc406f915, float _0x5075e769, float _0x4d8076ae, float _0x97ebd4ef)
    {
        this._0xb531a3e5 = _0x53a89df9;
        this._0x4e4675ad = _0xd3fb1c8c;
        this._0xe6ca5d3c = _0xc406f915;
        this._0xaea9864b = _0x5075e769;
        this._0x40493c60 = _0x4d8076ae;
        this._0x01ff91a7 = _0x97ebd4ef;
        this._0x0b40acb5 = new _0x70ded5f4[_0xd3edbd6a.Reels];
        for (int _0xdae590c5 = 0; _0xdae590c5 < _0xd3edbd6a.Reels; _0xdae590c5++)
        {
            RectTransform _0xbde30461 = _0x0bb64a0b.Node(_0xc406f915, _0xf91748d4._0xc4ebecd5(new byte[4] { 73, 126, 126, 119 }, 27) + _0xdae590c5.ToString(), new Vector2((_0xdae590c5 - 2) * _0x4d8076ae, 0f), new Vector2(_0x5075e769, _0x97ebd4ef * 3f));
            this._0x0b40acb5[_0xdae590c5] = new _0x70ded5f4()._0xd14b7a6c(_0x53a89df9, _0xd3fb1c8c, this._cellPrefab, _0xbde30461, _0xdae590c5, _0x5075e769, _0x97ebd4ef);
        }

        // Created AFTER the symbols on purpose: the payline marks are the low-alpha
        // overlay that is meant to sit on top of them (C.13).
        this._0x6bae645f = _0x0bb64a0b.Node(_0xc406f915, _0xf91748d4._0xc4ebecd5(new byte[8] { 116, 69, 93, 72, 77, 74, 65, 87 }, 36), Vector2.zero, new Vector2(_0x4d8076ae * 5f, _0x97ebd4ef * 3f));
        this._0x54fd0c13 = new int[_0xd3edbd6a.Reels];
        this._0xeea4bc9f = new bool[_0xd3edbd6a.Reels];
        this._0x804ed3ef = StateIdle;
        this._0x8d52bfa3 = true;
    }

    public void _0x7f1ed1d0(bool _0x3c62601b)
    {
        this._0x52389d52 = _0x3c62601b;
    }
}

internal static class _0xf91748d4
{
    internal static string _0xc4ebecd5(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}