using UnityEngine;

public class ScreenshotTaker : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F12))  // F12 키로 스크린샷
        {
            string filename = $"Screenshot_{System.DateTime.Now:yyyyMMdd_HHmmss}.png";
            ScreenCapture.CaptureScreenshot(filename);
            Debug.Log($"스크린샷 저장됨: {filename}");
        }
    }
}
