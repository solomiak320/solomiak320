using System;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public static class _0xc3dbd8a4
{
    public class _0x0c2dc5f2
    {
        private static readonly _0x0c2dc5f2 _0xd3496900 = new();
        public static readonly _0x0c2dc5f2[] ALL_SCENES_SETTING_SINGLETONS =
        {
            _0xd3496900,
            _0xd3496900,
            _0xd3496900,
        };
        private int _0xcdf76ead => 0;
        private int _0xb92d4e35 => 10;
        private string _0x15c10ee0 => _0x83ff439b._0x284aafc4(new byte[4] { 184, 144, 155, 128 }, 245);
        private string _0x645950ce => _0x83ff439b._0x284aafc4(new byte[8] { 224, 233, 250, 233, 224, 215, 156, 209 }, 172);

        private int _0xff320221
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x83ff439b._0x284aafc4(new byte[25] { 184, 142, 137, 137, 158, 149, 143, 188, 151, 148, 153, 154, 151, 184, 147, 154, 139, 143, 158, 137, 178, 149, 159, 158, 131 }, 251)))
                    PlayerPrefs.SetInt(_0x83ff439b._0x284aafc4(new byte[25] { 109, 91, 92, 92, 75, 64, 90, 105, 66, 65, 76, 79, 66, 109, 70, 79, 94, 90, 75, 92, 103, 64, 74, 75, 86 }, 46), 0);
                return PlayerPrefs.GetInt(_0x83ff439b._0x284aafc4(new byte[25] { 182, 128, 135, 135, 144, 155, 129, 178, 153, 154, 151, 148, 153, 182, 157, 148, 133, 129, 144, 135, 188, 155, 145, 144, 141 }, 245));
            }

            set => PlayerPrefs.SetInt(_0x83ff439b._0x284aafc4(new byte[25] { 177, 135, 128, 128, 151, 156, 134, 181, 158, 157, 144, 147, 158, 177, 154, 147, 130, 134, 151, 128, 187, 156, 150, 151, 138 }, 242), value);
        }

        public int _0xda3cc4e9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x15c10ee0}CurrentLevelIndex"))
                    PlayerPrefs.SetInt($"{this._0x15c10ee0}CurrentLevelIndex", 0);
                return PlayerPrefs.GetInt($"{this._0x15c10ee0}CurrentLevelIndex");
            }

            set => PlayerPrefs.SetInt($"{this._0x15c10ee0}CurrentLevelIndex", value);
        }

        public int _0xfd83b1c9
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x15c10ee0}BestScore"))
                    this._0xfd83b1c9 = 0;
                return PlayerPrefs.GetInt($"{this._0x15c10ee0}BestScore");
            }

            set => PlayerPrefs.SetInt($"{this._0x15c10ee0}BestScore", value);
        }

        public bool _0xa9ac1b34
        {
            get
            {
                if (!PlayerPrefs.HasKey($"{this._0x15c10ee0}IsGameTutorPassed"))
                    PlayerPrefs.SetInt($"{this._0x15c10ee0}IsGameTutorPassed", Convert.ToInt32(false));
                return PlayerPrefs.GetInt($"{this._0x15c10ee0}IsGameTutorPassed") == 1;
            }

            set => PlayerPrefs.SetInt($"{this._0x15c10ee0}IsGameTutorPassed", Convert.ToInt32(value));
        }
    }

    public static class _0x92fa9eac
    {
        public static readonly int PAUSE = 6;
        public static readonly int WIN = 7;
        public static readonly int LOSE = 8;
    }

    public static class _0x5833a5d8
    {
        public static int _0xe99fdd92
        {
            get
            {
                if (!PlayerPrefs.HasKey(_0x83ff439b._0x284aafc4(new byte[5] { 155, 183, 177, 182, 171 }, 216)))
                    PlayerPrefs.SetInt(_0x83ff439b._0x284aafc4(new byte[5] { 147, 191, 185, 190, 163 }, 208), 0);
                return PlayerPrefs.GetInt(_0x83ff439b._0x284aafc4(new byte[5] { 65, 109, 107, 108, 113 }, 2));
            }

            set
            {
                PlayerPrefs.SetInt(_0x83ff439b._0x284aafc4(new byte[5] { 122, 86, 80, 87, 74 }, 57), value);
                _0x05c8a753.Instance._0xeb7ed306();
            }
        }
    }

    public static class _0x28f4af65
    {
        public static readonly int SCENE_0 = 0;
        public static readonly int SCENE_1 = 1;
    }

    public static class _0x576642f8
    {
        public static readonly int SPLASH = 0;
        public static readonly int DEFAULT = 1;
        public static readonly int EMPTY = 2;
        public static readonly int TUTORIAL0 = 13;
        public static readonly int TUTORIAL1 = 14;
        public static readonly int TUTORIAL2 = 15;
        public static readonly int TUTORIAL3 = 16;
        public static readonly int TUTORIAL4 = 17;
        public static readonly int TUTORIAL5 = 18;
        public static readonly int TUTORIAL6 = 19;
    }
}

internal static class _0x83ff439b
{
    internal static string _0x284aafc4(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}