using UnityEngine;
using UnityEngine.UI;

public class _0xa3417428 : MonoBehaviour
{
    public int NextTutorialPanelIndex;
    public Button TutorialEndButton;
    public int EndTutorialPanelIndex = 1;
    public Button NextTutorialButton;
    private void Start()
    {
        if (this.NextTutorialButton != null)
        {
            if (this.IsTutorialEndPanel)
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xa62f9119.Instance._0x1e9b02f7(this.EndTutorialPanelIndex));
                this.NextTutorialButton.onClick.AddListener(() => _0x05c8a753.Instance._0xe0b5394f());
            }
            else
            {
                this.NextTutorialButton.onClick.AddListener(() => _0xa62f9119.Instance._0x1e9b02f7(this.NextTutorialPanelIndex));
            }
        }

        if (this.TutorialEndButton != null)
        {
            this.TutorialEndButton.onClick.AddListener(() => _0xa62f9119.Instance._0x1e9b02f7(this.EndTutorialPanelIndex));
            this.TutorialEndButton.onClick.AddListener(() => _0x05c8a753.Instance._0xe0b5394f());
        }
    }

    public bool IsTutorialEndPanel;
}