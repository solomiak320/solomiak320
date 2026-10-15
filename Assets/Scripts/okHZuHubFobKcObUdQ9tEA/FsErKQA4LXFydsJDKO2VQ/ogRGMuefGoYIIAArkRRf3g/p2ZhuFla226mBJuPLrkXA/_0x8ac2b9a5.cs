using UnityEngine;
using UnityEngine.UI;

public class _0x8ac2b9a5 : MonoBehaviour
{
    private void Awake()
    {
        if (this._0xbee7efc6 == null)
            if (!this.TryGetComponent(out this._0xbee7efc6))
                this._0xbee7efc6 = this.GetComponentInChildren<Button>();
    }

    private void Start()
    {
        if (this._0x282d0182)
            this._0xbee7efc6.onClick.AddListener(() => _0xa62f9119.Instance._0x6acffd98());
        else
            this._0xbee7efc6.onClick.AddListener(() => _0xa62f9119.Instance._0x1e9b02f7(this._0xef4c86b6));
    }

    private bool _0x282d0182;
    private Button _0xbee7efc6;
    private int _0xef4c86b6;
}