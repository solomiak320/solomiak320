using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class _0x222e2911 : MonoBehaviour
{
    private float _0xf5290b88 = 1;
    private Vector3 _0x8fbf4494 { get; set; }
    private Vector3 _0x1ca2720c { get; set; }

    private static _0x222e2911 _0xbf1f13f7;
    private Color _0x3824e873 = Color.white;
    private _0x6baf661a _0x7c5272a9 = _0x6baf661a.Portrait;
    private Vector3 _0x2349e8b2 { get; set; }
    private Vector3 _0x1ca93084 { get; set; }

    public enum _0x6baf661a
    {
        Landscape,
        Portrait
    }

    //public bool executeInUpdate;
    private float _0x0f02c621 { get; set; }

    private void OnDrawGizmos()
    {
        Gizmos.color = this._0x3824e873;
        Matrix4x4 _0x5208f72c = Gizmos.matrix;
        Gizmos.matrix = Matrix4x4.TRS(this.transform.position, this.transform.rotation, Vector3.one);
        if (this._0x4eeba3b5.orthographic)
        {
            float _0xfe2eed2c = this._0x4eeba3b5.farClipPlane - this._0x4eeba3b5.nearClipPlane;
            float _0xefb54747 = (this._0x4eeba3b5.farClipPlane + this._0x4eeba3b5.nearClipPlane) * 0.5f;
            Gizmos.DrawWireCube(new Vector3(0, 0, _0xefb54747), new Vector3(this._0x4eeba3b5.orthographicSize * 2 * this._0x4eeba3b5.aspect, this._0x4eeba3b5.orthographicSize * 2, _0xfe2eed2c));
        }
        else
        {
            Gizmos.DrawFrustum(Vector3.zero, this._0x4eeba3b5.fieldOfView, this._0x4eeba3b5.farClipPlane, this._0x4eeba3b5.nearClipPlane, this._0x4eeba3b5.aspect);
        }

        Gizmos.matrix = _0x5208f72c;
    }

    private void _0x71dd885e()
    {
        float _0xc027fde4, _0xa07d1ee2, _0x28c04608, _0x83a82de0;
        if (this._0x7c5272a9 == _0x6baf661a.Landscape)
            this._0x4eeba3b5.orthographicSize = 1f / this._0x4eeba3b5.aspect * this._0xf5290b88 / 2f;
        else
            this._0x4eeba3b5.orthographicSize = this._0xf5290b88 / 2f;
        this._0xf3425e5e = 2f * this._0x4eeba3b5.orthographicSize;
        this._0x0f02c621 = this._0xf3425e5e * this._0x4eeba3b5.aspect;
        float _0x2db75579 = this._0x4eeba3b5.transform.position.x;
        float _0xc05e9003 = this._0x4eeba3b5.transform.position.y;
        _0xc027fde4 = _0x2db75579 - this._0x0f02c621 / 2;
        _0xa07d1ee2 = _0x2db75579 + this._0x0f02c621 / 2;
        _0x28c04608 = _0xc05e9003 + this._0xf3425e5e / 2;
        _0x83a82de0 = _0xc05e9003 - this._0xf3425e5e / 2;
        this._0x6a538f4c = new Vector3(_0xc027fde4, _0x83a82de0, 0);
        this._0x234f63c1 = new Vector3(_0x2db75579, _0x83a82de0, 0);
        this._0x1cfc63c0 = new Vector3(_0xa07d1ee2, _0x83a82de0, 0);
        this._0x2349e8b2 = new Vector3(_0xc027fde4, _0xc05e9003, 0);
        this._0xd695263a = new Vector3(_0x2db75579, _0xc05e9003, 0);
        this._0x5da2be56 = new Vector3(_0xa07d1ee2, _0xc05e9003, 0);
        this._0x1ca2720c = new Vector3(_0xc027fde4, _0x28c04608, 0);
        this._0x8fbf4494 = new Vector3(_0x2db75579, _0x28c04608, 0);
        this._0x1ca93084 = new Vector3(_0xa07d1ee2, _0x28c04608, 0);
    }

    private new Camera _0x4eeba3b5;
    private void Awake()
    {
        this._0x4eeba3b5 = this.GetComponent<Camera>();
        _0xbf1f13f7 = this;
        this._0x71dd885e();
    }

    private Vector3 _0x234f63c1 { get; set; }
    private Vector3 _0x6a538f4c { get; set; }
    private Vector3 _0x5da2be56 { get; set; }
    private Vector3 _0x1cfc63c0 { get; set; }
    private Vector3 _0xd695263a { get; set; }
    private float _0xf3425e5e { get; set; }
}