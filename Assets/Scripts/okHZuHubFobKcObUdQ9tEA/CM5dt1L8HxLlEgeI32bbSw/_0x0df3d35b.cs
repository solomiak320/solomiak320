using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x0df3d35b : MonoBehaviour
{
    private void _0xd24cecc6()
    {
        this.IsGameEnd = true;
        _0x05c8a753.IsAfterLevelComplete = true;
    }

    private void Start()
    {
        this.IsGameEnd = false;
        this.TimeLeft = this._0x08f859fe;
        this.CurrentGameIndex = _0x05c8a753.Instance._0x7d9d4bd8;
        foreach (Button _0x7fed7b7b in this.HomeButtons)
            _0x7fed7b7b.onClick.AddListener(() =>
            {
                this._0x6326d148();
            });
        foreach (Button _0xfd3dbe72 in this.PauseButtons)
            _0xfd3dbe72.onClick.AddListener(() =>
            {
                _0x05c8a753.Instance._0x7c8c6e4a(false);
                _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.PAUSE);
            });
        this._0xad5d77de();
        this.LevelNumberText.ForEach(_0xcb42b951 => _0xcb42b951.text = $"LVL {_0x05c8a753._0xe420109c._0xda3cc4e9 + 1}");
        if (_0x9d1cdd19.Instance.IsTimerEnabled)
        {
            this._0x9343bfda();
            this.StartCoroutine(this._0x535b940c());
        }
    }

    [HideInInspector]
    public int TimeLeft;
    public void _0xf3104e3e()
    {
        if (!this.IsGameEnd)
        {
            this._0xd24cecc6();
            _0x05c8a753.IsAfterLevelComplete = true;
            _0x05c8a753.IsAfterLevelFailed = false;
            _0x8f94dcac _0xb497b905 = _0xe6d286ce.Instance._0x9f18a12f(_0xc3dbd8a4._0x92fa9eac.WIN).GetComponent<_0x8f94dcac>();
            if (_0x9d1cdd19.Instance.IsCheckScoreEnabled)
                _0xb497b905.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9900f6d8}";
            else
                _0xb497b905.ContentMainText.text = $"{this.ScoreCurrent}";
            if (_0x9d1cdd19.Instance.IsBestScoreEnabled)
            {
                if (this.ScoreCurrent > _0xc3dbd8a4._0x5833a5d8._0xe99fdd92)
                    _0xc3dbd8a4._0x5833a5d8._0xe99fdd92 = this.ScoreCurrent;
                _0xb497b905.ContentAdditionalText.text = $"{_0xc3dbd8a4._0x5833a5d8._0xe99fdd92}";
            }
            else
            {
                _0xb497b905.ContentAdditionalText.text = $"{this._0x68461ecd}";
                _0xc3dbd8a4._0x5833a5d8._0xe99fdd92 += this._0x68461ecd;
            }

            if (_0x9d1cdd19.Instance.IsLevelIncrementOnWin)
                ++_0x05c8a753._0xe420109c._0xda3cc4e9;
            _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.WIN);
        }
    }

    public void _0x160e9e97(int scoreToAdd)
    {
        if (!this.IsGameEnd)
        {
            this.ScoreCurrent += scoreToAdd;
            this._0xad5d77de();
            this._0x80f23e17();
        }
    }

    private void Awake()
    {
        _0x5db55b5e = this.gameObject.GetComponent<_0x0df3d35b>();
    }

    private int _0x68461ecd => this.ScoreCurrent;

    public void _0x36906a4d()
    {
        if (_0x9d1cdd19.Instance.IsOnlyWinGameEndEnabled)
            this._0xf3104e3e();
        if (!this.IsGameEnd)
        {
            this._0xd24cecc6();
            _0x05c8a753.IsAfterLevelComplete = false;
            _0x05c8a753.IsAfterLevelFailed = true;
            _0x8f94dcac _0xca00263d = _0xe6d286ce.Instance._0x9f18a12f(_0xc3dbd8a4._0x92fa9eac.LOSE).GetComponent<_0x8f94dcac>();
            if (_0x9d1cdd19.Instance.IsCheckScoreEnabled)
                _0xca00263d.ContentMainText.text = $"{this.ScoreCurrent}/{this._0x9900f6d8}";
            else
                _0xca00263d.ContentMainText.text = $"{this.ScoreCurrent}";
            _0xca00263d.ContentAdditionalText.text = $"{0}";
            _0xc3dbd8a4._0x5833a5d8._0xe99fdd92 += 0;
            _0xe6d286ce.Instance._0x66cf3aa5(_0xc3dbd8a4._0x92fa9eac.LOSE);
        }
    }

    private void _0xad5d77de()
    {
        if (_0x9d1cdd19.Instance.IsCheckScoreEnabled)
            this.ScoreText.ForEach(_0xcb42b951 => _0xcb42b951.text = $"{this.ScoreCurrent}/{this._0x9900f6d8}");
        else
            this.ScoreText.ForEach(_0xcb42b951 => _0xcb42b951.text = $"{this.ScoreCurrent}");
    }

    private void _0x80f23e17()
    {
        if (this.ScoreCurrent > _0x05c8a753._0xe420109c._0xfd83b1c9)
            _0x05c8a753._0xe420109c._0xfd83b1c9 = this.ScoreCurrent;
        if (_0x9d1cdd19.Instance.IsCheckScoreEnabled)
            if (this.ScoreCurrent >= this._0x9900f6d8)
                this._0xf3104e3e();
    }

    public List<Button> PauseButtons = new();
    private void _0x9343bfda()
    {
        this.TimerText.ForEach(_0xcb42b951 => _0xcb42b951.text = TimeSpan.FromSeconds(this.TimeLeft).ToString(_0xa9b2d57a._0x260f952f(new byte[6] { 30, 30, 47, 73, 0, 0 }, 115)));
    }

    private IEnumerator _0x535b940c()
    {
        this._0x9343bfda();
        while (!this.IsGameEnd && this.TimeLeft > 0 && _0x05c8a753.Instance._0x7d9d4bd8 == this.CurrentGameIndex)
        {
            yield return new WaitForSeconds(1f);
            if (_0x05c8a753.Instance._0xe5c04bec)
            {
                if (this.IsGameEnd)
                    break;
                this.TimeLeft--;
                this._0x9343bfda();
            }
        }

        if (!this.IsGameEnd)
            this._0x36906a4d();
    }

    public int CustomTimeInitial = 30;
    public List<TMP_Text> LevelNumberText = new();
    private int _0x08f859fe => this.CustomTimeInitial + _0x05c8a753._0xe420109c._0xda3cc4e9 * 10;

    [HideInInspector]
    public int ScoreCurrent;
    public List<Button> HomeButtons = new();
    [HideInInspector]
    public bool IsGameEnd;
    public List<TMP_Text> ScoreText = new();
    public int CustomTargetScore = 10;
    private static _0x0df3d35b _0x5db55b5e;
    public List<TMP_Text> TimerText = new();
    private int _0x9900f6d8 => this.CustomTargetScore + _0x05c8a753._0xe420109c._0xda3cc4e9 * 10;

    public List<TMP_Text> SubtitleText = new();
    private void _0xd286eba5()
    {
        if (this.ScoreCurrent >= this._0x9900f6d8)
            this._0xf3104e3e();
        else
            this._0x36906a4d();
    }

    [HideInInspector]
    public int CurrentGameIndex;
    public void _0x6326d148()
    {
        _0x05c8a753.Instance._0x7c8c6e4a(true);
        _0x05c8a753.Instance._0x8595e80b(_0xc3dbd8a4._0x28f4af65.SCENE_0);
    }
}

internal static class _0xa9b2d57a
{
    internal static string _0x260f952f(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}