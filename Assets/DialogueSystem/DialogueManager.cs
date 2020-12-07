using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class DialogueManager : MonoBehaviour
{
    public TextMeshProUGUI speakerName, dialogue, navButtonText;
    public Image speakerSprite;

    private int currentIndex;
    private Conversation currentConvo;
    private static DialogueManager instance;
    private Animator anim;
    public static GameObject startButton;
    public static GameObject navButton;

    private bool isIntroVideo;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;

            anim = GetComponent<Animator>();
            navButton = GameObject.Find("NavButton");
            navButton.SetActive(false);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public static void StartConversation(Conversation convo)
    {
        startButton = GameObject.Find("StartButton");
        startButton.SetActive(false);
        navButton.SetActive(true);

        instance.anim.SetBool("isOpen", true);
        instance.currentIndex = 0;
        instance.currentConvo = convo;
        instance.speakerName.text = "";
        instance.dialogue.text = "";
        instance.navButtonText.text = ">";

        instance.ReadNext();
    }

    public void ReadNext()
    {
        if (currentIndex > currentConvo.GetLength())
        {
            instance.anim.SetBool("isOpen", false);
            return;
        }

        isIntroVideo = currentConvo.GetLineByIndex(currentIndex).isIntroCharacter;
        var imageIntro = currentConvo.GetLineByIndex(currentIndex).imageIntroCharacter;
        Image img = GameObject.Find("Panel").GetComponent<Image>();
        img.sprite = imageIntro;

        if (isIntroVideo)
        {
            instance.anim.SetBool("isOpen", false);
            StartCoroutine(ShowImageIntro());
        }
        else
        {

            instance.anim.SetBool("isOpen", true);
            speakerName.text = currentConvo.GetLineByIndex(currentIndex).speaker.GetName();
            dialogue.text = currentConvo.GetLineByIndex(currentIndex).dialogue;
            speakerSprite.sprite = currentConvo.GetLineByIndex(currentIndex).speaker.GetSprite();
        }
        currentIndex++;
    }

    IEnumerator ShowImageIntro()
    {
        yield return new WaitForSeconds(5);
    }
}
