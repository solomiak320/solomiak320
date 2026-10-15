using System;
using TMPro;
using UnityEngine;

// Every sprite and the font the generated UI needs, in ONE serialized block so each
// director carries exactly one [SerializeField] and the scene YAML holds real
// {fileID, guid} references (no Resources.Load, no lookup by name).
// No constructor anywhere (C.59): plain fields, filled by the serializer.
//
// Surfaces are built from the TEMPLATE's own 9-slice plates (Round, Soft) rather than
// from a generated button plate. A generated 9-slice is a gamble: the model decides
// where its border really sits, and an ornate plate whose middle is not flat tiles into
// mush at 560x164. Everything generated here is CONTENT art - symbols, icons, the mark -
// drawn with preserveAspect, which is the one case the model cannot get wrong.
[Serializable]
public sealed class _0x41b355c2
{
    public Sprite Coin;
    public Sprite SymHeart;
    public Sprite Shard;
    public Sprite IconPause;
    public TMP_FontAsset Font;
    // Index order must match SpinRng's symbol ids.
    public Sprite _0x26facb78(int _0x96f94b83)
    {
        if (_0x96f94b83 == 0)
            return this.SymJoker;
        if (_0x96f94b83 == 1)
            return this.SymCrown;
        if (_0x96f94b83 == 2)
            return this.SymRuby;
        if (_0x96f94b83 == 3)
            return this.SymTicket;
        if (_0x96f94b83 == 4)
            return this.SymHeart;
        if (_0x96f94b83 == 5)
            return this.SymDiamond;
        if (_0x96f94b83 == 6)
            return this.SymSpade;
        return this.SymClub;
    }

    public Sprite Round; // template sliced_solid_round - every plate and card face
    public Sprite SymCrown;
    public Sprite SymDiamond;
    public Sprite SymSpade;
    public Sprite IconBack;
    public Sprite SymJoker;
    public Sprite IconClose;
    public Sprite Emblem;
    public Sprite SymClub;
    public Sprite Soft; // template shadow_sliced - soft drop shadows and glows
    public Sprite SymRuby;
    public Sprite SymTicket;
}