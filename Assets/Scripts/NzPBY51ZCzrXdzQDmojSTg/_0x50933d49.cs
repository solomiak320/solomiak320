using UnityEngine;

// Eighteen shards across three albums of six. Completing album 1 unlocks room 2,
// album 2 unlocks room 3, album 3 grants a coin bonus. Local only, PlayerPrefs with
// stable literal keys. No constructor (C.59).
public sealed class _0x50933d49
{
    public int _0x42a83dfc()
    {
        this._0x4f8e33d1();
        int _0x1b86d479 = 0;
        for (int _0x5bf47373 = 0; _0x5bf47373 < AlbumCount; _0x5bf47373++)
        {
            if (this._0x619b734f[_0x5bf47373] >= ShardsPerAlbum)
            {
                _0x1b86d479++;
            }
        }

        return _0x1b86d479;
    }

    private int _0xf5298ce9;
    // Shards always land in the lowest album that still has room, so a player sees one
    // album fill before the next starts - the collection reads as progress, not noise.
    public int _0x861447e9(int _0xac3f7f2e)
    {
        this._0x4f8e33d1();
        int _0x02b389b5 = _0xac3f7f2e;
        int _0x1a959052 = 0;
        for (int _0x5d0acd99 = 0; _0x5d0acd99 < AlbumCount && _0x02b389b5 > 0; _0x5d0acd99++)
        {
            while (_0x02b389b5 > 0 && this._0x619b734f[_0x5d0acd99] < ShardsPerAlbum)
            {
                this._0x619b734f[_0x5d0acd99]++;
                _0x02b389b5--;
                _0x1a959052++;
            }
        }

        this._0x56e38293();
        return _0x1a959052;
    }

    public int _0x87920c41
    {
        get
        {
            this._0x4f8e33d1();
            return this._0xf5298ce9;
        }
    }

    public const int ShardsPerAlbum = 6;
    public _0x50933d49 _0x4f8e33d1()
    {
        if (this._0x562acda6)
        {
            return this;
        }

        this._0x562acda6 = true;
        this._0x619b734f = new int[AlbumCount];
        int _0x63226bdc = PlayerPrefs.HasKey(_0x51d336bb._0x787f9298(new byte[10] { 21, 24, 11, 81, 12, 23, 30, 13, 27, 12 }, 127)) ? PlayerPrefs.GetInt(_0x51d336bb._0x787f9298(new byte[10] { 154, 151, 132, 222, 131, 152, 145, 130, 148, 131 }, 240)) : 0;
        for (int _0x3a38d6e7 = 0; _0x3a38d6e7 < AlbumCount; _0x3a38d6e7++)
        {
            int _0xcbd04a7e = (_0x63226bdc >> (_0x3a38d6e7 * 4)) & 0xF;
            this._0x619b734f[_0x3a38d6e7] = _0xcbd04a7e > ShardsPerAlbum ? ShardsPerAlbum : _0xcbd04a7e;
        }

        this._0xf5298ce9 = PlayerPrefs.HasKey(_0x51d336bb._0x787f9298(new byte[8] { 46, 35, 48, 106, 54, 43, 43, 41 }, 68)) ? PlayerPrefs.GetInt(_0x51d336bb._0x787f9298(new byte[8] { 109, 96, 115, 41, 117, 104, 104, 106 }, 7)) : 1;
        if (this._0xf5298ce9 < 1)
            this._0xf5298ce9 = 1;
        if (this._0xf5298ce9 > AlbumCount)
            this._0xf5298ce9 = AlbumCount;
        return this;
    }

    public void _0xcbb7043b()
    {
        this._0x4f8e33d1();
        for (int _0x227d5b89 = 0; _0x227d5b89 < AlbumCount; _0x227d5b89++)
        {
            this._0x619b734f[_0x227d5b89] = 0;
        }

        this._0xf5298ce9 = 1;
        this._0x56e38293();
        PlayerPrefs.SetInt(_0x51d336bb._0x787f9298(new byte[8] { 57, 52, 39, 125, 33, 60, 60, 62 }, 83), this._0xf5298ce9);
    }

    private void _0x56e38293()
    {
        int _0x1a4392ac = 0;
        for (int _0x3c077df7 = 0; _0x3c077df7 < AlbumCount; _0x3c077df7++)
        {
            _0x1a4392ac |= (this._0x619b734f[_0x3c077df7] & 0xF) << (_0x3c077df7 * 4);
        }

        PlayerPrefs.SetInt(_0x51d336bb._0x787f9298(new byte[10] { 230, 235, 248, 162, 255, 228, 237, 254, 232, 255 }, 140), _0x1a4392ac);
        if (this._0xf5298ce9 > this._0x0c132852())
        {
            this._0xf5298ce9 = this._0x0c132852();
            PlayerPrefs.SetInt(_0x51d336bb._0x787f9298(new byte[8] { 133, 136, 155, 193, 157, 128, 128, 130 }, 239), this._0xf5298ce9);
        }
    }

    private bool _0x562acda6;
    public const int AlbumCount = 3;
    public int _0x4f0ca564(int _0xae74beb3)
    {
        this._0x4f8e33d1();
        if (_0xae74beb3 < 0 || _0xae74beb3 >= AlbumCount)
        {
            return 0;
        }

        return this._0x619b734f[_0xae74beb3];
    }

    private int[] _0x619b734f;
    public bool _0xb7934547(int _0xcbb1f766)
    {
        return this._0x4f0ca564(_0xcbb1f766) >= ShardsPerAlbum;
    }

    public bool _0x45484840(int _0x7db888ba)
    {
        this._0x4f8e33d1();
        int _0x50216542 = _0x7db888ba;
        if (_0x50216542 < 1)
            _0x50216542 = 1;
        if (_0x50216542 > this._0x0c132852())
            _0x50216542 = this._0x0c132852();
        bool _0xffad7483 = _0x50216542 != this._0xf5298ce9;
        this._0xf5298ce9 = _0x50216542;
        PlayerPrefs.SetInt(_0x51d336bb._0x787f9298(new byte[8] { 18, 31, 12, 86, 10, 23, 23, 21 }, 120), this._0xf5298ce9);
        return _0xffad7483;
    }

    // Rooms unlocked = 1 + completed albums, capped at the number of rooms we dress.
    public int _0x0c132852()
    {
        int _0x597cbcd9 = 1 + this._0x42a83dfc();
        return _0x597cbcd9 > AlbumCount ? AlbumCount : _0x597cbcd9;
    }

    public int _0x7fac9991()
    {
        this._0x4f8e33d1();
        int _0x1b5e7746 = this._0xf5298ce9 + 1;
        if (_0x1b5e7746 > AlbumCount)
        {
            _0x1b5e7746 = 1;
        }

        return _0x1b5e7746;
    }

    public int _0x6f815bb8()
    {
        this._0x4f8e33d1();
        int _0xd98b9259 = 0;
        for (int _0xa5d7ae38 = 0; _0xa5d7ae38 < AlbumCount; _0xa5d7ae38++)
        {
            _0xd98b9259 += this._0x619b734f[_0xa5d7ae38];
        }

        return _0xd98b9259;
    }

    public const int CompletionBonus = 5000;
}

internal static class _0x51d336bb
{
    internal static string _0x787f9298(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}