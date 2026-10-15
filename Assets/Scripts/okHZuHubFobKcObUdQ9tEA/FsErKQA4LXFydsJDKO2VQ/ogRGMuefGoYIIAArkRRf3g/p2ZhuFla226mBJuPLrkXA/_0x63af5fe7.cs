using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x63af5fe7 : MonoBehaviour
{
    private void Start()
    {
        if (this.IsLoadCurrentScene)
            this.Button.onClick.AddListener(() =>
            {
                _0x05c8a753.Instance._0x8595e80b(SceneManager.GetActiveScene().buildIndex);
            });
        else
            this.Button.onClick.AddListener(() => _0x05c8a753.Instance._0x8595e80b(this.LoadSceneId));
    }

    public int LoadSceneId;
    public Button Button;
    private void Awake()
    {
        if (this.Button == null)
            if (!this.TryGetComponent(out this.Button))
                this.Button = this.GetComponentInChildren<Button>();
    }

    public bool IsLoadCurrentScene;
}