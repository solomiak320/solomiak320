using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Canvas))]
public class _0xd9b24e16 : MonoBehaviour
{
    private CanvasScaler _0x19e468e9;
    private RectTransform _0x34f2b79c;
    private static void SafeAreaChanged()
    {
        _0x98db66b2 = Screen.safeArea;
        ApplySafeAreaToAll();
    }

    private static bool _0x3352ba48;
    private void OnDestroy()
    {
        if (_0x5b92dcd3 != null && _0x5b92dcd3.Contains(this))
            _0x5b92dcd3.Remove(this);
    }

    private static void ApplySafeAreaToAll()
    {
        for (int _0x09a3f402 = 0; _0x09a3f402 < _0x5b92dcd3.Count; _0x09a3f402++)
            _0x5b92dcd3[_0x09a3f402]._0x9882add6();
    }

    private static void ResolutionChanged()
    {
        _0x0c5634c5.x = Screen.width;
        _0x0c5634c5.y = Screen.height;
        _0x98db66b2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x6d4d3d56.Invoke();
    }

    private static Rect _0x98db66b2 = Rect.zero;
    private static void OrientationChanged()
    {
        _0x22147157 = Screen.orientation;
        _0x0c5634c5.x = Screen.width;
        _0x0c5634c5.y = Screen.height;
        _0x98db66b2 = Screen.safeArea;
        ApplySafeAreaToAll();
        _0x6d4d3d56.Invoke();
    }

    private static ScreenOrientation _0x22147157 = ScreenOrientation.LandscapeLeft;
    private static Vector2 _0x0c5634c5 = Vector2.zero;
    private void Update()
    {
        if (_0x5b92dcd3.Count == 0 || _0x5b92dcd3[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x22147157)
            OrientationChanged();
        if (Screen.safeArea != _0x98db66b2)
            SafeAreaChanged();
        if (Screen.width != _0x0c5634c5.x || Screen.height != _0x0c5634c5.y)
            ResolutionChanged();
    }

    private static UnityEvent _0x6d4d3d56 = new();
    private Vector2 _0x088b07f0;
    private void Start()
    {
    }

    private Canvas _0x72ddff66;
    private void _0x9882add6()
    {
        if (this._0x34f2b79c == null)
            return;
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;
        if (screenWidth <= 0f || screenHeight <= 0f)
            return;
        Rect _0x119bbf7a = Screen.safeArea;
        Vector2 _0xa865fcc1 = _0x119bbf7a.position;
        Vector2 _0x0aff39b8 = _0x119bbf7a.position + _0x119bbf7a.size;
        _0xa865fcc1.x /= screenWidth;
        _0xa865fcc1.y /= screenHeight;
        _0x0aff39b8.x /= screenWidth;
        _0x0aff39b8.y /= screenHeight;
        this._0x34f2b79c.anchorMin = _0xa865fcc1;
        this._0x34f2b79c.anchorMax = _0x0aff39b8;
        this._0x34f2b79c.offsetMin = Vector2.zero;
        this._0x34f2b79c.offsetMax = Vector2.zero;
        if (this._0x19e468e9 == null)
            return;
        Vector2 _0x7c7b6acf = _0x0aff39b8 - _0xa865fcc1;
        float _0x88a3fe4f = 2f - _0x7c7b6acf.x;
        float _0x32653122 = 2f - _0x7c7b6acf.y;
        this._0x19e468e9.referenceResolution = this._0x088b07f0 * new Vector2(_0x88a3fe4f, _0x32653122);
    }

    private void Awake()
    {
        if (!_0x5b92dcd3.Contains(this))
            _0x5b92dcd3.Add(this);
        this._0x72ddff66 = this.GetComponent<Canvas>();
        this._0x19e468e9 = this.GetComponent<CanvasScaler>();
        if (this._0x19e468e9 != null)
            this._0x088b07f0 = this._0x19e468e9.referenceResolution;
        this._0x0a69bb37 = this.GetComponent<RectTransform>();
        this._0x34f2b79c = this.transform.Find(_0x5e7be131._0x5b3d8814(new byte[8] { 168, 154, 157, 158, 186, 137, 158, 154 }, 251)) as RectTransform;
        if (!_0x3352ba48)
        {
            _0x22147157 = Screen.orientation;
            _0x0c5634c5.x = Screen.width;
            _0x0c5634c5.y = Screen.height;
            _0x98db66b2 = Screen.safeArea;
            _0x3352ba48 = true;
        }

        this._0x9882add6();
    }

    private RectTransform _0x0a69bb37;
    private static readonly List<_0xd9b24e16> _0x5b92dcd3 = new();
}

internal static class _0x5e7be131
{
    internal static string _0x5b3d8814(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}