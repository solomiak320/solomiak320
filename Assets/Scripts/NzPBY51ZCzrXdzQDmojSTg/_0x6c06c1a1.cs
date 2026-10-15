using TMPro;
using UnityEngine;

// Rule C.15. The template ships seven tutorial pages, every one of them carrying its own
// dummy copy, and anything this game leaves undressed goes to the store exactly as the
// template wrote it. This game explains itself with one permanent line in the game scene
// (C.6 - the control is a single tap), so SETUP_OBJECT.IsTutorialEnabled stays 0 and all
// seven pages are emptied at run time.
//
// The pages are NOT deactivated: the controllers address panels by index and a removed
// object breaks navigation. Clearing their text is enough, and it touches no template
// file (rule 00). No constructor (C.59).
public sealed class _0x6c06c1a1
{
    private void _0xd85a6002(int _0x7219932d)
    {
        if (_0x7219932d < 0 || _0x7219932d >= _0xa62f9119.Instance.Panels.Count)
        {
            return;
        }

        _0x2f6bc10c _0xb6624a6a = _0xa62f9119.Instance.Panels[_0x7219932d];
        if (_0xb6624a6a == null)
        {
            return;
        }

        TMP_Text[] _0xfb5d7d74 = _0xb6624a6a.GetComponentsInChildren<TMP_Text>(true);
        for (int _0xfc8065b7 = 0; _0xfc8065b7 < _0xfb5d7d74.Length; _0xfc8065b7++)
        {
            _0xf5cbd7d1.SetText(_0xfb5d7d74[_0xfc8065b7], string.Empty);
        }
    }

    public void _0xe6fed157()
    {
        if (_0xa62f9119.Instance == null || _0xa62f9119.Instance.Panels == null)
        {
            return;
        }

        int[] _0xd5da366d =
        {
            _0xc3dbd8a4._0x576642f8.TUTORIAL0,
            _0xc3dbd8a4._0x576642f8.TUTORIAL1,
            _0xc3dbd8a4._0x576642f8.TUTORIAL2,
            _0xc3dbd8a4._0x576642f8.TUTORIAL3,
            _0xc3dbd8a4._0x576642f8.TUTORIAL4,
            _0xc3dbd8a4._0x576642f8.TUTORIAL5,
            _0xc3dbd8a4._0x576642f8.TUTORIAL6
        };
        for (int _0xb736331e = 0; _0xb736331e < _0xd5da366d.Length; _0xb736331e++)
        {
            this._0xd85a6002(_0xd5da366d[_0xb736331e]);
        }
    }
}