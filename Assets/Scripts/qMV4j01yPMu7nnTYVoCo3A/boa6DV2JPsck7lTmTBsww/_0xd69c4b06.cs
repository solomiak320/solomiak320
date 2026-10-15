using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0xd69c4b06 : MonoBehaviour
{
    private void _0x67ef7dda()
    {
        if (this._0xcd7ab653.canvasRenderer.GetColor() != this._0x21f60977.canvasRenderer.GetColor())
            this._0x21f60977.canvasRenderer.SetColor(this._0xcd7ab653.canvasRenderer.GetColor());
    }

    private TMP_Text _0x21f60977;
    private Image _0xcd7ab653;
    private void Update()
    {
        this._0x67ef7dda();
    }
}