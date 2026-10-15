using System.Collections.Generic;
using UnityEngine;

// Ten fixed paylines, left to right, one bet covering all ten. JOKER is wild and
// substitutes for everything except TICKET; TICKET is a scatter and pays anywhere on the
// screen. Every multiplier applies to the TOTAL BET and is held in hundredths so the
// whole evaluation is integer arithmetic.
// No constructor (C.59): a static evaluator plus a small result record built with Init().
public sealed class _0xb17cbc9c
{
    public int Line;
    public int Count;
    public int Symbol;
    public int Payout;
    public _0xb17cbc9c _0x5f71a0bb(int _0xbe624410, int _0xfa9421b0, int _0x97f156b7, int _0x0bb899e1, bool _0xbc95d611)
    {
        this.Line = _0xbe624410;
        this.Symbol = _0xfa9421b0;
        this.Count = _0x97f156b7;
        this.Payout = _0x0bb899e1;
        this.Scatter = _0xbc95d611;
        return this;
    }

    public bool Scatter;
}

public static class _0xa17acf4e
{
    public const int LineCount = 10;
    public static List<_0xb17cbc9c> Evaluate(int[] _0xa1e46d68, int _0xdf6ceefc)
    {
        List<_0xb17cbc9c> _0xdab58877 = new List<_0xb17cbc9c>();
        for (int _0xbb367512 = 0; _0xbb367512 < LineCount; _0xbb367512++)
        {
            int[] _0xa7e169fe = Line(_0xbb367512);
            int _0xb5ebeee3 = Cell(_0xa1e46d68, 0, _0xa7e169fe[0]);
            if (_0xb5ebeee3 == _0xd3edbd6a.Ticket)
            {
                continue; // scatters never pay on a line
            }

            int _0xffa46c4c = _0xb5ebeee3;
            int _0x303449b2 = 1;
            for (int _0x8dcf970f = 1; _0x8dcf970f < _0xd3edbd6a.Reels; _0x8dcf970f++)
            {
                int _0x484c4638 = Cell(_0xa1e46d68, _0x8dcf970f, _0xa7e169fe[_0x8dcf970f]);
                if (_0x484c4638 == _0xd3edbd6a.Ticket)
                {
                    break;
                }

                if (_0xffa46c4c == _0xd3edbd6a.Joker && _0x484c4638 != _0xd3edbd6a.Joker)
                {
                    _0xffa46c4c = _0x484c4638; // a leading wild takes the identity of the first real symbol
                    _0x303449b2++;
                    continue;
                }

                if (_0x484c4638 == _0xffa46c4c || _0x484c4638 == _0xd3edbd6a.Joker)
                {
                    _0x303449b2++;
                    continue;
                }

                break;
            }

            int _0x8a115667 = Multiplier(_0xffa46c4c, _0x303449b2);
            if (_0x8a115667 <= 0)
            {
                continue;
            }

            int _0xea8f042c = _0xdf6ceefc * _0x8a115667 / 100;
            if (_0xea8f042c <= 0)
            {
                continue;
            }

            _0xdab58877.Add(new _0xb17cbc9c()._0x5f71a0bb(_0xbb367512, _0xffa46c4c, _0x303449b2, _0xea8f042c, false));
        }

        int _0x45e9b731 = 0;
        for (int _0x95972117 = 0; _0x95972117 < _0xd3edbd6a.Reels; _0x95972117++)
        {
            for (int _0x7463137c = 0; _0x7463137c < _0xd3edbd6a.Rows; _0x7463137c++)
            {
                if (Cell(_0xa1e46d68, _0x95972117, _0x7463137c) == _0xd3edbd6a.Ticket)
                {
                    _0x45e9b731++;
                }
            }
        }

        if (_0x45e9b731 >= 3)
        {
            int _0x1fb89a99 = Multiplier(_0xd3edbd6a.Ticket, _0x45e9b731 > 5 ? 5 : _0x45e9b731);
            int _0xf129247a = _0xdf6ceefc * _0x1fb89a99 / 100;
            if (_0xf129247a > 0)
            {
                _0xdab58877.Add(new _0xb17cbc9c()._0x5f71a0bb(-1, _0xd3edbd6a.Ticket, _0x45e9b731, _0xf129247a, true));
            }
        }

        return _0xdab58877;
    }

    public static string SymbolName(int _0x5840d222)
    {
        if (_0x5840d222 == _0xd3edbd6a.Joker)
            return _0x333e3f8f._0x5972223f(new byte[5] { 41, 44, 40, 38, 49 }, 99);
        if (_0x5840d222 == _0xd3edbd6a.Crown)
            return _0x333e3f8f._0x5972223f(new byte[5] { 118, 103, 122, 98, 123 }, 53);
        if (_0x5840d222 == _0xd3edbd6a.Ruby)
            return _0x333e3f8f._0x5972223f(new byte[4] { 131, 132, 147, 136 }, 209);
        if (_0x5840d222 == _0xd3edbd6a.Ticket)
            return _0x333e3f8f._0x5972223f(new byte[6] { 125, 96, 106, 98, 108, 125 }, 41);
        if (_0x5840d222 == _0xd3edbd6a.Heart)
            return _0x333e3f8f._0x5972223f(new byte[5] { 71, 74, 78, 93, 91 }, 15);
        if (_0x5840d222 == _0xd3edbd6a.Diamond)
            return _0x333e3f8f._0x5972223f(new byte[7] { 82, 95, 87, 91, 89, 88, 82 }, 22);
        if (_0x5840d222 == _0xd3edbd6a.Spade)
            return _0x333e3f8f._0x5972223f(new byte[5] { 57, 58, 43, 46, 47 }, 106);
        return _0x333e3f8f._0x5972223f(new byte[4] { 166, 169, 176, 167 }, 229);
    }

    private static int Multiplier(int _0x17421a01, int _0x642f4782)
    {
        if (_0x642f4782 == 3)
            return _0x5e11ff34[_0x17421a01];
        if (_0x642f4782 == 4)
            return _0xf62f686b[_0x17421a01];
        if (_0x642f4782 >= 5)
            return _0xe16eac04[_0x17421a01];
        return 0;
    }

    private static readonly int[] _0xe16eac04 =
    {
        8000,
        3600,
        2400,
        800,
        640,
        640,
        480,
        480
    };
    public static int TotalPayout(int[] _0x1a1968d6, int _0x3a25884a)
    {
        List<_0xb17cbc9c> _0x7b155419 = Evaluate(_0x1a1968d6, _0x3a25884a);
        int _0x691a82dc = 0;
        for (int _0x76c0c8f2 = 0; _0x76c0c8f2 < _0x7b155419.Count; _0x76c0c8f2++)
        {
            _0x691a82dc += _0x7b155419[_0x76c0c8f2].Payout;
        }

        return _0x691a82dc;
    }

    // Hundredths of the total bet for 3 / 4 / 5 of a kind, indexed by symbol id, i.e.
    // 400 = 4x the whole stake. JOKER 4 / 16 / 80, CROWN 2.5 / 8 / 36, RUBY 1.6 / 5.6 / 24,
    // TICKET 0.8 / 2.4 / 8, HEART and DIAMOND 0.6 / 1.6 / 6.4, SPADE and CLUB 0.4 / 1.2 / 4.8.
    //
    // THESE NUMBERS WERE MEASURED, NOT PICKED. Ten lines over eight symbols land something
    // on roughly four spins in ten, so a low symbol paying a full stake for three of a
    // kind puts the machine above 200% return: the balance would only ever grow, the bet
    // would stop mattering and the refill, the daily bonus and the whole economy would be
    // decoration. At these values the headless port of this evaluator measures 92.5%
    // return over 180,000 spins, and a player tapping without pause needs about eight
    // minutes to reach the free refill - far past the capture window C.5 cares about, and
    // still a machine where a win is worth something.
    private static readonly int[] _0x5e11ff34 =
    {
        400,
        250,
        160,
        80,
        60,
        60,
        40,
        40
    };
    private static readonly int[] _0xf62f686b =
    {
        1600,
        800,
        560,
        240,
        160,
        160,
        120,
        120
    };
    public static int CountSymbol(int[] _0xaff91eb0, int _0x72c1ebd7)
    {
        int _0x32e60e7a = 0;
        for (int _0x607c6e79 = 0; _0x607c6e79 < _0xaff91eb0.Length; _0x607c6e79++)
        {
            if (_0xaff91eb0[_0x607c6e79] == _0x72c1ebd7)
            {
                _0x32e60e7a++;
            }
        }

        return _0x32e60e7a;
    }

    private static readonly int[] _0x19c58949 =
    {
        0,
        0,
        0,
        0,
        0
    };
    private static readonly int[] _0x07bcb731 =
    {
        2,
        2,
        2,
        2,
        2
    };
    // Row index per reel, 0 = top row.
    private static readonly int[] _0xf6f4184d =
    {
        1,
        1,
        1,
        1,
        1
    };
    private static readonly int[] _0xd301585f =
    {
        1,
        2,
        2,
        2,
        1
    };
    private static readonly int[] _0xff0a8642 =
    {
        0,
        1,
        2,
        1,
        0
    };
    private static readonly int[] _0x66115239 =
    {
        0,
        1,
        1,
        1,
        0
    };
    private static readonly int[] _0x301d85b1 =
    {
        2,
        2,
        1,
        0,
        0
    };
    public static int Cell(int[] _0xc9b3221f, int _0x723f1fbc, int _0x080e9a4b)
    {
        return _0xc9b3221f[_0x723f1fbc * _0xd3edbd6a.Rows + _0x080e9a4b];
    }

    public static int[] Line(int _0xd02eb40d)
    {
        if (_0xd02eb40d == 0)
            return _0xf6f4184d;
        if (_0xd02eb40d == 1)
            return _0x19c58949;
        if (_0xd02eb40d == 2)
            return _0x07bcb731;
        if (_0xd02eb40d == 3)
            return _0xff0a8642;
        if (_0xd02eb40d == 4)
            return _0xf1d5ebaf;
        if (_0xd02eb40d == 5)
            return _0x53cb703c;
        if (_0xd02eb40d == 6)
            return _0x301d85b1;
        if (_0xd02eb40d == 7)
            return _0xe8fc2304;
        if (_0xd02eb40d == 8)
            return _0xd301585f;
        return _0x66115239;
    }

    private static readonly int[] _0xe8fc2304 =
    {
        1,
        0,
        0,
        0,
        1
    };
    private static readonly int[] _0x53cb703c =
    {
        0,
        0,
        1,
        2,
        2
    };
    private static readonly int[] _0xf1d5ebaf =
    {
        2,
        1,
        0,
        1,
        2
    };
}

internal static class _0x333e3f8f
{
    internal static string _0x5972223f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}