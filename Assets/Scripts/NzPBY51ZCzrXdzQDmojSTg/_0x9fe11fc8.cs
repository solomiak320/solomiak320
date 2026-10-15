using UnityEngine;

// Three local missions, drawn from a pool by a DATE seed, so two days differ and the
// lobby card is never the same two runs running (C.11). System.Random, never
// UnityEngine.Random: the latter is global state two systems would fight over.
// No constructor (C.59).
public sealed class _0x9fe11fc8
{
    // Returns the coins earned by missions that completed on this report.
    public int _0x0d2a9c47(int _0x49eea5bc, int amount)
    {
        this._0xe31e93af();
        int _0xa2ea8197 = 0;
        for (int _0x9e0d5a7a = 0; _0x9e0d5a7a < MissionCount; _0x9e0d5a7a++)
        {
            if (this._0x2cdf1a03[_0x9e0d5a7a] != _0x49eea5bc || amount <= 0)
            {
                continue;
            }

            bool _0x5a059805 = this._0x3e332361[_0x9e0d5a7a] >= this._0x1172dd56[_0x9e0d5a7a];
            this._0x3e332361[_0x9e0d5a7a] += amount;
            PlayerPrefs.SetInt(_0xd62fd995._0x75adafb6(new byte[6] { 243, 254, 237, 183, 244, 233 }, 153) + _0x9e0d5a7a.ToString(), this._0x3e332361[_0x9e0d5a7a]);
            if (!_0x5a059805 && this._0x3e332361[_0x9e0d5a7a] >= this._0x1172dd56[_0x9e0d5a7a])
            {
                _0xa2ea8197 += this._0xef83aab2[_0x9e0d5a7a];
            }
        }

        return _0xa2ea8197;
    }

    private bool _0x3c55822c;
    private int[] _0xef83aab2;
    private int _0x2b17decf()
    {
        System.DateTime _0x41d2a6c5 = System.DateTime.Now;
        return _0x41d2a6c5.Year * 10000 + _0x41d2a6c5.Month * 100 + _0x41d2a6c5.Day;
    }

    private int _0xce08ca7c;
    // The mission the lobby ticker and the game-scene chip show: the first unfinished one.
    public int _0xc5f7772a()
    {
        this._0xe31e93af();
        for (int _0x1d91939c = 0; _0x1d91939c < MissionCount; _0x1d91939c++)
        {
            if (!this._0x098d8b1b(_0x1d91939c))
            {
                return _0x1d91939c;
            }
        }

        return -1;
    }

    public _0x9fe11fc8 _0xe31e93af()
    {
        if (this._0x3c55822c)
        {
            return this;
        }

        this._0x3c55822c = true;
        this._0x2cdf1a03 = new int[MissionCount];
        this._0x1172dd56 = new int[MissionCount];
        this._0x3e332361 = new int[MissionCount];
        this._0xef83aab2 = new int[MissionCount];
        int _0xd80c4456 = this._0x2b17decf();
        int _0xe8f052d1 = PlayerPrefs.HasKey(_0xd62fd995._0x75adafb6(new byte[12] { 161, 172, 191, 229, 166, 162, 184, 184, 162, 164, 165, 184 }, 203)) ? PlayerPrefs.GetInt(_0xd62fd995._0x75adafb6(new byte[12] { 188, 177, 162, 248, 187, 191, 165, 165, 191, 185, 184, 165 }, 214)) : 0;
        this._0xce08ca7c = _0xe8f052d1;
        this._0xf944b77b(_0xd80c4456);
        if (_0xe8f052d1 == _0xd80c4456)
        {
            for (int _0x3d2e2e40 = 0; _0x3d2e2e40 < MissionCount; _0x3d2e2e40++)
            {
                this._0x3e332361[_0x3d2e2e40] = PlayerPrefs.GetInt(_0xd62fd995._0x75adafb6(new byte[6] { 204, 193, 210, 136, 203, 214 }, 166) + _0x3d2e2e40.ToString(), 0);
            }
        }
        else
        {
            this._0xce08ca7c = _0xd80c4456;
            PlayerPrefs.SetInt(_0xd62fd995._0x75adafb6(new byte[12] { 66, 79, 92, 6, 69, 65, 91, 91, 65, 71, 70, 91 }, 40), _0xd80c4456);
            for (int _0x4cc7744b = 0; _0x4cc7744b < MissionCount; _0x4cc7744b++)
            {
                this._0x3e332361[_0x4cc7744b] = 0;
                PlayerPrefs.SetInt(_0xd62fd995._0x75adafb6(new byte[6] { 182, 187, 168, 242, 177, 172 }, 220) + _0x4cc7744b.ToString(), 0);
            }
        }

        return this;
    }

    public const int KindJokers = 1;
    public int _0xc9e982f8(int _0x4db155e0)
    {
        this._0xe31e93af();
        return this._0x1172dd56[_0x4db155e0];
    }

    public bool _0x098d8b1b(int _0x586ae879)
    {
        return this._0x451f3ea9(_0x586ae879) >= this._0xc9e982f8(_0x586ae879);
    }

    public bool _0x451ba924()
    {
        this._0xe31e93af();
        for (int _0x0f20da11 = 0; _0x0f20da11 < MissionCount; _0x0f20da11++)
        {
            if (!this._0x098d8b1b(_0x0f20da11))
            {
                return false;
            }
        }

        return true;
    }

    public const int KindSpins = 0;
    public int _0x451f3ea9(int _0x4f8450dd)
    {
        this._0xe31e93af();
        int _0x5ad26cde = this._0x3e332361[_0x4f8450dd];
        return _0x5ad26cde > this._0x1172dd56[_0x4f8450dd] ? this._0x1172dd56[_0x4f8450dd] : _0x5ad26cde;
    }

    public string _0x1e94d6a2(int _0x76873da6)
    {
        this._0xe31e93af();
        int _0xef8b4cc0 = this._0x2cdf1a03[_0x76873da6];
        string _0x0d833a64 = this._0x1172dd56[_0x76873da6].ToString();
        if (_0xef8b4cc0 == KindSpins)
            return _0xd62fd995._0x75adafb6(new byte[5] { 180, 183, 174, 169, 199 }, 231) + _0x0d833a64 + _0xd62fd995._0x75adafb6(new byte[6] { 24, 108, 113, 117, 125, 107 }, 56);
        if (_0xef8b4cc0 == KindJokers)
            return _0xd62fd995._0x75adafb6(new byte[5] { 136, 133, 138, 128, 228 }, 196) + _0x0d833a64 + _0xd62fd995._0x75adafb6(new byte[7] { 112, 26, 31, 27, 21, 2, 3 }, 80);
        if (_0xef8b4cc0 == KindShards)
            return _0xd62fd995._0x75adafb6(new byte[8] { 143, 131, 128, 128, 137, 143, 152, 236 }, 204) + _0x0d833a64 + _0xd62fd995._0x75adafb6(new byte[7] { 53, 70, 93, 84, 71, 81, 70 }, 21);
        if (_0xef8b4cc0 == KindCoins)
            return _0xd62fd995._0x75adafb6(new byte[4] { 237, 243, 244, 154 }, 186) + _0x0d833a64 + _0xd62fd995._0x75adafb6(new byte[12] { 147, 240, 252, 250, 253, 224, 147, 231, 252, 247, 242, 234 }, 179);
        return _0xd62fd995._0x75adafb6(new byte[4] { 193, 192, 221, 169 }, 137) + _0x0d833a64 + _0xd62fd995._0x75adafb6(new byte[14] { 113, 2, 18, 16, 5, 5, 20, 3, 113, 5, 3, 24, 30, 2 }, 81);
    }

    private int[] _0x1172dd56;
    public int _0xc54c193d(int _0xa43e123e)
    {
        this._0xe31e93af();
        return this._0xef83aab2[_0xa43e123e];
    }

    public void _0x90d6d60d()
    {
        this._0xe31e93af();
        for (int _0x7cdb9bfb = 0; _0x7cdb9bfb < MissionCount; _0x7cdb9bfb++)
        {
            this._0x3e332361[_0x7cdb9bfb] = 0;
            PlayerPrefs.SetInt(_0xd62fd995._0x75adafb6(new byte[6] { 32, 45, 62, 100, 39, 58 }, 74) + _0x7cdb9bfb.ToString(), 0);
        }
    }

    private int[] _0x2cdf1a03;
    public int _0x2ad38779(int _0x9811e0f5)
    {
        this._0xe31e93af();
        return this._0x2cdf1a03[_0x9811e0f5];
    }

    private void _0xf944b77b(int _0xd9112783)
    {
        int _0xde84b1ef = (_0xd9112783 * 7919) ^ 104729;
        System.Random _0xce2a9c08 = new System.Random(_0xde84b1ef);
        int[] _0xa127a9a4 =
        {
            KindSpins,
            KindJokers,
            KindShards,
            KindCoins,
            KindScatters
        };
        for (int _0xdf3d6467 = _0xa127a9a4.Length - 1; _0xdf3d6467 > 0; _0xdf3d6467--)
        {
            int _0x34e77237 = _0xce2a9c08.Next(_0xdf3d6467 + 1);
            int _0x6d27f6bc = _0xa127a9a4[_0xdf3d6467];
            _0xa127a9a4[_0xdf3d6467] = _0xa127a9a4[_0x34e77237];
            _0xa127a9a4[_0x34e77237] = _0x6d27f6bc;
        }

        int[] _0x331bda3f =
        {
            15,
            25,
            40
        };
        int[] _0xcd057831 =
        {
            3,
            4,
            6
        };
        int[] _0x051d83b1 =
        {
            4,
            6,
            8
        };
        int[] _0x74b61cd1 =
        {
            800,
            1500,
            2500
        };
        int[] _0xd05cc522 =
        {
            2,
            3,
            3
        };
        for (int _0xb842c8a7 = 0; _0xb842c8a7 < MissionCount; _0xb842c8a7++)
        {
            int _0x4a13d7e9 = _0xa127a9a4[_0xb842c8a7];
            this._0x2cdf1a03[_0xb842c8a7] = _0x4a13d7e9;
            if (_0x4a13d7e9 == KindSpins)
                this._0x1172dd56[_0xb842c8a7] = _0x331bda3f[_0xce2a9c08.Next(_0x331bda3f.Length)];
            else if (_0x4a13d7e9 == KindJokers)
                this._0x1172dd56[_0xb842c8a7] = _0xcd057831[_0xce2a9c08.Next(_0xcd057831.Length)];
            else if (_0x4a13d7e9 == KindShards)
                this._0x1172dd56[_0xb842c8a7] = _0x051d83b1[_0xce2a9c08.Next(_0x051d83b1.Length)];
            else if (_0x4a13d7e9 == KindCoins)
                this._0x1172dd56[_0xb842c8a7] = _0x74b61cd1[_0xce2a9c08.Next(_0x74b61cd1.Length)];
            else
                this._0x1172dd56[_0xb842c8a7] = _0xd05cc522[_0xce2a9c08.Next(_0xd05cc522.Length)];
            this._0xef83aab2[_0xb842c8a7] = 300 + _0xce2a9c08.Next(7) * 100;
        }

        {
#if B_LOGS
            {
                Debug.Log($"[missions] day={_0xd9112783} seed={_0xde84b1ef} k0={this._0x2cdf1a03[0]} k1={this._0x2cdf1a03[1]} k2={this._0x2cdf1a03[2]}");
            }
#endif
        }
    }

    public const int KindScatters = 4;
    public const int KindShards = 2;
    public const int MissionCount = 3;
    public const int KindCoins = 3;
    private int[] _0x3e332361;
}

internal static class _0xd62fd995
{
    internal static string _0x75adafb6(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}