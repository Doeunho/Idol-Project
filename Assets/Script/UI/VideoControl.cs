using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public RawImage rawImage;

    void Start()
    {
        if (videoPlayer == null || rawImage == null)
        {
            Debug.LogError("VideoPlayer �Ǵ� RawImage�� �Ҵ���� �ʾҽ��ϴ�.");
            return;
        }

        // VideoPlayer�� �̺�Ʈ�� �ݹ� �Լ� ���
        videoPlayer.loopPointReached += OnVideoEnd;

        // VideoPlayer�� ��� �ؽ�ó�� RawImage�� ����
        rawImage.texture = videoPlayer.texture;

        // ������ ��� ����
        videoPlayer.Play();
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // ������ ������ �� RawImage�� ��Ȱ��ȭ
        rawImage.gameObject.SetActive(false);
    }
}
