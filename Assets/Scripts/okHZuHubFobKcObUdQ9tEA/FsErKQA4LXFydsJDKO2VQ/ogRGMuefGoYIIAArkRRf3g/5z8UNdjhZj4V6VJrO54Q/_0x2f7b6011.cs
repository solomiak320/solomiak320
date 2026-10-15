using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class _0x2f7b6011 : MonoBehaviour
{
    public float SecondPassSliderValue = 0.5f;
    public void _0xf8368ed2()
    {
        this._0x192b27e0();
        bool _0xa756b557 = _0xfe9b8f22;
        this._0x008252ef = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xfd4a1079 => this.AnimationSlider.value = _0xfd4a1079, _0xa756b557 ? 1f : this.SecondPassSliderValue, this.DefaultAnimationTime)).SetEase(Ease.Linear);
        _0xfe9b8f22 = !_0xfe9b8f22;
    }

    public float DefaultAnimationTime = 0.4f;
    private Sequence _0x008252ef;
    public Slider AnimationSlider;
    public GameObject Content;
    public void _0xc0f39b9f()
    {
        this._0x008252ef?.Pause();
    }

    public void _0xbfa85505()
    {
        {
#if B_LOGS
            {
                Debug.Log($"[Test] Animate Force");
            }
#endif
        }

        this._0x008252ef?.Kill();
        if (AnimationSlider != null)
            this.AnimationSlider.value = 1f;
        _0xfe9b8f22 = false;
    }

    public GameObject Error;
    private void Awake()
    {
        Instance = this.gameObject.GetComponent<_0x2f7b6011>();
    }

    public void _0x61136c1f()
    {
        this._0x008252ef?.Play();
    }

    private void _0xe55eee88()
    {
        this.AnimationSlider.value = 0.05f;
        _0xfe9b8f22 = !_0xfe9b8f22;
        this._0x008252ef = DOTween.Sequence().Append(DOTween.To(() => this.AnimationSlider.value, _0xfd4a1079 => this.AnimationSlider.value = _0xfd4a1079, 1f, this.FirstAnimationTime)).SetEase(Ease.Linear).OnComplete(() =>
        {
            _0x2d0123df._0x35715d42?._0x782a7245();
        });
    }

    public void _0x192b27e0()
    {
        this._0x008252ef?.Kill();
        this.AnimationSlider.value = _0xfe9b8f22 ? this.SecondPassSliderValue : 0.05f;
    }

    public float FirstAnimationTime = 10.0f;
    private void Start()
    {
        if (SceneManager.GetActiveScene().buildIndex == _0xc3dbd8a4._0x28f4af65.SCENE_0 && !_0xfe9b8f22)
        {
            this._0xe55eee88();
        }
        else
        {
            this._0xf8368ed2();
        }
    }

    public static _0x2f7b6011 Instance;
    private static bool _0xfe9b8f22 = false;
    public GameObject Background;
}