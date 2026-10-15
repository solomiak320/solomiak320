using TMPro;
using UnityEngine;
using UnityEngine.UI;

// Stateless UGUI builder. No state, no singleton, no Update.
//
// SIGNATURE ORDER, written down so a plate fill and a text tint can never be swapped
// (C.14 - that swap is the classic failure):
//   Plate  (parent, label, centre, size, face, FILL colour, ppu)
//   Action (parent, label, centre, size, face, FILL colour, ppu)      -> returns Button
//   Caption(parent, label, font, body, size, TEXT tint, centre, box, align)
// Anything called "fill" paints a surface; anything called "tint" paints glyphs and is
// always one of Cream / Gold / GoldLight / Lilac.
//
// Coordinates are panel units of DefaultPanel/Content: 1242 x 2688, origin at the
// centre. Fraction helpers convert the design document's "fraction of the canvas,
// measured from the bottom" into anchoredPosition.
public static class _0x0bb64a0b
{
    // Primary CTA: gold-rimmed royal plate, caption drawn LAST so the plate can never
    // cover it (E.1 - hierarchy order is draw order).
    public static Button Cta(RectTransform _0x9dfe762c, string _0x8b861316, TMP_FontAsset _0xfac48a07, string _0x0ad26958, Vector2 _0xa3943c27, Vector2 _0x87ea3553, Sprite _0xa149ce48, float _0x81771a08)
    {
        Button _0x095837ec = Action(_0x9dfe762c, _0x8b861316, _0xa3943c27, _0x87ea3553, _0xa149ce48, _0x0d231d8c.RoyalDeep, RadiusCard);
        RectTransform _0x1d5b70e5 = _0x095837ec.GetComponent<RectTransform>();
        Image _0xd41ff667 = Plate(_0x1d5b70e5, _0x4aa55945._0x55286d4d(new byte[3] { 21, 46, 42 }, 71), Vector2.zero, new Vector2(_0x87ea3553.x - 10f, _0x87ea3553.y - 10f), _0xa149ce48, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.0f), RadiusCard);
        _0xd41ff667.color = _0x0d231d8c.Fade(_0x0d231d8c.GoldLight, 0.22f);
        Caption(_0x1d5b70e5, _0x4aa55945._0x55286d4d(new byte[5] { 51, 30, 29, 26, 19 }, 127), _0xfac48a07, _0x0ad26958, _0x81771a08, _0x0d231d8c.Cream, Vector2.zero, new Vector2(_0x87ea3553.x - 80f, _0x87ea3553.y - 36f), TextAlignmentOptions.Center);
        return _0x095837ec;
    }

    // Square icon button (back, pause, close). Icon is a fixed square with preserveAspect,
    // never positioned absolutely, never a different size between buttons of one class.
    public static Button IconAction(RectTransform _0xfbbe94ff, string _0x2346d24f, Vector2 _0x1e87e53d, float _0xc8e39401, Sprite _0x3e9b1b0a, Sprite _0x3b2d6f7b, float _0xa3e54814, Color _0x17aa06f7)
    {
        Button _0xceeb328f = Action(_0xfbbe94ff, _0x2346d24f, _0x1e87e53d, new Vector2(_0xc8e39401, _0xc8e39401), _0x3e9b1b0a, _0x17aa06f7, RadiusChip);
        RectTransform _0x77ebcd17 = _0xceeb328f.GetComponent<RectTransform>();
        Plate(_0x77ebcd17, _0x4aa55945._0x55286d4d(new byte[4] { 97, 64, 67, 65 }, 36), Vector2.zero, new Vector2(_0xc8e39401 - 6f, _0xc8e39401 - 6f), _0x3e9b1b0a, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.34f), RadiusChip);
        Picture(_0x77ebcd17, _0x4aa55945._0x55286d4d(new byte[4] { 164, 142, 130, 131 }, 237), Vector2.zero, new Vector2(_0xa3e54814, _0xa3e54814), _0x3b2d6f7b, _0x0d231d8c.Gold);
        return _0xceeb328f;
    }

    public static Image Wash(RectTransform _0xe97a9aa0, string _0xdb0c5644, Color _0x2ed69cd4)
    {
        RectTransform _0x3d5ab59f = Stretch(_0xe97a9aa0, _0xdb0c5644);
        Image _0x0a3d6345 = _0x3d5ab59f.gameObject.AddComponent<Image>();
        _0x0a3d6345.color = _0x2ed69cd4;
        _0x0a3d6345.type = Image.Type.Simple;
        _0x0a3d6345.raycastTarget = false;
        return _0x0a3d6345;
    }

    public const float PanelWidth = 1242f;
    // Secondary: quiet surface, gold hairline, cream caption.
    public static Button Minor(RectTransform _0x8a6bf508, string _0x1d3397ac, TMP_FontAsset _0xd11713b1, string _0xdb262a34, Vector2 _0xe893ab76, Vector2 _0x86436361, Sprite _0x4db8d8ff, float _0x9d7dc3f0)
    {
        Button _0x590b80cc = Action(_0x8a6bf508, _0x1d3397ac, _0xe893ab76, _0x86436361, _0x4db8d8ff, _0x0d231d8c.Raised, RadiusChip);
        RectTransform _0x44848254 = _0x590b80cc.GetComponent<RectTransform>();
        Plate(_0x44848254, _0x4aa55945._0x55286d4d(new byte[4] { 131, 162, 161, 163 }, 198), Vector2.zero, new Vector2(_0x86436361.x - 6f, _0x86436361.y - 6f), _0x4db8d8ff, _0x0d231d8c.Fade(_0x0d231d8c.Gold, 0.30f), RadiusChip);
        Caption(_0x44848254, _0x4aa55945._0x55286d4d(new byte[5] { 85, 120, 123, 124, 117 }, 25), _0xd11713b1, _0xdb262a34, _0x9d7dc3f0, _0x0d231d8c.Cream, Vector2.zero, new Vector2(_0x86436361.x - 40f, _0x86436361.y - 26f), TextAlignmentOptions.Center);
        return _0x590b80cc;
    }

    public const float RadiusChip = 4.6f; // ~28 units - chips, pills, small buttons
    public static Vector2 At(float _0x214149c8, float _0xf6773b27)
    {
        return new Vector2((_0x214149c8 - 0.5f) * PanelWidth, (_0xf6773b27 - 0.5f) * PanelHeight);
    }

    public const float TextWidth = 700f;
    public const float RadiusTile = 6.4f; // ~20 units - reel cells, pips
    // Two-band row (C.25): an indicator gutter and a text column that never share x.
    // gutterCentre 110, gutterWidth 84, text column left 198 wide 700 - checked:
    // 198 >= 110 + 42 + 24 and 198 + 700 = 898 <= rowWidth - 40 for rowWidth 1050+.
    public const float GutterCentre = 110f;
    public static Vector2 TextAt(float _0x14cda0fb, float _0xa7f69f53)
    {
        return new Vector2(TextLeft + TextWidth * 0.5f - _0x14cda0fb * 0.5f, _0xa7f69f53);
    }

    public const float TextLeft = 198f;
    // Content art: the PNG aspect is honoured, never stretched (F.2a).
    public static Image Picture(RectTransform _0x7d3a9635, string _0xb635937a, Vector2 _0x5c14f9f2, Vector2 _0xcb54ef88, Sprite _0x22953d56, Color _0x499dcef6)
    {
        RectTransform _0xe234c907 = Node(_0x7d3a9635, _0xb635937a, _0x5c14f9f2, _0xcb54ef88);
        Image _0x9a88b925 = _0xe234c907.gameObject.AddComponent<Image>();
        _0x9a88b925.sprite = _0x22953d56;
        _0x9a88b925.color = _0x499dcef6;
        _0x9a88b925.type = Image.Type.Simple;
        _0x9a88b925.preserveAspect = true;
        _0x9a88b925.raycastTarget = false;
        return _0x9a88b925;
    }

    public static string Thousands(int _0x9a70c33b)
    {
        int _0xc0ab7bc7 = _0x9a70c33b < 0 ? -_0x9a70c33b : _0x9a70c33b;
        string _0xb207e901 = _0xc0ab7bc7.ToString();
        string _0x18997431 = string.Empty;
        int _0x2dda2990 = 0;
        for (int _0xed43d457 = _0xb207e901.Length - 1; _0xed43d457 >= 0; _0xed43d457--)
        {
            _0x18997431 = _0xb207e901[_0xed43d457] + _0x18997431;
            _0x2dda2990++;
            if (_0x2dda2990 % 3 == 0 && _0xed43d457 > 0)
            {
                _0x18997431 = _0x4aa55945._0x55286d4d(new byte[1] { 54 }, 26) + _0x18997431;
            }
        }

        return _0x9a70c33b < 0 ? _0x4aa55945._0x55286d4d(new byte[1] { 189 }, 144) + _0x18997431 : _0x18997431;
    }

    // A flat tinted surface. "face" is always a 9-slice sprite (the template's
    // sliced_solid_round or the generated button plate) so the corner radius is real.
    public static Image Plate(RectTransform _0xca438cf8, string _0x8c46d5fb, Vector2 _0x1e0732e6, Vector2 _0x8ba99338, Sprite _0xde6b44a1, Color _0xa23e6278, float _0x3787d443)
    {
        RectTransform _0x6747cf8d = Node(_0xca438cf8, _0x8c46d5fb, _0x1e0732e6, _0x8ba99338);
        Image _0x251b9d07 = _0x6747cf8d.gameObject.AddComponent<Image>();
        _0x251b9d07.sprite = _0xde6b44a1;
        _0x251b9d07.color = _0xa23e6278;
        _0x251b9d07.raycastTarget = false;
        if (_0xde6b44a1 != null)
        {
            _0x251b9d07.type = Image.Type.Sliced;
            _0x251b9d07.pixelsPerUnitMultiplier = Ppu(_0x3787d443, _0x8ba99338);
        }
        else
        {
            _0x251b9d07.type = Image.Type.Simple;
        }

        return _0x251b9d07;
    }

    public static Button Action(RectTransform _0x18a9e8a7, string _0xb165b723, Vector2 _0x09ada83b, Vector2 _0x658960e9, Sprite _0x2c73cad2, Color _0xe96c4420, float _0x5607b9c2)
    {
        RectTransform _0xd8c29ba4 = Node(_0x18a9e8a7, _0xb165b723, _0x09ada83b, _0x658960e9);
        Image _0xd7c99800 = _0xd8c29ba4.gameObject.AddComponent<Image>();
        _0xd7c99800.sprite = _0x2c73cad2;
        _0xd7c99800.color = _0xe96c4420;
        _0xd7c99800.type = Image.Type.Sliced;
        _0xd7c99800.pixelsPerUnitMultiplier = Ppu(_0x5607b9c2, _0x658960e9);
        _0xd7c99800.raycastTarget = true;
        Button _0x41abc11c = _0xd8c29ba4.gameObject.AddComponent<Button>();
        _0x41abc11c.targetGraphic = _0xd7c99800;
        ColorBlock _0xe1da9f73 = _0x41abc11c.colors;
        _0xe1da9f73.normalColor = new Color(1f, 1f, 1f, 1f);
        _0xe1da9f73.highlightedColor = new Color(1f, 0.96f, 0.82f, 1f);
        _0xe1da9f73.pressedColor = new Color(0.74f, 0.70f, 0.86f, 1f);
        _0xe1da9f73.selectedColor = new Color(1f, 1f, 1f, 1f);
        _0xe1da9f73.disabledColor = new Color(0.55f, 0.50f, 0.62f, 0.70f);
        _0xe1da9f73.fadeDuration = 0.08f;
        _0x41abc11c.colors = _0xe1da9f73;
        return _0x41abc11c;
    }

    // Dresses a TEMPLATE button that renders nothing of its own. The scene's
    // EMPTY_BASE_BUTTON switches every BASE_PANEL layer off and the one survivor, Fade,
    // is driven by the Button's ColorTint (transparent at rest, a white flash when
    // pressed - free press feedback, C.7). So the face is OUR node, added as a child of
    // the button rect: later siblings draw on top, caption LAST of all (E.1), and every
    // piece is raycastTarget = false so the tap still reaches the template Button and its
    // LoadSceneButton driver. The template's own caption ships inactive, so exactly one
    // PLAY literal remains on screen.
    public static TextMeshProUGUI DressButton(RectTransform _0xe5e31e20, TMP_FontAsset _0x3f1d99a1, string _0x144be73f, Sprite _0x1812a0b9, float _0x42d14b71, Color _0x3da23517, Color _0x06053320)
    {
        Vector2 _0xb8c259fc = _0xe5e31e20.rect.size;
        if (_0xb8c259fc.x < 1f || _0xb8c259fc.y < 1f)
        {
            _0xb8c259fc = _0xe5e31e20.sizeDelta;
        }

        Plate(_0xe5e31e20, _0x4aa55945._0x55286d4d(new byte[6] { 139, 176, 185, 188, 183, 175 }, 216), new Vector2(0f, -12f), new Vector2(_0xb8c259fc.x + 8f, _0xb8c259fc.y + 8f), _0x1812a0b9, _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.55f), RadiusCard);
        Plate(_0xe5e31e20, _0x4aa55945._0x55286d4d(new byte[4] { 41, 8, 11, 9 }, 108), Vector2.zero, _0xb8c259fc, _0x1812a0b9, _0x0d231d8c.Gold, RadiusCard);
        Plate(_0xe5e31e20, _0x4aa55945._0x55286d4d(new byte[4] { 67, 100, 102, 96 }, 5), Vector2.zero, new Vector2(_0xb8c259fc.x - 10f, _0xb8c259fc.y - 10f), _0x1812a0b9, _0x3da23517, RadiusCard);
        Plate(_0xe5e31e20, _0x4aa55945._0x55286d4d(new byte[5] { 180, 143, 130, 130, 137 }, 231), new Vector2(0f, _0xb8c259fc.y * 0.24f), new Vector2(_0xb8c259fc.x - 34f, _0xb8c259fc.y * 0.42f), _0x1812a0b9, _0x0d231d8c.Fade(_0x0d231d8c.GoldLight, 0.20f), RadiusCard);
        return Caption(_0xe5e31e20, _0x4aa55945._0x55286d4d(new byte[5] { 158, 179, 176, 183, 190 }, 210), _0x3f1d99a1, _0x144be73f, _0x42d14b71, _0x06053320, Vector2.zero, new Vector2(_0xb8c259fc.x - 80f, _0xb8c259fc.y - 40f), TextAlignmentOptions.Center);
    }

    // 9-SLICE SAFETY. sliced_solid_round carries a 127 px border on every side, and a
    // 9-slice border NEVER shrinks - only the centre does. So a plate drawn shorter than
    // 2 * 127 / multiplier renders as a crooked sliver instead of a rounded surface, and
    // nothing in the gates catches it. Every face takes its multiplier from here: the
    // value a caller passes is only the FLOOR (how round a large plate should be), and a
    // small rect raises it automatically. 300 / side leaves the border at 42% of the
    // side, i.e. an 18% margin under the 254-unit break-even.
    public const float SliceBorder = 127f;
    public static Vector2 TextBox(float height)
    {
        return new Vector2(TextWidth, height);
    }

    public static RectTransform Stretch(RectTransform _0xeec57795, string _0x3619bde9)
    {
        GameObject _0x3f02f0db = new GameObject(_0x3619bde9, typeof(RectTransform));
        RectTransform _0x488fb51d = _0x3f02f0db.GetComponent<RectTransform>();
        _0x488fb51d.SetParent(_0xeec57795, false);
        _0x488fb51d.anchorMin = Vector2.zero;
        _0x488fb51d.anchorMax = Vector2.one;
        _0x488fb51d.offsetMin = Vector2.zero;
        _0x488fb51d.offsetMax = Vector2.zero;
        _0x488fb51d.localScale = Vector3.one;
        return _0x488fb51d;
    }

    public const float PanelHeight = 2688f;
    // Word wrap OFF, line breaks by hand, autosize ALWAYS on, floor 24 (C.10 / C.12).
    public static TextMeshProUGUI Caption(RectTransform _0xd77033d2, string _0xd520454b, TMP_FontAsset _0xc236ebd5, string _0xb0fbdd46, float _0xadc2b3bf, Color _0x9f1801cb, Vector2 _0x5121376e, Vector2 _0x2bfcdce9, TextAlignmentOptions _0xb5ff2ca2)
    {
        RectTransform _0x1d6830f3 = Node(_0xd77033d2, _0xd520454b, _0x5121376e, _0x2bfcdce9);
        TextMeshProUGUI _0xddf76cee = _0x1d6830f3.gameObject.AddComponent<TextMeshProUGUI>();
        if (_0xc236ebd5 != null)
        {
            _0xddf76cee.font = _0xc236ebd5;
        }

        _0xddf76cee.text = _0xb0fbdd46;
        _0xddf76cee.alignment = _0xb5ff2ca2;
        _0xddf76cee.color = _0x9f1801cb;
        _0xddf76cee.raycastTarget = false;
        _0xf5cbd7d1.Apply(_0xddf76cee, _0xadc2b3bf);
        return _0xddf76cee;
    }

    public static Vector2 GutterAt(float _0xd130526f, float _0x7e197a65)
    {
        return new Vector2(GutterCentre - _0xd130526f * 0.5f, _0x7e197a65);
    }

    public static RectTransform Node(RectTransform _0x9f26c5ca, string _0xb12c0e48, Vector2 _0x7fdead55, Vector2 _0xde377b7e)
    {
        GameObject _0x577e3650 = new GameObject(_0xb12c0e48, typeof(RectTransform));
        RectTransform _0xf4eaeaa3 = _0x577e3650.GetComponent<RectTransform>();
        _0xf4eaeaa3.SetParent(_0x9f26c5ca, false);
        _0xf4eaeaa3.anchorMin = new Vector2(0.5f, 0.5f);
        _0xf4eaeaa3.anchorMax = new Vector2(0.5f, 0.5f);
        _0xf4eaeaa3.pivot = new Vector2(0.5f, 0.5f);
        _0xf4eaeaa3.anchoredPosition = _0x7fdead55;
        _0xf4eaeaa3.sizeDelta = _0xde377b7e;
        _0xf4eaeaa3.localScale = Vector3.one;
        return _0xf4eaeaa3;
    }

    public static float Ppu(float _0xbe2dd5a3, Vector2 _0xc933fcc5)
    {
        float width = _0xc933fcc5.x < 0f ? -_0xc933fcc5.x : _0xc933fcc5.x;
        float height = _0xc933fcc5.y < 0f ? -_0xc933fcc5.y : _0xc933fcc5.y;
        float _0x523ae6c7 = width < height ? width : height;
        float _0x9ef88eae = _0xbe2dd5a3 < 1f ? 1f : _0xbe2dd5a3;
        if (_0x523ae6c7 <= 1f)
        {
            return _0x9ef88eae;
        }

        float _0x9fe0553e = 300f / _0x523ae6c7;
        return _0x9fe0553e > _0x9ef88eae ? _0x9fe0553e : _0x9ef88eae;
    }

    // A framed card: fill, then a thin gold edge, then a faint top gradient band.
    // Returns the BODY rect that content goes into.
    public static RectTransform Card(RectTransform _0xbc301575, string _0x6d33bf37, Vector2 _0x64c3c621, Vector2 _0x47764f1e, Sprite _0xfe9dc901, Color _0x02fd9dd1, float _0xdff2c85d)
    {
        RectTransform _0x4b538aa0 = Node(_0xbc301575, _0x6d33bf37, _0x64c3c621, _0x47764f1e);
        Plate(_0x4b538aa0, _0x4aa55945._0x55286d4d(new byte[6] { 171, 144, 153, 156, 151, 143 }, 248), new Vector2(0f, -10f), new Vector2(_0x47764f1e.x + 10f, _0x47764f1e.y + 10f), _0xfe9dc901, _0x0d231d8c.Fade(_0x0d231d8c.ShadowInk, 0.50f), _0xdff2c85d);
        Plate(_0x4b538aa0, _0x4aa55945._0x55286d4d(new byte[4] { 245, 212, 215, 213 }, 176), Vector2.zero, _0x47764f1e, _0xfe9dc901, _0x0d231d8c.Gold, _0xdff2c85d);
        Plate(_0x4b538aa0, _0x4aa55945._0x55286d4d(new byte[4] { 229, 202, 207, 207 }, 163), Vector2.zero, new Vector2(_0x47764f1e.x - 8f, _0x47764f1e.y - 8f), _0xfe9dc901, _0x02fd9dd1, _0xdff2c85d);
        Plate(_0x4b538aa0, _0x4aa55945._0x55286d4d(new byte[5] { 201, 242, 255, 255, 244 }, 154), new Vector2(0f, _0x47764f1e.y * 0.26f), new Vector2(_0x47764f1e.x - 24f, _0x47764f1e.y * 0.44f), _0xfe9dc901, _0x0d231d8c.Fade(_0x0d231d8c.Royal, 0.18f), _0xdff2c85d);
        RectTransform _0x70e70d46 = Stretch(_0x4b538aa0, _0x4aa55945._0x55286d4d(new byte[4] { 219, 246, 253, 224 }, 153));
        return _0x70e70d46;
    }

    // Sliced corner radius in panel units is 127 / multiplier (the template's
    // sliced_solid_round carries a 127 px border). Keep 2 * radius below the smallest
    // side of the rect or the 9-slice eats its own middle.
    public const float RadiusCard = 3.2f; // ~40 units - cards, pops, CTA plates
    public const float GutterWidth = 84f;
    public static Vector2 Size(float width, float height)
    {
        return new Vector2(width, height);
    }

    // Spawns a pre-configured content prefab (a reel cell, a flying coin): the Image on
    // it already carries preserveAspect and raycastTarget: 0 from the prefab file, so the
    // object is right the moment it appears and no runtime fix-up is needed (F.2). The
    // prefab arrives as a SERIALIZED reference; if one is ever missing the builder falls
    // back to an equivalent node rather than leaving a hole on screen.
    public static Image Spawn(RectTransform _0x84e03c10, GameObject _0x149faa08, string _0x59146e53, Vector2 _0xbc620655, Vector2 _0x1e01a8ca, Sprite _0xbce29b78, Color _0x49ec1884)
    {
        if (_0x149faa08 == null)
        {
            return Picture(_0x84e03c10, _0x59146e53, _0xbc620655, _0x1e01a8ca, _0xbce29b78, _0x49ec1884);
        }

        GameObject _0x93d1f9a4 = Object.Instantiate(_0x149faa08, _0x84e03c10, false);
        _0x93d1f9a4.name = _0x59146e53;
        RectTransform _0x8e863886 = _0x93d1f9a4.GetComponent<RectTransform>();
        if (_0x8e863886 != null)
        {
            _0x8e863886.anchorMin = new Vector2(0.5f, 0.5f);
            _0x8e863886.anchorMax = new Vector2(0.5f, 0.5f);
            _0x8e863886.pivot = new Vector2(0.5f, 0.5f);
            _0x8e863886.anchoredPosition = _0xbc620655;
            _0x8e863886.sizeDelta = _0x1e01a8ca;
            _0x8e863886.localScale = Vector3.one;
        }

        Image _0x6034ac3a = _0x93d1f9a4.GetComponent<Image>();
        if (_0x6034ac3a != null)
        {
            _0x6034ac3a.preserveAspect = true;
            _0x6034ac3a.sprite = _0xbce29b78;
            _0x6034ac3a.color = _0x49ec1884;
        }

        return _0x6034ac3a;
    }
}

internal static class _0x4aa55945
{
    internal static string _0x55286d4d(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}