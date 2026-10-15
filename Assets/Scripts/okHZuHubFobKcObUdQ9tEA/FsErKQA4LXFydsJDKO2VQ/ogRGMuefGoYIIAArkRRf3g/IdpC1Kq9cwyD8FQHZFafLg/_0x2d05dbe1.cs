using TMPro;
using UnityEngine;
using static _0xc3dbd8a4;

public class _0x2d05dbe1 : MonoBehaviour
{
    public void _0xc84d5eb6()
    {
        this.MoneyCountText.text = _0x5833a5d8._0xe99fdd92.ToString();
    }

    public TMP_Text MoneyCountText;
    private void Start()
    {
        if (this.MoneyCountText == null)
        {
            TMP_Text _0x56cf0997;
            if (this.gameObject.TryGetComponent(out _0x56cf0997))
                this.MoneyCountText = _0x56cf0997;
        }

        this._0xc84d5eb6();
    }
}