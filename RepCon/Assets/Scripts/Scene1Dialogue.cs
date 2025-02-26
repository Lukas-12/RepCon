using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.Video;

public class Scene1Dialogue : MonoBehaviour {
// These are the script variables.
// For more character images / buttons, copy & renumber the variables:
        public int primeInt = 0;        // This integer drives game progress!
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameObject hiddenButton;
        public GameObject currentVideo;
        private bool allowSpace = true;
        public TMP_Text lottispeech1;
        public TMP_Text speech1Text;
        public GameObject speech1;
        public TMP_Text speech2Text;
        public GameObject speech2;
        public TMP_Text speech3Text;
        public GameObject speech3;
        public TMP_Text speech4Text;
        public GameObject speech4;
        public TMP_Text speech5Text;
        public GameObject speech5;
        public VideoPlayer videoPlayer;
        public GameObject hiddenImage;
        public RawImage background;
        public GameObject lotti2Text;
        public VideoClip[] videoClips;
        public Texture[] images;
        private int videoIndex = 0;
        private int imageIndex = 0;

        void Start(){  
                
             NextScene1Button.SetActive(false);
             NextScene2Button.SetActive(false);
             nextButton.SetActive(false);
             hiddenButton.SetActive(false);
             lotti2Text.SetActive(false);
             speech1.SetActive(false);
             speech2.SetActive(false);
             speech3.SetActive(false);
             speech4.SetActive(false);
             speech5.SetActive(false);
             hiddenImage.SetActive(false);
             videoPlayer.clip = videoClips[videoIndex];
             currentVideo.SetActive(true);
             videoPlayer.loopPointReached += VideoEnd;
             background.gameObject.SetActive(false);
        
        }


        void Update(){        
             if (allowSpace == true){
                 if (Input.GetKeyDown("space")){
                        if(primeInt != 1){
                                 Next();
                        }
                     
                 }

                 // secret debug code: go back 1 Story Unit, if NEXT is visible
                 if (Input.GetKeyDown("p")) {
                      primeInt -= 2;
                      Next();
                 }
             }
        }

//Story Units! The main story function.
//Players hit [NEXT] to progress to the next primeInt:
public void Next(){
        primeInt += 1;
        Debug.Log("Current Prime: " + primeInt);
        if (primeInt == 1){
                videoPlayer.clip = videoClips[videoIndex];
                currentVideo.SetActive(true);
                
        }
        else if (primeInt == 2){
                UpdateBG();
                background.gameObject.SetActive(true);
                //SwStandNachEingangsvideo.SetActive(true);
                hiddenButton.SetActive(true);

                //DialogueDisplay.SetActive(true);
                //Char1name.text = "Lotti";
                //Char1speech.text = "Hello There";
                
        }
       else if (primeInt ==3){
                background.gameObject.SetActive(false);
                hiddenButton.SetActive(false);
                hiddenImage.SetActive(false);
                currentVideo.SetActive(true);
                videoPlayer.clip = videoClips[videoIndex];
                //Char1name.text = "Lotti";
                //Char1speech.text = "Whats up?";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
                UpdateBG();
                background.gameObject.SetActive(true);
                //BuntNachHoverBG.SetActive(true);
                nextButton.SetActive(true);
                //Char1name.text = "Lotti";
                //Char1speech.text = "Where i should go?";
                //nextButton.SetActive(false);
                //allowSpace = false;
                //NextScene1Button.SetActive(true);
                //NextScene2Button.SetActive(true);
       }else if (primeInt == 5){
                UpdateBG();
       }
       else if (primeInt == 6){
                UpdateBG();
                lotti2Text.SetActive(true);
                lottispeech1.text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet. Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.";
       }
       else if (primeInt == 7){
                UpdateBG();
                lotti2Text.SetActive(false);
       }
        else if (primeInt == 8){
                UpdateBG();
                
       }
        else if (primeInt == 9){
                UpdateBG();
                speech1.SetActive(true);
                speech1Text.text = "Lorem ipsum dolor sit amet,";
                
       }
       else if (primeInt == 10){
                UpdateBG();
                speech2.SetActive(true);
                speech2Text.text = "Lorem ipsum dolor sit amet, consetetur ";
                
       }
       else if (primeInt == 11){
                UpdateBG();
                speech3.SetActive(true);
                speech3Text.text = "Lorem ipsum dolor sit amet, consetetur";
                
       }
       else if (primeInt == 12){
                UpdateBG();
                speech4.SetActive(true);
                speech4Text.text = "Lorem ipsum dolor sit amet, consetetur sadipscing elitr,  diam voluptua.";
                
       }
       else if (primeInt == 13){
                UpdateBG();
                speech5.SetActive(true);
                speech5Text.text = "Lorem ipsum dolor sit amet, consetetur sadipscin oluptua.";
                
       }
       else if (primeInt == 14){
                background.gameObject.SetActive(false);
                nextButton.SetActive(false);
                videoPlayer.clip = videoClips[videoIndex];
                currentVideo.SetActive(true);
       }
       else if (primeInt == 15){
                speech1.SetActive(false);
                speech2.SetActive(false);
                speech3.SetActive(false);
                speech4.SetActive(false);
                speech5.SetActive(false);
                videoPlayer.clip = videoClips[videoIndex];
                currentVideo.SetActive(true);
       }

     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and SceneChanges)
        public void SceneChange1(){
               SceneManager.LoadScene("Scene2a");
        }
        public void SceneChange2(){
                SceneManager.LoadScene("Scene2b");
                 }

        public void HiddenButtonPressed(){
                Debug.Log("HiddenButton pressed!");
                Next();
        }
        
        public void VideoEnd(VideoPlayer vp){
                Debug.Log("Video end" + " Index: " + videoIndex);
                currentVideo.SetActive(false);
                videoIndex+=1;
                Next();
        }

        public void UpdateBG(){
                background.texture = images[imageIndex];
                imageIndex +=1;
        }
 
}