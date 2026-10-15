using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class _0x2f6bc10c : MonoBehaviour
{
    private bool _0xcbaa3716 => this.Content.transform.localScale.x > 0.5f && this.Content.transform.localScale.y > 0.5f;

    private void Awake()
    {
        this.Content.SetActive(true);
        if (this.OuterBackground != null)
            this.OuterBackground.gameObject.SetActive(true);
        if (this.IsScaledDownOnAwake)
            this._0x038622e2();
    }

    private void _0xc3c8fcde()
    {
        if (this.OuterBackground != null)
        {
            Image _0x0ac6fcb3 = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x0ac6fcb3, true);
            _0x0ac6fcb3.DOFade(1f, 0f);
        }
    }

    public void _0xe43762e6()
    {
        this._0x572af6a7();
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
        {
            this.Content.SetActive(false);
        });
    }

    public void Show()
    {
        this._0x657d65d3();
        if (this.Content != null)
        {
            DOTween.Kill(this.Content.transform, true);
            this.Content.SetActive(true);
            this.Content.transform.DOScale(1f, this.ScaleDuration).SetEase(this.Ease).OnComplete(() =>
            {
                _0xa62f9119.Instance._0x829276e1(_0xa62f9119.Instance.CurrentPanelIndex);
            });
        }
    }

    private void _0x657d65d3()
    {
        if (this.OuterBackground != null)
        {
            Image _0x4d42490f = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0x4d42490f, true);
            _0x4d42490f.DOFade(1f, this.ScaleDuration / 2f);
        }
    }

    public TMP_Text HeaderText;
    public GameObject Content;
    public void _0xed4eff13()
    {
        this._0xc3c8fcde();
        this.Content.SetActive(true);
        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.localScale = Vector3.one;
        _0xa62f9119.Instance._0x829276e1(_0xa62f9119.Instance.CurrentPanelIndex);
    }

    private void _0x572af6a7()
    {
        if (this.OuterBackground != null)
        {
            Image _0xae08682e = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xae08682e, true);
            _0xae08682e.DOFade(0f, this.ScaleDuration);
        }
    }

    public Ease Ease = Ease.OutSine;
    public TMP_Text MainText;
    public GameObject OuterBackground;
    public float ScaleDuration = 0.4f;
    private void _0x038622e2()
    {
        if (this.OuterBackground != null)
        {
            Image _0xea76109f = this.OuterBackground.GetComponent<Image>();
            DOTween.Kill(_0xea76109f, true);
            _0xea76109f.DOFade(0f, 0.01f);
        }

        DOTween.Kill(this.Content.transform, true);
        this.Content.transform.DOScale(0f, 0.01f);
    }

    public bool IsScaledDownOnAwake = true;
}