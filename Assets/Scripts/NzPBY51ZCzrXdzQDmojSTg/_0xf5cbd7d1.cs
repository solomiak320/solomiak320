using TMPro;
using UnityEngine;

// Rule C.10 for the text this game creates at run time. Stage 5c3 reads scenes and
// prefabs; a label built from C# is in neither, so everything it would have guaranteed
// has to be done here instead.
//
// Every caption in this game is light on purpose (C.14), so the one shared font material
// - whose outline is the dark Ink - is already the contrasting one. The dark-face branch
// below exists so that a future caption which does go dark still gets a readable outline
// rather than merging into its own.
public static class _0xf5cbd7d1
{
    // The readability floor of C.12 is 24 px on a 1080-wide reference. This canvas is
    // 1242 wide, so the same physical size is 24 * 1242 / 1080 = 27.6; 28 is the floor
    // used here and no caption in the game is ever allowed below it.
    public const float Floor = 28f;
    // Word wrap OFF, line breaks by hand, autosize ALWAYS on - counters and timers
    // included. The engine must never decide where a line ends, so the layout is
    // identical on every device; a line that does not fit gets another '\n' in the
    // string, never a lower minimum.
    public static void Apply(TMP_Text _0xdd46693d, float _0xc5544b43)
    {
        if (_0xdd46693d == null)
        {
            return;
        }

        float _0x46475c20 = _0xc5544b43 < Floor ? Floor : _0xc5544b43;
        _0xdd46693d.textWrappingMode = TextWrappingModes.NoWrap;
        _0xdd46693d.overflowMode = TextOverflowModes.Overflow;
        _0xdd46693d.enableAutoSizing = true;
        _0xdd46693d.fontSizeMin = Floor;
        _0xdd46693d.fontSizeMax = _0x46475c20;
        _0xdd46693d.fontSize = _0x46475c20;
        ApplyOutline(_0xdd46693d);
    }

    // Reading fontMaterial creates an INSTANCE of the material; the shared asset that
    // every other caption uses is left exactly as it was.
    public static void ApplyOutline(TMP_Text _0x58c87451)
    {
        if (_0x58c87451 == null)
        {
            return;
        }

        Color _0x6da33b70 = _0x58c87451.color;
        float _0x33eaa1cd = 0.299f * _0x6da33b70.r + 0.587f * _0x6da33b70.g + 0.114f * _0x6da33b70.b;
        if (_0x33eaa1cd >= 0.5f)
        {
            return;
        }

        Material _0xa302e16b = _0x58c87451.fontMaterial;
        if (_0xa302e16b == null)
        {
            return;
        }

        _0xa302e16b.SetColor(ShaderUtilities.ID_OutlineColor, _0x0d231d8c.Cream);
        _0xa302e16b.SetFloat(ShaderUtilities.ID_OutlineWidth, 0.18f);
    }

    public static void SetText(TMP_Text _0x6db86411, string _0x9e70bba2)
    {
        if (_0x6db86411 != null)
        {
            _0x6db86411.text = _0x9e70bba2;
        }
    }
}