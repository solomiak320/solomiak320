using System.Linq;
using UnityEngine;
using UnityEngine.InputSystem.EnhancedTouch;
using Touch = UnityEngine.InputSystem.EnhancedTouch.Touch;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class _0x8d4dbe02 : MonoBehaviour
{
    private void _0xbf10a053(Touch? _0x242c612b)
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
        {
            _0x242c612b = null;
            return;
        }

        int _0x806d1a86 = _0x242c612b.Value.touchId;
        _0x242c612b = Touch.activeTouches.FirstOrDefault(_0xd965e646 => _0xd965e646.touchId == _0x806d1a86);
        if (!this._0x312b38e1(_0x242c612b.Value))
            _0x242c612b = null;
    }

    private Touch? _0x34c977ad()
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
            return null;
        foreach (Touch _0x25103fc7 in Touch.activeTouches)
            if (_0x25103fc7.ended)
                if (this._0x312b38e1(_0x25103fc7))
                    return _0x25103fc7;
        return null;
    }

    private Touch? _0xd186b6a1(Bounds _0x0221695a, TouchPhase _0xb140b04a)
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
            return null;
        foreach (Touch _0xf3c9f568 in Touch.activeTouches)
            if (_0xf3c9f568.phase == _0xb140b04a)
            {
                Vector3 _0x306290a6 = Camera.main.ScreenToWorldPoint(_0xf3c9f568.screenPosition);
                Vector3 _0x442fd213 = new(_0x306290a6.x, _0x306290a6.y, _0x0221695a.center.z);
                if (_0x0221695a.Contains(_0x442fd213) && this._0x312b38e1(_0xf3c9f568))
                    return _0xf3c9f568;
            }

        return null;
    }

    private Touch? _0x484b92c4(Bounds _0x17344c06)
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
            return null;
        foreach (Touch _0xd4469fb2 in Touch.activeTouches)
            if (!_0xd4469fb2.ended)
            {
                Vector3 _0xb40baefa = Camera.main.ScreenToWorldPoint(_0xd4469fb2.screenPosition);
                Vector3 _0xfa4d2a58 = new(_0xb40baefa.x, _0xb40baefa.y, _0x17344c06.center.z);
                if (_0x17344c06.Contains(_0xfa4d2a58) && this._0x312b38e1(_0xd4469fb2))
                    return _0xd4469fb2;
            }

        return null;
    }

    private static _0x8d4dbe02 _0x455a26ee;
    private Touch? _0x8f7456bf()
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
            return null;
        foreach (Touch _0xe6dba7cc in Touch.activeTouches)
            if (!_0xe6dba7cc.ended)
                if (this._0x312b38e1(_0xe6dba7cc))
                    return _0xe6dba7cc;
        return null;
    }

    public BoxCollider2D CameraTouchBounds;
    private void Awake()
    {
        EnhancedTouchSupport.Enable();
        _0x455a26ee = this.gameObject.GetComponent<_0x8d4dbe02>();
    }

    private bool _0x312b38e1(Touch? _0xa1f615ea)
    {
        if (!_0xa1f615ea.HasValue)
            return false;
        Vector3 _0x868e850b = Camera.main.ScreenToWorldPoint(_0xa1f615ea.Value.screenPosition);
        Vector3 _0x15bb4af6 = _0x868e850b;
        _0x15bb4af6.z = this.CameraTouchBounds.transform.position.z;
        if (this.CameraTouchBounds.bounds.Contains(_0x15bb4af6))
            return true;
        _0xa1f615ea = null;
        return false;
    }

    private bool _0x5c8a5bb9(Touch? _0xce45a28d, Bounds _0x7c9dcb3d, TouchPhase _0x13d41bdd)
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
        {
            _0xce45a28d = null;
            return false;
        }

        if (_0xce45a28d != null)
            if (_0xce45a28d.Value.phase == _0x13d41bdd)
            {
                Vector3 _0x86a70a7a = Camera.main.ScreenToWorldPoint(_0xce45a28d.Value.screenPosition);
                Vector3 _0x20873497 = new(_0x86a70a7a.x, _0x86a70a7a.y, _0x7c9dcb3d.center.z);
                if (_0x7c9dcb3d.Contains(_0x20873497) && this._0x312b38e1(_0xce45a28d.Value))
                    return true;
            }

        return false;
    }

    private Touch? _0x90fb4568(Bounds _0x77124ac5)
    {
        if (!_0x05c8a753.Instance._0xe5c04bec)
            return null;
        foreach (Touch _0x548fceb4 in Touch.activeTouches)
            if (_0x548fceb4.ended)
            {
                Vector3 _0x08607d66 = Camera.main.ScreenToWorldPoint(_0x548fceb4.screenPosition);
                Vector3 _0xb398f5d7 = new(_0x08607d66.x, _0x08607d66.y, _0x77124ac5.center.z);
                if (_0x77124ac5.Contains(_0xb398f5d7) && this._0x312b38e1(_0x548fceb4))
                    return _0x548fceb4;
            }

        return null;
    }
}