using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class ToggleVideo : MonoBehaviour
{
    public GameObject plane;
    public VideoPlayer videoPlayer;
    public Button playVideoButton;
    public Sprite playSprite;
    public Sprite stopSprite;

    private Image playButtonImage;
    private bool isPlaying = false;

    void Start()
    {
        playButtonImage = playVideoButton.GetComponent<Image>();
    }

    public void Toggle()
    {
        if (isPlaying)
        {
            playButtonImage.sprite = playSprite;
            videoPlayer.Stop();
            plane.SetActive(false);

        }
        else
        {
            playButtonImage.sprite = stopSprite;
            plane.SetActive(true);
            videoPlayer.Play();

        }

        isPlaying = !isPlaying;
    }
}
