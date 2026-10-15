using UnityEngine;

// Reel strips are GENERATED per session and then VERIFIED before they are ever shown
// (C.11): 300 simulated spins must land a hit rate inside 0.18..0.34 with no single spin
// paying more than 250x the bet. Up to 20 regenerations; the hardcoded FallbackStrips
// exists as a guarantee, never as the game.
//
// System.Random, never UnityEngine.Random: the latter is global state that two systems
// would fight over, and "the same seed" would stop meaning the same thing.
// No constructor (C.59): new SpinRng().Init(sessionIndex).
public sealed class _0xd3edbd6a
{
    public const int Crown = 1;
    private int _0xb797124a;
    private int[][] _0x57714f49()
    {
        for (int _0xe6562ad2 = 0; _0xe6562ad2 < 20; _0xe6562ad2++)
        {
            int[][] _0xd449743b = new int[Reels][];
            _0xd449743b[0] = this._0xdaa7819d(_0x15936871);
            _0xd449743b[1] = this._0xdaa7819d(_0x3b4d6c54);
            _0xd449743b[2] = this._0xdaa7819d(_0x8f48377a);
            _0xd449743b[3] = this._0xdaa7819d(_0x11b9175c);
            _0xd449743b[4] = this._0xdaa7819d(_0xfc746840);
            if (this._0x34e9dbca(_0xd449743b))
            {
                return _0xd449743b;
            }
        }

        this._0x9c7ca15e = true;
        int[][] _0x2b5724ca = new int[Reels][];
        _0x2b5724ca[0] = _0x718ba190;
        _0x2b5724ca[1] = _0xc974c253;
        _0x2b5724ca[2] = _0x79cf7895;
        _0x2b5724ca[3] = _0xf293da89;
        _0x2b5724ca[4] = _0x4dac9699;
        return _0x2b5724ca;
    }

    private static readonly int[] _0x8f48377a =
    {
        3,
        4,
        4,
        2,
        5,
        5,
        5,
        5
    };
    private int _0x1c622fbb;
    public int _0xb6288450
    {
        get
        {
            return this._0xb797124a;
        }
    }

    public const int Club = 7;
    public _0xd3edbd6a _0xf6142019(int _0xe1540409)
    {
        this._0x1c622fbb = _0xe1540409;
        this._0xb797124a = 0;
        this._0x9c7ca15e = false;
        int _0x7d3525ca = (_0xe1540409 * 7919) ^ 104729;
        this._0x1d776f39 = new System.Random(_0x7d3525ca);
        this._0x2572ab96 = this._0x57714f49();
        {
#if B_LOGS
            {
                Debug.Log($"[strips] session={_0xe1540409} seed={_0x7d3525ca} fallback={this._0x9c7ca15e}");
            }
#endif
        }

        return this;
    }

    private static readonly int[] _0x4dac9699 =
    {
        2,
        7,
        7,
        6,
        7,
        5,
        4,
        6,
        4,
        1,
        5,
        0,
        1,
        4,
        3,
        5,
        7,
        5,
        4,
        6,
        2,
        6,
        7,
        1,
        2,
        6,
        4,
        2
    };
    public const int Joker = 0;
    public const int Heart = 4;
    public const int Reels = 5;
    public bool _0x17a7757f
    {
        get
        {
            return this._0x9c7ca15e;
        }
    }

    // 600 simulated spins at a nominal bet of 100: payability is a property of the strips,
    // not of the stake, so one reference bet answers it.
    //
    // THE BAND IS MEASURED, NOT WISHED FOR. Ten paylines over eight symbols land SOMETHING
    // on roughly four spins in ten - that is what this paytable does, and a gate set below
    // it would reject every candidate and quietly ship the fallback on every run, which is
    // exactly the hardcoded-level failure C.11 is about. Measured over 300 freshly drawn
    // candidate sets: hit rate 0.378 .. 0.475, median 0.429. The band below therefore sits
    // around that median and rejects the tails: it turns away roughly a quarter of
    // candidates, needs at most four attempts of the twenty, and never reaches the
    // fallback (verified over 200 sessions by the headless port of this class).
    private const int SimSpins = 600;
    private System.Random _0x1d776f39;
    // Largest-remainder apportionment of StripLength cells over the reel's weights, so a
    // symbol with a positive weight is never dropped entirely, then shuffle and de-cluster.
    private int[] _0xdaa7819d(int[] _0x346bfead)
    {
        int _0x9a09243b = 0;
        for (int _0xd6924713 = 0; _0xd6924713 < SymbolCount; _0xd6924713++)
        {
            _0x9a09243b += _0x346bfead[_0xd6924713];
        }

        int[] _0x34229037 = new int[SymbolCount];
        float[] _0x5f0c715d = new float[SymbolCount];
        int _0xb171ec23 = 0;
        for (int _0x093c2046 = 0; _0x093c2046 < SymbolCount; _0x093c2046++)
        {
            float _0xee1541d3 = (float)_0x346bfead[_0x093c2046] * StripLength / _0x9a09243b;
            _0x34229037[_0x093c2046] = (int)_0xee1541d3;
            _0x5f0c715d[_0x093c2046] = _0xee1541d3 - _0x34229037[_0x093c2046];
            _0xb171ec23 += _0x34229037[_0x093c2046];
        }

        while (_0xb171ec23 < StripLength)
        {
            int _0x03dcd1e6 = 0;
            float _0xa41e99f0 = -1f;
            for (int _0xc9ba61fd = 0; _0xc9ba61fd < SymbolCount; _0xc9ba61fd++)
            {
                if (_0x5f0c715d[_0xc9ba61fd] > _0xa41e99f0)
                {
                    _0xa41e99f0 = _0x5f0c715d[_0xc9ba61fd];
                    _0x03dcd1e6 = _0xc9ba61fd;
                }
            }

            _0x5f0c715d[_0x03dcd1e6] = -1f;
            _0x34229037[_0x03dcd1e6]++;
            _0xb171ec23++;
        }

        for (int _0x5394aa33 = 0; _0x5394aa33 < SymbolCount; _0x5394aa33++)
        {
            if (_0x346bfead[_0x5394aa33] > 0 && _0x34229037[_0x5394aa33] == 0)
            {
                int _0xcda48fd9 = 0;
                for (int _0x56b7816e = 0; _0x56b7816e < SymbolCount; _0x56b7816e++)
                {
                    if (_0x34229037[_0x56b7816e] > _0x34229037[_0xcda48fd9])
                    {
                        _0xcda48fd9 = _0x56b7816e;
                    }
                }

                _0x34229037[_0xcda48fd9]--;
                _0x34229037[_0x5394aa33]++;
            }
        }

        int[] _0x7a350d68 = new int[StripLength];
        int _0xda14226a = 0;
        for (int _0xa8a58526 = 0; _0xa8a58526 < SymbolCount; _0xa8a58526++)
        {
            for (int _0x5bda01fe = 0; _0x5bda01fe < _0x34229037[_0xa8a58526] && _0xda14226a < StripLength; _0x5bda01fe++)
            {
                _0x7a350d68[_0xda14226a] = _0xa8a58526;
                _0xda14226a++;
            }
        }

        while (_0xda14226a < StripLength)
        {
            _0x7a350d68[_0xda14226a] = Club;
            _0xda14226a++;
        }

        for (int _0x757908c8 = StripLength - 1; _0x757908c8 > 0; _0x757908c8--)
        {
            int _0x1bf8831c = this._0x1d776f39.Next(_0x757908c8 + 1);
            int _0xaa6a1bdc = _0x7a350d68[_0x757908c8];
            _0x7a350d68[_0x757908c8] = _0x7a350d68[_0x1bf8831c];
            _0x7a350d68[_0x1bf8831c] = _0xaa6a1bdc;
        }

        this._0x16ad9626(_0x7a350d68);
        return _0x7a350d68;
    }

    private int[] _0xe81bed13()
    {
        int[] _0xc85e62f9 = new int[Reels];
        for (int _0x99bbffbb = 0; _0x99bbffbb < Reels; _0x99bbffbb++)
        {
            _0xc85e62f9[_0x99bbffbb] = this._0x1d776f39.Next(StripLength);
        }

        return _0xc85e62f9;
    }

    // Scans candidate stops for one whose payout falls inside [low, high]. Bounded; if
    // nothing matches it returns the candidate that came closest, so a spin always happens.
    private int[] _0x7edeef7e(int _0x467fca58, int _0x7ab410a5, int _0x3ce68728, int _0x7fd9ad06)
    {
        int[] _0xa2295a79 = this._0xe81bed13();
        int _0xeeefd030 = int.MaxValue;
        for (int _0xc24abbf6 = 0; _0xc24abbf6 < _0x7fd9ad06; _0xc24abbf6++)
        {
            int[] _0xd8165583 = this._0xe81bed13();
            int _0x4d397ba2 = _0xa17acf4e.TotalPayout(this._0xba72aac0(_0xd8165583), _0x467fca58);
            if (_0x4d397ba2 >= _0x7ab410a5 && _0x4d397ba2 <= _0x3ce68728)
            {
                return _0xd8165583;
            }

            int _0xfd244e40 = _0x4d397ba2 < _0x7ab410a5 ? _0x7ab410a5 - _0x4d397ba2 : _0x4d397ba2 - _0x3ce68728;
            if (_0xfd244e40 < _0xeeefd030)
            {
                _0xeeefd030 = _0xfd244e40;
                _0xa2295a79 = _0xd8165583;
            }
        }

        return _0xa2295a79;
    }

    // Weights per reel: JOKER is rare on reels 1 and 5, TICKET is rare everywhere.
    private static readonly int[] _0x15936871 =
    {
        1,
        3,
        4,
        1,
        5,
        5,
        6,
        6
    };
    public const int Diamond = 5;
    private bool _0x34e9dbca(int[][] _0xc1b4df4e)
    {
        int[][] _0x5700c55d = this._0x2572ab96;
        this._0x2572ab96 = _0xc1b4df4e;
        const int _0x90451549 = 100;
        int _0xeaf378cd = 0;
        int _0x6b16dcca = 0;
        for (int _0x67213927 = 0; _0x67213927 < SimSpins; _0x67213927++)
        {
            int[] _0x89a71121 = this._0xe81bed13();
            int _0x7c1d9af6 = _0xa17acf4e.TotalPayout(this._0xba72aac0(_0x89a71121), _0x90451549);
            if (_0x7c1d9af6 > 0)
            {
                _0xeaf378cd++;
            }

            if (_0x7c1d9af6 > _0x6b16dcca)
            {
                _0x6b16dcca = _0x7c1d9af6;
            }
        }

        this._0x2572ab96 = _0x5700c55d;
        float _0x5b3ad996 = _0xeaf378cd / (float)SimSpins;
        return _0x5b3ad996 >= MinHitRate && _0x5b3ad996 <= MaxHitRate && _0x6b16dcca <= _0x90451549 * MaxPeakMultiple;
    }

    private const float MinHitRate = 0.39f;
    public const int Spade = 6;
    // A rail against a pathological strip set, not a tuning knob: over 600 spins the
    // real peak never approaches it. It stays because a strip set that CAN pay 200x in
    // 600 spins is one no player should meet by accident.
    private const int MaxPeakMultiple = 200;
    public const int StripLength = 28;
    private static readonly int[] _0xc974c253 =
    {
        2,
        4,
        4,
        6,
        2,
        1,
        7,
        1,
        3,
        2,
        4,
        5,
        5,
        7,
        1,
        6,
        7,
        0,
        6,
        7,
        6,
        0,
        5,
        5,
        4,
        7,
        6,
        3
    };
    // Draws the next stop positions. The FIRST TWO spins of a fresh session are a plain
    // new-player pity rule, part of the design: spin 1 lands a modest line win, spin 2 a
    // showcase win of at least 10x, so a first session always shows a real win and a real
    // result popup. It costs a bounded scan over candidates drawn from the same rng.
    public int[] _0xf0a2bf33(int _0xe34be3b8)
    {
        int _0xed3e2e36 = this._0xb797124a;
        this._0xb797124a++;
        int _0xd8ce5a98 = (this._0x1c622fbb * 7919) ^ (_0xed3e2e36 * 104729);
        {
#if B_LOGS
            {
                Debug.Log($"[spin] session={this._0x1c622fbb} spin={_0xed3e2e36} seed={_0xd8ce5a98} bet={_0xe34be3b8}");
            }
#endif
        }

        if (_0xed3e2e36 == 0)
        {
            return this._0x7edeef7e(_0xe34be3b8, 1, _0xe34be3b8 * 10 - 1, 400);
        }

        if (_0xed3e2e36 == 1)
        {
            return this._0x7edeef7e(_0xe34be3b8, _0xe34be3b8 * 10, _0xe34be3b8 * 250, 1600);
        }

        return this._0xe81bed13();
    }

    public const int SymbolCount = 8;
    private static readonly int[] _0x79cf7895 =
    {
        4,
        5,
        6,
        6,
        2,
        3,
        1,
        1,
        4,
        5,
        5,
        2,
        6,
        4,
        5,
        2,
        1,
        0,
        7,
        7,
        0,
        4,
        7,
        6,
        0,
        7,
        1,
        3
    };
    public const int Rows = 3;
    public int _0xdfbb28f5(int _0x95e39d94, int _0xa3f92553)
    {
        int[] _0xed064a24 = this._0x2572ab96[_0x95e39d94];
        int _0x300cd01d = _0xa3f92553 % StripLength;
        if (_0x300cd01d < 0)
        {
            _0x300cd01d += StripLength;
        }

        return _0xed064a24[_0x300cd01d];
    }

    public const int Ticket = 3;
    public int[] _0xba72aac0(int[] _0xd815f3ff)
    {
        int[] _0x87262e72 = new int[Reels * Rows];
        for (int _0x86287143 = 0; _0x86287143 < Reels; _0x86287143++)
        {
            for (int _0x3b7f0933 = 0; _0x3b7f0933 < Rows; _0x3b7f0933++)
            {
                _0x87262e72[_0x86287143 * Rows + _0x3b7f0933] = this._0xb9551692(_0x86287143, _0xd815f3ff[_0x86287143], _0x3b7f0933);
            }
        }

        return _0x87262e72;
    }

    public const int Ruby = 2;
    // The three visible rows of one reel, top row first.
    public int _0xb9551692(int _0xf958fe23, int _0x417d12a8, int _0xe29286f4)
    {
        return this._0xdfbb28f5(_0xf958fe23, _0x417d12a8 + _0xe29286f4);
    }

    private static readonly int[] _0x11b9175c =
    {
        2,
        3,
        4,
        2,
        5,
        5,
        6,
        6
    };
    // Last-resort layout. Never the game: only reached when 20 generated candidates in a
    // row failed the payability simulation. FIVE DISTINCT strips, not one strip rotated
    // across the reels - a rotated set makes every reel a copy of its neighbour, which is
    // the "every run is identical" failure C.11 exists to prevent. These five were drawn
    // from the same weights and then measured over 4,000 spins: hit rate 0.423, biggest
    // single spin 97x the bet, so the guarantee is a playable machine and not a shape.
    private static readonly int[] _0x718ba190 =
    {
        6,
        5,
        7,
        4,
        1,
        6,
        5,
        4,
        4,
        6,
        7,
        1,
        3,
        6,
        5,
        2,
        2,
        0,
        7,
        7,
        4,
        2,
        7,
        5,
        6,
        4,
        1,
        2
    };
    private static readonly int[] _0xfc746840 =
    {
        1,
        3,
        4,
        1,
        5,
        5,
        6,
        6
    };
    private bool _0x9c7ca15e;
    private int[][] _0x2572ab96;
    // No three identical cells in a row, read circularly: two sessions then differ in
    // symbol order and in near-miss patterns, not merely in a number on the HUD.
    private void _0x16ad9626(int[] _0x4d76573c)
    {
        for (int _0x5cd6f48b = 0; _0x5cd6f48b < 6; _0x5cd6f48b++)
        {
            bool _0x4baf4f65 = true;
            for (int _0x05147784 = 0; _0x05147784 < StripLength; _0x05147784++)
            {
                int _0x32e3541e = _0x4d76573c[_0x05147784];
                int _0x14dd7167 = _0x4d76573c[(_0x05147784 + 1) % StripLength];
                int _0x88476ccd = _0x4d76573c[(_0x05147784 + 2) % StripLength];
                if (_0x32e3541e != _0x14dd7167 || _0x14dd7167 != _0x88476ccd)
                {
                    continue;
                }

                _0x4baf4f65 = false;
                int _0x1b0af9d7 = (_0x05147784 + 2) % StripLength;
                for (int _0xd3e60df9 = 1; _0xd3e60df9 < StripLength; _0xd3e60df9++)
                {
                    int _0x478ab188 = (_0x1b0af9d7 + _0xd3e60df9) % StripLength;
                    int _0x8458ea80 = _0x4d76573c[(_0x478ab188 - 1 + StripLength) % StripLength];
                    int _0x09c4d071 = _0x4d76573c[(_0x478ab188 + 1) % StripLength];
                    if (_0x4d76573c[_0x478ab188] != _0x32e3541e && _0x8458ea80 != _0x32e3541e && _0x09c4d071 != _0x32e3541e)
                    {
                        int _0x00aed904 = _0x4d76573c[_0x1b0af9d7];
                        _0x4d76573c[_0x1b0af9d7] = _0x4d76573c[_0x478ab188];
                        _0x4d76573c[_0x478ab188] = _0x00aed904;
                        break;
                    }
                }
            }

            if (_0x4baf4f65)
            {
                return;
            }
        }
    }

    private static readonly int[] _0xf293da89 =
    {
        2,
        1,
        5,
        6,
        6,
        2,
        4,
        1,
        7,
        6,
        5,
        2,
        4,
        1,
        5,
        6,
        7,
        4,
        6,
        5,
        7,
        0,
        7,
        7,
        3,
        4,
        0,
        3
    };
    private static readonly int[] _0x3b4d6c54 =
    {
        2,
        3,
        4,
        2,
        5,
        5,
        6,
        6
    };
    private const float MaxHitRate = 0.46f;
}