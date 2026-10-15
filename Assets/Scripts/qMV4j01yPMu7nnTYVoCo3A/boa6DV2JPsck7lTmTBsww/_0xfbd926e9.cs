using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public class _0xfbd926e9 : MonoBehaviour
{
    private List<string> _0x4048ad89 = new();
    private void Update()
    {
        int _0x6161c3ce = 1;
        if (this._0x4048ad89.Count > 0)
        {
            string _0xf96befd0 = this._0x721f9055.text;
            foreach (string _0x4d57a39e in this._0x4048ad89)
                while (_0xf96befd0.Contains(_0x4d57a39e))
                    _0xf96befd0 = _0xf96befd0.Replace(_0x4d57a39e, "");
            _0x6161c3ce = _0xf96befd0.Length;
        }
        else
        {
            _0x6161c3ce = this._0x721f9055.text.Length;
        }

        float _0x22ee9576 = Mathf.Clamp(this._0xa5721555 + this._0xfebf8477 * _0x6161c3ce, this._0x8144ae43, this._0x9be79c23);
        if (!Mathf.Approximately(this._0xeec8c4fb.aspectRatio, _0x22ee9576))
            this._0xeec8c4fb.aspectRatio = _0x22ee9576;
    }

    private float _0x9be79c23 = 4;
    private float _0xa5721555;
    private float _0xfebf8477 = 0.6f;
    private TMP_Text _0x721f9055;
    private float _0x8144ae43 = 1.5f;
    private AspectRatioFitter _0xeec8c4fb;
}