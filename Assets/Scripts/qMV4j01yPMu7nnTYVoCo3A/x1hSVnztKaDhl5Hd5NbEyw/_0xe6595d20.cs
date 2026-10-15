using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Canvas))]
public class _0xe6595d20 : MonoBehaviour
{
    private RectTransform _0xb1bd7d67;
    private static readonly List<_0xe6595d20> _0x8b2977d2 = new();
    private static void ResolutionChanged()
    {
        _0x46af38a9.x = Screen.width;
        _0x46af38a9.y = Screen.height;
        _0x2feaad8a.Invoke();
    }

    private static bool _0x132f86aa;
    private void Awake()
    {
        if (!_0x8b2977d2.Contains(this))
            _0x8b2977d2.Add(this);
        this._0xdc41b57b = this.GetComponent<Canvas>();
        this._0xb1bd7d67 = this.GetComponent<RectTransform>();
        this._0x720de312 = this.transform.Find(_0x07dd3863._0x3baa3762(new byte[8] { 26, 40, 47, 44, 8, 59, 44, 40 }, 73)) as RectTransform;
        if (!_0x132f86aa)
        {
            _0x729a5525 = Screen.orientation;
            _0x46af38a9.x = Screen.width;
            _0x46af38a9.y = Screen.height;
            _0x7e92da80 = Screen.safeArea;
            _0x132f86aa = true;
        }

        this._0x9485efc5();
    }

    private void Update()
    {
        if (_0x8b2977d2[0] != this)
            return;
        if (Application.isMobilePlatform && Screen.orientation != _0x729a5525)
            OrientationChanged();
        if (Screen.safeArea != _0x7e92da80)
            SafeAreaChanged();
        if (Screen.width != _0x46af38a9.x || Screen.height != _0x46af38a9.y)
            ResolutionChanged();
    }

    private static void OrientationChanged()
    {
        _0x729a5525 = Screen.orientation;
        _0x46af38a9.x = Screen.width;
        _0x46af38a9.y = Screen.height;
        _0x2feaad8a.Invoke();
    }

    private Canvas _0xdc41b57b;
    private void OnDestroy()
    {
        if (_0x8b2977d2 != null && _0x8b2977d2.Contains(this))
            _0x8b2977d2.Remove(this);
    }

    private static Rect _0x7e92da80 = Rect.zero;
    private RectTransform _0x720de312;
    private static void SafeAreaChanged()
    {
        _0x7e92da80 = Screen.safeArea;
        for (int _0x657b6b56 = 0; _0x657b6b56 < _0x8b2977d2.Count; _0x657b6b56++)
            _0x8b2977d2[_0x657b6b56]._0x9485efc5();
    }

    private static Vector2 _0x46af38a9 = Vector2.zero;
    private void _0x9485efc5()
    {
        if (this._0x720de312 == null)
            return;
        Rect _0xc06cc067 = Screen.safeArea;
        Vector2 _0xbedebc81 = _0xc06cc067.position;
        Vector2 _0xe1563d5e = _0xc06cc067.position + _0xc06cc067.size;
        _0xbedebc81.x /= this._0xdc41b57b.pixelRect.width;
        _0xbedebc81.y /= this._0xdc41b57b.pixelRect.height;
        _0xe1563d5e.x /= this._0xdc41b57b.pixelRect.width;
        _0xe1563d5e.y /= this._0xdc41b57b.pixelRect.height;
        this._0x720de312.anchorMin = _0xbedebc81;
        this._0x720de312.anchorMax = _0xe1563d5e;
    }

    private static ScreenOrientation _0x729a5525 = ScreenOrientation.LandscapeLeft;
    private static UnityEvent _0x2feaad8a = new();
}

internal static class _0x07dd3863
{
    internal static string _0x3baa3762(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}