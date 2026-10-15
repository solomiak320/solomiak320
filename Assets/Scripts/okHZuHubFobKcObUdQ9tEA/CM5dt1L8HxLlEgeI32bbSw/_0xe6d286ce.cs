using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;
using static _0xc3dbd8a4;

public class _0xe6d286ce : MonoBehaviour
{
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0xe6d286ce>();
    }

    public List<_0x8f94dcac> Pops;
    public GameObject BlurBackground;
    public List<int> LastPopIndexes = new();
    private void BackgroundHidden()
    {
        this.BlurBackground.gameObject.SetActive(false);
    }

    public void _0x66cf3aa5(int _0x981026e1)
    {
        this.CurrentPopIndex = _0x981026e1;
        this.LastPopIndexes.Add(this.CurrentPopIndex);
        this._0x8b6d4c7b(true);
        this._0x60aa1638();
        this.Pops[_0x981026e1].Show();
        foreach (GameObject _0x1fdf7882 in this.GameObjectsToHide)
            _0x1fdf7882.SetActive(false);
    }

    public void _0x3f7e9f8e()
    {
        this.LastPopIndexes.RemoveAll(_0xe10579c2 => _0xe10579c2 == this.CurrentPopIndex);
        if (this.LastPopIndexes.Count <= 0)
            this._0x4f14b792();
        else
            this._0x66cf3aa5(this.LastPopIndexes.Last());
    }

    public int CurrentPopIndex;
    private void _0x8b6d4c7b(bool _0xf59a4797 = false)
    {
        for (int _0xda71f5b0 = 0; _0xda71f5b0 < this.Pops.Count; ++_0xda71f5b0)
            if (this.Pops[_0xda71f5b0] != null && !(_0xda71f5b0 == this.CurrentPopIndex && _0xf59a4797))
                this.Pops[_0xda71f5b0]._0x7f8bf8d1();
    }

    private void Start()
    {
        this.BackgroundHidden();
        foreach (_0x8f94dcac _0x26cf1da8 in this.Pops)
            if (_0x26cf1da8 != null)
                _0x26cf1da8.gameObject.SetActive(true);
    }

    public _0x8f94dcac _0x9f18a12f(int _0x5eb502f2)
    {
        return this.Pops[_0x5eb502f2];
    }

    public float ScaleDuration = 0.4f;
    private void _0x746ec763()
    {
        this.Invoke(nameof(this.BackgroundHidden), this.ScaleDuration);
    }

    public static _0xe6d286ce Instance;
    public List<GameObject> GameObjectsToHide;
    private void _0x60aa1638()
    {
        this.BlurBackground.gameObject.SetActive(true);
    }

    public void _0x4f14b792()
    {
        this.LastPopIndexes.Clear();
        this._0x8b6d4c7b();
        foreach (GameObject _0xf3ece67e in this.GameObjectsToHide)
            if (_0xf3ece67e != null)
                _0xf3ece67e.SetActive(true);
        this._0x746ec763();
    }
}