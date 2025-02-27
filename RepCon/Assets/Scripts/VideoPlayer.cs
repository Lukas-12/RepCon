using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;
public class VideoController : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public bool isPaused = false;
    public string nextSceneName = "Scene1";
    void Start(){
        
         if (videoPlayer == null)
            videoPlayer = GetComponent<VideoPlayer>();

         //if (videoPlayer != null);
            
            //videoPlayer.loopPointReached += OnVideoEnd;
        
      
    }

    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            
            SceneManager.LoadScene(nextSceneName);
        
        }*/
        
    }
    
    /*void OnVideoEnd(VideoPlayer vp)
    {
        Debug.Log("Video ist zu Ende! Wechsel zur Szene...");
        SceneManager.LoadScene(nextSceneName);
    }
    */
}
