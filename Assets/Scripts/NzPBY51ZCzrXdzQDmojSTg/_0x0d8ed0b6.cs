using UnityEngine;

// Shows and hides ONE view this game built itself. Generated code reliably controls only
// what it created, so every show/hide in this project goes through a gate like this one
// and never through an m_IsActive aimed at a template object (C.2).
//
// The gate deliberately does not live ON the object it switches off: a driver that
// disables its own GameObject stops running. No constructor (C.59).
public sealed class _0x0d8ed0b6
{
    public bool _0x4fd4b597
    {
        get
        {
            return this._0x4b13730a != null && this._0x4b13730a.activeSelf;
        }
    }

    private GameObject _0x4b13730a;
    public void _0x8e086730()
    {
        if (this._0x4b13730a != null)
        {
            this._0x4b13730a.SetActive(false);
        }
    }

    public _0x0d8ed0b6 _0xadf5ef62(GameObject _0x606ac2f0)
    {
        this._0x4b13730a = _0x606ac2f0;
        return this;
    }

    public void Show()
    {
        if (this._0x4b13730a != null)
        {
            this._0x4b13730a.SetActive(true);
        }
    }
}