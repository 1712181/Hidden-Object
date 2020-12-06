using UnityEngine;

[System.Serializable]

public class DialogueLine
{
    public Speaker speaker;
    [TextArea] 
    public string dialogue;

    public Sprite imageIntroCharacter;
    // public Texture2D imageIntroCharacter;
    public bool isIntroCharacter;
}
