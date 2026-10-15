using UnityEngine;

public class _0x9d1cdd19 : MonoBehaviour
{
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this.gameObject.GetComponent<_0x9d1cdd19>();
            DontDestroyOnLoad(this.gameObject);
            this._0x78437cbb();
        }
        else
        {
            this._0xaf02f85e();
            Destroy(this.gameObject);
        }
    }

    public bool IsSkipSplashEnabled;
    public bool IsTutorialEnabled;
    public bool IsTimerEnabled;
    public static _0x9d1cdd19 Instance;
    private void _0x78437cbb()
    {
        {
#if !B_LOGS
        {
            Debug.unityLogger.logEnabled = false;
            Application.SetStackTraceLogType(LogType.Assert, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Warning, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Error, StackTraceLogType.None);
            Application.SetStackTraceLogType(LogType.Log, StackTraceLogType.None);
        }
#endif
        }

        QualitySettings.vSyncCount = 1;
        Application.runInBackground = true;
    //Application.targetFrameRate = 60;
    // Time.fixedDeltaTime = 0.03f; // USE CUSTOM PHYSICS TIME FOR OPTIMIZATION IF NEEDED
    // Add this once at startup to silence the specific assertion
    }

    private void _0xaf02f85e()
    {
    }

    public bool IsCheckScoreEnabled;
    public bool IsStoryEnabled;
    public bool IsOnlyWinGameEndEnabled;
    public bool IsBestScoreEnabled;
    public bool IsLevelIncrementOnWin;
    public bool IsLevelSelectorEnabled;
}