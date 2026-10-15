using System.Collections.Generic;
using TMPro;
using UnityEngine;

// TmpContrastGuard.cs — staged into every Unity app by approve-pipeline-unity.sh
// (stage 5c3, rule C.14 in CLAUDE-unity.md). Do not edit the copy inside a project;
// edit scripts/lib/unity/TmpContrastGuard.cs.
//
// WHY: every TMP label gets an outline (C.10), and by default that outline is dark.
// A dark face colour on a dark outline merges into a smudge — the label is not
// readable on any backing (ANDROID-3627: PLAY drawn Deep #12151E on the #12151E
// outline read as a black blob). enforce-text-contrast.sh fixes colours SERIALISED
// in scenes/prefabs, but labels built at runtime from C# (UiKit.Cta, VaultUi.Caption,
// label.color = Palette.X ...) never reach a scene file, so that pass cannot see them.
//
// WHAT: after any TMP text is regenerated, compare its face colour with the outline
// colour of the material it actually renders with. Below WCAG 4.5:1 the face is
// blended toward white (dark outline) or black (light outline) until it reaches 7:1.
// Hue is kept; alpha is kept. A label whose outline was deliberately switched to a
// light colour (TextReadability-style per-label material) is measured against THAT
// outline, so intentionally dark text on a light rim is left alone. Labels without
// an outline are left alone too.
public sealed class _0x3705b96e : MonoBehaviour
{
    private const float TargetRatio = 7f;
    // A lambda held in a field, never the bare method group: Plana renames the method
    // declaration but not a method-group reference (verify-unity-buttons.sh, CS0103).
    // The field keeps Add and Remove on the same delegate instance.
    private System.Action<Object> _0x68fe32e3;
    private const float MinRatio = 4.5f;
    private void OnEnable()
    {
        if (this._0x68fe32e3 == null)
            this._0x68fe32e3 = _0xc2f3f892 => this._0xffbf5dfb(_0xc2f3f892);
        TMPro_EventManager.TEXT_CHANGED_EVENT.Add(this._0x68fe32e3);
    }

    // The event fires from inside the canvas rebuild. Changing the colour right there
    // would re-dirty the graphic mid-rebuild, which Unity rejects — so queue it and
    // apply in LateUpdate, which runs before the next frame's rebuild.
    private void _0xffbf5dfb(Object _0x22eb0c20)
    {
        TMP_Text _0xf5af2867 = _0x22eb0c20 as TMP_Text;
        if (_0xf5af2867 != null)
            this._0x6d77849a.Add(_0xf5af2867);
    }

    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    private static void Boot()
    {
        if (_0x60419796 != null)
            return;
        GameObject _0xadc7e687 = new GameObject(_0x61c64d8b._0xee3ad036(new byte[16] { 205, 244, 233, 218, 246, 247, 237, 235, 248, 234, 237, 222, 236, 248, 235, 253 }, 153));
        _0xadc7e687.hideFlags = HideFlags.HideInHierarchy;
        DontDestroyOnLoad(_0xadc7e687);
        _0x60419796 = _0xadc7e687.AddComponent<_0x3705b96e>();
    }

    private static float Ratio(Color _0x69e10c15, Color _0x75b5fccf)
    {
        float _0xa3508fb9 = Luminance(_0x69e10c15);
        float _0xa203c032 = Luminance(_0x75b5fccf);
        return (Mathf.Max(_0xa3508fb9, _0xa203c032) + 0.05f) / (Mathf.Min(_0xa3508fb9, _0xa203c032) + 0.05f);
    }

    private const float MinOutlineWidth = 0.01f;
    private static void Fix(TMP_Text _0x87058125)
    {
        if (_0x87058125 == null || !_0x87058125.isActiveAndEnabled)
            return;
        Material _0x8ad4361a = _0x87058125.fontSharedMaterial;
        if (_0x8ad4361a == null || !_0x8ad4361a.HasProperty(ShaderUtilities.ID_OutlineColor) || !_0x8ad4361a.HasProperty(ShaderUtilities.ID_OutlineWidth))
            return;
        if (_0x8ad4361a.GetFloat(ShaderUtilities.ID_OutlineWidth) < MinOutlineWidth)
            return;
        Color _0xa8e483a1 = _0x87058125.color;
        if (_0xa8e483a1.a <= 0f)
            return;
        Color _0x3e24e05c = _0x8ad4361a.GetColor(ShaderUtilities.ID_OutlineColor);
        if (Ratio(_0xa8e483a1, _0x3e24e05c) >= MinRatio)
            return;
        Color _0xa1e26627 = Luminance(_0x3e24e05c) < 0.5f ? Color.white : Color.black;
        Color _0xcd123bda;
        if (Ratio(_0xa1e26627, _0x3e24e05c) < TargetRatio)
        {
            _0xcd123bda = _0xa1e26627;
        }
        else
        {
            // Smallest blend that reaches the target: contrast grows monotonically
            // with t, so a short bisection keeps as much of the hue as possible.
            float _0x3b91b76d = 0f;
            float _0x78c48822 = 1f;
            for (int _0xdb4b28de = 0; _0xdb4b28de < 20; _0xdb4b28de++)
            {
                float _0x0f24c272 = (_0x3b91b76d + _0x78c48822) * 0.5f;
                if (Ratio(Color.Lerp(_0xa8e483a1, _0xa1e26627, _0x0f24c272), _0x3e24e05c) >= TargetRatio)
                    _0x78c48822 = _0x0f24c272;
                else
                    _0x3b91b76d = _0x0f24c272;
            }

            _0xcd123bda = Color.Lerp(_0xa8e483a1, _0xa1e26627, _0x78c48822);
        }

        _0xcd123bda.a = _0xa8e483a1.a;
        _0x87058125.color = _0xcd123bda;
    }

    private readonly List<TMP_Text> _0x04085268 = new List<TMP_Text>();
    private void OnDisable()
    {
        if (this._0x68fe32e3 != null)
            TMPro_EventManager.TEXT_CHANGED_EVENT.Remove(this._0x68fe32e3);
    }

    private readonly HashSet<TMP_Text> _0x6d77849a = new HashSet<TMP_Text>();
    private static float Linear(float _0x5857479e)
    {
        _0x5857479e = Mathf.Clamp01(_0x5857479e);
        return _0x5857479e <= 0.03928f ? _0x5857479e / 12.92f : Mathf.Pow((_0x5857479e + 0.055f) / 1.055f, 2.4f);
    }

    // WCAG relative luminance of an sRGB colour, and the contrast ratio of two.
    private static float Luminance(Color _0x92ac0dbc)
    {
        return 0.2126f * Linear(_0x92ac0dbc.r) + 0.7152f * Linear(_0x92ac0dbc.g) + 0.0722f * Linear(_0x92ac0dbc.b);
    }

    private static _0x3705b96e _0x60419796;
    private void LateUpdate()
    {
        if (this._0x6d77849a.Count == 0)
            return;
        this._0x04085268.Clear();
        this._0x04085268.AddRange(this._0x6d77849a);
        this._0x6d77849a.Clear();
        for (int _0x6bb90f25 = 0; _0x6bb90f25 < this._0x04085268.Count; _0x6bb90f25++)
            Fix(this._0x04085268[_0x6bb90f25]);
    }
}

internal static class _0x61c64d8b
{
    internal static string _0xee3ad036(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}