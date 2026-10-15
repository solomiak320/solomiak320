using UnityEngine;
using UnityEngine.UI;

public class _0x24c60ddb : MonoBehaviour
{
    private void Start()
    {
        if (this.IsShowLastPop)
            this.Button.onClick.AddListener(() =>
            {
                _0xe6d286ce.Instance._0x3f7e9f8e();
            });
        else if (this.IsHideAllPops)
            this.Button.onClick.AddListener(() => _0xe6d286ce.Instance._0x4f14b792());
        else
            this.Button.onClick.AddListener(() => _0xe6d286ce.Instance._0x66cf3aa5(this.PopToShowIndex));
    }

    public Button Button;
    public int PopToShowIndex;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsShowLastPop;
    public bool IsHideAllPops;
}