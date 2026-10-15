using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x8f94dcac : MonoBehaviour
{
    public TMP_Text ContentAdditionalText;
    private void Start()
    {
    // Content.SetActive(false);
    }

    public Ease ease = Ease.OutSine;
    public float scaleDuration = 0.4f;
    public void Show()
    {
        this.Content.SetActive(true);
        if ((DOTween.TweensByTarget(this.Content.transform)?.Count ?? 0) > 0)
            DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
        else
            this.Content.transform.DOScale(1f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
            {
            });
    }

    public bool IsOnlyYScale;
    public GameObject Content;
    public TMP_Text ContentHeaderText;
    public void _0x7f8bf8d1()
    {
        if (this.Content.gameObject.activeSelf)
        {
            DOTween.Kill(this.Content.transform, true);
            if (this.IsOnlyYScale)
                this.Content.transform.DOScaleY(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
            else
                this.Content.transform.DOScale(0f, this.scaleDuration).SetEase(this.ease).OnComplete(() =>
                {
                    this.Content.SetActive(false);
                });
        }
    }

    public Image ContentImage;
    private void _0x930df5c3()
    {
        DOTween.Kill(this.Content.transform, true);
        if (this.IsOnlyYScale)
            this.Content.transform.DOScaleY(0f, 0.01f);
        else
            this.Content.transform.DOScale(0f, 0.01f);
        this.Content.SetActive(false);
    }

    private bool _0x59956d02 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x930df5c3();
    }

    public bool IsScaledDownOnAwake = true;
    public TMP_Text ContentMainText;
    public static void HideAllPops()
    {
        _0xe6d286ce.Instance._0x4f14b792();
    }
}