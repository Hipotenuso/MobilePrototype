using UnityEngine;

public class AnimationExemple : MonoBehaviour
{
    public Animation animationn;
    public AnimationClip run;
    public AnimationClip idle;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A))
        {
            PlayAnimation(run);
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            PlayAnimation(idle);
        }
    }

    private void PlayAnimation(AnimationClip c)
    {
        animationn.CrossFade(c.name);
    }
}
