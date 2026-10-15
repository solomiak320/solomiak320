using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static _0xc3dbd8a4;

public class _0x05c8a753 : MonoBehaviour
{
    private static void ExitGame()
    {
        Application.Quit();
    }

    public void _0x7c8c6e4a(bool _0x28f29b5d)
    {
        this._0xe5c04bec = _0x28f29b5d;
        this._0x5726ffd5(!this._0xe5c04bec);
        Physics2D.simulationMode = this._0xe5c04bec ? SimulationMode2D.FixedUpdate : SimulationMode2D.Script;
        if (this.EnvironmentWithTweensToToggle != null)
            this._0xc64dacc8(this.EnvironmentWithTweensToToggle);
    }

    private void _0x639bd123()
    {
        IsAfterLevelComplete = true;
        Instance._0x8595e80b(_0x28f4af65.SCENE_0);
    }

    public static _0x0c2dc5f2 _0xe420109c => _0x0c2dc5f2.ALL_SCENES_SETTING_SINGLETONS[Instance._0x7d9d4bd8];

    private void _0x5726ffd5(bool _0xaa976a19)
    {
        Rigidbody2D[] _0x49a64529 = this.RootGameObject.GetComponentsInChildren<Rigidbody2D>(true);
        foreach (Rigidbody2D _0xa0c76a19 in _0x49a64529)
            if (_0xaa976a19)
                _0xa0c76a19.constraints = RigidbodyConstraints2D.FreezeAll;
            else
                _0xa0c76a19.constraints = RigidbodyConstraints2D.None;
    }

    public static bool IsAfterLevelComplete;
    public bool _0xe5c04bec { get; private set; }

    public Button ShowResetTutorialButton;
    private void Start()
    {
        if (this._0x7d9d4bd8 != _0x28f4af65.SCENE_0)
            Screen.orientation = ScreenOrientation.Portrait;
        this.DeleteProgressDataButton?.onClick.AddListener(() =>
        {
            PlayerPrefs.DeleteAll();
            //AudioController.Instance.UpdateMusics();
            //AudioController.Instance.UpdateSfxes();
            Instance._0x8595e80b(_0x28f4af65.SCENE_0);
        });
        this.ShowResetTutorialButton?.onClick.AddListener(() =>
        {
            _0xe420109c._0xa9ac1b34 = false;
            _0xe6d286ce.Instance._0x4f14b792();
            _0xa62f9119.Instance._0x1e9b02f7(_0x576642f8.TUTORIAL0);
        });
    }

    private static _0x0c2dc5f2 _0x153022c7 => _0x0c2dc5f2.ALL_SCENES_SETTING_SINGLETONS[0];

    public void _0xe0b5394f()
    {
        _0xe420109c._0xa9ac1b34 = true;
    }

    public void _0xeb7ed306()
    {
        foreach (_0x2d05dbe1 _0xafc7325b in this.MoneyCountContainers)
            _0xafc7325b._0xc84d5eb6();
    }

    public static _0x05c8a753 Instance;
    private static void MakeGrid(List<RectTransform> _0xbcbe02fc, AspectRatioFitter _0x373bc7ed, float _0x039d9556, int _0x86e5019d, int _0x879c0de5)
    {
        _0x373bc7ed.aspectMode = AspectRatioFitter.AspectMode.WidthControlsHeight;
        _0x373bc7ed.aspectRatio = _0x039d9556;
        foreach (RectTransform _0x55419f4c in _0xbcbe02fc)
        {
            int _0xb80a20b0 = _0x55419f4c.transform.GetSiblingIndex();
            _0x55419f4c.anchorMin = new Vector3(Mathf.FloorToInt((float)_0xb80a20b0 % _0x86e5019d) * (1f / _0x86e5019d), (_0x879c0de5 - (Mathf.FloorToInt((float)_0xb80a20b0 / _0x86e5019d) % _0x879c0de5 + 1f)) * (1f / _0x879c0de5));
            _0x55419f4c.anchorMax = new Vector3(Mathf.FloorToInt((float)_0xb80a20b0 % _0x86e5019d + 1f) * (1f / _0x86e5019d), (_0x879c0de5 - Mathf.FloorToInt((float)_0xb80a20b0 / _0x86e5019d) % _0x879c0de5) * (1f / _0x879c0de5));
            _0x55419f4c.offsetMin = Vector2.zero;
            _0x55419f4c.offsetMax = Vector2.zero;
        }
    }

    public Transform Environment;
    public Canvas MainCanvas;
    public Button DeleteProgressDataButton;
    private IEnumerator _0x57005b81(int _0x68ce079a)
    {
        _0xa62f9119.Instance._0x1e9b02f7(_0x576642f8.SPLASH);
        AsyncOperation _0xff3eb3d3 = SceneManager.LoadSceneAsync(_0x68ce079a);
        while (!_0xff3eb3d3.isDone)
            yield return null;
    }

    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x05c8a753>();
        this.RootGameObject = GameObject.FindWithTag(_0x900ba0a5._0x07d18656(new byte[4] { 164, 153, 153, 130 }, 246));
        if (this._0x7d9d4bd8 == _0x28f4af65.SCENE_0)
            this._0x7c8c6e4a(true);
        else
            this._0x7c8c6e4a(false);
        this.MoneyCountContainers = this.RootGameObject.GetComponentsInChildren<_0x2d05dbe1>(true).ToList();
    }

    private void _0xc64dacc8(Transform _0xc90432d0)
    {
        Transform[] _0x1e0a6e5e = _0xc90432d0.GetComponentsInChildren<Transform>();
        foreach (Transform _0xbcfb1e4c in _0x1e0a6e5e)
            if (_0xbcfb1e4c != null && DOTween.IsTweening(_0xbcfb1e4c))
            {
                if (this._0xe5c04bec)
                    DOTween.Play(_0xbcfb1e4c);
                else
                    DOTween.Pause(_0xbcfb1e4c);
            }
    }

    public void _0xde8591ab()
    {
        this._0x8595e80b(SceneManager.GetActiveScene().buildIndex);
    }

    private static _0x0c2dc5f2 GAME_INDEX_SETTINGS(int _0xf359e08a)
    {
        return _0x0c2dc5f2.ALL_SCENES_SETTING_SINGLETONS[_0xf359e08a];
    }

    public int _0x7d9d4bd8 => SceneManager.GetActiveScene().buildIndex;

    public Transform EnvironmentWithTweensToToggle;
    [HideInInspector]
    public List<_0x2d05dbe1> MoneyCountContainers = new();
    public void _0x8595e80b(int _0x5f11c82a)
    {
        //if (SceneManager.GetActiveScene().buildIndex == sceneIndex)
        //    AdsInitializer.Instance?.ShowAd();
        this.StartCoroutine(this._0x57005b81(_0x5f11c82a));
    }

    private IEnumerator _0x3a23b5ac(string _0x8879566c)
    {
        _0xa62f9119.Instance._0x1e9b02f7(_0x576642f8.SPLASH);
        //AudioController.Instance.SaveLastMusicTimes();
        AsyncOperation _0x9bc02960 = SceneManager.LoadSceneAsync(_0x8879566c);
        while (!_0x9bc02960.isDone)
            yield return null;
    }

    public static bool IsAfterLevelFailed = false;
    [HideInInspector]
    public GameObject RootGameObject; // tag - "Root"
}

internal static class _0x900ba0a5
{
    internal static string _0x07d18656(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}