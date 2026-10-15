using UnityEngine;
using UnityEngine.UI;

public class _0x015cbce1 : MonoBehaviour
{
    private void Start()
    {
        this.Button.onClick.AddListener(() => _0x05c8a753.Instance._0x7c8c6e4a(this.IsPhysicsRunOnClick));
    }

    public bool IsPhysicsRunOnClick;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }
}