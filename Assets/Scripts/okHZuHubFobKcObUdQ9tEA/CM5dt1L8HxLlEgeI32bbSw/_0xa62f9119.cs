using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc3dbd8a4;

public class _0xa62f9119 : MonoBehaviour
{
    private void Start()
    {
        this._0xcdea5cd2();
    }

    [HideInInspector]
    public List<int> LastPanelIndexes = new()
    {
        1
    };
    private void SwitchSplash()
    {
        if (_0x9d1cdd19.Instance.IsTutorialEnabled && !_0x05c8a753._0xe420109c._0xa9ac1b34)
            this._0x1e9b02f7(_0x576642f8.TUTORIAL0);
        else
            this._0x1e9b02f7(_0x576642f8.DEFAULT);
    }

    public int CurrentPanelIndex;
    private void _0xcdea5cd2()
    {
        this._0xad1e777c(_0x576642f8.SPLASH);
        if (_0x05c8a753.Instance._0x7d9d4bd8 == _0x28f4af65.SCENE_0)
        {
        }
        else
        {
            this.Invoke(nameof(this.SwitchSplash), _0x2f7b6011.Instance.DefaultAnimationTime);
        }
    }

    private void _0xad1e777c(int _0x4e723236)
    {
        this._0xf9a32f0f(_0x4e723236);
        this._0xd3a01bd4(_0x4e723236);
        this.CurrentPanelIndex = _0x4e723236;
        this.Panels[_0x4e723236]._0xed4eff13();
    }

    public void _0x1e9b02f7(int _0x30b80df5)
    {
        this._0xf9a32f0f(_0x30b80df5);
        this._0xd3a01bd4(_0x30b80df5);
        this.CurrentPanelIndex = _0x30b80df5;
        this.Panels[_0x30b80df5].Show();
    }

    public List<_0x2f6bc10c> Panels;
    public static _0xa62f9119 Instance;
    private void _0x55707188(int _0xa0386c7a)
    {
        this.LastPanelIndexes.Add(_0xa0386c7a);
        this.CurrentPanelIndex = _0xa0386c7a;
        for (int _0xb365e7b0 = 0; _0xb365e7b0 < this.Panels.Count; _0xb365e7b0++)
            if (_0xb365e7b0 != _0xa0386c7a && this.Panels[_0xb365e7b0] != null)
                this.Panels[_0xb365e7b0]._0xe43762e6();
    }

    public float ScaleDuration = 0.4f;
    public void _0x6acffd98()
    {
        this.LastPanelIndexes.RemoveAll(_0xe10579c2 => _0xe10579c2 == this.CurrentPanelIndex);
        int _0xd323b9c3 = this.LastPanelIndexes.Last();
        this._0xd3a01bd4(_0xd323b9c3);
        this._0x55707188(_0xd323b9c3);
        this.CurrentPanelIndex = _0xd323b9c3;
        this.Panels[_0xd323b9c3].Show();
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xa62f9119>();
    }

    public bool IsShowSplashOnStart = true;
    private void _0xd3a01bd4(int _0xaddaa956)
    {
        if (_0xaddaa956 == _0x576642f8.SPLASH)
            _0x2f7b6011.Instance._0x192b27e0();
        if (_0x05c8a753.Instance._0x7d9d4bd8 == _0x28f4af65.SCENE_0)
        {
        }
    }

    private _0x2f6bc10c _0xf71c46db(int _0x7fcfcaf6)
    {
        return this.Panels[_0x7fcfcaf6];
    }

    public float StaticBlurMaterialInitialValue;
    public void _0x829276e1(int _0xcf81760e)
    {
        if (_0xcf81760e == _0x576642f8.SPLASH && _0x05c8a753.Instance._0x7d9d4bd8 != _0x28f4af65.SCENE_0)
            _0x2f7b6011.Instance._0xf8368ed2();
        if (_0x05c8a753.Instance._0x7d9d4bd8 != _0x28f4af65.SCENE_0)
        {
            if (_0xcf81760e == _0x576642f8.SPLASH || _0xcf81760e == _0x576642f8.TUTORIAL0)
                _0x05c8a753.Instance._0x7c8c6e4a(false);
            else if (_0xcf81760e == _0x576642f8.DEFAULT)
                _0x05c8a753.Instance._0x7c8c6e4a(true);
        }
    }

    private void _0xf9a32f0f(int _0x13f9c982)
    {
        this.LastPanelIndexes.Add(_0x13f9c982);
        this.CurrentPanelIndex = _0x13f9c982;
        for (int _0x74d272ca = 0; _0x74d272ca < this.Panels.Count; _0x74d272ca++)
            if (_0x74d272ca != _0x13f9c982 && this.Panels[_0x74d272ca] != null)
                this.Panels[_0x74d272ca]._0xe43762e6();
    }
}