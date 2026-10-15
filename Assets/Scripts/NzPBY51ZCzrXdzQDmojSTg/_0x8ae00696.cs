using UnityEngine;

// Fictional, closed, offline economy. Coins are mirrored into SETTINGS.PlayerSYSTEM.Coins
// so the template's own counters agree with ours. PlayerPrefs keys are STABLE LITERALS,
// never nameof (obfuscation renames symbols, and a renamed key loses the save).
// No constructor, no Awake-assigned singleton (C.59): the owner calls EnsureReady().
public sealed class _0x8ae00696
{
    public bool _0x1febf943()
    {
        this._0x2f7442c7();
        if (this._0xa0de5f82 >= _0x5b2be465.Length - 1)
        {
            return false;
        }

        this._0xa0de5f82++;
        this._0x299f6186();
        return true;
    }

    public int _0x8ed1f8ee
    {
        get
        {
            this._0x2f7442c7();
            return _0x5b2be465[this._0xa0de5f82];
        }
    }

    public bool _0x7649367a()
    {
        this._0x2f7442c7();
        return this._0x95b90038 < _0x5b2be465[0];
    }

    public int _0xc96bb9a6
    {
        get
        {
            this._0x2f7442c7();
            return this._0x95b90038;
        }
    }

    private bool _0xdf0db8f8;
    private void _0x299f6186()
    {
        PlayerPrefs.SetInt(_0xd39e89ce._0x5a0513a1(new byte[9] { 159, 146, 129, 219, 150, 154, 156, 155, 134 }, 245), this._0x95b90038);
        PlayerPrefs.SetInt(_0xd39e89ce._0x5a0513a1(new byte[7] { 39, 42, 57, 99, 47, 40, 57 }, 77), this._0xa0de5f82);
        if (_0x05c8a753.Instance != null)
        {
            _0xc3dbd8a4._0x5833a5d8._0xe99fdd92 = this._0x95b90038;
        }
    }

    private static readonly int[] _0x5b2be465 =
    {
        20,
        50,
        100,
        200
    };
    private int _0xa0de5f82;
    public _0x8ae00696 _0x2f7442c7()
    {
        if (this._0xdf0db8f8)
        {
            return this;
        }

        this._0xdf0db8f8 = true;
        this._0x95b90038 = PlayerPrefs.HasKey(_0xd39e89ce._0x5a0513a1(new byte[9] { 2, 15, 28, 70, 11, 7, 1, 6, 27 }, 104)) ? PlayerPrefs.GetInt(_0xd39e89ce._0x5a0513a1(new byte[9] { 142, 131, 144, 202, 135, 139, 141, 138, 151 }, 228)) : StartCoins;
        this._0xa0de5f82 = PlayerPrefs.HasKey(_0xd39e89ce._0x5a0513a1(new byte[7] { 127, 114, 97, 59, 119, 112, 97 }, 21)) ? PlayerPrefs.GetInt(_0xd39e89ce._0x5a0513a1(new byte[7] { 192, 205, 222, 132, 200, 207, 222 }, 170)) : 1;
        if (this._0xa0de5f82 < 0)
            this._0xa0de5f82 = 0;
        if (this._0xa0de5f82 > _0x5b2be465.Length - 1)
            this._0xa0de5f82 = _0x5b2be465.Length - 1;
        if (this._0x95b90038 < 0)
            this._0x95b90038 = 0;
        this._0x299f6186();
        return this;
    }

    public bool _0xa58f9149(int amount)
    {
        this._0x2f7442c7();
        if (amount <= 0 || this._0x95b90038 < amount)
        {
            return false;
        }

        this._0x95b90038 -= amount;
        this._0x299f6186();
        return true;
    }

    public int _0xeb5c5334
    {
        get
        {
            return _0x5b2be465[0];
        }
    }

    public const int RefillCoins = 1000;
    public bool _0x4e6d072b()
    {
        this._0x2f7442c7();
        if (this._0xa0de5f82 <= 0)
        {
            return false;
        }

        this._0xa0de5f82--;
        this._0x299f6186();
        return true;
    }

    private int _0x95b90038;
    public const int StartCoins = 5000;
    public void _0x82239263()
    {
        this._0x2f7442c7();
        this._0x95b90038 = StartCoins;
        this._0xa0de5f82 = 1;
        this._0x299f6186();
    }

    public void _0x6789d0c8(int amount)
    {
        this._0x2f7442c7();
        if (amount <= 0)
        {
            return;
        }

        this._0x95b90038 += amount;
        this._0x299f6186();
    }

    public bool _0x64654caf
    {
        get
        {
            this._0x2f7442c7();
            return this._0xa0de5f82 < _0x5b2be465.Length - 1;
        }
    }

    public bool _0x77d7bec8
    {
        get
        {
            this._0x2f7442c7();
            return this._0xa0de5f82 > 0;
        }
    }

    public void _0x4e4dfde1()
    {
        this._0x2f7442c7();
        this._0x95b90038 += RefillCoins;
        this._0x299f6186();
    }
}

internal static class _0xd39e89ce
{
    internal static string _0x5a0513a1(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}